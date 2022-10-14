// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xproto.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop.Xlib;

public partial struct xWindowRoot
{
    [NativeTypeName("CARD32")]
    public uint windowId;

    [NativeTypeName("CARD32")]
    public uint defaultColormap;

    [NativeTypeName("CARD32")]
    public uint whitePixel;

    [NativeTypeName("CARD32")]
    public uint blackPixel;

    [NativeTypeName("CARD32")]
    public uint currentInputMask;

    [NativeTypeName("CARD16")]
    public ushort pixWidth;

    [NativeTypeName("CARD16")]
    public ushort pixHeight;

    [NativeTypeName("CARD16")]
    public ushort mmWidth;

    [NativeTypeName("CARD16")]
    public ushort mmHeight;

    [NativeTypeName("CARD16")]
    public ushort minInstalledMaps;

    [NativeTypeName("CARD16")]
    public ushort maxInstalledMaps;

    [NativeTypeName("CARD32")]
    public uint rootVisualID;

    [NativeTypeName("CARD8")]
    public byte backingStore;

    [NativeTypeName("BOOL")]
    public byte saveUnders;

    [NativeTypeName("CARD8")]
    public byte rootDepth;

    [NativeTypeName("CARD8")]
    public byte nDepths;
}
