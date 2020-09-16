// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xprotostr.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="xRectangle" /> struct.</summary>
    public static unsafe class xRectangleTests
    {
        /// <summary>Validates that the <see cref="xRectangle" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<xRectangle>(), Is.EqualTo(sizeof(xRectangle)));
        }

        /// <summary>Validates that the <see cref="xRectangle" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(xRectangle).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="xRectangle" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(xRectangle), Is.EqualTo(8));
        }
    }
}
