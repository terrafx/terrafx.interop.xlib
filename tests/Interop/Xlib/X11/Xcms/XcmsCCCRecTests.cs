// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xcms.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © Tektronix, Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Xlib.UnitTests;

/// <summary>Provides validation of the <see cref="XcmsCCCRec" /> struct.</summary>
public static unsafe partial class XcmsCCCRecTests
{
    /// <summary>Validates that the <see cref="XcmsCCCRec" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<XcmsCCCRec>(), Is.EqualTo(sizeof(XcmsCCCRec)));
    }

    /// <summary>Validates that the <see cref="XcmsCCCRec" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(XcmsCCCRec).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="XcmsCCCRec" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(XcmsCCCRec), Is.EqualTo(112));
        }
        else
        {
            Assert.That(sizeof(XcmsCCCRec), Is.EqualTo(80));
        }
    }
}
