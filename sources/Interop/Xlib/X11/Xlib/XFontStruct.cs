// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop.Xlib;

public unsafe partial struct XFontStruct
{
    public XExtData* ext_data;

    public Font fid;

    [NativeTypeName("unsigned int")]
    public uint direction;

    [NativeTypeName("unsigned int")]
    public uint min_char_or_byte2;

    [NativeTypeName("unsigned int")]
    public uint max_char_or_byte2;

    [NativeTypeName("unsigned int")]
    public uint min_byte1;

    [NativeTypeName("unsigned int")]
    public uint max_byte1;

    public int all_chars_exist;

    [NativeTypeName("unsigned int")]
    public uint default_char;

    public int n_properties;

    public XFontProp* properties;

    public XCharStruct min_bounds;

    public XCharStruct max_bounds;

    public XCharStruct* per_char;

    public int ascent;

    public int descent;
}
