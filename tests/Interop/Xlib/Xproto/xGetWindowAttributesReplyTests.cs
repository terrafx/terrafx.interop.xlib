// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xproto.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="xGetWindowAttributesReply" /> struct.</summary>
    public static unsafe class xGetWindowAttributesReplyTests
    {
        /// <summary>Validates that the <see cref="xGetWindowAttributesReply" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<xGetWindowAttributesReply>(), Is.EqualTo(sizeof(xGetWindowAttributesReply)));
        }

        /// <summary>Validates that the <see cref="xGetWindowAttributesReply" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(xGetWindowAttributesReply).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="xGetWindowAttributesReply" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(xGetWindowAttributesReply), Is.EqualTo(44));
        }
    }
}
