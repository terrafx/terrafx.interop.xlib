// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System;

namespace TerraFX.Interop
{
    public partial struct XMotionEvent
    {
        public int type;

        [NativeTypeName("unsigned long")]
        public nuint serial;

        public int send_event;

        [NativeTypeName("Display *")]
        public IntPtr display;

        [NativeTypeName("Window")]
        public nuint window;

        [NativeTypeName("Window")]
        public nuint root;

        [NativeTypeName("Window")]
        public nuint subwindow;

        [NativeTypeName("Time")]
        public nuint time;

        public int x;

        public int y;

        public int x_root;

        public int y_root;

        [NativeTypeName("unsigned int")]
        public uint state;

        [NativeTypeName("char")]
        public sbyte is_hint;

        public int same_screen;
    }
}
