// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct XWindowAttributes
    {
        public int x;

        public int y;

        public int width;

        public int height;

        public int border_width;

        public int depth;

        [NativeTypeName("Visual *")]
        public Visual* visual;

        [NativeTypeName("Window")]
        public UIntPtr root;

        public int c_class;

        public int bit_gravity;

        public int win_gravity;

        public int backing_store;

        [NativeTypeName("unsigned long")]
        public UIntPtr backing_planes;

        [NativeTypeName("unsigned long")]
        public UIntPtr backing_pixel;

        public int save_under;

        [NativeTypeName("Colormap")]
        public UIntPtr colormap;

        public int map_installed;

        public int map_state;

        [NativeTypeName("long")]
        public IntPtr all_event_masks;

        [NativeTypeName("long")]
        public IntPtr your_event_mask;

        [NativeTypeName("long")]
        public IntPtr do_not_propagate_mask;

        public int override_redirect;

        [NativeTypeName("Screen *")]
        public Screen* screen;
    }
}
