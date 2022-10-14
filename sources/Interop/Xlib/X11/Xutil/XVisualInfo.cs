// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xutil.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop.Xlib;

public unsafe partial struct XVisualInfo
{
    public Visual* visual;

    public VisualID visualid;

    public int screen;

    public int depth;

    public int c_class;

    [NativeTypeName("unsigned long")]
    public nuint red_mask;

    [NativeTypeName("unsigned long")]
    public nuint green_mask;

    [NativeTypeName("unsigned long")]
    public nuint blue_mask;

    public int colormap_size;

    public int bits_per_rgb;
}
