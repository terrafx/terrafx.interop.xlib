// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop
{
    public unsafe partial struct XIMCallback
    {
        [NativeTypeName("XPointer")]
        public sbyte* client_data;

        [NativeTypeName("XIMProc")]
        public delegate* unmanaged<XIM, sbyte*, sbyte*, void> callback;
    }
}
