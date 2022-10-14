// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xproto.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop.Xlib;

public partial struct xVisualType
{
    [NativeTypeName("CARD32")]
    public uint visualID;

    [NativeTypeName("CARD8")]
    public byte c_class;

    [NativeTypeName("CARD8")]
    public byte bitsPerRGB;

    [NativeTypeName("CARD16")]
    public ushort colormapEntries;

    [NativeTypeName("CARD32")]
    public uint redMask;

    [NativeTypeName("CARD32")]
    public uint greenMask;

    [NativeTypeName("CARD32")]
    public uint blueMask;

    [NativeTypeName("CARD32")]
    public uint pad;
}
