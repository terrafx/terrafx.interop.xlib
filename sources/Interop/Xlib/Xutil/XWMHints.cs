// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\Xutil.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group and Digital Equipment Corporation, Maynard, Massachusetts.

using System;

namespace TerraFX.Interop
{
    public partial struct XWMHints
    {
        [NativeTypeName("long")]
        public IntPtr flags;

        public int input;

        public int initial_state;

        [NativeTypeName("Pixmap")]
        public UIntPtr icon_pixmap;

        [NativeTypeName("Window")]
        public UIntPtr icon_window;

        public int icon_x;

        public int icon_y;

        [NativeTypeName("Pixmap")]
        public UIntPtr icon_mask;

        [NativeTypeName("XID")]
        public UIntPtr window_group;
    }
}
