// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct XExtData
    {
        public int number;

        [NativeTypeName("struct XExtData *")]
        public XExtData* next;

        [NativeTypeName("int (*)(struct XExtData *)")]
        public IntPtr free_private;

        [NativeTypeName("XPointer")]
        public sbyte* private_data;
    }
}
