// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\Xproto.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group and Digital Equipment Corporation, Maynard, Massachusetts.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct xEvent
    {
        [NativeTypeName("union (anonymous union at /usr/include/X11/Xproto.h:997:5)")]
        public _u__AnonymousRecord u;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _u__AnonymousRecord
        {
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:998:2)")]
            public _u__AnonymousRecord2 u;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1003:2)")]
            public _keyButtonPointer__AnonymousRecord keyButtonPointer;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1012:2)")]
            public _enterLeave__AnonymousRecord enterLeave;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1023:2)")]
            public _focus__AnonymousRecord focus;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1029:2)")]
            public _expose__AnonymousRecord expose;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1036:2)")]
            public _graphicsExposure__AnonymousRecord graphicsExposure;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1045:2)")]
            public _noExposure__AnonymousRecord noExposure;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1052:2)")]
            public _visibility__AnonymousRecord visibility;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1058:2)")]
            public _createNotify__AnonymousRecord createNotify;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1074:2)")]
            public _destroyNotify__AnonymousRecord destroyNotify;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1078:2)")]
            public _unmapNotify__AnonymousRecord unmapNotify;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1084:2)")]
            public _mapNotify__AnonymousRecord mapNotify;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1090:2)")]
            public _mapRequest__AnonymousRecord mapRequest;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1094:2)")]
            public _reparent__AnonymousRecord reparent;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1101:2)")]
            public _configureNotify__AnonymousRecord configureNotify;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1109:2)")]
            public _configureRequest__AnonymousRecord configureRequest;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1117:2)")]
            public _gravity__AnonymousRecord gravity;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1123:2)")]
            public _resizeRequest__AnonymousRecord resizeRequest;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1128:2)")]
            public _circulate__AnonymousRecord circulate;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1136:2)")]
            public _property__AnonymousRecord property;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1145:2)")]
            public _selectionClear__AnonymousRecord selectionClear;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1151:2)")]
            public _selectionRequest__AnonymousRecord selectionRequest;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1157:2)")]
            public _selectionNotify__AnonymousRecord selectionNotify;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1163:2)")]
            public _colormap__AnonymousRecord colormap;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1175:2)")]
            public _mappingNotify__AnonymousRecord mappingNotify;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1182:2)")]
            public _clientMessage__AnonymousRecord clientMessage;

            public partial struct _u__AnonymousRecord2
            {
                [NativeTypeName("BYTE")]
                public byte type;

                [NativeTypeName("BYTE")]
                public byte detail;

                [NativeTypeName("CARD16")]
                public ushort sequenceNumber;
            }

            public partial struct _keyButtonPointer__AnonymousRecord
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

                [NativeTypeName("BYTE")]
                public byte pad1;
            }

            public partial struct _enterLeave__AnonymousRecord
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

                [NativeTypeName("BYTE")]
                public byte mode;

                [NativeTypeName("BYTE")]
                public byte flags;
            }

            public partial struct _focus__AnonymousRecord
            {
                [NativeTypeName("CARD32")]
                public uint pad00;

                [NativeTypeName("CARD32")]
                public uint window;

                [NativeTypeName("BYTE")]
                public byte mode;

                [NativeTypeName("BYTE")]
                public byte pad1;

                [NativeTypeName("BYTE")]
                public byte pad2;

                [NativeTypeName("BYTE")]
                public byte pad3;
            }

            public partial struct _expose__AnonymousRecord
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

            public partial struct _graphicsExposure__AnonymousRecord
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

                [NativeTypeName("BYTE")]
                public byte majorEvent;

                [NativeTypeName("BYTE")]
                public byte pad1;

                [NativeTypeName("BYTE")]
                public byte pad2;

                [NativeTypeName("BYTE")]
                public byte pad3;
            }

            public partial struct _noExposure__AnonymousRecord
            {
                [NativeTypeName("CARD32")]
                public uint pad00;

                [NativeTypeName("CARD32")]
                public uint drawable;

                [NativeTypeName("CARD16")]
                public ushort minorEvent;

                [NativeTypeName("BYTE")]
                public byte majorEvent;

                [NativeTypeName("BYTE")]
                public byte bpad;
            }

            public partial struct _visibility__AnonymousRecord
            {
                [NativeTypeName("CARD32")]
                public uint pad00;

                [NativeTypeName("CARD32")]
                public uint window;

                [NativeTypeName("CARD8")]
                public byte state;

                [NativeTypeName("BYTE")]
                public byte pad1;

                [NativeTypeName("BYTE")]
                public byte pad2;

                [NativeTypeName("BYTE")]
                public byte pad3;
            }

            public partial struct _createNotify__AnonymousRecord
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

                [NativeTypeName("BYTE")]
                public byte bpad;
            }

            public partial struct _destroyNotify__AnonymousRecord
            {
                [NativeTypeName("CARD32")]
                public uint pad00;

                [NativeTypeName("CARD32")]
                public uint @event;

                [NativeTypeName("CARD32")]
                public uint window;
            }

            public partial struct _unmapNotify__AnonymousRecord
            {
                [NativeTypeName("CARD32")]
                public uint pad00;

                [NativeTypeName("CARD32")]
                public uint @event;

                [NativeTypeName("CARD32")]
                public uint window;

                [NativeTypeName("BOOL")]
                public byte fromConfigure;

                [NativeTypeName("BYTE")]
                public byte pad1;

                [NativeTypeName("BYTE")]
                public byte pad2;

                [NativeTypeName("BYTE")]
                public byte pad3;
            }

            public partial struct _mapNotify__AnonymousRecord
            {
                [NativeTypeName("CARD32")]
                public uint pad00;

                [NativeTypeName("CARD32")]
                public uint @event;

                [NativeTypeName("CARD32")]
                public uint window;

                [NativeTypeName("BOOL")]
                public byte @override;

                [NativeTypeName("BYTE")]
                public byte pad1;

                [NativeTypeName("BYTE")]
                public byte pad2;

                [NativeTypeName("BYTE")]
                public byte pad3;
            }

            public partial struct _mapRequest__AnonymousRecord
            {
                [NativeTypeName("CARD32")]
                public uint pad00;

                [NativeTypeName("CARD32")]
                public uint parent;

                [NativeTypeName("CARD32")]
                public uint window;
            }

            public partial struct _reparent__AnonymousRecord
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

                [NativeTypeName("BYTE")]
                public byte pad1;

                [NativeTypeName("BYTE")]
                public byte pad2;

                [NativeTypeName("BYTE")]
                public byte pad3;
            }

            public partial struct _configureNotify__AnonymousRecord
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

                [NativeTypeName("BYTE")]
                public byte bpad;
            }

            public partial struct _configureRequest__AnonymousRecord
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

            public partial struct _gravity__AnonymousRecord
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

            public partial struct _resizeRequest__AnonymousRecord
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

            public partial struct _circulate__AnonymousRecord
            {
                [NativeTypeName("CARD32")]
                public uint pad00;

                [NativeTypeName("CARD32")]
                public uint @event;

                [NativeTypeName("CARD32")]
                public uint window;

                [NativeTypeName("CARD32")]
                public uint parent;

                [NativeTypeName("BYTE")]
                public byte place;

                [NativeTypeName("BYTE")]
                public byte pad1;

                [NativeTypeName("BYTE")]
                public byte pad2;

                [NativeTypeName("BYTE")]
                public byte pad3;
            }

            public partial struct _property__AnonymousRecord
            {
                [NativeTypeName("CARD32")]
                public uint pad00;

                [NativeTypeName("CARD32")]
                public uint window;

                [NativeTypeName("CARD32")]
                public uint atom;

                [NativeTypeName("CARD32")]
                public uint time;

                [NativeTypeName("BYTE")]
                public byte state;

                [NativeTypeName("BYTE")]
                public byte pad1;

                [NativeTypeName("CARD16")]
                public ushort pad2;
            }

            public partial struct _selectionClear__AnonymousRecord
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

            public partial struct _selectionRequest__AnonymousRecord
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

            public partial struct _selectionNotify__AnonymousRecord
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

            public partial struct _colormap__AnonymousRecord
            {
                [NativeTypeName("CARD32")]
                public uint pad00;

                [NativeTypeName("CARD32")]
                public uint window;

                [NativeTypeName("CARD32")]
                public uint colormap;

                [NativeTypeName("BOOL")]
                public byte c_new;

                [NativeTypeName("BYTE")]
                public byte state;

                [NativeTypeName("BYTE")]
                public byte pad1;

                [NativeTypeName("BYTE")]
                public byte pad2;
            }

            public partial struct _mappingNotify__AnonymousRecord
            {
                [NativeTypeName("CARD32")]
                public uint pad00;

                [NativeTypeName("CARD8")]
                public byte request;

                [NativeTypeName("CARD8")]
                public byte firstKeyCode;

                [NativeTypeName("CARD8")]
                public byte count;

                [NativeTypeName("BYTE")]
                public byte pad1;
            }

            public partial struct _clientMessage__AnonymousRecord
            {
                [NativeTypeName("CARD32")]
                public uint pad00;

                [NativeTypeName("CARD32")]
                public uint window;

                [NativeTypeName("union (anonymous union at /usr/include/X11/Xproto.h:1185:6)")]
                public _u__AnonymousRecord u;

                [StructLayout(LayoutKind.Explicit)]
                public partial struct _u__AnonymousRecord
                {
                    [FieldOffset(0)]
                    [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1186:3)")]
                    public _l__AnonymousRecord l;

                    [FieldOffset(0)]
                    [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1194:3)")]
                    public _s__AnonymousRecord s;

                    [FieldOffset(0)]
                    [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xproto.h:1207:3)")]
                    public _b__AnonymousRecord b;

                    public partial struct _l__AnonymousRecord
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

                    public partial struct _s__AnonymousRecord
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

                    public unsafe partial struct _b__AnonymousRecord
                    {
                        [NativeTypeName("CARD32")]
                        public uint type;

                        [NativeTypeName("INT8 [20]")]
                        public fixed sbyte bytes[20];
                    }
                }
            }
        }
    }
}
