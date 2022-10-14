// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xproto.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop.Xlib;

public partial struct xChangePointerControlReq
{
    [NativeTypeName("CARD8")]
    public byte reqType;

    public byte pad;

    [NativeTypeName("CARD16")]
    public ushort length;

    [NativeTypeName("INT16")]
    public short accelNum;

    [NativeTypeName("INT16")]
    public short accelDenum;

    [NativeTypeName("INT16")]
    public short threshold;

    [NativeTypeName("BOOL")]
    public byte doAccel;

    [NativeTypeName("BOOL")]
    public byte doThresh;
}
