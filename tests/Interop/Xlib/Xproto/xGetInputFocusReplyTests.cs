// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xproto.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="xGetInputFocusReply" /> struct.</summary>
    public static unsafe class xGetInputFocusReplyTests
    {
        /// <summary>Validates that the <see cref="xGetInputFocusReply" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<xGetInputFocusReply>(), Is.EqualTo(sizeof(xGetInputFocusReply)));
        }

        /// <summary>Validates that the <see cref="xGetInputFocusReply" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(xGetInputFocusReply).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="xGetInputFocusReply" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(xGetInputFocusReply), Is.EqualTo(32));
        }
    }
}
