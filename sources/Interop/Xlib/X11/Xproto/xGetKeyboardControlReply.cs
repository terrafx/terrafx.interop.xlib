// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xproto.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop.Xlib;

public unsafe partial struct xGetKeyboardControlReply
{
    public byte type;

    [NativeTypeName("BOOL")]
    public byte globalAutoRepeat;

    [NativeTypeName("CARD16")]
    public ushort sequenceNumber;

    [NativeTypeName("CARD32")]
    public uint length;

    [NativeTypeName("CARD32")]
    public uint ledMask;

    [NativeTypeName("CARD8")]
    public byte keyClickPercent;

    [NativeTypeName("CARD8")]
    public byte bellPercent;

    [NativeTypeName("CARD16")]
    public ushort bellPitch;

    [NativeTypeName("CARD16")]
    public ushort bellDuration;

    [NativeTypeName("CARD16")]
    public ushort pad;

    [NativeTypeName("BYTE[32]")]
    public fixed byte map[32];
}
