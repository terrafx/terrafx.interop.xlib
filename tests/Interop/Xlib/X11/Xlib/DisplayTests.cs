// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Xlib.UnitTests;

/// <summary>Provides validation of the <see cref="Display" /> struct.</summary>
public static unsafe partial class DisplayTests
{
    /// <summary>Validates that the <see cref="Display" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<Display>(), Is.EqualTo(sizeof(Display)));
    }

    /// <summary>Validates that the <see cref="Display" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(Display).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="Display" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(Display), Is.EqualTo(296));
        }
        else
        {
            Assert.That(sizeof(Display), Is.EqualTo(176));
        }
    }
}
