// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xcms.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © Tektronix, Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="XcmsFunctionSet" /> struct.</summary>
    public static unsafe class XcmsFunctionSetTests
    {
        /// <summary>Validates that the <see cref="XcmsFunctionSet" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<XcmsFunctionSet>(), Is.EqualTo(sizeof(XcmsFunctionSet)));
        }

        /// <summary>Validates that the <see cref="XcmsFunctionSet" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(XcmsFunctionSet).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="XcmsFunctionSet" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(XcmsFunctionSet), Is.EqualTo(24));
            }
            else
            {
                Assert.That(sizeof(XcmsFunctionSet), Is.EqualTo(16));
            }
        }
    }
}
