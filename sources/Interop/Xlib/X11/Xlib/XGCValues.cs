// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop.Xlib;

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

    public Pixmap tile;

    public Pixmap stipple;

    public int ts_x_origin;

    public int ts_y_origin;

    public Font font;

    public int subwindow_mode;

    public int graphics_exposures;

    public int clip_x_origin;

    public int clip_y_origin;

    public Pixmap clip_mask;

    public int dash_offset;

    [NativeTypeName("char")]
    public sbyte dashes;
}
