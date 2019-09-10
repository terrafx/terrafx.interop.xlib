// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from time.h in the Open Group Base Specifications: Issue 7
// Original source is Copyright © The IEEE and The Open Group.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class c
    {
        private const string libraryPath = "c";

        [DllImport(libraryPath, EntryPoint = "clock_getres", CallingConvention = CallingConvention.Cdecl)]
        public static extern int clock_getres([NativeTypeName("clockid_t")] int clock_id, [NativeTypeName("struct timespec *")] timespec* res);

        [DllImport(libraryPath, EntryPoint = "clock_gettime", CallingConvention = CallingConvention.Cdecl)]
        public static extern int clock_gettime([NativeTypeName("clockid_t")] int clock_id, [NativeTypeName("struct timespec *")] timespec* tp);

        [DllImport(libraryPath, EntryPoint = "clock_settime", CallingConvention = CallingConvention.Cdecl)]
        public static extern int clock_settime([NativeTypeName("clockid_t")] int clock_id, [NativeTypeName("struct timespec *")] timespec* tp);
    }
}
