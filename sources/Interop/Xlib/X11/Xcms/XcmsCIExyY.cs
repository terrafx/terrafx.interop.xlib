// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xcms.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © Tektronix, Inc.

namespace TerraFX.Interop.Xlib;

public partial struct XcmsCIExyY
{
    [NativeTypeName("XcmsFloat")]
    public double x;

    [NativeTypeName("XcmsFloat")]
    public double y;

    [NativeTypeName("XcmsFloat")]
    public double Y;
}
