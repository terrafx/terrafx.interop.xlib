// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct XPrivDisplay
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [return: NativeTypeName("XID")]
        public delegate UIntPtr _resource_alloc([NativeTypeName("struct XDisplay *")] UIntPtr param0);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int _private15([NativeTypeName("struct XDisplay*")] UIntPtr param0);
    }
}
