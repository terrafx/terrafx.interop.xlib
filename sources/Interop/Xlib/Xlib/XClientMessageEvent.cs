// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct XClientMessageEvent
    {
        public int type;

        [NativeTypeName("unsigned long")]
        public UIntPtr serial;

        public int send_event;

        [NativeTypeName("Display *")]
        public UIntPtr display;

        [NativeTypeName("Window")]
        public UIntPtr window;

        [NativeTypeName("Atom")]
        public UIntPtr message_type;

        public int format;

        [NativeTypeName("union (anonymous union at /usr/include/X11/Xlib.h:905:2)")]
        public _data__AnonymousRecord data;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _data__AnonymousRecord
        {
            [FieldOffset(0)]
            [NativeTypeName("char [20]")]
            public fixed sbyte b[20];

            [FieldOffset(0)]
            [NativeTypeName("short [10]")]
            public fixed short s[10];

            [FieldOffset(0)]
            [NativeTypeName("long [5]")]
            public _l_e__FixedBuffer l;

            public partial struct _l_e__FixedBuffer
            {
                internal IntPtr e0;
                internal IntPtr e1;
                internal IntPtr e2;
                internal IntPtr e3;
                internal IntPtr e4;
            }
        }
    }
}
