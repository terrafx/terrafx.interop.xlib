// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System;

namespace TerraFX.Interop.Xlib
{
    public unsafe partial struct Display
    {
        public XExtData* ext_data;

        [NativeTypeName("struct _XPrivate *")]
        public IntPtr private1;

        public int fd;

        public int private2;

        public int proto_major_version;

        public int proto_minor_version;

        [NativeTypeName("char *")]
        public sbyte* vendor;

        public XID private3;

        public XID private4;

        public XID private5;

        public int private6;

        [NativeTypeName("XID (*)(struct _XDisplay *)")]
        public delegate* unmanaged<Display*, XID> resource_alloc;

        public int byte_order;

        public int bitmap_unit;

        public int bitmap_pad;

        public int bitmap_bit_order;

        public int nformats;

        public ScreenFormat* pixmap_format;

        public int private8;

        public int release;

        [NativeTypeName("struct _XPrivate *")]
        public IntPtr private9;

        [NativeTypeName("struct _XPrivate *")]
        public IntPtr private10;

        public int qlen;

        [NativeTypeName("unsigned long")]
        public nuint last_request_read;

        [NativeTypeName("unsigned long")]
        public nuint request;

        [NativeTypeName("XPointer")]
        public sbyte* private11;

        [NativeTypeName("XPointer")]
        public sbyte* private12;

        [NativeTypeName("XPointer")]
        public sbyte* private13;

        [NativeTypeName("XPointer")]
        public sbyte* private14;

        [NativeTypeName("unsigned int")]
        public uint max_request_size;

        [NativeTypeName("struct _XrmHashBucketRec *")]
        public XrmHashBucket db;

        [NativeTypeName("int (*)(struct _XDisplay *)")]
        public delegate* unmanaged<Display*, int> private15;

        [NativeTypeName("char *")]
        public sbyte* display_name;

        public int default_screen;

        public int nscreens;

        public Screen* screens;

        [NativeTypeName("unsigned long")]
        public nuint motion_buffer;

        [NativeTypeName("unsigned long")]
        public nuint private16;

        public int min_keycode;

        public int max_keycode;

        [NativeTypeName("XPointer")]
        public sbyte* private17;

        [NativeTypeName("XPointer")]
        public sbyte* private18;

        public int private19;

        [NativeTypeName("char *")]
        public sbyte* xdefaults;
    }
}
