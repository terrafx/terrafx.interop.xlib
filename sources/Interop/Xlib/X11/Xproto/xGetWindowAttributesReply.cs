// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xproto.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop.Xlib;

public partial struct xGetWindowAttributesReply
{
    public byte type;

    [NativeTypeName("CARD8")]
    public byte backingStore;

    [NativeTypeName("CARD16")]
    public ushort sequenceNumber;

    [NativeTypeName("CARD32")]
    public uint length;

    [NativeTypeName("CARD32")]
    public uint visualID;

    [NativeTypeName("CARD16")]
    public ushort c_class;

    [NativeTypeName("CARD8")]
    public byte bitGravity;

    [NativeTypeName("CARD8")]
    public byte winGravity;

    [NativeTypeName("CARD32")]
    public uint backingBitPlanes;

    [NativeTypeName("CARD32")]
    public uint backingPixel;

    [NativeTypeName("BOOL")]
    public byte saveUnder;

    [NativeTypeName("BOOL")]
    public byte mapInstalled;

    [NativeTypeName("CARD8")]
    public byte mapState;

    [NativeTypeName("BOOL")]
    public byte @override;

    [NativeTypeName("CARD32")]
    public uint colormap;

    [NativeTypeName("CARD32")]
    public uint allEventMasks;

    [NativeTypeName("CARD32")]
    public uint yourEventMask;

    [NativeTypeName("CARD16")]
    public ushort doNotPropagateMask;

    [NativeTypeName("CARD16")]
    public ushort pad;
}
