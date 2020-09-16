// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct XImage
    {
        public int width;

        public int height;

        public int xoffset;

        public int format;

        [NativeTypeName("char *")]
        public sbyte* data;

        public int byte_order;

        public int bitmap_unit;

        public int bitmap_bit_order;

        public int bitmap_pad;

        public int depth;

        public int bytes_per_line;

        public int bits_per_pixel;

        [NativeTypeName("unsigned long")]
        public nuint red_mask;

        [NativeTypeName("unsigned long")]
        public nuint green_mask;

        [NativeTypeName("unsigned long")]
        public nuint blue_mask;

        [NativeTypeName("XPointer")]
        public sbyte* obdata;

        [NativeTypeName("struct funcs")]
        public funcs f;

        public partial struct funcs
        {
            [NativeTypeName("struct _XImage *(*)(struct _XDisplay *, Visual *, unsigned int, int, int, char *, unsigned int, unsigned int, int, int)")]
            public IntPtr create_image;

            [NativeTypeName("int (*)(struct _XImage *)")]
            public IntPtr destroy_image;

            [NativeTypeName("unsigned long (*)(struct _XImage *, int, int)")]
            public IntPtr get_pixel;

            [NativeTypeName("int (*)(struct _XImage *, int, int, unsigned long)")]
            public IntPtr put_pixel;

            [NativeTypeName("struct _XImage *(*)(struct _XImage *, int, int, unsigned int, unsigned int)")]
            public IntPtr sub_image;

            [NativeTypeName("int (*)(struct _XImage *, long)")]
            public IntPtr add_pixel;
        }
    }
}
