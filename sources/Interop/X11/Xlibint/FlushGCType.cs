// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\Xlibint.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int FlushGCType([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("GC")] XGC* param1, [NativeTypeName("XExtCodes *")] XExtCodes* param2);
}
