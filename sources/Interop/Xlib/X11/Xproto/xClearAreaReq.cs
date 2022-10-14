// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xproto.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop.Xlib;

public partial struct xClearAreaReq
{
    [NativeTypeName("CARD8")]
    public byte reqType;

    [NativeTypeName("BOOL")]
    public byte exposures;

    [NativeTypeName("CARD16")]
    public ushort length;

    [NativeTypeName("CARD32")]
    public uint window;

    [NativeTypeName("INT16")]
    public short x;

    [NativeTypeName("INT16")]
    public short y;

    [NativeTypeName("CARD16")]
    public ushort width;

    [NativeTypeName("CARD16")]
    public ushort height;
}
