// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\Xcms.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © Tektronix, Inc.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class X11
    {
        [DllImport(libraryPath, EntryPoint = "XcmsAddColorSpace", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsAddColorSpace([NativeTypeName("XcmsColorSpace *")] XcmsColorSpace* param0);

        [DllImport(libraryPath, EntryPoint = "XcmsAddFunctionSet", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsAddFunctionSet([NativeTypeName("XcmsFunctionSet *")] XcmsFunctionSet* param0);

        [DllImport(libraryPath, EntryPoint = "XcmsAllocColor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsAllocColor([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Colormap")] UIntPtr param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2, [NativeTypeName("XcmsColorFormat")] UIntPtr param3);

        [DllImport(libraryPath, EntryPoint = "XcmsAllocNamedColor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsAllocNamedColor([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Colormap")] UIntPtr param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("XcmsColor *")] XcmsColor* param3, [NativeTypeName("XcmsColor *")] XcmsColor* param4, [NativeTypeName("XcmsColorFormat")] UIntPtr param5);

        [DllImport(libraryPath, EntryPoint = "XcmsCCCOfColormap", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XcmsCCC")]
        public static extern XcmsCCC* XcmsCCCOfColormap([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Colormap")] UIntPtr param1);

        [DllImport(libraryPath, EntryPoint = "XcmsCIELabClipab", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIELabClipab([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("int *")] int* param4);

        [DllImport(libraryPath, EntryPoint = "XcmsCIELabClipL", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIELabClipL([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("int *")] int* param4);

        [DllImport(libraryPath, EntryPoint = "XcmsCIELabClipLab", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIELabClipLab([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("int *")] int* param4);

        [DllImport(libraryPath, EntryPoint = "XcmsCIELabQueryMaxC", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIELabQueryMaxC([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsFloat")] double param1, [NativeTypeName("XcmsFloat")] double param2, [NativeTypeName("XcmsColor *")] XcmsColor* param3);

        [DllImport(libraryPath, EntryPoint = "XcmsCIELabQueryMaxL", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIELabQueryMaxL([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsFloat")] double param1, [NativeTypeName("XcmsFloat")] double param2, [NativeTypeName("XcmsColor *")] XcmsColor* param3);

        [DllImport(libraryPath, EntryPoint = "XcmsCIELabQueryMaxLC", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIELabQueryMaxLC([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsFloat")] double param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2);

        [DllImport(libraryPath, EntryPoint = "XcmsCIELabQueryMinL", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIELabQueryMinL([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsFloat")] double param1, [NativeTypeName("XcmsFloat")] double param2, [NativeTypeName("XcmsColor *")] XcmsColor* param3);

        [DllImport(libraryPath, EntryPoint = "XcmsCIELabToCIEXYZ", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIELabToCIEXYZ([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3);

        [DllImport(libraryPath, EntryPoint = "XcmsCIELabWhiteShiftColors", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIELabWhiteShiftColors([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2, [NativeTypeName("XcmsColorFormat")] UIntPtr param3, [NativeTypeName("XcmsColor *")] XcmsColor* param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("int *")] int* param6);

        [DllImport(libraryPath, EntryPoint = "XcmsCIELuvClipL", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIELuvClipL([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("int *")] int* param4);

        [DllImport(libraryPath, EntryPoint = "XcmsCIELuvClipLuv", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIELuvClipLuv([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("int *")] int* param4);

        [DllImport(libraryPath, EntryPoint = "XcmsCIELuvClipuv", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIELuvClipuv([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("int *")] int* param4);

        [DllImport(libraryPath, EntryPoint = "XcmsCIELuvQueryMaxC", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIELuvQueryMaxC([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsFloat")] double param1, [NativeTypeName("XcmsFloat")] double param2, [NativeTypeName("XcmsColor *")] XcmsColor* param3);

        [DllImport(libraryPath, EntryPoint = "XcmsCIELuvQueryMaxL", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIELuvQueryMaxL([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsFloat")] double param1, [NativeTypeName("XcmsFloat")] double param2, [NativeTypeName("XcmsColor *")] XcmsColor* param3);

        [DllImport(libraryPath, EntryPoint = "XcmsCIELuvQueryMaxLC", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIELuvQueryMaxLC([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsFloat")] double param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2);

        [DllImport(libraryPath, EntryPoint = "XcmsCIELuvQueryMinL", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIELuvQueryMinL([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsFloat")] double param1, [NativeTypeName("XcmsFloat")] double param2, [NativeTypeName("XcmsColor *")] XcmsColor* param3);

        [DllImport(libraryPath, EntryPoint = "XcmsCIELuvToCIEuvY", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIELuvToCIEuvY([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3);

        [DllImport(libraryPath, EntryPoint = "XcmsCIELuvWhiteShiftColors", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIELuvWhiteShiftColors([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2, [NativeTypeName("XcmsColorFormat")] UIntPtr param3, [NativeTypeName("XcmsColor *")] XcmsColor* param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("int *")] int* param6);

        [DllImport(libraryPath, EntryPoint = "XcmsCIEXYZToCIELab", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIEXYZToCIELab([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3);

        [DllImport(libraryPath, EntryPoint = "XcmsCIEXYZToCIEuvY", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIEXYZToCIEuvY([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3);

        [DllImport(libraryPath, EntryPoint = "XcmsCIEXYZToCIExyY", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIEXYZToCIExyY([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3);

        [DllImport(libraryPath, EntryPoint = "XcmsCIEXYZToRGBi", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIEXYZToRGBi([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("int *")] int* param3);

        [DllImport(libraryPath, EntryPoint = "XcmsCIEuvYToCIELuv", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIEuvYToCIELuv([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3);

        [DllImport(libraryPath, EntryPoint = "XcmsCIEuvYToCIEXYZ", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIEuvYToCIEXYZ([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3);

        [DllImport(libraryPath, EntryPoint = "XcmsCIEuvYToTekHVC", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIEuvYToTekHVC([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3);

        [DllImport(libraryPath, EntryPoint = "XcmsCIExyYToCIEXYZ", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIExyYToCIEXYZ([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3);

        [DllImport(libraryPath, EntryPoint = "XcmsClientWhitePointOfCCC", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XcmsColor *")]
        public static extern XcmsColor* XcmsClientWhitePointOfCCC([NativeTypeName("XcmsCCC")] XcmsCCC* param0);

        [DllImport(libraryPath, EntryPoint = "XcmsConvertColors", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsConvertColors([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("XcmsColorFormat")] UIntPtr param3, [NativeTypeName("int *")] int* param4);

        [DllImport(libraryPath, EntryPoint = "XcmsCreateCCC", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XcmsCCC")]
        public static extern XcmsCCC* XcmsCreateCCC([NativeTypeName("Display *")] XDisplay* param0, int param1, [NativeTypeName("Visual *")] Visual* param2, [NativeTypeName("XcmsColor *")] XcmsColor* param3, [NativeTypeName("XcmsCompressionProc")] IntPtr param4, [NativeTypeName("XPointer")] sbyte* param5, [NativeTypeName("XcmsWhiteAdjustProc")] IntPtr param6, [NativeTypeName("XPointer")] sbyte* param7);

        [DllImport(libraryPath, EntryPoint = "XcmsDefaultCCC", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XcmsCCC")]
        public static extern XcmsCCC* XcmsDefaultCCC([NativeTypeName("Display *")] XDisplay* param0, int param1);

        [DllImport(libraryPath, EntryPoint = "XcmsDisplayOfCCC", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Display *")]
        public static extern XDisplay* XcmsDisplayOfCCC([NativeTypeName("XcmsCCC")] XcmsCCC* param0);

        [DllImport(libraryPath, EntryPoint = "XcmsFormatOfPrefix", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XcmsColorFormat")]
        public static extern UIntPtr XcmsFormatOfPrefix([NativeTypeName("char *")] sbyte* param0);

        [DllImport(libraryPath, EntryPoint = "XcmsFreeCCC", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XcmsFreeCCC([NativeTypeName("XcmsCCC")] XcmsCCC* param0);

        [DllImport(libraryPath, EntryPoint = "XcmsLookupColor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsLookupColor([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Colormap")] UIntPtr param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("XcmsColor *")] XcmsColor* param3, [NativeTypeName("XcmsColor *")] XcmsColor* param4, [NativeTypeName("XcmsColorFormat")] UIntPtr param5);

        [DllImport(libraryPath, EntryPoint = "XcmsPrefixOfFormat", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XcmsPrefixOfFormat([NativeTypeName("XcmsColorFormat")] UIntPtr param0);

        [DllImport(libraryPath, EntryPoint = "XcmsQueryBlack", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsQueryBlack([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColorFormat")] UIntPtr param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2);

        [DllImport(libraryPath, EntryPoint = "XcmsQueryBlue", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsQueryBlue([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColorFormat")] UIntPtr param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2);

        [DllImport(libraryPath, EntryPoint = "XcmsQueryColor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsQueryColor([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Colormap")] UIntPtr param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2, [NativeTypeName("XcmsColorFormat")] UIntPtr param3);

        [DllImport(libraryPath, EntryPoint = "XcmsQueryColors", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsQueryColors([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Colormap")] UIntPtr param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("XcmsColorFormat")] UIntPtr param4);

        [DllImport(libraryPath, EntryPoint = "XcmsQueryGreen", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsQueryGreen([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColorFormat")] UIntPtr param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2);

        [DllImport(libraryPath, EntryPoint = "XcmsQueryRed", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsQueryRed([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColorFormat")] UIntPtr param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2);

        [DllImport(libraryPath, EntryPoint = "XcmsQueryWhite", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsQueryWhite([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColorFormat")] UIntPtr param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2);

        [DllImport(libraryPath, EntryPoint = "XcmsRGBiToCIEXYZ", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsRGBiToCIEXYZ([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("int *")] int* param3);

        [DllImport(libraryPath, EntryPoint = "XcmsRGBiToRGB", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsRGBiToRGB([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("int *")] int* param3);

        [DllImport(libraryPath, EntryPoint = "XcmsRGBToRGBi", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsRGBToRGBi([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("int *")] int* param3);

        [DllImport(libraryPath, EntryPoint = "XcmsScreenNumberOfCCC", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsScreenNumberOfCCC([NativeTypeName("XcmsCCC")] XcmsCCC* param0);

        [DllImport(libraryPath, EntryPoint = "XcmsScreenWhitePointOfCCC", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XcmsColor *")]
        public static extern XcmsColor* XcmsScreenWhitePointOfCCC([NativeTypeName("XcmsCCC")] XcmsCCC* param0);

        [DllImport(libraryPath, EntryPoint = "XcmsSetCCCOfColormap", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XcmsCCC")]
        public static extern XcmsCCC* XcmsSetCCCOfColormap([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Colormap")] UIntPtr param1, [NativeTypeName("XcmsCCC")] XcmsCCC* param2);

        [DllImport(libraryPath, EntryPoint = "XcmsSetCompressionProc", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XcmsCompressionProc")]
        public static extern IntPtr XcmsSetCompressionProc([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsCompressionProc")] IntPtr param1, [NativeTypeName("XPointer")] sbyte* param2);

        [DllImport(libraryPath, EntryPoint = "XcmsSetWhiteAdjustProc", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XcmsWhiteAdjustProc")]
        public static extern IntPtr XcmsSetWhiteAdjustProc([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsWhiteAdjustProc")] IntPtr param1, [NativeTypeName("XPointer")] sbyte* param2);

        [DllImport(libraryPath, EntryPoint = "XcmsSetWhitePoint", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsSetWhitePoint([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1);

        [DllImport(libraryPath, EntryPoint = "XcmsStoreColor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsStoreColor([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Colormap")] UIntPtr param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2);

        [DllImport(libraryPath, EntryPoint = "XcmsStoreColors", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsStoreColors([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Colormap")] UIntPtr param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("int *")] int* param4);

        [DllImport(libraryPath, EntryPoint = "XcmsTekHVCClipC", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsTekHVCClipC([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("int *")] int* param4);

        [DllImport(libraryPath, EntryPoint = "XcmsTekHVCClipV", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsTekHVCClipV([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("int *")] int* param4);

        [DllImport(libraryPath, EntryPoint = "XcmsTekHVCClipVC", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsTekHVCClipVC([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("int *")] int* param4);

        [DllImport(libraryPath, EntryPoint = "XcmsTekHVCQueryMaxC", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsTekHVCQueryMaxC([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsFloat")] double param1, [NativeTypeName("XcmsFloat")] double param2, [NativeTypeName("XcmsColor *")] XcmsColor* param3);

        [DllImport(libraryPath, EntryPoint = "XcmsTekHVCQueryMaxV", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsTekHVCQueryMaxV([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsFloat")] double param1, [NativeTypeName("XcmsFloat")] double param2, [NativeTypeName("XcmsColor *")] XcmsColor* param3);

        [DllImport(libraryPath, EntryPoint = "XcmsTekHVCQueryMaxVC", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsTekHVCQueryMaxVC([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsFloat")] double param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2);

        [DllImport(libraryPath, EntryPoint = "XcmsTekHVCQueryMaxVSamples", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsTekHVCQueryMaxVSamples([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsFloat")] double param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3);

        [DllImport(libraryPath, EntryPoint = "XcmsTekHVCQueryMinV", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsTekHVCQueryMinV([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsFloat")] double param1, [NativeTypeName("XcmsFloat")] double param2, [NativeTypeName("XcmsColor *")] XcmsColor* param3);

        [DllImport(libraryPath, EntryPoint = "XcmsTekHVCToCIEuvY", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsTekHVCToCIEuvY([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3);

        [DllImport(libraryPath, EntryPoint = "XcmsTekHVCWhiteShiftColors", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsTekHVCWhiteShiftColors([NativeTypeName("XcmsCCC")] XcmsCCC* param0, [NativeTypeName("XcmsColor *")] XcmsColor* param1, [NativeTypeName("XcmsColor *")] XcmsColor* param2, [NativeTypeName("XcmsColorFormat")] UIntPtr param3, [NativeTypeName("XcmsColor *")] XcmsColor* param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("int *")] int* param6);

        [DllImport(libraryPath, EntryPoint = "XcmsVisualOfCCC", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Visual *")]
        public static extern Visual* XcmsVisualOfCCC([NativeTypeName("XcmsCCC")] XcmsCCC* param0);
    }
}
