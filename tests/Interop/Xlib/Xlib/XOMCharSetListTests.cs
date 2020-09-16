// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="XOMCharSetList" /> struct.</summary>
    public static unsafe class XOMCharSetListTests
    {
        /// <summary>Validates that the <see cref="XOMCharSetList" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<XOMCharSetList>(), Is.EqualTo(sizeof(XOMCharSetList)));
        }

        /// <summary>Validates that the <see cref="XOMCharSetList" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(XOMCharSetList).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="XOMCharSetList" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(XOMCharSetList), Is.EqualTo(16));
            }
            else
            {
                Assert.That(sizeof(XOMCharSetList), Is.EqualTo(8));
            }
        }
    }
}
