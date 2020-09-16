// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xcms.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © Tektronix, Inc.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Xlib
    {
        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsAddColorSpace([NativeTypeName("XcmsColorSpace *")] XcmsColorSpace* param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsAddFunctionSet([NativeTypeName("XcmsFunctionSet *")] XcmsFunctionSet* param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsAllocColor([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Colormap")] nuint param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2, [NativeTypeName("XcmsColorFormat")] nuint param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsAllocNamedColor([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Colormap")] nuint param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("XcmsColor *")] XcmsColor* param3, [NativeTypeName("XcmsColor *")] XcmsColor* param4, [NativeTypeName("XcmsColorFormat")] nuint param5);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("XcmsCCC")]
        public static extern XcmsCCC* XcmsCCCOfColormap([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Colormap")] nuint param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsCIELabClipab([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("int *")] int* param4);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsCIELabClipL([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("int *")] int* param4);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsCIELabClipLab([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("int *")] int* param4);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsCIELabQueryMaxC([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsFloat")] double param1, [NativeTypeName("XcmsFloat")] double param2, [NativeTypeName("XcmsColor *")] XcmsColor* param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsCIELabQueryMaxL([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsFloat")] double param1, [NativeTypeName("XcmsFloat")] double param2, [NativeTypeName("XcmsColor *")] XcmsColor* param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsCIELabQueryMaxLC([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsFloat")] double param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsCIELabQueryMinL([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsFloat")] double param1, [NativeTypeName("XcmsFloat")] double param2, [NativeTypeName("XcmsColor *")] XcmsColor* param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsCIELabToCIEXYZ([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsCIELabWhiteShiftColors([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2, [NativeTypeName("XcmsColorFormat")] nuint param3, [NativeTypeName("XcmsColor *")] XcmsColor* param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("int *")] int* param6);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsCIELuvClipL([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("int *")] int* param4);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsCIELuvClipLuv([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("int *")] int* param4);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsCIELuvClipuv([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("int *")] int* param4);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsCIELuvQueryMaxC([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsFloat")] double param1, [NativeTypeName("XcmsFloat")] double param2, [NativeTypeName("XcmsColor *")] XcmsColor* param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsCIELuvQueryMaxL([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsFloat")] double param1, [NativeTypeName("XcmsFloat")] double param2, [NativeTypeName("XcmsColor *")] XcmsColor* param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsCIELuvQueryMaxLC([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsFloat")] double param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsCIELuvQueryMinL([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsFloat")] double param1, [NativeTypeName("XcmsFloat")] double param2, [NativeTypeName("XcmsColor *")] XcmsColor* param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsCIELuvToCIEuvY([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsCIELuvWhiteShiftColors([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2, [NativeTypeName("XcmsColorFormat")] nuint param3, [NativeTypeName("XcmsColor *")] XcmsColor* param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("int *")] int* param6);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsCIEXYZToCIELab([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsCIEXYZToCIEuvY([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsCIEXYZToCIExyY([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsCIEXYZToRGBi([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("int *")] int* param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsCIEuvYToCIELuv([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsCIEuvYToCIEXYZ([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsCIEuvYToTekHVC([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsCIExyYToCIEXYZ([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("XcmsColor *")]
        public static extern XcmsColor* XcmsClientWhitePointOfCCC([NativeTypeName("XcmsCCC")] XcmsCCC* param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsConvertColors([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("XcmsColorFormat")] nuint param3, [NativeTypeName("int *")] int* param4);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("XcmsCCC")]
        public static extern XcmsCCC* XcmsCreateCCC([NativeTypeName("Display *")] IntPtr param0, int param1, [NativeTypeName("Visual *")] Visual* param2, [NativeTypeName("XcmsColor *")] XcmsColor* param3, [NativeTypeName("XcmsCompressionProc")] delegate* unmanaged<XcmsCCC*, XcmsColor*, uint, uint, int*, int> param4, [NativeTypeName("XPointer")] sbyte* param5, [NativeTypeName("XcmsWhiteAdjustProc")] delegate* unmanaged<XcmsCCC*, XcmsColor*, XcmsColor*, nuint, XcmsColor*, uint, int*, int> param6, [NativeTypeName("XPointer")] sbyte* param7);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("XcmsCCC")]
        public static extern XcmsCCC* XcmsDefaultCCC([NativeTypeName("Display *")] IntPtr param0, int param1);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("Display *")]
        public static extern IntPtr XcmsDisplayOfCCC([NativeTypeName("XcmsCCC")] XcmsCCC* param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("XcmsColorFormat")]
        public static extern nuint XcmsFormatOfPrefix([NativeTypeName("char *")] sbyte* param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern void XcmsFreeCCC([NativeTypeName("XcmsCCC")] XcmsCCC* param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsLookupColor([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Colormap")] nuint param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("XcmsColor *")] XcmsColor* param3, [NativeTypeName("XcmsColor *")] XcmsColor* param4, [NativeTypeName("XcmsColorFormat")] nuint param5);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XcmsPrefixOfFormat([NativeTypeName("XcmsColorFormat")] nuint param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsQueryBlack([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColorFormat")] nuint param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsQueryBlue([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColorFormat")] nuint param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsQueryColor([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Colormap")] nuint param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2, [NativeTypeName("XcmsColorFormat")] nuint param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsQueryColors([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Colormap")] nuint param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("XcmsColorFormat")] nuint param4);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsQueryGreen([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColorFormat")] nuint param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsQueryRed([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColorFormat")] nuint param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsQueryWhite([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColorFormat")] nuint param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsRGBiToCIEXYZ([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("int *")] int* param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsRGBiToRGB([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("int *")] int* param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsRGBToRGBi([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("int *")] int* param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsScreenNumberOfCCC([NativeTypeName("XcmsCCC")] XcmsCCC* param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("XcmsColor *")]
        public static extern XcmsColor* XcmsScreenWhitePointOfCCC([NativeTypeName("XcmsCCC")] XcmsCCC* param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("XcmsCCC")]
        public static extern XcmsCCC* XcmsSetCCCOfColormap([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Colormap")] nuint param1, [NativeTypeName("XcmsCCC")] XcmsCCC* param2);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("XcmsCompressionProc")]
        public static extern delegate* unmanaged<XcmsCCC*, XcmsColor*, uint, uint, int*, int> XcmsSetCompressionProc([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsCompressionProc")] delegate* unmanaged<XcmsCCC*, XcmsColor*, uint, uint, int*, int> param1, [NativeTypeName("XPointer")] sbyte* param2);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("XcmsWhiteAdjustProc")]
        public static extern delegate* unmanaged<XcmsCCC*, XcmsColor*, XcmsColor*, nuint, XcmsColor*, uint, int*, int> XcmsSetWhiteAdjustProc([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsWhiteAdjustProc")] delegate* unmanaged<XcmsCCC*, XcmsColor*, XcmsColor*, nuint, XcmsColor*, uint, int*, int> param1, [NativeTypeName("XPointer")] sbyte* param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsSetWhitePoint([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsStoreColor([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Colormap")] nuint param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsStoreColors([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Colormap")] nuint param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("int *")] int* param4);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsTekHVCClipC([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("int *")] int* param4);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsTekHVCClipV([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("int *")] int* param4);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsTekHVCClipVC([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("int *")] int* param4);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsTekHVCQueryMaxC([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsFloat")] double param1, [NativeTypeName("XcmsFloat")] double param2, [NativeTypeName("XcmsColor *")] XcmsColor* param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsTekHVCQueryMaxV([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsFloat")] double param1, [NativeTypeName("XcmsFloat")] double param2, [NativeTypeName("XcmsColor *")] XcmsColor* param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsTekHVCQueryMaxVC([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsFloat")] double param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsTekHVCQueryMaxVSamples([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsFloat")] double param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsTekHVCQueryMinV([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsFloat")] double param1, [NativeTypeName("XcmsFloat")] double param2, [NativeTypeName("XcmsColor *")] XcmsColor* param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsTekHVCToCIEuvY([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XcmsTekHVCWhiteShiftColors([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2, [NativeTypeName("XcmsColorFormat")] nuint param3, [NativeTypeName("XcmsColor *")] XcmsColor* param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("int *")] int* param6);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("Visual *")]
        public static extern Visual* XcmsVisualOfCCC([NativeTypeName("XcmsCCC")] XcmsCCC* param0);

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
}
