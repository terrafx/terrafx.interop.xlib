// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop
{
    public unsafe partial struct XErrorEvent
    {
        public int type;

        public Display* display;

        public XID resourceid;

        [NativeTypeName("unsigned long")]
        public nuint serial;

        [NativeTypeName("unsigned char")]
        public byte error_code;

        [NativeTypeName("unsigned char")]
        public byte request_code;

        [NativeTypeName("unsigned char")]
        public byte minor_code;
    }
}
