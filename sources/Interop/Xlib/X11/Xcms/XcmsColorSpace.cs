// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xcms.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © Tektronix, Inc.

namespace TerraFX.Interop.Xlib;

public unsafe partial struct XcmsColorSpace
{
    [NativeTypeName("const char *")]
    public sbyte* prefix;

    [NativeTypeName("XcmsColorFormat")]
    public nuint id;

    [NativeTypeName("XcmsParseStringProc")]
    public delegate* unmanaged<sbyte*, XcmsColor*, int> parseString;

    [NativeTypeName("XcmsFuncListPtr")]
    public delegate* unmanaged<XcmsCCC, XcmsColor*, XcmsColor*, uint, int>* to_CIEXYZ;

    [NativeTypeName("XcmsFuncListPtr")]
    public delegate* unmanaged<XcmsCCC, XcmsColor*, XcmsColor*, uint, int>* from_CIEXYZ;

    public int inverse_flag;
}
