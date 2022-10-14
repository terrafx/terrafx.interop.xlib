// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xproto.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop.Xlib;

public partial struct xQueryPointerReply
{
    public byte type;

    [NativeTypeName("BOOL")]
    public byte sameScreen;

    [NativeTypeName("CARD16")]
    public ushort sequenceNumber;

    [NativeTypeName("CARD32")]
    public uint length;

    [NativeTypeName("CARD32")]
    public uint root;

    [NativeTypeName("CARD32")]
    public uint child;

    [NativeTypeName("INT16")]
    public short rootX;

    [NativeTypeName("INT16")]
    public short rootY;

    [NativeTypeName("INT16")]
    public short winX;

    [NativeTypeName("INT16")]
    public short winY;

    [NativeTypeName("CARD16")]
    public ushort mask;

    [NativeTypeName("CARD16")]
    public ushort pad1;

    [NativeTypeName("CARD32")]
    public uint pad;
}
