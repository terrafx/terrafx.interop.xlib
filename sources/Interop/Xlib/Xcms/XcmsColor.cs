// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\Xcms.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © Tektronix, Inc.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct XcmsColor
    {
        [NativeTypeName("union (anonymous union at /usr/include/X11/Xcms.h:176:5)")]
        public _spec__AnonymousRecord spec;

        [NativeTypeName("unsigned long")]
        public UIntPtr pixel;

        [NativeTypeName("XcmsColorFormat")]
        public UIntPtr format;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _spec__AnonymousRecord
        {
            [FieldOffset(0)]
            public XcmsRGB RGB;

            [FieldOffset(0)]
            public XcmsRGBi RGBi;

            [FieldOffset(0)]
            public XcmsCIEXYZ CIEXYZ;

            [FieldOffset(0)]
            public XcmsCIEuvY CIEuvY;

            [FieldOffset(0)]
            public XcmsCIExyY CIExyY;

            [FieldOffset(0)]
            public XcmsCIELab CIELab;

            [FieldOffset(0)]
            public XcmsCIELuv CIELuv;

            [FieldOffset(0)]
            public XcmsTekHVC TekHVC;

            [FieldOffset(0)]
            public XcmsPad Pad;
        }
    }
}
