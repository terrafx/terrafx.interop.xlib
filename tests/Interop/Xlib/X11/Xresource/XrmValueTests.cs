// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xresource.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Xlib.UnitTests
{
    /// <summary>Provides validation of the <see cref="XrmValue" /> struct.</summary>
    public static unsafe partial class XrmValueTests
    {
        /// <summary>Validates that the <see cref="XrmValue" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<XrmValue>(), Is.EqualTo(sizeof(XrmValue)));
        }

        /// <summary>Validates that the <see cref="XrmValue" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(XrmValue).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="XrmValue" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(XrmValue), Is.EqualTo(16));
            }
            else
            {
                Assert.That(sizeof(XrmValue), Is.EqualTo(8));
            }
        }
    }
}
