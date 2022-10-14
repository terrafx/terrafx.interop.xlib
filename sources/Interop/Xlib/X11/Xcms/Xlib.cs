// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xcms.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © Tektronix, Inc.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Xlib;

public static unsafe partial class Xlib
{
    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsAddColorSpace(XcmsColorSpace* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsAddFunctionSet(XcmsFunctionSet* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsAllocColor(Display* param0, Colormap param1, XcmsColor* param2, [NativeTypeName("XcmsColorFormat")] nuint param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsAllocNamedColor(Display* param0, Colormap param1, [NativeTypeName("const char *")] sbyte* param2, XcmsColor* param3, XcmsColor* param4, [NativeTypeName("XcmsColorFormat")] nuint param5);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern XcmsCCC XcmsCCCOfColormap(Display* param0, Colormap param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsCIELabClipab(XcmsCCC param0, XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, int* param4);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsCIELabClipL(XcmsCCC param0, XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, int* param4);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsCIELabClipLab(XcmsCCC param0, XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, int* param4);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsCIELabQueryMaxC(XcmsCCC param0, [NativeTypeName("XcmsFloat")] double param1, [NativeTypeName("XcmsFloat")] double param2, XcmsColor* param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsCIELabQueryMaxL(XcmsCCC param0, [NativeTypeName("XcmsFloat")] double param1, [NativeTypeName("XcmsFloat")] double param2, XcmsColor* param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsCIELabQueryMaxLC(XcmsCCC param0, [NativeTypeName("XcmsFloat")] double param1, XcmsColor* param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsCIELabQueryMinL(XcmsCCC param0, [NativeTypeName("XcmsFloat")] double param1, [NativeTypeName("XcmsFloat")] double param2, XcmsColor* param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsCIELabToCIEXYZ(XcmsCCC param0, XcmsColor* param1, XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsCIELabWhiteShiftColors(XcmsCCC param0, XcmsColor* param1, XcmsColor* param2, [NativeTypeName("XcmsColorFormat")] nuint param3, XcmsColor* param4, [NativeTypeName("unsigned int")] uint param5, int* param6);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsCIELuvClipL(XcmsCCC param0, XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, int* param4);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsCIELuvClipLuv(XcmsCCC param0, XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, int* param4);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsCIELuvClipuv(XcmsCCC param0, XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, int* param4);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsCIELuvQueryMaxC(XcmsCCC param0, [NativeTypeName("XcmsFloat")] double param1, [NativeTypeName("XcmsFloat")] double param2, XcmsColor* param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsCIELuvQueryMaxL(XcmsCCC param0, [NativeTypeName("XcmsFloat")] double param1, [NativeTypeName("XcmsFloat")] double param2, XcmsColor* param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsCIELuvQueryMaxLC(XcmsCCC param0, [NativeTypeName("XcmsFloat")] double param1, XcmsColor* param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsCIELuvQueryMinL(XcmsCCC param0, [NativeTypeName("XcmsFloat")] double param1, [NativeTypeName("XcmsFloat")] double param2, XcmsColor* param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsCIELuvToCIEuvY(XcmsCCC param0, XcmsColor* param1, XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsCIELuvWhiteShiftColors(XcmsCCC param0, XcmsColor* param1, XcmsColor* param2, [NativeTypeName("XcmsColorFormat")] nuint param3, XcmsColor* param4, [NativeTypeName("unsigned int")] uint param5, int* param6);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsCIEXYZToCIELab(XcmsCCC param0, XcmsColor* param1, XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsCIEXYZToCIEuvY(XcmsCCC param0, XcmsColor* param1, XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsCIEXYZToCIExyY(XcmsCCC param0, XcmsColor* param1, XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsCIEXYZToRGBi(XcmsCCC param0, XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, int* param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsCIEuvYToCIELuv(XcmsCCC param0, XcmsColor* param1, XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsCIEuvYToCIEXYZ(XcmsCCC param0, XcmsColor* param1, XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsCIEuvYToTekHVC(XcmsCCC param0, XcmsColor* param1, XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsCIExyYToCIEXYZ(XcmsCCC param0, XcmsColor* param1, XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern XcmsColor* XcmsClientWhitePointOfCCC(XcmsCCC param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsConvertColors(XcmsCCC param0, XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("XcmsColorFormat")] nuint param3, int* param4);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern XcmsCCC XcmsCreateCCC(Display* param0, int param1, Visual* param2, XcmsColor* param3, [NativeTypeName("XcmsCompressionProc")] delegate* unmanaged<XcmsCCC, XcmsColor*, uint, uint, int*, int> param4, [NativeTypeName("XPointer")] sbyte* param5, [NativeTypeName("XcmsWhiteAdjustProc")] delegate* unmanaged<XcmsCCC, XcmsColor*, XcmsColor*, nuint, XcmsColor*, uint, int*, int> param6, [NativeTypeName("XPointer")] sbyte* param7);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern XcmsCCC XcmsDefaultCCC(Display* param0, int param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern Display* XcmsDisplayOfCCC(XcmsCCC param0);

    [DllImport("libX11", ExactSpelling = true)]
    [return: NativeTypeName("XcmsColorFormat")]
    public static extern nuint XcmsFormatOfPrefix([NativeTypeName("char *")] sbyte* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern void XcmsFreeCCC(XcmsCCC param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsLookupColor(Display* param0, Colormap param1, [NativeTypeName("const char *")] sbyte* param2, XcmsColor* param3, XcmsColor* param4, [NativeTypeName("XcmsColorFormat")] nuint param5);

    [DllImport("libX11", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* XcmsPrefixOfFormat([NativeTypeName("XcmsColorFormat")] nuint param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsQueryBlack(XcmsCCC param0, [NativeTypeName("XcmsColorFormat")] nuint param1, XcmsColor* param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsQueryBlue(XcmsCCC param0, [NativeTypeName("XcmsColorFormat")] nuint param1, XcmsColor* param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsQueryColor(Display* param0, Colormap param1, XcmsColor* param2, [NativeTypeName("XcmsColorFormat")] nuint param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsQueryColors(Display* param0, Colormap param1, XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("XcmsColorFormat")] nuint param4);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsQueryGreen(XcmsCCC param0, [NativeTypeName("XcmsColorFormat")] nuint param1, XcmsColor* param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsQueryRed(XcmsCCC param0, [NativeTypeName("XcmsColorFormat")] nuint param1, XcmsColor* param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsQueryWhite(XcmsCCC param0, [NativeTypeName("XcmsColorFormat")] nuint param1, XcmsColor* param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsRGBiToCIEXYZ(XcmsCCC param0, XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, int* param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsRGBiToRGB(XcmsCCC param0, XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, int* param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsRGBToRGBi(XcmsCCC param0, XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, int* param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsScreenNumberOfCCC(XcmsCCC param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern XcmsColor* XcmsScreenWhitePointOfCCC(XcmsCCC param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern XcmsCCC XcmsSetCCCOfColormap(Display* param0, Colormap param1, XcmsCCC param2);

    [DllImport("libX11", ExactSpelling = true)]
    [return: NativeTypeName("XcmsCompressionProc")]
    public static extern delegate* unmanaged<XcmsCCC, XcmsColor*, uint, uint, int*, int> XcmsSetCompressionProc(XcmsCCC param0, [NativeTypeName("XcmsCompressionProc")] delegate* unmanaged<XcmsCCC, XcmsColor*, uint, uint, int*, int> param1, [NativeTypeName("XPointer")] sbyte* param2);

    [DllImport("libX11", ExactSpelling = true)]
    [return: NativeTypeName("XcmsWhiteAdjustProc")]
    public static extern delegate* unmanaged<XcmsCCC, XcmsColor*, XcmsColor*, nuint, XcmsColor*, uint, int*, int> XcmsSetWhiteAdjustProc(XcmsCCC param0, [NativeTypeName("XcmsWhiteAdjustProc")] delegate* unmanaged<XcmsCCC, XcmsColor*, XcmsColor*, nuint, XcmsColor*, uint, int*, int> param1, [NativeTypeName("XPointer")] sbyte* param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsSetWhitePoint(XcmsCCC param0, XcmsColor* param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsStoreColor(Display* param0, Colormap param1, XcmsColor* param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsStoreColors(Display* param0, Colormap param1, XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3, int* param4);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsTekHVCClipC(XcmsCCC param0, XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, int* param4);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsTekHVCClipV(XcmsCCC param0, XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, int* param4);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsTekHVCClipVC(XcmsCCC param0, XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, int* param4);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsTekHVCQueryMaxC(XcmsCCC param0, [NativeTypeName("XcmsFloat")] double param1, [NativeTypeName("XcmsFloat")] double param2, XcmsColor* param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsTekHVCQueryMaxV(XcmsCCC param0, [NativeTypeName("XcmsFloat")] double param1, [NativeTypeName("XcmsFloat")] double param2, XcmsColor* param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsTekHVCQueryMaxVC(XcmsCCC param0, [NativeTypeName("XcmsFloat")] double param1, XcmsColor* param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsTekHVCQueryMaxVSamples(XcmsCCC param0, [NativeTypeName("XcmsFloat")] double param1, XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsTekHVCQueryMinV(XcmsCCC param0, [NativeTypeName("XcmsFloat")] double param1, [NativeTypeName("XcmsFloat")] double param2, XcmsColor* param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsTekHVCToCIEuvY(XcmsCCC param0, XcmsColor* param1, XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XcmsTekHVCWhiteShiftColors(XcmsCCC param0, XcmsColor* param1, XcmsColor* param2, [NativeTypeName("XcmsColorFormat")] nuint param3, XcmsColor* param4, [NativeTypeName("unsigned int")] uint param5, int* param6);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern Visual* XcmsVisualOfCCC(XcmsCCC param0);

    [NativeTypeName("#define XcmsFailure 0")]
    public const int XcmsFailure = 0;

    [NativeTypeName("#define XcmsSuccess 1")]
    public const int XcmsSuccess = 1;

    [NativeTypeName("#define XcmsSuccessWithCompression 2")]
    public const int XcmsSuccessWithCompression = 2;

    [NativeTypeName("#define XcmsUndefinedFormat (XcmsColorFormat)0x00000000")]
    public const nuint XcmsUndefinedFormat = (nuint)(0x00000000);

    [NativeTypeName("#define XcmsCIEXYZFormat (XcmsColorFormat)0x00000001")]
    public const nuint XcmsCIEXYZFormat = (nuint)(0x00000001);

    [NativeTypeName("#define XcmsCIEuvYFormat (XcmsColorFormat)0x00000002")]
    public const nuint XcmsCIEuvYFormat = (nuint)(0x00000002);

    [NativeTypeName("#define XcmsCIExyYFormat (XcmsColorFormat)0x00000003")]
    public const nuint XcmsCIExyYFormat = (nuint)(0x00000003);

    [NativeTypeName("#define XcmsCIELabFormat (XcmsColorFormat)0x00000004")]
    public const nuint XcmsCIELabFormat = (nuint)(0x00000004);

    [NativeTypeName("#define XcmsCIELuvFormat (XcmsColorFormat)0x00000005")]
    public const nuint XcmsCIELuvFormat = (nuint)(0x00000005);

    [NativeTypeName("#define XcmsTekHVCFormat (XcmsColorFormat)0x00000006")]
    public const nuint XcmsTekHVCFormat = (nuint)(0x00000006);

    [NativeTypeName("#define XcmsRGBFormat (XcmsColorFormat)0x80000000")]
    public const nuint XcmsRGBFormat = (nuint)(0x80000000);

    [NativeTypeName("#define XcmsRGBiFormat (XcmsColorFormat)0x80000001")]
    public const nuint XcmsRGBiFormat = (nuint)(0x80000001);

    [NativeTypeName("#define XcmsInitNone 0x00")]
    public const int XcmsInitNone = 0x00;

    [NativeTypeName("#define XcmsInitSuccess 0x01")]
    public const int XcmsInitSuccess = 0x01;

    [NativeTypeName("#define XcmsInitFailure 0xff")]
    public const int XcmsInitFailure = 0xff;
}
