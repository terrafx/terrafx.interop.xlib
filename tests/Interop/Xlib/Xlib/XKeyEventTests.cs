// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="XKeyEvent" /> struct.</summary>
    public static unsafe class XKeyEventTests
    {
        /// <summary>Validates that the <see cref="XKeyEvent" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<XKeyEvent>(), Is.EqualTo(sizeof(XKeyEvent)));
        }

        /// <summary>Validates that the <see cref="XKeyEvent" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(XKeyEvent).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="XKeyEvent" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(XKeyEvent), Is.EqualTo(96));
            }
            else
            {
                Assert.That(sizeof(XKeyEvent), Is.EqualTo(64));
            }
        }
    }
}
