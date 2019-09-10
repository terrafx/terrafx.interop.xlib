// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\Xutil.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group and Digital Equipment Corporation, Maynard, Massachusetts.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct XTextProperty
    {
        [NativeTypeName("unsigned char *")]
        public byte* value;

        [NativeTypeName("Atom")]
        public UIntPtr encoding;

        public int format;

        [NativeTypeName("unsigned long")]
        public UIntPtr nitems;
    }
}
