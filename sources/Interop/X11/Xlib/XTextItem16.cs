// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct XTextItem16
    {
        [NativeTypeName("XChar2b *")]
        public XChar2b* chars;

        public int nchars;

        public int delta;

        [NativeTypeName("Font")]
        public UIntPtr font;
    }
}
