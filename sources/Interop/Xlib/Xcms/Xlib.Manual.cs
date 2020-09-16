// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xcms.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © Tektronix, Inc.

using System;

namespace TerraFX.Interop
{
    public static unsafe partial class Xlib
    {
        [return: NativeTypeName("Display *")]
        public static IntPtr DisplayOfCCC([NativeTypeName("XcmsCCC")] XcmsCCC* ccc) => ccc->dpy;

        public static int ScreenNumberOfCCC([NativeTypeName("XcmsCCC")] XcmsCCC* ccc) => ccc->screenNumber;

        [return: NativeTypeName("Visual *")]
        public static Visual* VisualOfCCC([NativeTypeName("XcmsCCC")] XcmsCCC* ccc) => ccc->visual;

        public static XcmsColor* ClientWhitePointOfCCC([NativeTypeName("XcmsCCC")] XcmsCCC* ccc) => &ccc->clientWhitePt;

        public static XcmsColor* ScreenWhitePointOfCCC([NativeTypeName("XcmsCCC")] XcmsCCC* ccc) => &ccc->pPerScrnInfo->screenWhitePt;

        [return: NativeTypeName("XPointer")]
        public static sbyte* FunctionSetOfCCC([NativeTypeName("XcmsCCC")] XcmsCCC* ccc) => ccc->pPerScrnInfo->functionSet;
    }
}
