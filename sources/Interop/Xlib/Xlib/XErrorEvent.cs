// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct XErrorEvent
    {
        public int type;

        [NativeTypeName("Display *")]
        public UIntPtr display;

        [NativeTypeName("XID")]
        public UIntPtr resourceid;

        [NativeTypeName("unsigned long")]
        public UIntPtr serial;

        [NativeTypeName("unsigned char")]
        public byte error_code;

        [NativeTypeName("unsigned char")]
        public byte request_code;

        [NativeTypeName("unsigned char")]
        public byte minor_code;
    }
}
