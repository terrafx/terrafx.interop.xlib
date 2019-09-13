// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct XImage
    {
        public partial struct funcs
        {
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: NativeTypeName("XImage *")]
            public delegate XImage* _create_image([NativeTypeName("struct XDisplay*")] UIntPtr display, Visual* visual, [NativeTypeName("unsigned int")] uint depth, int format, int offset, [NativeTypeName("char*")] sbyte* data, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height, int bitmap_pad, int bytes_per_line);

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate int _destroy_image([NativeTypeName("struct _XImage *")] XImage* param0);

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: NativeTypeName("unsigned long")]
            public delegate UIntPtr _get_pixel([NativeTypeName("struct _XImage *")] XImage* param0, int param1, int param2);

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate int _put_pixel([NativeTypeName("struct _XImage *")] XImage* param0, int param1, int param2, [NativeTypeName("unsigned long")] UIntPtr param3);

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: NativeTypeName("struct XImage *")]
            public delegate XImage* _sub_image([NativeTypeName("struct _XImage *")] XImage* param0, int param1, int param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int")] uint param4);

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate int _add_pixel([NativeTypeName("struct _XImage *")] XImage* param0, [NativeTypeName("long")] IntPtr param1);
        }
    }
}
