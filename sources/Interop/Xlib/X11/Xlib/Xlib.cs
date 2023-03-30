// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Xlib;

public static unsafe partial class Xlib
{
    [DllImport("libX11", EntryPoint = "_Z7_XmblenPci", ExactSpelling = true)]
    public static extern int _Xmblen([NativeTypeName("char *")] sbyte* str, int len);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern XFontStruct* XLoadQueryFont(Display* param0, [NativeTypeName("const char *")] sbyte* param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern XFontStruct* XQueryFont(Display* param0, XID param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern XTimeCoord* XGetMotionEvents(Display* param0, Window param1, Time param2, Time param3, int* param4);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern XModifierKeymap* XDeleteModifiermapEntry(XModifierKeymap* param0, [NativeTypeName("KeyCode")] byte param1, int param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern XModifierKeymap* XGetModifierMapping(Display* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern XModifierKeymap* XInsertModifiermapEntry(XModifierKeymap* param0, [NativeTypeName("KeyCode")] byte param1, int param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern XModifierKeymap* XNewModifiermap(int param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern XImage* XCreateImage(Display* param0, Visual* param1, [NativeTypeName("unsigned int")] uint param2, int param3, int param4, [NativeTypeName("char *")] sbyte* param5, [NativeTypeName("unsigned int")] uint param6, [NativeTypeName("unsigned int")] uint param7, int param8, int param9);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XInitImage(XImage* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern XImage* XGetImage(Display* param0, Drawable param1, int param2, int param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned long")] nuint param6, int param7);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern XImage* XGetSubImage(Display* param0, Drawable param1, int param2, int param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned long")] nuint param6, int param7, XImage* param8, int param9, int param10);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern Display* XOpenDisplay([NativeTypeName("const char *")] sbyte* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern void XrmInitialize();

    [DllImport("libX11", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* XFetchBytes(Display* param0, int* param1);

    [DllImport("libX11", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* XFetchBuffer(Display* param0, int* param1, int param2);

    [DllImport("libX11", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* XGetAtomName(Display* param0, Atom param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XGetAtomNames(Display* param0, Atom* param1, int param2, [NativeTypeName("char **")] sbyte** param3);

    [DllImport("libX11", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* XGetDefault(Display* param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("const char *")] sbyte* param2);

    [DllImport("libX11", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* XDisplayName([NativeTypeName("const char *")] sbyte* param0);

    [DllImport("libX11", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* XKeysymToString(KeySym param0);

    [DllImport("libX11", ExactSpelling = true)]
    [return: NativeTypeName("int (*)(Display *)")]
    public static extern delegate* unmanaged<Display*, int> XSynchronize(Display* param0, int param1);

    [DllImport("libX11", ExactSpelling = true)]
    [return: NativeTypeName("int (*)(Display *)")]
    public static extern delegate* unmanaged<Display*, int> XSetAfterFunction(Display* param0, [NativeTypeName("int (*)(Display *)")] delegate* unmanaged<Display*, int> param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern Atom XInternAtom(Display* param0, [NativeTypeName("const char *")] sbyte* param1, int param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XInternAtoms(Display* param0, [NativeTypeName("char **")] sbyte** param1, int param2, int param3, Atom* param4);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern Colormap XCopyColormapAndFree(Display* param0, Colormap param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern Colormap XCreateColormap(Display* param0, Window param1, Visual* param2, int param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern Cursor XCreatePixmapCursor(Display* param0, Pixmap param1, Pixmap param2, XColor* param3, XColor* param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned int")] uint param6);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern Cursor XCreateGlyphCursor(Display* param0, Font param1, Font param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("const XColor *")] XColor* param5, [NativeTypeName("const XColor *")] XColor* param6);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern Cursor XCreateFontCursor(Display* param0, [NativeTypeName("unsigned int")] uint param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern Font XLoadFont(Display* param0, [NativeTypeName("const char *")] sbyte* param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern GC XCreateGC(Display* param0, Drawable param1, [NativeTypeName("unsigned long")] nuint param2, XGCValues* param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern GContext XGContextFromGC(GC param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern void XFlushGC(Display* param0, GC param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern Pixmap XCreatePixmap(Display* param0, Drawable param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int")] uint param4);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern Pixmap XCreateBitmapFromData(Display* param0, Drawable param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int")] uint param4);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern Pixmap XCreatePixmapFromBitmapData(Display* param0, Drawable param1, [NativeTypeName("char *")] sbyte* param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned long")] nuint param5, [NativeTypeName("unsigned long")] nuint param6, [NativeTypeName("unsigned int")] uint param7);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern Window XCreateSimpleWindow(Display* param0, Window param1, int param2, int param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned int")] uint param6, [NativeTypeName("unsigned long")] nuint param7, [NativeTypeName("unsigned long")] nuint param8);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern Window XGetSelectionOwner(Display* param0, Atom param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern Window XCreateWindow(Display* param0, Window param1, int param2, int param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned int")] uint param6, int param7, [NativeTypeName("unsigned int")] uint param8, Visual* param9, [NativeTypeName("unsigned long")] nuint param10, XSetWindowAttributes* param11);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern Colormap* XListInstalledColormaps(Display* param0, Window param1, int* param2);

    [DllImport("libX11", ExactSpelling = true)]
    [return: NativeTypeName("char **")]
    public static extern sbyte** XListFonts(Display* param0, [NativeTypeName("const char *")] sbyte* param1, int param2, int* param3);

    [DllImport("libX11", ExactSpelling = true)]
    [return: NativeTypeName("char **")]
    public static extern sbyte** XListFontsWithInfo(Display* param0, [NativeTypeName("const char *")] sbyte* param1, int param2, int* param3, XFontStruct** param4);

    [DllImport("libX11", ExactSpelling = true)]
    [return: NativeTypeName("char **")]
    public static extern sbyte** XGetFontPath(Display* param0, int* param1);

    [DllImport("libX11", ExactSpelling = true)]
    [return: NativeTypeName("char **")]
    public static extern sbyte** XListExtensions(Display* param0, int* param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern Atom* XListProperties(Display* param0, Window param1, int* param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern XHostAddress* XListHosts(Display* param0, int* param1, int* param2);

    [DllImport("libX11", ExactSpelling = true)]
    [Obsolete]
    public static extern KeySym XKeycodeToKeysym(Display* param0, [NativeTypeName("KeyCode")] byte param1, int param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern KeySym XLookupKeysym(XKeyEvent* param0, int param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern KeySym* XGetKeyboardMapping(Display* param0, [NativeTypeName("KeyCode")] byte param1, int param2, int* param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern KeySym XStringToKeysym([NativeTypeName("const char *")] sbyte* param0);

    [DllImport("libX11", ExactSpelling = true)]
    [return: NativeTypeName("long")]
    public static extern nint XMaxRequestSize(Display* param0);

    [DllImport("libX11", ExactSpelling = true)]
    [return: NativeTypeName("long")]
    public static extern nint XExtendedMaxRequestSize(Display* param0);

    [DllImport("libX11", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* XResourceManagerString(Display* param0);

    [DllImport("libX11", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* XScreenResourceString(Screen* param0);

    [DllImport("libX11", ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    public static extern nuint XDisplayMotionBufferSize(Display* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern VisualID XVisualIDFromVisual(Visual* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XInitThreads();

    [DllImport("libX11", ExactSpelling = true)]
    public static extern void XLockDisplay(Display* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern void XUnlockDisplay(Display* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern XExtCodes* XInitExtension(Display* param0, [NativeTypeName("const char *")] sbyte* param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern XExtCodes* XAddExtension(Display* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern XExtData* XFindOnExtensionList(XExtData** param0, int param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern XExtData** XEHeadOfExtensionList(XEDataObject param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern Window XRootWindow(Display* param0, int param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern Window XDefaultRootWindow(Display* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern Window XRootWindowOfScreen(Screen* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern Visual* XDefaultVisual(Display* param0, int param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern Visual* XDefaultVisualOfScreen(Screen* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern GC XDefaultGC(Display* param0, int param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern GC XDefaultGCOfScreen(Screen* param0);

    [DllImport("libX11", ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    public static extern nuint XBlackPixel(Display* param0, int param1);

    [DllImport("libX11", ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    public static extern nuint XWhitePixel(Display* param0, int param1);

    [DllImport("libX11", ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    public static extern nuint XAllPlanes();

    [DllImport("libX11", ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    public static extern nuint XBlackPixelOfScreen(Screen* param0);

    [DllImport("libX11", ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    public static extern nuint XWhitePixelOfScreen(Screen* param0);

    [DllImport("libX11", ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    public static extern nuint XNextRequest(Display* param0);

    [DllImport("libX11", ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    public static extern nuint XLastKnownRequestProcessed(Display* param0);

    [DllImport("libX11", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* XServerVendor(Display* param0);

    [DllImport("libX11", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* XDisplayString(Display* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern Colormap XDefaultColormap(Display* param0, int param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern Colormap XDefaultColormapOfScreen(Screen* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern Display* XDisplayOfScreen(Screen* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern Screen* XScreenOfDisplay(Display* param0, int param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern Screen* XDefaultScreenOfDisplay(Display* param0);

    [DllImport("libX11", ExactSpelling = true)]
    [return: NativeTypeName("long")]
    public static extern nint XEventMaskOfScreen(Screen* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XScreenNumberOfScreen(Screen* param0);

    [DllImport("libX11", ExactSpelling = true)]
    [return: NativeTypeName("XErrorHandler")]
    public static extern delegate* unmanaged<Display*, XErrorEvent*, int> XSetErrorHandler([NativeTypeName("XErrorHandler")] delegate* unmanaged<Display*, XErrorEvent*, int> param0);

    [DllImport("libX11", ExactSpelling = true)]
    [return: NativeTypeName("XIOErrorHandler")]
    public static extern delegate* unmanaged<Display*, int> XSetIOErrorHandler([NativeTypeName("XIOErrorHandler")] delegate* unmanaged<Display*, int> param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern void XSetIOErrorExitHandler(Display* param0, [NativeTypeName("XIOErrorExitHandler")] delegate* unmanaged<Display*, void*, void> param1, void* param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern XPixmapFormatValues* XListPixmapFormats(Display* param0, int* param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int* XListDepths(Display* param0, int param1, int* param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XReconfigureWMWindow(Display* param0, Window param1, int param2, [NativeTypeName("unsigned int")] uint param3, XWindowChanges* param4);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XGetWMProtocols(Display* param0, Window param1, Atom** param2, int* param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XSetWMProtocols(Display* param0, Window param1, Atom* param2, int param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XIconifyWindow(Display* param0, Window param1, int param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XWithdrawWindow(Display* param0, Window param1, int param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XGetCommand(Display* param0, Window param1, [NativeTypeName("char ***")] sbyte*** param2, int* param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XGetWMColormapWindows(Display* param0, Window param1, Window** param2, int* param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XSetWMColormapWindows(Display* param0, Window param1, Window* param2, int param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern void XFreeStringList([NativeTypeName("char **")] sbyte** param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XSetTransientForHint(Display* param0, Window param1, Window param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XActivateScreenSaver(Display* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XAddHost(Display* param0, XHostAddress* param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XAddHosts(Display* param0, XHostAddress* param1, int param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XAddToExtensionList([NativeTypeName("struct _XExtData **")] XExtData** param0, XExtData* param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XAddToSaveSet(Display* param0, Window param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XAllocColor(Display* param0, Colormap param1, XColor* param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XAllocColorCells(Display* param0, Colormap param1, int param2, [NativeTypeName("unsigned long *")] nuint* param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned long *")] nuint* param5, [NativeTypeName("unsigned int")] uint param6);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XAllocColorPlanes(Display* param0, Colormap param1, int param2, [NativeTypeName("unsigned long *")] nuint* param3, int param4, int param5, int param6, int param7, [NativeTypeName("unsigned long *")] nuint* param8, [NativeTypeName("unsigned long *")] nuint* param9, [NativeTypeName("unsigned long *")] nuint* param10);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XAllocNamedColor(Display* param0, Colormap param1, [NativeTypeName("const char *")] sbyte* param2, XColor* param3, XColor* param4);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XAllowEvents(Display* param0, int param1, Time param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XAutoRepeatOff(Display* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XAutoRepeatOn(Display* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XBell(Display* param0, int param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XBitmapBitOrder(Display* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XBitmapPad(Display* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XBitmapUnit(Display* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XCellsOfScreen(Screen* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XChangeActivePointerGrab(Display* param0, [NativeTypeName("unsigned int")] uint param1, Cursor param2, Time param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XChangeGC(Display* param0, GC param1, [NativeTypeName("unsigned long")] nuint param2, XGCValues* param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XChangeKeyboardControl(Display* param0, [NativeTypeName("unsigned long")] nuint param1, XKeyboardControl* param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XChangeKeyboardMapping(Display* param0, int param1, int param2, KeySym* param3, int param4);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XChangePointerControl(Display* param0, int param1, int param2, int param3, int param4, int param5);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XChangeProperty(Display* param0, Window param1, Atom param2, Atom param3, int param4, int param5, [NativeTypeName("const unsigned char *")] byte* param6, int param7);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XChangeSaveSet(Display* param0, Window param1, int param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XChangeWindowAttributes(Display* param0, Window param1, [NativeTypeName("unsigned long")] nuint param2, XSetWindowAttributes* param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XCheckIfEvent(Display* param0, XEvent* param1, [NativeTypeName("int (*)(Display *, XEvent *, XPointer)")] delegate* unmanaged<Display*, XEvent*, sbyte*, int> param2, [NativeTypeName("XPointer")] sbyte* param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XCheckMaskEvent(Display* param0, [NativeTypeName("long")] nint param1, XEvent* param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XCheckTypedEvent(Display* param0, int param1, XEvent* param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XCheckTypedWindowEvent(Display* param0, Window param1, int param2, XEvent* param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XCheckWindowEvent(Display* param0, Window param1, [NativeTypeName("long")] nint param2, XEvent* param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XCirculateSubwindows(Display* param0, Window param1, int param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XCirculateSubwindowsDown(Display* param0, Window param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XCirculateSubwindowsUp(Display* param0, Window param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XClearArea(Display* param0, Window param1, int param2, int param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int")] uint param5, int param6);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XClearWindow(Display* param0, Window param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XCloseDisplay(Display* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XConfigureWindow(Display* param0, Window param1, [NativeTypeName("unsigned int")] uint param2, XWindowChanges* param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XConnectionNumber(Display* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XConvertSelection(Display* param0, Atom param1, Atom param2, Atom param3, Window param4, Time param5);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XCopyArea(Display* param0, Drawable param1, Drawable param2, GC param3, int param4, int param5, [NativeTypeName("unsigned int")] uint param6, [NativeTypeName("unsigned int")] uint param7, int param8, int param9);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XCopyGC(Display* param0, GC param1, [NativeTypeName("unsigned long")] nuint param2, GC param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XCopyPlane(Display* param0, Drawable param1, Drawable param2, GC param3, int param4, int param5, [NativeTypeName("unsigned int")] uint param6, [NativeTypeName("unsigned int")] uint param7, int param8, int param9, [NativeTypeName("unsigned long")] nuint param10);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XDefaultDepth(Display* param0, int param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XDefaultDepthOfScreen(Screen* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XDefaultScreen(Display* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XDefineCursor(Display* param0, Window param1, Cursor param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XDeleteProperty(Display* param0, Window param1, Atom param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XDestroyWindow(Display* param0, Window param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XDestroySubwindows(Display* param0, Window param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XDoesBackingStore(Screen* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XDoesSaveUnders(Screen* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XDisableAccessControl(Display* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XDisplayCells(Display* param0, int param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XDisplayHeight(Display* param0, int param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XDisplayHeightMM(Display* param0, int param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XDisplayKeycodes(Display* param0, int* param1, int* param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XDisplayPlanes(Display* param0, int param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XDisplayWidth(Display* param0, int param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XDisplayWidthMM(Display* param0, int param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XDrawArc(Display* param0, Drawable param1, GC param2, int param3, int param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned int")] uint param6, int param7, int param8);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XDrawArcs(Display* param0, Drawable param1, GC param2, XArc* param3, int param4);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XDrawImageString(Display* param0, Drawable param1, GC param2, int param3, int param4, [NativeTypeName("const char *")] sbyte* param5, int param6);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XDrawImageString16(Display* param0, Drawable param1, GC param2, int param3, int param4, [NativeTypeName("const XChar2b *")] XChar2b* param5, int param6);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XDrawLine(Display* param0, Drawable param1, GC param2, int param3, int param4, int param5, int param6);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XDrawLines(Display* param0, Drawable param1, GC param2, XPoint* param3, int param4, int param5);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XDrawPoint(Display* param0, Drawable param1, GC param2, int param3, int param4);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XDrawPoints(Display* param0, Drawable param1, GC param2, XPoint* param3, int param4, int param5);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XDrawRectangle(Display* param0, Drawable param1, GC param2, int param3, int param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned int")] uint param6);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XDrawRectangles(Display* param0, Drawable param1, GC param2, XRectangle* param3, int param4);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XDrawSegments(Display* param0, Drawable param1, GC param2, XSegment* param3, int param4);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XDrawString(Display* param0, Drawable param1, GC param2, int param3, int param4, [NativeTypeName("const char *")] sbyte* param5, int param6);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XDrawString16(Display* param0, Drawable param1, GC param2, int param3, int param4, [NativeTypeName("const XChar2b *")] XChar2b* param5, int param6);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XDrawText(Display* param0, Drawable param1, GC param2, int param3, int param4, XTextItem* param5, int param6);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XDrawText16(Display* param0, Drawable param1, GC param2, int param3, int param4, XTextItem16* param5, int param6);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XEnableAccessControl(Display* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XEventsQueued(Display* param0, int param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XFetchName(Display* param0, Window param1, [NativeTypeName("char **")] sbyte** param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XFillArc(Display* param0, Drawable param1, GC param2, int param3, int param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned int")] uint param6, int param7, int param8);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XFillArcs(Display* param0, Drawable param1, GC param2, XArc* param3, int param4);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XFillPolygon(Display* param0, Drawable param1, GC param2, XPoint* param3, int param4, int param5, int param6);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XFillRectangle(Display* param0, Drawable param1, GC param2, int param3, int param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned int")] uint param6);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XFillRectangles(Display* param0, Drawable param1, GC param2, XRectangle* param3, int param4);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XFlush(Display* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XForceScreenSaver(Display* param0, int param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XFree(void* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XFreeColormap(Display* param0, Colormap param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XFreeColors(Display* param0, Colormap param1, [NativeTypeName("unsigned long *")] nuint* param2, int param3, [NativeTypeName("unsigned long")] nuint param4);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XFreeCursor(Display* param0, Cursor param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XFreeExtensionList([NativeTypeName("char **")] sbyte** param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XFreeFont(Display* param0, XFontStruct* param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XFreeFontInfo([NativeTypeName("char **")] sbyte** param0, XFontStruct* param1, int param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XFreeFontNames([NativeTypeName("char **")] sbyte** param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XFreeFontPath([NativeTypeName("char **")] sbyte** param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XFreeGC(Display* param0, GC param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XFreeModifiermap(XModifierKeymap* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XFreePixmap(Display* param0, Pixmap param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XGeometry(Display* param0, int param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("const char *")] sbyte* param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned int")] uint param6, int param7, int param8, int* param9, int* param10, int* param11, int* param12);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XGetErrorDatabaseText(Display* param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("const char *")] sbyte* param3, [NativeTypeName("char *")] sbyte* param4, int param5);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XGetErrorText(Display* param0, int param1, [NativeTypeName("char *")] sbyte* param2, int param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XGetFontProperty(XFontStruct* param0, Atom param1, [NativeTypeName("unsigned long *")] nuint* param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XGetGCValues(Display* param0, GC param1, [NativeTypeName("unsigned long")] nuint param2, XGCValues* param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XGetGeometry(Display* param0, Drawable param1, Window* param2, int* param3, int* param4, [NativeTypeName("unsigned int *")] uint* param5, [NativeTypeName("unsigned int *")] uint* param6, [NativeTypeName("unsigned int *")] uint* param7, [NativeTypeName("unsigned int *")] uint* param8);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XGetIconName(Display* param0, Window param1, [NativeTypeName("char **")] sbyte** param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XGetInputFocus(Display* param0, Window* param1, int* param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XGetKeyboardControl(Display* param0, XKeyboardState* param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XGetPointerControl(Display* param0, int* param1, int* param2, int* param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XGetPointerMapping(Display* param0, [NativeTypeName("unsigned char *")] byte* param1, int param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XGetScreenSaver(Display* param0, int* param1, int* param2, int* param3, int* param4);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XGetTransientForHint(Display* param0, Window param1, Window* param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XGetWindowProperty(Display* param0, Window param1, Atom param2, [NativeTypeName("long")] nint param3, [NativeTypeName("long")] nint param4, int param5, Atom param6, Atom* param7, int* param8, [NativeTypeName("unsigned long *")] nuint* param9, [NativeTypeName("unsigned long *")] nuint* param10, [NativeTypeName("unsigned char **")] byte** param11);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XGetWindowAttributes(Display* param0, Window param1, XWindowAttributes* param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XGrabButton(Display* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("unsigned int")] uint param2, Window param3, int param4, [NativeTypeName("unsigned int")] uint param5, int param6, int param7, Window param8, Cursor param9);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XGrabKey(Display* param0, int param1, [NativeTypeName("unsigned int")] uint param2, Window param3, int param4, int param5, int param6);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XGrabKeyboard(Display* param0, Window param1, int param2, int param3, int param4, Time param5);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XGrabPointer(Display* param0, Window param1, int param2, [NativeTypeName("unsigned int")] uint param3, int param4, int param5, Window param6, Cursor param7, Time param8);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XGrabServer(Display* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XHeightMMOfScreen(Screen* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XHeightOfScreen(Screen* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XIfEvent(Display* param0, XEvent* param1, [NativeTypeName("int (*)(Display *, XEvent *, XPointer)")] delegate* unmanaged<Display*, XEvent*, sbyte*, int> param2, [NativeTypeName("XPointer")] sbyte* param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XImageByteOrder(Display* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XInstallColormap(Display* param0, Colormap param1);

    [DllImport("libX11", ExactSpelling = true)]
    [return: NativeTypeName("KeyCode")]
    public static extern byte XKeysymToKeycode(Display* param0, KeySym param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XKillClient(Display* param0, XID param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XLookupColor(Display* param0, Colormap param1, [NativeTypeName("const char *")] sbyte* param2, XColor* param3, XColor* param4);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XLowerWindow(Display* param0, Window param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XMapRaised(Display* param0, Window param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XMapSubwindows(Display* param0, Window param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XMapWindow(Display* param0, Window param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XMaskEvent(Display* param0, [NativeTypeName("long")] nint param1, XEvent* param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XMaxCmapsOfScreen(Screen* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XMinCmapsOfScreen(Screen* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XMoveResizeWindow(Display* param0, Window param1, int param2, int param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int")] uint param5);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XMoveWindow(Display* param0, Window param1, int param2, int param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XNextEvent(Display* param0, XEvent* param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XNoOp(Display* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XParseColor(Display* param0, Colormap param1, [NativeTypeName("const char *")] sbyte* param2, XColor* param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XParseGeometry([NativeTypeName("const char *")] sbyte* param0, int* param1, int* param2, [NativeTypeName("unsigned int *")] uint* param3, [NativeTypeName("unsigned int *")] uint* param4);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XPeekEvent(Display* param0, XEvent* param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XPeekIfEvent(Display* param0, XEvent* param1, [NativeTypeName("int (*)(Display *, XEvent *, XPointer)")] delegate* unmanaged<Display*, XEvent*, sbyte*, int> param2, [NativeTypeName("XPointer")] sbyte* param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XPending(Display* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XPlanesOfScreen(Screen* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XProtocolRevision(Display* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XProtocolVersion(Display* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XPutBackEvent(Display* param0, XEvent* param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XPutImage(Display* param0, Drawable param1, GC param2, XImage* param3, int param4, int param5, int param6, int param7, [NativeTypeName("unsigned int")] uint param8, [NativeTypeName("unsigned int")] uint param9);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XQLength(Display* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XQueryBestCursor(Display* param0, Drawable param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int *")] uint* param4, [NativeTypeName("unsigned int *")] uint* param5);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XQueryBestSize(Display* param0, int param1, Drawable param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int *")] uint* param5, [NativeTypeName("unsigned int *")] uint* param6);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XQueryBestStipple(Display* param0, Drawable param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int *")] uint* param4, [NativeTypeName("unsigned int *")] uint* param5);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XQueryBestTile(Display* param0, Drawable param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int *")] uint* param4, [NativeTypeName("unsigned int *")] uint* param5);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XQueryColor(Display* param0, Colormap param1, XColor* param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XQueryColors(Display* param0, Colormap param1, XColor* param2, int param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XQueryExtension(Display* param0, [NativeTypeName("const char *")] sbyte* param1, int* param2, int* param3, int* param4);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XQueryKeymap(Display* param0, [NativeTypeName("char[32]")] sbyte* param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XQueryPointer(Display* param0, Window param1, Window* param2, Window* param3, int* param4, int* param5, int* param6, int* param7, [NativeTypeName("unsigned int *")] uint* param8);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XQueryTextExtents(Display* param0, XID param1, [NativeTypeName("const char *")] sbyte* param2, int param3, int* param4, int* param5, int* param6, XCharStruct* param7);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XQueryTextExtents16(Display* param0, XID param1, [NativeTypeName("const XChar2b *")] XChar2b* param2, int param3, int* param4, int* param5, int* param6, XCharStruct* param7);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XQueryTree(Display* param0, Window param1, Window* param2, Window* param3, Window** param4, [NativeTypeName("unsigned int *")] uint* param5);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XRaiseWindow(Display* param0, Window param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XReadBitmapFile(Display* param0, Drawable param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("unsigned int *")] uint* param3, [NativeTypeName("unsigned int *")] uint* param4, Pixmap* param5, int* param6, int* param7);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XReadBitmapFileData([NativeTypeName("const char *")] sbyte* param0, [NativeTypeName("unsigned int *")] uint* param1, [NativeTypeName("unsigned int *")] uint* param2, [NativeTypeName("unsigned char **")] byte** param3, int* param4, int* param5);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XRebindKeysym(Display* param0, KeySym param1, KeySym* param2, int param3, [NativeTypeName("const unsigned char *")] byte* param4, int param5);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XRecolorCursor(Display* param0, Cursor param1, XColor* param2, XColor* param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XRefreshKeyboardMapping(XMappingEvent* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XRemoveFromSaveSet(Display* param0, Window param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XRemoveHost(Display* param0, XHostAddress* param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XRemoveHosts(Display* param0, XHostAddress* param1, int param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XReparentWindow(Display* param0, Window param1, Window param2, int param3, int param4);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XResetScreenSaver(Display* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XResizeWindow(Display* param0, Window param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XRestackWindows(Display* param0, Window* param1, int param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XRotateBuffers(Display* param0, int param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XRotateWindowProperties(Display* param0, Window param1, Atom* param2, int param3, int param4);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XScreenCount(Display* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XSelectInput(Display* param0, Window param1, [NativeTypeName("long")] nint param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XSendEvent(Display* param0, Window param1, int param2, [NativeTypeName("long")] nint param3, XEvent* param4);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XSetAccessControl(Display* param0, int param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XSetArcMode(Display* param0, GC param1, int param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XSetBackground(Display* param0, GC param1, [NativeTypeName("unsigned long")] nuint param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XSetClipMask(Display* param0, GC param1, Pixmap param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XSetClipOrigin(Display* param0, GC param1, int param2, int param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XSetClipRectangles(Display* param0, GC param1, int param2, int param3, XRectangle* param4, int param5, int param6);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XSetCloseDownMode(Display* param0, int param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XSetCommand(Display* param0, Window param1, [NativeTypeName("char **")] sbyte** param2, int param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XSetDashes(Display* param0, GC param1, int param2, [NativeTypeName("const char *")] sbyte* param3, int param4);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XSetFillRule(Display* param0, GC param1, int param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XSetFillStyle(Display* param0, GC param1, int param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XSetFont(Display* param0, GC param1, Font param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XSetFontPath(Display* param0, [NativeTypeName("char **")] sbyte** param1, int param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XSetForeground(Display* param0, GC param1, [NativeTypeName("unsigned long")] nuint param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XSetFunction(Display* param0, GC param1, int param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XSetGraphicsExposures(Display* param0, GC param1, int param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XSetIconName(Display* param0, Window param1, [NativeTypeName("const char *")] sbyte* param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XSetInputFocus(Display* param0, Window param1, int param2, Time param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XSetLineAttributes(Display* param0, GC param1, [NativeTypeName("unsigned int")] uint param2, int param3, int param4, int param5);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XSetModifierMapping(Display* param0, XModifierKeymap* param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XSetPlaneMask(Display* param0, GC param1, [NativeTypeName("unsigned long")] nuint param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XSetPointerMapping(Display* param0, [NativeTypeName("const unsigned char *")] byte* param1, int param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XSetScreenSaver(Display* param0, int param1, int param2, int param3, int param4);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XSetSelectionOwner(Display* param0, Atom param1, Window param2, Time param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XSetState(Display* param0, GC param1, [NativeTypeName("unsigned long")] nuint param2, [NativeTypeName("unsigned long")] nuint param3, int param4, [NativeTypeName("unsigned long")] nuint param5);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XSetStipple(Display* param0, GC param1, Pixmap param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XSetSubwindowMode(Display* param0, GC param1, int param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XSetTSOrigin(Display* param0, GC param1, int param2, int param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XSetTile(Display* param0, GC param1, Pixmap param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XSetWindowBackground(Display* param0, Window param1, [NativeTypeName("unsigned long")] nuint param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XSetWindowBackgroundPixmap(Display* param0, Window param1, Pixmap param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XSetWindowBorder(Display* param0, Window param1, [NativeTypeName("unsigned long")] nuint param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XSetWindowBorderPixmap(Display* param0, Window param1, Pixmap param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XSetWindowBorderWidth(Display* param0, Window param1, [NativeTypeName("unsigned int")] uint param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XSetWindowColormap(Display* param0, Window param1, Colormap param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XStoreBuffer(Display* param0, [NativeTypeName("const char *")] sbyte* param1, int param2, int param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XStoreBytes(Display* param0, [NativeTypeName("const char *")] sbyte* param1, int param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XStoreColor(Display* param0, Colormap param1, XColor* param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XStoreColors(Display* param0, Colormap param1, XColor* param2, int param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XStoreName(Display* param0, Window param1, [NativeTypeName("const char *")] sbyte* param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XStoreNamedColor(Display* param0, Colormap param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("unsigned long")] nuint param3, int param4);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XSync(Display* param0, int param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XTextExtents(XFontStruct* param0, [NativeTypeName("const char *")] sbyte* param1, int param2, int* param3, int* param4, int* param5, XCharStruct* param6);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XTextExtents16(XFontStruct* param0, [NativeTypeName("const XChar2b *")] XChar2b* param1, int param2, int* param3, int* param4, int* param5, XCharStruct* param6);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XTextWidth(XFontStruct* param0, [NativeTypeName("const char *")] sbyte* param1, int param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XTextWidth16(XFontStruct* param0, [NativeTypeName("const XChar2b *")] XChar2b* param1, int param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XTranslateCoordinates(Display* param0, Window param1, Window param2, int param3, int param4, int* param5, int* param6, Window* param7);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XUndefineCursor(Display* param0, Window param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XUngrabButton(Display* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("unsigned int")] uint param2, Window param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XUngrabKey(Display* param0, int param1, [NativeTypeName("unsigned int")] uint param2, Window param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XUngrabKeyboard(Display* param0, Time param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XUngrabPointer(Display* param0, Time param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XUngrabServer(Display* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XUninstallColormap(Display* param0, Colormap param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XUnloadFont(Display* param0, Font param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XUnmapSubwindows(Display* param0, Window param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XUnmapWindow(Display* param0, Window param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XVendorRelease(Display* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XWarpPointer(Display* param0, Window param1, Window param2, int param3, int param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned int")] uint param6, int param7, int param8);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XWidthMMOfScreen(Screen* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XWidthOfScreen(Screen* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XWindowEvent(Display* param0, Window param1, [NativeTypeName("long")] nint param2, XEvent* param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XWriteBitmapFile(Display* param0, [NativeTypeName("const char *")] sbyte* param1, Pixmap param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int")] uint param4, int param5, int param6);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XSupportsLocale();

    [DllImport("libX11", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* XSetLocaleModifiers([NativeTypeName("const char *")] sbyte* param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern XOM XOpenOM(Display* param0, [NativeTypeName("struct _XrmHashBucketRec *")] XrmHashBucket param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("const char *")] sbyte* param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XCloseOM(XOM param0);

    [DllImport("libX11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* XSetOMValues(XOM param0, __arglist);

    [DllImport("libX11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* XGetOMValues(XOM param0, __arglist);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern Display* XDisplayOfOM(XOM param0);

    [DllImport("libX11", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* XLocaleOfOM(XOM param0);

    [DllImport("libX11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern XOC XCreateOC(XOM param0, __arglist);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern void XDestroyOC(XOC param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern XOM XOMOfOC(XOC param0);

    [DllImport("libX11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* XSetOCValues(XOC param0, __arglist);

    [DllImport("libX11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* XGetOCValues(XOC param0, __arglist);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern XFontSet XCreateFontSet(Display* param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("char ***")] sbyte*** param2, int* param3, [NativeTypeName("char **")] sbyte** param4);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern void XFreeFontSet(Display* param0, XFontSet param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XFontsOfFontSet(XFontSet param0, XFontStruct*** param1, [NativeTypeName("char ***")] sbyte*** param2);

    [DllImport("libX11", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* XBaseFontNameListOfFontSet(XFontSet param0);

    [DllImport("libX11", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* XLocaleOfFontSet(XFontSet param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XContextDependentDrawing(XFontSet param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XDirectionalDependentDrawing(XFontSet param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XContextualDrawing(XFontSet param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern XFontSetExtents* XExtentsOfFontSet(XFontSet param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XmbTextEscapement(XFontSet param0, [NativeTypeName("const char *")] sbyte* param1, int param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XwcTextEscapement(XFontSet param0, [NativeTypeName("const wchar_t *")] uint* param1, int param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int Xutf8TextEscapement(XFontSet param0, [NativeTypeName("const char *")] sbyte* param1, int param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XmbTextExtents(XFontSet param0, [NativeTypeName("const char *")] sbyte* param1, int param2, XRectangle* param3, XRectangle* param4);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XwcTextExtents(XFontSet param0, [NativeTypeName("const wchar_t *")] uint* param1, int param2, XRectangle* param3, XRectangle* param4);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int Xutf8TextExtents(XFontSet param0, [NativeTypeName("const char *")] sbyte* param1, int param2, XRectangle* param3, XRectangle* param4);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XmbTextPerCharExtents(XFontSet param0, [NativeTypeName("const char *")] sbyte* param1, int param2, XRectangle* param3, XRectangle* param4, int param5, int* param6, XRectangle* param7, XRectangle* param8);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XwcTextPerCharExtents(XFontSet param0, [NativeTypeName("const wchar_t *")] uint* param1, int param2, XRectangle* param3, XRectangle* param4, int param5, int* param6, XRectangle* param7, XRectangle* param8);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int Xutf8TextPerCharExtents(XFontSet param0, [NativeTypeName("const char *")] sbyte* param1, int param2, XRectangle* param3, XRectangle* param4, int param5, int* param6, XRectangle* param7, XRectangle* param8);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern void XmbDrawText(Display* param0, Drawable param1, GC param2, int param3, int param4, XmbTextItem* param5, int param6);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern void XwcDrawText(Display* param0, Drawable param1, GC param2, int param3, int param4, XwcTextItem* param5, int param6);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern void Xutf8DrawText(Display* param0, Drawable param1, GC param2, int param3, int param4, XmbTextItem* param5, int param6);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern void XmbDrawString(Display* param0, Drawable param1, XFontSet param2, GC param3, int param4, int param5, [NativeTypeName("const char *")] sbyte* param6, int param7);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern void XwcDrawString(Display* param0, Drawable param1, XFontSet param2, GC param3, int param4, int param5, [NativeTypeName("const wchar_t *")] uint* param6, int param7);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern void Xutf8DrawString(Display* param0, Drawable param1, XFontSet param2, GC param3, int param4, int param5, [NativeTypeName("const char *")] sbyte* param6, int param7);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern void XmbDrawImageString(Display* param0, Drawable param1, XFontSet param2, GC param3, int param4, int param5, [NativeTypeName("const char *")] sbyte* param6, int param7);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern void XwcDrawImageString(Display* param0, Drawable param1, XFontSet param2, GC param3, int param4, int param5, [NativeTypeName("const wchar_t *")] uint* param6, int param7);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern void Xutf8DrawImageString(Display* param0, Drawable param1, XFontSet param2, GC param3, int param4, int param5, [NativeTypeName("const char *")] sbyte* param6, int param7);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern XIM XOpenIM(Display* param0, [NativeTypeName("struct _XrmHashBucketRec *")] XrmHashBucket param1, [NativeTypeName("char *")] sbyte* param2, [NativeTypeName("char *")] sbyte* param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XCloseIM(XIM param0);

    [DllImport("libX11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* XGetIMValues(XIM param0, __arglist);

    [DllImport("libX11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* XSetIMValues(XIM param0, __arglist);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern Display* XDisplayOfIM(XIM param0);

    [DllImport("libX11", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* XLocaleOfIM(XIM param0);

    [DllImport("libX11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern XIC XCreateIC(XIM param0, __arglist);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern void XDestroyIC(XIC param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern void XSetICFocus(XIC param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern void XUnsetICFocus(XIC param0);

    [DllImport("libX11", ExactSpelling = true)]
    [return: NativeTypeName("wchar_t *")]
    public static extern uint* XwcResetIC(XIC param0);

    [DllImport("libX11", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* XmbResetIC(XIC param0);

    [DllImport("libX11", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* Xutf8ResetIC(XIC param0);

    [DllImport("libX11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* XSetICValues(XIC param0, __arglist);

    [DllImport("libX11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* XGetICValues(XIC param0, __arglist);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern XIM XIMOfIC(XIC param0);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XFilterEvent(XEvent* param0, Window param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XmbLookupString(XIC param0, [NativeTypeName("XKeyPressedEvent *")] XKeyEvent* param1, [NativeTypeName("char *")] sbyte* param2, int param3, KeySym* param4, int* param5);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XwcLookupString(XIC param0, [NativeTypeName("XKeyPressedEvent *")] XKeyEvent* param1, [NativeTypeName("wchar_t *")] uint* param2, int param3, KeySym* param4, int* param5);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int Xutf8LookupString(XIC param0, [NativeTypeName("XKeyPressedEvent *")] XKeyEvent* param1, [NativeTypeName("char *")] sbyte* param2, int param3, KeySym* param4, int* param5);

    [DllImport("libX11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("XVaNestedList")]
    public static extern void* XVaCreateNestedList(int param0, __arglist);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XRegisterIMInstantiateCallback(Display* param0, [NativeTypeName("struct _XrmHashBucketRec *")] XrmHashBucket param1, [NativeTypeName("char *")] sbyte* param2, [NativeTypeName("char *")] sbyte* param3, [NativeTypeName("XIDProc")] delegate* unmanaged<Display*, sbyte*, sbyte*, void> param4, [NativeTypeName("XPointer")] sbyte* param5);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XUnregisterIMInstantiateCallback(Display* param0, [NativeTypeName("struct _XrmHashBucketRec *")] XrmHashBucket param1, [NativeTypeName("char *")] sbyte* param2, [NativeTypeName("char *")] sbyte* param3, [NativeTypeName("XIDProc")] delegate* unmanaged<Display*, sbyte*, sbyte*, void> param4, [NativeTypeName("XPointer")] sbyte* param5);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XInternalConnectionNumbers(Display* param0, int** param1, int* param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern void XProcessInternalConnection(Display* param0, int param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XAddConnectionWatch(Display* param0, [NativeTypeName("XConnectionWatchProc")] delegate* unmanaged<Display*, sbyte*, int, int, sbyte**, void> param1, [NativeTypeName("XPointer")] sbyte* param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern void XRemoveConnectionWatch(Display* param0, [NativeTypeName("XConnectionWatchProc")] delegate* unmanaged<Display*, sbyte*, int, int, sbyte**, void> param1, [NativeTypeName("XPointer")] sbyte* param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern void XSetAuthorization([NativeTypeName("char *")] sbyte* param0, int param1, [NativeTypeName("char *")] sbyte* param2, int param3);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int _Xmbtowc([NativeTypeName("wchar_t *")] uint* param0, [NativeTypeName("char *")] sbyte* param1, int param2);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int _Xwctomb([NativeTypeName("char *")] sbyte* param0, [NativeTypeName("wchar_t")] uint param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern int XGetEventData(Display* param0, XGenericEventCookie* param1);

    [DllImport("libX11", ExactSpelling = true)]
    public static extern void XFreeEventData(Display* param0, XGenericEventCookie* param1);

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

    [NativeTypeName("#define XNRequiredCharSet \"requiredCharSet\"")]
    public static ReadOnlySpan<byte> XNRequiredCharSet => "requiredCharSet"u8;

    [NativeTypeName("#define XNQueryOrientation \"queryOrientation\"")]
    public static ReadOnlySpan<byte> XNQueryOrientation => "queryOrientation"u8;

    [NativeTypeName("#define XNBaseFontName \"baseFontName\"")]
    public static ReadOnlySpan<byte> XNBaseFontName => "baseFontName"u8;

    [NativeTypeName("#define XNOMAutomatic \"omAutomatic\"")]
    public static ReadOnlySpan<byte> XNOMAutomatic => "omAutomatic"u8;

    [NativeTypeName("#define XNMissingCharSet \"missingCharSet\"")]
    public static ReadOnlySpan<byte> XNMissingCharSet => "missingCharSet"u8;

    [NativeTypeName("#define XNDefaultString \"defaultString\"")]
    public static ReadOnlySpan<byte> XNDefaultString => "defaultString"u8;

    [NativeTypeName("#define XNOrientation \"orientation\"")]
    public static ReadOnlySpan<byte> XNOrientation => "orientation"u8;

    [NativeTypeName("#define XNDirectionalDependentDrawing \"directionalDependentDrawing\"")]
    public static ReadOnlySpan<byte> XNDirectionalDependentDrawing => "directionalDependentDrawing"u8;

    [NativeTypeName("#define XNContextualDrawing \"contextualDrawing\"")]
    public static ReadOnlySpan<byte> XNContextualDrawing => "contextualDrawing"u8;

    [NativeTypeName("#define XNFontInfo \"fontInfo\"")]
    public static ReadOnlySpan<byte> XNFontInfo => "fontInfo"u8;

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
    public static ReadOnlySpan<byte> XNVaNestedList => "XNVaNestedList"u8;

    [NativeTypeName("#define XNQueryInputStyle \"queryInputStyle\"")]
    public static ReadOnlySpan<byte> XNQueryInputStyle => "queryInputStyle"u8;

    [NativeTypeName("#define XNClientWindow \"clientWindow\"")]
    public static ReadOnlySpan<byte> XNClientWindow => "clientWindow"u8;

    [NativeTypeName("#define XNInputStyle \"inputStyle\"")]
    public static ReadOnlySpan<byte> XNInputStyle => "inputStyle"u8;

    [NativeTypeName("#define XNFocusWindow \"focusWindow\"")]
    public static ReadOnlySpan<byte> XNFocusWindow => "focusWindow"u8;

    [NativeTypeName("#define XNResourceName \"resourceName\"")]
    public static ReadOnlySpan<byte> XNResourceName => "resourceName"u8;

    [NativeTypeName("#define XNResourceClass \"resourceClass\"")]
    public static ReadOnlySpan<byte> XNResourceClass => "resourceClass"u8;

    [NativeTypeName("#define XNGeometryCallback \"geometryCallback\"")]
    public static ReadOnlySpan<byte> XNGeometryCallback => "geometryCallback"u8;

    [NativeTypeName("#define XNDestroyCallback \"destroyCallback\"")]
    public static ReadOnlySpan<byte> XNDestroyCallback => "destroyCallback"u8;

    [NativeTypeName("#define XNFilterEvents \"filterEvents\"")]
    public static ReadOnlySpan<byte> XNFilterEvents => "filterEvents"u8;

    [NativeTypeName("#define XNPreeditStartCallback \"preeditStartCallback\"")]
    public static ReadOnlySpan<byte> XNPreeditStartCallback => "preeditStartCallback"u8;

    [NativeTypeName("#define XNPreeditDoneCallback \"preeditDoneCallback\"")]
    public static ReadOnlySpan<byte> XNPreeditDoneCallback => "preeditDoneCallback"u8;

    [NativeTypeName("#define XNPreeditDrawCallback \"preeditDrawCallback\"")]
    public static ReadOnlySpan<byte> XNPreeditDrawCallback => "preeditDrawCallback"u8;

    [NativeTypeName("#define XNPreeditCaretCallback \"preeditCaretCallback\"")]
    public static ReadOnlySpan<byte> XNPreeditCaretCallback => "preeditCaretCallback"u8;

    [NativeTypeName("#define XNPreeditStateNotifyCallback \"preeditStateNotifyCallback\"")]
    public static ReadOnlySpan<byte> XNPreeditStateNotifyCallback => "preeditStateNotifyCallback"u8;

    [NativeTypeName("#define XNPreeditAttributes \"preeditAttributes\"")]
    public static ReadOnlySpan<byte> XNPreeditAttributes => "preeditAttributes"u8;

    [NativeTypeName("#define XNStatusStartCallback \"statusStartCallback\"")]
    public static ReadOnlySpan<byte> XNStatusStartCallback => "statusStartCallback"u8;

    [NativeTypeName("#define XNStatusDoneCallback \"statusDoneCallback\"")]
    public static ReadOnlySpan<byte> XNStatusDoneCallback => "statusDoneCallback"u8;

    [NativeTypeName("#define XNStatusDrawCallback \"statusDrawCallback\"")]
    public static ReadOnlySpan<byte> XNStatusDrawCallback => "statusDrawCallback"u8;

    [NativeTypeName("#define XNStatusAttributes \"statusAttributes\"")]
    public static ReadOnlySpan<byte> XNStatusAttributes => "statusAttributes"u8;

    [NativeTypeName("#define XNArea \"area\"")]
    public static ReadOnlySpan<byte> XNArea => "area"u8;

    [NativeTypeName("#define XNAreaNeeded \"areaNeeded\"")]
    public static ReadOnlySpan<byte> XNAreaNeeded => "areaNeeded"u8;

    [NativeTypeName("#define XNSpotLocation \"spotLocation\"")]
    public static ReadOnlySpan<byte> XNSpotLocation => "spotLocation"u8;

    [NativeTypeName("#define XNColormap \"colorMap\"")]
    public static ReadOnlySpan<byte> XNColormap => "colorMap"u8;

    [NativeTypeName("#define XNStdColormap \"stdColorMap\"")]
    public static ReadOnlySpan<byte> XNStdColormap => "stdColorMap"u8;

    [NativeTypeName("#define XNForeground \"foreground\"")]
    public static ReadOnlySpan<byte> XNForeground => "foreground"u8;

    [NativeTypeName("#define XNBackground \"background\"")]
    public static ReadOnlySpan<byte> XNBackground => "background"u8;

    [NativeTypeName("#define XNBackgroundPixmap \"backgroundPixmap\"")]
    public static ReadOnlySpan<byte> XNBackgroundPixmap => "backgroundPixmap"u8;

    [NativeTypeName("#define XNFontSet \"fontSet\"")]
    public static ReadOnlySpan<byte> XNFontSet => "fontSet"u8;

    [NativeTypeName("#define XNLineSpace \"lineSpace\"")]
    public static ReadOnlySpan<byte> XNLineSpace => "lineSpace"u8;

    [NativeTypeName("#define XNCursor \"cursor\"")]
    public static ReadOnlySpan<byte> XNCursor => "cursor"u8;

    [NativeTypeName("#define XNQueryIMValuesList \"queryIMValuesList\"")]
    public static ReadOnlySpan<byte> XNQueryIMValuesList => "queryIMValuesList"u8;

    [NativeTypeName("#define XNQueryICValuesList \"queryICValuesList\"")]
    public static ReadOnlySpan<byte> XNQueryICValuesList => "queryICValuesList"u8;

    [NativeTypeName("#define XNVisiblePosition \"visiblePosition\"")]
    public static ReadOnlySpan<byte> XNVisiblePosition => "visiblePosition"u8;

    [NativeTypeName("#define XNR6PreeditCallback \"r6PreeditCallback\"")]
    public static ReadOnlySpan<byte> XNR6PreeditCallback => "r6PreeditCallback"u8;

    [NativeTypeName("#define XNStringConversionCallback \"stringConversionCallback\"")]
    public static ReadOnlySpan<byte> XNStringConversionCallback => "stringConversionCallback"u8;

    [NativeTypeName("#define XNStringConversion \"stringConversion\"")]
    public static ReadOnlySpan<byte> XNStringConversion => "stringConversion"u8;

    [NativeTypeName("#define XNResetState \"resetState\"")]
    public static ReadOnlySpan<byte> XNResetState => "resetState"u8;

    [NativeTypeName("#define XNHotKey \"hotKey\"")]
    public static ReadOnlySpan<byte> XNHotKey => "hotKey"u8;

    [NativeTypeName("#define XNHotKeyState \"hotKeyState\"")]
    public static ReadOnlySpan<byte> XNHotKeyState => "hotKeyState"u8;

    [NativeTypeName("#define XNPreeditState \"preeditState\"")]
    public static ReadOnlySpan<byte> XNPreeditState => "preeditState"u8;

    [NativeTypeName("#define XNSeparatorofNestedList \"separatorofNestedList\"")]
    public static ReadOnlySpan<byte> XNSeparatorofNestedList => "separatorofNestedList"u8;

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
