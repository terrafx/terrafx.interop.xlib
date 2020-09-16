// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop
{
    public partial struct XGCValues
    {
        public int function;

        [NativeTypeName("unsigned long")]
        public nuint plane_mask;

        [NativeTypeName("unsigned long")]
        public nuint foreground;

        [NativeTypeName("unsigned long")]
        public nuint background;

        public int line_width;

        public int line_style;

        public int cap_style;

        public int join_style;

        public int fill_style;

        public int fill_rule;

        public int arc_mode;

        [NativeTypeName("Pixmap")]
        public nuint tile;

        [NativeTypeName("Pixmap")]
        public nuint stipple;

        public int ts_x_origin;

        public int ts_y_origin;

        [NativeTypeName("Font")]
        public nuint font;

        public int subwindow_mode;

        public int graphics_exposures;

        public int clip_x_origin;

        public int clip_y_origin;

        [NativeTypeName("Pixmap")]
        public nuint clip_mask;

        public int dash_offset;

        [NativeTypeName("char")]
        public sbyte dashes;
    }
}
