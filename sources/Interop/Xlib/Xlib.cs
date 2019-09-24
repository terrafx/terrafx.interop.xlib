// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Xlib
    {
        private const string libraryPath = "libX11";

        static Xlib()
        {
            NativeLibrary.SetDllImportResolver(Assembly.GetExecutingAssembly(), ResolveLibrary);
        }

        private static IntPtr ResolveLibrary(string libraryName, Assembly assembly, DllImportSearchPath? searchPath)
        {
            if (!NativeLibrary.TryLoad("libX11.so", assembly, searchPath, out var nativeLibrary))
            {
                nativeLibrary = NativeLibrary.Load("libX11.so.6", assembly, searchPath);
            }

            return nativeLibrary;
        }
    }
}
