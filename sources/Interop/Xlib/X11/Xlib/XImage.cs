// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop.Xlib;

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

    public unsafe partial struct funcs
    {
        [NativeTypeName("struct _XImage *(*)(struct _XDisplay *, Visual *, unsigned int, int, int, char *, unsigned int, unsigned int, int, int)")]
        public delegate* unmanaged<Display*, Visual*, uint, int, int, sbyte*, uint, uint, int, int, XImage*> create_image;

        [NativeTypeName("int (*)(struct _XImage *)")]
        public delegate* unmanaged<XImage*, int> destroy_image;

        [NativeTypeName("unsigned long (*)(struct _XImage *, int, int)")]
        public delegate* unmanaged<XImage*, int, int, nuint> get_pixel;

        [NativeTypeName("int (*)(struct _XImage *, int, int, unsigned long)")]
        public delegate* unmanaged<XImage*, int, int, nuint, int> put_pixel;

        [NativeTypeName("struct _XImage *(*)(struct _XImage *, int, int, unsigned int, unsigned int)")]
        public delegate* unmanaged<XImage*, int, int, uint, uint, XImage*> sub_image;

        [NativeTypeName("int (*)(struct _XImage *, long)")]
        public delegate* unmanaged<XImage*, nint, int> add_pixel;
    }
}
