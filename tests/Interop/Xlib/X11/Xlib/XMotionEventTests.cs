// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Xlib.UnitTests;

/// <summary>Provides validation of the <see cref="XMotionEvent" /> struct.</summary>
public static unsafe partial class XMotionEventTests
{
    /// <summary>Validates that the <see cref="XMotionEvent" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<XMotionEvent>(), Is.EqualTo(sizeof(XMotionEvent)));
    }

    /// <summary>Validates that the <see cref="XMotionEvent" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(XMotionEvent).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="XMotionEvent" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(XMotionEvent), Is.EqualTo(96));
        }
        else
        {
            Assert.That(sizeof(XMotionEvent), Is.EqualTo(60));
        }
    }
}
