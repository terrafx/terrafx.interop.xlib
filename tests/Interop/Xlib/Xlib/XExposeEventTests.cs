// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="XExposeEvent" /> struct.</summary>
    public static unsafe partial class XExposeEventTests
    {
        /// <summary>Validates that the <see cref="XExposeEvent" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<XExposeEvent>(), Is.EqualTo(sizeof(XExposeEvent)));
        }

        /// <summary>Validates that the <see cref="XExposeEvent" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(XExposeEvent).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="XExposeEvent" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(XExposeEvent), Is.EqualTo(64));
            }
            else
            {
                Assert.That(sizeof(XExposeEvent), Is.EqualTo(40));
            }
        }
    }
}
