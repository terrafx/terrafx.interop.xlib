// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\Xcms.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © Tektronix, Inc.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Xlib
    {
        [DllImport(libraryPath, EntryPoint = "XcmsAddColorSpace", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsAddColorSpace([NativeTypeName("XcmsColorSpace *")] XcmsColorSpace* pColorSpace);

        [DllImport(libraryPath, EntryPoint = "XcmsAddFunctionSet", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsAddFunctionSet([NativeTypeName("XcmsFunctionSet *")] XcmsFunctionSet* functionSet);

        [DllImport(libraryPath, EntryPoint = "XcmsAllocColor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsAllocColor([NativeTypeName("Display *")] UIntPtr dpy, [NativeTypeName("Colormap")] UIntPtr colormap, [NativeTypeName("XcmsColor *")] XcmsColor* color_in_out, [NativeTypeName("XcmsColorFormat")] UIntPtr result_format);

        [DllImport(libraryPath, EntryPoint = "XcmsAllocNamedColor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsAllocNamedColor([NativeTypeName("Display *")] UIntPtr dpy, [NativeTypeName("Colormap")] UIntPtr colormap, [NativeTypeName("const char *")] sbyte* color_string, [NativeTypeName("XcmsColor *")] XcmsColor* color_scrn_return, [NativeTypeName("XcmsColor *")] XcmsColor* color_exact_return, [NativeTypeName("XcmsColorFormat")] UIntPtr result_format);

        [DllImport(libraryPath, EntryPoint = "XcmsCCCOfColormap", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XcmsCCC")]
        public static extern XcmsCCC* XcmsCCCOfColormap([NativeTypeName("Display *")] UIntPtr dpy, [NativeTypeName("Colormap")] UIntPtr colormap);

        [DllImport(libraryPath, EntryPoint = "XcmsCIELabClipab", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIELabClipab([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* colors_in_out, [NativeTypeName("unsigned int")] uint ncolors, [NativeTypeName("unsigned int")] uint index, [NativeTypeName("int *")] int* compression_flags_return);

        [DllImport(libraryPath, EntryPoint = "XcmsCIELabClipL", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIELabClipL([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* colors_in_out, [NativeTypeName("unsigned int")] uint ncolors, [NativeTypeName("unsigned int")] uint index, [NativeTypeName("int *")] int* compression_flags_return);

        [DllImport(libraryPath, EntryPoint = "XcmsCIELabClipLab", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIELabClipLab([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* colors_in_out, [NativeTypeName("unsigned int")] uint ncolors, [NativeTypeName("unsigned int")] uint index, [NativeTypeName("int *")] int* compression_flags_return);

        [DllImport(libraryPath, EntryPoint = "XcmsCIELabQueryMaxC", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIELabQueryMaxC([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsFloat")] double hue_angle, [NativeTypeName("XcmsFloat")] double L_star, [NativeTypeName("XcmsColor *")] XcmsColor* color_return);

        [DllImport(libraryPath, EntryPoint = "XcmsCIELabQueryMaxL", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIELabQueryMaxL([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsFloat")] double hue_angle, [NativeTypeName("XcmsFloat")] double chroma, [NativeTypeName("XcmsColor *")] XcmsColor* color_return);

        [DllImport(libraryPath, EntryPoint = "XcmsCIELabQueryMaxLC", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIELabQueryMaxLC([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsFloat")] double hue_angle, [NativeTypeName("XcmsColor *")] XcmsColor* color_return);

        [DllImport(libraryPath, EntryPoint = "XcmsCIELabQueryMinL", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIELabQueryMinL([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsFloat")] double hue_angle, [NativeTypeName("XcmsFloat")] double chroma, [NativeTypeName("XcmsColor *")] XcmsColor* color_return);

        [DllImport(libraryPath, EntryPoint = "XcmsCIELabToCIEXYZ", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIELabToCIEXYZ([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* white_point, [NativeTypeName("XcmsColor *")] XcmsColor* colors, [NativeTypeName("unsigned int")] uint ncolors);

        [DllImport(libraryPath, EntryPoint = "XcmsCIELabWhiteShiftColors", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIELabWhiteShiftColors([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* initial_white_point, [NativeTypeName("XcmsColor *")] XcmsColor* target_white_point, [NativeTypeName("XcmsColorFormat")] UIntPtr target_format, [NativeTypeName("XcmsColor *")] XcmsColor* colors_in_out, [NativeTypeName("unsigned int")] uint ncolors, [NativeTypeName("int *")] int* compression_flags_return);

        [DllImport(libraryPath, EntryPoint = "XcmsCIELuvClipL", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIELuvClipL([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* colors_in_out, [NativeTypeName("unsigned int")] uint ncolors, [NativeTypeName("unsigned int")] uint index, [NativeTypeName("int *")] int* compression_flags_return);

        [DllImport(libraryPath, EntryPoint = "XcmsCIELuvClipLuv", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIELuvClipLuv([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* colors_in_out, [NativeTypeName("unsigned int")] uint ncolors, [NativeTypeName("unsigned int")] uint index, [NativeTypeName("int *")] int* compression_flags_return);

        [DllImport(libraryPath, EntryPoint = "XcmsCIELuvClipuv", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIELuvClipuv([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* colors_in_out, [NativeTypeName("unsigned int")] uint ncolors, [NativeTypeName("unsigned int")] uint index, [NativeTypeName("int *")] int* compression_flags_return);

        [DllImport(libraryPath, EntryPoint = "XcmsCIELuvQueryMaxC", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIELuvQueryMaxC([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsFloat")] double hue_angle, [NativeTypeName("XcmsFloat")] double L_star, [NativeTypeName("XcmsColor *")] XcmsColor* color_return);

        [DllImport(libraryPath, EntryPoint = "XcmsCIELuvQueryMaxL", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIELuvQueryMaxL([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsFloat")] double hue_angle, [NativeTypeName("XcmsFloat")] double chroma, [NativeTypeName("XcmsColor *")] XcmsColor* color_return);

        [DllImport(libraryPath, EntryPoint = "XcmsCIELuvQueryMaxLC", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIELuvQueryMaxLC([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsFloat")] double hue_angle, [NativeTypeName("XcmsColor *")] XcmsColor* color_return);

        [DllImport(libraryPath, EntryPoint = "XcmsCIELuvQueryMinL", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIELuvQueryMinL([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsFloat")] double hue_angle, [NativeTypeName("XcmsFloat")] double chroma, [NativeTypeName("XcmsColor *")] XcmsColor* color_return);

        [DllImport(libraryPath, EntryPoint = "XcmsCIELuvToCIEuvY", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIELuvToCIEuvY([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* white_point, [NativeTypeName("XcmsColor *")] XcmsColor* colors, [NativeTypeName("unsigned int")] uint ncolors);

        [DllImport(libraryPath, EntryPoint = "XcmsCIELuvWhiteShiftColors", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIELuvWhiteShiftColors([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* initial_white_point, [NativeTypeName("XcmsColor *")] XcmsColor* target_white_point, [NativeTypeName("XcmsColorFormat")] UIntPtr target_format, [NativeTypeName("XcmsColor *")] XcmsColor* colors_in_out, [NativeTypeName("unsigned int")] uint ncolors, [NativeTypeName("int *")] int* compression_flags_return);

        [DllImport(libraryPath, EntryPoint = "XcmsCIEXYZToCIELab", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIEXYZToCIELab([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* white_point, [NativeTypeName("XcmsColor *")] XcmsColor* colors, [NativeTypeName("unsigned int")] uint ncolors);

        [DllImport(libraryPath, EntryPoint = "XcmsCIEXYZToCIEuvY", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIEXYZToCIEuvY([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* white_point, [NativeTypeName("XcmsColor *")] XcmsColor* colors, [NativeTypeName("unsigned int")] uint ncolors);

        [DllImport(libraryPath, EntryPoint = "XcmsCIEXYZToCIExyY", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIEXYZToCIExyY([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* white_point, [NativeTypeName("XcmsColor *")] XcmsColor* colors, [NativeTypeName("unsigned int")] uint ncolors);

        [DllImport(libraryPath, EntryPoint = "XcmsCIEXYZToRGBi", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIEXYZToRGBi([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* colors, [NativeTypeName("unsigned int")] uint ncolors, [NativeTypeName("int *")] int* compression_flags_return);

        [DllImport(libraryPath, EntryPoint = "XcmsCIEuvYToCIELuv", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIEuvYToCIELuv([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* white_point, [NativeTypeName("XcmsColor *")] XcmsColor* colors, [NativeTypeName("unsigned int")] uint ncolors);

        [DllImport(libraryPath, EntryPoint = "XcmsCIEuvYToCIEXYZ", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIEuvYToCIEXYZ([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* white_point, [NativeTypeName("XcmsColor *")] XcmsColor* colors, [NativeTypeName("unsigned int")] uint ncolors);

        [DllImport(libraryPath, EntryPoint = "XcmsCIEuvYToTekHVC", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIEuvYToTekHVC([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* white_point, [NativeTypeName("XcmsColor *")] XcmsColor* colors, [NativeTypeName("unsigned int")] uint ncolors);

        [DllImport(libraryPath, EntryPoint = "XcmsCIExyYToCIEXYZ", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsCIExyYToCIEXYZ([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* white_point, [NativeTypeName("XcmsColor *")] XcmsColor* colors, [NativeTypeName("unsigned int")] uint ncolors);

        [DllImport(libraryPath, EntryPoint = "XcmsClientWhitePointOfCCC", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XcmsColor *")]
        public static extern XcmsColor* XcmsClientWhitePointOfCCC([NativeTypeName("XcmsCCC")] XcmsCCC* ccc);

        [DllImport(libraryPath, EntryPoint = "XcmsConvertColors", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsConvertColors([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* colorArry_in_out, [NativeTypeName("unsigned int")] uint nColors, [NativeTypeName("XcmsColorFormat")] UIntPtr targetFormat, [NativeTypeName("int *")] int* compArry_return);

        [DllImport(libraryPath, EntryPoint = "XcmsCreateCCC", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XcmsCCC")]
        public static extern XcmsCCC* XcmsCreateCCC([NativeTypeName("Display *")] UIntPtr dpy, int screenNumber, [NativeTypeName("Visual *")] Visual* visual, [NativeTypeName("XcmsColor *")] XcmsColor* clientWhitePt, [NativeTypeName("XcmsCompressionProc")] IntPtr gamutCompProc, [NativeTypeName("XPointer")] sbyte* gamutCompClientData, [NativeTypeName("XcmsWhiteAdjustProc")] IntPtr whitePtAdjProc, [NativeTypeName("XPointer")] sbyte* whitePtAdjClientData);

        [DllImport(libraryPath, EntryPoint = "XcmsDefaultCCC", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XcmsCCC")]
        public static extern XcmsCCC* XcmsDefaultCCC([NativeTypeName("Display *")] UIntPtr dpy, int screenNumber);

        [DllImport(libraryPath, EntryPoint = "XcmsDisplayOfCCC", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Display *")]
        public static extern UIntPtr XcmsDisplayOfCCC([NativeTypeName("XcmsCCC")] XcmsCCC* ccc);

        [DllImport(libraryPath, EntryPoint = "XcmsFormatOfPrefix", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XcmsColorFormat")]
        public static extern UIntPtr XcmsFormatOfPrefix([NativeTypeName("char *")] sbyte* prefix);

        [DllImport(libraryPath, EntryPoint = "XcmsFreeCCC", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XcmsFreeCCC([NativeTypeName("XcmsCCC")] XcmsCCC* ccc);

        [DllImport(libraryPath, EntryPoint = "XcmsLookupColor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsLookupColor([NativeTypeName("Display *")] UIntPtr dpy, [NativeTypeName("Colormap")] UIntPtr colormap, [NativeTypeName("const char *")] sbyte* color_string, [NativeTypeName("XcmsColor *")] XcmsColor* pColor_exact_in_out, [NativeTypeName("XcmsColor *")] XcmsColor* pColor_scrn_in_out, [NativeTypeName("XcmsColorFormat")] UIntPtr result_format);

        [DllImport(libraryPath, EntryPoint = "XcmsPrefixOfFormat", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XcmsPrefixOfFormat([NativeTypeName("XcmsColorFormat")] UIntPtr id);

        [DllImport(libraryPath, EntryPoint = "XcmsQueryBlack", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsQueryBlack([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColorFormat")] UIntPtr target_format, [NativeTypeName("XcmsColor *")] XcmsColor* color_return);

        [DllImport(libraryPath, EntryPoint = "XcmsQueryBlue", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsQueryBlue([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColorFormat")] UIntPtr target_format, [NativeTypeName("XcmsColor *")] XcmsColor* color_return);

        [DllImport(libraryPath, EntryPoint = "XcmsQueryColor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsQueryColor([NativeTypeName("Display *")] UIntPtr dpu, [NativeTypeName("Colormap")] UIntPtr colormap, [NativeTypeName("XcmsColor *")] XcmsColor* pColor_in_out, [NativeTypeName("XcmsColorFormat")] UIntPtr result_format);

        [DllImport(libraryPath, EntryPoint = "XcmsQueryColors", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsQueryColors([NativeTypeName("Display *")] UIntPtr dpy, [NativeTypeName("Colormap")] UIntPtr colormap, [NativeTypeName("XcmsColor *")] XcmsColor* colorArry_in_out, [NativeTypeName("unsigned int")] uint nColors, [NativeTypeName("XcmsColorFormat")] UIntPtr result_format);

        [DllImport(libraryPath, EntryPoint = "XcmsQueryGreen", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsQueryGreen([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColorFormat")] UIntPtr target_format, [NativeTypeName("XcmsColor *")] XcmsColor* color_return);

        [DllImport(libraryPath, EntryPoint = "XcmsQueryRed", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsQueryRed([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColorFormat")] UIntPtr target_format, [NativeTypeName("XcmsColor *")] XcmsColor* color_return);

        [DllImport(libraryPath, EntryPoint = "XcmsQueryWhite", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsQueryWhite([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColorFormat")] UIntPtr target_format, [NativeTypeName("XcmsColor *")] XcmsColor* color_return);

        [DllImport(libraryPath, EntryPoint = "XcmsRGBiToCIEXYZ", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsRGBiToCIEXYZ([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* colors, [NativeTypeName("unsigned int")] uint ncolors, [NativeTypeName("int *")] int* compression_flags_return);

        [DllImport(libraryPath, EntryPoint = "XcmsRGBiToRGB", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsRGBiToRGB([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* colors, [NativeTypeName("unsigned int")] uint ncolors, [NativeTypeName("int *")] int* compression_flags_return);

        [DllImport(libraryPath, EntryPoint = "XcmsRGBToRGBi", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsRGBToRGBi([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* colors, [NativeTypeName("unsigned int")] uint ncolors, [NativeTypeName("int *")] int* compression_flags_return);

        [DllImport(libraryPath, EntryPoint = "XcmsScreenNumberOfCCC", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsScreenNumberOfCCC([NativeTypeName("XcmsCCC")] XcmsCCC* ccc);

        [DllImport(libraryPath, EntryPoint = "XcmsScreenWhitePointOfCCC", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XcmsColor *")]
        public static extern XcmsColor* XcmsScreenWhitePointOfCCC([NativeTypeName("XcmsCCC")] XcmsCCC* ccc);

        [DllImport(libraryPath, EntryPoint = "XcmsSetCCCOfColormap", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XcmsCCC")]
        public static extern XcmsCCC* XcmsSetCCCOfColormap([NativeTypeName("Display *")] UIntPtr dpy, [NativeTypeName("Colormap")] UIntPtr colormap, [NativeTypeName("XcmsCCC")] XcmsCCC* ccc);

        [DllImport(libraryPath, EntryPoint = "XcmsSetCompressionProc", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XcmsCompressionProc")]
        public static extern IntPtr XcmsSetCompressionProc([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsCompressionProc")] IntPtr compression_proc, [NativeTypeName("XPointer")] sbyte* client_data);

        [DllImport(libraryPath, EntryPoint = "XcmsSetWhiteAdjustProc", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XcmsWhiteAdjustProc")]
        public static extern IntPtr XcmsSetWhiteAdjustProc([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsWhiteAdjustProc")] IntPtr white_adjust_proc, [NativeTypeName("XPointer")] sbyte* client_data);

        [DllImport(libraryPath, EntryPoint = "XcmsSetWhitePoint", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsSetWhitePoint([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* color);

        [DllImport(libraryPath, EntryPoint = "XcmsStoreColor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsStoreColor([NativeTypeName("Display *")] UIntPtr dpy, [NativeTypeName("Colormap")] UIntPtr colormap, [NativeTypeName("XcmsColor *")] XcmsColor* pColor_in);

        [DllImport(libraryPath, EntryPoint = "XcmsStoreColors", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsStoreColors([NativeTypeName("Display *")] UIntPtr dpy, [NativeTypeName("Colormap")] UIntPtr colormap, [NativeTypeName("XcmsColor *")] XcmsColor* colorArry_in, [NativeTypeName("unsigned int")] uint nColors, [NativeTypeName("int *")] int* compArry_return);

        [DllImport(libraryPath, EntryPoint = "XcmsTekHVCClipC", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsTekHVCClipC([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* colors_in_out, [NativeTypeName("unsigned int")] uint ncolors, [NativeTypeName("unsigned int")] uint index, [NativeTypeName("int *")] int* compression_flags_return);

        [DllImport(libraryPath, EntryPoint = "XcmsTekHVCClipV", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsTekHVCClipV([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* colors_in_out, [NativeTypeName("unsigned int")] uint ncolors, [NativeTypeName("unsigned int")] uint index, [NativeTypeName("int *")] int* compression_flags_return);

        [DllImport(libraryPath, EntryPoint = "XcmsTekHVCClipVC", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsTekHVCClipVC([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* colors_in_out, [NativeTypeName("unsigned int")] uint ncolors, [NativeTypeName("unsigned int")] uint index, [NativeTypeName("int *")] int* compression_flags_return);

        [DllImport(libraryPath, EntryPoint = "XcmsTekHVCQueryMaxC", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsTekHVCQueryMaxC([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsFloat")] double hue, [NativeTypeName("XcmsFloat")] double value, [NativeTypeName("XcmsColor *")] XcmsColor* color_return);

        [DllImport(libraryPath, EntryPoint = "XcmsTekHVCQueryMaxV", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsTekHVCQueryMaxV([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsFloat")] double hue, [NativeTypeName("XcmsFloat")] double chroma, [NativeTypeName("XcmsColor *")] XcmsColor* color_return);

        [DllImport(libraryPath, EntryPoint = "XcmsTekHVCQueryMaxVC", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsTekHVCQueryMaxVC([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsFloat")] double hue, [NativeTypeName("XcmsColor *")] XcmsColor* color_return);

        [DllImport(libraryPath, EntryPoint = "XcmsTekHVCQueryMaxVSamples", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsTekHVCQueryMaxVSamples([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsFloat")] double hue, [NativeTypeName("XcmsColor *")] XcmsColor* colors_return, [NativeTypeName("unsigned int")] uint nsamples);

        [DllImport(libraryPath, EntryPoint = "XcmsTekHVCQueryMinV", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsTekHVCQueryMinV([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsFloat")] double hue, [NativeTypeName("XcmsFloat")] double chroma, [NativeTypeName("XcmsColor *")] XcmsColor* color_return);

        [DllImport(libraryPath, EntryPoint = "XcmsTekHVCToCIEuvY", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsTekHVCToCIEuvY([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* white_point, [NativeTypeName("XcmsColor *")] XcmsColor* colors, [NativeTypeName("unsigned int")] uint ncolors);

        [DllImport(libraryPath, EntryPoint = "XcmsTekHVCWhiteShiftColors", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XcmsTekHVCWhiteShiftColors([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* initial_white_point, [NativeTypeName("XcmsColor *")] XcmsColor* target_white_point, [NativeTypeName("XcmsColorFormat")] UIntPtr target_format, [NativeTypeName("XcmsColor *")] XcmsColor* colors_in_out, [NativeTypeName("unsigned int")] uint ncolors, [NativeTypeName("int *")] int* compression_flags_return);

        [DllImport(libraryPath, EntryPoint = "XcmsVisualOfCCC", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Visual *")]
        public static extern Visual* XcmsVisualOfCCC([NativeTypeName("XcmsCCC")] XcmsCCC* ccc);
    }
}
