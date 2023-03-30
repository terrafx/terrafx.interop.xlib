// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xcms.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © Tektronix, Inc.

namespace TerraFX.Interop.Xlib;

public unsafe partial struct XcmsPerScrnInfo
{
    public XcmsColor screenWhitePt;

    [NativeTypeName("XPointer")]
    public sbyte* functionSet;

    [NativeTypeName("XPointer")]
    public sbyte* screenData;

    [NativeTypeName("unsigned char")]
    public byte state;

    [NativeTypeName("char[3]")]
    public fixed sbyte pad[3];
}
