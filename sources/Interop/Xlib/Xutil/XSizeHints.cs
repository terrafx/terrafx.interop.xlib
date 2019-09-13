// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\Xutil.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group and Digital Equipment Corporation, Maynard, Massachusetts.

using System;

namespace TerraFX.Interop
{
    public partial struct XSizeHints
    {
        [NativeTypeName("long")]
        public IntPtr flags;

        public int x;

        public int y;

        public int width;

        public int height;

        public int min_width;

        public int min_height;

        public int max_width;

        public int max_height;

        public int width_inc;

        public int height_inc;

        [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xutil.h:88:2)")]
        public _aspect__AnonymousRecord min_aspect;

        [NativeTypeName("struct (anonymous struct at /usr/include/X11/Xutil.h:88:2)")]
        public _aspect__AnonymousRecord max_aspect;

        public int base_width;

        public int base_height;

        public int win_gravity;

        public partial struct _aspect__AnonymousRecord
        {
            public int x;

            public int y;
        }
    }
}
