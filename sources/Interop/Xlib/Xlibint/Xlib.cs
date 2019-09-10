// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\Xlibint.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Xlib
    {
        // [NativeTypeName("void (*)(LockInfoPtr)")]
        // public static extern IntPtr _XCreateMutex_fn;

        // [NativeTypeName("void (*)(LockInfoPtr)")]
        // public static extern IntPtr _XFreeMutex_fn;

        // [NativeTypeName("void (*)(LockInfoPtr)")]
        // public static extern IntPtr _XLockMutex_fn;

        // [NativeTypeName("void (*)(LockInfoPtr)")]
        // public static extern IntPtr _XUnlockMutex_fn;

        // [NativeTypeName("LockInfoPtr")]
        // public static extern _LockInfoRec* _Xglobal_lock;

        [DllImport(libraryPath, EntryPoint = "_XGetRequest", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("void *")]
        public static extern void* _XGetRequest([NativeTypeName("Display *")] XDisplay* dpy, [NativeTypeName("CARD8")] byte type, [NativeTypeName("size_t")] UIntPtr len);

        [DllImport(libraryPath, EntryPoint = "_XFlushGCCache", CallingConvention = CallingConvention.Cdecl)]
        public static extern void _XFlushGCCache([NativeTypeName("Display *")] XDisplay* dpy, [NativeTypeName("GC")] XGC* gc);

        [DllImport(libraryPath, EntryPoint = "_XData32", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _XData32([NativeTypeName("Display *")] XDisplay* dpy, [NativeTypeName("const long *")] IntPtr* data, [NativeTypeName("unsigned int")] uint len);

        [DllImport(libraryPath, EntryPoint = "_XRead32", CallingConvention = CallingConvention.Cdecl)]
        public static extern void _XRead32([NativeTypeName("Display *")] XDisplay* dpy, [NativeTypeName("long *")] IntPtr* data, [NativeTypeName("long")] IntPtr len);

        [DllImport(libraryPath, EntryPoint = "_XDeqAsyncHandler", CallingConvention = CallingConvention.Cdecl)]
        public static extern void _XDeqAsyncHandler([NativeTypeName("Display *")] XDisplay* dpy, [NativeTypeName("_XAsyncHandler *")] XInternalAsync* handler);

        [DllImport(libraryPath, EntryPoint = "_XError", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _XError([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("xError *")] xError* param1);

        [DllImport(libraryPath, EntryPoint = "_XIOError", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _XIOError([NativeTypeName("Display *")] XDisplay* param0);

        // [NativeTypeName("int (*)(Display *)")]
        // public static extern IntPtr _XIOErrorFunction;

        // [NativeTypeName("int (*)(Display *, XErrorEvent *)")]
        // public static extern IntPtr _XErrorFunction;

        [DllImport(libraryPath, EntryPoint = "_XEatData", CallingConvention = CallingConvention.Cdecl)]
        public static extern void _XEatData([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("unsigned long")] UIntPtr param1);

        [DllImport(libraryPath, EntryPoint = "_XEatDataWords", CallingConvention = CallingConvention.Cdecl)]
        public static extern void _XEatDataWords([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("unsigned long")] UIntPtr param1);

        [DllImport(libraryPath, EntryPoint = "_XAllocScratch", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* _XAllocScratch([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("unsigned long")] UIntPtr param1);

        [DllImport(libraryPath, EntryPoint = "_XAllocTemp", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* _XAllocTemp([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("unsigned long")] UIntPtr param1);

        [DllImport(libraryPath, EntryPoint = "_XFreeTemp", CallingConvention = CallingConvention.Cdecl)]
        public static extern void _XFreeTemp([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("char *")] sbyte* param1, [NativeTypeName("unsigned long")] UIntPtr param2);

        [DllImport(libraryPath, EntryPoint = "_XVIDtoVisual", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Visual *")]
        public static extern Visual* _XVIDtoVisual([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("VisualID")] UIntPtr param1);

        [DllImport(libraryPath, EntryPoint = "_XSetLastRequestRead", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("unsigned long")]
        public static extern UIntPtr _XSetLastRequestRead([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("xGenericReply *")] xGenericReply* param1);

        [DllImport(libraryPath, EntryPoint = "_XGetHostname", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _XGetHostname([NativeTypeName("char *")] sbyte* param0, int param1);

        [DllImport(libraryPath, EntryPoint = "_XScreenOfWindow", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Screen *")]
        public static extern Screen* _XScreenOfWindow([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("Window")] UIntPtr param1);

        [DllImport(libraryPath, EntryPoint = "_XAsyncErrorHandler", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _XAsyncErrorHandler([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("xReply *")] xReply* param1, [NativeTypeName("char *")] sbyte* param2, int param3, [NativeTypeName("XPointer")] sbyte* param4);

        [DllImport(libraryPath, EntryPoint = "_XGetAsyncReply", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* _XGetAsyncReply([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("char *")] sbyte* param1, [NativeTypeName("xReply *")] xReply* param2, [NativeTypeName("char *")] sbyte* param3, int param4, int param5, int param6);

        [DllImport(libraryPath, EntryPoint = "_XGetAsyncData", CallingConvention = CallingConvention.Cdecl)]
        public static extern void _XGetAsyncData([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("char *")] sbyte* param1, [NativeTypeName("char *")] sbyte* param2, int param3, int param4, int param5, int param6);

        [DllImport(libraryPath, EntryPoint = "_XFlush", CallingConvention = CallingConvention.Cdecl)]
        public static extern void _XFlush([NativeTypeName("Display *")] XDisplay* param0);

        [DllImport(libraryPath, EntryPoint = "_XEventsQueued", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _XEventsQueued([NativeTypeName("Display *")] XDisplay* param0, int param1);

        [DllImport(libraryPath, EntryPoint = "_XReadEvents", CallingConvention = CallingConvention.Cdecl)]
        public static extern void _XReadEvents([NativeTypeName("Display *")] XDisplay* param0);

        [DllImport(libraryPath, EntryPoint = "_XRead", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _XRead([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("char *")] sbyte* param1, [NativeTypeName("long")] IntPtr param2);

        [DllImport(libraryPath, EntryPoint = "_XReadPad", CallingConvention = CallingConvention.Cdecl)]
        public static extern void _XReadPad([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("char *")] sbyte* param1, [NativeTypeName("long")] IntPtr param2);

        [DllImport(libraryPath, EntryPoint = "_XSend", CallingConvention = CallingConvention.Cdecl)]
        public static extern void _XSend([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("long")] IntPtr param2);

        [DllImport(libraryPath, EntryPoint = "_XReply", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _XReply([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("xReply *")] xReply* param1, int param2, int param3);

        [DllImport(libraryPath, EntryPoint = "_XEnq", CallingConvention = CallingConvention.Cdecl)]
        public static extern void _XEnq([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("xEvent *")] xEvent* param1);

        [DllImport(libraryPath, EntryPoint = "_XDeq", CallingConvention = CallingConvention.Cdecl)]
        public static extern void _XDeq([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("_XQEvent *")] XSQEvent* param1, [NativeTypeName("_XQEvent *")] XSQEvent* param2);

        [DllImport(libraryPath, EntryPoint = "_XUnknownWireEvent", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _XUnknownWireEvent([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("XEvent *")] XEvent* param1, [NativeTypeName("xEvent *")] xEvent* param2);

        [DllImport(libraryPath, EntryPoint = "_XUnknownWireEventCookie", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _XUnknownWireEventCookie([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("XGenericEventCookie *")] XGenericEventCookie* param1, [NativeTypeName("xEvent *")] xEvent* param2);

        [DllImport(libraryPath, EntryPoint = "_XUnknownCopyEventCookie", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _XUnknownCopyEventCookie([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("XGenericEventCookie *")] XGenericEventCookie* param1, [NativeTypeName("XGenericEventCookie *")] XGenericEventCookie* param2);

        [DllImport(libraryPath, EntryPoint = "_XUnknownNativeEvent", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _XUnknownNativeEvent([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("XEvent *")] XEvent* param1, [NativeTypeName("xEvent *")] xEvent* param2);

        [DllImport(libraryPath, EntryPoint = "_XWireToEvent", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _XWireToEvent([NativeTypeName("Display *")] XDisplay* dpy, [NativeTypeName("XEvent *")] XEvent* re, [NativeTypeName("xEvent *")] xEvent* @event);

        [DllImport(libraryPath, EntryPoint = "_XDefaultWireError", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _XDefaultWireError([NativeTypeName("Display *")] XDisplay* display, [NativeTypeName("XErrorEvent *")] XErrorEvent* he, [NativeTypeName("xError *")] xError* we);

        [DllImport(libraryPath, EntryPoint = "_XPollfdCacheInit", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _XPollfdCacheInit([NativeTypeName("Display *")] XDisplay* dpy);

        [DllImport(libraryPath, EntryPoint = "_XPollfdCacheAdd", CallingConvention = CallingConvention.Cdecl)]
        public static extern void _XPollfdCacheAdd([NativeTypeName("Display *")] XDisplay* dpy, int fd);

        [DllImport(libraryPath, EntryPoint = "_XPollfdCacheDel", CallingConvention = CallingConvention.Cdecl)]
        public static extern void _XPollfdCacheDel([NativeTypeName("Display *")] XDisplay* dpy, int fd);

        [DllImport(libraryPath, EntryPoint = "_XAllocID", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XID")]
        public static extern UIntPtr _XAllocID([NativeTypeName("Display *")] XDisplay* dpy);

        [DllImport(libraryPath, EntryPoint = "_XAllocIDs", CallingConvention = CallingConvention.Cdecl)]
        public static extern void _XAllocIDs([NativeTypeName("Display *")] XDisplay* dpy, [NativeTypeName("XID *")] UIntPtr* ids, int count);

        [DllImport(libraryPath, EntryPoint = "_XFreeExtData", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _XFreeExtData([NativeTypeName("XExtData *")] XExtData* param0);

        [DllImport(libraryPath, EntryPoint = "XESetCreateGC", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("int (*)(Display *, GC, XExtCodes *)")]
        public static extern IntPtr XESetCreateGC([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("GC")] XGC* param1, [NativeTypeName("XExtCodes *")] XExtCodes* param2, [NativeTypeName("Display *")] XDisplay* param3, int param4, [NativeTypeName("int (*)(Display *, GC, XExtCodes *)")] IntPtr param5);

        [DllImport(libraryPath, EntryPoint = "XESetCopyGC", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("int (*)(Display *, GC, XExtCodes *)")]
        public static extern IntPtr XESetCopyGC([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("GC")] XGC* param1, [NativeTypeName("XExtCodes *")] XExtCodes* param2, [NativeTypeName("Display *")] XDisplay* param3, int param4, [NativeTypeName("int (*)(Display *, GC, XExtCodes *)")] IntPtr param5);

        [DllImport(libraryPath, EntryPoint = "XESetFlushGC", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("int (*)(Display *, GC, XExtCodes *)")]
        public static extern IntPtr XESetFlushGC([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("GC")] XGC* param1, [NativeTypeName("XExtCodes *")] XExtCodes* param2, [NativeTypeName("Display *")] XDisplay* param3, int param4, [NativeTypeName("int (*)(Display *, GC, XExtCodes *)")] IntPtr param5);

        [DllImport(libraryPath, EntryPoint = "XESetFreeGC", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("int (*)(Display *, GC, XExtCodes *)")]
        public static extern IntPtr XESetFreeGC([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("GC")] XGC* param1, [NativeTypeName("XExtCodes *")] XExtCodes* param2, [NativeTypeName("Display *")] XDisplay* param3, int param4, [NativeTypeName("int (*)(Display *, GC, XExtCodes *)")] IntPtr param5);

        [DllImport(libraryPath, EntryPoint = "XESetCreateFont", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("int (*)(Display *, XFontStruct *, XExtCodes *)")]
        public static extern IntPtr XESetCreateFont([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("XFontStruct *")] XFontStruct* param1, [NativeTypeName("XExtCodes *")] XExtCodes* param2, [NativeTypeName("Display *")] XDisplay* param3, int param4, [NativeTypeName("int (*)(Display *, XFontStruct *, XExtCodes *)")] IntPtr param5);

        [DllImport(libraryPath, EntryPoint = "XESetFreeFont", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("int (*)(Display *, XFontStruct *, XExtCodes *)")]
        public static extern IntPtr XESetFreeFont([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("XFontStruct *")] XFontStruct* param1, [NativeTypeName("XExtCodes *")] XExtCodes* param2, [NativeTypeName("Display *")] XDisplay* param3, int param4, [NativeTypeName("int (*)(Display *, XFontStruct *, XExtCodes *)")] IntPtr param5);

        [DllImport(libraryPath, EntryPoint = "XESetCloseDisplay", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("int (*)(Display *, XExtCodes *)")]
        public static extern IntPtr XESetCloseDisplay([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("XExtCodes *")] XExtCodes* param1, [NativeTypeName("Display *")] XDisplay* param2, int param3, [NativeTypeName("int (*)(Display *, XExtCodes *)")] IntPtr param4);

        [DllImport(libraryPath, EntryPoint = "XESetError", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("int (*)(Display *, xError *, XExtCodes *, int *)")]
        public static extern IntPtr XESetError([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("xError *")] xError* param1, [NativeTypeName("XExtCodes *")] XExtCodes* param2, [NativeTypeName("int *")] int* param3, [NativeTypeName("Display *")] XDisplay* param4, int param5, [NativeTypeName("int (*)(Display *, xError *, XExtCodes *, int *)")] IntPtr param6);

        [DllImport(libraryPath, EntryPoint = "XESetErrorString", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *(*)(Display *, int, XExtCodes *, char *, int)")]
        public static extern IntPtr XESetErrorString([NativeTypeName("Display *")] XDisplay* param0, int param1, [NativeTypeName("XExtCodes *")] XExtCodes* param2, [NativeTypeName("char *")] sbyte* param3, int param4, [NativeTypeName("Display *")] XDisplay* param5, int param6, [NativeTypeName("char *(*)(Display *, int, XExtCodes *, char *, int)")] IntPtr param7);

        [DllImport(libraryPath, EntryPoint = "XESetPrintErrorValues", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("void (*)(Display *, XErrorEvent *, void *)")]
        public static extern IntPtr XESetPrintErrorValues([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("XErrorEvent *")] XErrorEvent* param1, [NativeTypeName("void *")] void* param2, [NativeTypeName("Display *")] XDisplay* param3, int param4, [NativeTypeName("void (*)(Display *, XErrorEvent *, void *)")] IntPtr param5);

        [DllImport(libraryPath, EntryPoint = "XESetWireToEvent", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("int (*)(Display *, XEvent *, xEvent *)")]
        public static extern IntPtr XESetWireToEvent([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("XEvent *")] XEvent* param1, [NativeTypeName("xEvent *")] xEvent* param2, [NativeTypeName("Display *")] XDisplay* param3, int param4, [NativeTypeName("int (*)(Display *, XEvent *, xEvent *)")] IntPtr param5);

        [DllImport(libraryPath, EntryPoint = "XESetWireToEventCookie", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("int (*)(Display *, XGenericEventCookie *, xEvent *)")]
        public static extern IntPtr XESetWireToEventCookie([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("XGenericEventCookie *")] XGenericEventCookie* param1, [NativeTypeName("xEvent *")] xEvent* param2, [NativeTypeName("Display *")] XDisplay* param3, int param4, [NativeTypeName("int (*)(Display *, XGenericEventCookie *, xEvent *)")] IntPtr param5);

        [DllImport(libraryPath, EntryPoint = "XESetCopyEventCookie", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("int (*)(Display *, XGenericEventCookie *, XGenericEventCookie *)")]
        public static extern IntPtr XESetCopyEventCookie([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("XGenericEventCookie *")] XGenericEventCookie* param1, [NativeTypeName("XGenericEventCookie *")] XGenericEventCookie* param2, [NativeTypeName("Display *")] XDisplay* param3, int param4, [NativeTypeName("int (*)(Display *, XGenericEventCookie *, XGenericEventCookie *)")] IntPtr param5);

        [DllImport(libraryPath, EntryPoint = "XESetEventToWire", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("int (*)(Display *, XEvent *, xEvent *)")]
        public static extern IntPtr XESetEventToWire([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("XEvent *")] XEvent* param1, [NativeTypeName("xEvent *")] xEvent* param2, [NativeTypeName("Display *")] XDisplay* param3, int param4, [NativeTypeName("int (*)(Display *, XEvent *, xEvent *)")] IntPtr param5);

        [DllImport(libraryPath, EntryPoint = "XESetWireToError", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("int (*)(Display *, XErrorEvent *, xError *)")]
        public static extern IntPtr XESetWireToError([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("XErrorEvent *")] XErrorEvent* param1, [NativeTypeName("xError *")] xError* param2, [NativeTypeName("Display *")] XDisplay* param3, int param4, [NativeTypeName("int (*)(Display *, XErrorEvent *, xError *)")] IntPtr param5);

        [DllImport(libraryPath, EntryPoint = "XESetBeforeFlush", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("void (*)(Display *, XExtCodes *, const char *, long)")]
        public static extern IntPtr XESetBeforeFlush([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("XExtCodes *")] XExtCodes* param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("long")] IntPtr param3, [NativeTypeName("Display *")] XDisplay* param4, int param5, [NativeTypeName("void (*)(Display *, XExtCodes *, const char *, long)")] IntPtr param6);

        [DllImport(libraryPath, EntryPoint = "_XRegisterInternalConnection", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _XRegisterInternalConnection([NativeTypeName("Display *")] XDisplay* param0, int param1, [NativeTypeName("_XInternalConnectionProc")] IntPtr param2, [NativeTypeName("XPointer")] sbyte* param3);

        [DllImport(libraryPath, EntryPoint = "_XUnregisterInternalConnection", CallingConvention = CallingConvention.Cdecl)]
        public static extern void _XUnregisterInternalConnection([NativeTypeName("Display *")] XDisplay* param0, int param1);

        [DllImport(libraryPath, EntryPoint = "_XProcessInternalConnection", CallingConvention = CallingConvention.Cdecl)]
        public static extern void _XProcessInternalConnection([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("struct XConnectionInfo *")] XConnectionInfo* param1);

        [DllImport(libraryPath, EntryPoint = "_XTextHeight", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _XTextHeight([NativeTypeName("XFontStruct *")] XFontStruct* param0, [NativeTypeName("const char *")] sbyte* param1, int param2);

        [DllImport(libraryPath, EntryPoint = "_XTextHeight16", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _XTextHeight16([NativeTypeName("XFontStruct *")] XFontStruct* param0, [NativeTypeName("const XChar2b *")] XChar2b* param1, int param2);

        [DllImport(libraryPath, EntryPoint = "_XEventToWire", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _XEventToWire([NativeTypeName("Display *")] XDisplay* dpy, [NativeTypeName("XEvent *")] XEvent* re, [NativeTypeName("xEvent *")] xEvent* @event);

        [DllImport(libraryPath, EntryPoint = "_XF86LoadQueryLocaleFont", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _XF86LoadQueryLocaleFont([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("XFontStruct **")] XFontStruct** param2, [NativeTypeName("Font *")] UIntPtr* param3);

        [DllImport(libraryPath, EntryPoint = "_XProcessWindowAttributes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void _XProcessWindowAttributes([NativeTypeName("Display *")] XDisplay* dpy, [NativeTypeName("xChangeWindowAttributesReq *")] xChangeWindowAttributesReq* req, [NativeTypeName("unsigned long")] UIntPtr valuemask, [NativeTypeName("XSetWindowAttributes *")] XSetWindowAttributes* attributes);

        [DllImport(libraryPath, EntryPoint = "_XDefaultError", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _XDefaultError([NativeTypeName("Display *")] XDisplay* dpy, [NativeTypeName("XErrorEvent *")] XErrorEvent* @event);

        [DllImport(libraryPath, EntryPoint = "_XDefaultIOError", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _XDefaultIOError([NativeTypeName("Display *")] XDisplay* dpy);

        [DllImport(libraryPath, EntryPoint = "_XSetClipRectangles", CallingConvention = CallingConvention.Cdecl)]
        public static extern void _XSetClipRectangles([NativeTypeName("Display *")] XDisplay* dpy, [NativeTypeName("GC")] XGC* gc, int clip_x_origin, int clip_y_origin, [NativeTypeName("XRectangle *")] XRectangle* rectangles, int n, int ordering);

        [DllImport(libraryPath, EntryPoint = "_XGetWindowAttributes", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _XGetWindowAttributes([NativeTypeName("Display *")] XDisplay* dpy, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("XWindowAttributes *")] XWindowAttributes* attr);

        [DllImport(libraryPath, EntryPoint = "_XPutBackEvent", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _XPutBackEvent([NativeTypeName("Display *")] XDisplay* dpy, [NativeTypeName("XEvent *")] XEvent* @event);

        [DllImport(libraryPath, EntryPoint = "_XIsEventCookie", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _XIsEventCookie([NativeTypeName("Display *")] XDisplay* dpy, [NativeTypeName("XEvent *")] XEvent* ev);

        [DllImport(libraryPath, EntryPoint = "_XFreeEventCookies", CallingConvention = CallingConvention.Cdecl)]
        public static extern void _XFreeEventCookies([NativeTypeName("Display *")] XDisplay* dpy);

        [DllImport(libraryPath, EntryPoint = "_XStoreEventCookie", CallingConvention = CallingConvention.Cdecl)]
        public static extern void _XStoreEventCookie([NativeTypeName("Display *")] XDisplay* dpy, [NativeTypeName("XEvent *")] XEvent* ev);

        [DllImport(libraryPath, EntryPoint = "_XFetchEventCookie", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _XFetchEventCookie([NativeTypeName("Display *")] XDisplay* dpy, [NativeTypeName("XGenericEventCookie *")] XGenericEventCookie* ev);

        [DllImport(libraryPath, EntryPoint = "_XCopyEventCookie", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _XCopyEventCookie([NativeTypeName("Display *")] XDisplay* dpy, [NativeTypeName("XGenericEventCookie *")] XGenericEventCookie* @in, [NativeTypeName("XGenericEventCookie *")] XGenericEventCookie* @out);

        [DllImport(libraryPath, EntryPoint = "xlocaledir", CallingConvention = CallingConvention.Cdecl)]
        public static extern void xlocaledir([NativeTypeName("char *")] sbyte* buf, int buf_len);
    }
}
