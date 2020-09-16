// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Xlib
    {
        [DllImport("libX11", ExactSpelling = true)]
        public static extern int _Xmblen([NativeTypeName("char *")] sbyte* str, int len);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("XFontStruct *")]
        public static extern XFontStruct* XLoadQueryFont([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("const char *")] sbyte* param1);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("XFontStruct *")]
        public static extern XFontStruct* XQueryFont([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("XID")] nuint param1);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("XTimeCoord *")]
        public static extern XTimeCoord* XGetMotionEvents([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("Time")] nuint param2, [NativeTypeName("Time")] nuint param3, [NativeTypeName("int *")] int* param4);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("XModifierKeymap *")]
        public static extern XModifierKeymap* XDeleteModifiermapEntry([NativeTypeName("XModifierKeymap *")] XModifierKeymap* param0, [NativeTypeName("KeyCode")] byte param1, int param2);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("XModifierKeymap *")]
        public static extern XModifierKeymap* XGetModifierMapping([NativeTypeName("Display *")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("XModifierKeymap *")]
        public static extern XModifierKeymap* XInsertModifiermapEntry([NativeTypeName("XModifierKeymap *")] XModifierKeymap* param0, [NativeTypeName("KeyCode")] byte param1, int param2);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("XModifierKeymap *")]
        public static extern XModifierKeymap* XNewModifiermap(int param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("XImage *")]
        public static extern XImage* XCreateImage([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Visual *")] Visual* param1, [NativeTypeName("unsigned int")] uint param2, int param3, int param4, [NativeTypeName("char *")] sbyte* param5, [NativeTypeName("unsigned int")] uint param6, [NativeTypeName("unsigned int")] uint param7, int param8, int param9);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XInitImage([NativeTypeName("XImage *")] XImage* param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("XImage *")]
        public static extern XImage* XGetImage([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Drawable")] nuint param1, int param2, int param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned long")] nuint param6, int param7);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("XImage *")]
        public static extern XImage* XGetSubImage([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Drawable")] nuint param1, int param2, int param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned long")] nuint param6, int param7, [NativeTypeName("XImage *")] XImage* param8, int param9, int param10);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("Display *")]
        public static extern IntPtr XOpenDisplay([NativeTypeName("const char *")] sbyte* param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern void XrmInitialize();

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XFetchBytes([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("int *")] int* param1);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XFetchBuffer([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("int *")] int* param1, int param2);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XGetAtomName([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Atom")] nuint param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XGetAtomNames([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Atom *")] nuint* param1, int param2, [NativeTypeName("char **")] sbyte** param3);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XGetDefault([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("const char *")] sbyte* param2);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XDisplayName([NativeTypeName("const char *")] sbyte* param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XKeysymToString([NativeTypeName("KeySym")] nuint param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("int (*)(Display *)")]
        public static extern delegate* unmanaged<IntPtr, int> XSynchronize([NativeTypeName("Display *")] IntPtr param0, int param1);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("int (*)(Display *)")]
        public static extern delegate* unmanaged<IntPtr, int> XSetAfterFunction([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("int (*)(Display *)")] delegate* unmanaged<IntPtr, int> param1);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("Atom")]
        public static extern nuint XInternAtom([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("const char *")] sbyte* param1, int param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XInternAtoms([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("char **")] sbyte** param1, int param2, int param3, [NativeTypeName("Atom *")] nuint* param4);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("Colormap")]
        public static extern nuint XCopyColormapAndFree([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Colormap")] nuint param1);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("Colormap")]
        public static extern nuint XCreateColormap([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("Visual *")] Visual* param2, int param3);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("Cursor")]
        public static extern nuint XCreatePixmapCursor([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Pixmap")] nuint param1, [NativeTypeName("Pixmap")] nuint param2, [NativeTypeName("XColor *")] XColor* param3, [NativeTypeName("XColor *")] XColor* param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned int")] uint param6);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("Cursor")]
        public static extern nuint XCreateGlyphCursor([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Font")] nuint param1, [NativeTypeName("Font")] nuint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("const XColor *")] XColor* param5, [NativeTypeName("const XColor *")] XColor* param6);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("Cursor")]
        public static extern nuint XCreateFontCursor([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("unsigned int")] uint param1);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("Font")]
        public static extern nuint XLoadFont([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("const char *")] sbyte* param1);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("GC")]
        public static extern IntPtr XCreateGC([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("unsigned long")] nuint param2, [NativeTypeName("XGCValues *")] XGCValues* param3);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("GContext")]
        public static extern nuint XGContextFromGC([NativeTypeName("GC")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern void XFlushGC([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("GC")] IntPtr param1);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("Pixmap")]
        public static extern nuint XCreatePixmap([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int")] uint param4);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("Pixmap")]
        public static extern nuint XCreateBitmapFromData([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int")] uint param4);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("Pixmap")]
        public static extern nuint XCreatePixmapFromBitmapData([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("char *")] sbyte* param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned long")] nuint param5, [NativeTypeName("unsigned long")] nuint param6, [NativeTypeName("unsigned int")] uint param7);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("Window")]
        public static extern nuint XCreateSimpleWindow([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, int param2, int param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned int")] uint param6, [NativeTypeName("unsigned long")] nuint param7, [NativeTypeName("unsigned long")] nuint param8);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("Window")]
        public static extern nuint XGetSelectionOwner([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Atom")] nuint param1);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("Window")]
        public static extern nuint XCreateWindow([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, int param2, int param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned int")] uint param6, int param7, [NativeTypeName("unsigned int")] uint param8, [NativeTypeName("Visual *")] Visual* param9, [NativeTypeName("unsigned long")] nuint param10, [NativeTypeName("XSetWindowAttributes *")] XSetWindowAttributes* param11);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("Colormap *")]
        public static extern nuint* XListInstalledColormaps([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("int *")] int* param2);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("char **")]
        public static extern sbyte** XListFonts([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("const char *")] sbyte* param1, int param2, [NativeTypeName("int *")] int* param3);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("char **")]
        public static extern sbyte** XListFontsWithInfo([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("const char *")] sbyte* param1, int param2, [NativeTypeName("int *")] int* param3, [NativeTypeName("XFontStruct **")] XFontStruct** param4);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("char **")]
        public static extern sbyte** XGetFontPath([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("int *")] int* param1);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("char **")]
        public static extern sbyte** XListExtensions([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("int *")] int* param1);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("Atom *")]
        public static extern nuint* XListProperties([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("int *")] int* param2);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("XHostAddress *")]
        public static extern XHostAddress* XListHosts([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("int *")] int* param1, [NativeTypeName("int *")] int* param2);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("KeySym")]
        public static extern nuint XKeycodeToKeysym([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("KeyCode")] byte param1, int param2);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("KeySym")]
        public static extern nuint XLookupKeysym([NativeTypeName("XKeyEvent *")] XKeyEvent* param0, int param1);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("KeySym *")]
        public static extern nuint* XGetKeyboardMapping([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("KeyCode")] byte param1, int param2, [NativeTypeName("int *")] int* param3);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("KeySym")]
        public static extern nuint XStringToKeysym([NativeTypeName("const char *")] sbyte* param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern nint XMaxRequestSize([NativeTypeName("Display *")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern nint XExtendedMaxRequestSize([NativeTypeName("Display *")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XResourceManagerString([NativeTypeName("Display *")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XScreenResourceString([NativeTypeName("Screen *")] Screen* param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("unsigned long")]
        public static extern nuint XDisplayMotionBufferSize([NativeTypeName("Display *")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("VisualID")]
        public static extern nuint XVisualIDFromVisual([NativeTypeName("Visual *")] Visual* param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XInitThreads();

        [DllImport("libX11", ExactSpelling = true)]
        public static extern void XLockDisplay([NativeTypeName("Display *")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern void XUnlockDisplay([NativeTypeName("Display *")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("XExtCodes *")]
        public static extern XExtCodes* XInitExtension([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("const char *")] sbyte* param1);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("XExtCodes *")]
        public static extern XExtCodes* XAddExtension([NativeTypeName("Display *")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("XExtData *")]
        public static extern XExtData* XFindOnExtensionList([NativeTypeName("XExtData **")] XExtData** param0, int param1);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("XExtData **")]
        public static extern XExtData** XEHeadOfExtensionList(XEDataObject param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("Window")]
        public static extern nuint XRootWindow([NativeTypeName("Display *")] IntPtr param0, int param1);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("Window")]
        public static extern nuint XDefaultRootWindow([NativeTypeName("Display *")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("Window")]
        public static extern nuint XRootWindowOfScreen([NativeTypeName("Screen *")] Screen* param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("Visual *")]
        public static extern Visual* XDefaultVisual([NativeTypeName("Display *")] IntPtr param0, int param1);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("Visual *")]
        public static extern Visual* XDefaultVisualOfScreen([NativeTypeName("Screen *")] Screen* param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("GC")]
        public static extern IntPtr XDefaultGC([NativeTypeName("Display *")] IntPtr param0, int param1);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("GC")]
        public static extern IntPtr XDefaultGCOfScreen([NativeTypeName("Screen *")] Screen* param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("unsigned long")]
        public static extern nuint XBlackPixel([NativeTypeName("Display *")] IntPtr param0, int param1);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("unsigned long")]
        public static extern nuint XWhitePixel([NativeTypeName("Display *")] IntPtr param0, int param1);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("unsigned long")]
        public static extern nuint XAllPlanes();

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("unsigned long")]
        public static extern nuint XBlackPixelOfScreen([NativeTypeName("Screen *")] Screen* param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("unsigned long")]
        public static extern nuint XWhitePixelOfScreen([NativeTypeName("Screen *")] Screen* param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("unsigned long")]
        public static extern nuint XNextRequest([NativeTypeName("Display *")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("unsigned long")]
        public static extern nuint XLastKnownRequestProcessed([NativeTypeName("Display *")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XServerVendor([NativeTypeName("Display *")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XDisplayString([NativeTypeName("Display *")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("Colormap")]
        public static extern nuint XDefaultColormap([NativeTypeName("Display *")] IntPtr param0, int param1);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("Colormap")]
        public static extern nuint XDefaultColormapOfScreen([NativeTypeName("Screen *")] Screen* param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("Display *")]
        public static extern IntPtr XDisplayOfScreen([NativeTypeName("Screen *")] Screen* param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("Screen *")]
        public static extern Screen* XScreenOfDisplay([NativeTypeName("Display *")] IntPtr param0, int param1);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("Screen *")]
        public static extern Screen* XDefaultScreenOfDisplay([NativeTypeName("Display *")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern nint XEventMaskOfScreen([NativeTypeName("Screen *")] Screen* param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XScreenNumberOfScreen([NativeTypeName("Screen *")] Screen* param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("XErrorHandler")]
        public static extern delegate* unmanaged<IntPtr, XErrorEvent*, int> XSetErrorHandler([NativeTypeName("XErrorHandler")] delegate* unmanaged<IntPtr, XErrorEvent*, int> param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("XIOErrorHandler")]
        public static extern delegate* unmanaged<IntPtr, int> XSetIOErrorHandler([NativeTypeName("XIOErrorHandler")] delegate* unmanaged<IntPtr, int> param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("XPixmapFormatValues *")]
        public static extern XPixmapFormatValues* XListPixmapFormats([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("int *")] int* param1);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("int *")]
        public static extern int* XListDepths([NativeTypeName("Display *")] IntPtr param0, int param1, [NativeTypeName("int *")] int* param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XReconfigureWMWindow([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, int param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("XWindowChanges *")] XWindowChanges* param4);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XGetWMProtocols([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("Atom **")] nuint** param2, [NativeTypeName("int *")] int* param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSetWMProtocols([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("Atom *")] nuint* param2, int param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XIconifyWindow([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, int param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XWithdrawWindow([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, int param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XGetCommand([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("char ***")] sbyte*** param2, [NativeTypeName("int *")] int* param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XGetWMColormapWindows([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("Window **")] nuint** param2, [NativeTypeName("int *")] int* param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSetWMColormapWindows([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("Window *")] nuint* param2, int param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern void XFreeStringList([NativeTypeName("char **")] sbyte** param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSetTransientForHint([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("Window")] nuint param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XActivateScreenSaver([NativeTypeName("Display *")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XAddHost([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("XHostAddress *")] XHostAddress* param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XAddHosts([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("XHostAddress *")] XHostAddress* param1, int param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XAddToExtensionList([NativeTypeName("struct _XExtData **")] XExtData** param0, [NativeTypeName("XExtData *")] XExtData* param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XAddToSaveSet([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XAllocColor([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Colormap")] nuint param1, [NativeTypeName("XColor *")] XColor* param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XAllocColorCells([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Colormap")] nuint param1, int param2, [NativeTypeName("unsigned long *")] nuint* param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned long *")] nuint* param5, [NativeTypeName("unsigned int")] uint param6);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XAllocColorPlanes([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Colormap")] nuint param1, int param2, [NativeTypeName("unsigned long *")] nuint* param3, int param4, int param5, int param6, int param7, [NativeTypeName("unsigned long *")] nuint* param8, [NativeTypeName("unsigned long *")] nuint* param9, [NativeTypeName("unsigned long *")] nuint* param10);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XAllocNamedColor([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Colormap")] nuint param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("XColor *")] XColor* param3, [NativeTypeName("XColor *")] XColor* param4);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XAllowEvents([NativeTypeName("Display *")] IntPtr param0, int param1, [NativeTypeName("Time")] nuint param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XAutoRepeatOff([NativeTypeName("Display *")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XAutoRepeatOn([NativeTypeName("Display *")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XBell([NativeTypeName("Display *")] IntPtr param0, int param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XBitmapBitOrder([NativeTypeName("Display *")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XBitmapPad([NativeTypeName("Display *")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XBitmapUnit([NativeTypeName("Display *")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XCellsOfScreen([NativeTypeName("Screen *")] Screen* param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XChangeActivePointerGrab([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("Cursor")] nuint param2, [NativeTypeName("Time")] nuint param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XChangeGC([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("GC")] IntPtr param1, [NativeTypeName("unsigned long")] nuint param2, [NativeTypeName("XGCValues *")] XGCValues* param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XChangeKeyboardControl([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("unsigned long")] nuint param1, [NativeTypeName("XKeyboardControl *")] XKeyboardControl* param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XChangeKeyboardMapping([NativeTypeName("Display *")] IntPtr param0, int param1, int param2, [NativeTypeName("KeySym *")] nuint* param3, int param4);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XChangePointerControl([NativeTypeName("Display *")] IntPtr param0, int param1, int param2, int param3, int param4, int param5);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XChangeProperty([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("Atom")] nuint param2, [NativeTypeName("Atom")] nuint param3, int param4, int param5, [NativeTypeName("const unsigned char *")] byte* param6, int param7);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XChangeSaveSet([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, int param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XChangeWindowAttributes([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("unsigned long")] nuint param2, [NativeTypeName("XSetWindowAttributes *")] XSetWindowAttributes* param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XCheckIfEvent([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("XEvent *")] XEvent* param1, [NativeTypeName("int (*)(Display *, XEvent *, XPointer)")] delegate* unmanaged<IntPtr, XEvent*, sbyte*, int> param2, [NativeTypeName("XPointer")] sbyte* param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XCheckMaskEvent([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("long")] nint param1, [NativeTypeName("XEvent *")] XEvent* param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XCheckTypedEvent([NativeTypeName("Display *")] IntPtr param0, int param1, [NativeTypeName("XEvent *")] XEvent* param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XCheckTypedWindowEvent([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, int param2, [NativeTypeName("XEvent *")] XEvent* param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XCheckWindowEvent([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("long")] nint param2, [NativeTypeName("XEvent *")] XEvent* param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XCirculateSubwindows([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, int param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XCirculateSubwindowsDown([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XCirculateSubwindowsUp([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XClearArea([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, int param2, int param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int")] uint param5, int param6);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XClearWindow([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XCloseDisplay([NativeTypeName("Display *")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XConfigureWindow([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("XWindowChanges *")] XWindowChanges* param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XConnectionNumber([NativeTypeName("Display *")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XConvertSelection([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Atom")] nuint param1, [NativeTypeName("Atom")] nuint param2, [NativeTypeName("Atom")] nuint param3, [NativeTypeName("Window")] nuint param4, [NativeTypeName("Time")] nuint param5);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XCopyArea([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("Drawable")] nuint param2, [NativeTypeName("GC")] IntPtr param3, int param4, int param5, [NativeTypeName("unsigned int")] uint param6, [NativeTypeName("unsigned int")] uint param7, int param8, int param9);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XCopyGC([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("GC")] IntPtr param1, [NativeTypeName("unsigned long")] nuint param2, [NativeTypeName("GC")] IntPtr param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XCopyPlane([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("Drawable")] nuint param2, [NativeTypeName("GC")] IntPtr param3, int param4, int param5, [NativeTypeName("unsigned int")] uint param6, [NativeTypeName("unsigned int")] uint param7, int param8, int param9, [NativeTypeName("unsigned long")] nuint param10);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XDefaultDepth([NativeTypeName("Display *")] IntPtr param0, int param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XDefaultDepthOfScreen([NativeTypeName("Screen *")] Screen* param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XDefaultScreen([NativeTypeName("Display *")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XDefineCursor([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("Cursor")] nuint param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XDeleteProperty([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("Atom")] nuint param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XDestroyWindow([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XDestroySubwindows([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XDoesBackingStore([NativeTypeName("Screen *")] Screen* param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XDoesSaveUnders([NativeTypeName("Screen *")] Screen* param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XDisableAccessControl([NativeTypeName("Display *")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XDisplayCells([NativeTypeName("Display *")] IntPtr param0, int param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XDisplayHeight([NativeTypeName("Display *")] IntPtr param0, int param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XDisplayHeightMM([NativeTypeName("Display *")] IntPtr param0, int param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XDisplayKeycodes([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("int *")] int* param1, [NativeTypeName("int *")] int* param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XDisplayPlanes([NativeTypeName("Display *")] IntPtr param0, int param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XDisplayWidth([NativeTypeName("Display *")] IntPtr param0, int param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XDisplayWidthMM([NativeTypeName("Display *")] IntPtr param0, int param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XDrawArc([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("GC")] IntPtr param2, int param3, int param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned int")] uint param6, int param7, int param8);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XDrawArcs([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("GC")] IntPtr param2, [NativeTypeName("XArc *")] XArc* param3, int param4);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XDrawImageString([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("GC")] IntPtr param2, int param3, int param4, [NativeTypeName("const char *")] sbyte* param5, int param6);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XDrawImageString16([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("GC")] IntPtr param2, int param3, int param4, [NativeTypeName("const XChar2b *")] XChar2b* param5, int param6);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XDrawLine([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("GC")] IntPtr param2, int param3, int param4, int param5, int param6);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XDrawLines([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("GC")] IntPtr param2, [NativeTypeName("XPoint *")] XPoint* param3, int param4, int param5);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XDrawPoint([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("GC")] IntPtr param2, int param3, int param4);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XDrawPoints([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("GC")] IntPtr param2, [NativeTypeName("XPoint *")] XPoint* param3, int param4, int param5);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XDrawRectangle([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("GC")] IntPtr param2, int param3, int param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned int")] uint param6);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XDrawRectangles([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("GC")] IntPtr param2, [NativeTypeName("XRectangle *")] XRectangle* param3, int param4);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XDrawSegments([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("GC")] IntPtr param2, [NativeTypeName("XSegment *")] XSegment* param3, int param4);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XDrawString([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("GC")] IntPtr param2, int param3, int param4, [NativeTypeName("const char *")] sbyte* param5, int param6);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XDrawString16([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("GC")] IntPtr param2, int param3, int param4, [NativeTypeName("const XChar2b *")] XChar2b* param5, int param6);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XDrawText([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("GC")] IntPtr param2, int param3, int param4, [NativeTypeName("XTextItem *")] XTextItem* param5, int param6);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XDrawText16([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("GC")] IntPtr param2, int param3, int param4, [NativeTypeName("XTextItem16 *")] XTextItem16* param5, int param6);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XEnableAccessControl([NativeTypeName("Display *")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XEventsQueued([NativeTypeName("Display *")] IntPtr param0, int param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XFetchName([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("char **")] sbyte** param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XFillArc([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("GC")] IntPtr param2, int param3, int param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned int")] uint param6, int param7, int param8);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XFillArcs([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("GC")] IntPtr param2, [NativeTypeName("XArc *")] XArc* param3, int param4);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XFillPolygon([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("GC")] IntPtr param2, [NativeTypeName("XPoint *")] XPoint* param3, int param4, int param5, int param6);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XFillRectangle([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("GC")] IntPtr param2, int param3, int param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned int")] uint param6);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XFillRectangles([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("GC")] IntPtr param2, [NativeTypeName("XRectangle *")] XRectangle* param3, int param4);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XFlush([NativeTypeName("Display *")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XForceScreenSaver([NativeTypeName("Display *")] IntPtr param0, int param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XFree([NativeTypeName("void *")] void* param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XFreeColormap([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Colormap")] nuint param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XFreeColors([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Colormap")] nuint param1, [NativeTypeName("unsigned long *")] nuint* param2, int param3, [NativeTypeName("unsigned long")] nuint param4);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XFreeCursor([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Cursor")] nuint param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XFreeExtensionList([NativeTypeName("char **")] sbyte** param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XFreeFont([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("XFontStruct *")] XFontStruct* param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XFreeFontInfo([NativeTypeName("char **")] sbyte** param0, [NativeTypeName("XFontStruct *")] XFontStruct* param1, int param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XFreeFontNames([NativeTypeName("char **")] sbyte** param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XFreeFontPath([NativeTypeName("char **")] sbyte** param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XFreeGC([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("GC")] IntPtr param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XFreeModifiermap([NativeTypeName("XModifierKeymap *")] XModifierKeymap* param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XFreePixmap([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Pixmap")] nuint param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XGeometry([NativeTypeName("Display *")] IntPtr param0, int param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("const char *")] sbyte* param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned int")] uint param6, int param7, int param8, [NativeTypeName("int *")] int* param9, [NativeTypeName("int *")] int* param10, [NativeTypeName("int *")] int* param11, [NativeTypeName("int *")] int* param12);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XGetErrorDatabaseText([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("const char *")] sbyte* param3, [NativeTypeName("char *")] sbyte* param4, int param5);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XGetErrorText([NativeTypeName("Display *")] IntPtr param0, int param1, [NativeTypeName("char *")] sbyte* param2, int param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XGetFontProperty([NativeTypeName("XFontStruct *")] XFontStruct* param0, [NativeTypeName("Atom")] nuint param1, [NativeTypeName("unsigned long *")] nuint* param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XGetGCValues([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("GC")] IntPtr param1, [NativeTypeName("unsigned long")] nuint param2, [NativeTypeName("XGCValues *")] XGCValues* param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XGetGeometry([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("Window *")] nuint* param2, [NativeTypeName("int *")] int* param3, [NativeTypeName("int *")] int* param4, [NativeTypeName("unsigned int *")] uint* param5, [NativeTypeName("unsigned int *")] uint* param6, [NativeTypeName("unsigned int *")] uint* param7, [NativeTypeName("unsigned int *")] uint* param8);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XGetIconName([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("char **")] sbyte** param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XGetInputFocus([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window *")] nuint* param1, [NativeTypeName("int *")] int* param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XGetKeyboardControl([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("XKeyboardState *")] XKeyboardState* param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XGetPointerControl([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("int *")] int* param1, [NativeTypeName("int *")] int* param2, [NativeTypeName("int *")] int* param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XGetPointerMapping([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("unsigned char *")] byte* param1, int param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XGetScreenSaver([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("int *")] int* param1, [NativeTypeName("int *")] int* param2, [NativeTypeName("int *")] int* param3, [NativeTypeName("int *")] int* param4);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XGetTransientForHint([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("Window *")] nuint* param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XGetWindowProperty([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("Atom")] nuint param2, [NativeTypeName("long")] nint param3, [NativeTypeName("long")] nint param4, int param5, [NativeTypeName("Atom")] nuint param6, [NativeTypeName("Atom *")] nuint* param7, [NativeTypeName("int *")] int* param8, [NativeTypeName("unsigned long *")] nuint* param9, [NativeTypeName("unsigned long *")] nuint* param10, [NativeTypeName("unsigned char **")] byte** param11);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XGetWindowAttributes([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("XWindowAttributes *")] XWindowAttributes* param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XGrabButton([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("Window")] nuint param3, int param4, [NativeTypeName("unsigned int")] uint param5, int param6, int param7, [NativeTypeName("Window")] nuint param8, [NativeTypeName("Cursor")] nuint param9);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XGrabKey([NativeTypeName("Display *")] IntPtr param0, int param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("Window")] nuint param3, int param4, int param5, int param6);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XGrabKeyboard([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, int param2, int param3, int param4, [NativeTypeName("Time")] nuint param5);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XGrabPointer([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, int param2, [NativeTypeName("unsigned int")] uint param3, int param4, int param5, [NativeTypeName("Window")] nuint param6, [NativeTypeName("Cursor")] nuint param7, [NativeTypeName("Time")] nuint param8);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XGrabServer([NativeTypeName("Display *")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XHeightMMOfScreen([NativeTypeName("Screen *")] Screen* param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XHeightOfScreen([NativeTypeName("Screen *")] Screen* param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XIfEvent([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("XEvent *")] XEvent* param1, [NativeTypeName("int (*)(Display *, XEvent *, XPointer)")] delegate* unmanaged<IntPtr, XEvent*, sbyte*, int> param2, [NativeTypeName("XPointer")] sbyte* param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XImageByteOrder([NativeTypeName("Display *")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XInstallColormap([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Colormap")] nuint param1);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("KeyCode")]
        public static extern byte XKeysymToKeycode([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("KeySym")] nuint param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XKillClient([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("XID")] nuint param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XLookupColor([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Colormap")] nuint param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("XColor *")] XColor* param3, [NativeTypeName("XColor *")] XColor* param4);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XLowerWindow([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XMapRaised([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XMapSubwindows([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XMapWindow([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XMaskEvent([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("long")] nint param1, [NativeTypeName("XEvent *")] XEvent* param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XMaxCmapsOfScreen([NativeTypeName("Screen *")] Screen* param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XMinCmapsOfScreen([NativeTypeName("Screen *")] Screen* param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XMoveResizeWindow([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, int param2, int param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int")] uint param5);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XMoveWindow([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, int param2, int param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XNextEvent([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("XEvent *")] XEvent* param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XNoOp([NativeTypeName("Display *")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XParseColor([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Colormap")] nuint param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("XColor *")] XColor* param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XParseGeometry([NativeTypeName("const char *")] sbyte* param0, [NativeTypeName("int *")] int* param1, [NativeTypeName("int *")] int* param2, [NativeTypeName("unsigned int *")] uint* param3, [NativeTypeName("unsigned int *")] uint* param4);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XPeekEvent([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("XEvent *")] XEvent* param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XPeekIfEvent([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("XEvent *")] XEvent* param1, [NativeTypeName("int (*)(Display *, XEvent *, XPointer)")] delegate* unmanaged<IntPtr, XEvent*, sbyte*, int> param2, [NativeTypeName("XPointer")] sbyte* param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XPending([NativeTypeName("Display *")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XPlanesOfScreen([NativeTypeName("Screen *")] Screen* param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XProtocolRevision([NativeTypeName("Display *")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XProtocolVersion([NativeTypeName("Display *")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XPutBackEvent([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("XEvent *")] XEvent* param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XPutImage([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("GC")] IntPtr param2, [NativeTypeName("XImage *")] XImage* param3, int param4, int param5, int param6, int param7, [NativeTypeName("unsigned int")] uint param8, [NativeTypeName("unsigned int")] uint param9);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XQLength([NativeTypeName("Display *")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XQueryBestCursor([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int *")] uint* param4, [NativeTypeName("unsigned int *")] uint* param5);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XQueryBestSize([NativeTypeName("Display *")] IntPtr param0, int param1, [NativeTypeName("Drawable")] nuint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int *")] uint* param5, [NativeTypeName("unsigned int *")] uint* param6);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XQueryBestStipple([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int *")] uint* param4, [NativeTypeName("unsigned int *")] uint* param5);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XQueryBestTile([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int *")] uint* param4, [NativeTypeName("unsigned int *")] uint* param5);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XQueryColor([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Colormap")] nuint param1, [NativeTypeName("XColor *")] XColor* param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XQueryColors([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Colormap")] nuint param1, [NativeTypeName("XColor *")] XColor* param2, int param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XQueryExtension([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("int *")] int* param2, [NativeTypeName("int *")] int* param3, [NativeTypeName("int *")] int* param4);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XQueryKeymap([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("char [32]")] sbyte* param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XQueryPointer([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("Window *")] nuint* param2, [NativeTypeName("Window *")] nuint* param3, [NativeTypeName("int *")] int* param4, [NativeTypeName("int *")] int* param5, [NativeTypeName("int *")] int* param6, [NativeTypeName("int *")] int* param7, [NativeTypeName("unsigned int *")] uint* param8);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XQueryTextExtents([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("XID")] nuint param1, [NativeTypeName("const char *")] sbyte* param2, int param3, [NativeTypeName("int *")] int* param4, [NativeTypeName("int *")] int* param5, [NativeTypeName("int *")] int* param6, [NativeTypeName("XCharStruct *")] XCharStruct* param7);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XQueryTextExtents16([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("XID")] nuint param1, [NativeTypeName("const XChar2b *")] XChar2b* param2, int param3, [NativeTypeName("int *")] int* param4, [NativeTypeName("int *")] int* param5, [NativeTypeName("int *")] int* param6, [NativeTypeName("XCharStruct *")] XCharStruct* param7);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XQueryTree([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("Window *")] nuint* param2, [NativeTypeName("Window *")] nuint* param3, [NativeTypeName("Window **")] nuint** param4, [NativeTypeName("unsigned int *")] uint* param5);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XRaiseWindow([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XReadBitmapFile([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("unsigned int *")] uint* param3, [NativeTypeName("unsigned int *")] uint* param4, [NativeTypeName("Pixmap *")] nuint* param5, [NativeTypeName("int *")] int* param6, [NativeTypeName("int *")] int* param7);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XReadBitmapFileData([NativeTypeName("const char *")] sbyte* param0, [NativeTypeName("unsigned int *")] uint* param1, [NativeTypeName("unsigned int *")] uint* param2, [NativeTypeName("unsigned char **")] byte** param3, [NativeTypeName("int *")] int* param4, [NativeTypeName("int *")] int* param5);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XRebindKeysym([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("KeySym")] nuint param1, [NativeTypeName("KeySym *")] nuint* param2, int param3, [NativeTypeName("const unsigned char *")] byte* param4, int param5);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XRecolorCursor([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Cursor")] nuint param1, [NativeTypeName("XColor *")] XColor* param2, [NativeTypeName("XColor *")] XColor* param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XRefreshKeyboardMapping([NativeTypeName("XMappingEvent *")] XMappingEvent* param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XRemoveFromSaveSet([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XRemoveHost([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("XHostAddress *")] XHostAddress* param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XRemoveHosts([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("XHostAddress *")] XHostAddress* param1, int param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XReparentWindow([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("Window")] nuint param2, int param3, int param4);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XResetScreenSaver([NativeTypeName("Display *")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XResizeWindow([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XRestackWindows([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window *")] nuint* param1, int param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XRotateBuffers([NativeTypeName("Display *")] IntPtr param0, int param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XRotateWindowProperties([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("Atom *")] nuint* param2, int param3, int param4);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XScreenCount([NativeTypeName("Display *")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSelectInput([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("long")] nint param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSendEvent([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, int param2, [NativeTypeName("long")] nint param3, [NativeTypeName("XEvent *")] XEvent* param4);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSetAccessControl([NativeTypeName("Display *")] IntPtr param0, int param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSetArcMode([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("GC")] IntPtr param1, int param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSetBackground([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("GC")] IntPtr param1, [NativeTypeName("unsigned long")] nuint param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSetClipMask([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("GC")] IntPtr param1, [NativeTypeName("Pixmap")] nuint param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSetClipOrigin([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("GC")] IntPtr param1, int param2, int param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSetClipRectangles([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("GC")] IntPtr param1, int param2, int param3, [NativeTypeName("XRectangle *")] XRectangle* param4, int param5, int param6);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSetCloseDownMode([NativeTypeName("Display *")] IntPtr param0, int param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSetCommand([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("char **")] sbyte** param2, int param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSetDashes([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("GC")] IntPtr param1, int param2, [NativeTypeName("const char *")] sbyte* param3, int param4);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSetFillRule([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("GC")] IntPtr param1, int param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSetFillStyle([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("GC")] IntPtr param1, int param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSetFont([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("GC")] IntPtr param1, [NativeTypeName("Font")] nuint param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSetFontPath([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("char **")] sbyte** param1, int param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSetForeground([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("GC")] IntPtr param1, [NativeTypeName("unsigned long")] nuint param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSetFunction([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("GC")] IntPtr param1, int param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSetGraphicsExposures([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("GC")] IntPtr param1, int param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSetIconName([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("const char *")] sbyte* param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSetInputFocus([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, int param2, [NativeTypeName("Time")] nuint param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSetLineAttributes([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("GC")] IntPtr param1, [NativeTypeName("unsigned int")] uint param2, int param3, int param4, int param5);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSetModifierMapping([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("XModifierKeymap *")] XModifierKeymap* param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSetPlaneMask([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("GC")] IntPtr param1, [NativeTypeName("unsigned long")] nuint param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSetPointerMapping([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("const unsigned char *")] byte* param1, int param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSetScreenSaver([NativeTypeName("Display *")] IntPtr param0, int param1, int param2, int param3, int param4);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSetSelectionOwner([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Atom")] nuint param1, [NativeTypeName("Window")] nuint param2, [NativeTypeName("Time")] nuint param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSetState([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("GC")] IntPtr param1, [NativeTypeName("unsigned long")] nuint param2, [NativeTypeName("unsigned long")] nuint param3, int param4, [NativeTypeName("unsigned long")] nuint param5);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSetStipple([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("GC")] IntPtr param1, [NativeTypeName("Pixmap")] nuint param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSetSubwindowMode([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("GC")] IntPtr param1, int param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSetTSOrigin([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("GC")] IntPtr param1, int param2, int param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSetTile([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("GC")] IntPtr param1, [NativeTypeName("Pixmap")] nuint param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSetWindowBackground([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("unsigned long")] nuint param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSetWindowBackgroundPixmap([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("Pixmap")] nuint param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSetWindowBorder([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("unsigned long")] nuint param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSetWindowBorderPixmap([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("Pixmap")] nuint param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSetWindowBorderWidth([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("unsigned int")] uint param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSetWindowColormap([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("Colormap")] nuint param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XStoreBuffer([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("const char *")] sbyte* param1, int param2, int param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XStoreBytes([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("const char *")] sbyte* param1, int param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XStoreColor([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Colormap")] nuint param1, [NativeTypeName("XColor *")] XColor* param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XStoreColors([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Colormap")] nuint param1, [NativeTypeName("XColor *")] XColor* param2, int param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XStoreName([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("const char *")] sbyte* param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XStoreNamedColor([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Colormap")] nuint param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("unsigned long")] nuint param3, int param4);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSync([NativeTypeName("Display *")] IntPtr param0, int param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XTextExtents([NativeTypeName("XFontStruct *")] XFontStruct* param0, [NativeTypeName("const char *")] sbyte* param1, int param2, [NativeTypeName("int *")] int* param3, [NativeTypeName("int *")] int* param4, [NativeTypeName("int *")] int* param5, [NativeTypeName("XCharStruct *")] XCharStruct* param6);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XTextExtents16([NativeTypeName("XFontStruct *")] XFontStruct* param0, [NativeTypeName("const XChar2b *")] XChar2b* param1, int param2, [NativeTypeName("int *")] int* param3, [NativeTypeName("int *")] int* param4, [NativeTypeName("int *")] int* param5, [NativeTypeName("XCharStruct *")] XCharStruct* param6);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XTextWidth([NativeTypeName("XFontStruct *")] XFontStruct* param0, [NativeTypeName("const char *")] sbyte* param1, int param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XTextWidth16([NativeTypeName("XFontStruct *")] XFontStruct* param0, [NativeTypeName("const XChar2b *")] XChar2b* param1, int param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XTranslateCoordinates([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("Window")] nuint param2, int param3, int param4, [NativeTypeName("int *")] int* param5, [NativeTypeName("int *")] int* param6, [NativeTypeName("Window *")] nuint* param7);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XUndefineCursor([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XUngrabButton([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("Window")] nuint param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XUngrabKey([NativeTypeName("Display *")] IntPtr param0, int param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("Window")] nuint param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XUngrabKeyboard([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Time")] nuint param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XUngrabPointer([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Time")] nuint param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XUngrabServer([NativeTypeName("Display *")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XUninstallColormap([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Colormap")] nuint param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XUnloadFont([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Font")] nuint param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XUnmapSubwindows([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XUnmapWindow([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XVendorRelease([NativeTypeName("Display *")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XWarpPointer([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("Window")] nuint param2, int param3, int param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned int")] uint param6, int param7, int param8);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XWidthMMOfScreen([NativeTypeName("Screen *")] Screen* param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XWidthOfScreen([NativeTypeName("Screen *")] Screen* param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XWindowEvent([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("long")] nint param2, [NativeTypeName("XEvent *")] XEvent* param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XWriteBitmapFile([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("Pixmap")] nuint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int")] uint param4, int param5, int param6);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSupportsLocale();

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XSetLocaleModifiers([NativeTypeName("const char *")] sbyte* param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("XOM")]
        public static extern IntPtr XOpenOM([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("struct _XrmHashBucketRec *")] IntPtr param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("const char *")] sbyte* param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XCloseOM([NativeTypeName("XOM")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XSetOMValues([NativeTypeName("XOM")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XGetOMValues([NativeTypeName("XOM")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("Display *")]
        public static extern IntPtr XDisplayOfOM([NativeTypeName("XOM")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XLocaleOfOM([NativeTypeName("XOM")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("XOC")]
        public static extern IntPtr XCreateOC([NativeTypeName("XOM")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern void XDestroyOC([NativeTypeName("XOC")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("XOM")]
        public static extern IntPtr XOMOfOC([NativeTypeName("XOC")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XSetOCValues([NativeTypeName("XOC")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XGetOCValues([NativeTypeName("XOC")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("XFontSet")]
        public static extern IntPtr XCreateFontSet([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("char ***")] sbyte*** param2, [NativeTypeName("int *")] int* param3, [NativeTypeName("char **")] sbyte** param4);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern void XFreeFontSet([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("XFontSet")] IntPtr param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XFontsOfFontSet([NativeTypeName("XFontSet")] IntPtr param0, [NativeTypeName("XFontStruct ***")] XFontStruct*** param1, [NativeTypeName("char ***")] sbyte*** param2);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XBaseFontNameListOfFontSet([NativeTypeName("XFontSet")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XLocaleOfFontSet([NativeTypeName("XFontSet")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XContextDependentDrawing([NativeTypeName("XFontSet")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XDirectionalDependentDrawing([NativeTypeName("XFontSet")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XContextualDrawing([NativeTypeName("XFontSet")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("XFontSetExtents *")]
        public static extern XFontSetExtents* XExtentsOfFontSet([NativeTypeName("XFontSet")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XmbTextEscapement([NativeTypeName("XFontSet")] IntPtr param0, [NativeTypeName("const char *")] sbyte* param1, int param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XwcTextEscapement([NativeTypeName("XFontSet")] IntPtr param0, [NativeTypeName("const wchar_t *")] int* param1, int param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int Xutf8TextEscapement([NativeTypeName("XFontSet")] IntPtr param0, [NativeTypeName("const char *")] sbyte* param1, int param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XmbTextExtents([NativeTypeName("XFontSet")] IntPtr param0, [NativeTypeName("const char *")] sbyte* param1, int param2, [NativeTypeName("XRectangle *")] XRectangle* param3, [NativeTypeName("XRectangle *")] XRectangle* param4);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XwcTextExtents([NativeTypeName("XFontSet")] IntPtr param0, [NativeTypeName("const wchar_t *")] int* param1, int param2, [NativeTypeName("XRectangle *")] XRectangle* param3, [NativeTypeName("XRectangle *")] XRectangle* param4);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int Xutf8TextExtents([NativeTypeName("XFontSet")] IntPtr param0, [NativeTypeName("const char *")] sbyte* param1, int param2, [NativeTypeName("XRectangle *")] XRectangle* param3, [NativeTypeName("XRectangle *")] XRectangle* param4);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XmbTextPerCharExtents([NativeTypeName("XFontSet")] IntPtr param0, [NativeTypeName("const char *")] sbyte* param1, int param2, [NativeTypeName("XRectangle *")] XRectangle* param3, [NativeTypeName("XRectangle *")] XRectangle* param4, int param5, [NativeTypeName("int *")] int* param6, [NativeTypeName("XRectangle *")] XRectangle* param7, [NativeTypeName("XRectangle *")] XRectangle* param8);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XwcTextPerCharExtents([NativeTypeName("XFontSet")] IntPtr param0, [NativeTypeName("const wchar_t *")] int* param1, int param2, [NativeTypeName("XRectangle *")] XRectangle* param3, [NativeTypeName("XRectangle *")] XRectangle* param4, int param5, [NativeTypeName("int *")] int* param6, [NativeTypeName("XRectangle *")] XRectangle* param7, [NativeTypeName("XRectangle *")] XRectangle* param8);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int Xutf8TextPerCharExtents([NativeTypeName("XFontSet")] IntPtr param0, [NativeTypeName("const char *")] sbyte* param1, int param2, [NativeTypeName("XRectangle *")] XRectangle* param3, [NativeTypeName("XRectangle *")] XRectangle* param4, int param5, [NativeTypeName("int *")] int* param6, [NativeTypeName("XRectangle *")] XRectangle* param7, [NativeTypeName("XRectangle *")] XRectangle* param8);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern void XmbDrawText([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("GC")] IntPtr param2, int param3, int param4, [NativeTypeName("XmbTextItem *")] XmbTextItem* param5, int param6);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern void XwcDrawText([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("GC")] IntPtr param2, int param3, int param4, [NativeTypeName("XwcTextItem *")] XwcTextItem* param5, int param6);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern void Xutf8DrawText([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("GC")] IntPtr param2, int param3, int param4, [NativeTypeName("XmbTextItem *")] XmbTextItem* param5, int param6);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern void XmbDrawString([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("XFontSet")] IntPtr param2, [NativeTypeName("GC")] IntPtr param3, int param4, int param5, [NativeTypeName("const char *")] sbyte* param6, int param7);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern void XwcDrawString([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("XFontSet")] IntPtr param2, [NativeTypeName("GC")] IntPtr param3, int param4, int param5, [NativeTypeName("const wchar_t *")] int* param6, int param7);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern void Xutf8DrawString([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("XFontSet")] IntPtr param2, [NativeTypeName("GC")] IntPtr param3, int param4, int param5, [NativeTypeName("const char *")] sbyte* param6, int param7);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern void XmbDrawImageString([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("XFontSet")] IntPtr param2, [NativeTypeName("GC")] IntPtr param3, int param4, int param5, [NativeTypeName("const char *")] sbyte* param6, int param7);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern void XwcDrawImageString([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("XFontSet")] IntPtr param2, [NativeTypeName("GC")] IntPtr param3, int param4, int param5, [NativeTypeName("const wchar_t *")] int* param6, int param7);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern void Xutf8DrawImageString([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("XFontSet")] IntPtr param2, [NativeTypeName("GC")] IntPtr param3, int param4, int param5, [NativeTypeName("const char *")] sbyte* param6, int param7);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("XIM")]
        public static extern IntPtr XOpenIM([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("struct _XrmHashBucketRec *")] IntPtr param1, [NativeTypeName("char *")] sbyte* param2, [NativeTypeName("char *")] sbyte* param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XCloseIM([NativeTypeName("XIM")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XGetIMValues([NativeTypeName("XIM")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XSetIMValues([NativeTypeName("XIM")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("Display *")]
        public static extern IntPtr XDisplayOfIM([NativeTypeName("XIM")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XLocaleOfIM([NativeTypeName("XIM")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("XIC")]
        public static extern IntPtr XCreateIC([NativeTypeName("XIM")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern void XDestroyIC([NativeTypeName("XIC")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern void XSetICFocus([NativeTypeName("XIC")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern void XUnsetICFocus([NativeTypeName("XIC")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("wchar_t *")]
        public static extern int* XwcResetIC([NativeTypeName("XIC")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XmbResetIC([NativeTypeName("XIC")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* Xutf8ResetIC([NativeTypeName("XIC")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XSetICValues([NativeTypeName("XIC")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XGetICValues([NativeTypeName("XIC")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("XIM")]
        public static extern IntPtr XIMOfIC([NativeTypeName("XIC")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XFilterEvent([NativeTypeName("XEvent *")] XEvent* param0, [NativeTypeName("Window")] nuint param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XmbLookupString([NativeTypeName("XIC")] IntPtr param0, [NativeTypeName("XKeyPressedEvent *")] XKeyEvent* param1, [NativeTypeName("char *")] sbyte* param2, int param3, [NativeTypeName("KeySym *")] nuint* param4, [NativeTypeName("int *")] int* param5);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XwcLookupString([NativeTypeName("XIC")] IntPtr param0, [NativeTypeName("XKeyPressedEvent *")] XKeyEvent* param1, [NativeTypeName("wchar_t *")] int* param2, int param3, [NativeTypeName("KeySym *")] nuint* param4, [NativeTypeName("int *")] int* param5);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int Xutf8LookupString([NativeTypeName("XIC")] IntPtr param0, [NativeTypeName("XKeyPressedEvent *")] XKeyEvent* param1, [NativeTypeName("char *")] sbyte* param2, int param3, [NativeTypeName("KeySym *")] nuint* param4, [NativeTypeName("int *")] int* param5);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("XVaNestedList")]
        public static extern void* XVaCreateNestedList(int param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XRegisterIMInstantiateCallback([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("struct _XrmHashBucketRec *")] IntPtr param1, [NativeTypeName("char *")] sbyte* param2, [NativeTypeName("char *")] sbyte* param3, [NativeTypeName("XIDProc")] delegate* unmanaged<IntPtr, sbyte*, sbyte*, void> param4, [NativeTypeName("XPointer")] sbyte* param5);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XUnregisterIMInstantiateCallback([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("struct _XrmHashBucketRec *")] IntPtr param1, [NativeTypeName("char *")] sbyte* param2, [NativeTypeName("char *")] sbyte* param3, [NativeTypeName("XIDProc")] delegate* unmanaged<IntPtr, sbyte*, sbyte*, void> param4, [NativeTypeName("XPointer")] sbyte* param5);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XInternalConnectionNumbers([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("int **")] int** param1, [NativeTypeName("int *")] int* param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern void XProcessInternalConnection([NativeTypeName("Display *")] IntPtr param0, int param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XAddConnectionWatch([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("XConnectionWatchProc")] delegate* unmanaged<IntPtr, sbyte*, int, int, sbyte**, void> param1, [NativeTypeName("XPointer")] sbyte* param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern void XRemoveConnectionWatch([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("XConnectionWatchProc")] delegate* unmanaged<IntPtr, sbyte*, int, int, sbyte**, void> param1, [NativeTypeName("XPointer")] sbyte* param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern void XSetAuthorization([NativeTypeName("char *")] sbyte* param0, int param1, [NativeTypeName("char *")] sbyte* param2, int param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int _Xmbtowc([NativeTypeName("wchar_t *")] int* param0, [NativeTypeName("char *")] sbyte* param1, int param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int _Xwctomb([NativeTypeName("char *")] sbyte* param0, [NativeTypeName("wchar_t")] int param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XGetEventData([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("XGenericEventCookie *")] XGenericEventCookie* param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern void XFreeEventData([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("XGenericEventCookie *")] XGenericEventCookie* param1);

        [NativeTypeName("#define XlibSpecificationRelease 6")]
        public const int XlibSpecificationRelease = 6;

        [NativeTypeName("#define X_HAVE_UTF8_STRING 1")]
        public const int X_HAVE_UTF8_STRING = 1;

        [NativeTypeName("#define True 1")]
        public const int True = 1;

        [NativeTypeName("#define False 0")]
        public const int False = 0;

        [NativeTypeName("#define QueuedAlready 0")]
        public const int QueuedAlready = 0;

        [NativeTypeName("#define QueuedAfterReading 1")]
        public const int QueuedAfterReading = 1;

        [NativeTypeName("#define QueuedAfterFlush 2")]
        public const int QueuedAfterFlush = 2;

        [NativeTypeName("#define AllPlanes ((unsigned long)~0L)")]
        public static readonly nuint AllPlanes = unchecked((nuint)(~0));

        [NativeTypeName("#define XNRequiredCharSet \"requiredCharSet\"")]
        public static ReadOnlySpan<byte> XNRequiredCharSet => new byte[] { 0x72, 0x65, 0x71, 0x75, 0x69, 0x72, 0x65, 0x64, 0x43, 0x68, 0x61, 0x72, 0x53, 0x65, 0x74, 0x00 };

        [NativeTypeName("#define XNQueryOrientation \"queryOrientation\"")]
        public static ReadOnlySpan<byte> XNQueryOrientation => new byte[] { 0x71, 0x75, 0x65, 0x72, 0x79, 0x4F, 0x72, 0x69, 0x65, 0x6E, 0x74, 0x61, 0x74, 0x69, 0x6F, 0x6E, 0x00 };

        [NativeTypeName("#define XNBaseFontName \"baseFontName\"")]
        public static ReadOnlySpan<byte> XNBaseFontName => new byte[] { 0x62, 0x61, 0x73, 0x65, 0x46, 0x6F, 0x6E, 0x74, 0x4E, 0x61, 0x6D, 0x65, 0x00 };

        [NativeTypeName("#define XNOMAutomatic \"omAutomatic\"")]
        public static ReadOnlySpan<byte> XNOMAutomatic => new byte[] { 0x6F, 0x6D, 0x41, 0x75, 0x74, 0x6F, 0x6D, 0x61, 0x74, 0x69, 0x63, 0x00 };

        [NativeTypeName("#define XNMissingCharSet \"missingCharSet\"")]
        public static ReadOnlySpan<byte> XNMissingCharSet => new byte[] { 0x6D, 0x69, 0x73, 0x73, 0x69, 0x6E, 0x67, 0x43, 0x68, 0x61, 0x72, 0x53, 0x65, 0x74, 0x00 };

        [NativeTypeName("#define XNDefaultString \"defaultString\"")]
        public static ReadOnlySpan<byte> XNDefaultString => new byte[] { 0x64, 0x65, 0x66, 0x61, 0x75, 0x6C, 0x74, 0x53, 0x74, 0x72, 0x69, 0x6E, 0x67, 0x00 };

        [NativeTypeName("#define XNOrientation \"orientation\"")]
        public static ReadOnlySpan<byte> XNOrientation => new byte[] { 0x6F, 0x72, 0x69, 0x65, 0x6E, 0x74, 0x61, 0x74, 0x69, 0x6F, 0x6E, 0x00 };

        [NativeTypeName("#define XNDirectionalDependentDrawing \"directionalDependentDrawing\"")]
        public static ReadOnlySpan<byte> XNDirectionalDependentDrawing => new byte[] { 0x64, 0x69, 0x72, 0x65, 0x63, 0x74, 0x69, 0x6F, 0x6E, 0x61, 0x6C, 0x44, 0x65, 0x70, 0x65, 0x6E, 0x64, 0x65, 0x6E, 0x74, 0x44, 0x72, 0x61, 0x77, 0x69, 0x6E, 0x67, 0x00 };

        [NativeTypeName("#define XNContextualDrawing \"contextualDrawing\"")]
        public static ReadOnlySpan<byte> XNContextualDrawing => new byte[] { 0x63, 0x6F, 0x6E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x61, 0x6C, 0x44, 0x72, 0x61, 0x77, 0x69, 0x6E, 0x67, 0x00 };

        [NativeTypeName("#define XNFontInfo \"fontInfo\"")]
        public static ReadOnlySpan<byte> XNFontInfo => new byte[] { 0x66, 0x6F, 0x6E, 0x74, 0x49, 0x6E, 0x66, 0x6F, 0x00 };

        [NativeTypeName("#define XIMPreeditArea 0x0001L")]
        public const nint XIMPreeditArea = 0x0001;

        [NativeTypeName("#define XIMPreeditCallbacks 0x0002L")]
        public const nint XIMPreeditCallbacks = 0x0002;

        [NativeTypeName("#define XIMPreeditPosition 0x0004L")]
        public const nint XIMPreeditPosition = 0x0004;

        [NativeTypeName("#define XIMPreeditNothing 0x0008L")]
        public const nint XIMPreeditNothing = 0x0008;

        [NativeTypeName("#define XIMPreeditNone 0x0010L")]
        public const nint XIMPreeditNone = 0x0010;

        [NativeTypeName("#define XIMStatusArea 0x0100L")]
        public const nint XIMStatusArea = 0x0100;

        [NativeTypeName("#define XIMStatusCallbacks 0x0200L")]
        public const nint XIMStatusCallbacks = 0x0200;

        [NativeTypeName("#define XIMStatusNothing 0x0400L")]
        public const nint XIMStatusNothing = 0x0400;

        [NativeTypeName("#define XIMStatusNone 0x0800L")]
        public const nint XIMStatusNone = 0x0800;

        [NativeTypeName("#define XNVaNestedList \"XNVaNestedList\"")]
        public static ReadOnlySpan<byte> XNVaNestedList => new byte[] { 0x58, 0x4E, 0x56, 0x61, 0x4E, 0x65, 0x73, 0x74, 0x65, 0x64, 0x4C, 0x69, 0x73, 0x74, 0x00 };

        [NativeTypeName("#define XNQueryInputStyle \"queryInputStyle\"")]
        public static ReadOnlySpan<byte> XNQueryInputStyle => new byte[] { 0x71, 0x75, 0x65, 0x72, 0x79, 0x49, 0x6E, 0x70, 0x75, 0x74, 0x53, 0x74, 0x79, 0x6C, 0x65, 0x00 };

        [NativeTypeName("#define XNClientWindow \"clientWindow\"")]
        public static ReadOnlySpan<byte> XNClientWindow => new byte[] { 0x63, 0x6C, 0x69, 0x65, 0x6E, 0x74, 0x57, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x00 };

        [NativeTypeName("#define XNInputStyle \"inputStyle\"")]
        public static ReadOnlySpan<byte> XNInputStyle => new byte[] { 0x69, 0x6E, 0x70, 0x75, 0x74, 0x53, 0x74, 0x79, 0x6C, 0x65, 0x00 };

        [NativeTypeName("#define XNFocusWindow \"focusWindow\"")]
        public static ReadOnlySpan<byte> XNFocusWindow => new byte[] { 0x66, 0x6F, 0x63, 0x75, 0x73, 0x57, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x00 };

        [NativeTypeName("#define XNResourceName \"resourceName\"")]
        public static ReadOnlySpan<byte> XNResourceName => new byte[] { 0x72, 0x65, 0x73, 0x6F, 0x75, 0x72, 0x63, 0x65, 0x4E, 0x61, 0x6D, 0x65, 0x00 };

        [NativeTypeName("#define XNResourceClass \"resourceClass\"")]
        public static ReadOnlySpan<byte> XNResourceClass => new byte[] { 0x72, 0x65, 0x73, 0x6F, 0x75, 0x72, 0x63, 0x65, 0x43, 0x6C, 0x61, 0x73, 0x73, 0x00 };

        [NativeTypeName("#define XNGeometryCallback \"geometryCallback\"")]
        public static ReadOnlySpan<byte> XNGeometryCallback => new byte[] { 0x67, 0x65, 0x6F, 0x6D, 0x65, 0x74, 0x72, 0x79, 0x43, 0x61, 0x6C, 0x6C, 0x62, 0x61, 0x63, 0x6B, 0x00 };

        [NativeTypeName("#define XNDestroyCallback \"destroyCallback\"")]
        public static ReadOnlySpan<byte> XNDestroyCallback => new byte[] { 0x64, 0x65, 0x73, 0x74, 0x72, 0x6F, 0x79, 0x43, 0x61, 0x6C, 0x6C, 0x62, 0x61, 0x63, 0x6B, 0x00 };

        [NativeTypeName("#define XNFilterEvents \"filterEvents\"")]
        public static ReadOnlySpan<byte> XNFilterEvents => new byte[] { 0x66, 0x69, 0x6C, 0x74, 0x65, 0x72, 0x45, 0x76, 0x65, 0x6E, 0x74, 0x73, 0x00 };

        [NativeTypeName("#define XNPreeditStartCallback \"preeditStartCallback\"")]
        public static ReadOnlySpan<byte> XNPreeditStartCallback => new byte[] { 0x70, 0x72, 0x65, 0x65, 0x64, 0x69, 0x74, 0x53, 0x74, 0x61, 0x72, 0x74, 0x43, 0x61, 0x6C, 0x6C, 0x62, 0x61, 0x63, 0x6B, 0x00 };

        [NativeTypeName("#define XNPreeditDoneCallback \"preeditDoneCallback\"")]
        public static ReadOnlySpan<byte> XNPreeditDoneCallback => new byte[] { 0x70, 0x72, 0x65, 0x65, 0x64, 0x69, 0x74, 0x44, 0x6F, 0x6E, 0x65, 0x43, 0x61, 0x6C, 0x6C, 0x62, 0x61, 0x63, 0x6B, 0x00 };

        [NativeTypeName("#define XNPreeditDrawCallback \"preeditDrawCallback\"")]
        public static ReadOnlySpan<byte> XNPreeditDrawCallback => new byte[] { 0x70, 0x72, 0x65, 0x65, 0x64, 0x69, 0x74, 0x44, 0x72, 0x61, 0x77, 0x43, 0x61, 0x6C, 0x6C, 0x62, 0x61, 0x63, 0x6B, 0x00 };

        [NativeTypeName("#define XNPreeditCaretCallback \"preeditCaretCallback\"")]
        public static ReadOnlySpan<byte> XNPreeditCaretCallback => new byte[] { 0x70, 0x72, 0x65, 0x65, 0x64, 0x69, 0x74, 0x43, 0x61, 0x72, 0x65, 0x74, 0x43, 0x61, 0x6C, 0x6C, 0x62, 0x61, 0x63, 0x6B, 0x00 };

        [NativeTypeName("#define XNPreeditStateNotifyCallback \"preeditStateNotifyCallback\"")]
        public static ReadOnlySpan<byte> XNPreeditStateNotifyCallback => new byte[] { 0x70, 0x72, 0x65, 0x65, 0x64, 0x69, 0x74, 0x53, 0x74, 0x61, 0x74, 0x65, 0x4E, 0x6F, 0x74, 0x69, 0x66, 0x79, 0x43, 0x61, 0x6C, 0x6C, 0x62, 0x61, 0x63, 0x6B, 0x00 };

        [NativeTypeName("#define XNPreeditAttributes \"preeditAttributes\"")]
        public static ReadOnlySpan<byte> XNPreeditAttributes => new byte[] { 0x70, 0x72, 0x65, 0x65, 0x64, 0x69, 0x74, 0x41, 0x74, 0x74, 0x72, 0x69, 0x62, 0x75, 0x74, 0x65, 0x73, 0x00 };

        [NativeTypeName("#define XNStatusStartCallback \"statusStartCallback\"")]
        public static ReadOnlySpan<byte> XNStatusStartCallback => new byte[] { 0x73, 0x74, 0x61, 0x74, 0x75, 0x73, 0x53, 0x74, 0x61, 0x72, 0x74, 0x43, 0x61, 0x6C, 0x6C, 0x62, 0x61, 0x63, 0x6B, 0x00 };

        [NativeTypeName("#define XNStatusDoneCallback \"statusDoneCallback\"")]
        public static ReadOnlySpan<byte> XNStatusDoneCallback => new byte[] { 0x73, 0x74, 0x61, 0x74, 0x75, 0x73, 0x44, 0x6F, 0x6E, 0x65, 0x43, 0x61, 0x6C, 0x6C, 0x62, 0x61, 0x63, 0x6B, 0x00 };

        [NativeTypeName("#define XNStatusDrawCallback \"statusDrawCallback\"")]
        public static ReadOnlySpan<byte> XNStatusDrawCallback => new byte[] { 0x73, 0x74, 0x61, 0x74, 0x75, 0x73, 0x44, 0x72, 0x61, 0x77, 0x43, 0x61, 0x6C, 0x6C, 0x62, 0x61, 0x63, 0x6B, 0x00 };

        [NativeTypeName("#define XNStatusAttributes \"statusAttributes\"")]
        public static ReadOnlySpan<byte> XNStatusAttributes => new byte[] { 0x73, 0x74, 0x61, 0x74, 0x75, 0x73, 0x41, 0x74, 0x74, 0x72, 0x69, 0x62, 0x75, 0x74, 0x65, 0x73, 0x00 };

        [NativeTypeName("#define XNArea \"area\"")]
        public static ReadOnlySpan<byte> XNArea => new byte[] { 0x61, 0x72, 0x65, 0x61, 0x00 };

        [NativeTypeName("#define XNAreaNeeded \"areaNeeded\"")]
        public static ReadOnlySpan<byte> XNAreaNeeded => new byte[] { 0x61, 0x72, 0x65, 0x61, 0x4E, 0x65, 0x65, 0x64, 0x65, 0x64, 0x00 };

        [NativeTypeName("#define XNSpotLocation \"spotLocation\"")]
        public static ReadOnlySpan<byte> XNSpotLocation => new byte[] { 0x73, 0x70, 0x6F, 0x74, 0x4C, 0x6F, 0x63, 0x61, 0x74, 0x69, 0x6F, 0x6E, 0x00 };

        [NativeTypeName("#define XNColormap \"colorMap\"")]
        public static ReadOnlySpan<byte> XNColormap => new byte[] { 0x63, 0x6F, 0x6C, 0x6F, 0x72, 0x4D, 0x61, 0x70, 0x00 };

        [NativeTypeName("#define XNStdColormap \"stdColorMap\"")]
        public static ReadOnlySpan<byte> XNStdColormap => new byte[] { 0x73, 0x74, 0x64, 0x43, 0x6F, 0x6C, 0x6F, 0x72, 0x4D, 0x61, 0x70, 0x00 };

        [NativeTypeName("#define XNForeground \"foreground\"")]
        public static ReadOnlySpan<byte> XNForeground => new byte[] { 0x66, 0x6F, 0x72, 0x65, 0x67, 0x72, 0x6F, 0x75, 0x6E, 0x64, 0x00 };

        [NativeTypeName("#define XNBackground \"background\"")]
        public static ReadOnlySpan<byte> XNBackground => new byte[] { 0x62, 0x61, 0x63, 0x6B, 0x67, 0x72, 0x6F, 0x75, 0x6E, 0x64, 0x00 };

        [NativeTypeName("#define XNBackgroundPixmap \"backgroundPixmap\"")]
        public static ReadOnlySpan<byte> XNBackgroundPixmap => new byte[] { 0x62, 0x61, 0x63, 0x6B, 0x67, 0x72, 0x6F, 0x75, 0x6E, 0x64, 0x50, 0x69, 0x78, 0x6D, 0x61, 0x70, 0x00 };

        [NativeTypeName("#define XNFontSet \"fontSet\"")]
        public static ReadOnlySpan<byte> XNFontSet => new byte[] { 0x66, 0x6F, 0x6E, 0x74, 0x53, 0x65, 0x74, 0x00 };

        [NativeTypeName("#define XNLineSpace \"lineSpace\"")]
        public static ReadOnlySpan<byte> XNLineSpace => new byte[] { 0x6C, 0x69, 0x6E, 0x65, 0x53, 0x70, 0x61, 0x63, 0x65, 0x00 };

        [NativeTypeName("#define XNCursor \"cursor\"")]
        public static ReadOnlySpan<byte> XNCursor => new byte[] { 0x63, 0x75, 0x72, 0x73, 0x6F, 0x72, 0x00 };

        [NativeTypeName("#define XNQueryIMValuesList \"queryIMValuesList\"")]
        public static ReadOnlySpan<byte> XNQueryIMValuesList => new byte[] { 0x71, 0x75, 0x65, 0x72, 0x79, 0x49, 0x4D, 0x56, 0x61, 0x6C, 0x75, 0x65, 0x73, 0x4C, 0x69, 0x73, 0x74, 0x00 };

        [NativeTypeName("#define XNQueryICValuesList \"queryICValuesList\"")]
        public static ReadOnlySpan<byte> XNQueryICValuesList => new byte[] { 0x71, 0x75, 0x65, 0x72, 0x79, 0x49, 0x43, 0x56, 0x61, 0x6C, 0x75, 0x65, 0x73, 0x4C, 0x69, 0x73, 0x74, 0x00 };

        [NativeTypeName("#define XNVisiblePosition \"visiblePosition\"")]
        public static ReadOnlySpan<byte> XNVisiblePosition => new byte[] { 0x76, 0x69, 0x73, 0x69, 0x62, 0x6C, 0x65, 0x50, 0x6F, 0x73, 0x69, 0x74, 0x69, 0x6F, 0x6E, 0x00 };

        [NativeTypeName("#define XNR6PreeditCallback \"r6PreeditCallback\"")]
        public static ReadOnlySpan<byte> XNR6PreeditCallback => new byte[] { 0x72, 0x36, 0x50, 0x72, 0x65, 0x65, 0x64, 0x69, 0x74, 0x43, 0x61, 0x6C, 0x6C, 0x62, 0x61, 0x63, 0x6B, 0x00 };

        [NativeTypeName("#define XNStringConversionCallback \"stringConversionCallback\"")]
        public static ReadOnlySpan<byte> XNStringConversionCallback => new byte[] { 0x73, 0x74, 0x72, 0x69, 0x6E, 0x67, 0x43, 0x6F, 0x6E, 0x76, 0x65, 0x72, 0x73, 0x69, 0x6F, 0x6E, 0x43, 0x61, 0x6C, 0x6C, 0x62, 0x61, 0x63, 0x6B, 0x00 };

        [NativeTypeName("#define XNStringConversion \"stringConversion\"")]
        public static ReadOnlySpan<byte> XNStringConversion => new byte[] { 0x73, 0x74, 0x72, 0x69, 0x6E, 0x67, 0x43, 0x6F, 0x6E, 0x76, 0x65, 0x72, 0x73, 0x69, 0x6F, 0x6E, 0x00 };

        [NativeTypeName("#define XNResetState \"resetState\"")]
        public static ReadOnlySpan<byte> XNResetState => new byte[] { 0x72, 0x65, 0x73, 0x65, 0x74, 0x53, 0x74, 0x61, 0x74, 0x65, 0x00 };

        [NativeTypeName("#define XNHotKey \"hotKey\"")]
        public static ReadOnlySpan<byte> XNHotKey => new byte[] { 0x68, 0x6F, 0x74, 0x4B, 0x65, 0x79, 0x00 };

        [NativeTypeName("#define XNHotKeyState \"hotKeyState\"")]
        public static ReadOnlySpan<byte> XNHotKeyState => new byte[] { 0x68, 0x6F, 0x74, 0x4B, 0x65, 0x79, 0x53, 0x74, 0x61, 0x74, 0x65, 0x00 };

        [NativeTypeName("#define XNPreeditState \"preeditState\"")]
        public static ReadOnlySpan<byte> XNPreeditState => new byte[] { 0x70, 0x72, 0x65, 0x65, 0x64, 0x69, 0x74, 0x53, 0x74, 0x61, 0x74, 0x65, 0x00 };

        [NativeTypeName("#define XNSeparatorofNestedList \"separatorofNestedList\"")]
        public static ReadOnlySpan<byte> XNSeparatorofNestedList => new byte[] { 0x73, 0x65, 0x70, 0x61, 0x72, 0x61, 0x74, 0x6F, 0x72, 0x6F, 0x66, 0x4E, 0x65, 0x73, 0x74, 0x65, 0x64, 0x4C, 0x69, 0x73, 0x74, 0x00 };

        [NativeTypeName("#define XBufferOverflow -1")]
        public const int XBufferOverflow = -1;

        [NativeTypeName("#define XLookupNone 1")]
        public const int XLookupNone = 1;

        [NativeTypeName("#define XLookupChars 2")]
        public const int XLookupChars = 2;

        [NativeTypeName("#define XLookupKeySym 3")]
        public const int XLookupKeySym = 3;

        [NativeTypeName("#define XLookupBoth 4")]
        public const int XLookupBoth = 4;

        [NativeTypeName("#define XIMReverse 1L")]
        public const nint XIMReverse = 1;

        [NativeTypeName("#define XIMUnderline (1L<<1)")]
        public const nint XIMUnderline = (1 << 1);

        [NativeTypeName("#define XIMHighlight (1L<<2)")]
        public const nint XIMHighlight = (1 << 2);

        [NativeTypeName("#define XIMPrimary (1L<<5)")]
        public const nint XIMPrimary = (1 << 5);

        [NativeTypeName("#define XIMSecondary (1L<<6)")]
        public const nint XIMSecondary = (1 << 6);

        [NativeTypeName("#define XIMTertiary (1L<<7)")]
        public const nint XIMTertiary = (1 << 7);

        [NativeTypeName("#define XIMVisibleToForward (1L<<8)")]
        public const nint XIMVisibleToForward = (1 << 8);

        [NativeTypeName("#define XIMVisibleToBackword (1L<<9)")]
        public const nint XIMVisibleToBackword = (1 << 9);

        [NativeTypeName("#define XIMVisibleToCenter (1L<<10)")]
        public const nint XIMVisibleToCenter = (1 << 10);

        [NativeTypeName("#define XIMPreeditUnKnown 0L")]
        public const nint XIMPreeditUnKnown = 0;

        [NativeTypeName("#define XIMPreeditEnable 1L")]
        public const nint XIMPreeditEnable = 1;

        [NativeTypeName("#define XIMPreeditDisable (1L<<1)")]
        public const nint XIMPreeditDisable = (1 << 1);

        [NativeTypeName("#define XIMInitialState 1L")]
        public const nint XIMInitialState = 1;

        [NativeTypeName("#define XIMPreserveState (1L<<1)")]
        public const nint XIMPreserveState = (1 << 1);

        [NativeTypeName("#define XIMStringConversionLeftEdge (0x00000001)")]
        public const int XIMStringConversionLeftEdge = (0x00000001);

        [NativeTypeName("#define XIMStringConversionRightEdge (0x00000002)")]
        public const int XIMStringConversionRightEdge = (0x00000002);

        [NativeTypeName("#define XIMStringConversionTopEdge (0x00000004)")]
        public const int XIMStringConversionTopEdge = (0x00000004);

        [NativeTypeName("#define XIMStringConversionBottomEdge (0x00000008)")]
        public const int XIMStringConversionBottomEdge = (0x00000008);

        [NativeTypeName("#define XIMStringConversionConcealed (0x00000010)")]
        public const int XIMStringConversionConcealed = (0x00000010);

        [NativeTypeName("#define XIMStringConversionWrapped (0x00000020)")]
        public const int XIMStringConversionWrapped = (0x00000020);

        [NativeTypeName("#define XIMStringConversionBuffer (0x0001)")]
        public const int XIMStringConversionBuffer = (0x0001);

        [NativeTypeName("#define XIMStringConversionLine (0x0002)")]
        public const int XIMStringConversionLine = (0x0002);

        [NativeTypeName("#define XIMStringConversionWord (0x0003)")]
        public const int XIMStringConversionWord = (0x0003);

        [NativeTypeName("#define XIMStringConversionChar (0x0004)")]
        public const int XIMStringConversionChar = (0x0004);

        [NativeTypeName("#define XIMStringConversionSubstitution (0x0001)")]
        public const int XIMStringConversionSubstitution = (0x0001);

        [NativeTypeName("#define XIMStringConversionRetrieval (0x0002)")]
        public const int XIMStringConversionRetrieval = (0x0002);

        [NativeTypeName("#define XIMHotKeyStateON (0x0001L)")]
        public const nint XIMHotKeyStateON = (0x0001);

        [NativeTypeName("#define XIMHotKeyStateOFF (0x0002L)")]
        public const nint XIMHotKeyStateOFF = (0x0002);
    }
}
