// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public unsafe delegate void XConnectionWatchProc([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("XPointer")] sbyte* param1, int param2, int param3, [NativeTypeName("XPointer *")] sbyte** param4);
}
