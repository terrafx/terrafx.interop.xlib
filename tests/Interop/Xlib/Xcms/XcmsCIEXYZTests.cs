// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xcms.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © Tektronix, Inc.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="XcmsCIEXYZ" /> struct.</summary>
    public static unsafe partial class XcmsCIEXYZTests
    {
        /// <summary>Validates that the <see cref="XcmsCIEXYZ" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<XcmsCIEXYZ>(), Is.EqualTo(sizeof(XcmsCIEXYZ)));
        }

        /// <summary>Validates that the <see cref="XcmsCIEXYZ" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(XcmsCIEXYZ).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="XcmsCIEXYZ" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(XcmsCIEXYZ), Is.EqualTo(24));
        }
    }
}
