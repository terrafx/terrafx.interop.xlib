// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xproto.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop.Xlib;

public partial struct xGenericReply
{
    public byte type;

    public byte data1;

    [NativeTypeName("CARD16")]
    public ushort sequenceNumber;

    [NativeTypeName("CARD32")]
    public uint length;

    [NativeTypeName("CARD32")]
    public uint data00;

    [NativeTypeName("CARD32")]
    public uint data01;

    [NativeTypeName("CARD32")]
    public uint data02;

    [NativeTypeName("CARD32")]
    public uint data03;

    [NativeTypeName("CARD32")]
    public uint data04;

    [NativeTypeName("CARD32")]
    public uint data05;
}
