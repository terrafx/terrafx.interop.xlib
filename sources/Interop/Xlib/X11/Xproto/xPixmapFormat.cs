// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xproto.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop.Xlib;

public partial struct xPixmapFormat
{
    [NativeTypeName("CARD8")]
    public byte depth;

    [NativeTypeName("CARD8")]
    public byte bitsPerPixel;

    [NativeTypeName("CARD8")]
    public byte scanLinePad;

    [NativeTypeName("CARD8")]
    public byte pad1;

    [NativeTypeName("CARD32")]
    public uint pad2;
}
