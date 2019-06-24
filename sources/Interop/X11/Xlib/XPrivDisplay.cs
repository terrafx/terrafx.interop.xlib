// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct XPrivDisplay
    {
        [NativeTypeName("XExtData *")]
        public XExtData* ext_data;

        [NativeTypeName("struct XPrivate *")]
        public XPrivate* private1;

        public int fd;

        public int private2;

        public int proto_major_version;

        public int proto_minor_version;

        [NativeTypeName("char *")]
        public sbyte* vendor;

        [NativeTypeName("XID")]
        public UIntPtr private3;

        [NativeTypeName("XID")]
        public UIntPtr private4;

        [NativeTypeName("XID")]
        public UIntPtr private5;

        public int private6;

        [NativeTypeName("XID (*)(struct XDisplay *)")]
        public IntPtr resource_alloc;

        public int byte_order;

        public int bitmap_unit;

        public int bitmap_pad;

        public int bitmap_bit_order;

        public int nformats;

        [NativeTypeName("ScreenFormat *")]
        public ScreenFormat* pixmap_format;

        public int private8;

        public int release;

        [NativeTypeName("struct XPrivate *")]
        public XPrivate* private9;

        [NativeTypeName("struct XPrivate *")]
        public XPrivate* private10;

        public int qlen;

        [NativeTypeName("unsigned long")]
        public UIntPtr last_request_read;

        [NativeTypeName("unsigned long")]
        public UIntPtr request;

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

        [NativeTypeName("struct XrmHashBucketRec *")]
        public XrmHashBucketRec* db;

        [NativeTypeName("int (*)(struct XDisplay *)")]
        public IntPtr private15;

        [NativeTypeName("char *")]
        public sbyte* display_name;

        public int default_screen;

        public int nscreens;

        [NativeTypeName("Screen *")]
        public Screen* screens;

        [NativeTypeName("unsigned long")]
        public UIntPtr motion_buffer;

        [NativeTypeName("unsigned long")]
        public UIntPtr private16;

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
