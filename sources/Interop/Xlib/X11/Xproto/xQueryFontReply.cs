// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xproto.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop.Xlib;

public partial struct xQueryFontReply
{
    public byte type;

    public byte pad1;

    [NativeTypeName("CARD16")]
    public ushort sequenceNumber;

    [NativeTypeName("CARD32")]
    public uint length;

    public xCharInfo minBounds;

    [NativeTypeName("CARD32")]
    public uint walign1;

    public xCharInfo maxBounds;

    [NativeTypeName("CARD32")]
    public uint walign2;

    [NativeTypeName("CARD16")]
    public ushort minCharOrByte2;

    [NativeTypeName("CARD16")]
    public ushort maxCharOrByte2;

    [NativeTypeName("CARD16")]
    public ushort defaultChar;

    [NativeTypeName("CARD16")]
    public ushort nFontProps;

    [NativeTypeName("CARD8")]
    public byte drawDirection;

    [NativeTypeName("CARD8")]
    public byte minByte1;

    [NativeTypeName("CARD8")]
    public byte maxByte1;

    [NativeTypeName("BOOL")]
    public byte allCharsExist;

    [NativeTypeName("INT16")]
    public short fontAscent;

    [NativeTypeName("INT16")]
    public short fontDescent;

    [NativeTypeName("CARD32")]
    public uint nCharInfos;
}
