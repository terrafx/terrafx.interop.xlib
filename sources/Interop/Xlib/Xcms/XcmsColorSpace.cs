// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xcms.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © Tektronix, Inc.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct XcmsColorSpace
    {
        [NativeTypeName("const char *")]
        public sbyte* prefix;

        [NativeTypeName("XcmsColorFormat")]
        public nuint id;

        [NativeTypeName("XcmsParseStringProc")]
        public IntPtr parseString;

        [NativeTypeName("XcmsFuncListPtr")]
        public IntPtr* to_CIEXYZ;

        [NativeTypeName("XcmsFuncListPtr")]
        public IntPtr* from_CIEXYZ;

        public int inverse_flag;
    }
}
