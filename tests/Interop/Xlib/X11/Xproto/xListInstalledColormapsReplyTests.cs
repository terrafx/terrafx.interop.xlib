// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xproto.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Xlib.UnitTests
{
    /// <summary>Provides validation of the <see cref="xListInstalledColormapsReply" /> struct.</summary>
    public static unsafe partial class xListInstalledColormapsReplyTests
    {
        /// <summary>Validates that the <see cref="xListInstalledColormapsReply" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<xListInstalledColormapsReply>(), Is.EqualTo(sizeof(xListInstalledColormapsReply)));
        }

        /// <summary>Validates that the <see cref="xListInstalledColormapsReply" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(xListInstalledColormapsReply).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="xListInstalledColormapsReply" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(xListInstalledColormapsReply), Is.EqualTo(32));
        }
    }
}
