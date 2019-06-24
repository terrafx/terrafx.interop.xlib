// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\Xlibint.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct XExten
    {
        [NativeTypeName("struct XExten *")]
        public XExten* next;

        public XExtCodes codes;

        [NativeTypeName("CreateGCType")]
        public IntPtr create_GC;

        [NativeTypeName("CopyGCType")]
        public IntPtr copy_GC;

        [NativeTypeName("FlushGCType")]
        public IntPtr flush_GC;

        [NativeTypeName("FreeGCType")]
        public IntPtr free_GC;

        [NativeTypeName("CreateFontType")]
        public IntPtr create_Font;

        [NativeTypeName("FreeFontType")]
        public IntPtr free_Font;

        [NativeTypeName("CloseDisplayType")]
        public IntPtr close_display;

        [NativeTypeName("ErrorType")]
        public IntPtr error;

        [NativeTypeName("ErrorStringType")]
        public IntPtr error_string;

        [NativeTypeName("char *")]
        public sbyte* name;

        [NativeTypeName("PrintErrorType")]
        public IntPtr error_values;

        [NativeTypeName("BeforeFlushType")]
        public IntPtr before_flush;

        [NativeTypeName("struct XExten *")]
        public XExten* next_flush;
    }
}
