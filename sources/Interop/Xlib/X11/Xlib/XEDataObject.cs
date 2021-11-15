// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Xlib
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct XEDataObject
    {
        [FieldOffset(0)]
        public Display* display;

        [FieldOffset(0)]
        public GC gc;

        [FieldOffset(0)]
        public Visual* visual;

        [FieldOffset(0)]
        public Screen* screen;

        [FieldOffset(0)]
        public ScreenFormat* pixmap_format;

        [FieldOffset(0)]
        public XFontStruct* font;
    }
}
