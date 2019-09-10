// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\Xlibint.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct XConnectionInfo
    {
        public int fd;

        [NativeTypeName("_XInternalConnectionProc")]
        public IntPtr read_callback;

        [NativeTypeName("XPointer")]
        public sbyte* call_data;

        [NativeTypeName("XPointer *")]
        public sbyte** watch_data;

        [NativeTypeName("struct XConnectionInfo *")]
        public XConnectionInfo* next;
    }
}
