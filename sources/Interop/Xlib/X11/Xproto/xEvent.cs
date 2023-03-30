// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xproto.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Xlib;

public partial struct xEvent
{
    [NativeTypeName("union (anonymous union at /usr/include/X11/Xproto.h:997:5)")]
    public _u_e__Union u;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _u_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:998:2)")]
        public _u_e__Struct u;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1003:2)")]
        public _keyButtonPointer_e__Struct keyButtonPointer;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1012:2)")]
        public _enterLeave_e__Struct enterLeave;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1023:2)")]
        public _focus_e__Struct focus;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1029:2)")]
        public _expose_e__Struct expose;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1036:2)")]
        public _graphicsExposure_e__Struct graphicsExposure;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1045:2)")]
        public _noExposure_e__Struct noExposure;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1052:2)")]
        public _visibility_e__Struct visibility;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1058:2)")]
        public _createNotify_e__Struct createNotify;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1074:2)")]
        public _destroyNotify_e__Struct destroyNotify;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1078:2)")]
        public _unmapNotify_e__Struct unmapNotify;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1084:2)")]
        public _mapNotify_e__Struct mapNotify;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1090:2)")]
        public _mapRequest_e__Struct mapRequest;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1094:2)")]
        public _reparent_e__Struct reparent;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1101:2)")]
        public _configureNotify_e__Struct configureNotify;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1109:2)")]
        public _configureRequest_e__Struct configureRequest;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1117:2)")]
        public _gravity_e__Struct gravity;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1123:2)")]
        public _resizeRequest_e__Struct resizeRequest;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1128:2)")]
        public _circulate_e__Struct circulate;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1136:2)")]
        public _property_e__Struct property;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1145:2)")]
        public _selectionClear_e__Struct selectionClear;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1151:2)")]
        public _selectionRequest_e__Struct selectionRequest;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1157:2)")]
        public _selectionNotify_e__Struct selectionNotify;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1163:2)")]
        public _colormap_e__Struct colormap;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1175:2)")]
        public _mappingNotify_e__Struct mappingNotify;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1182:2)")]
        public _clientMessage_e__Struct clientMessage;

        public partial struct _u_e__Struct
        {
            public byte type;

            public byte detail;

            [NativeTypeName("CARD16")]
            public ushort sequenceNumber;
        }

        public partial struct _keyButtonPointer_e__Struct
        {
            [NativeTypeName("CARD32")]
            public uint pad00;

            [NativeTypeName("CARD32")]
            public uint time;

            [NativeTypeName("CARD32")]
            public uint root;

            [NativeTypeName("CARD32")]
            public uint @event;

            [NativeTypeName("CARD32")]
            public uint child;

            [NativeTypeName("INT16")]
            public short rootX;

            [NativeTypeName("INT16")]
            public short rootY;

            [NativeTypeName("INT16")]
            public short eventX;

            [NativeTypeName("INT16")]
            public short eventY;

            [NativeTypeName("KeyButMask")]
            public ushort state;

            [NativeTypeName("BOOL")]
            public byte sameScreen;

            public byte pad1;
        }

        public partial struct _enterLeave_e__Struct
        {
            [NativeTypeName("CARD32")]
            public uint pad00;

            [NativeTypeName("CARD32")]
            public uint time;

            [NativeTypeName("CARD32")]
            public uint root;

            [NativeTypeName("CARD32")]
            public uint @event;

            [NativeTypeName("CARD32")]
            public uint child;

            [NativeTypeName("INT16")]
            public short rootX;

            [NativeTypeName("INT16")]
            public short rootY;

            [NativeTypeName("INT16")]
            public short eventX;

            [NativeTypeName("INT16")]
            public short eventY;

            [NativeTypeName("KeyButMask")]
            public ushort state;

            public byte mode;

            public byte flags;
        }

        public partial struct _focus_e__Struct
        {
            [NativeTypeName("CARD32")]
            public uint pad00;

            [NativeTypeName("CARD32")]
            public uint window;

            public byte mode;

            public byte pad1;

            public byte pad2;

            public byte pad3;
        }

        public partial struct _expose_e__Struct
        {
            [NativeTypeName("CARD32")]
            public uint pad00;

            [NativeTypeName("CARD32")]
            public uint window;

            [NativeTypeName("CARD16")]
            public ushort x;

            [NativeTypeName("CARD16")]
            public ushort y;

            [NativeTypeName("CARD16")]
            public ushort width;

            [NativeTypeName("CARD16")]
            public ushort height;

            [NativeTypeName("CARD16")]
            public ushort count;

            [NativeTypeName("CARD16")]
            public ushort pad2;
        }

        public partial struct _graphicsExposure_e__Struct
        {
            [NativeTypeName("CARD32")]
            public uint pad00;

            [NativeTypeName("CARD32")]
            public uint drawable;

            [NativeTypeName("CARD16")]
            public ushort x;

            [NativeTypeName("CARD16")]
            public ushort y;

            [NativeTypeName("CARD16")]
            public ushort width;

            [NativeTypeName("CARD16")]
            public ushort height;

            [NativeTypeName("CARD16")]
            public ushort minorEvent;

            [NativeTypeName("CARD16")]
            public ushort count;

            public byte majorEvent;

            public byte pad1;

            public byte pad2;

            public byte pad3;
        }

        public partial struct _noExposure_e__Struct
        {
            [NativeTypeName("CARD32")]
            public uint pad00;

            [NativeTypeName("CARD32")]
            public uint drawable;

            [NativeTypeName("CARD16")]
            public ushort minorEvent;

            public byte majorEvent;

            public byte bpad;
        }

        public partial struct _visibility_e__Struct
        {
            [NativeTypeName("CARD32")]
            public uint pad00;

            [NativeTypeName("CARD32")]
            public uint window;

            [NativeTypeName("CARD8")]
            public byte state;

            public byte pad1;

            public byte pad2;

            public byte pad3;
        }

        public partial struct _createNotify_e__Struct
        {
            [NativeTypeName("CARD32")]
            public uint pad00;

            [NativeTypeName("CARD32")]
            public uint parent;

            [NativeTypeName("CARD32")]
            public uint window;

            [NativeTypeName("INT16")]
            public short x;

            [NativeTypeName("INT16")]
            public short y;

            [NativeTypeName("CARD16")]
            public ushort width;

            [NativeTypeName("CARD16")]
            public ushort height;

            [NativeTypeName("CARD16")]
            public ushort borderWidth;

            [NativeTypeName("BOOL")]
            public byte @override;

            public byte bpad;
        }

        public partial struct _destroyNotify_e__Struct
        {
            [NativeTypeName("CARD32")]
            public uint pad00;

            [NativeTypeName("CARD32")]
            public uint @event;

            [NativeTypeName("CARD32")]
            public uint window;
        }

        public partial struct _unmapNotify_e__Struct
        {
            [NativeTypeName("CARD32")]
            public uint pad00;

            [NativeTypeName("CARD32")]
            public uint @event;

            [NativeTypeName("CARD32")]
            public uint window;

            [NativeTypeName("BOOL")]
            public byte fromConfigure;

            public byte pad1;

            public byte pad2;

            public byte pad3;
        }

        public partial struct _mapNotify_e__Struct
        {
            [NativeTypeName("CARD32")]
            public uint pad00;

            [NativeTypeName("CARD32")]
            public uint @event;

            [NativeTypeName("CARD32")]
            public uint window;

            [NativeTypeName("BOOL")]
            public byte @override;

            public byte pad1;

            public byte pad2;

            public byte pad3;
        }

        public partial struct _mapRequest_e__Struct
        {
            [NativeTypeName("CARD32")]
            public uint pad00;

            [NativeTypeName("CARD32")]
            public uint parent;

            [NativeTypeName("CARD32")]
            public uint window;
        }

        public partial struct _reparent_e__Struct
        {
            [NativeTypeName("CARD32")]
            public uint pad00;

            [NativeTypeName("CARD32")]
            public uint @event;

            [NativeTypeName("CARD32")]
            public uint window;

            [NativeTypeName("CARD32")]
            public uint parent;

            [NativeTypeName("INT16")]
            public short x;

            [NativeTypeName("INT16")]
            public short y;

            [NativeTypeName("BOOL")]
            public byte @override;

            public byte pad1;

            public byte pad2;

            public byte pad3;
        }

        public partial struct _configureNotify_e__Struct
        {
            [NativeTypeName("CARD32")]
            public uint pad00;

            [NativeTypeName("CARD32")]
            public uint @event;

            [NativeTypeName("CARD32")]
            public uint window;

            [NativeTypeName("CARD32")]
            public uint aboveSibling;

            [NativeTypeName("INT16")]
            public short x;

            [NativeTypeName("INT16")]
            public short y;

            [NativeTypeName("CARD16")]
            public ushort width;

            [NativeTypeName("CARD16")]
            public ushort height;

            [NativeTypeName("CARD16")]
            public ushort borderWidth;

            [NativeTypeName("BOOL")]
            public byte @override;

            public byte bpad;
        }

        public partial struct _configureRequest_e__Struct
        {
            [NativeTypeName("CARD32")]
            public uint pad00;

            [NativeTypeName("CARD32")]
            public uint parent;

            [NativeTypeName("CARD32")]
            public uint window;

            [NativeTypeName("CARD32")]
            public uint sibling;

            [NativeTypeName("INT16")]
            public short x;

            [NativeTypeName("INT16")]
            public short y;

            [NativeTypeName("CARD16")]
            public ushort width;

            [NativeTypeName("CARD16")]
            public ushort height;

            [NativeTypeName("CARD16")]
            public ushort borderWidth;

            [NativeTypeName("CARD16")]
            public ushort valueMask;

            [NativeTypeName("CARD32")]
            public uint pad1;
        }

        public partial struct _gravity_e__Struct
        {
            [NativeTypeName("CARD32")]
            public uint pad00;

            [NativeTypeName("CARD32")]
            public uint @event;

            [NativeTypeName("CARD32")]
            public uint window;

            [NativeTypeName("INT16")]
            public short x;

            [NativeTypeName("INT16")]
            public short y;

            [NativeTypeName("CARD32")]
            public uint pad1;

            [NativeTypeName("CARD32")]
            public uint pad2;

            [NativeTypeName("CARD32")]
            public uint pad3;

            [NativeTypeName("CARD32")]
            public uint pad4;
        }

        public partial struct _resizeRequest_e__Struct
        {
            [NativeTypeName("CARD32")]
            public uint pad00;

            [NativeTypeName("CARD32")]
            public uint window;

            [NativeTypeName("CARD16")]
            public ushort width;

            [NativeTypeName("CARD16")]
            public ushort height;
        }

        public partial struct _circulate_e__Struct
        {
            [NativeTypeName("CARD32")]
            public uint pad00;

            [NativeTypeName("CARD32")]
            public uint @event;

            [NativeTypeName("CARD32")]
            public uint window;

            [NativeTypeName("CARD32")]
            public uint parent;

            public byte place;

            public byte pad1;

            public byte pad2;

            public byte pad3;
        }

        public partial struct _property_e__Struct
        {
            [NativeTypeName("CARD32")]
            public uint pad00;

            [NativeTypeName("CARD32")]
            public uint window;

            [NativeTypeName("CARD32")]
            public uint atom;

            [NativeTypeName("CARD32")]
            public uint time;

            public byte state;

            public byte pad1;

            [NativeTypeName("CARD16")]
            public ushort pad2;
        }

        public partial struct _selectionClear_e__Struct
        {
            [NativeTypeName("CARD32")]
            public uint pad00;

            [NativeTypeName("CARD32")]
            public uint time;

            [NativeTypeName("CARD32")]
            public uint window;

            [NativeTypeName("CARD32")]
            public uint atom;
        }

        public partial struct _selectionRequest_e__Struct
        {
            [NativeTypeName("CARD32")]
            public uint pad00;

            [NativeTypeName("CARD32")]
            public uint time;

            [NativeTypeName("CARD32")]
            public uint owner;

            [NativeTypeName("CARD32")]
            public uint requestor;

            [NativeTypeName("CARD32")]
            public uint selection;

            [NativeTypeName("CARD32")]
            public uint target;

            [NativeTypeName("CARD32")]
            public uint property;
        }

        public partial struct _selectionNotify_e__Struct
        {
            [NativeTypeName("CARD32")]
            public uint pad00;

            [NativeTypeName("CARD32")]
            public uint time;

            [NativeTypeName("CARD32")]
            public uint requestor;

            [NativeTypeName("CARD32")]
            public uint selection;

            [NativeTypeName("CARD32")]
            public uint target;

            [NativeTypeName("CARD32")]
            public uint property;
        }

        public partial struct _colormap_e__Struct
        {
            [NativeTypeName("CARD32")]
            public uint pad00;

            [NativeTypeName("CARD32")]
            public uint window;

            [NativeTypeName("CARD32")]
            public uint colormap;

            [NativeTypeName("BOOL")]
            public byte c_new;

            public byte state;

            public byte pad1;

            public byte pad2;
        }

        public partial struct _mappingNotify_e__Struct
        {
            [NativeTypeName("CARD32")]
            public uint pad00;

            [NativeTypeName("CARD8")]
            public byte request;

            [NativeTypeName("CARD8")]
            public byte firstKeyCode;

            [NativeTypeName("CARD8")]
            public byte count;

            public byte pad1;
        }

        public partial struct _clientMessage_e__Struct
        {
            [NativeTypeName("CARD32")]
            public uint pad00;

            [NativeTypeName("CARD32")]
            public uint window;

            [NativeTypeName("union (anonymous union at /usr/include/X11/Xproto.h:1185:6)")]
            public _u_e__Union u;

            [StructLayout(LayoutKind.Explicit)]
            public partial struct _u_e__Union
            {
                [FieldOffset(0)]
                [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1186:3)")]
                public _l_e__Struct l;

                [FieldOffset(0)]
                [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1194:3)")]
                public _s_e__Struct s;

                [FieldOffset(0)]
                [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1207:3)")]
                public _b_e__Struct b;

                public partial struct _l_e__Struct
                {
                    [NativeTypeName("CARD32")]
                    public uint type;

                    [NativeTypeName("INT32")]
                    public int longs0;

                    [NativeTypeName("INT32")]
                    public int longs1;

                    [NativeTypeName("INT32")]
                    public int longs2;

                    [NativeTypeName("INT32")]
                    public int longs3;

                    [NativeTypeName("INT32")]
                    public int longs4;
                }

                public partial struct _s_e__Struct
                {
                    [NativeTypeName("CARD32")]
                    public uint type;

                    [NativeTypeName("INT16")]
                    public short shorts0;

                    [NativeTypeName("INT16")]
                    public short shorts1;

                    [NativeTypeName("INT16")]
                    public short shorts2;

                    [NativeTypeName("INT16")]
                    public short shorts3;

                    [NativeTypeName("INT16")]
                    public short shorts4;

                    [NativeTypeName("INT16")]
                    public short shorts5;

                    [NativeTypeName("INT16")]
                    public short shorts6;

                    [NativeTypeName("INT16")]
                    public short shorts7;

                    [NativeTypeName("INT16")]
                    public short shorts8;

                    [NativeTypeName("INT16")]
                    public short shorts9;
                }

                public unsafe partial struct _b_e__Struct
                {
                    [NativeTypeName("CARD32")]
                    public uint type;

                    [NativeTypeName("INT8[20]")]
                    public fixed sbyte bytes[20];
                }
            }
        }
    }
}
