// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xproto.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Xlib.UnitTests
{
    /// <summary>Provides validation of the <see cref="xListFontsWithInfoReply" /> struct.</summary>
    public static unsafe partial class xListFontsWithInfoReplyTests
    {
        /// <summary>Validates that the <see cref="xListFontsWithInfoReply" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<xListFontsWithInfoReply>(), Is.EqualTo(sizeof(xListFontsWithInfoReply)));
        }

        /// <summary>Validates that the <see cref="xListFontsWithInfoReply" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(xListFontsWithInfoReply).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="xListFontsWithInfoReply" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(xListFontsWithInfoReply), Is.EqualTo(60));
        }
    }
}
