// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xutil.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop.Xlib;

public unsafe partial struct XTextProperty
{
    [NativeTypeName("unsigned char *")]
    public byte* value;

    public Atom encoding;

    public int format;

    [NativeTypeName("unsigned long")]
    public nuint nitems;
}
