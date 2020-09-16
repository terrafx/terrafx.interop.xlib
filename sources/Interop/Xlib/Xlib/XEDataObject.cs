// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct XEDataObject
    {
        [FieldOffset(0)]
        [NativeTypeName("Display *")]
        public IntPtr display;

        [FieldOffset(0)]
        [NativeTypeName("GC")]
        public IntPtr gc;

        [FieldOffset(0)]
        [NativeTypeName("Visual *")]
        public Visual* visual;

        [FieldOffset(0)]
        [NativeTypeName("Screen *")]
        public Screen* screen;

        [FieldOffset(0)]
        [NativeTypeName("ScreenFormat *")]
        public ScreenFormat* pixmap_format;

        [FieldOffset(0)]
        [NativeTypeName("XFontStruct *")]
        public XFontStruct* font;
    }
}
