// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xproto.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop.Xlib;

public partial struct xGetGeometryReply
{
    public byte type;

    [NativeTypeName("CARD8")]
    public byte depth;

    [NativeTypeName("CARD16")]
    public ushort sequenceNumber;

    [NativeTypeName("CARD32")]
    public uint length;

    [NativeTypeName("CARD32")]
    public uint root;

    [NativeTypeName("INT16")]
    public short x;

    [NativeTypeName("INT16")]
    public short y;

    [NativeTypeName("CARD16")]
    public ushort width;

    [NativeTypeName("CARD16")]
    public ushort height;

    [NativeTypeName("CARD16")]
    public ushort borderWidth;

    [NativeTypeName("CARD16")]
    public ushort pad1;

    [NativeTypeName("CARD32")]
    public uint pad2;

    [NativeTypeName("CARD32")]
    public uint pad3;
}
