// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xcms.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © Tektronix, Inc.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct XcmsCCC
    {
        [NativeTypeName("Display *")]
        public IntPtr dpy;

        public int screenNumber;

        [NativeTypeName("Visual *")]
        public Visual* visual;

        public XcmsColor clientWhitePt;

        [NativeTypeName("XcmsCompressionProc")]
        public IntPtr gamutCompProc;

        [NativeTypeName("XPointer")]
        public sbyte* gamutCompClientData;

        [NativeTypeName("XcmsWhiteAdjustProc")]
        public IntPtr whitePtAdjProc;

        [NativeTypeName("XPointer")]
        public sbyte* whitePtAdjClientData;

        [NativeTypeName("XcmsPerScrnInfo *")]
        public XcmsPerScrnInfo* pPerScrnInfo;
    }
}
