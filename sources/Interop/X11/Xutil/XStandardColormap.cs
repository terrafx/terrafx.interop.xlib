// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\Xutil.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group and Digital Equipment Corporation, Maynard, Massachusetts.

using System;

namespace TerraFX.Interop
{
    public partial struct XStandardColormap
    {
        [NativeTypeName("Colormap")]
        public UIntPtr colormap;

        [NativeTypeName("unsigned long")]
        public UIntPtr red_max;

        [NativeTypeName("unsigned long")]
        public UIntPtr red_mult;

        [NativeTypeName("unsigned long")]
        public UIntPtr green_max;

        [NativeTypeName("unsigned long")]
        public UIntPtr green_mult;

        [NativeTypeName("unsigned long")]
        public UIntPtr blue_max;

        [NativeTypeName("unsigned long")]
        public UIntPtr blue_mult;

        [NativeTypeName("unsigned long")]
        public UIntPtr base_pixel;

        [NativeTypeName("VisualID")]
        public UIntPtr visualid;

        [NativeTypeName("XID")]
        public UIntPtr killid;
    }
}
