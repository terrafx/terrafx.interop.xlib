// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xutil.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Xlib
    {
        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("XClassHint *")]
        public static extern XClassHint* XAllocClassHint();

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("XIconSize *")]
        public static extern XIconSize* XAllocIconSize();

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("XSizeHints *")]
        public static extern XSizeHints* XAllocSizeHints();

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("XStandardColormap *")]
        public static extern XStandardColormap* XAllocStandardColormap();

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("XWMHints *")]
        public static extern XWMHints* XAllocWMHints();

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XClipBox([NativeTypeName("Region")] IntPtr param0, [NativeTypeName("XRectangle *")] XRectangle* param1);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("Region")]
        public static extern IntPtr XCreateRegion();

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* XDefaultString();

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XDeleteContext([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("XID")] nuint param1, [NativeTypeName("XContext")] int param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XDestroyRegion([NativeTypeName("Region")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XEmptyRegion([NativeTypeName("Region")] IntPtr param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XEqualRegion([NativeTypeName("Region")] IntPtr param0, [NativeTypeName("Region")] IntPtr param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XFindContext([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("XID")] nuint param1, [NativeTypeName("XContext")] int param2, [NativeTypeName("XPointer *")] sbyte** param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XGetClassHint([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("XClassHint *")] XClassHint* param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XGetIconSizes([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("XIconSize **")] XIconSize** param2, [NativeTypeName("int *")] int* param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XGetNormalHints([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("XSizeHints *")] XSizeHints* param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XGetRGBColormaps([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("XStandardColormap **")] XStandardColormap** param2, [NativeTypeName("int *")] int* param3, [NativeTypeName("Atom")] nuint param4);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XGetSizeHints([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("XSizeHints *")] XSizeHints* param2, [NativeTypeName("Atom")] nuint param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XGetStandardColormap([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("XStandardColormap *")] XStandardColormap* param2, [NativeTypeName("Atom")] nuint param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XGetTextProperty([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("XTextProperty *")] XTextProperty* param2, [NativeTypeName("Atom")] nuint param3);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("XVisualInfo *")]
        public static extern XVisualInfo* XGetVisualInfo([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("long")] nint param1, [NativeTypeName("XVisualInfo *")] XVisualInfo* param2, [NativeTypeName("int *")] int* param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XGetWMClientMachine([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("XTextProperty *")] XTextProperty* param2);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("XWMHints *")]
        public static extern XWMHints* XGetWMHints([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XGetWMIconName([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("XTextProperty *")] XTextProperty* param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XGetWMName([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("XTextProperty *")] XTextProperty* param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XGetWMNormalHints([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("XSizeHints *")] XSizeHints* param2, [NativeTypeName("long *")] nint* param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XGetWMSizeHints([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("XSizeHints *")] XSizeHints* param2, [NativeTypeName("long *")] nint* param3, [NativeTypeName("Atom")] nuint param4);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XGetZoomHints([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("XSizeHints *")] XSizeHints* param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XIntersectRegion([NativeTypeName("Region")] IntPtr param0, [NativeTypeName("Region")] IntPtr param1, [NativeTypeName("Region")] IntPtr param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern void XConvertCase([NativeTypeName("KeySym")] nuint param0, [NativeTypeName("KeySym *")] nuint* param1, [NativeTypeName("KeySym *")] nuint* param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XLookupString([NativeTypeName("XKeyEvent *")] XKeyEvent* param0, [NativeTypeName("char *")] sbyte* param1, int param2, [NativeTypeName("KeySym *")] nuint* param3, [NativeTypeName("XComposeStatus *")] XComposeStatus* param4);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XMatchVisualInfo([NativeTypeName("Display *")] IntPtr param0, int param1, int param2, int param3, [NativeTypeName("XVisualInfo *")] XVisualInfo* param4);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XOffsetRegion([NativeTypeName("Region")] IntPtr param0, int param1, int param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XPointInRegion([NativeTypeName("Region")] IntPtr param0, int param1, int param2);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("Region")]
        public static extern IntPtr XPolygonRegion([NativeTypeName("XPoint *")] XPoint* param0, int param1, int param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XRectInRegion([NativeTypeName("Region")] IntPtr param0, int param1, int param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int")] uint param4);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSaveContext([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("XID")] nuint param1, [NativeTypeName("XContext")] int param2, [NativeTypeName("const char *")] sbyte* param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSetClassHint([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("XClassHint *")] XClassHint* param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSetIconSizes([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("XIconSize *")] XIconSize* param2, int param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSetNormalHints([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("XSizeHints *")] XSizeHints* param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern void XSetRGBColormaps([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("XStandardColormap *")] XStandardColormap* param2, int param3, [NativeTypeName("Atom")] nuint param4);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSetSizeHints([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("XSizeHints *")] XSizeHints* param2, [NativeTypeName("Atom")] nuint param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSetStandardProperties([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("const char *")] sbyte* param3, [NativeTypeName("Pixmap")] nuint param4, [NativeTypeName("char **")] sbyte** param5, int param6, [NativeTypeName("XSizeHints *")] XSizeHints* param7);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern void XSetTextProperty([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("XTextProperty *")] XTextProperty* param2, [NativeTypeName("Atom")] nuint param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern void XSetWMClientMachine([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("XTextProperty *")] XTextProperty* param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSetWMHints([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("XWMHints *")] XWMHints* param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern void XSetWMIconName([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("XTextProperty *")] XTextProperty* param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern void XSetWMName([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("XTextProperty *")] XTextProperty* param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern void XSetWMNormalHints([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("XSizeHints *")] XSizeHints* param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern void XSetWMProperties([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("XTextProperty *")] XTextProperty* param2, [NativeTypeName("XTextProperty *")] XTextProperty* param3, [NativeTypeName("char **")] sbyte** param4, int param5, [NativeTypeName("XSizeHints *")] XSizeHints* param6, [NativeTypeName("XWMHints *")] XWMHints* param7, [NativeTypeName("XClassHint *")] XClassHint* param8);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern void XmbSetWMProperties([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("const char *")] sbyte* param3, [NativeTypeName("char **")] sbyte** param4, int param5, [NativeTypeName("XSizeHints *")] XSizeHints* param6, [NativeTypeName("XWMHints *")] XWMHints* param7, [NativeTypeName("XClassHint *")] XClassHint* param8);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern void Xutf8SetWMProperties([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("const char *")] sbyte* param3, [NativeTypeName("char **")] sbyte** param4, int param5, [NativeTypeName("XSizeHints *")] XSizeHints* param6, [NativeTypeName("XWMHints *")] XWMHints* param7, [NativeTypeName("XClassHint *")] XClassHint* param8);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern void XSetWMSizeHints([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("XSizeHints *")] XSizeHints* param2, [NativeTypeName("Atom")] nuint param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSetRegion([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("GC")] IntPtr param1, [NativeTypeName("Region")] IntPtr param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern void XSetStandardColormap([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("XStandardColormap *")] XStandardColormap* param2, [NativeTypeName("Atom")] nuint param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSetZoomHints([NativeTypeName("Display *")] IntPtr param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("XSizeHints *")] XSizeHints* param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XShrinkRegion([NativeTypeName("Region")] IntPtr param0, int param1, int param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XStringListToTextProperty([NativeTypeName("char **")] sbyte** param0, int param1, [NativeTypeName("XTextProperty *")] XTextProperty* param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XSubtractRegion([NativeTypeName("Region")] IntPtr param0, [NativeTypeName("Region")] IntPtr param1, [NativeTypeName("Region")] IntPtr param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XmbTextListToTextProperty([NativeTypeName("Display *")] IntPtr display, [NativeTypeName("char **")] sbyte** list, int count, XICCEncodingStyle style, [NativeTypeName("XTextProperty *")] XTextProperty* text_prop_return);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XwcTextListToTextProperty([NativeTypeName("Display *")] IntPtr display, [NativeTypeName("wchar_t **")] int** list, int count, XICCEncodingStyle style, [NativeTypeName("XTextProperty *")] XTextProperty* text_prop_return);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int Xutf8TextListToTextProperty([NativeTypeName("Display *")] IntPtr display, [NativeTypeName("char **")] sbyte** list, int count, XICCEncodingStyle style, [NativeTypeName("XTextProperty *")] XTextProperty* text_prop_return);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern void XwcFreeStringList([NativeTypeName("wchar_t **")] int** list);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XTextPropertyToStringList([NativeTypeName("XTextProperty *")] XTextProperty* param0, [NativeTypeName("char ***")] sbyte*** param1, [NativeTypeName("int *")] int* param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XmbTextPropertyToTextList([NativeTypeName("Display *")] IntPtr display, [NativeTypeName("const XTextProperty *")] XTextProperty* text_prop, [NativeTypeName("char ***")] sbyte*** list_return, [NativeTypeName("int *")] int* count_return);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XwcTextPropertyToTextList([NativeTypeName("Display *")] IntPtr display, [NativeTypeName("const XTextProperty *")] XTextProperty* text_prop, [NativeTypeName("wchar_t ***")] int*** list_return, [NativeTypeName("int *")] int* count_return);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int Xutf8TextPropertyToTextList([NativeTypeName("Display *")] IntPtr display, [NativeTypeName("const XTextProperty *")] XTextProperty* text_prop, [NativeTypeName("char ***")] sbyte*** list_return, [NativeTypeName("int *")] int* count_return);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XUnionRectWithRegion([NativeTypeName("XRectangle *")] XRectangle* param0, [NativeTypeName("Region")] IntPtr param1, [NativeTypeName("Region")] IntPtr param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XUnionRegion([NativeTypeName("Region")] IntPtr param0, [NativeTypeName("Region")] IntPtr param1, [NativeTypeName("Region")] IntPtr param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XWMGeometry([NativeTypeName("Display *")] IntPtr param0, int param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("const char *")] sbyte* param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("XSizeHints *")] XSizeHints* param5, [NativeTypeName("int *")] int* param6, [NativeTypeName("int *")] int* param7, [NativeTypeName("int *")] int* param8, [NativeTypeName("int *")] int* param9, [NativeTypeName("int *")] int* param10);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XXorRegion([NativeTypeName("Region")] IntPtr param0, [NativeTypeName("Region")] IntPtr param1, [NativeTypeName("Region")] IntPtr param2);
    }
}
