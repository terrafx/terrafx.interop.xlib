// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop.Xlib;

public unsafe partial struct Screen
{
    public XExtData* ext_data;

    [NativeTypeName("struct _XDisplay *")]
    public Display* display;

    public Window root;

    public int width;

    public int height;

    public int mwidth;

    public int mheight;

    public int ndepths;

    public Depth* depths;

    public int root_depth;

    public Visual* root_visual;

    public GC default_gc;

    public Colormap cmap;

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
