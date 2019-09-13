// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\Xcms.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © Tektronix, Inc.

using System;

namespace TerraFX.Interop
{
    public static unsafe partial class Xlib
    {
        public const int XcmsFailure = 0;

        public const int XcmsSuccess = 1;

        public const int XcmsSuccessWithCompression = 2;

        [NativeTypeName("XcmsColorFormat")]
        public const uint XcmsUndefinedFormat  = 0x00000000;

        [NativeTypeName("XcmsColorFormat")]
        public const uint XcmsCIEXYZFormat	   = 0x00000001;

        [NativeTypeName("XcmsColorFormat")]
        public const uint XcmsCIEuvYFormat	   = 0x00000002;

        [NativeTypeName("XcmsColorFormat")]
        public const uint XcmsCIExyYFormat	   = 0x00000003;

        [NativeTypeName("XcmsColorFormat")]
        public const uint XcmsCIELabFormat	   = 0x00000004;

        [NativeTypeName("XcmsColorFormat")]
        public const uint XcmsCIELuvFormat	   = 0x00000005;

        [NativeTypeName("XcmsColorFormat")]
        public const uint XcmsTekHVCFormat	   = 0x00000006;

        [NativeTypeName("XcmsColorFormat")]
        public const uint XcmsRGBFormat		   = 0x80000000;

        [NativeTypeName("XcmsColorFormat")]
        public const uint XcmsRGBiFormat = 0x80000001;

        public const int XcmsInitNone = 0x00;

        public const int XcmsInitSuccess = 0x01;

        public const int XcmsInitFailure = 0xFF;

        [return: NativeTypeName("Display *")]
        public static UIntPtr DisplayOfCCC([NativeTypeName("XcmsCCC")] XcmsCCC* ccc) => ccc->dpy;

        public static int ScreenNumberOfCCC([NativeTypeName("XcmsCCC")] XcmsCCC* ccc) => ccc->screenNumber;

        [return: NativeTypeName("Visual *")]
        public static Visual* VisualOfCCC([NativeTypeName("XcmsCCC")] XcmsCCC* ccc) => ccc->visual;

        public static XcmsColor* ClientWhitePointOfCCC([NativeTypeName("XcmsCCC")] XcmsCCC* ccc) => &ccc->clientWhitePt;

        public static XcmsColor* ScreenWhitePointOfCCC([NativeTypeName("XcmsCCC")] XcmsCCC* ccc) => &ccc->pPerScrnInfo->screenWhitePt;

        [return: NativeTypeName("XPointer")]
        public static sbyte* FunctionSetOfCCC([NativeTypeName("XcmsCCC")] XcmsCCC* ccc) => ccc->pPerScrnInfo->functionSet;
    }
}
