// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xproto.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop.Xlib;

public partial struct xConnSetup
{
    [NativeTypeName("CARD32")]
    public uint release;

    [NativeTypeName("CARD32")]
    public uint ridBase;

    [NativeTypeName("CARD32")]
    public uint ridMask;

    [NativeTypeName("CARD32")]
    public uint motionBufferSize;

    [NativeTypeName("CARD16")]
    public ushort nbytesVendor;

    [NativeTypeName("CARD16")]
    public ushort maxRequestSize;

    [NativeTypeName("CARD8")]
    public byte numRoots;

    [NativeTypeName("CARD8")]
    public byte numFormats;

    [NativeTypeName("CARD8")]
    public byte imageByteOrder;

    [NativeTypeName("CARD8")]
    public byte bitmapBitOrder;

    [NativeTypeName("CARD8")]
    public byte bitmapScanlineUnit;

    [NativeTypeName("CARD8")]
    public byte bitmapScanlinePad;

    [NativeTypeName("CARD8")]
    public byte minKeyCode;

    [NativeTypeName("CARD8")]
    public byte maxKeyCode;

    [NativeTypeName("CARD32")]
    public uint pad2;
}
