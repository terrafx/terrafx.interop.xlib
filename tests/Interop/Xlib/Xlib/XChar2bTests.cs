// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="XChar2b" /> struct.</summary>
    public static unsafe class XChar2bTests
    {
        /// <summary>Validates that the <see cref="XChar2b" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<XChar2b>(), Is.EqualTo(sizeof(XChar2b)));
        }

        /// <summary>Validates that the <see cref="XChar2b" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(XChar2b).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="XChar2b" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(XChar2b), Is.EqualTo(2));
        }
    }
}
