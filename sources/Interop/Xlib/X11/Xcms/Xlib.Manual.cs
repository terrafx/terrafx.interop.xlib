// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xcms.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © Tektronix, Inc.

namespace TerraFX.Interop.Xlib;

public static unsafe partial class Xlib
{
    public static Display* DisplayOfCCC(XcmsCCC ccc) => ((XcmsCCCRec*)(ccc))->dpy;

    public static int ScreenNumberOfCCC(XcmsCCC ccc) => ((XcmsCCCRec*)(ccc))->screenNumber;

    public static Visual* VisualOfCCC(XcmsCCC ccc) => ((XcmsCCCRec*)(ccc))->visual;

    public static XcmsColor* ClientWhitePointOfCCC(XcmsCCC ccc) => &((XcmsCCCRec*)(ccc))->clientWhitePt;

    public static XcmsColor* ScreenWhitePointOfCCC(XcmsCCC ccc) => &((XcmsCCCRec*)(ccc))->pPerScrnInfo->screenWhitePt;

    [return: NativeTypeName("XPointer")]
    public static sbyte* FunctionSetOfCCC(XcmsCCC ccc) => ((XcmsCCCRec*)(ccc))->pPerScrnInfo->functionSet;
}
