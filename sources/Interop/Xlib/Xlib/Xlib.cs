// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Xlib
    {
        private const string libraryPath = "X11";

        [DllImport(libraryPath, EntryPoint = "_Xmblen", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _Xmblen([NativeTypeName("char *")] sbyte* str, int len);

        // public static extern int _Xdebug;

        [DllImport(libraryPath, EntryPoint = "XLoadQueryFont", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XFontStruct *")]
        public static extern XFontStruct* XLoadQueryFont([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("const char *")] sbyte* param1);

        [DllImport(libraryPath, EntryPoint = "XQueryFont", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XFontStruct *")]
        public static extern XFontStruct* XQueryFont([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("XID")] UIntPtr param1);

        [DllImport(libraryPath, EntryPoint = "XGetMotionEvents", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XTimeCoord *")]
        public static extern XTimeCoord* XGetMotionEvents([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("Time")] UIntPtr param2, [NativeTypeName("Time")] UIntPtr param3, [NativeTypeName("int *")] int* param4);

        [DllImport(libraryPath, EntryPoint = "XDeleteModifiermapEntry", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XModifierKeymap *")]
        public static extern XModifierKeymap* XDeleteModifiermapEntry([NativeTypeName("XModifierKeymap *")] XModifierKeymap* param0, [NativeTypeName("KeyCode")] byte param1, int param2);

        [DllImport(libraryPath, EntryPoint = "XGetModifierMapping", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XModifierKeymap *")]
        public static extern XModifierKeymap* XGetModifierMapping([NativeTypeName("Display *")] XDisplay* param0);

        [DllImport(libraryPath, EntryPoint = "XInsertModifiermapEntry", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XModifierKeymap *")]
        public static extern XModifierKeymap* XInsertModifiermapEntry([NativeTypeName("XModifierKeymap *")] XModifierKeymap* param0, [NativeTypeName("KeyCode")] byte param1, int param2);

        [DllImport(libraryPath, EntryPoint = "XNewModifiermap", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XModifierKeymap *")]
        public static extern XModifierKeymap* XNewModifiermap(int param0);

        [DllImport(libraryPath, EntryPoint = "XCreateImage", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XImage *")]
        public static extern XImage* XCreateImage([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Visual *")] Visual* param1, [NativeTypeName("unsigned int")] uint param2, int param3, int param4, [NativeTypeName("char *")] sbyte* param5, [NativeTypeName("unsigned int")] uint param6, [NativeTypeName("unsigned int")] uint param7, int param8, int param9);

        [DllImport(libraryPath, EntryPoint = "XInitImage", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XInitImage([NativeTypeName("XImage *")] XImage* param0);

        [DllImport(libraryPath, EntryPoint = "XGetImage", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XImage *")]
        public static extern XImage* XGetImage([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Drawable")] UIntPtr param1, int param2, int param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned long")] UIntPtr param6, int param7);

        [DllImport(libraryPath, EntryPoint = "XGetSubImage", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XImage *")]
        public static extern XImage* XGetSubImage([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Drawable")] UIntPtr param1, int param2, int param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned long")] UIntPtr param6, int param7, [NativeTypeName("XImage *")] XImage* param8, int param9, int param10);

        [DllImport(libraryPath, EntryPoint = "XOpenDisplay", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Display *")]
        public static extern XDisplay* XOpenDisplay([NativeTypeName("const char *")] sbyte* param0);

        [DllImport(libraryPath, EntryPoint = "XrmInitialize", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XrmInitialize();

        [DllImport(libraryPath, EntryPoint = "XFetchBytes", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XFetchBytes([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("int *")] int* param1);

        [DllImport(libraryPath, EntryPoint = "XFetchBuffer", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XFetchBuffer([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("int *")] int* param1, int param2);

        [DllImport(libraryPath, EntryPoint = "XGetAtomName", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XGetAtomName([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Atom")] UIntPtr param1);

        [DllImport(libraryPath, EntryPoint = "XGetAtomNames", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetAtomNames([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Atom *")] UIntPtr* param1, int param2, [NativeTypeName("char **")] sbyte** param3);

        [DllImport(libraryPath, EntryPoint = "XGetDefault", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XGetDefault([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("const char *")] sbyte* param2);

        [DllImport(libraryPath, EntryPoint = "XDisplayName", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XDisplayName([NativeTypeName("const char *")] sbyte* param0);

        [DllImport(libraryPath, EntryPoint = "XKeysymToString", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XKeysymToString([NativeTypeName("KeySym")] UIntPtr param0);

        [DllImport(libraryPath, EntryPoint = "XSynchronize", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("int (*)(Display *)")]
        public static extern IntPtr XSynchronize([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Display *")] XDisplay* param1, int param2);

        [DllImport(libraryPath, EntryPoint = "XSetAfterFunction", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("int (*)(Display *)")]
        public static extern IntPtr XSetAfterFunction([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Display *")] XDisplay* param1, [NativeTypeName("int (*)(Display *)")] IntPtr param2);

        [DllImport(libraryPath, EntryPoint = "XInternAtom", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Atom")]
        public static extern UIntPtr XInternAtom([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("const char *")] sbyte* param1, int param2);

        [DllImport(libraryPath, EntryPoint = "XInternAtoms", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XInternAtoms([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("char **")] sbyte** param1, int param2, int param3, [NativeTypeName("Atom *")] UIntPtr* param4);

        [DllImport(libraryPath, EntryPoint = "XCopyColormapAndFree", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Colormap")]
        public static extern UIntPtr XCopyColormapAndFree([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Colormap")] UIntPtr param1);

        [DllImport(libraryPath, EntryPoint = "XCreateColormap", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Colormap")]
        public static extern UIntPtr XCreateColormap([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("Visual *")] Visual* param2, int param3);

        [DllImport(libraryPath, EntryPoint = "XCreatePixmapCursor", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Cursor")]
        public static extern UIntPtr XCreatePixmapCursor([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Pixmap")] UIntPtr param1, [NativeTypeName("Pixmap")] UIntPtr param2, [NativeTypeName("XColor *")] XColor* param3, [NativeTypeName("XColor *")] XColor* param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned int")] uint param6);

        [DllImport(libraryPath, EntryPoint = "XCreateGlyphCursor", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Cursor")]
        public static extern UIntPtr XCreateGlyphCursor([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Font")] UIntPtr param1, [NativeTypeName("Font")] UIntPtr param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("const XColor *")] XColor* param5, [NativeTypeName("const XColor *")] XColor* param6);

        [DllImport(libraryPath, EntryPoint = "XCreateFontCursor", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Cursor")]
        public static extern UIntPtr XCreateFontCursor([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("unsigned int")] uint param1);

        [DllImport(libraryPath, EntryPoint = "XLoadFont", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Font")]
        public static extern UIntPtr XLoadFont([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("const char *")] sbyte* param1);

        [DllImport(libraryPath, EntryPoint = "XCreateGC", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("GC")]
        public static extern XGC* XCreateGC([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Drawable")] UIntPtr param1, [NativeTypeName("unsigned long")] UIntPtr param2, [NativeTypeName("XGCValues *")] XGCValues* param3);

        [DllImport(libraryPath, EntryPoint = "XGContextFromGC", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("GContext")]
        public static extern UIntPtr XGContextFromGC([NativeTypeName("GC")] XGC* param0);

        [DllImport(libraryPath, EntryPoint = "XFlushGC", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XFlushGC([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("GC")] XGC* param1);

        [DllImport(libraryPath, EntryPoint = "XCreatePixmap", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Pixmap")]
        public static extern UIntPtr XCreatePixmap([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Drawable")] UIntPtr param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int")] uint param4);

        [DllImport(libraryPath, EntryPoint = "XCreateBitmapFromData", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Pixmap")]
        public static extern UIntPtr XCreateBitmapFromData([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Drawable")] UIntPtr param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int")] uint param4);

        [DllImport(libraryPath, EntryPoint = "XCreatePixmapFromBitmapData", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Pixmap")]
        public static extern UIntPtr XCreatePixmapFromBitmapData([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Drawable")] UIntPtr param1, [NativeTypeName("char *")] sbyte* param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned long")] UIntPtr param5, [NativeTypeName("unsigned long")] UIntPtr param6, [NativeTypeName("unsigned int")] uint param7);

        [DllImport(libraryPath, EntryPoint = "XCreateSimpleWindow", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Window")]
        public static extern UIntPtr XCreateSimpleWindow([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, int param2, int param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned int")] uint param6, [NativeTypeName("unsigned long")] UIntPtr param7, [NativeTypeName("unsigned long")] UIntPtr param8);

        [DllImport(libraryPath, EntryPoint = "XGetSelectionOwner", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Window")]
        public static extern UIntPtr XGetSelectionOwner([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Atom")] UIntPtr param1);

        [DllImport(libraryPath, EntryPoint = "XCreateWindow", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Window")]
        public static extern UIntPtr XCreateWindow([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, int param2, int param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned int")] uint param6, int param7, [NativeTypeName("unsigned int")] uint param8, [NativeTypeName("Visual *")] Visual* param9, [NativeTypeName("unsigned long")] UIntPtr param10, [NativeTypeName("XSetWindowAttributes *")] XSetWindowAttributes* param11);

        [DllImport(libraryPath, EntryPoint = "XListInstalledColormaps", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Colormap *")]
        public static extern UIntPtr* XListInstalledColormaps([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("int *")] int* param2);

        [DllImport(libraryPath, EntryPoint = "XListFonts", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char **")]
        public static extern sbyte** XListFonts([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("const char *")] sbyte* param1, int param2, [NativeTypeName("int *")] int* param3);

        [DllImport(libraryPath, EntryPoint = "XListFontsWithInfo", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char **")]
        public static extern sbyte** XListFontsWithInfo([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("const char *")] sbyte* param1, int param2, [NativeTypeName("int *")] int* param3, [NativeTypeName("XFontStruct **")] XFontStruct** param4);

        [DllImport(libraryPath, EntryPoint = "XGetFontPath", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char **")]
        public static extern sbyte** XGetFontPath([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("int *")] int* param1);

        [DllImport(libraryPath, EntryPoint = "XListExtensions", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char **")]
        public static extern sbyte** XListExtensions([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("int *")] int* param1);

        [DllImport(libraryPath, EntryPoint = "XListProperties", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Atom *")]
        public static extern UIntPtr* XListProperties([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("int *")] int* param2);

        [DllImport(libraryPath, EntryPoint = "XListHosts", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XHostAddress *")]
        public static extern XHostAddress* XListHosts([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("int *")] int* param1, [NativeTypeName("int *")] int* param2);

        [DllImport(libraryPath, EntryPoint = "XKeycodeToKeysym", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("KeySym")]
        public static extern UIntPtr XKeycodeToKeysym([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("KeyCode")] byte param1, int param2);

        [DllImport(libraryPath, EntryPoint = "XLookupKeysym", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("KeySym")]
        public static extern UIntPtr XLookupKeysym([NativeTypeName("XKeyEvent *")] XKeyEvent* param0, int param1);

        [DllImport(libraryPath, EntryPoint = "XGetKeyboardMapping", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("KeySym *")]
        public static extern UIntPtr* XGetKeyboardMapping([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("KeyCode")] byte param1, int param2, [NativeTypeName("int *")] int* param3);

        [DllImport(libraryPath, EntryPoint = "XStringToKeysym", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("KeySym")]
        public static extern UIntPtr XStringToKeysym([NativeTypeName("const char *")] sbyte* param0);

        [DllImport(libraryPath, EntryPoint = "XMaxRequestSize", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("long")]
        public static extern IntPtr XMaxRequestSize([NativeTypeName("Display *")] XDisplay* param0);

        [DllImport(libraryPath, EntryPoint = "XExtendedMaxRequestSize", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("long")]
        public static extern IntPtr XExtendedMaxRequestSize([NativeTypeName("Display *")] XDisplay* param0);

        [DllImport(libraryPath, EntryPoint = "XResourceManagerString", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XResourceManagerString([NativeTypeName("Display *")] XDisplay* param0);

        [DllImport(libraryPath, EntryPoint = "XScreenResourceString", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XScreenResourceString([NativeTypeName("Screen *")] Screen* param0);

        [DllImport(libraryPath, EntryPoint = "XDisplayMotionBufferSize", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("unsigned long")]
        public static extern UIntPtr XDisplayMotionBufferSize([NativeTypeName("Display *")] XDisplay* param0);

        [DllImport(libraryPath, EntryPoint = "XVisualIDFromVisual", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("VisualID")]
        public static extern UIntPtr XVisualIDFromVisual([NativeTypeName("Visual *")] Visual* param0);

        [DllImport(libraryPath, EntryPoint = "XInitThreads", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XInitThreads();

        [DllImport(libraryPath, EntryPoint = "XLockDisplay", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XLockDisplay([NativeTypeName("Display *")] XDisplay* param0);

        [DllImport(libraryPath, EntryPoint = "XUnlockDisplay", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XUnlockDisplay([NativeTypeName("Display *")] XDisplay* param0);

        [DllImport(libraryPath, EntryPoint = "XInitExtension", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XExtCodes *")]
        public static extern XExtCodes* XInitExtension([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("const char *")] sbyte* param1);

        [DllImport(libraryPath, EntryPoint = "XAddExtension", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XExtCodes *")]
        public static extern XExtCodes* XAddExtension([NativeTypeName("Display *")] XDisplay* param0);

        [DllImport(libraryPath, EntryPoint = "XFindOnExtensionList", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XExtData *")]
        public static extern XExtData* XFindOnExtensionList([NativeTypeName("XExtData **")] XExtData** param0, int param1);

        [DllImport(libraryPath, EntryPoint = "XEHeadOfExtensionList", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XExtData **")]
        public static extern XExtData** XEHeadOfExtensionList(XEDataObject param0);

        [DllImport(libraryPath, EntryPoint = "XRootWindow", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Window")]
        public static extern UIntPtr XRootWindow([NativeTypeName("Display *")] XDisplay* param0, int param1);

        [DllImport(libraryPath, EntryPoint = "XDefaultRootWindow", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Window")]
        public static extern UIntPtr XDefaultRootWindow([NativeTypeName("Display *")] XDisplay* param0);

        [DllImport(libraryPath, EntryPoint = "XRootWindowOfScreen", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Window")]
        public static extern UIntPtr XRootWindowOfScreen([NativeTypeName("Screen *")] Screen* param0);

        [DllImport(libraryPath, EntryPoint = "XDefaultVisual", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Visual *")]
        public static extern Visual* XDefaultVisual([NativeTypeName("Display *")] XDisplay* param0, int param1);

        [DllImport(libraryPath, EntryPoint = "XDefaultVisualOfScreen", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Visual *")]
        public static extern Visual* XDefaultVisualOfScreen([NativeTypeName("Screen *")] Screen* param0);

        [DllImport(libraryPath, EntryPoint = "XDefaultGC", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("GC")]
        public static extern XGC* XDefaultGC([NativeTypeName("Display *")] XDisplay* param0, int param1);

        [DllImport(libraryPath, EntryPoint = "XDefaultGCOfScreen", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("GC")]
        public static extern XGC* XDefaultGCOfScreen([NativeTypeName("Screen *")] Screen* param0);

        [DllImport(libraryPath, EntryPoint = "XBlackPixel", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("unsigned long")]
        public static extern UIntPtr XBlackPixel([NativeTypeName("Display *")] XDisplay* param0, int param1);

        [DllImport(libraryPath, EntryPoint = "XWhitePixel", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("unsigned long")]
        public static extern UIntPtr XWhitePixel([NativeTypeName("Display *")] XDisplay* param0, int param1);

        [DllImport(libraryPath, EntryPoint = "XAllPlanes", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("unsigned long")]
        public static extern UIntPtr XAllPlanes();

        [DllImport(libraryPath, EntryPoint = "XBlackPixelOfScreen", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("unsigned long")]
        public static extern UIntPtr XBlackPixelOfScreen([NativeTypeName("Screen *")] Screen* param0);

        [DllImport(libraryPath, EntryPoint = "XWhitePixelOfScreen", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("unsigned long")]
        public static extern UIntPtr XWhitePixelOfScreen([NativeTypeName("Screen *")] Screen* param0);

        [DllImport(libraryPath, EntryPoint = "XNextRequest", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("unsigned long")]
        public static extern UIntPtr XNextRequest([NativeTypeName("Display *")] XDisplay* param0);

        [DllImport(libraryPath, EntryPoint = "XLastKnownRequestProcessed", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("unsigned long")]
        public static extern UIntPtr XLastKnownRequestProcessed([NativeTypeName("Display *")] XDisplay* param0);

        [DllImport(libraryPath, EntryPoint = "XServerVendor", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XServerVendor([NativeTypeName("Display *")] XDisplay* param0);

        [DllImport(libraryPath, EntryPoint = "XDisplayString", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XDisplayString([NativeTypeName("Display *")] XDisplay* param0);

        [DllImport(libraryPath, EntryPoint = "XDefaultColormap", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Colormap")]
        public static extern UIntPtr XDefaultColormap([NativeTypeName("Display *")] XDisplay* param0, int param1);

        [DllImport(libraryPath, EntryPoint = "XDefaultColormapOfScreen", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Colormap")]
        public static extern UIntPtr XDefaultColormapOfScreen([NativeTypeName("Screen *")] Screen* param0);

        [DllImport(libraryPath, EntryPoint = "XDisplayOfScreen", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Display *")]
        public static extern XDisplay* XDisplayOfScreen([NativeTypeName("Screen *")] Screen* param0);

        [DllImport(libraryPath, EntryPoint = "XScreenOfDisplay", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Screen *")]
        public static extern Screen* XScreenOfDisplay([NativeTypeName("Display *")] XDisplay* param0, int param1);

        [DllImport(libraryPath, EntryPoint = "XDefaultScreenOfDisplay", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Screen *")]
        public static extern Screen* XDefaultScreenOfDisplay([NativeTypeName("Display *")] XDisplay* param0);

        [DllImport(libraryPath, EntryPoint = "XEventMaskOfScreen", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("long")]
        public static extern IntPtr XEventMaskOfScreen([NativeTypeName("Screen *")] Screen* param0);

        [DllImport(libraryPath, EntryPoint = "XScreenNumberOfScreen", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XScreenNumberOfScreen([NativeTypeName("Screen *")] Screen* param0);

        [DllImport(libraryPath, EntryPoint = "XSetErrorHandler", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XErrorHandler")]
        public static extern IntPtr XSetErrorHandler([NativeTypeName("XErrorHandler")] IntPtr param0);

        [DllImport(libraryPath, EntryPoint = "XSetIOErrorHandler", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XIOErrorHandler")]
        public static extern IntPtr XSetIOErrorHandler([NativeTypeName("XIOErrorHandler")] IntPtr param0);

        [DllImport(libraryPath, EntryPoint = "XListPixmapFormats", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XPixmapFormatValues *")]
        public static extern XPixmapFormatValues* XListPixmapFormats([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("int *")] int* param1);

        [DllImport(libraryPath, EntryPoint = "XListDepths", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("int *")]
        public static extern int* XListDepths([NativeTypeName("Display *")] XDisplay* param0, int param1, [NativeTypeName("int *")] int* param2);

        [DllImport(libraryPath, EntryPoint = "XReconfigureWMWindow", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XReconfigureWMWindow([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, int param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("XWindowChanges *")] XWindowChanges* param4);

        [DllImport(libraryPath, EntryPoint = "XGetWMProtocols", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetWMProtocols([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("Atom **")] UIntPtr** param2, [NativeTypeName("int *")] int* param3);

        [DllImport(libraryPath, EntryPoint = "XSetWMProtocols", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetWMProtocols([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("Atom *")] UIntPtr* param2, int param3);

        [DllImport(libraryPath, EntryPoint = "XIconifyWindow", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XIconifyWindow([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, int param2);

        [DllImport(libraryPath, EntryPoint = "XWithdrawWindow", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XWithdrawWindow([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, int param2);

        [DllImport(libraryPath, EntryPoint = "XGetCommand", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetCommand([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("char ***")] sbyte*** param2, [NativeTypeName("int *")] int* param3);

        [DllImport(libraryPath, EntryPoint = "XGetWMColormapWindows", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetWMColormapWindows([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("Window **")] UIntPtr** param2, [NativeTypeName("int *")] int* param3);

        [DllImport(libraryPath, EntryPoint = "XSetWMColormapWindows", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetWMColormapWindows([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("Window *")] UIntPtr* param2, int param3);

        [DllImport(libraryPath, EntryPoint = "XFreeStringList", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XFreeStringList([NativeTypeName("char **")] sbyte** param0);

        [DllImport(libraryPath, EntryPoint = "XSetTransientForHint", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetTransientForHint([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("Window")] UIntPtr param2);

        [DllImport(libraryPath, EntryPoint = "XActivateScreenSaver", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XActivateScreenSaver([NativeTypeName("Display *")] XDisplay* param0);

        [DllImport(libraryPath, EntryPoint = "XAddHost", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XAddHost([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("XHostAddress *")] XHostAddress* param1);

        [DllImport(libraryPath, EntryPoint = "XAddHosts", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XAddHosts([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("XHostAddress *")] XHostAddress* param1, int param2);

        [DllImport(libraryPath, EntryPoint = "XAddToExtensionList", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XAddToExtensionList([NativeTypeName("struct XExtData **")] XExtData** param0, [NativeTypeName("XExtData *")] XExtData* param1);

        [DllImport(libraryPath, EntryPoint = "XAddToSaveSet", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XAddToSaveSet([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1);

        [DllImport(libraryPath, EntryPoint = "XAllocColor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XAllocColor([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Colormap")] UIntPtr param1, [NativeTypeName("XColor *")] XColor* param2);

        [DllImport(libraryPath, EntryPoint = "XAllocColorCells", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XAllocColorCells([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Colormap")] UIntPtr param1, int param2, [NativeTypeName("unsigned long *")] UIntPtr* param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned long *")] UIntPtr* param5, [NativeTypeName("unsigned int")] uint param6);

        [DllImport(libraryPath, EntryPoint = "XAllocColorPlanes", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XAllocColorPlanes([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Colormap")] UIntPtr param1, int param2, [NativeTypeName("unsigned long *")] UIntPtr* param3, int param4, int param5, int param6, int param7, [NativeTypeName("unsigned long *")] UIntPtr* param8, [NativeTypeName("unsigned long *")] UIntPtr* param9, [NativeTypeName("unsigned long *")] UIntPtr* param10);

        [DllImport(libraryPath, EntryPoint = "XAllocNamedColor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XAllocNamedColor([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Colormap")] UIntPtr param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("XColor *")] XColor* param3, [NativeTypeName("XColor *")] XColor* param4);

        [DllImport(libraryPath, EntryPoint = "XAllowEvents", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XAllowEvents([NativeTypeName("Display *")] XDisplay* param0, int param1, [NativeTypeName("Time")] UIntPtr param2);

        [DllImport(libraryPath, EntryPoint = "XAutoRepeatOff", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XAutoRepeatOff([NativeTypeName("Display *")] XDisplay* param0);

        [DllImport(libraryPath, EntryPoint = "XAutoRepeatOn", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XAutoRepeatOn([NativeTypeName("Display *")] XDisplay* param0);

        [DllImport(libraryPath, EntryPoint = "XBell", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XBell([NativeTypeName("Display *")] XDisplay* param0, int param1);

        [DllImport(libraryPath, EntryPoint = "XBitmapBitOrder", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XBitmapBitOrder([NativeTypeName("Display *")] XDisplay* param0);

        [DllImport(libraryPath, EntryPoint = "XBitmapPad", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XBitmapPad([NativeTypeName("Display *")] XDisplay* param0);

        [DllImport(libraryPath, EntryPoint = "XBitmapUnit", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XBitmapUnit([NativeTypeName("Display *")] XDisplay* param0);

        [DllImport(libraryPath, EntryPoint = "XCellsOfScreen", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XCellsOfScreen([NativeTypeName("Screen *")] Screen* param0);

        [DllImport(libraryPath, EntryPoint = "XChangeActivePointerGrab", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XChangeActivePointerGrab([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("Cursor")] UIntPtr param2, [NativeTypeName("Time")] UIntPtr param3);

        [DllImport(libraryPath, EntryPoint = "XChangeGC", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XChangeGC([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("GC")] XGC* param1, [NativeTypeName("unsigned long")] UIntPtr param2, [NativeTypeName("XGCValues *")] XGCValues* param3);

        [DllImport(libraryPath, EntryPoint = "XChangeKeyboardControl", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XChangeKeyboardControl([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("unsigned long")] UIntPtr param1, [NativeTypeName("XKeyboardControl *")] XKeyboardControl* param2);

        [DllImport(libraryPath, EntryPoint = "XChangeKeyboardMapping", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XChangeKeyboardMapping([NativeTypeName("Display *")] XDisplay* param0, int param1, int param2, [NativeTypeName("KeySym *")] UIntPtr* param3, int param4);

        [DllImport(libraryPath, EntryPoint = "XChangePointerControl", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XChangePointerControl([NativeTypeName("Display *")] XDisplay* param0, int param1, int param2, int param3, int param4, int param5);

        [DllImport(libraryPath, EntryPoint = "XChangeProperty", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XChangeProperty([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("Atom")] UIntPtr param2, [NativeTypeName("Atom")] UIntPtr param3, int param4, int param5, [NativeTypeName("const unsigned char *")] byte* param6, int param7);

        [DllImport(libraryPath, EntryPoint = "XChangeSaveSet", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XChangeSaveSet([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, int param2);

        [DllImport(libraryPath, EntryPoint = "XChangeWindowAttributes", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XChangeWindowAttributes([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("unsigned long")] UIntPtr param2, [NativeTypeName("XSetWindowAttributes *")] XSetWindowAttributes* param3);

        [DllImport(libraryPath, EntryPoint = "XCheckIfEvent", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XCheckIfEvent([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("XEvent *")] XEvent* param1, [NativeTypeName("int (*)(Display *, XEvent *, XPointer)")] IntPtr param2, [NativeTypeName("XPointer")] sbyte* param3);

        [DllImport(libraryPath, EntryPoint = "XCheckMaskEvent", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XCheckMaskEvent([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("long")] IntPtr param1, [NativeTypeName("XEvent *")] XEvent* param2);

        [DllImport(libraryPath, EntryPoint = "XCheckTypedEvent", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XCheckTypedEvent([NativeTypeName("Display *")] XDisplay* param0, int param1, [NativeTypeName("XEvent *")] XEvent* param2);

        [DllImport(libraryPath, EntryPoint = "XCheckTypedWindowEvent", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XCheckTypedWindowEvent([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, int param2, [NativeTypeName("XEvent *")] XEvent* param3);

        [DllImport(libraryPath, EntryPoint = "XCheckWindowEvent", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XCheckWindowEvent([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("long")] IntPtr param2, [NativeTypeName("XEvent *")] XEvent* param3);

        [DllImport(libraryPath, EntryPoint = "XCirculateSubwindows", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XCirculateSubwindows([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, int param2);

        [DllImport(libraryPath, EntryPoint = "XCirculateSubwindowsDown", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XCirculateSubwindowsDown([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1);

        [DllImport(libraryPath, EntryPoint = "XCirculateSubwindowsUp", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XCirculateSubwindowsUp([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1);

        [DllImport(libraryPath, EntryPoint = "XClearArea", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XClearArea([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, int param2, int param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int")] uint param5, int param6);

        [DllImport(libraryPath, EntryPoint = "XClearWindow", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XClearWindow([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1);

        [DllImport(libraryPath, EntryPoint = "XCloseDisplay", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XCloseDisplay([NativeTypeName("Display *")] XDisplay* param0);

        [DllImport(libraryPath, EntryPoint = "XConfigureWindow", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XConfigureWindow([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("XWindowChanges *")] XWindowChanges* param3);

        [DllImport(libraryPath, EntryPoint = "XConnectionNumber", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XConnectionNumber([NativeTypeName("Display *")] XDisplay* param0);

        [DllImport(libraryPath, EntryPoint = "XConvertSelection", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XConvertSelection([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Atom")] UIntPtr param1, [NativeTypeName("Atom")] UIntPtr param2, [NativeTypeName("Atom")] UIntPtr param3, [NativeTypeName("Window")] UIntPtr param4, [NativeTypeName("Time")] UIntPtr param5);

        [DllImport(libraryPath, EntryPoint = "XCopyArea", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XCopyArea([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Drawable")] UIntPtr param1, [NativeTypeName("Drawable")] UIntPtr param2, [NativeTypeName("GC")] XGC* param3, int param4, int param5, [NativeTypeName("unsigned int")] uint param6, [NativeTypeName("unsigned int")] uint param7, int param8, int param9);

        [DllImport(libraryPath, EntryPoint = "XCopyGC", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XCopyGC([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("GC")] XGC* param1, [NativeTypeName("unsigned long")] UIntPtr param2, [NativeTypeName("GC")] XGC* param3);

        [DllImport(libraryPath, EntryPoint = "XCopyPlane", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XCopyPlane([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Drawable")] UIntPtr param1, [NativeTypeName("Drawable")] UIntPtr param2, [NativeTypeName("GC")] XGC* param3, int param4, int param5, [NativeTypeName("unsigned int")] uint param6, [NativeTypeName("unsigned int")] uint param7, int param8, int param9, [NativeTypeName("unsigned long")] UIntPtr param10);

        [DllImport(libraryPath, EntryPoint = "XDefaultDepth", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDefaultDepth([NativeTypeName("Display *")] XDisplay* param0, int param1);

        [DllImport(libraryPath, EntryPoint = "XDefaultDepthOfScreen", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDefaultDepthOfScreen([NativeTypeName("Screen *")] Screen* param0);

        [DllImport(libraryPath, EntryPoint = "XDefaultScreen", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDefaultScreen([NativeTypeName("Display *")] XDisplay* param0);

        [DllImport(libraryPath, EntryPoint = "XDefineCursor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDefineCursor([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("Cursor")] UIntPtr param2);

        [DllImport(libraryPath, EntryPoint = "XDeleteProperty", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDeleteProperty([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("Atom")] UIntPtr param2);

        [DllImport(libraryPath, EntryPoint = "XDestroyWindow", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDestroyWindow([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1);

        [DllImport(libraryPath, EntryPoint = "XDestroySubwindows", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDestroySubwindows([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1);

        [DllImport(libraryPath, EntryPoint = "XDoesBackingStore", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDoesBackingStore([NativeTypeName("Screen *")] Screen* param0);

        [DllImport(libraryPath, EntryPoint = "XDoesSaveUnders", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDoesSaveUnders([NativeTypeName("Screen *")] Screen* param0);

        [DllImport(libraryPath, EntryPoint = "XDisableAccessControl", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDisableAccessControl([NativeTypeName("Display *")] XDisplay* param0);

        [DllImport(libraryPath, EntryPoint = "XDisplayCells", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDisplayCells([NativeTypeName("Display *")] XDisplay* param0, int param1);

        [DllImport(libraryPath, EntryPoint = "XDisplayHeight", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDisplayHeight([NativeTypeName("Display *")] XDisplay* param0, int param1);

        [DllImport(libraryPath, EntryPoint = "XDisplayHeightMM", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDisplayHeightMM([NativeTypeName("Display *")] XDisplay* param0, int param1);

        [DllImport(libraryPath, EntryPoint = "XDisplayKeycodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDisplayKeycodes([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("int *")] int* param1, [NativeTypeName("int *")] int* param2);

        [DllImport(libraryPath, EntryPoint = "XDisplayPlanes", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDisplayPlanes([NativeTypeName("Display *")] XDisplay* param0, int param1);

        [DllImport(libraryPath, EntryPoint = "XDisplayWidth", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDisplayWidth([NativeTypeName("Display *")] XDisplay* param0, int param1);

        [DllImport(libraryPath, EntryPoint = "XDisplayWidthMM", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDisplayWidthMM([NativeTypeName("Display *")] XDisplay* param0, int param1);

        [DllImport(libraryPath, EntryPoint = "XDrawArc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDrawArc([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Drawable")] UIntPtr param1, [NativeTypeName("GC")] XGC* param2, int param3, int param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned int")] uint param6, int param7, int param8);

        [DllImport(libraryPath, EntryPoint = "XDrawArcs", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDrawArcs([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Drawable")] UIntPtr param1, [NativeTypeName("GC")] XGC* param2, [NativeTypeName("XArc *")] XArc* param3, int param4);

        [DllImport(libraryPath, EntryPoint = "XDrawImageString", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDrawImageString([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Drawable")] UIntPtr param1, [NativeTypeName("GC")] XGC* param2, int param3, int param4, [NativeTypeName("const char *")] sbyte* param5, int param6);

        [DllImport(libraryPath, EntryPoint = "XDrawImageString16", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDrawImageString16([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Drawable")] UIntPtr param1, [NativeTypeName("GC")] XGC* param2, int param3, int param4, [NativeTypeName("const XChar2b *")] XChar2b* param5, int param6);

        [DllImport(libraryPath, EntryPoint = "XDrawLine", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDrawLine([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Drawable")] UIntPtr param1, [NativeTypeName("GC")] XGC* param2, int param3, int param4, int param5, int param6);

        [DllImport(libraryPath, EntryPoint = "XDrawLines", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDrawLines([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Drawable")] UIntPtr param1, [NativeTypeName("GC")] XGC* param2, [NativeTypeName("XPoint *")] XPoint* param3, int param4, int param5);

        [DllImport(libraryPath, EntryPoint = "XDrawPoint", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDrawPoint([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Drawable")] UIntPtr param1, [NativeTypeName("GC")] XGC* param2, int param3, int param4);

        [DllImport(libraryPath, EntryPoint = "XDrawPoints", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDrawPoints([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Drawable")] UIntPtr param1, [NativeTypeName("GC")] XGC* param2, [NativeTypeName("XPoint *")] XPoint* param3, int param4, int param5);

        [DllImport(libraryPath, EntryPoint = "XDrawRectangle", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDrawRectangle([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Drawable")] UIntPtr param1, [NativeTypeName("GC")] XGC* param2, int param3, int param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned int")] uint param6);

        [DllImport(libraryPath, EntryPoint = "XDrawRectangles", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDrawRectangles([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Drawable")] UIntPtr param1, [NativeTypeName("GC")] XGC* param2, [NativeTypeName("XRectangle *")] XRectangle* param3, int param4);

        [DllImport(libraryPath, EntryPoint = "XDrawSegments", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDrawSegments([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Drawable")] UIntPtr param1, [NativeTypeName("GC")] XGC* param2, [NativeTypeName("XSegment *")] XSegment* param3, int param4);

        [DllImport(libraryPath, EntryPoint = "XDrawString", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDrawString([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Drawable")] UIntPtr param1, [NativeTypeName("GC")] XGC* param2, int param3, int param4, [NativeTypeName("const char *")] sbyte* param5, int param6);

        [DllImport(libraryPath, EntryPoint = "XDrawString16", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDrawString16([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Drawable")] UIntPtr param1, [NativeTypeName("GC")] XGC* param2, int param3, int param4, [NativeTypeName("const XChar2b *")] XChar2b* param5, int param6);

        [DllImport(libraryPath, EntryPoint = "XDrawText", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDrawText([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Drawable")] UIntPtr param1, [NativeTypeName("GC")] XGC* param2, int param3, int param4, [NativeTypeName("XTextItem *")] XTextItem* param5, int param6);

        [DllImport(libraryPath, EntryPoint = "XDrawText16", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDrawText16([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Drawable")] UIntPtr param1, [NativeTypeName("GC")] XGC* param2, int param3, int param4, [NativeTypeName("XTextItem16 *")] XTextItem16* param5, int param6);

        [DllImport(libraryPath, EntryPoint = "XEnableAccessControl", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XEnableAccessControl([NativeTypeName("Display *")] XDisplay* param0);

        [DllImport(libraryPath, EntryPoint = "XEventsQueued", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XEventsQueued([NativeTypeName("Display *")] XDisplay* param0, int param1);

        [DllImport(libraryPath, EntryPoint = "XFetchName", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XFetchName([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("char **")] sbyte** param2);

        [DllImport(libraryPath, EntryPoint = "XFillArc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XFillArc([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Drawable")] UIntPtr param1, [NativeTypeName("GC")] XGC* param2, int param3, int param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned int")] uint param6, int param7, int param8);

        [DllImport(libraryPath, EntryPoint = "XFillArcs", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XFillArcs([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Drawable")] UIntPtr param1, [NativeTypeName("GC")] XGC* param2, [NativeTypeName("XArc *")] XArc* param3, int param4);

        [DllImport(libraryPath, EntryPoint = "XFillPolygon", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XFillPolygon([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Drawable")] UIntPtr param1, [NativeTypeName("GC")] XGC* param2, [NativeTypeName("XPoint *")] XPoint* param3, int param4, int param5, int param6);

        [DllImport(libraryPath, EntryPoint = "XFillRectangle", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XFillRectangle([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Drawable")] UIntPtr param1, [NativeTypeName("GC")] XGC* param2, int param3, int param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned int")] uint param6);

        [DllImport(libraryPath, EntryPoint = "XFillRectangles", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XFillRectangles([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Drawable")] UIntPtr param1, [NativeTypeName("GC")] XGC* param2, [NativeTypeName("XRectangle *")] XRectangle* param3, int param4);

        [DllImport(libraryPath, EntryPoint = "XFlush", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XFlush([NativeTypeName("Display *")] XDisplay* param0);

        [DllImport(libraryPath, EntryPoint = "XForceScreenSaver", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XForceScreenSaver([NativeTypeName("Display *")] XDisplay* param0, int param1);

        [DllImport(libraryPath, EntryPoint = "XFree", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XFree([NativeTypeName("void *")] void* param0);

        [DllImport(libraryPath, EntryPoint = "XFreeColormap", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XFreeColormap([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Colormap")] UIntPtr param1);

        [DllImport(libraryPath, EntryPoint = "XFreeColors", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XFreeColors([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Colormap")] UIntPtr param1, [NativeTypeName("unsigned long *")] UIntPtr* param2, int param3, [NativeTypeName("unsigned long")] UIntPtr param4);

        [DllImport(libraryPath, EntryPoint = "XFreeCursor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XFreeCursor([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Cursor")] UIntPtr param1);

        [DllImport(libraryPath, EntryPoint = "XFreeExtensionList", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XFreeExtensionList([NativeTypeName("char **")] sbyte** param0);

        [DllImport(libraryPath, EntryPoint = "XFreeFont", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XFreeFont([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("XFontStruct *")] XFontStruct* param1);

        [DllImport(libraryPath, EntryPoint = "XFreeFontInfo", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XFreeFontInfo([NativeTypeName("char **")] sbyte** param0, [NativeTypeName("XFontStruct *")] XFontStruct* param1, int param2);

        [DllImport(libraryPath, EntryPoint = "XFreeFontNames", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XFreeFontNames([NativeTypeName("char **")] sbyte** param0);

        [DllImport(libraryPath, EntryPoint = "XFreeFontPath", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XFreeFontPath([NativeTypeName("char **")] sbyte** param0);

        [DllImport(libraryPath, EntryPoint = "XFreeGC", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XFreeGC([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("GC")] XGC* param1);

        [DllImport(libraryPath, EntryPoint = "XFreeModifiermap", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XFreeModifiermap([NativeTypeName("XModifierKeymap *")] XModifierKeymap* param0);

        [DllImport(libraryPath, EntryPoint = "XFreePixmap", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XFreePixmap([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Pixmap")] UIntPtr param1);

        [DllImport(libraryPath, EntryPoint = "XGeometry", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGeometry([NativeTypeName("Display *")] XDisplay* param0, int param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("const char *")] sbyte* param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned int")] uint param6, int param7, int param8, [NativeTypeName("int *")] int* param9, [NativeTypeName("int *")] int* param10, [NativeTypeName("int *")] int* param11, [NativeTypeName("int *")] int* param12);

        [DllImport(libraryPath, EntryPoint = "XGetErrorDatabaseText", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetErrorDatabaseText([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("const char *")] sbyte* param3, [NativeTypeName("char *")] sbyte* param4, int param5);

        [DllImport(libraryPath, EntryPoint = "XGetErrorText", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetErrorText([NativeTypeName("Display *")] XDisplay* param0, int param1, [NativeTypeName("char *")] sbyte* param2, int param3);

        [DllImport(libraryPath, EntryPoint = "XGetFontProperty", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetFontProperty([NativeTypeName("XFontStruct *")] XFontStruct* param0, [NativeTypeName("Atom")] UIntPtr param1, [NativeTypeName("unsigned long *")] UIntPtr* param2);

        [DllImport(libraryPath, EntryPoint = "XGetGCValues", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetGCValues([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("GC")] XGC* param1, [NativeTypeName("unsigned long")] UIntPtr param2, [NativeTypeName("XGCValues *")] XGCValues* param3);

        [DllImport(libraryPath, EntryPoint = "XGetGeometry", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetGeometry([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Drawable")] UIntPtr param1, [NativeTypeName("Window *")] UIntPtr* param2, [NativeTypeName("int *")] int* param3, [NativeTypeName("int *")] int* param4, [NativeTypeName("unsigned int *")] uint* param5, [NativeTypeName("unsigned int *")] uint* param6, [NativeTypeName("unsigned int *")] uint* param7, [NativeTypeName("unsigned int *")] uint* param8);

        [DllImport(libraryPath, EntryPoint = "XGetIconName", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetIconName([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("char **")] sbyte** param2);

        [DllImport(libraryPath, EntryPoint = "XGetInputFocus", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetInputFocus([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window *")] UIntPtr* param1, [NativeTypeName("int *")] int* param2);

        [DllImport(libraryPath, EntryPoint = "XGetKeyboardControl", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetKeyboardControl([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("XKeyboardState *")] XKeyboardState* param1);

        [DllImport(libraryPath, EntryPoint = "XGetPointerControl", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetPointerControl([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("int *")] int* param1, [NativeTypeName("int *")] int* param2, [NativeTypeName("int *")] int* param3);

        [DllImport(libraryPath, EntryPoint = "XGetPointerMapping", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetPointerMapping([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("unsigned char *")] byte* param1, int param2);

        [DllImport(libraryPath, EntryPoint = "XGetScreenSaver", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetScreenSaver([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("int *")] int* param1, [NativeTypeName("int *")] int* param2, [NativeTypeName("int *")] int* param3, [NativeTypeName("int *")] int* param4);

        [DllImport(libraryPath, EntryPoint = "XGetTransientForHint", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetTransientForHint([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("Window *")] UIntPtr* param2);

        [DllImport(libraryPath, EntryPoint = "XGetWindowProperty", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetWindowProperty([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("Atom")] UIntPtr param2, [NativeTypeName("long")] IntPtr param3, [NativeTypeName("long")] IntPtr param4, int param5, [NativeTypeName("Atom")] UIntPtr param6, [NativeTypeName("Atom *")] UIntPtr* param7, [NativeTypeName("int *")] int* param8, [NativeTypeName("unsigned long *")] UIntPtr* param9, [NativeTypeName("unsigned long *")] UIntPtr* param10, [NativeTypeName("unsigned char **")] byte** param11);

        [DllImport(libraryPath, EntryPoint = "XGetWindowAttributes", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetWindowAttributes([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("XWindowAttributes *")] XWindowAttributes* param2);

        [DllImport(libraryPath, EntryPoint = "XGrabButton", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGrabButton([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("Window")] UIntPtr param3, int param4, [NativeTypeName("unsigned int")] uint param5, int param6, int param7, [NativeTypeName("Window")] UIntPtr param8, [NativeTypeName("Cursor")] UIntPtr param9);

        [DllImport(libraryPath, EntryPoint = "XGrabKey", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGrabKey([NativeTypeName("Display *")] XDisplay* param0, int param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("Window")] UIntPtr param3, int param4, int param5, int param6);

        [DllImport(libraryPath, EntryPoint = "XGrabKeyboard", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGrabKeyboard([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, int param2, int param3, int param4, [NativeTypeName("Time")] UIntPtr param5);

        [DllImport(libraryPath, EntryPoint = "XGrabPointer", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGrabPointer([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, int param2, [NativeTypeName("unsigned int")] uint param3, int param4, int param5, [NativeTypeName("Window")] UIntPtr param6, [NativeTypeName("Cursor")] UIntPtr param7, [NativeTypeName("Time")] UIntPtr param8);

        [DllImport(libraryPath, EntryPoint = "XGrabServer", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGrabServer([NativeTypeName("Display *")] XDisplay* param0);

        [DllImport(libraryPath, EntryPoint = "XHeightMMOfScreen", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XHeightMMOfScreen([NativeTypeName("Screen *")] Screen* param0);

        [DllImport(libraryPath, EntryPoint = "XHeightOfScreen", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XHeightOfScreen([NativeTypeName("Screen *")] Screen* param0);

        [DllImport(libraryPath, EntryPoint = "XIfEvent", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XIfEvent([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("XEvent *")] XEvent* param1, [NativeTypeName("int (*)(Display *, XEvent *, XPointer)")] IntPtr param2, [NativeTypeName("XPointer")] sbyte* param3);

        [DllImport(libraryPath, EntryPoint = "XImageByteOrder", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XImageByteOrder([NativeTypeName("Display *")] XDisplay* param0);

        [DllImport(libraryPath, EntryPoint = "XInstallColormap", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XInstallColormap([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Colormap")] UIntPtr param1);

        [DllImport(libraryPath, EntryPoint = "XKeysymToKeycode", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("KeyCode")]
        public static extern byte XKeysymToKeycode([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("KeySym")] UIntPtr param1);

        [DllImport(libraryPath, EntryPoint = "XKillClient", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XKillClient([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("XID")] UIntPtr param1);

        [DllImport(libraryPath, EntryPoint = "XLookupColor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XLookupColor([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Colormap")] UIntPtr param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("XColor *")] XColor* param3, [NativeTypeName("XColor *")] XColor* param4);

        [DllImport(libraryPath, EntryPoint = "XLowerWindow", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XLowerWindow([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1);

        [DllImport(libraryPath, EntryPoint = "XMapRaised", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XMapRaised([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1);

        [DllImport(libraryPath, EntryPoint = "XMapSubwindows", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XMapSubwindows([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1);

        [DllImport(libraryPath, EntryPoint = "XMapWindow", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XMapWindow([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1);

        [DllImport(libraryPath, EntryPoint = "XMaskEvent", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XMaskEvent([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("long")] IntPtr param1, [NativeTypeName("XEvent *")] XEvent* param2);

        [DllImport(libraryPath, EntryPoint = "XMaxCmapsOfScreen", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XMaxCmapsOfScreen([NativeTypeName("Screen *")] Screen* param0);

        [DllImport(libraryPath, EntryPoint = "XMinCmapsOfScreen", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XMinCmapsOfScreen([NativeTypeName("Screen *")] Screen* param0);

        [DllImport(libraryPath, EntryPoint = "XMoveResizeWindow", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XMoveResizeWindow([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, int param2, int param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int")] uint param5);

        [DllImport(libraryPath, EntryPoint = "XMoveWindow", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XMoveWindow([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, int param2, int param3);

        [DllImport(libraryPath, EntryPoint = "XNextEvent", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XNextEvent([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("XEvent *")] XEvent* param1);

        [DllImport(libraryPath, EntryPoint = "XNoOp", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XNoOp([NativeTypeName("Display *")] XDisplay* param0);

        [DllImport(libraryPath, EntryPoint = "XParseColor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XParseColor([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Colormap")] UIntPtr param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("XColor *")] XColor* param3);

        [DllImport(libraryPath, EntryPoint = "XParseGeometry", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XParseGeometry([NativeTypeName("const char *")] sbyte* param0, [NativeTypeName("int *")] int* param1, [NativeTypeName("int *")] int* param2, [NativeTypeName("unsigned int *")] uint* param3, [NativeTypeName("unsigned int *")] uint* param4);

        [DllImport(libraryPath, EntryPoint = "XPeekEvent", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XPeekEvent([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("XEvent *")] XEvent* param1);

        [DllImport(libraryPath, EntryPoint = "XPeekIfEvent", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XPeekIfEvent([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("XEvent *")] XEvent* param1, [NativeTypeName("int (*)(Display *, XEvent *, XPointer)")] IntPtr param2, [NativeTypeName("XPointer")] sbyte* param3);

        [DllImport(libraryPath, EntryPoint = "XPending", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XPending([NativeTypeName("Display *")] XDisplay* param0);

        [DllImport(libraryPath, EntryPoint = "XPlanesOfScreen", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XPlanesOfScreen([NativeTypeName("Screen *")] Screen* param0);

        [DllImport(libraryPath, EntryPoint = "XProtocolRevision", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XProtocolRevision([NativeTypeName("Display *")] XDisplay* param0);

        [DllImport(libraryPath, EntryPoint = "XProtocolVersion", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XProtocolVersion([NativeTypeName("Display *")] XDisplay* param0);

        [DllImport(libraryPath, EntryPoint = "XPutBackEvent", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XPutBackEvent([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("XEvent *")] XEvent* param1);

        [DllImport(libraryPath, EntryPoint = "XPutImage", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XPutImage([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Drawable")] UIntPtr param1, [NativeTypeName("GC")] XGC* param2, [NativeTypeName("XImage *")] XImage* param3, int param4, int param5, int param6, int param7, [NativeTypeName("unsigned int")] uint param8, [NativeTypeName("unsigned int")] uint param9);

        [DllImport(libraryPath, EntryPoint = "XQLength", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XQLength([NativeTypeName("Display *")] XDisplay* param0);

        [DllImport(libraryPath, EntryPoint = "XQueryBestCursor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XQueryBestCursor([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Drawable")] UIntPtr param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int *")] uint* param4, [NativeTypeName("unsigned int *")] uint* param5);

        [DllImport(libraryPath, EntryPoint = "XQueryBestSize", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XQueryBestSize([NativeTypeName("Display *")] XDisplay* param0, int param1, [NativeTypeName("Drawable")] UIntPtr param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int *")] uint* param5, [NativeTypeName("unsigned int *")] uint* param6);

        [DllImport(libraryPath, EntryPoint = "XQueryBestStipple", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XQueryBestStipple([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Drawable")] UIntPtr param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int *")] uint* param4, [NativeTypeName("unsigned int *")] uint* param5);

        [DllImport(libraryPath, EntryPoint = "XQueryBestTile", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XQueryBestTile([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Drawable")] UIntPtr param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int *")] uint* param4, [NativeTypeName("unsigned int *")] uint* param5);

        [DllImport(libraryPath, EntryPoint = "XQueryColor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XQueryColor([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Colormap")] UIntPtr param1, [NativeTypeName("XColor *")] XColor* param2);

        [DllImport(libraryPath, EntryPoint = "XQueryColors", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XQueryColors([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Colormap")] UIntPtr param1, [NativeTypeName("XColor *")] XColor* param2, int param3);

        [DllImport(libraryPath, EntryPoint = "XQueryExtension", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XQueryExtension([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("int *")] int* param2, [NativeTypeName("int *")] int* param3, [NativeTypeName("int *")] int* param4);

        [DllImport(libraryPath, EntryPoint = "XQueryKeymap", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XQueryKeymap([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("char [32]")] sbyte param1);

        [DllImport(libraryPath, EntryPoint = "XQueryPointer", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XQueryPointer([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("Window *")] UIntPtr* param2, [NativeTypeName("Window *")] UIntPtr* param3, [NativeTypeName("int *")] int* param4, [NativeTypeName("int *")] int* param5, [NativeTypeName("int *")] int* param6, [NativeTypeName("int *")] int* param7, [NativeTypeName("unsigned int *")] uint* param8);

        [DllImport(libraryPath, EntryPoint = "XQueryTextExtents", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XQueryTextExtents([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("XID")] UIntPtr param1, [NativeTypeName("const char *")] sbyte* param2, int param3, [NativeTypeName("int *")] int* param4, [NativeTypeName("int *")] int* param5, [NativeTypeName("int *")] int* param6, [NativeTypeName("XCharStruct *")] XCharStruct* param7);

        [DllImport(libraryPath, EntryPoint = "XQueryTextExtents16", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XQueryTextExtents16([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("XID")] UIntPtr param1, [NativeTypeName("const XChar2b *")] XChar2b* param2, int param3, [NativeTypeName("int *")] int* param4, [NativeTypeName("int *")] int* param5, [NativeTypeName("int *")] int* param6, [NativeTypeName("XCharStruct *")] XCharStruct* param7);

        [DllImport(libraryPath, EntryPoint = "XQueryTree", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XQueryTree([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("Window *")] UIntPtr* param2, [NativeTypeName("Window *")] UIntPtr* param3, [NativeTypeName("Window **")] UIntPtr** param4, [NativeTypeName("unsigned int *")] uint* param5);

        [DllImport(libraryPath, EntryPoint = "XRaiseWindow", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XRaiseWindow([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1);

        [DllImport(libraryPath, EntryPoint = "XReadBitmapFile", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XReadBitmapFile([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Drawable")] UIntPtr param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("unsigned int *")] uint* param3, [NativeTypeName("unsigned int *")] uint* param4, [NativeTypeName("Pixmap *")] UIntPtr* param5, [NativeTypeName("int *")] int* param6, [NativeTypeName("int *")] int* param7);

        [DllImport(libraryPath, EntryPoint = "XReadBitmapFileData", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XReadBitmapFileData([NativeTypeName("const char *")] sbyte* param0, [NativeTypeName("unsigned int *")] uint* param1, [NativeTypeName("unsigned int *")] uint* param2, [NativeTypeName("unsigned char **")] byte** param3, [NativeTypeName("int *")] int* param4, [NativeTypeName("int *")] int* param5);

        [DllImport(libraryPath, EntryPoint = "XRebindKeysym", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XRebindKeysym([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("KeySym")] UIntPtr param1, [NativeTypeName("KeySym *")] UIntPtr* param2, int param3, [NativeTypeName("const unsigned char *")] byte* param4, int param5);

        [DllImport(libraryPath, EntryPoint = "XRecolorCursor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XRecolorCursor([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Cursor")] UIntPtr param1, [NativeTypeName("XColor *")] XColor* param2, [NativeTypeName("XColor *")] XColor* param3);

        [DllImport(libraryPath, EntryPoint = "XRefreshKeyboardMapping", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XRefreshKeyboardMapping([NativeTypeName("XMappingEvent *")] XMappingEvent* param0);

        [DllImport(libraryPath, EntryPoint = "XRemoveFromSaveSet", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XRemoveFromSaveSet([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1);

        [DllImport(libraryPath, EntryPoint = "XRemoveHost", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XRemoveHost([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("XHostAddress *")] XHostAddress* param1);

        [DllImport(libraryPath, EntryPoint = "XRemoveHosts", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XRemoveHosts([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("XHostAddress *")] XHostAddress* param1, int param2);

        [DllImport(libraryPath, EntryPoint = "XReparentWindow", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XReparentWindow([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("Window")] UIntPtr param2, int param3, int param4);

        [DllImport(libraryPath, EntryPoint = "XResetScreenSaver", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XResetScreenSaver([NativeTypeName("Display *")] XDisplay* param0);

        [DllImport(libraryPath, EntryPoint = "XResizeWindow", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XResizeWindow([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3);

        [DllImport(libraryPath, EntryPoint = "XRestackWindows", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XRestackWindows([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window *")] UIntPtr* param1, int param2);

        [DllImport(libraryPath, EntryPoint = "XRotateBuffers", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XRotateBuffers([NativeTypeName("Display *")] XDisplay* param0, int param1);

        [DllImport(libraryPath, EntryPoint = "XRotateWindowProperties", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XRotateWindowProperties([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("Atom *")] UIntPtr* param2, int param3, int param4);

        [DllImport(libraryPath, EntryPoint = "XScreenCount", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XScreenCount([NativeTypeName("Display *")] XDisplay* param0);

        [DllImport(libraryPath, EntryPoint = "XSelectInput", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSelectInput([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("long")] IntPtr param2);

        [DllImport(libraryPath, EntryPoint = "XSendEvent", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSendEvent([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, int param2, [NativeTypeName("long")] IntPtr param3, [NativeTypeName("XEvent *")] XEvent* param4);

        [DllImport(libraryPath, EntryPoint = "XSetAccessControl", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetAccessControl([NativeTypeName("Display *")] XDisplay* param0, int param1);

        [DllImport(libraryPath, EntryPoint = "XSetArcMode", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetArcMode([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("GC")] XGC* param1, int param2);

        [DllImport(libraryPath, EntryPoint = "XSetBackground", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetBackground([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("GC")] XGC* param1, [NativeTypeName("unsigned long")] UIntPtr param2);

        [DllImport(libraryPath, EntryPoint = "XSetClipMask", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetClipMask([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("GC")] XGC* param1, [NativeTypeName("Pixmap")] UIntPtr param2);

        [DllImport(libraryPath, EntryPoint = "XSetClipOrigin", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetClipOrigin([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("GC")] XGC* param1, int param2, int param3);

        [DllImport(libraryPath, EntryPoint = "XSetClipRectangles", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetClipRectangles([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("GC")] XGC* param1, int param2, int param3, [NativeTypeName("XRectangle *")] XRectangle* param4, int param5, int param6);

        [DllImport(libraryPath, EntryPoint = "XSetCloseDownMode", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetCloseDownMode([NativeTypeName("Display *")] XDisplay* param0, int param1);

        [DllImport(libraryPath, EntryPoint = "XSetCommand", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetCommand([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("char **")] sbyte** param2, int param3);

        [DllImport(libraryPath, EntryPoint = "XSetDashes", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetDashes([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("GC")] XGC* param1, int param2, [NativeTypeName("const char *")] sbyte* param3, int param4);

        [DllImport(libraryPath, EntryPoint = "XSetFillRule", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetFillRule([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("GC")] XGC* param1, int param2);

        [DllImport(libraryPath, EntryPoint = "XSetFillStyle", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetFillStyle([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("GC")] XGC* param1, int param2);

        [DllImport(libraryPath, EntryPoint = "XSetFont", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetFont([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("GC")] XGC* param1, [NativeTypeName("Font")] UIntPtr param2);

        [DllImport(libraryPath, EntryPoint = "XSetFontPath", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetFontPath([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("char **")] sbyte** param1, int param2);

        [DllImport(libraryPath, EntryPoint = "XSetForeground", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetForeground([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("GC")] XGC* param1, [NativeTypeName("unsigned long")] UIntPtr param2);

        [DllImport(libraryPath, EntryPoint = "XSetFunction", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetFunction([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("GC")] XGC* param1, int param2);

        [DllImport(libraryPath, EntryPoint = "XSetGraphicsExposures", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetGraphicsExposures([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("GC")] XGC* param1, int param2);

        [DllImport(libraryPath, EntryPoint = "XSetIconName", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetIconName([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("const char *")] sbyte* param2);

        [DllImport(libraryPath, EntryPoint = "XSetInputFocus", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetInputFocus([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, int param2, [NativeTypeName("Time")] UIntPtr param3);

        [DllImport(libraryPath, EntryPoint = "XSetLineAttributes", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetLineAttributes([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("GC")] XGC* param1, [NativeTypeName("unsigned int")] uint param2, int param3, int param4, int param5);

        [DllImport(libraryPath, EntryPoint = "XSetModifierMapping", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetModifierMapping([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("XModifierKeymap *")] XModifierKeymap* param1);

        [DllImport(libraryPath, EntryPoint = "XSetPlaneMask", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetPlaneMask([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("GC")] XGC* param1, [NativeTypeName("unsigned long")] UIntPtr param2);

        [DllImport(libraryPath, EntryPoint = "XSetPointerMapping", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetPointerMapping([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("const unsigned char *")] byte* param1, int param2);

        [DllImport(libraryPath, EntryPoint = "XSetScreenSaver", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetScreenSaver([NativeTypeName("Display *")] XDisplay* param0, int param1, int param2, int param3, int param4);

        [DllImport(libraryPath, EntryPoint = "XSetSelectionOwner", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetSelectionOwner([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Atom")] UIntPtr param1, [NativeTypeName("Window")] UIntPtr param2, [NativeTypeName("Time")] UIntPtr param3);

        [DllImport(libraryPath, EntryPoint = "XSetState", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetState([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("GC")] XGC* param1, [NativeTypeName("unsigned long")] UIntPtr param2, [NativeTypeName("unsigned long")] UIntPtr param3, int param4, [NativeTypeName("unsigned long")] UIntPtr param5);

        [DllImport(libraryPath, EntryPoint = "XSetStipple", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetStipple([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("GC")] XGC* param1, [NativeTypeName("Pixmap")] UIntPtr param2);

        [DllImport(libraryPath, EntryPoint = "XSetSubwindowMode", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetSubwindowMode([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("GC")] XGC* param1, int param2);

        [DllImport(libraryPath, EntryPoint = "XSetTSOrigin", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetTSOrigin([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("GC")] XGC* param1, int param2, int param3);

        [DllImport(libraryPath, EntryPoint = "XSetTile", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetTile([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("GC")] XGC* param1, [NativeTypeName("Pixmap")] UIntPtr param2);

        [DllImport(libraryPath, EntryPoint = "XSetWindowBackground", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetWindowBackground([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("unsigned long")] UIntPtr param2);

        [DllImport(libraryPath, EntryPoint = "XSetWindowBackgroundPixmap", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetWindowBackgroundPixmap([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("Pixmap")] UIntPtr param2);

        [DllImport(libraryPath, EntryPoint = "XSetWindowBorder", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetWindowBorder([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("unsigned long")] UIntPtr param2);

        [DllImport(libraryPath, EntryPoint = "XSetWindowBorderPixmap", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetWindowBorderPixmap([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("Pixmap")] UIntPtr param2);

        [DllImport(libraryPath, EntryPoint = "XSetWindowBorderWidth", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetWindowBorderWidth([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("unsigned int")] uint param2);

        [DllImport(libraryPath, EntryPoint = "XSetWindowColormap", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetWindowColormap([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("Colormap")] UIntPtr param2);

        [DllImport(libraryPath, EntryPoint = "XStoreBuffer", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XStoreBuffer([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("const char *")] sbyte* param1, int param2, int param3);

        [DllImport(libraryPath, EntryPoint = "XStoreBytes", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XStoreBytes([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("const char *")] sbyte* param1, int param2);

        [DllImport(libraryPath, EntryPoint = "XStoreColor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XStoreColor([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Colormap")] UIntPtr param1, [NativeTypeName("XColor *")] XColor* param2);

        [DllImport(libraryPath, EntryPoint = "XStoreColors", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XStoreColors([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Colormap")] UIntPtr param1, [NativeTypeName("XColor *")] XColor* param2, int param3);

        [DllImport(libraryPath, EntryPoint = "XStoreName", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XStoreName([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("const char *")] sbyte* param2);

        [DllImport(libraryPath, EntryPoint = "XStoreNamedColor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XStoreNamedColor([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Colormap")] UIntPtr param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("unsigned long")] UIntPtr param3, int param4);

        [DllImport(libraryPath, EntryPoint = "XSync", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSync([NativeTypeName("Display *")] XDisplay* param0, int param1);

        [DllImport(libraryPath, EntryPoint = "XTextExtents", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XTextExtents([NativeTypeName("XFontStruct *")] XFontStruct* param0, [NativeTypeName("const char *")] sbyte* param1, int param2, [NativeTypeName("int *")] int* param3, [NativeTypeName("int *")] int* param4, [NativeTypeName("int *")] int* param5, [NativeTypeName("XCharStruct *")] XCharStruct* param6);

        [DllImport(libraryPath, EntryPoint = "XTextExtents16", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XTextExtents16([NativeTypeName("XFontStruct *")] XFontStruct* param0, [NativeTypeName("const XChar2b *")] XChar2b* param1, int param2, [NativeTypeName("int *")] int* param3, [NativeTypeName("int *")] int* param4, [NativeTypeName("int *")] int* param5, [NativeTypeName("XCharStruct *")] XCharStruct* param6);

        [DllImport(libraryPath, EntryPoint = "XTextWidth", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XTextWidth([NativeTypeName("XFontStruct *")] XFontStruct* param0, [NativeTypeName("const char *")] sbyte* param1, int param2);

        [DllImport(libraryPath, EntryPoint = "XTextWidth16", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XTextWidth16([NativeTypeName("XFontStruct *")] XFontStruct* param0, [NativeTypeName("const XChar2b *")] XChar2b* param1, int param2);

        [DllImport(libraryPath, EntryPoint = "XTranslateCoordinates", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XTranslateCoordinates([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("Window")] UIntPtr param2, int param3, int param4, [NativeTypeName("int *")] int* param5, [NativeTypeName("int *")] int* param6, [NativeTypeName("Window *")] UIntPtr* param7);

        [DllImport(libraryPath, EntryPoint = "XUndefineCursor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XUndefineCursor([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1);

        [DllImport(libraryPath, EntryPoint = "XUngrabButton", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XUngrabButton([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("Window")] UIntPtr param3);

        [DllImport(libraryPath, EntryPoint = "XUngrabKey", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XUngrabKey([NativeTypeName("Display *")] XDisplay* param0, int param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("Window")] UIntPtr param3);

        [DllImport(libraryPath, EntryPoint = "XUngrabKeyboard", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XUngrabKeyboard([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Time")] UIntPtr param1);

        [DllImport(libraryPath, EntryPoint = "XUngrabPointer", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XUngrabPointer([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Time")] UIntPtr param1);

        [DllImport(libraryPath, EntryPoint = "XUngrabServer", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XUngrabServer([NativeTypeName("Display *")] XDisplay* param0);

        [DllImport(libraryPath, EntryPoint = "XUninstallColormap", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XUninstallColormap([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Colormap")] UIntPtr param1);

        [DllImport(libraryPath, EntryPoint = "XUnloadFont", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XUnloadFont([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Font")] UIntPtr param1);

        [DllImport(libraryPath, EntryPoint = "XUnmapSubwindows", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XUnmapSubwindows([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1);

        [DllImport(libraryPath, EntryPoint = "XUnmapWindow", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XUnmapWindow([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1);

        [DllImport(libraryPath, EntryPoint = "XVendorRelease", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XVendorRelease([NativeTypeName("Display *")] XDisplay* param0);

        [DllImport(libraryPath, EntryPoint = "XWarpPointer", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XWarpPointer([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("Window")] UIntPtr param2, int param3, int param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned int")] uint param6, int param7, int param8);

        [DllImport(libraryPath, EntryPoint = "XWidthMMOfScreen", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XWidthMMOfScreen([NativeTypeName("Screen *")] Screen* param0);

        [DllImport(libraryPath, EntryPoint = "XWidthOfScreen", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XWidthOfScreen([NativeTypeName("Screen *")] Screen* param0);

        [DllImport(libraryPath, EntryPoint = "XWindowEvent", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XWindowEvent([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("long")] IntPtr param2, [NativeTypeName("XEvent *")] XEvent* param3);

        [DllImport(libraryPath, EntryPoint = "XWriteBitmapFile", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XWriteBitmapFile([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("Pixmap")] UIntPtr param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int")] uint param4, int param5, int param6);

        [DllImport(libraryPath, EntryPoint = "XSupportsLocale", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSupportsLocale();

        [DllImport(libraryPath, EntryPoint = "XSetLocaleModifiers", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XSetLocaleModifiers([NativeTypeName("const char *")] sbyte* param0);

        [DllImport(libraryPath, EntryPoint = "XOpenOM", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XOM")]
        public static extern XOM* XOpenOM([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("struct XrmHashBucketRec *")] XrmHashBucketRec* param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("const char *")] sbyte* param3);

        [DllImport(libraryPath, EntryPoint = "XCloseOM", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XCloseOM([NativeTypeName("XOM")] XOM* param0);

        [DllImport(libraryPath, EntryPoint = "XSetOMValues", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XSetOMValues([NativeTypeName("XOM")] XOM* param0);

        [DllImport(libraryPath, EntryPoint = "XGetOMValues", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XGetOMValues([NativeTypeName("XOM")] XOM* param0);

        [DllImport(libraryPath, EntryPoint = "XDisplayOfOM", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Display *")]
        public static extern XDisplay* XDisplayOfOM([NativeTypeName("XOM")] XOM* param0);

        [DllImport(libraryPath, EntryPoint = "XLocaleOfOM", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XLocaleOfOM([NativeTypeName("XOM")] XOM* param0);

        [DllImport(libraryPath, EntryPoint = "XCreateOC", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XOC")]
        public static extern XOC* XCreateOC([NativeTypeName("XOM")] XOM* param0);

        [DllImport(libraryPath, EntryPoint = "XDestroyOC", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XDestroyOC([NativeTypeName("XOC")] XOC* param0);

        [DllImport(libraryPath, EntryPoint = "XOMOfOC", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XOM")]
        public static extern XOM* XOMOfOC([NativeTypeName("XOC")] XOC* param0);

        [DllImport(libraryPath, EntryPoint = "XSetOCValues", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XSetOCValues([NativeTypeName("XOC")] XOC* param0);

        [DllImport(libraryPath, EntryPoint = "XGetOCValues", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XGetOCValues([NativeTypeName("XOC")] XOC* param0);

        [DllImport(libraryPath, EntryPoint = "XCreateFontSet", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XFontSet")]
        public static extern XOC* XCreateFontSet([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("char ***")] sbyte*** param2, [NativeTypeName("int *")] int* param3, [NativeTypeName("char **")] sbyte** param4);

        [DllImport(libraryPath, EntryPoint = "XFreeFontSet", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XFreeFontSet([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("XFontSet")] XOC* param1);

        [DllImport(libraryPath, EntryPoint = "XFontsOfFontSet", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XFontsOfFontSet([NativeTypeName("XFontSet")] XOC* param0, [NativeTypeName("XFontStruct ***")] XFontStruct*** param1, [NativeTypeName("char ***")] sbyte*** param2);

        [DllImport(libraryPath, EntryPoint = "XBaseFontNameListOfFontSet", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XBaseFontNameListOfFontSet([NativeTypeName("XFontSet")] XOC* param0);

        [DllImport(libraryPath, EntryPoint = "XLocaleOfFontSet", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XLocaleOfFontSet([NativeTypeName("XFontSet")] XOC* param0);

        [DllImport(libraryPath, EntryPoint = "XContextDependentDrawing", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XContextDependentDrawing([NativeTypeName("XFontSet")] XOC* param0);

        [DllImport(libraryPath, EntryPoint = "XDirectionalDependentDrawing", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDirectionalDependentDrawing([NativeTypeName("XFontSet")] XOC* param0);

        [DllImport(libraryPath, EntryPoint = "XContextualDrawing", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XContextualDrawing([NativeTypeName("XFontSet")] XOC* param0);

        [DllImport(libraryPath, EntryPoint = "XExtentsOfFontSet", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XFontSetExtents *")]
        public static extern XFontSetExtents* XExtentsOfFontSet([NativeTypeName("XFontSet")] XOC* param0);

        [DllImport(libraryPath, EntryPoint = "XmbTextEscapement", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XmbTextEscapement([NativeTypeName("XFontSet")] XOC* param0, [NativeTypeName("const char *")] sbyte* param1, int param2);

        [DllImport(libraryPath, EntryPoint = "XwcTextEscapement", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XwcTextEscapement([NativeTypeName("XFontSet")] XOC* param0, [NativeTypeName("const wchar_t *")] int* param1, int param2);

        [DllImport(libraryPath, EntryPoint = "Xutf8TextEscapement", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Xutf8TextEscapement([NativeTypeName("XFontSet")] XOC* param0, [NativeTypeName("const char *")] sbyte* param1, int param2);

        [DllImport(libraryPath, EntryPoint = "XmbTextExtents", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XmbTextExtents([NativeTypeName("XFontSet")] XOC* param0, [NativeTypeName("const char *")] sbyte* param1, int param2, [NativeTypeName("XRectangle *")] XRectangle* param3, [NativeTypeName("XRectangle *")] XRectangle* param4);

        [DllImport(libraryPath, EntryPoint = "XwcTextExtents", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XwcTextExtents([NativeTypeName("XFontSet")] XOC* param0, [NativeTypeName("const wchar_t *")] int* param1, int param2, [NativeTypeName("XRectangle *")] XRectangle* param3, [NativeTypeName("XRectangle *")] XRectangle* param4);

        [DllImport(libraryPath, EntryPoint = "Xutf8TextExtents", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Xutf8TextExtents([NativeTypeName("XFontSet")] XOC* param0, [NativeTypeName("const char *")] sbyte* param1, int param2, [NativeTypeName("XRectangle *")] XRectangle* param3, [NativeTypeName("XRectangle *")] XRectangle* param4);

        [DllImport(libraryPath, EntryPoint = "XmbTextPerCharExtents", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XmbTextPerCharExtents([NativeTypeName("XFontSet")] XOC* param0, [NativeTypeName("const char *")] sbyte* param1, int param2, [NativeTypeName("XRectangle *")] XRectangle* param3, [NativeTypeName("XRectangle *")] XRectangle* param4, int param5, [NativeTypeName("int *")] int* param6, [NativeTypeName("XRectangle *")] XRectangle* param7, [NativeTypeName("XRectangle *")] XRectangle* param8);

        [DllImport(libraryPath, EntryPoint = "XwcTextPerCharExtents", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XwcTextPerCharExtents([NativeTypeName("XFontSet")] XOC* param0, [NativeTypeName("const wchar_t *")] int* param1, int param2, [NativeTypeName("XRectangle *")] XRectangle* param3, [NativeTypeName("XRectangle *")] XRectangle* param4, int param5, [NativeTypeName("int *")] int* param6, [NativeTypeName("XRectangle *")] XRectangle* param7, [NativeTypeName("XRectangle *")] XRectangle* param8);

        [DllImport(libraryPath, EntryPoint = "Xutf8TextPerCharExtents", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Xutf8TextPerCharExtents([NativeTypeName("XFontSet")] XOC* param0, [NativeTypeName("const char *")] sbyte* param1, int param2, [NativeTypeName("XRectangle *")] XRectangle* param3, [NativeTypeName("XRectangle *")] XRectangle* param4, int param5, [NativeTypeName("int *")] int* param6, [NativeTypeName("XRectangle *")] XRectangle* param7, [NativeTypeName("XRectangle *")] XRectangle* param8);

        [DllImport(libraryPath, EntryPoint = "XmbDrawText", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XmbDrawText([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Drawable")] UIntPtr param1, [NativeTypeName("GC")] XGC* param2, int param3, int param4, [NativeTypeName("XmbTextItem *")] XmbTextItem* param5, int param6);

        [DllImport(libraryPath, EntryPoint = "XwcDrawText", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XwcDrawText([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Drawable")] UIntPtr param1, [NativeTypeName("GC")] XGC* param2, int param3, int param4, [NativeTypeName("XwcTextItem *")] XwcTextItem* param5, int param6);

        [DllImport(libraryPath, EntryPoint = "Xutf8DrawText", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Xutf8DrawText([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Drawable")] UIntPtr param1, [NativeTypeName("GC")] XGC* param2, int param3, int param4, [NativeTypeName("XmbTextItem *")] XmbTextItem* param5, int param6);

        [DllImport(libraryPath, EntryPoint = "XmbDrawString", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XmbDrawString([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Drawable")] UIntPtr param1, [NativeTypeName("XFontSet")] XOC* param2, [NativeTypeName("GC")] XGC* param3, int param4, int param5, [NativeTypeName("const char *")] sbyte* param6, int param7);

        [DllImport(libraryPath, EntryPoint = "XwcDrawString", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XwcDrawString([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Drawable")] UIntPtr param1, [NativeTypeName("XFontSet")] XOC* param2, [NativeTypeName("GC")] XGC* param3, int param4, int param5, [NativeTypeName("const wchar_t *")] int* param6, int param7);

        [DllImport(libraryPath, EntryPoint = "Xutf8DrawString", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Xutf8DrawString([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Drawable")] UIntPtr param1, [NativeTypeName("XFontSet")] XOC* param2, [NativeTypeName("GC")] XGC* param3, int param4, int param5, [NativeTypeName("const char *")] sbyte* param6, int param7);

        [DllImport(libraryPath, EntryPoint = "XmbDrawImageString", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XmbDrawImageString([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Drawable")] UIntPtr param1, [NativeTypeName("XFontSet")] XOC* param2, [NativeTypeName("GC")] XGC* param3, int param4, int param5, [NativeTypeName("const char *")] sbyte* param6, int param7);

        [DllImport(libraryPath, EntryPoint = "XwcDrawImageString", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XwcDrawImageString([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Drawable")] UIntPtr param1, [NativeTypeName("XFontSet")] XOC* param2, [NativeTypeName("GC")] XGC* param3, int param4, int param5, [NativeTypeName("const wchar_t *")] int* param6, int param7);

        [DllImport(libraryPath, EntryPoint = "Xutf8DrawImageString", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Xutf8DrawImageString([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Drawable")] UIntPtr param1, [NativeTypeName("XFontSet")] XOC* param2, [NativeTypeName("GC")] XGC* param3, int param4, int param5, [NativeTypeName("const char *")] sbyte* param6, int param7);

        [DllImport(libraryPath, EntryPoint = "XOpenIM", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XIM")]
        public static extern XIM* XOpenIM([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("struct XrmHashBucketRec *")] XrmHashBucketRec* param1, [NativeTypeName("char *")] sbyte* param2, [NativeTypeName("char *")] sbyte* param3);

        [DllImport(libraryPath, EntryPoint = "XCloseIM", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XCloseIM([NativeTypeName("XIM")] XIM* param0);

        [DllImport(libraryPath, EntryPoint = "XGetIMValues", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XGetIMValues([NativeTypeName("XIM")] XIM* param0);

        [DllImport(libraryPath, EntryPoint = "XSetIMValues", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XSetIMValues([NativeTypeName("XIM")] XIM* param0);

        [DllImport(libraryPath, EntryPoint = "XDisplayOfIM", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Display *")]
        public static extern XDisplay* XDisplayOfIM([NativeTypeName("XIM")] XIM* param0);

        [DllImport(libraryPath, EntryPoint = "XLocaleOfIM", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XLocaleOfIM([NativeTypeName("XIM")] XIM* param0);

        [DllImport(libraryPath, EntryPoint = "XCreateIC", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XIC")]
        public static extern XIC* XCreateIC([NativeTypeName("XIM")] XIM* param0);

        [DllImport(libraryPath, EntryPoint = "XDestroyIC", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XDestroyIC([NativeTypeName("XIC")] XIC* param0);

        [DllImport(libraryPath, EntryPoint = "XSetICFocus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XSetICFocus([NativeTypeName("XIC")] XIC* param0);

        [DllImport(libraryPath, EntryPoint = "XUnsetICFocus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XUnsetICFocus([NativeTypeName("XIC")] XIC* param0);

        [DllImport(libraryPath, EntryPoint = "XwcResetIC", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("wchar_t *")]
        public static extern int* XwcResetIC([NativeTypeName("XIC")] XIC* param0);

        [DllImport(libraryPath, EntryPoint = "XmbResetIC", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XmbResetIC([NativeTypeName("XIC")] XIC* param0);

        [DllImport(libraryPath, EntryPoint = "Xutf8ResetIC", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* Xutf8ResetIC([NativeTypeName("XIC")] XIC* param0);

        [DllImport(libraryPath, EntryPoint = "XSetICValues", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XSetICValues([NativeTypeName("XIC")] XIC* param0);

        [DllImport(libraryPath, EntryPoint = "XGetICValues", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XGetICValues([NativeTypeName("XIC")] XIC* param0);

        [DllImport(libraryPath, EntryPoint = "XIMOfIC", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XIM")]
        public static extern XIM* XIMOfIC([NativeTypeName("XIC")] XIC* param0);

        [DllImport(libraryPath, EntryPoint = "XFilterEvent", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XFilterEvent([NativeTypeName("XEvent *")] XEvent* param0, [NativeTypeName("Window")] UIntPtr param1);

        [DllImport(libraryPath, EntryPoint = "XmbLookupString", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XmbLookupString([NativeTypeName("XIC")] XIC* param0, [NativeTypeName("XKeyPressedEvent *")] XKeyEvent* param1, [NativeTypeName("char *")] sbyte* param2, int param3, [NativeTypeName("KeySym *")] UIntPtr* param4, [NativeTypeName("int *")] int* param5);

        [DllImport(libraryPath, EntryPoint = "XwcLookupString", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XwcLookupString([NativeTypeName("XIC")] XIC* param0, [NativeTypeName("XKeyPressedEvent *")] XKeyEvent* param1, [NativeTypeName("wchar_t *")] int* param2, int param3, [NativeTypeName("KeySym *")] UIntPtr* param4, [NativeTypeName("int *")] int* param5);

        [DllImport(libraryPath, EntryPoint = "Xutf8LookupString", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Xutf8LookupString([NativeTypeName("XIC")] XIC* param0, [NativeTypeName("XKeyPressedEvent *")] XKeyEvent* param1, [NativeTypeName("char *")] sbyte* param2, int param3, [NativeTypeName("KeySym *")] UIntPtr* param4, [NativeTypeName("int *")] int* param5);

        [DllImport(libraryPath, EntryPoint = "XVaCreateNestedList", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XVaNestedList")]
        public static extern void* XVaCreateNestedList(int param0);

        [DllImport(libraryPath, EntryPoint = "XRegisterIMInstantiateCallback", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XRegisterIMInstantiateCallback([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("struct XrmHashBucketRec *")] XrmHashBucketRec* param1, [NativeTypeName("char *")] sbyte* param2, [NativeTypeName("char *")] sbyte* param3, [NativeTypeName("XIDProc")] IntPtr param4, [NativeTypeName("XPointer")] sbyte* param5);

        [DllImport(libraryPath, EntryPoint = "XUnregisterIMInstantiateCallback", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XUnregisterIMInstantiateCallback([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("struct XrmHashBucketRec *")] XrmHashBucketRec* param1, [NativeTypeName("char *")] sbyte* param2, [NativeTypeName("char *")] sbyte* param3, [NativeTypeName("XIDProc")] IntPtr param4, [NativeTypeName("XPointer")] sbyte* param5);

        [DllImport(libraryPath, EntryPoint = "XInternalConnectionNumbers", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XInternalConnectionNumbers([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("int **")] int** param1, [NativeTypeName("int *")] int* param2);

        [DllImport(libraryPath, EntryPoint = "XProcessInternalConnection", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XProcessInternalConnection([NativeTypeName("Display *")] XDisplay* param0, int param1);

        [DllImport(libraryPath, EntryPoint = "XAddConnectionWatch", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XAddConnectionWatch([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("XConnectionWatchProc")] IntPtr param1, [NativeTypeName("XPointer")] sbyte* param2);

        [DllImport(libraryPath, EntryPoint = "XRemoveConnectionWatch", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XRemoveConnectionWatch([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("XConnectionWatchProc")] IntPtr param1, [NativeTypeName("XPointer")] sbyte* param2);

        [DllImport(libraryPath, EntryPoint = "XSetAuthorization", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XSetAuthorization([NativeTypeName("char *")] sbyte* param0, int param1, [NativeTypeName("char *")] sbyte* param2, int param3);

        [DllImport(libraryPath, EntryPoint = "_Xmbtowc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _Xmbtowc([NativeTypeName("wchar_t *")] int* param0, [NativeTypeName("char *")] sbyte* param1, int param2);

        [DllImport(libraryPath, EntryPoint = "_Xwctomb", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _Xwctomb([NativeTypeName("char *")] sbyte* param0, [NativeTypeName("wchar_t")] int param1);

        [DllImport(libraryPath, EntryPoint = "XGetEventData", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetEventData([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("XGenericEventCookie *")] XGenericEventCookie* param1);

        [DllImport(libraryPath, EntryPoint = "XFreeEventData", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XFreeEventData([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("XGenericEventCookie *")] XGenericEventCookie* param1);
    }
}
