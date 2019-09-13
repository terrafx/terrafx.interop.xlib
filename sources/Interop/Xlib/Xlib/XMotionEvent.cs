// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct XMotionEvent
    {
        public int type;

        [NativeTypeName("unsigned long")]
        public UIntPtr serial;

        public int send_event;

        [NativeTypeName("Display *")]
        public UIntPtr display;

        [NativeTypeName("Window")]
        public UIntPtr window;

        [NativeTypeName("Window")]
        public UIntPtr root;

        [NativeTypeName("Window")]
        public UIntPtr subwindow;

        [NativeTypeName("Time")]
        public UIntPtr time;

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
