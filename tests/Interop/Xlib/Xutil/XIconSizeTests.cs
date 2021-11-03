// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xutil.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="XIconSize" /> struct.</summary>
    public static unsafe partial class XIconSizeTests
    {
        /// <summary>Validates that the <see cref="XIconSize" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<XIconSize>(), Is.EqualTo(sizeof(XIconSize)));
        }

        /// <summary>Validates that the <see cref="XIconSize" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(XIconSize).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="XIconSize" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(XIconSize), Is.EqualTo(24));
        }
    }
}
