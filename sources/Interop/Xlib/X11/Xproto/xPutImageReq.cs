// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xproto.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop.Xlib;

public partial struct xPutImageReq
{
    [NativeTypeName("CARD8")]
    public byte reqType;

    [NativeTypeName("CARD8")]
    public byte format;

    [NativeTypeName("CARD16")]
    public ushort length;

    [NativeTypeName("CARD32")]
    public uint drawable;

    [NativeTypeName("CARD32")]
    public uint gc;

    [NativeTypeName("CARD16")]
    public ushort width;

    [NativeTypeName("CARD16")]
    public ushort height;

    [NativeTypeName("INT16")]
    public short dstX;

    [NativeTypeName("INT16")]
    public short dstY;

    [NativeTypeName("CARD8")]
    public byte leftPad;

    [NativeTypeName("CARD8")]
    public byte depth;

    [NativeTypeName("CARD16")]
    public ushort pad;
}
