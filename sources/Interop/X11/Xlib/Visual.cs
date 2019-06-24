// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct Visual
    {
        [NativeTypeName("XExtData *")]
        public XExtData* ext_data;

        [NativeTypeName("VisualID")]
        public UIntPtr visualid;

        public int c_class;

        [NativeTypeName("unsigned long")]
        public UIntPtr red_mask;

        [NativeTypeName("unsigned long")]
        public UIntPtr green_mask;

        [NativeTypeName("unsigned long")]
        public UIntPtr blue_mask;

        public int bits_per_rgb;

        public int map_entries;
    }
}
