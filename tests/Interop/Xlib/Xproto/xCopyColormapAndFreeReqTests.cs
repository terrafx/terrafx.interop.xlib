// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xproto.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="xCopyColormapAndFreeReq" /> struct.</summary>
    public static unsafe class xCopyColormapAndFreeReqTests
    {
        /// <summary>Validates that the <see cref="xCopyColormapAndFreeReq" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<xCopyColormapAndFreeReq>(), Is.EqualTo(sizeof(xCopyColormapAndFreeReq)));
        }

        /// <summary>Validates that the <see cref="xCopyColormapAndFreeReq" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(xCopyColormapAndFreeReq).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="xCopyColormapAndFreeReq" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(xCopyColormapAndFreeReq), Is.EqualTo(12));
        }
    }
}
