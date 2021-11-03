// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="XServerInterpretedAddress" /> struct.</summary>
    public static unsafe partial class XServerInterpretedAddressTests
    {
        /// <summary>Validates that the <see cref="XServerInterpretedAddress" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<XServerInterpretedAddress>(), Is.EqualTo(sizeof(XServerInterpretedAddress)));
        }

        /// <summary>Validates that the <see cref="XServerInterpretedAddress" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(XServerInterpretedAddress).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="XServerInterpretedAddress" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(XServerInterpretedAddress), Is.EqualTo(24));
            }
            else
            {
                Assert.That(sizeof(XServerInterpretedAddress), Is.EqualTo(16));
            }
        }
    }
}
