// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.InteropServices;
using NUnit.Framework;

#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable CA1031  // Do not catch general exception types
#pragma warning disable IL2026  // Members attributed with RequiresUnreferencedCode may break when trimming
#pragma warning disable IL2072  // 'target parameter' argument does not satisfy 'DynamicallyAccessedMembersAttribute' in call to 'target method'

namespace TerraFX.Interop.Xlib.UnitTests;

/// <summary>Provides validation that the <see cref="DllImportAttribute" /> attributed methods can be resolved.</summary>
public static unsafe partial class ResolveDllImportTests
{
    /// <summary>Validates that the <see cref="DllImportAttribute" /> attributed methods can be resolved.</summary>
    [Test]
    [Platform("Linux")]
    public static void ResolveDllImportTest()
    {
        Assert.Multiple(() => {
            var assembly = typeof(Xlib).Assembly;
            ProcessAssembly(assembly);
        });
    }

    private static void ProcessAssembly(Assembly assembly)
    {
        var unresolved = new List<string>();

        foreach (var type in assembly.GetTypes())
        {
            ProcessType(type, unresolved);
        }

        Assert.That(unresolved, Is.Empty);
    }

#pragma warning disable CA1031 // Do not catch general exception types
    private static void ProcessMethod(MethodInfo method, List<string> unresolved)
    {
        if (!method.Attributes.HasFlag(MethodAttributes.PinvokeImpl))
        {
            return;
        }

        try
        {
            Marshal.Prelink(method);
        }
        catch
        {
            unresolved.Add(method.Name);
        }
    }
#pragma warning restore CA1031 // Do not catch general exception types

    private static void ProcessType([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods | DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes)] Type type, List<string> unresolved)
    {
        foreach (var method in type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static))
        {
            ProcessMethod(method, unresolved);
        }

        foreach (var nestedType in type.GetNestedTypes(BindingFlags.Public | BindingFlags.NonPublic))
        {
            ProcessType(nestedType, unresolved);
        }
    }
}
