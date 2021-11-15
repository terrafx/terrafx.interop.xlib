// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Xlib
{
    public unsafe partial struct XIMText
    {
        [NativeTypeName("unsigned short")]
        public ushort length;

        [NativeTypeName("XIMFeedback *")]
        public nuint* feedback;

        public int encoding_is_wchar;

        [NativeTypeName("union (anonymous union at /usr/include/X11/Xlib.h:1261:5)")]
        public _string_e__Union @string;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _string_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("char *")]
            public sbyte* multi_byte;

            [FieldOffset(0)]
            [NativeTypeName("wchar_t *")]
            public uint* wide_char;
        }
    }
}
