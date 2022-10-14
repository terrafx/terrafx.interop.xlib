// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xproto.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop.Xlib;

public partial struct xAllocColorPlanesReply
{
    public byte type;

    public byte pad1;

    [NativeTypeName("CARD16")]
    public ushort sequenceNumber;

    [NativeTypeName("CARD32")]
    public uint length;

    [NativeTypeName("CARD16")]
    public ushort nPixels;

    [NativeTypeName("CARD16")]
    public ushort pad2;

    [NativeTypeName("CARD32")]
    public uint redMask;

    [NativeTypeName("CARD32")]
    public uint greenMask;

    [NativeTypeName("CARD32")]
    public uint blueMask;

    [NativeTypeName("CARD32")]
    public uint pad3;

    [NativeTypeName("CARD32")]
    public uint pad4;
}
