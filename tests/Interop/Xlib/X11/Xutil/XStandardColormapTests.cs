// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xutil.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Xlib.UnitTests;

/// <summary>Provides validation of the <see cref="XStandardColormap" /> struct.</summary>
public static unsafe partial class XStandardColormapTests
{
    /// <summary>Validates that the <see cref="XStandardColormap" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<XStandardColormap>(), Is.EqualTo(sizeof(XStandardColormap)));
    }

    /// <summary>Validates that the <see cref="XStandardColormap" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(XStandardColormap).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="XStandardColormap" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(XStandardColormap), Is.EqualTo(80));
        }
        else
        {
            Assert.That(sizeof(XStandardColormap), Is.EqualTo(40));
        }
    }
}
