// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="XEvent" /> struct.</summary>
    public static unsafe class XEventTests
    {
        /// <summary>Validates that the <see cref="XEvent" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<XEvent>(), Is.EqualTo(sizeof(XEvent)));
        }

        /// <summary>Validates that the <see cref="XEvent" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutExplicitTest()
        {
            Assert.That(typeof(XEvent).IsExplicitLayout, Is.True);
        }

        /// <summary>Validates that the <see cref="XEvent" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(XEvent), Is.EqualTo(192));
            }
            else
            {
                Assert.That(sizeof(XEvent), Is.EqualTo(96));
            }
        }
    }
}
