// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xcms.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © Tektronix, Inc.

namespace TerraFX.Interop.Xlib;

public unsafe partial struct XcmsCCCRec
{
    public Display* dpy;

    public int screenNumber;

    public Visual* visual;

    public XcmsColor clientWhitePt;

    [NativeTypeName("XcmsCompressionProc")]
    public delegate* unmanaged<XcmsCCC, XcmsColor*, uint, uint, int*, int> gamutCompProc;

    [NativeTypeName("XPointer")]
    public sbyte* gamutCompClientData;

    [NativeTypeName("XcmsWhiteAdjustProc")]
    public delegate* unmanaged<XcmsCCC, XcmsColor*, XcmsColor*, nuint, XcmsColor*, uint, int*, int> whitePtAdjProc;

    [NativeTypeName("XPointer")]
    public sbyte* whitePtAdjClientData;

    public XcmsPerScrnInfo* pPerScrnInfo;
}
