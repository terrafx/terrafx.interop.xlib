// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop.Xlib;

public unsafe partial struct Visual
{
    public XExtData* ext_data;

    public VisualID visualid;

    public int c_class;

    [NativeTypeName("unsigned long")]
    public nuint red_mask;

    [NativeTypeName("unsigned long")]
    public nuint green_mask;

    [NativeTypeName("unsigned long")]
    public nuint blue_mask;

    public int bits_per_rgb;

    public int map_entries;
}
