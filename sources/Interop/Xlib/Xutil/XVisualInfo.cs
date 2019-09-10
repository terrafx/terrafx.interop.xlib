// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\Xutil.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group and Digital Equipment Corporation, Maynard, Massachusetts.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct XVisualInfo
    {
        [NativeTypeName("Visual *")]
        public Visual* visual;

        [NativeTypeName("VisualID")]
        public UIntPtr visualid;

        public int screen;

        public int depth;

        public int c_class;

        [NativeTypeName("unsigned long")]
        public UIntPtr red_mask;

        [NativeTypeName("unsigned long")]
        public UIntPtr green_mask;

        [NativeTypeName("unsigned long")]
        public UIntPtr blue_mask;

        public int colormap_size;

        public int bits_per_rgb;
    }
}
