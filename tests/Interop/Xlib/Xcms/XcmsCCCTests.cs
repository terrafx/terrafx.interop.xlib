// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xcms.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © Tektronix, Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="XcmsCCC" /> struct.</summary>
    public static unsafe class XcmsCCCTests
    {
        /// <summary>Validates that the <see cref="XcmsCCC" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<XcmsCCC>(), Is.EqualTo(sizeof(XcmsCCC)));
        }

        /// <summary>Validates that the <see cref="XcmsCCC" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(XcmsCCC).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="XcmsCCC" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(XcmsCCC), Is.EqualTo(112));
            }
            else
            {
                Assert.That(sizeof(XcmsCCC), Is.EqualTo(80));
            }
        }
    }
}
