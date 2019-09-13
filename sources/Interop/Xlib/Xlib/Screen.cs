// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct Screen
    {
        [NativeTypeName("XExtData *")]
        public XExtData* ext_data;

        [NativeTypeName("struct XDisplay *")]
        public UIntPtr display;

        [NativeTypeName("Window")]
        public UIntPtr root;

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
        public XGC* default_gc;

        [NativeTypeName("Colormap")]
        public UIntPtr cmap;

        [NativeTypeName("unsigned long")]
        public UIntPtr white_pixel;

        [NativeTypeName("unsigned long")]
        public UIntPtr black_pixel;

        public int max_maps;

        public int min_maps;

        public int backing_store;

        public int save_unders;

        [NativeTypeName("long")]
        public IntPtr root_input_mask;
    }
}
