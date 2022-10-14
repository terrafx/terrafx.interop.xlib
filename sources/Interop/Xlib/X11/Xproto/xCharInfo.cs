// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xproto.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop.Xlib;

public partial struct xCharInfo
{
    [NativeTypeName("INT16")]
    public short leftSideBearing;

    [NativeTypeName("INT16")]
    public short rightSideBearing;

    [NativeTypeName("INT16")]
    public short characterWidth;

    [NativeTypeName("INT16")]
    public short ascent;

    [NativeTypeName("INT16")]
    public short descent;

    [NativeTypeName("CARD16")]
    public ushort attributes;
}
