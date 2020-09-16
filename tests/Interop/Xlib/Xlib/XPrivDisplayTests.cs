// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="XPrivDisplay" /> struct.</summary>
    public static unsafe class XPrivDisplayTests
    {
        /// <summary>Validates that the <see cref="XPrivDisplay" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<XPrivDisplay>(), Is.EqualTo(sizeof(XPrivDisplay)));
        }

        /// <summary>Validates that the <see cref="XPrivDisplay" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(XPrivDisplay).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="XPrivDisplay" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(XPrivDisplay), Is.EqualTo(296));
            }
            else
            {
                Assert.That(sizeof(XPrivDisplay), Is.EqualTo(176));
            }
        }
    }
}
