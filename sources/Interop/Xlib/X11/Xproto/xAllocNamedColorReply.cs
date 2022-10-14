// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xproto.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop.Xlib;

public partial struct xAllocNamedColorReply
{
    public byte type;

    public byte pad1;

    [NativeTypeName("CARD16")]
    public ushort sequenceNumber;

    [NativeTypeName("CARD32")]
    public uint length;

    [NativeTypeName("CARD32")]
    public uint pixel;

    [NativeTypeName("CARD16")]
    public ushort exactRed;

    [NativeTypeName("CARD16")]
    public ushort exactGreen;

    [NativeTypeName("CARD16")]
    public ushort exactBlue;

    [NativeTypeName("CARD16")]
    public ushort screenRed;

    [NativeTypeName("CARD16")]
    public ushort screenGreen;

    [NativeTypeName("CARD16")]
    public ushort screenBlue;

    [NativeTypeName("CARD32")]
    public uint pad2;

    [NativeTypeName("CARD32")]
    public uint pad3;
}
