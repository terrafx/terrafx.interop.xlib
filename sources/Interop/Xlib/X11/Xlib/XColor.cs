// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop.Xlib;

public partial struct XColor
{
    [NativeTypeName("unsigned long")]
    public nuint pixel;

    [NativeTypeName("unsigned short")]
    public ushort red;

    [NativeTypeName("unsigned short")]
    public ushort green;

    [NativeTypeName("unsigned short")]
    public ushort blue;

    [NativeTypeName("char")]
    public sbyte flags;

    [NativeTypeName("char")]
    public sbyte pad;
}
