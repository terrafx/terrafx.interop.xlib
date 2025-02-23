// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

[assembly: DefaultDllImportSearchPaths(DllImportSearchPath.SafeDirectories)]

namespace TerraFX.Interop.Xlib;

public static unsafe partial class Xlib
{
    /// <summary>Raised whenever a native library is loaded by TerraFX.Interop.Xlib. Handlers can be added to this event to customize how libraries are loaded, and they will be used first whenever a new native library is being resolved.</summary>
    public static event DllImportResolver? ResolveLibrary;

    static Xlib()
    {
        if (!Configuration.DisableResolveLibraryHook)
        {
            NativeLibrary.SetDllImportResolver(Assembly.GetExecutingAssembly(), OnDllImport);
        }
    }

    /// <summary>The default <see cref="DllImportResolver"/> for TerraFX.Interop.Xlib.</summary>
    /// <inheritdoc cref="DllImportResolver"/>
    private static IntPtr OnDllImport(string libraryName, Assembly assembly, DllImportSearchPath? searchPath)
    {
        if (TryResolveLibrary(libraryName, assembly, searchPath, out var nativeLibrary))
        {
            return nativeLibrary;
        }

        if (libraryName.Equals("libX11", StringComparison.OrdinalIgnoreCase) && TryResolveLibX11(assembly, searchPath, out nativeLibrary))
        {
            return nativeLibrary;
        }

        return 0;
    }

    private static bool TryResolveLibX11(Assembly assembly, DllImportSearchPath? searchPath, out IntPtr nativeLibrary)
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            if (NativeLibrary.TryLoad("libX11.so.6", assembly, searchPath, out nativeLibrary))
            {
                return true;
            }
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
        {
            if (NativeLibrary.TryLoad("libX11.6.dylib", assembly, searchPath, out nativeLibrary))
            {
                return true;
            }
        }

        return NativeLibrary.TryLoad("libX11", assembly, searchPath, out nativeLibrary);
    }

    private static bool TryResolveLibrary(string libraryName, Assembly assembly, DllImportSearchPath? searchPath, out IntPtr nativeLibrary)
    {
        var resolveLibrary = ResolveLibrary;

        if (resolveLibrary is not null)
        {
            var resolvers = resolveLibrary.GetInvocationList();

            foreach (DllImportResolver resolver in resolvers.Cast<DllImportResolver>())
            {
                nativeLibrary = resolver(libraryName, assembly, searchPath);

                if (nativeLibrary != 0)
                {
                    return true;
                }
            }
        }

        nativeLibrary = 0;
        return false;
    }
}
