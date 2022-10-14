// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop.Xlib;

public unsafe partial struct XExtData
{
    public int number;

    [NativeTypeName("struct _XExtData *")]
    public XExtData* next;

    [NativeTypeName("int (*)(struct _XExtData *)")]
    public delegate* unmanaged<XExtData*, int> free_private;

    [NativeTypeName("XPointer")]
    public sbyte* private_data;
}
