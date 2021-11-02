// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="XVisibilityEvent" /> struct.</summary>
    public static unsafe partial class XVisibilityEventTests
    {
        /// <summary>Validates that the <see cref="XVisibilityEvent" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<XVisibilityEvent>(), Is.EqualTo(sizeof(XVisibilityEvent)));
        }

        /// <summary>Validates that the <see cref="XVisibilityEvent" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(XVisibilityEvent).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="XVisibilityEvent" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(XVisibilityEvent), Is.EqualTo(48));
            }
            else
            {
                Assert.That(sizeof(XVisibilityEvent), Is.EqualTo(24));
            }
        }
    }
}
