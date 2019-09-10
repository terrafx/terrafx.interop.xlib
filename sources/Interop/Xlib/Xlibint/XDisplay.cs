// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\Xlibint.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct XDisplay
    {
        [NativeTypeName("XExtData *")]
        public XExtData* ext_data;

        [NativeTypeName("struct XFreeFuncs *")]
        public XFreeFuncs* free_funcs;

        public int fd;

        public int conn_checker;

        public int proto_major_version;

        public int proto_minor_version;

        [NativeTypeName("char *")]
        public sbyte* vendor;

        [NativeTypeName("XID")]
        public UIntPtr resource_base;

        [NativeTypeName("XID")]
        public UIntPtr resource_mask;

        [NativeTypeName("XID")]
        public UIntPtr resource_id;

        public int resource_shift;

        [NativeTypeName("XID (*)(struct XDisplay *)")]
        public IntPtr resource_alloc;

        public int byte_order;

        public int bitmap_unit;

        public int bitmap_pad;

        public int bitmap_bit_order;

        public int nformats;

        [NativeTypeName("ScreenFormat *")]
        public ScreenFormat* pixmap_format;

        public int vnumber;

        public int release;

        [NativeTypeName("struct XSQEvent *")]
        public XSQEvent* head;

        [NativeTypeName("struct XSQEvent *")]
        public XSQEvent* tail;

        public int qlen;

        [NativeTypeName("unsigned long")]
        public UIntPtr last_request_read;

        [NativeTypeName("unsigned long")]
        public UIntPtr request;

        [NativeTypeName("char *")]
        public sbyte* last_req;

        [NativeTypeName("char *")]
        public sbyte* buffer;

        [NativeTypeName("char *")]
        public sbyte* bufptr;

        [NativeTypeName("char *")]
        public sbyte* bufmax;

        [NativeTypeName("unsigned int")]
        public uint max_request_size;

        [NativeTypeName("struct XrmHashBucketRec *")]
        public XrmHashBucketRec* db;

        [NativeTypeName("int (*)(struct XDisplay *)")]
        public IntPtr synchandler;

        [NativeTypeName("char *")]
        public sbyte* display_name;

        public int default_screen;

        public int nscreens;

        [NativeTypeName("Screen *")]
        public Screen* screens;

        [NativeTypeName("unsigned long")]
        public UIntPtr motion_buffer;

        [NativeTypeName("volatile unsigned long")]
        public UIntPtr flags;

        public int min_keycode;

        public int max_keycode;

        [NativeTypeName("KeySym *")]
        public UIntPtr* keysyms;

        [NativeTypeName("XModifierKeymap *")]
        public XModifierKeymap* modifiermap;

        public int keysyms_per_keycode;

        [NativeTypeName("char *")]
        public sbyte* xdefaults;

        [NativeTypeName("char *")]
        public sbyte* scratch_buffer;

        [NativeTypeName("unsigned long")]
        public UIntPtr scratch_length;

        public int ext_number;

        [NativeTypeName("struct XExten *")]
        public XExten* ext_procs;

        [NativeTypeName("int (*[128])(Display *, XEvent *, xEvent *)")]
        public _event_vec_e__FixedBuffer event_vec;

        [NativeTypeName("int (*[128])(Display *, XEvent *, xEvent *)")]
        public _wire_vec_e__FixedBuffer wire_vec;

        [NativeTypeName("KeySym")]
        public UIntPtr lock_meaning;

        [NativeTypeName("struct XLockInfo *")]
        public XLockInfo* @lock;

        [NativeTypeName("struct XInternalAsync *")]
        public XInternalAsync* async_handlers;

        [NativeTypeName("unsigned long")]
        public UIntPtr bigreq_size;

        [NativeTypeName("struct XLockPtrs *")]
        public XLockPtrs* lock_fns;

        [NativeTypeName("void (*)(Display *, XID *, int)")]
        public IntPtr idlist_alloc;

        [NativeTypeName("struct XKeytrans *")]
        public XKeytrans* key_bindings;

        [NativeTypeName("Font")]
        public UIntPtr cursor_font;

        [NativeTypeName("struct XDisplayAtoms *")]
        public XDisplayAtoms* atoms;

        [NativeTypeName("unsigned int")]
        public uint mode_switch;

        [NativeTypeName("unsigned int")]
        public uint num_lock;

        [NativeTypeName("struct XContextDB *")]
        public XContextDB* context_db;

        [NativeTypeName("int (**)(Display *, XErrorEvent *, xError *)")]
        public IntPtr* error_vec;

        [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xlibint.h:164:2)")]
        public _cms__AnonymousRecord cms;

        [NativeTypeName("struct XIMFilter *")]
        public XIMFilter* im_filters;

        [NativeTypeName("struct XSQEvent *")]
        public XSQEvent* qfree;

        [NativeTypeName("unsigned long")]
        public UIntPtr next_event_serial_num;

        [NativeTypeName("struct XExten *")]
        public XExten* flushes;

        [NativeTypeName("struct XConnectionInfo *")]
        public XConnectionInfo* im_fd_info;

        public int im_fd_length;

        [NativeTypeName("struct XConnWatchInfo *")]
        public XConnWatchInfo* conn_watchers;

        public int watcher_count;

        [NativeTypeName("XPointer")]
        public sbyte* filedes;

        [NativeTypeName("int (*)(Display *)")]
        public IntPtr savedsynchandler;

        [NativeTypeName("XID")]
        public UIntPtr resource_max;

        public int xcmisc_opcode;

        [NativeTypeName("struct XkbInfoRec *")]
        public XkbInfoRec* xkb_info;

        [NativeTypeName("struct XtransConnInfo *")]
        public XtransConnInfo* trans_conn;

        [NativeTypeName("struct X11XCBPrivate *")]
        public X11XCBPrivate* xcb;

        [NativeTypeName("unsigned int")]
        public uint next_cookie;

        [NativeTypeName("int (*[128])(Display *, XGenericEventCookie *, xEvent *)")]
        public _generic_event_vec_e__FixedBuffer generic_event_vec;

        [NativeTypeName("int (*[128])(Display *, XGenericEventCookie *, XGenericEventCookie *)")]
        public _generic_event_copy_vec_e__FixedBuffer generic_event_copy_vec;

        [NativeTypeName("void *")]
        public void* cookiejar;

        public partial struct XLockInfo
        {
        }

        public partial struct XKeytrans
        {
        }

        public partial struct XDisplayAtoms
        {
        }

        public partial struct XContextDB
        {
        }

        public unsafe partial struct _cms__AnonymousRecord
        {
            [NativeTypeName("XPointer")]
            public sbyte* defaultCCCs;

            [NativeTypeName("XPointer")]
            public sbyte* clientCmaps;

            [NativeTypeName("XPointer")]
            public sbyte* perVisualIntensityMaps;
        }

        public partial struct XIMFilter
        {
        }

        public partial struct XkbInfoRec
        {
        }

        public partial struct XtransConnInfo
        {
        }

        public partial struct X11XCBPrivate
        {
        }

        public partial struct _event_vec_e__FixedBuffer
        {
            internal IntPtr e0;
            internal IntPtr e1;
            internal IntPtr e2;
            internal IntPtr e3;
            internal IntPtr e4;
            internal IntPtr e5;
            internal IntPtr e6;
            internal IntPtr e7;
            internal IntPtr e8;
            internal IntPtr e9;
            internal IntPtr e10;
            internal IntPtr e11;
            internal IntPtr e12;
            internal IntPtr e13;
            internal IntPtr e14;
            internal IntPtr e15;
            internal IntPtr e16;
            internal IntPtr e17;
            internal IntPtr e18;
            internal IntPtr e19;
            internal IntPtr e20;
            internal IntPtr e21;
            internal IntPtr e22;
            internal IntPtr e23;
            internal IntPtr e24;
            internal IntPtr e25;
            internal IntPtr e26;
            internal IntPtr e27;
            internal IntPtr e28;
            internal IntPtr e29;
            internal IntPtr e30;
            internal IntPtr e31;
            internal IntPtr e32;
            internal IntPtr e33;
            internal IntPtr e34;
            internal IntPtr e35;
            internal IntPtr e36;
            internal IntPtr e37;
            internal IntPtr e38;
            internal IntPtr e39;
            internal IntPtr e40;
            internal IntPtr e41;
            internal IntPtr e42;
            internal IntPtr e43;
            internal IntPtr e44;
            internal IntPtr e45;
            internal IntPtr e46;
            internal IntPtr e47;
            internal IntPtr e48;
            internal IntPtr e49;
            internal IntPtr e50;
            internal IntPtr e51;
            internal IntPtr e52;
            internal IntPtr e53;
            internal IntPtr e54;
            internal IntPtr e55;
            internal IntPtr e56;
            internal IntPtr e57;
            internal IntPtr e58;
            internal IntPtr e59;
            internal IntPtr e60;
            internal IntPtr e61;
            internal IntPtr e62;
            internal IntPtr e63;
            internal IntPtr e64;
            internal IntPtr e65;
            internal IntPtr e66;
            internal IntPtr e67;
            internal IntPtr e68;
            internal IntPtr e69;
            internal IntPtr e70;
            internal IntPtr e71;
            internal IntPtr e72;
            internal IntPtr e73;
            internal IntPtr e74;
            internal IntPtr e75;
            internal IntPtr e76;
            internal IntPtr e77;
            internal IntPtr e78;
            internal IntPtr e79;
            internal IntPtr e80;
            internal IntPtr e81;
            internal IntPtr e82;
            internal IntPtr e83;
            internal IntPtr e84;
            internal IntPtr e85;
            internal IntPtr e86;
            internal IntPtr e87;
            internal IntPtr e88;
            internal IntPtr e89;
            internal IntPtr e90;
            internal IntPtr e91;
            internal IntPtr e92;
            internal IntPtr e93;
            internal IntPtr e94;
            internal IntPtr e95;
            internal IntPtr e96;
            internal IntPtr e97;
            internal IntPtr e98;
            internal IntPtr e99;
            internal IntPtr e100;
            internal IntPtr e101;
            internal IntPtr e102;
            internal IntPtr e103;
            internal IntPtr e104;
            internal IntPtr e105;
            internal IntPtr e106;
            internal IntPtr e107;
            internal IntPtr e108;
            internal IntPtr e109;
            internal IntPtr e110;
            internal IntPtr e111;
            internal IntPtr e112;
            internal IntPtr e113;
            internal IntPtr e114;
            internal IntPtr e115;
            internal IntPtr e116;
            internal IntPtr e117;
            internal IntPtr e118;
            internal IntPtr e119;
            internal IntPtr e120;
            internal IntPtr e121;
            internal IntPtr e122;
            internal IntPtr e123;
            internal IntPtr e124;
            internal IntPtr e125;
            internal IntPtr e126;
            internal IntPtr e127;

            public unsafe ref IntPtr this[int index]
            {
                get
                {
                    fixed (IntPtr* pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }

        public partial struct _wire_vec_e__FixedBuffer
        {
            internal IntPtr e0;
            internal IntPtr e1;
            internal IntPtr e2;
            internal IntPtr e3;
            internal IntPtr e4;
            internal IntPtr e5;
            internal IntPtr e6;
            internal IntPtr e7;
            internal IntPtr e8;
            internal IntPtr e9;
            internal IntPtr e10;
            internal IntPtr e11;
            internal IntPtr e12;
            internal IntPtr e13;
            internal IntPtr e14;
            internal IntPtr e15;
            internal IntPtr e16;
            internal IntPtr e17;
            internal IntPtr e18;
            internal IntPtr e19;
            internal IntPtr e20;
            internal IntPtr e21;
            internal IntPtr e22;
            internal IntPtr e23;
            internal IntPtr e24;
            internal IntPtr e25;
            internal IntPtr e26;
            internal IntPtr e27;
            internal IntPtr e28;
            internal IntPtr e29;
            internal IntPtr e30;
            internal IntPtr e31;
            internal IntPtr e32;
            internal IntPtr e33;
            internal IntPtr e34;
            internal IntPtr e35;
            internal IntPtr e36;
            internal IntPtr e37;
            internal IntPtr e38;
            internal IntPtr e39;
            internal IntPtr e40;
            internal IntPtr e41;
            internal IntPtr e42;
            internal IntPtr e43;
            internal IntPtr e44;
            internal IntPtr e45;
            internal IntPtr e46;
            internal IntPtr e47;
            internal IntPtr e48;
            internal IntPtr e49;
            internal IntPtr e50;
            internal IntPtr e51;
            internal IntPtr e52;
            internal IntPtr e53;
            internal IntPtr e54;
            internal IntPtr e55;
            internal IntPtr e56;
            internal IntPtr e57;
            internal IntPtr e58;
            internal IntPtr e59;
            internal IntPtr e60;
            internal IntPtr e61;
            internal IntPtr e62;
            internal IntPtr e63;
            internal IntPtr e64;
            internal IntPtr e65;
            internal IntPtr e66;
            internal IntPtr e67;
            internal IntPtr e68;
            internal IntPtr e69;
            internal IntPtr e70;
            internal IntPtr e71;
            internal IntPtr e72;
            internal IntPtr e73;
            internal IntPtr e74;
            internal IntPtr e75;
            internal IntPtr e76;
            internal IntPtr e77;
            internal IntPtr e78;
            internal IntPtr e79;
            internal IntPtr e80;
            internal IntPtr e81;
            internal IntPtr e82;
            internal IntPtr e83;
            internal IntPtr e84;
            internal IntPtr e85;
            internal IntPtr e86;
            internal IntPtr e87;
            internal IntPtr e88;
            internal IntPtr e89;
            internal IntPtr e90;
            internal IntPtr e91;
            internal IntPtr e92;
            internal IntPtr e93;
            internal IntPtr e94;
            internal IntPtr e95;
            internal IntPtr e96;
            internal IntPtr e97;
            internal IntPtr e98;
            internal IntPtr e99;
            internal IntPtr e100;
            internal IntPtr e101;
            internal IntPtr e102;
            internal IntPtr e103;
            internal IntPtr e104;
            internal IntPtr e105;
            internal IntPtr e106;
            internal IntPtr e107;
            internal IntPtr e108;
            internal IntPtr e109;
            internal IntPtr e110;
            internal IntPtr e111;
            internal IntPtr e112;
            internal IntPtr e113;
            internal IntPtr e114;
            internal IntPtr e115;
            internal IntPtr e116;
            internal IntPtr e117;
            internal IntPtr e118;
            internal IntPtr e119;
            internal IntPtr e120;
            internal IntPtr e121;
            internal IntPtr e122;
            internal IntPtr e123;
            internal IntPtr e124;
            internal IntPtr e125;
            internal IntPtr e126;
            internal IntPtr e127;

            public unsafe ref IntPtr this[int index]
            {
                get
                {
                    fixed (IntPtr* pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }

        public partial struct _generic_event_vec_e__FixedBuffer
        {
            internal IntPtr e0;
            internal IntPtr e1;
            internal IntPtr e2;
            internal IntPtr e3;
            internal IntPtr e4;
            internal IntPtr e5;
            internal IntPtr e6;
            internal IntPtr e7;
            internal IntPtr e8;
            internal IntPtr e9;
            internal IntPtr e10;
            internal IntPtr e11;
            internal IntPtr e12;
            internal IntPtr e13;
            internal IntPtr e14;
            internal IntPtr e15;
            internal IntPtr e16;
            internal IntPtr e17;
            internal IntPtr e18;
            internal IntPtr e19;
            internal IntPtr e20;
            internal IntPtr e21;
            internal IntPtr e22;
            internal IntPtr e23;
            internal IntPtr e24;
            internal IntPtr e25;
            internal IntPtr e26;
            internal IntPtr e27;
            internal IntPtr e28;
            internal IntPtr e29;
            internal IntPtr e30;
            internal IntPtr e31;
            internal IntPtr e32;
            internal IntPtr e33;
            internal IntPtr e34;
            internal IntPtr e35;
            internal IntPtr e36;
            internal IntPtr e37;
            internal IntPtr e38;
            internal IntPtr e39;
            internal IntPtr e40;
            internal IntPtr e41;
            internal IntPtr e42;
            internal IntPtr e43;
            internal IntPtr e44;
            internal IntPtr e45;
            internal IntPtr e46;
            internal IntPtr e47;
            internal IntPtr e48;
            internal IntPtr e49;
            internal IntPtr e50;
            internal IntPtr e51;
            internal IntPtr e52;
            internal IntPtr e53;
            internal IntPtr e54;
            internal IntPtr e55;
            internal IntPtr e56;
            internal IntPtr e57;
            internal IntPtr e58;
            internal IntPtr e59;
            internal IntPtr e60;
            internal IntPtr e61;
            internal IntPtr e62;
            internal IntPtr e63;
            internal IntPtr e64;
            internal IntPtr e65;
            internal IntPtr e66;
            internal IntPtr e67;
            internal IntPtr e68;
            internal IntPtr e69;
            internal IntPtr e70;
            internal IntPtr e71;
            internal IntPtr e72;
            internal IntPtr e73;
            internal IntPtr e74;
            internal IntPtr e75;
            internal IntPtr e76;
            internal IntPtr e77;
            internal IntPtr e78;
            internal IntPtr e79;
            internal IntPtr e80;
            internal IntPtr e81;
            internal IntPtr e82;
            internal IntPtr e83;
            internal IntPtr e84;
            internal IntPtr e85;
            internal IntPtr e86;
            internal IntPtr e87;
            internal IntPtr e88;
            internal IntPtr e89;
            internal IntPtr e90;
            internal IntPtr e91;
            internal IntPtr e92;
            internal IntPtr e93;
            internal IntPtr e94;
            internal IntPtr e95;
            internal IntPtr e96;
            internal IntPtr e97;
            internal IntPtr e98;
            internal IntPtr e99;
            internal IntPtr e100;
            internal IntPtr e101;
            internal IntPtr e102;
            internal IntPtr e103;
            internal IntPtr e104;
            internal IntPtr e105;
            internal IntPtr e106;
            internal IntPtr e107;
            internal IntPtr e108;
            internal IntPtr e109;
            internal IntPtr e110;
            internal IntPtr e111;
            internal IntPtr e112;
            internal IntPtr e113;
            internal IntPtr e114;
            internal IntPtr e115;
            internal IntPtr e116;
            internal IntPtr e117;
            internal IntPtr e118;
            internal IntPtr e119;
            internal IntPtr e120;
            internal IntPtr e121;
            internal IntPtr e122;
            internal IntPtr e123;
            internal IntPtr e124;
            internal IntPtr e125;
            internal IntPtr e126;
            internal IntPtr e127;

            public unsafe ref IntPtr this[int index]
            {
                get
                {
                    fixed (IntPtr* pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }

        public partial struct _generic_event_copy_vec_e__FixedBuffer
        {
            internal IntPtr e0;
            internal IntPtr e1;
            internal IntPtr e2;
            internal IntPtr e3;
            internal IntPtr e4;
            internal IntPtr e5;
            internal IntPtr e6;
            internal IntPtr e7;
            internal IntPtr e8;
            internal IntPtr e9;
            internal IntPtr e10;
            internal IntPtr e11;
            internal IntPtr e12;
            internal IntPtr e13;
            internal IntPtr e14;
            internal IntPtr e15;
            internal IntPtr e16;
            internal IntPtr e17;
            internal IntPtr e18;
            internal IntPtr e19;
            internal IntPtr e20;
            internal IntPtr e21;
            internal IntPtr e22;
            internal IntPtr e23;
            internal IntPtr e24;
            internal IntPtr e25;
            internal IntPtr e26;
            internal IntPtr e27;
            internal IntPtr e28;
            internal IntPtr e29;
            internal IntPtr e30;
            internal IntPtr e31;
            internal IntPtr e32;
            internal IntPtr e33;
            internal IntPtr e34;
            internal IntPtr e35;
            internal IntPtr e36;
            internal IntPtr e37;
            internal IntPtr e38;
            internal IntPtr e39;
            internal IntPtr e40;
            internal IntPtr e41;
            internal IntPtr e42;
            internal IntPtr e43;
            internal IntPtr e44;
            internal IntPtr e45;
            internal IntPtr e46;
            internal IntPtr e47;
            internal IntPtr e48;
            internal IntPtr e49;
            internal IntPtr e50;
            internal IntPtr e51;
            internal IntPtr e52;
            internal IntPtr e53;
            internal IntPtr e54;
            internal IntPtr e55;
            internal IntPtr e56;
            internal IntPtr e57;
            internal IntPtr e58;
            internal IntPtr e59;
            internal IntPtr e60;
            internal IntPtr e61;
            internal IntPtr e62;
            internal IntPtr e63;
            internal IntPtr e64;
            internal IntPtr e65;
            internal IntPtr e66;
            internal IntPtr e67;
            internal IntPtr e68;
            internal IntPtr e69;
            internal IntPtr e70;
            internal IntPtr e71;
            internal IntPtr e72;
            internal IntPtr e73;
            internal IntPtr e74;
            internal IntPtr e75;
            internal IntPtr e76;
            internal IntPtr e77;
            internal IntPtr e78;
            internal IntPtr e79;
            internal IntPtr e80;
            internal IntPtr e81;
            internal IntPtr e82;
            internal IntPtr e83;
            internal IntPtr e84;
            internal IntPtr e85;
            internal IntPtr e86;
            internal IntPtr e87;
            internal IntPtr e88;
            internal IntPtr e89;
            internal IntPtr e90;
            internal IntPtr e91;
            internal IntPtr e92;
            internal IntPtr e93;
            internal IntPtr e94;
            internal IntPtr e95;
            internal IntPtr e96;
            internal IntPtr e97;
            internal IntPtr e98;
            internal IntPtr e99;
            internal IntPtr e100;
            internal IntPtr e101;
            internal IntPtr e102;
            internal IntPtr e103;
            internal IntPtr e104;
            internal IntPtr e105;
            internal IntPtr e106;
            internal IntPtr e107;
            internal IntPtr e108;
            internal IntPtr e109;
            internal IntPtr e110;
            internal IntPtr e111;
            internal IntPtr e112;
            internal IntPtr e113;
            internal IntPtr e114;
            internal IntPtr e115;
            internal IntPtr e116;
            internal IntPtr e117;
            internal IntPtr e118;
            internal IntPtr e119;
            internal IntPtr e120;
            internal IntPtr e121;
            internal IntPtr e122;
            internal IntPtr e123;
            internal IntPtr e124;
            internal IntPtr e125;
            internal IntPtr e126;
            internal IntPtr e127;

            public unsafe ref IntPtr this[int index]
            {
                get
                {
                    fixed (IntPtr* pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }
    }
}
