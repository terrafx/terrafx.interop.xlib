// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct Screen
    {
        [NativeTypeName("XExtData *")]
        public XExtData* ext_data;

        [NativeTypeName("struct _XDisplay *")]
        public IntPtr display;

        [NativeTypeName("Window")]
        public nuint root;

        public int width;

        public int height;

        public int mwidth;

        public int mheight;

        public int ndepths;

        [NativeTypeName("Depth *")]
        public Depth* depths;

        public int root_depth;

        [NativeTypeName("Visual *")]
        public Visual* root_visual;

        [NativeTypeName("GC")]
        public IntPtr default_gc;

        [NativeTypeName("Colormap")]
        public nuint cmap;

        [NativeTypeName("unsigned long")]
        public nuint white_pixel;

        [NativeTypeName("unsigned long")]
        public nuint black_pixel;

        public int max_maps;

        public int min_maps;

        public int backing_store;

        public int save_unders;

        [NativeTypeName("long")]
        public nint root_input_mask;
    }
}
