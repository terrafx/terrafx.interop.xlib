// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="XDestroyWindowEvent" /> struct.</summary>
    public static unsafe partial class XDestroyWindowEventTests
    {
        /// <summary>Validates that the <see cref="XDestroyWindowEvent" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<XDestroyWindowEvent>(), Is.EqualTo(sizeof(XDestroyWindowEvent)));
        }

        /// <summary>Validates that the <see cref="XDestroyWindowEvent" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(XDestroyWindowEvent).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="XDestroyWindowEvent" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(XDestroyWindowEvent), Is.EqualTo(48));
            }
            else
            {
                Assert.That(sizeof(XDestroyWindowEvent), Is.EqualTo(24));
            }
        }
    }
}
