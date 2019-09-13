// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\Xutil.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group and Digital Equipment Corporation, Maynard, Massachusetts.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Xlib
    {
        [DllImport(libraryPath, EntryPoint = "XDestroyImage", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDestroyImage([NativeTypeName("XImage *")] XImage* ximage);

        [DllImport(libraryPath, EntryPoint = "XDestroyImage", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("unsigned long")]
        public static extern UIntPtr XGetPixel([NativeTypeName("XImage *")] XImage* ximage, int x, int y);

        [DllImport(libraryPath, EntryPoint = "XPutPixel", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XPutPixel([NativeTypeName("XImage *")] XImage* ximage, int x, int y, [NativeTypeName("unsigned long")] UIntPtr pixel);

        [DllImport(libraryPath, EntryPoint = "XSubImage", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XImage *")]
        public static extern XImage* XSubImage([NativeTypeName("XImage *")] XImage* ximage, int x, int y, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height);

        [DllImport(libraryPath, EntryPoint = "XAddPixel", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XAddPixel([NativeTypeName("XImage *")] XImage* ximage, [NativeTypeName("long")] IntPtr value);

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
        public static extern int XClipBox([NativeTypeName("Region")] XRegion* r, [NativeTypeName("XRectangle *")] XRectangle* rect_return);

        [DllImport(libraryPath, EntryPoint = "XCreateRegion", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Region")]
        public static extern XRegion* XCreateRegion();

        [DllImport(libraryPath, EntryPoint = "XDefaultString", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* XDefaultString();

        [DllImport(libraryPath, EntryPoint = "XDeleteContext", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDeleteContext([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("XID")] UIntPtr rid, [NativeTypeName("XContext")] int context);

        [DllImport(libraryPath, EntryPoint = "XDestroyRegion", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDestroyRegion([NativeTypeName("Region")] XRegion* r);

        [DllImport(libraryPath, EntryPoint = "XEmptyRegion", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XEmptyRegion([NativeTypeName("Region")] XRegion* r);

        [DllImport(libraryPath, EntryPoint = "XEqualRegion", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XEqualRegion([NativeTypeName("Region")] XRegion* r1, [NativeTypeName("Region")] XRegion* r2);

        [DllImport(libraryPath, EntryPoint = "XFindContext", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XFindContext([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("XID")] UIntPtr rid, [NativeTypeName("XContext")] int context, [NativeTypeName("XPointer *")] sbyte** data_return);

        [DllImport(libraryPath, EntryPoint = "XGetClassHint", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetClassHint([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("XClassHint *")] XClassHint* class_hints_return);

        [DllImport(libraryPath, EntryPoint = "XGetIconSizes", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetIconSizes([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("XIconSize **")] XIconSize** size_list_return, [NativeTypeName("int *")] int* count_return);

        [DllImport(libraryPath, EntryPoint = "XGetNormalHints", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetNormalHints([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("XSizeHints *")] XSizeHints* hints_return);

        [DllImport(libraryPath, EntryPoint = "XGetRGBColormaps", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetRGBColormaps([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("XStandardColormap **")] XStandardColormap** stdcmap_return, [NativeTypeName("int *")] int* count_return, [NativeTypeName("Atom")] UIntPtr property);

        [DllImport(libraryPath, EntryPoint = "XGetSizeHints", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetSizeHints([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("XSizeHints *")] XSizeHints* hints_return, [NativeTypeName("Atom")] UIntPtr property);

        [DllImport(libraryPath, EntryPoint = "XGetStandardColormap", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetStandardColormap([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("XStandardColormap *")] XStandardColormap* colormap_return, [NativeTypeName("Atom")] UIntPtr property);

        [DllImport(libraryPath, EntryPoint = "XGetTextProperty", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetTextProperty([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr window, [NativeTypeName("XTextProperty *")] XTextProperty* text_prop_return, [NativeTypeName("Atom")] UIntPtr property);

        [DllImport(libraryPath, EntryPoint = "XGetVisualInfo", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XVisualInfo *")]
        public static extern XVisualInfo* XGetVisualInfo([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("long")] IntPtr vinfo_mask, [NativeTypeName("XVisualInfo *")] XVisualInfo* vinfo_template, [NativeTypeName("int *")] int* nitems_return);

        [DllImport(libraryPath, EntryPoint = "XGetWMClientMachine", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetWMClientMachine([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("XTextProperty *")] XTextProperty* text_prop_return);

        [DllImport(libraryPath, EntryPoint = "XGetWMHints", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XWMHints *")]
        public static extern XWMHints* XGetWMHints([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w);

        [DllImport(libraryPath, EntryPoint = "XGetWMIconName", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetWMIconName([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("XTextProperty *")] XTextProperty* text_prop_return);

        [DllImport(libraryPath, EntryPoint = "XGetWMName", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetWMName([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("XTextProperty *")] XTextProperty* text_prop_return);

        [DllImport(libraryPath, EntryPoint = "XGetWMNormalHints", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetWMNormalHints([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("XSizeHints *")] XSizeHints* hints_return, [NativeTypeName("long *")] IntPtr* supplied_return);

        [DllImport(libraryPath, EntryPoint = "XGetWMSizeHints", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetWMSizeHints([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("XSizeHints *")] XSizeHints* hints_return, [NativeTypeName("long *")] IntPtr* supplied_return, [NativeTypeName("Atom")] UIntPtr property);

        [DllImport(libraryPath, EntryPoint = "XGetZoomHints", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetZoomHints([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("XSizeHints *")] XSizeHints* zhints_return);

        [DllImport(libraryPath, EntryPoint = "XIntersectRegion", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XIntersectRegion([NativeTypeName("Region")] XRegion* sra, [NativeTypeName("Region")] XRegion* srb, [NativeTypeName("Region")] XRegion* dr_return);

        [DllImport(libraryPath, EntryPoint = "XConvertCase", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XConvertCase([NativeTypeName("KeySym")] UIntPtr sym, [NativeTypeName("KeySym *")] UIntPtr* lower, [NativeTypeName("KeySym *")] UIntPtr* upper);

        [DllImport(libraryPath, EntryPoint = "XLookupString", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XLookupString([NativeTypeName("XKeyEvent *")] XKeyEvent* event_struct, [NativeTypeName("char *")] sbyte* buffer_return, int bytes_buffer, [NativeTypeName("KeySym *")] UIntPtr* keysym_return, [NativeTypeName("XComposeStatus *")] XComposeStatus* status_in_out);

        [DllImport(libraryPath, EntryPoint = "XMatchVisualInfo", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XMatchVisualInfo([NativeTypeName("Display *")] UIntPtr display, int screen, int depth, int c_class, [NativeTypeName("XVisualInfo *")] XVisualInfo* vinfo_return);

        [DllImport(libraryPath, EntryPoint = "XOffsetRegion", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XOffsetRegion([NativeTypeName("Region")] XRegion* r, int dx, int dy);

        [DllImport(libraryPath, EntryPoint = "XPointInRegion", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XPointInRegion([NativeTypeName("Region")] XRegion* r, int x, int y);

        [DllImport(libraryPath, EntryPoint = "XPolygonRegion", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Region")]
        public static extern XRegion* XPolygonRegion([NativeTypeName("XPoint *")] XPoint* points, int n, int fill_rule);

        [DllImport(libraryPath, EntryPoint = "XRectInRegion", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XRectInRegion([NativeTypeName("Region")] XRegion* r, int x, int y, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height);

        [DllImport(libraryPath, EntryPoint = "XSaveContext", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSaveContext([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("XID")] UIntPtr rid, [NativeTypeName("XContext")] int context, [NativeTypeName("const char *")] sbyte* data);

        [DllImport(libraryPath, EntryPoint = "XSetClassHint", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetClassHint([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("XClassHint *")] XClassHint* class_hints);

        [DllImport(libraryPath, EntryPoint = "XSetIconSizes", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetIconSizes([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("XIconSize *")] XIconSize* size_list, int count);

        [DllImport(libraryPath, EntryPoint = "XSetNormalHints", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetNormalHints([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("XSizeHints *")] XSizeHints* hints);

        [DllImport(libraryPath, EntryPoint = "XSetRGBColormaps", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XSetRGBColormaps([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("XStandardColormap *")] XStandardColormap* stdcmaps, int count, [NativeTypeName("Atom")] UIntPtr property);

        [DllImport(libraryPath, EntryPoint = "XSetSizeHints", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetSizeHints([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("XSizeHints *")] XSizeHints* hints, [NativeTypeName("Atom")] UIntPtr property);

        [DllImport(libraryPath, EntryPoint = "XSetStandardProperties", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetStandardProperties([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("const char *")] sbyte* window_name, [NativeTypeName("const char *")] sbyte* icon_name, [NativeTypeName("Pixmap")] UIntPtr icon_pixmap, [NativeTypeName("char **")] sbyte** argv, int argc, [NativeTypeName("XSizeHints *")] XSizeHints* hints);

        [DllImport(libraryPath, EntryPoint = "XSetTextProperty", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XSetTextProperty([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("XTextProperty *")] XTextProperty* text_prop, [NativeTypeName("Atom")] UIntPtr property);

        [DllImport(libraryPath, EntryPoint = "XSetWMClientMachine", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XSetWMClientMachine([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("XTextProperty *")] XTextProperty* text_prop);

        [DllImport(libraryPath, EntryPoint = "XSetWMHints", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetWMHints([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("XWMHints *")] XWMHints* wm_hints);

        [DllImport(libraryPath, EntryPoint = "XSetWMIconName", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XSetWMIconName([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("XTextProperty *")] XTextProperty* text_prop);

        [DllImport(libraryPath, EntryPoint = "XSetWMName", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XSetWMName([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("XTextProperty *")] XTextProperty* text_prop);

        [DllImport(libraryPath, EntryPoint = "XSetWMNormalHints", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XSetWMNormalHints([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("XSizeHints *")] XSizeHints* hints);

        [DllImport(libraryPath, EntryPoint = "XSetWMProperties", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XSetWMProperties([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("XTextProperty *")] XTextProperty* window_name, [NativeTypeName("XTextProperty *")] XTextProperty* icon_name, [NativeTypeName("char **")] sbyte** argv, int argc, [NativeTypeName("XSizeHints *")] XSizeHints* normal_hints, [NativeTypeName("XWMHints *")] XWMHints* wm_hints, [NativeTypeName("XClassHint *")] XClassHint* class_hints);

        [DllImport(libraryPath, EntryPoint = "XmbSetWMProperties", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XmbSetWMProperties([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("const char *")] sbyte* window_name, [NativeTypeName("const char *")] sbyte* icon_name, [NativeTypeName("char **")] sbyte** argv, int argc, [NativeTypeName("XSizeHints *")] XSizeHints* normal_hints, [NativeTypeName("XWMHints *")] XWMHints* wm_hints, [NativeTypeName("XClassHint *")] XClassHint* class_hints);

        [DllImport(libraryPath, EntryPoint = "Xutf8SetWMProperties", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Xutf8SetWMProperties([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("const char *")] sbyte* window_name, [NativeTypeName("const char *")] sbyte* icon_name, [NativeTypeName("char **")] sbyte** argv, int argc, [NativeTypeName("XSizeHints *")] XSizeHints* normal_hints, [NativeTypeName("XWMHints *")] XWMHints* wm_hints, [NativeTypeName("XClassHint *")] XClassHint* class_hints);

        [DllImport(libraryPath, EntryPoint = "XSetWMSizeHints", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XSetWMSizeHints([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("XSizeHints *")] XSizeHints* hints, [NativeTypeName("Atom")] UIntPtr property);

        [DllImport(libraryPath, EntryPoint = "XSetRegion", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetRegion([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("GC")] XGC* gc, [NativeTypeName("Region")] XRegion* r);

        [DllImport(libraryPath, EntryPoint = "XSetStandardColormap", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XSetStandardColormap([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("XStandardColormap *")] XStandardColormap* colormap, [NativeTypeName("Atom")] UIntPtr property);

        [DllImport(libraryPath, EntryPoint = "XSetZoomHints", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetZoomHints([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("XSizeHints *")] XSizeHints* zhints);

        [DllImport(libraryPath, EntryPoint = "XShrinkRegion", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XShrinkRegion([NativeTypeName("Region")] XRegion* r, int dx, int dy);

        [DllImport(libraryPath, EntryPoint = "XStringListToTextProperty", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XStringListToTextProperty([NativeTypeName("char **")] sbyte** list, int count, [NativeTypeName("XTextProperty *")] XTextProperty* text_prop_return);

        [DllImport(libraryPath, EntryPoint = "XSubtractRegion", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSubtractRegion([NativeTypeName("Region")] XRegion* sra, [NativeTypeName("Region")] XRegion* srb, [NativeTypeName("Region")] XRegion* dr_return);

        [DllImport(libraryPath, EntryPoint = "XmbTextListToTextProperty", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XmbTextListToTextProperty([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("char **")] sbyte** list, int count, XICCEncodingStyle style, [NativeTypeName("XTextProperty *")] XTextProperty* text_prop_return);

        [DllImport(libraryPath, EntryPoint = "XwcTextListToTextProperty", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XwcTextListToTextProperty([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("wchar_t **")] int** list, int count, XICCEncodingStyle style, [NativeTypeName("XTextProperty *")] XTextProperty* text_prop_return);

        [DllImport(libraryPath, EntryPoint = "Xutf8TextListToTextProperty", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Xutf8TextListToTextProperty([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("char **")] sbyte** list, int count, XICCEncodingStyle style, [NativeTypeName("XTextProperty *")] XTextProperty* text_prop_return);

        [DllImport(libraryPath, EntryPoint = "XwcFreeStringList", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XwcFreeStringList([NativeTypeName("wchar_t **")] int** list);

        [DllImport(libraryPath, EntryPoint = "XTextPropertyToStringList", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XTextPropertyToStringList([NativeTypeName("XTextProperty *")] XTextProperty* text_prop, [NativeTypeName("char ***")] sbyte*** list_return, [NativeTypeName("int *")] int* count_return);

        [DllImport(libraryPath, EntryPoint = "XmbTextPropertyToTextList", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XmbTextPropertyToTextList([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("const XTextProperty *")] XTextProperty* text_prop, [NativeTypeName("char ***")] sbyte*** list_return, [NativeTypeName("int *")] int* count_return);

        [DllImport(libraryPath, EntryPoint = "XwcTextPropertyToTextList", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XwcTextPropertyToTextList([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("const XTextProperty *")] XTextProperty* text_prop, [NativeTypeName("wchar_t ***")] int*** list_return, [NativeTypeName("int *")] int* count_return);

        [DllImport(libraryPath, EntryPoint = "Xutf8TextPropertyToTextList", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Xutf8TextPropertyToTextList([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("const XTextProperty *")] XTextProperty* text_prop, [NativeTypeName("char ***")] sbyte*** list_return, [NativeTypeName("int *")] int* count_return);

        [DllImport(libraryPath, EntryPoint = "XUnionRectWithRegion", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XUnionRectWithRegion([NativeTypeName("XRectangle *")] XRectangle* rectangle, [NativeTypeName("Region")] XRegion* src_region, [NativeTypeName("Region")] XRegion* dest_region_return);

        [DllImport(libraryPath, EntryPoint = "XUnionRegion", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XUnionRegion([NativeTypeName("Region")] XRegion* sra, [NativeTypeName("Region")] XRegion* srb, [NativeTypeName("Region")] XRegion* dr_return);

        [DllImport(libraryPath, EntryPoint = "XWMGeometry", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XWMGeometry([NativeTypeName("Display *")] UIntPtr display, int screen_number, [NativeTypeName("const char *")] sbyte* user_geometry, [NativeTypeName("const char *")] sbyte* default_geometry, [NativeTypeName("unsigned int")] uint border_width, [NativeTypeName("XSizeHints *")] XSizeHints* hints, [NativeTypeName("int *")] int* x_return, [NativeTypeName("int *")] int* y_return, [NativeTypeName("int *")] int* width_return, [NativeTypeName("int *")] int* height_return, [NativeTypeName("int *")] int* gravity_return);

        [DllImport(libraryPath, EntryPoint = "XXorRegion", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XXorRegion([NativeTypeName("Region")] XRegion* sra, [NativeTypeName("Region")] XRegion* srb, [NativeTypeName("Region")] XRegion* dr_return);
    }
}
