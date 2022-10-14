// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xproto.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop.Xlib;

public partial struct xQueryTextExtentsReply
{
    public byte type;

    [NativeTypeName("CARD8")]
    public byte drawDirection;

    [NativeTypeName("CARD16")]
    public ushort sequenceNumber;

    [NativeTypeName("CARD32")]
    public uint length;

    [NativeTypeName("INT16")]
    public short fontAscent;

    [NativeTypeName("INT16")]
    public short fontDescent;

    [NativeTypeName("INT16")]
    public short overallAscent;

    [NativeTypeName("INT16")]
    public short overallDescent;

    [NativeTypeName("INT32")]
    public int overallWidth;

    [NativeTypeName("INT32")]
    public int overallLeft;

    [NativeTypeName("INT32")]
    public int overallRight;

    [NativeTypeName("CARD32")]
    public uint pad;
}
