// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Xlib.UnitTests;

/// <summary>Provides validation of the <see cref="XFontSetExtents" /> struct.</summary>
public static unsafe partial class XFontSetExtentsTests
{
    /// <summary>Validates that the <see cref="XFontSetExtents" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<XFontSetExtents>(), Is.EqualTo(sizeof(XFontSetExtents)));
    }

    /// <summary>Validates that the <see cref="XFontSetExtents" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(XFontSetExtents).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="XFontSetExtents" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(XFontSetExtents), Is.EqualTo(16));
    }
}
