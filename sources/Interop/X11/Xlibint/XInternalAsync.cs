// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\Xlibint.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct XInternalAsync
    {
        [NativeTypeName("struct XInternalAsync *")]
        public XInternalAsync* next;

        [NativeTypeName("int (*)(Display *, xReply *, char *, int, XPointer)")]
        public IntPtr handler;

        [NativeTypeName("XPointer")]
        public sbyte* data;
    }
}
