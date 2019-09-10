// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\Xutil.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group and Digital Equipment Corporation, Maynard, Massachusetts.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Xlib
    {
        [DllImport(libraryPath, EntryPoint = "XAllocClassHint", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XClassHint *")]
        public static extern XClassHint* XAllocClassHint();

        [DllImport(libraryPath, EntryPoint = "XAllocIconSize", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XIconSize *")]
        public static extern XIconSize* XAllocIconSize();

        [DllImport(libraryPath, EntryPoint = "XAllocSizeHints", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XSizeHints *")]
        public static extern XSizeHints* XAllocSizeHints();

        [DllImport(libraryPath, EntryPoint = "XAllocStandardColormap", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XStandardColormap *")]
        public static extern XStandardColormap* XAllocStandardColormap();

        [DllImport(libraryPath, EntryPoint = "XAllocWMHints", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XWMHints *")]
        public static extern XWMHints* XAllocWMHints();

        [DllImport(libraryPath, EntryPoint = "XClipBox", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XClipBox([NativeTypeName("Region")] XRegion* param0, [NativeTypeName("XRectangle *")] XRectangle* param1);

        [DllImport(libraryPath, EntryPoint = "XCreateRegion", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Region")]
        public static extern XRegion* XCreateRegion();

        [DllImport(libraryPath, EntryPoint = "XDefaultString", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* XDefaultString();

        [DllImport(libraryPath, EntryPoint = "XDeleteContext", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDeleteContext([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("XID")] UIntPtr param1, [NativeTypeName("XContext")] int param2);

        [DllImport(libraryPath, EntryPoint = "XDestroyRegion", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDestroyRegion([NativeTypeName("Region")] XRegion* param0);

        [DllImport(libraryPath, EntryPoint = "XEmptyRegion", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XEmptyRegion([NativeTypeName("Region")] XRegion* param0);

        [DllImport(libraryPath, EntryPoint = "XEqualRegion", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XEqualRegion([NativeTypeName("Region")] XRegion* param0, [NativeTypeName("Region")] XRegion* param1);

        [DllImport(libraryPath, EntryPoint = "XFindContext", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XFindContext([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("XID")] UIntPtr param1, [NativeTypeName("XContext")] int param2, [NativeTypeName("XPointer *")] sbyte** param3);

        [DllImport(libraryPath, EntryPoint = "XGetClassHint", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetClassHint([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("XClassHint *")] XClassHint* param2);

        [DllImport(libraryPath, EntryPoint = "XGetIconSizes", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetIconSizes([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("XIconSize **")] XIconSize** param2, [NativeTypeName("int *")] int* param3);

        [DllImport(libraryPath, EntryPoint = "XGetNormalHints", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetNormalHints([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("XSizeHints *")] XSizeHints* param2);

        [DllImport(libraryPath, EntryPoint = "XGetRGBColormaps", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetRGBColormaps([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("XStandardColormap **")] XStandardColormap** param2, [NativeTypeName("int *")] int* param3, [NativeTypeName("Atom")] UIntPtr param4);

        [DllImport(libraryPath, EntryPoint = "XGetSizeHints", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetSizeHints([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("XSizeHints *")] XSizeHints* param2, [NativeTypeName("Atom")] UIntPtr param3);

        [DllImport(libraryPath, EntryPoint = "XGetStandardColormap", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetStandardColormap([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("XStandardColormap *")] XStandardColormap* param2, [NativeTypeName("Atom")] UIntPtr param3);

        [DllImport(libraryPath, EntryPoint = "XGetTextProperty", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetTextProperty([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("XTextProperty *")] XTextProperty* param2, [NativeTypeName("Atom")] UIntPtr param3);

        [DllImport(libraryPath, EntryPoint = "XGetVisualInfo", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XVisualInfo *")]
        public static extern XVisualInfo* XGetVisualInfo([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("long")] IntPtr param1, [NativeTypeName("XVisualInfo *")] XVisualInfo* param2, [NativeTypeName("int *")] int* param3);

        [DllImport(libraryPath, EntryPoint = "XGetWMClientMachine", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetWMClientMachine([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("XTextProperty *")] XTextProperty* param2);

        [DllImport(libraryPath, EntryPoint = "XGetWMHints", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XWMHints *")]
        public static extern XWMHints* XGetWMHints([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1);

        [DllImport(libraryPath, EntryPoint = "XGetWMIconName", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetWMIconName([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("XTextProperty *")] XTextProperty* param2);

        [DllImport(libraryPath, EntryPoint = "XGetWMName", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetWMName([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("XTextProperty *")] XTextProperty* param2);

        [DllImport(libraryPath, EntryPoint = "XGetWMNormalHints", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetWMNormalHints([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("XSizeHints *")] XSizeHints* param2, [NativeTypeName("long *")] IntPtr* param3);

        [DllImport(libraryPath, EntryPoint = "XGetWMSizeHints", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetWMSizeHints([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("XSizeHints *")] XSizeHints* param2, [NativeTypeName("long *")] IntPtr* param3, [NativeTypeName("Atom")] UIntPtr param4);

        [DllImport(libraryPath, EntryPoint = "XGetZoomHints", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetZoomHints([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("XSizeHints *")] XSizeHints* param2);

        [DllImport(libraryPath, EntryPoint = "XIntersectRegion", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XIntersectRegion([NativeTypeName("Region")] XRegion* param0, [NativeTypeName("Region")] XRegion* param1, [NativeTypeName("Region")] XRegion* param2);

        [DllImport(libraryPath, EntryPoint = "XConvertCase", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XConvertCase([NativeTypeName("KeySym")] UIntPtr param0, [NativeTypeName("KeySym *")] UIntPtr* param1, [NativeTypeName("KeySym *")] UIntPtr* param2);

        [DllImport(libraryPath, EntryPoint = "XLookupString", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XLookupString([NativeTypeName("XKeyEvent *")] XKeyEvent* param0, [NativeTypeName("char *")] sbyte* param1, int param2, [NativeTypeName("KeySym *")] UIntPtr* param3, [NativeTypeName("XComposeStatus *")] XComposeStatus* param4);

        [DllImport(libraryPath, EntryPoint = "XMatchVisualInfo", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XMatchVisualInfo([NativeTypeName("Display *")] XDisplay* param0, int param1, int param2, int param3, [NativeTypeName("XVisualInfo *")] XVisualInfo* param4);

        [DllImport(libraryPath, EntryPoint = "XOffsetRegion", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XOffsetRegion([NativeTypeName("Region")] XRegion* param0, int param1, int param2);

        [DllImport(libraryPath, EntryPoint = "XPointInRegion", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XPointInRegion([NativeTypeName("Region")] XRegion* param0, int param1, int param2);

        [DllImport(libraryPath, EntryPoint = "XPolygonRegion", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Region")]
        public static extern XRegion* XPolygonRegion([NativeTypeName("XPoint *")] XPoint* param0, int param1, int param2);

        [DllImport(libraryPath, EntryPoint = "XRectInRegion", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XRectInRegion([NativeTypeName("Region")] XRegion* param0, int param1, int param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int")] uint param4);

        [DllImport(libraryPath, EntryPoint = "XSaveContext", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSaveContext([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("XID")] UIntPtr param1, [NativeTypeName("XContext")] int param2, [NativeTypeName("const char *")] sbyte* param3);

        [DllImport(libraryPath, EntryPoint = "XSetClassHint", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetClassHint([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("XClassHint *")] XClassHint* param2);

        [DllImport(libraryPath, EntryPoint = "XSetIconSizes", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetIconSizes([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("XIconSize *")] XIconSize* param2, int param3);

        [DllImport(libraryPath, EntryPoint = "XSetNormalHints", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetNormalHints([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("XSizeHints *")] XSizeHints* param2);

        [DllImport(libraryPath, EntryPoint = "XSetRGBColormaps", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XSetRGBColormaps([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("XStandardColormap *")] XStandardColormap* param2, int param3, [NativeTypeName("Atom")] UIntPtr param4);

        [DllImport(libraryPath, EntryPoint = "XSetSizeHints", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetSizeHints([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("XSizeHints *")] XSizeHints* param2, [NativeTypeName("Atom")] UIntPtr param3);

        [DllImport(libraryPath, EntryPoint = "XSetStandardProperties", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetStandardProperties([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("const char *")] sbyte* param3, [NativeTypeName("Pixmap")] UIntPtr param4, [NativeTypeName("char **")] sbyte** param5, int param6, [NativeTypeName("XSizeHints *")] XSizeHints* param7);

        [DllImport(libraryPath, EntryPoint = "XSetTextProperty", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XSetTextProperty([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("XTextProperty *")] XTextProperty* param2, [NativeTypeName("Atom")] UIntPtr param3);

        [DllImport(libraryPath, EntryPoint = "XSetWMClientMachine", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XSetWMClientMachine([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("XTextProperty *")] XTextProperty* param2);

        [DllImport(libraryPath, EntryPoint = "XSetWMHints", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetWMHints([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("XWMHints *")] XWMHints* param2);

        [DllImport(libraryPath, EntryPoint = "XSetWMIconName", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XSetWMIconName([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("XTextProperty *")] XTextProperty* param2);

        [DllImport(libraryPath, EntryPoint = "XSetWMName", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XSetWMName([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("XTextProperty *")] XTextProperty* param2);

        [DllImport(libraryPath, EntryPoint = "XSetWMNormalHints", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XSetWMNormalHints([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("XSizeHints *")] XSizeHints* param2);

        [DllImport(libraryPath, EntryPoint = "XSetWMProperties", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XSetWMProperties([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("XTextProperty *")] XTextProperty* param2, [NativeTypeName("XTextProperty *")] XTextProperty* param3, [NativeTypeName("char **")] sbyte** param4, int param5, [NativeTypeName("XSizeHints *")] XSizeHints* param6, [NativeTypeName("XWMHints *")] XWMHints* param7, [NativeTypeName("XClassHint *")] XClassHint* param8);

        [DllImport(libraryPath, EntryPoint = "XmbSetWMProperties", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XmbSetWMProperties([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("const char *")] sbyte* param3, [NativeTypeName("char **")] sbyte** param4, int param5, [NativeTypeName("XSizeHints *")] XSizeHints* param6, [NativeTypeName("XWMHints *")] XWMHints* param7, [NativeTypeName("XClassHint *")] XClassHint* param8);

        [DllImport(libraryPath, EntryPoint = "Xutf8SetWMProperties", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Xutf8SetWMProperties([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("const char *")] sbyte* param3, [NativeTypeName("char **")] sbyte** param4, int param5, [NativeTypeName("XSizeHints *")] XSizeHints* param6, [NativeTypeName("XWMHints *")] XWMHints* param7, [NativeTypeName("XClassHint *")] XClassHint* param8);

        [DllImport(libraryPath, EntryPoint = "XSetWMSizeHints", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XSetWMSizeHints([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("XSizeHints *")] XSizeHints* param2, [NativeTypeName("Atom")] UIntPtr param3);

        [DllImport(libraryPath, EntryPoint = "XSetRegion", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetRegion([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("GC")] XGC* param1, [NativeTypeName("Region")] XRegion* param2);

        [DllImport(libraryPath, EntryPoint = "XSetStandardColormap", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XSetStandardColormap([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("XStandardColormap *")] XStandardColormap* param2, [NativeTypeName("Atom")] UIntPtr param3);

        [DllImport(libraryPath, EntryPoint = "XSetZoomHints", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetZoomHints([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1, [NativeTypeName("XSizeHints *")] XSizeHints* param2);

        [DllImport(libraryPath, EntryPoint = "XShrinkRegion", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XShrinkRegion([NativeTypeName("Region")] XRegion* param0, int param1, int param2);

        [DllImport(libraryPath, EntryPoint = "XStringListToTextProperty", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XStringListToTextProperty([NativeTypeName("char **")] sbyte** param0, int param1, [NativeTypeName("XTextProperty *")] XTextProperty* param2);

        [DllImport(libraryPath, EntryPoint = "XSubtractRegion", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSubtractRegion([NativeTypeName("Region")] XRegion* param0, [NativeTypeName("Region")] XRegion* param1, [NativeTypeName("Region")] XRegion* param2);

        [DllImport(libraryPath, EntryPoint = "XmbTextListToTextProperty", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XmbTextListToTextProperty([NativeTypeName("Display *")] XDisplay* display, [NativeTypeName("char **")] sbyte** list, int count, XICCEncodingStyle style, [NativeTypeName("XTextProperty *")] XTextProperty* text_prop_return);

        [DllImport(libraryPath, EntryPoint = "XwcTextListToTextProperty", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XwcTextListToTextProperty([NativeTypeName("Display *")] XDisplay* display, [NativeTypeName("wchar_t **")] int** list, int count, XICCEncodingStyle style, [NativeTypeName("XTextProperty *")] XTextProperty* text_prop_return);

        [DllImport(libraryPath, EntryPoint = "Xutf8TextListToTextProperty", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Xutf8TextListToTextProperty([NativeTypeName("Display *")] XDisplay* display, [NativeTypeName("char **")] sbyte** list, int count, XICCEncodingStyle style, [NativeTypeName("XTextProperty *")] XTextProperty* text_prop_return);

        [DllImport(libraryPath, EntryPoint = "XwcFreeStringList", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XwcFreeStringList([NativeTypeName("wchar_t **")] int** list);

        [DllImport(libraryPath, EntryPoint = "XTextPropertyToStringList", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XTextPropertyToStringList([NativeTypeName("XTextProperty *")] XTextProperty* param0, [NativeTypeName("char ***")] sbyte*** param1, [NativeTypeName("int *")] int* param2);

        [DllImport(libraryPath, EntryPoint = "XmbTextPropertyToTextList", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XmbTextPropertyToTextList([NativeTypeName("Display *")] XDisplay* display, [NativeTypeName("const XTextProperty *")] XTextProperty* text_prop, [NativeTypeName("char ***")] sbyte*** list_return, [NativeTypeName("int *")] int* count_return);

        [DllImport(libraryPath, EntryPoint = "XwcTextPropertyToTextList", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XwcTextPropertyToTextList([NativeTypeName("Display *")] XDisplay* display, [NativeTypeName("const XTextProperty *")] XTextProperty* text_prop, [NativeTypeName("wchar_t ***")] int*** list_return, [NativeTypeName("int *")] int* count_return);

        [DllImport(libraryPath, EntryPoint = "Xutf8TextPropertyToTextList", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Xutf8TextPropertyToTextList([NativeTypeName("Display *")] XDisplay* display, [NativeTypeName("const XTextProperty *")] XTextProperty* text_prop, [NativeTypeName("char ***")] sbyte*** list_return, [NativeTypeName("int *")] int* count_return);

        [DllImport(libraryPath, EntryPoint = "XUnionRectWithRegion", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XUnionRectWithRegion([NativeTypeName("XRectangle *")] XRectangle* param0, [NativeTypeName("Region")] XRegion* param1, [NativeTypeName("Region")] XRegion* param2);

        [DllImport(libraryPath, EntryPoint = "XUnionRegion", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XUnionRegion([NativeTypeName("Region")] XRegion* param0, [NativeTypeName("Region")] XRegion* param1, [NativeTypeName("Region")] XRegion* param2);

        [DllImport(libraryPath, EntryPoint = "XWMGeometry", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XWMGeometry([NativeTypeName("Display *")] XDisplay* param0, int param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("const char *")] sbyte* param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("XSizeHints *")] XSizeHints* param5, [NativeTypeName("int *")] int* param6, [NativeTypeName("int *")] int* param7, [NativeTypeName("int *")] int* param8, [NativeTypeName("int *")] int* param9, [NativeTypeName("int *")] int* param10);

        [DllImport(libraryPath, EntryPoint = "XXorRegion", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XXorRegion([NativeTypeName("Region")] XRegion* param0, [NativeTypeName("Region")] XRegion* param1, [NativeTypeName("Region")] XRegion* param2);
    }
}
