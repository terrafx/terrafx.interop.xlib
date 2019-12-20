// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\Xcms.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © Tektronix, Inc.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Xlib
    {
        [DllImport(LibraryPath, EntryPoint = "XcmsAddColorSpace", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsAddColorSpace([NativeTypeName("XcmsColorSpace *")] XcmsColorSpace* pColorSpace);

        [DllImport(LibraryPath, EntryPoint = "XcmsAddFunctionSet", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsAddFunctionSet([NativeTypeName("XcmsFunctionSet *")] XcmsFunctionSet* functionSet);

        [DllImport(LibraryPath, EntryPoint = "XcmsAllocColor", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsAllocColor([NativeTypeName("Display *")] UIntPtr dpy, [NativeTypeName("Colormap")] UIntPtr colormap, [NativeTypeName("XcmsColor *")] XcmsColor* color_in_out, [NativeTypeName("XcmsColorFormat")] UIntPtr result_format);

        [DllImport(LibraryPath, EntryPoint = "XcmsAllocNamedColor", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsAllocNamedColor([NativeTypeName("Display *")] UIntPtr dpy, [NativeTypeName("Colormap")] UIntPtr colormap, [NativeTypeName("const char *")] sbyte* color_string, [NativeTypeName("XcmsColor *")] XcmsColor* color_scrn_return, [NativeTypeName("XcmsColor *")] XcmsColor* color_exact_return, [NativeTypeName("XcmsColorFormat")] UIntPtr result_format);

        [DllImport(LibraryPath, EntryPoint = "XcmsCCCOfColormap", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XcmsCCC")]
        public static extern XcmsCCC* XcmsCCCOfColormap([NativeTypeName("Display *")] UIntPtr dpy, [NativeTypeName("Colormap")] UIntPtr colormap);

        [DllImport(LibraryPath, EntryPoint = "XcmsCIELabClipab", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsCIELabClipab([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* colors_in_out, [NativeTypeName("unsigned int")] uint ncolors, [NativeTypeName("unsigned int")] uint index, [NativeTypeName("int *")] int* compression_flags_return);

        [DllImport(LibraryPath, EntryPoint = "XcmsCIELabClipL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsCIELabClipL([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* colors_in_out, [NativeTypeName("unsigned int")] uint ncolors, [NativeTypeName("unsigned int")] uint index, [NativeTypeName("int *")] int* compression_flags_return);

        [DllImport(LibraryPath, EntryPoint = "XcmsCIELabClipLab", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsCIELabClipLab([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* colors_in_out, [NativeTypeName("unsigned int")] uint ncolors, [NativeTypeName("unsigned int")] uint index, [NativeTypeName("int *")] int* compression_flags_return);

        [DllImport(LibraryPath, EntryPoint = "XcmsCIELabQueryMaxC", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsCIELabQueryMaxC([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsFloat")] double hue_angle, [NativeTypeName("XcmsFloat")] double L_star, [NativeTypeName("XcmsColor *")] XcmsColor* color_return);

        [DllImport(LibraryPath, EntryPoint = "XcmsCIELabQueryMaxL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsCIELabQueryMaxL([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsFloat")] double hue_angle, [NativeTypeName("XcmsFloat")] double chroma, [NativeTypeName("XcmsColor *")] XcmsColor* color_return);

        [DllImport(LibraryPath, EntryPoint = "XcmsCIELabQueryMaxLC", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsCIELabQueryMaxLC([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsFloat")] double hue_angle, [NativeTypeName("XcmsColor *")] XcmsColor* color_return);

        [DllImport(LibraryPath, EntryPoint = "XcmsCIELabQueryMinL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsCIELabQueryMinL([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsFloat")] double hue_angle, [NativeTypeName("XcmsFloat")] double chroma, [NativeTypeName("XcmsColor *")] XcmsColor* color_return);

        [DllImport(LibraryPath, EntryPoint = "XcmsCIELabToCIEXYZ", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsCIELabToCIEXYZ([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* white_point, [NativeTypeName("XcmsColor *")] XcmsColor* colors, [NativeTypeName("unsigned int")] uint ncolors);

        [DllImport(LibraryPath, EntryPoint = "XcmsCIELabWhiteShiftColors", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsCIELabWhiteShiftColors([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* initial_white_point, [NativeTypeName("XcmsColor *")] XcmsColor* target_white_point, [NativeTypeName("XcmsColorFormat")] UIntPtr target_format, [NativeTypeName("XcmsColor *")] XcmsColor* colors_in_out, [NativeTypeName("unsigned int")] uint ncolors, [NativeTypeName("int *")] int* compression_flags_return);

        [DllImport(LibraryPath, EntryPoint = "XcmsCIELuvClipL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsCIELuvClipL([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* colors_in_out, [NativeTypeName("unsigned int")] uint ncolors, [NativeTypeName("unsigned int")] uint index, [NativeTypeName("int *")] int* compression_flags_return);

        [DllImport(LibraryPath, EntryPoint = "XcmsCIELuvClipLuv", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsCIELuvClipLuv([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* colors_in_out, [NativeTypeName("unsigned int")] uint ncolors, [NativeTypeName("unsigned int")] uint index, [NativeTypeName("int *")] int* compression_flags_return);

        [DllImport(LibraryPath, EntryPoint = "XcmsCIELuvClipuv", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsCIELuvClipuv([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* colors_in_out, [NativeTypeName("unsigned int")] uint ncolors, [NativeTypeName("unsigned int")] uint index, [NativeTypeName("int *")] int* compression_flags_return);

        [DllImport(LibraryPath, EntryPoint = "XcmsCIELuvQueryMaxC", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsCIELuvQueryMaxC([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsFloat")] double hue_angle, [NativeTypeName("XcmsFloat")] double L_star, [NativeTypeName("XcmsColor *")] XcmsColor* color_return);

        [DllImport(LibraryPath, EntryPoint = "XcmsCIELuvQueryMaxL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsCIELuvQueryMaxL([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsFloat")] double hue_angle, [NativeTypeName("XcmsFloat")] double chroma, [NativeTypeName("XcmsColor *")] XcmsColor* color_return);

        [DllImport(LibraryPath, EntryPoint = "XcmsCIELuvQueryMaxLC", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsCIELuvQueryMaxLC([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsFloat")] double hue_angle, [NativeTypeName("XcmsColor *")] XcmsColor* color_return);

        [DllImport(LibraryPath, EntryPoint = "XcmsCIELuvQueryMinL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsCIELuvQueryMinL([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsFloat")] double hue_angle, [NativeTypeName("XcmsFloat")] double chroma, [NativeTypeName("XcmsColor *")] XcmsColor* color_return);

        [DllImport(LibraryPath, EntryPoint = "XcmsCIELuvToCIEuvY", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsCIELuvToCIEuvY([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* white_point, [NativeTypeName("XcmsColor *")] XcmsColor* colors, [NativeTypeName("unsigned int")] uint ncolors);

        [DllImport(LibraryPath, EntryPoint = "XcmsCIELuvWhiteShiftColors", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsCIELuvWhiteShiftColors([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* initial_white_point, [NativeTypeName("XcmsColor *")] XcmsColor* target_white_point, [NativeTypeName("XcmsColorFormat")] UIntPtr target_format, [NativeTypeName("XcmsColor *")] XcmsColor* colors_in_out, [NativeTypeName("unsigned int")] uint ncolors, [NativeTypeName("int *")] int* compression_flags_return);

        [DllImport(LibraryPath, EntryPoint = "XcmsCIEXYZToCIELab", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsCIEXYZToCIELab([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* white_point, [NativeTypeName("XcmsColor *")] XcmsColor* colors, [NativeTypeName("unsigned int")] uint ncolors);

        [DllImport(LibraryPath, EntryPoint = "XcmsCIEXYZToCIEuvY", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsCIEXYZToCIEuvY([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* white_point, [NativeTypeName("XcmsColor *")] XcmsColor* colors, [NativeTypeName("unsigned int")] uint ncolors);

        [DllImport(LibraryPath, EntryPoint = "XcmsCIEXYZToCIExyY", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsCIEXYZToCIExyY([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* white_point, [NativeTypeName("XcmsColor *")] XcmsColor* colors, [NativeTypeName("unsigned int")] uint ncolors);

        [DllImport(LibraryPath, EntryPoint = "XcmsCIEXYZToRGBi", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsCIEXYZToRGBi([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* colors, [NativeTypeName("unsigned int")] uint ncolors, [NativeTypeName("int *")] int* compression_flags_return);

        [DllImport(LibraryPath, EntryPoint = "XcmsCIEuvYToCIELuv", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsCIEuvYToCIELuv([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* white_point, [NativeTypeName("XcmsColor *")] XcmsColor* colors, [NativeTypeName("unsigned int")] uint ncolors);

        [DllImport(LibraryPath, EntryPoint = "XcmsCIEuvYToCIEXYZ", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsCIEuvYToCIEXYZ([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* white_point, [NativeTypeName("XcmsColor *")] XcmsColor* colors, [NativeTypeName("unsigned int")] uint ncolors);

        [DllImport(LibraryPath, EntryPoint = "XcmsCIEuvYToTekHVC", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsCIEuvYToTekHVC([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* white_point, [NativeTypeName("XcmsColor *")] XcmsColor* colors, [NativeTypeName("unsigned int")] uint ncolors);

        [DllImport(LibraryPath, EntryPoint = "XcmsCIExyYToCIEXYZ", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsCIExyYToCIEXYZ([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* white_point, [NativeTypeName("XcmsColor *")] XcmsColor* colors, [NativeTypeName("unsigned int")] uint ncolors);

        [DllImport(LibraryPath, EntryPoint = "XcmsClientWhitePointOfCCC", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XcmsColor *")]
        public static extern XcmsColor* XcmsClientWhitePointOfCCC([NativeTypeName("XcmsCCC")] XcmsCCC* ccc);

        [DllImport(LibraryPath, EntryPoint = "XcmsConvertColors", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsConvertColors([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* colorArry_in_out, [NativeTypeName("unsigned int")] uint nColors, [NativeTypeName("XcmsColorFormat")] UIntPtr targetFormat, [NativeTypeName("int *")] int* compArry_return);

        [DllImport(LibraryPath, EntryPoint = "XcmsCreateCCC", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XcmsCCC")]
        public static extern XcmsCCC* XcmsCreateCCC([NativeTypeName("Display *")] UIntPtr dpy, int screenNumber, [NativeTypeName("Visual *")] Visual* visual, [NativeTypeName("XcmsColor *")] XcmsColor* clientWhitePt, [NativeTypeName("XcmsCompressionProc")] IntPtr gamutCompProc, [NativeTypeName("XPointer")] sbyte* gamutCompClientData, [NativeTypeName("XcmsWhiteAdjustProc")] IntPtr whitePtAdjProc, [NativeTypeName("XPointer")] sbyte* whitePtAdjClientData);

        [DllImport(LibraryPath, EntryPoint = "XcmsDefaultCCC", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XcmsCCC")]
        public static extern XcmsCCC* XcmsDefaultCCC([NativeTypeName("Display *")] UIntPtr dpy, int screenNumber);

        [DllImport(LibraryPath, EntryPoint = "XcmsDisplayOfCCC", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Display *")]
        public static extern UIntPtr XcmsDisplayOfCCC([NativeTypeName("XcmsCCC")] XcmsCCC* ccc);

        [DllImport(LibraryPath, EntryPoint = "XcmsFormatOfPrefix", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XcmsColorFormat")]
        public static extern UIntPtr XcmsFormatOfPrefix([NativeTypeName("char *")] sbyte* prefix);

        [DllImport(LibraryPath, EntryPoint = "XcmsFreeCCC", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XcmsFreeCCC([NativeTypeName("XcmsCCC")] XcmsCCC* ccc);

        [DllImport(LibraryPath, EntryPoint = "XcmsLookupColor", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsLookupColor([NativeTypeName("Display *")] UIntPtr dpy, [NativeTypeName("Colormap")] UIntPtr colormap, [NativeTypeName("const char *")] sbyte* color_string, [NativeTypeName("XcmsColor *")] XcmsColor* pColor_exact_in_out, [NativeTypeName("XcmsColor *")] XcmsColor* pColor_scrn_in_out, [NativeTypeName("XcmsColorFormat")] UIntPtr result_format);

        [DllImport(LibraryPath, EntryPoint = "XcmsPrefixOfFormat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XcmsPrefixOfFormat([NativeTypeName("XcmsColorFormat")] UIntPtr id);

        [DllImport(LibraryPath, EntryPoint = "XcmsQueryBlack", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsQueryBlack([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColorFormat")] UIntPtr target_format, [NativeTypeName("XcmsColor *")] XcmsColor* color_return);

        [DllImport(LibraryPath, EntryPoint = "XcmsQueryBlue", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsQueryBlue([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColorFormat")] UIntPtr target_format, [NativeTypeName("XcmsColor *")] XcmsColor* color_return);

        [DllImport(LibraryPath, EntryPoint = "XcmsQueryColor", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsQueryColor([NativeTypeName("Display *")] UIntPtr dpu, [NativeTypeName("Colormap")] UIntPtr colormap, [NativeTypeName("XcmsColor *")] XcmsColor* pColor_in_out, [NativeTypeName("XcmsColorFormat")] UIntPtr result_format);

        [DllImport(LibraryPath, EntryPoint = "XcmsQueryColors", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsQueryColors([NativeTypeName("Display *")] UIntPtr dpy, [NativeTypeName("Colormap")] UIntPtr colormap, [NativeTypeName("XcmsColor *")] XcmsColor* colorArry_in_out, [NativeTypeName("unsigned int")] uint nColors, [NativeTypeName("XcmsColorFormat")] UIntPtr result_format);

        [DllImport(LibraryPath, EntryPoint = "XcmsQueryGreen", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsQueryGreen([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColorFormat")] UIntPtr target_format, [NativeTypeName("XcmsColor *")] XcmsColor* color_return);

        [DllImport(LibraryPath, EntryPoint = "XcmsQueryRed", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsQueryRed([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColorFormat")] UIntPtr target_format, [NativeTypeName("XcmsColor *")] XcmsColor* color_return);

        [DllImport(LibraryPath, EntryPoint = "XcmsQueryWhite", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsQueryWhite([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColorFormat")] UIntPtr target_format, [NativeTypeName("XcmsColor *")] XcmsColor* color_return);

        [DllImport(LibraryPath, EntryPoint = "XcmsRGBiToCIEXYZ", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsRGBiToCIEXYZ([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* colors, [NativeTypeName("unsigned int")] uint ncolors, [NativeTypeName("int *")] int* compression_flags_return);

        [DllImport(LibraryPath, EntryPoint = "XcmsRGBiToRGB", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsRGBiToRGB([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* colors, [NativeTypeName("unsigned int")] uint ncolors, [NativeTypeName("int *")] int* compression_flags_return);

        [DllImport(LibraryPath, EntryPoint = "XcmsRGBToRGBi", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsRGBToRGBi([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* colors, [NativeTypeName("unsigned int")] uint ncolors, [NativeTypeName("int *")] int* compression_flags_return);

        [DllImport(LibraryPath, EntryPoint = "XcmsScreenNumberOfCCC", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsScreenNumberOfCCC([NativeTypeName("XcmsCCC")] XcmsCCC* ccc);

        [DllImport(LibraryPath, EntryPoint = "XcmsScreenWhitePointOfCCC", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XcmsColor *")]
        public static extern XcmsColor* XcmsScreenWhitePointOfCCC([NativeTypeName("XcmsCCC")] XcmsCCC* ccc);

        [DllImport(LibraryPath, EntryPoint = "XcmsSetCCCOfColormap", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XcmsCCC")]
        public static extern XcmsCCC* XcmsSetCCCOfColormap([NativeTypeName("Display *")] UIntPtr dpy, [NativeTypeName("Colormap")] UIntPtr colormap, [NativeTypeName("XcmsCCC")] XcmsCCC* ccc);

        [DllImport(LibraryPath, EntryPoint = "XcmsSetCompressionProc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XcmsCompressionProc")]
        public static extern IntPtr XcmsSetCompressionProc([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsCompressionProc")] IntPtr compression_proc, [NativeTypeName("XPointer")] sbyte* client_data);

        [DllImport(LibraryPath, EntryPoint = "XcmsSetWhiteAdjustProc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XcmsWhiteAdjustProc")]
        public static extern IntPtr XcmsSetWhiteAdjustProc([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsWhiteAdjustProc")] IntPtr white_adjust_proc, [NativeTypeName("XPointer")] sbyte* client_data);

        [DllImport(LibraryPath, EntryPoint = "XcmsSetWhitePoint", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsSetWhitePoint([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* color);

        [DllImport(LibraryPath, EntryPoint = "XcmsStoreColor", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsStoreColor([NativeTypeName("Display *")] UIntPtr dpy, [NativeTypeName("Colormap")] UIntPtr colormap, [NativeTypeName("XcmsColor *")] XcmsColor* pColor_in);

        [DllImport(LibraryPath, EntryPoint = "XcmsStoreColors", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsStoreColors([NativeTypeName("Display *")] UIntPtr dpy, [NativeTypeName("Colormap")] UIntPtr colormap, [NativeTypeName("XcmsColor *")] XcmsColor* colorArry_in, [NativeTypeName("unsigned int")] uint nColors, [NativeTypeName("int *")] int* compArry_return);

        [DllImport(LibraryPath, EntryPoint = "XcmsTekHVCClipC", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsTekHVCClipC([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* colors_in_out, [NativeTypeName("unsigned int")] uint ncolors, [NativeTypeName("unsigned int")] uint index, [NativeTypeName("int *")] int* compression_flags_return);

        [DllImport(LibraryPath, EntryPoint = "XcmsTekHVCClipV", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsTekHVCClipV([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* colors_in_out, [NativeTypeName("unsigned int")] uint ncolors, [NativeTypeName("unsigned int")] uint index, [NativeTypeName("int *")] int* compression_flags_return);

        [DllImport(LibraryPath, EntryPoint = "XcmsTekHVCClipVC", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsTekHVCClipVC([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* colors_in_out, [NativeTypeName("unsigned int")] uint ncolors, [NativeTypeName("unsigned int")] uint index, [NativeTypeName("int *")] int* compression_flags_return);

        [DllImport(LibraryPath, EntryPoint = "XcmsTekHVCQueryMaxC", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsTekHVCQueryMaxC([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsFloat")] double hue, [NativeTypeName("XcmsFloat")] double value, [NativeTypeName("XcmsColor *")] XcmsColor* color_return);

        [DllImport(LibraryPath, EntryPoint = "XcmsTekHVCQueryMaxV", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsTekHVCQueryMaxV([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsFloat")] double hue, [NativeTypeName("XcmsFloat")] double chroma, [NativeTypeName("XcmsColor *")] XcmsColor* color_return);

        [DllImport(LibraryPath, EntryPoint = "XcmsTekHVCQueryMaxVC", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsTekHVCQueryMaxVC([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsFloat")] double hue, [NativeTypeName("XcmsColor *")] XcmsColor* color_return);

        [DllImport(LibraryPath, EntryPoint = "XcmsTekHVCQueryMaxVSamples", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsTekHVCQueryMaxVSamples([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsFloat")] double hue, [NativeTypeName("XcmsColor *")] XcmsColor* colors_return, [NativeTypeName("unsigned int")] uint nsamples);

        [DllImport(LibraryPath, EntryPoint = "XcmsTekHVCQueryMinV", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsTekHVCQueryMinV([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsFloat")] double hue, [NativeTypeName("XcmsFloat")] double chroma, [NativeTypeName("XcmsColor *")] XcmsColor* color_return);

        [DllImport(LibraryPath, EntryPoint = "XcmsTekHVCToCIEuvY", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsTekHVCToCIEuvY([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* white_point, [NativeTypeName("XcmsColor *")] XcmsColor* colors, [NativeTypeName("unsigned int")] uint ncolors);

        [DllImport(LibraryPath, EntryPoint = "XcmsTekHVCWhiteShiftColors", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XcmsTekHVCWhiteShiftColors([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* initial_white_point, [NativeTypeName("XcmsColor *")] XcmsColor* target_white_point, [NativeTypeName("XcmsColorFormat")] UIntPtr target_format, [NativeTypeName("XcmsColor *")] XcmsColor* colors_in_out, [NativeTypeName("unsigned int")] uint ncolors, [NativeTypeName("int *")] int* compression_flags_return);

        [DllImport(LibraryPath, EntryPoint = "XcmsVisualOfCCC", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Visual *")]
        public static extern Visual* XcmsVisualOfCCC([NativeTypeName("XcmsCCC")] XcmsCCC* ccc);
    }
}
