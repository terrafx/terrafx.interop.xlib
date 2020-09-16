// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xproto.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="xCreatePixmapReq" /> struct.</summary>
    public static unsafe class xCreatePixmapReqTests
    {
        /// <summary>Validates that the <see cref="xCreatePixmapReq" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<xCreatePixmapReq>(), Is.EqualTo(sizeof(xCreatePixmapReq)));
        }

        /// <summary>Validates that the <see cref="xCreatePixmapReq" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(xCreatePixmapReq).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="xCreatePixmapReq" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(xCreatePixmapReq), Is.EqualTo(16));
        }
    }
}
