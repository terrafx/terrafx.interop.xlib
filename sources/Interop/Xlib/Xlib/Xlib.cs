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
        public static extern XFontStruct* XLoadQueryFont([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("const char *")] sbyte* name);

        [DllImport(libraryPath, EntryPoint = "XQueryFont", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XFontStruct *")]
        public static extern XFontStruct* XQueryFont([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("XID")] UIntPtr font_ID);

        [DllImport(libraryPath, EntryPoint = "XGetMotionEvents", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XTimeCoord *")]
        public static extern XTimeCoord* XGetMotionEvents([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("Time")] UIntPtr start, [NativeTypeName("Time")] UIntPtr stop, [NativeTypeName("int *")] int* nevents_return);

        [DllImport(libraryPath, EntryPoint = "XDeleteModifiermapEntry", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XModifierKeymap *")]
        public static extern XModifierKeymap* XDeleteModifiermapEntry([NativeTypeName("XModifierKeymap *")] XModifierKeymap* modmap, [NativeTypeName("KeyCode")] byte keycode_entry, int modifier);

        [DllImport(libraryPath, EntryPoint = "XGetModifierMapping", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XModifierKeymap *")]
        public static extern XModifierKeymap* XGetModifierMapping([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(libraryPath, EntryPoint = "XInsertModifiermapEntry", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XModifierKeymap *")]
        public static extern XModifierKeymap* XInsertModifiermapEntry([NativeTypeName("XModifierKeymap *")] XModifierKeymap* modmap, [NativeTypeName("KeyCode")] byte keycode_entry, int modifier);

        [DllImport(libraryPath, EntryPoint = "XNewModifiermap", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XModifierKeymap *")]
        public static extern XModifierKeymap* XNewModifiermap(int max_keys_per_mod);

        [DllImport(libraryPath, EntryPoint = "XCreateImage", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XImage *")]
        public static extern XImage* XCreateImage([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Visual *")] Visual* visual, [NativeTypeName("unsigned int")] uint depth, int format, int offset, [NativeTypeName("char *")] sbyte* data, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height, int bitmap_pad, int bytes_per_line);

        [DllImport(libraryPath, EntryPoint = "XInitImage", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XInitImage([NativeTypeName("XImage *")] XImage* image);

        [DllImport(libraryPath, EntryPoint = "XGetImage", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XImage *")]
        public static extern XImage* XGetImage([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, int x, int y, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height, [NativeTypeName("unsigned long")] UIntPtr plane_mask, int format);

        [DllImport(libraryPath, EntryPoint = "XGetSubImage", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XImage *")]
        public static extern XImage* XGetSubImage([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, int x, int y, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height, [NativeTypeName("unsigned long")] UIntPtr plane_mask, int format, [NativeTypeName("XImage *")] XImage* dest_image, int dest_x, int dest_y);

        [DllImport(libraryPath, EntryPoint = "XOpenDisplay", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Display *")]
        public static extern UIntPtr XOpenDisplay([NativeTypeName("const char *")] sbyte* display_name);

        [DllImport(libraryPath, EntryPoint = "XrmInitialize", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XrmInitialize();

        [DllImport(libraryPath, EntryPoint = "XFetchBytes", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XFetchBytes([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("int *")] int* nbytes_return);

        [DllImport(libraryPath, EntryPoint = "XFetchBuffer", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XFetchBuffer([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("int *")] int* nbytes_return, int buffer);

        [DllImport(libraryPath, EntryPoint = "XGetAtomName", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XGetAtomName([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Atom")] UIntPtr atom);

        [DllImport(libraryPath, EntryPoint = "XGetAtomNames", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetAtomNames([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Atom *")] UIntPtr* atoms, int count, [NativeTypeName("char **")] sbyte** names_return);

        [DllImport(libraryPath, EntryPoint = "XGetDefault", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XGetDefault([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("const char *")] sbyte* program, [NativeTypeName("const char *")] sbyte* option);

        [DllImport(libraryPath, EntryPoint = "XDisplayName", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XDisplayName([NativeTypeName("const char *")] sbyte* c_string);

        [DllImport(libraryPath, EntryPoint = "XKeysymToString", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XKeysymToString([NativeTypeName("KeySym")] UIntPtr keysym);

        [DllImport(libraryPath, EntryPoint = "XSynchronize", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("int (*)(Display *)")]
        public static extern IntPtr XSynchronize([NativeTypeName("Display *")] UIntPtr display, int onoff);

        [DllImport(libraryPath, EntryPoint = "XSetAfterFunction", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("int (*)(Display *)")]
        public static extern IntPtr XSetAfterFunction([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("int (*)(Display *)")] IntPtr procedure);

        [DllImport(libraryPath, EntryPoint = "XInternAtom", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Atom")]
        public static extern UIntPtr XInternAtom([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("const char *")] sbyte* atom_name, int only_if_exists);

        [DllImport(libraryPath, EntryPoint = "XInternAtoms", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XInternAtoms([NativeTypeName("Display *")] UIntPtr dpy, [NativeTypeName("char **")] sbyte** names, int count, int onlyIfExists, [NativeTypeName("Atom *")] UIntPtr* atoms_return);

        [DllImport(libraryPath, EntryPoint = "XCopyColormapAndFree", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Colormap")]
        public static extern UIntPtr XCopyColormapAndFree([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Colormap")] UIntPtr colormap);

        [DllImport(libraryPath, EntryPoint = "XCreateColormap", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Colormap")]
        public static extern UIntPtr XCreateColormap([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("Visual *")] Visual* visual, int alloc);

        [DllImport(libraryPath, EntryPoint = "XCreatePixmapCursor", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Cursor")]
        public static extern UIntPtr XCreatePixmapCursor([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Pixmap")] UIntPtr source, [NativeTypeName("Pixmap")] UIntPtr mask, [NativeTypeName("XColor *")] XColor* foreground_color, [NativeTypeName("XColor *")] XColor* background_color, [NativeTypeName("unsigned int")] uint x, [NativeTypeName("unsigned int")] uint y);

        [DllImport(libraryPath, EntryPoint = "XCreateGlyphCursor", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Cursor")]
        public static extern UIntPtr XCreateGlyphCursor([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Font")] UIntPtr source_font, [NativeTypeName("Font")] UIntPtr mask_font, [NativeTypeName("unsigned int")] uint source_char, [NativeTypeName("unsigned int")] uint mask_char, [NativeTypeName("const XColor *")] XColor* foreground_color, [NativeTypeName("const XColor *")] XColor* background_color);

        [DllImport(libraryPath, EntryPoint = "XCreateFontCursor", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Cursor")]
        public static extern UIntPtr XCreateFontCursor([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("unsigned int")] uint shape);

        [DllImport(libraryPath, EntryPoint = "XLoadFont", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Font")]
        public static extern UIntPtr XLoadFont([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("const char *")] sbyte* name);

        [DllImport(libraryPath, EntryPoint = "XCreateGC", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("GC")]
        public static extern XGC* XCreateGC([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("unsigned long")] UIntPtr valuemask, [NativeTypeName("XGCValues *")] XGCValues* values);

        [DllImport(libraryPath, EntryPoint = "XGContextFromGC", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("GContext")]
        public static extern UIntPtr XGContextFromGC([NativeTypeName("GC")] XGC* gc);

        [DllImport(libraryPath, EntryPoint = "XFlushGC", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XFlushGC([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("GC")] XGC* gc);

        [DllImport(libraryPath, EntryPoint = "XCreatePixmap", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Pixmap")]
        public static extern UIntPtr XCreatePixmap([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height, [NativeTypeName("unsigned int")] uint depth);

        [DllImport(libraryPath, EntryPoint = "XCreateBitmapFromData", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Pixmap")]
        public static extern UIntPtr XCreateBitmapFromData([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("const char *")] sbyte* data, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height);

        [DllImport(libraryPath, EntryPoint = "XCreatePixmapFromBitmapData", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Pixmap")]
        public static extern UIntPtr XCreatePixmapFromBitmapData([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("char *")] sbyte* data, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height, [NativeTypeName("unsigned long")] UIntPtr fg, [NativeTypeName("unsigned long")] UIntPtr bg, [NativeTypeName("unsigned int")] uint depth);

        [DllImport(libraryPath, EntryPoint = "XCreateSimpleWindow", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Window")]
        public static extern UIntPtr XCreateSimpleWindow([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr parent, int x, int y, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height, [NativeTypeName("unsigned int")] uint border_width, [NativeTypeName("unsigned long")] UIntPtr border, [NativeTypeName("unsigned long")] UIntPtr background);

        [DllImport(libraryPath, EntryPoint = "XGetSelectionOwner", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Window")]
        public static extern UIntPtr XGetSelectionOwner([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Atom")] UIntPtr selection);

        [DllImport(libraryPath, EntryPoint = "XCreateWindow", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Window")]
        public static extern UIntPtr XCreateWindow([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr parent, int x, int y, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height, [NativeTypeName("unsigned int")] uint border_width, int depth, [NativeTypeName("unsigned int")] uint c_class, [NativeTypeName("Visual *")] Visual* visual, [NativeTypeName("unsigned long")] UIntPtr valuemask, [NativeTypeName("XSetWindowAttributes *")] XSetWindowAttributes* attributes);

        [DllImport(libraryPath, EntryPoint = "XListInstalledColormaps", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Colormap *")]
        public static extern UIntPtr* XListInstalledColormaps([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("int *")] int* num_return);

        [DllImport(libraryPath, EntryPoint = "XListFonts", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char **")]
        public static extern sbyte** XListFonts([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("const char *")] sbyte* pattern, int maxnames, [NativeTypeName("int *")] int* actual_count_return);

        [DllImport(libraryPath, EntryPoint = "XListFontsWithInfo", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char **")]
        public static extern sbyte** XListFontsWithInfo([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("const char *")] sbyte* pattern, int maxnames, [NativeTypeName("int *")] int* count_return, [NativeTypeName("XFontStruct **")] XFontStruct** info_return);

        [DllImport(libraryPath, EntryPoint = "XGetFontPath", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char **")]
        public static extern sbyte** XGetFontPath([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("int *")] int* npaths_return);

        [DllImport(libraryPath, EntryPoint = "XListExtensions", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char **")]
        public static extern sbyte** XListExtensions([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("int *")] int* nextensions_return);

        [DllImport(libraryPath, EntryPoint = "XListProperties", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Atom *")]
        public static extern UIntPtr* XListProperties([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("int *")] int* num_prop_Return);

        [DllImport(libraryPath, EntryPoint = "XListHosts", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XHostAddress *")]
        public static extern XHostAddress* XListHosts([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("int *")] int* nhosts_return, [NativeTypeName("int *")] int* state_return);

        [DllImport(libraryPath, EntryPoint = "XKeycodeToKeysym", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("KeySym")]
        public static extern UIntPtr XKeycodeToKeysym([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("KeyCode")] byte keycode, int index);

        [DllImport(libraryPath, EntryPoint = "XLookupKeysym", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("KeySym")]
        public static extern UIntPtr XLookupKeysym([NativeTypeName("XKeyEvent *")] XKeyEvent* key_event, int index);

        [DllImport(libraryPath, EntryPoint = "XGetKeyboardMapping", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("KeySym *")]
        public static extern UIntPtr* XGetKeyboardMapping([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("KeyCode")] byte first_keycode, int keycode_count, [NativeTypeName("int *")] int* keysyms_per_keycode_return);

        [DllImport(libraryPath, EntryPoint = "XStringToKeysym", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("KeySym")]
        public static extern UIntPtr XStringToKeysym([NativeTypeName("const char *")] sbyte* c_string);

        [DllImport(libraryPath, EntryPoint = "XMaxRequestSize", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("long")]
        public static extern IntPtr XMaxRequestSize([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(libraryPath, EntryPoint = "XExtendedMaxRequestSize", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("long")]
        public static extern IntPtr XExtendedMaxRequestSize([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(libraryPath, EntryPoint = "XResourceManagerString", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XResourceManagerString([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(libraryPath, EntryPoint = "XScreenResourceString", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XScreenResourceString([NativeTypeName("Screen *")] Screen* screen);

        [DllImport(libraryPath, EntryPoint = "XDisplayMotionBufferSize", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("unsigned long")]
        public static extern UIntPtr XDisplayMotionBufferSize([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(libraryPath, EntryPoint = "XVisualIDFromVisual", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("VisualID")]
        public static extern UIntPtr XVisualIDFromVisual([NativeTypeName("Visual *")] Visual* visual);

        [DllImport(libraryPath, EntryPoint = "XInitThreads", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XInitThreads();

        [DllImport(libraryPath, EntryPoint = "XLockDisplay", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XLockDisplay([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(libraryPath, EntryPoint = "XUnlockDisplay", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XUnlockDisplay([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(libraryPath, EntryPoint = "XInitExtension", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XExtCodes *")]
        public static extern XExtCodes* XInitExtension([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("const char *")] sbyte* name);

        [DllImport(libraryPath, EntryPoint = "XAddExtension", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XExtCodes *")]
        public static extern XExtCodes* XAddExtension([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(libraryPath, EntryPoint = "XFindOnExtensionList", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XExtData *")]
        public static extern XExtData* XFindOnExtensionList([NativeTypeName("XExtData **")] XExtData** structure, int number);

        [DllImport(libraryPath, EntryPoint = "XEHeadOfExtensionList", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XExtData **")]
        public static extern XExtData** XEHeadOfExtensionList(XEDataObject c_object);

        [DllImport(libraryPath, EntryPoint = "XRootWindow", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Window")]
        public static extern UIntPtr XRootWindow([NativeTypeName("Display *")] UIntPtr display, int screen_number);

        [DllImport(libraryPath, EntryPoint = "XDefaultRootWindow", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Window")]
        public static extern UIntPtr XDefaultRootWindow([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(libraryPath, EntryPoint = "XRootWindowOfScreen", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Window")]
        public static extern UIntPtr XRootWindowOfScreen([NativeTypeName("Screen *")] Screen* screen);

        [DllImport(libraryPath, EntryPoint = "XDefaultVisual", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Visual *")]
        public static extern Visual* XDefaultVisual([NativeTypeName("Display *")] UIntPtr display, int screen_number);

        [DllImport(libraryPath, EntryPoint = "XDefaultVisualOfScreen", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Visual *")]
        public static extern Visual* XDefaultVisualOfScreen([NativeTypeName("Screen *")] Screen* screen);

        [DllImport(libraryPath, EntryPoint = "XDefaultGC", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("GC")]
        public static extern XGC* XDefaultGC([NativeTypeName("Display *")] UIntPtr display, int screen_number);

        [DllImport(libraryPath, EntryPoint = "XDefaultGCOfScreen", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("GC")]
        public static extern XGC* XDefaultGCOfScreen([NativeTypeName("Screen *")] Screen* screen);

        [DllImport(libraryPath, EntryPoint = "XBlackPixel", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("unsigned long")]
        public static extern UIntPtr XBlackPixel([NativeTypeName("Display *")] UIntPtr display, int screen_number);

        [DllImport(libraryPath, EntryPoint = "XWhitePixel", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("unsigned long")]
        public static extern UIntPtr XWhitePixel([NativeTypeName("Display *")] UIntPtr display, int screen_number);

        [DllImport(libraryPath, EntryPoint = "XAllPlanes", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("unsigned long")]
        public static extern UIntPtr XAllPlanes();

        [DllImport(libraryPath, EntryPoint = "XBlackPixelOfScreen", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("unsigned long")]
        public static extern UIntPtr XBlackPixelOfScreen([NativeTypeName("Screen *")] Screen* screen);

        [DllImport(libraryPath, EntryPoint = "XWhitePixelOfScreen", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("unsigned long")]
        public static extern UIntPtr XWhitePixelOfScreen([NativeTypeName("Screen *")] Screen* screen);

        [DllImport(libraryPath, EntryPoint = "XNextRequest", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("unsigned long")]
        public static extern UIntPtr XNextRequest([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(libraryPath, EntryPoint = "XLastKnownRequestProcessed", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("unsigned long")]
        public static extern UIntPtr XLastKnownRequestProcessed([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(libraryPath, EntryPoint = "XServerVendor", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XServerVendor([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(libraryPath, EntryPoint = "XDisplayString", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XDisplayString([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(libraryPath, EntryPoint = "XDefaultColormap", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Colormap")]
        public static extern UIntPtr XDefaultColormap([NativeTypeName("Display *")] UIntPtr display, int screen_number);

        [DllImport(libraryPath, EntryPoint = "XDefaultColormapOfScreen", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Colormap")]
        public static extern UIntPtr XDefaultColormapOfScreen([NativeTypeName("Screen *")] Screen* screen);

        [DllImport(libraryPath, EntryPoint = "XDisplayOfScreen", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Display *")]
        public static extern UIntPtr XDisplayOfScreen([NativeTypeName("Screen *")] Screen* screen);

        [DllImport(libraryPath, EntryPoint = "XScreenOfDisplay", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Screen *")]
        public static extern Screen* XScreenOfDisplay([NativeTypeName("Display *")] UIntPtr display, int screen_number);

        [DllImport(libraryPath, EntryPoint = "XDefaultScreenOfDisplay", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Screen *")]
        public static extern Screen* XDefaultScreenOfDisplay([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(libraryPath, EntryPoint = "XEventMaskOfScreen", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("long")]
        public static extern IntPtr XEventMaskOfScreen([NativeTypeName("Screen *")] Screen* screen);

        [DllImport(libraryPath, EntryPoint = "XScreenNumberOfScreen", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XScreenNumberOfScreen([NativeTypeName("Screen *")] Screen* screen);

        [DllImport(libraryPath, EntryPoint = "XSetErrorHandler", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XErrorHandler")]
        public static extern IntPtr XSetErrorHandler([NativeTypeName("XErrorHandler")] IntPtr handler);

        [DllImport(libraryPath, EntryPoint = "XSetIOErrorHandler", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XIOErrorHandler")]
        public static extern IntPtr XSetIOErrorHandler([NativeTypeName("XIOErrorHandler")] IntPtr handler);

        [DllImport(libraryPath, EntryPoint = "XListPixmapFormats", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XPixmapFormatValues *")]
        public static extern XPixmapFormatValues* XListPixmapFormats([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("int *")] int* count_return);

        [DllImport(libraryPath, EntryPoint = "XListDepths", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("int *")]
        public static extern int* XListDepths([NativeTypeName("Display *")] UIntPtr display, int screen_number, [NativeTypeName("int *")] int* count_return);

        [DllImport(libraryPath, EntryPoint = "XReconfigureWMWindow", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XReconfigureWMWindow([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, int screen_number, [NativeTypeName("unsigned int")] uint mask, [NativeTypeName("XWindowChanges *")] XWindowChanges* changes);

        [DllImport(libraryPath, EntryPoint = "XGetWMProtocols", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetWMProtocols([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("Atom **")] UIntPtr** protocols_return, [NativeTypeName("int *")] int* count_return);

        [DllImport(libraryPath, EntryPoint = "XSetWMProtocols", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetWMProtocols([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("Atom *")] UIntPtr* protocols, int count);

        [DllImport(libraryPath, EntryPoint = "XIconifyWindow", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XIconifyWindow([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, int screen_number);

        [DllImport(libraryPath, EntryPoint = "XWithdrawWindow", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XWithdrawWindow([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, int screen_number);

        [DllImport(libraryPath, EntryPoint = "XGetCommand", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetCommand([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("char ***")] sbyte*** argv_return, [NativeTypeName("int *")] int* argc_return);

        [DllImport(libraryPath, EntryPoint = "XGetWMColormapWindows", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetWMColormapWindows([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("Window **")] UIntPtr** windows_return, [NativeTypeName("int *")] int* count_return);

        [DllImport(libraryPath, EntryPoint = "XSetWMColormapWindows", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetWMColormapWindows([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("Window *")] UIntPtr* colormap_windows, int count);

        [DllImport(libraryPath, EntryPoint = "XFreeStringList", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XFreeStringList([NativeTypeName("char **")] sbyte** list);

        [DllImport(libraryPath, EntryPoint = "XSetTransientForHint", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetTransientForHint([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("Window")] UIntPtr prop_window);

        [DllImport(libraryPath, EntryPoint = "XActivateScreenSaver", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XActivateScreenSaver([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(libraryPath, EntryPoint = "XAddHost", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XAddHost([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("XHostAddress *")] XHostAddress* host);

        [DllImport(libraryPath, EntryPoint = "XAddHosts", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XAddHosts([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("XHostAddress *")] XHostAddress* hosts, int num_hosts);

        [DllImport(libraryPath, EntryPoint = "XAddToExtensionList", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XAddToExtensionList([NativeTypeName("struct XExtData **")] XExtData** structure, [NativeTypeName("XExtData *")] XExtData* ext_data);

        [DllImport(libraryPath, EntryPoint = "XAddToSaveSet", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XAddToSaveSet([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w);

        [DllImport(libraryPath, EntryPoint = "XAllocColor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XAllocColor([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Colormap")] UIntPtr colormap, [NativeTypeName("XColor *")] XColor* screen_in_out);

        [DllImport(libraryPath, EntryPoint = "XAllocColorCells", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XAllocColorCells([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Colormap")] UIntPtr colormap, int contig, [NativeTypeName("unsigned long *")] UIntPtr* plane_masks_return, [NativeTypeName("unsigned int")] uint nplanes, [NativeTypeName("unsigned long *")] UIntPtr* pixels_return, [NativeTypeName("unsigned int")] uint npixels);

        [DllImport(libraryPath, EntryPoint = "XAllocColorPlanes", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XAllocColorPlanes([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Colormap")] UIntPtr colormap, int contig, [NativeTypeName("unsigned long *")] UIntPtr* pixels_return, int ncolors, int nreds, int ngreens, int nblues, [NativeTypeName("unsigned long *")] UIntPtr* rmask_return, [NativeTypeName("unsigned long *")] UIntPtr* gmask_return, [NativeTypeName("unsigned long *")] UIntPtr* bmask_return);

        [DllImport(libraryPath, EntryPoint = "XAllocNamedColor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XAllocNamedColor([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Colormap")] UIntPtr colormap, [NativeTypeName("const char *")] sbyte* color_name, [NativeTypeName("XColor *")] XColor* screen_def_return, [NativeTypeName("XColor *")] XColor* exact_def_return);

        [DllImport(libraryPath, EntryPoint = "XAllowEvents", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XAllowEvents([NativeTypeName("Display *")] UIntPtr display, int event_mode, [NativeTypeName("Time")] UIntPtr time);

        [DllImport(libraryPath, EntryPoint = "XAutoRepeatOff", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XAutoRepeatOff([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(libraryPath, EntryPoint = "XAutoRepeatOn", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XAutoRepeatOn([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(libraryPath, EntryPoint = "XBell", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XBell([NativeTypeName("Display *")] UIntPtr display, int percent);

        [DllImport(libraryPath, EntryPoint = "XBitmapBitOrder", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XBitmapBitOrder([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(libraryPath, EntryPoint = "XBitmapPad", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XBitmapPad([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(libraryPath, EntryPoint = "XBitmapUnit", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XBitmapUnit([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(libraryPath, EntryPoint = "XCellsOfScreen", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XCellsOfScreen([NativeTypeName("Screen *")] Screen* screen);

        [DllImport(libraryPath, EntryPoint = "XChangeActivePointerGrab", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XChangeActivePointerGrab([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("unsigned int")] uint event_mask, [NativeTypeName("Cursor")] UIntPtr cursor, [NativeTypeName("Time")] UIntPtr time);

        [DllImport(libraryPath, EntryPoint = "XChangeGC", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XChangeGC([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("GC")] XGC* gc, [NativeTypeName("unsigned long")] UIntPtr valuemask, [NativeTypeName("XGCValues *")] XGCValues* values);

        [DllImport(libraryPath, EntryPoint = "XChangeKeyboardControl", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XChangeKeyboardControl([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("unsigned long")] UIntPtr value_mask, [NativeTypeName("XKeyboardControl *")] XKeyboardControl* values);

        [DllImport(libraryPath, EntryPoint = "XChangeKeyboardMapping", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XChangeKeyboardMapping([NativeTypeName("Display *")] UIntPtr display, int first_keycode, int keysyms_per_keycode, [NativeTypeName("KeySym *")] UIntPtr* keysyms, int num_codes);

        [DllImport(libraryPath, EntryPoint = "XChangePointerControl", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XChangePointerControl([NativeTypeName("Display *")] UIntPtr display, int do_accel, int do_threshold, int accel_numerator, int accel_denominator, int threshold);

        [DllImport(libraryPath, EntryPoint = "XChangeProperty", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XChangeProperty([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("Atom")] UIntPtr property, [NativeTypeName("Atom")] UIntPtr type, int format, int mode, [NativeTypeName("const unsigned char *")] byte* data, int nelements);

        [DllImport(libraryPath, EntryPoint = "XChangeSaveSet", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XChangeSaveSet([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, int change_mode);

        [DllImport(libraryPath, EntryPoint = "XChangeWindowAttributes", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XChangeWindowAttributes([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("unsigned long")] UIntPtr valuemask, [NativeTypeName("XSetWindowAttributes *")] XSetWindowAttributes* attributes);

        [DllImport(libraryPath, EntryPoint = "XCheckIfEvent", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XCheckIfEvent([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("XEvent *")] XEvent* event_return, [NativeTypeName("int (*)(Display *, XEvent *, XPointer)")] IntPtr predicate, [NativeTypeName("XPointer")] sbyte* arg);

        [DllImport(libraryPath, EntryPoint = "XCheckMaskEvent", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XCheckMaskEvent([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("long")] IntPtr event_mask, [NativeTypeName("XEvent *")] XEvent* event_return);

        [DllImport(libraryPath, EntryPoint = "XCheckTypedEvent", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XCheckTypedEvent([NativeTypeName("Display *")] UIntPtr display, int event_type, [NativeTypeName("XEvent *")] XEvent* event_return);

        [DllImport(libraryPath, EntryPoint = "XCheckTypedWindowEvent", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XCheckTypedWindowEvent([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, int event_type, [NativeTypeName("XEvent *")] XEvent* event_return);

        [DllImport(libraryPath, EntryPoint = "XCheckWindowEvent", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XCheckWindowEvent([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("long")] IntPtr event_mask, [NativeTypeName("XEvent *")] XEvent* event_return);

        [DllImport(libraryPath, EntryPoint = "XCirculateSubwindows", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XCirculateSubwindows([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, int direction);

        [DllImport(libraryPath, EntryPoint = "XCirculateSubwindowsDown", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XCirculateSubwindowsDown([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w);

        [DllImport(libraryPath, EntryPoint = "XCirculateSubwindowsUp", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XCirculateSubwindowsUp([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w);

        [DllImport(libraryPath, EntryPoint = "XClearArea", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XClearArea([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, int x, int y, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height, int exposures);

        [DllImport(libraryPath, EntryPoint = "XClearWindow", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XClearWindow([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w);

        [DllImport(libraryPath, EntryPoint = "XCloseDisplay", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XCloseDisplay([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(libraryPath, EntryPoint = "XConfigureWindow", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XConfigureWindow([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("unsigned int")] uint value_mask, [NativeTypeName("XWindowChanges *")] XWindowChanges* values);

        [DllImport(libraryPath, EntryPoint = "XConnectionNumber", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XConnectionNumber([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(libraryPath, EntryPoint = "XConvertSelection", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XConvertSelection([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Atom")] UIntPtr selection, [NativeTypeName("Atom")] UIntPtr target, [NativeTypeName("Atom")] UIntPtr property, [NativeTypeName("Window")] UIntPtr requestor, [NativeTypeName("Time")] UIntPtr time);

        [DllImport(libraryPath, EntryPoint = "XCopyArea", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XCopyArea([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr src, [NativeTypeName("Drawable")] UIntPtr dest, [NativeTypeName("GC")] XGC* gc, int src_x, int src_y, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height, int dest_x, int dest_y);

        [DllImport(libraryPath, EntryPoint = "XCopyGC", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XCopyGC([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("GC")] XGC* src, [NativeTypeName("unsigned long")] UIntPtr valuemask, [NativeTypeName("GC")] XGC* dest);

        [DllImport(libraryPath, EntryPoint = "XCopyPlane", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XCopyPlane([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr src, [NativeTypeName("Drawable")] UIntPtr dest, [NativeTypeName("GC")] XGC* gc, int src_x, int src_y, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height, int dest_x, int dest_y, [NativeTypeName("unsigned long")] UIntPtr plane);

        [DllImport(libraryPath, EntryPoint = "XDefaultDepth", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDefaultDepth([NativeTypeName("Display *")] UIntPtr display, int screen_number);

        [DllImport(libraryPath, EntryPoint = "XDefaultDepthOfScreen", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDefaultDepthOfScreen([NativeTypeName("Screen *")] Screen* screen);

        [DllImport(libraryPath, EntryPoint = "XDefaultScreen", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDefaultScreen([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(libraryPath, EntryPoint = "XDefineCursor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDefineCursor([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("Cursor")] UIntPtr cursor);

        [DllImport(libraryPath, EntryPoint = "XDeleteProperty", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDeleteProperty([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("Atom")] UIntPtr property);

        [DllImport(libraryPath, EntryPoint = "XDestroyWindow", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDestroyWindow([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w);

        [DllImport(libraryPath, EntryPoint = "XDestroySubwindows", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDestroySubwindows([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w);

        [DllImport(libraryPath, EntryPoint = "XDoesBackingStore", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDoesBackingStore([NativeTypeName("Screen *")] Screen* screen);

        [DllImport(libraryPath, EntryPoint = "XDoesSaveUnders", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDoesSaveUnders([NativeTypeName("Screen *")] Screen* screen);

        [DllImport(libraryPath, EntryPoint = "XDisableAccessControl", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDisableAccessControl([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(libraryPath, EntryPoint = "XDisplayCells", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDisplayCells([NativeTypeName("Display *")] UIntPtr display, int screen_number);

        [DllImport(libraryPath, EntryPoint = "XDisplayHeight", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDisplayHeight([NativeTypeName("Display *")] UIntPtr display, int screen_number);

        [DllImport(libraryPath, EntryPoint = "XDisplayHeightMM", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDisplayHeightMM([NativeTypeName("Display *")] UIntPtr display, int screen_number);

        [DllImport(libraryPath, EntryPoint = "XDisplayKeycodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDisplayKeycodes([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("int *")] int* min_keycodes_return, [NativeTypeName("int *")] int* max_keycodes_return);

        [DllImport(libraryPath, EntryPoint = "XDisplayPlanes", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDisplayPlanes([NativeTypeName("Display *")] UIntPtr display, int screen_numberm1);

        [DllImport(libraryPath, EntryPoint = "XDisplayWidth", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDisplayWidth([NativeTypeName("Display *")] UIntPtr display, int screen_number);

        [DllImport(libraryPath, EntryPoint = "XDisplayWidthMM", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDisplayWidthMM([NativeTypeName("Display *")] UIntPtr display, int screen_number);

        [DllImport(libraryPath, EntryPoint = "XDrawArc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDrawArc([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("GC")] XGC* gc, int x, int y, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height, int angle1, int angle2);

        [DllImport(libraryPath, EntryPoint = "XDrawArcs", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDrawArcs([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("GC")] XGC* gc, [NativeTypeName("XArc *")] XArc* arcs, int narcs);

        [DllImport(libraryPath, EntryPoint = "XDrawImageString", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDrawImageString([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("GC")] XGC* gc, int x, int y, [NativeTypeName("const char *")] sbyte* c_string, int length);

        [DllImport(libraryPath, EntryPoint = "XDrawImageString16", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDrawImageString16([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("GC")] XGC* gc, int x, int y, [NativeTypeName("const XChar2b *")] XChar2b* c_string, int length);

        [DllImport(libraryPath, EntryPoint = "XDrawLine", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDrawLine([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("GC")] XGC* gc, int x1, int y1, int x2, int y2);

        [DllImport(libraryPath, EntryPoint = "XDrawLines", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDrawLines([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("GC")] XGC* gc, [NativeTypeName("XPoint *")] XPoint* points, int npoints, int mode);

        [DllImport(libraryPath, EntryPoint = "XDrawPoint", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDrawPoint([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("GC")] XGC* gc, int x, int y);

        [DllImport(libraryPath, EntryPoint = "XDrawPoints", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDrawPoints([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("GC")] XGC* gc, [NativeTypeName("XPoint *")] XPoint* points, int npoints, int mode);

        [DllImport(libraryPath, EntryPoint = "XDrawRectangle", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDrawRectangle([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("GC")] XGC* gc, int x, int y, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height);

        [DllImport(libraryPath, EntryPoint = "XDrawRectangles", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDrawRectangles([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("GC")] XGC* gc, [NativeTypeName("XRectangle *")] XRectangle* rectangles, int nrectangles);

        [DllImport(libraryPath, EntryPoint = "XDrawSegments", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDrawSegments([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("GC")] XGC* gc, [NativeTypeName("XSegment *")] XSegment* segments, int nsegments);

        [DllImport(libraryPath, EntryPoint = "XDrawString", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDrawString([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("GC")] XGC* gc, int x, int y, [NativeTypeName("const char *")] sbyte* c_string, int length);

        [DllImport(libraryPath, EntryPoint = "XDrawString16", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDrawString16([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("GC")] XGC* gc, int x, int y, [NativeTypeName("const XChar2b *")] XChar2b* c_string, int length);

        [DllImport(libraryPath, EntryPoint = "XDrawText", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDrawText([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("GC")] XGC* gc, int x, int y, [NativeTypeName("XTextItem *")] XTextItem* items, int nitems);

        [DllImport(libraryPath, EntryPoint = "XDrawText16", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDrawText16([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("GC")] XGC* gc, int x, int y, [NativeTypeName("XTextItem16 *")] XTextItem16* items, int nitems);

        [DllImport(libraryPath, EntryPoint = "XEnableAccessControl", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XEnableAccessControl([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(libraryPath, EntryPoint = "XEventsQueued", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XEventsQueued([NativeTypeName("Display *")] UIntPtr display, int mode);

        [DllImport(libraryPath, EntryPoint = "XFetchName", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XFetchName([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("char **")] sbyte** window_name_return);

        [DllImport(libraryPath, EntryPoint = "XFillArc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XFillArc([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("GC")] XGC* gc, int x, int y, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height, int angle1, int angle2);

        [DllImport(libraryPath, EntryPoint = "XFillArcs", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XFillArcs([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("GC")] XGC* gc, [NativeTypeName("XArc *")] XArc* arcs, int narcs);

        [DllImport(libraryPath, EntryPoint = "XFillPolygon", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XFillPolygon([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("GC")] XGC* gc, [NativeTypeName("XPoint *")] XPoint* points, int npoints, int shape, int mode);

        [DllImport(libraryPath, EntryPoint = "XFillRectangle", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XFillRectangle([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("GC")] XGC* gc, int x, int y, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height);

        [DllImport(libraryPath, EntryPoint = "XFillRectangles", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XFillRectangles([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("GC")] XGC* gc, [NativeTypeName("XRectangle *")] XRectangle* rectangles, int nrectangles);

        [DllImport(libraryPath, EntryPoint = "XFlush", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XFlush([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(libraryPath, EntryPoint = "XForceScreenSaver", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XForceScreenSaver([NativeTypeName("Display *")] UIntPtr display, int mode);

        [DllImport(libraryPath, EntryPoint = "XFree", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XFree([NativeTypeName("void *")] void* data);

        [DllImport(libraryPath, EntryPoint = "XFreeColormap", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XFreeColormap([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Colormap")] UIntPtr colormap);

        [DllImport(libraryPath, EntryPoint = "XFreeColors", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XFreeColors([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Colormap")] UIntPtr colormap, [NativeTypeName("unsigned long *")] UIntPtr* pixels, int npixels, [NativeTypeName("unsigned long")] UIntPtr planes);

        [DllImport(libraryPath, EntryPoint = "XFreeCursor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XFreeCursor([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Cursor")] UIntPtr cursor);

        [DllImport(libraryPath, EntryPoint = "XFreeExtensionList", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XFreeExtensionList([NativeTypeName("char **")] sbyte** list);

        [DllImport(libraryPath, EntryPoint = "XFreeFont", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XFreeFont([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("XFontStruct *")] XFontStruct* font_struct);

        [DllImport(libraryPath, EntryPoint = "XFreeFontInfo", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XFreeFontInfo([NativeTypeName("char **")] sbyte** names, [NativeTypeName("XFontStruct *")] XFontStruct* free_info, int actual_count);

        [DllImport(libraryPath, EntryPoint = "XFreeFontNames", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XFreeFontNames([NativeTypeName("char **")] sbyte** list);

        [DllImport(libraryPath, EntryPoint = "XFreeFontPath", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XFreeFontPath([NativeTypeName("char **")] sbyte** list);

        [DllImport(libraryPath, EntryPoint = "XFreeGC", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XFreeGC([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("GC")] XGC* gc);

        [DllImport(libraryPath, EntryPoint = "XFreeModifiermap", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XFreeModifiermap([NativeTypeName("XModifierKeymap *")] XModifierKeymap* modmap);

        [DllImport(libraryPath, EntryPoint = "XFreePixmap", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XFreePixmap([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Pixmap")] UIntPtr pixmap);

        [DllImport(libraryPath, EntryPoint = "XGeometry", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGeometry([NativeTypeName("Display *")] UIntPtr display, int screen, [NativeTypeName("const char *")] sbyte* position, [NativeTypeName("const char *")] sbyte* default_position, [NativeTypeName("unsigned int")] uint bwidth, [NativeTypeName("unsigned int")] uint fwidth, [NativeTypeName("unsigned int")] uint fheight, int xadder, int yadder, [NativeTypeName("int *")] int* x_return, [NativeTypeName("int *")] int* y_return, [NativeTypeName("int *")] int* width_return, [NativeTypeName("int *")] int* height_return);

        [DllImport(libraryPath, EntryPoint = "XGetErrorDatabaseText", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetErrorDatabaseText([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* message, [NativeTypeName("const char *")] sbyte* default_string, [NativeTypeName("char *")] sbyte* buffer_return, int length);

        [DllImport(libraryPath, EntryPoint = "XGetErrorText", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetErrorText([NativeTypeName("Display *")] UIntPtr display, int code, [NativeTypeName("char *")] sbyte* buffer_return, int length);

        [DllImport(libraryPath, EntryPoint = "XGetFontProperty", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetFontProperty([NativeTypeName("XFontStruct *")] XFontStruct* font_struct, [NativeTypeName("Atom")] UIntPtr atom, [NativeTypeName("unsigned long *")] UIntPtr* value_return);

        [DllImport(libraryPath, EntryPoint = "XGetGCValues", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetGCValues([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("GC")] XGC* gc, [NativeTypeName("unsigned long")] UIntPtr valuemask, [NativeTypeName("XGCValues *")] XGCValues* values_return);

        [DllImport(libraryPath, EntryPoint = "XGetGeometry", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetGeometry([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("Window *")] UIntPtr* root_return, [NativeTypeName("int *")] int* x_return, [NativeTypeName("int *")] int* y_return, [NativeTypeName("unsigned int *")] uint* width_return, [NativeTypeName("unsigned int *")] uint* height_return, [NativeTypeName("unsigned int *")] uint* border_width_return, [NativeTypeName("unsigned int *")] uint* depth_return);

        [DllImport(libraryPath, EntryPoint = "XGetIconName", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetIconName([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("char **")] sbyte** icon_name_return);

        [DllImport(libraryPath, EntryPoint = "XGetInputFocus", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetInputFocus([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window *")] UIntPtr* focus_return, [NativeTypeName("int *")] int* revert_to_return);

        [DllImport(libraryPath, EntryPoint = "XGetKeyboardControl", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetKeyboardControl([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("XKeyboardState *")] XKeyboardState* values_return);

        [DllImport(libraryPath, EntryPoint = "XGetPointerControl", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetPointerControl([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("int *")] int* accel_numerator_return, [NativeTypeName("int *")] int* accel_denominator_return, [NativeTypeName("int *")] int* threshold_return);

        [DllImport(libraryPath, EntryPoint = "XGetPointerMapping", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetPointerMapping([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("unsigned char *")] byte* map_return, int map);

        [DllImport(libraryPath, EntryPoint = "XGetScreenSaver", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetScreenSaver([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("int *")] int* timeout_return, [NativeTypeName("int *")] int* interval_return, [NativeTypeName("int *")] int* prefer_blanking_return, [NativeTypeName("int *")] int* allow_exposures_return);

        [DllImport(libraryPath, EntryPoint = "XGetTransientForHint", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetTransientForHint([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("Window *")] UIntPtr* prop_window_return);

        [DllImport(libraryPath, EntryPoint = "XGetWindowProperty", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetWindowProperty([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("Atom")] UIntPtr property, [NativeTypeName("long")] IntPtr long_offset, [NativeTypeName("long")] IntPtr long_length, int delete, [NativeTypeName("Atom")] UIntPtr req_type, [NativeTypeName("Atom *")] UIntPtr* actual_type_return, [NativeTypeName("int *")] int* actual_format_return, [NativeTypeName("unsigned long *")] UIntPtr* nitems_return, [NativeTypeName("unsigned long *")] UIntPtr* bytes_after_return, [NativeTypeName("unsigned char **")] byte** prop_return);

        [DllImport(libraryPath, EntryPoint = "XGetWindowAttributes", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetWindowAttributes([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("XWindowAttributes *")] XWindowAttributes* window_attributes_return);

        [DllImport(libraryPath, EntryPoint = "XGrabButton", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGrabButton([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("unsigned int")] uint button, [NativeTypeName("unsigned int")] uint modifiers, [NativeTypeName("Window")] UIntPtr grab_window, int owner_events, [NativeTypeName("unsigned int")] uint event_mask, int pointer_mode, int keyboard_mode, [NativeTypeName("Window")] UIntPtr confine_to, [NativeTypeName("Cursor")] UIntPtr cursor);

        [DllImport(libraryPath, EntryPoint = "XGrabKey", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGrabKey([NativeTypeName("Display *")] UIntPtr display, int keycode, [NativeTypeName("unsigned int")] uint modifiers, [NativeTypeName("Window")] UIntPtr grab_window, int owner_events, int pointer_mode, int keyboard_mode);

        [DllImport(libraryPath, EntryPoint = "XGrabKeyboard", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGrabKeyboard([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr grab_window, int owner_events, int pointer_mode, int keyboard_mode, [NativeTypeName("Time")] UIntPtr time);

        [DllImport(libraryPath, EntryPoint = "XGrabPointer", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGrabPointer([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr grab_window, int owner_events, [NativeTypeName("unsigned int")] uint event_mask, int pointer_mode, int keyboard_mode, [NativeTypeName("Window")] UIntPtr confine_to, [NativeTypeName("Cursor")] UIntPtr cursor, [NativeTypeName("Time")] UIntPtr time);

        [DllImport(libraryPath, EntryPoint = "XGrabServer", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGrabServer([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(libraryPath, EntryPoint = "XHeightMMOfScreen", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XHeightMMOfScreen([NativeTypeName("Screen *")] Screen* screen);

        [DllImport(libraryPath, EntryPoint = "XHeightOfScreen", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XHeightOfScreen([NativeTypeName("Screen *")] Screen* screen);

        [DllImport(libraryPath, EntryPoint = "XIfEvent", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XIfEvent([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("XEvent *")] XEvent* event_return, [NativeTypeName("int (*)(Display *, XEvent *, XPointer)")] IntPtr predicate, [NativeTypeName("XPointer")] sbyte* arg);

        [DllImport(libraryPath, EntryPoint = "XImageByteOrder", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XImageByteOrder([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(libraryPath, EntryPoint = "XInstallColormap", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XInstallColormap([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Colormap")] UIntPtr colormap);

        [DllImport(libraryPath, EntryPoint = "XKeysymToKeycode", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("KeyCode")]
        public static extern byte XKeysymToKeycode([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("KeySym")] UIntPtr keysym);

        [DllImport(libraryPath, EntryPoint = "XKillClient", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XKillClient([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("XID")] UIntPtr resource);

        [DllImport(libraryPath, EntryPoint = "XLookupColor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XLookupColor([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Colormap")] UIntPtr colormap, [NativeTypeName("const char *")] sbyte* color_name, [NativeTypeName("XColor *")] XColor* exact_def_return, [NativeTypeName("XColor *")] XColor* screen_def_return);

        [DllImport(libraryPath, EntryPoint = "XLowerWindow", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XLowerWindow([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w);

        [DllImport(libraryPath, EntryPoint = "XMapRaised", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XMapRaised([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w);

        [DllImport(libraryPath, EntryPoint = "XMapSubwindows", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XMapSubwindows([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w);

        [DllImport(libraryPath, EntryPoint = "XMapWindow", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XMapWindow([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w);

        [DllImport(libraryPath, EntryPoint = "XMaskEvent", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XMaskEvent([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("long")] IntPtr event_mask, [NativeTypeName("XEvent *")] XEvent* event_return);

        [DllImport(libraryPath, EntryPoint = "XMaxCmapsOfScreen", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XMaxCmapsOfScreen([NativeTypeName("Screen *")] Screen* screen);

        [DllImport(libraryPath, EntryPoint = "XMinCmapsOfScreen", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XMinCmapsOfScreen([NativeTypeName("Screen *")] Screen* screen);

        [DllImport(libraryPath, EntryPoint = "XMoveResizeWindow", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XMoveResizeWindow([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, int x, int y, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height);

        [DllImport(libraryPath, EntryPoint = "XMoveWindow", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XMoveWindow([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, int x, int y);

        [DllImport(libraryPath, EntryPoint = "XNextEvent", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XNextEvent([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("XEvent *")] XEvent* event_return);

        [DllImport(libraryPath, EntryPoint = "XNoOp", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XNoOp([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(libraryPath, EntryPoint = "XParseColor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XParseColor([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Colormap")] UIntPtr colormap, [NativeTypeName("const char *")] sbyte* spec, [NativeTypeName("XColor *")] XColor* exact_def_return);

        [DllImport(libraryPath, EntryPoint = "XParseGeometry", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XParseGeometry([NativeTypeName("const char *")] sbyte* parsestring, [NativeTypeName("int *")] int* x_return, [NativeTypeName("int *")] int* y_return, [NativeTypeName("unsigned int *")] uint* width_return, [NativeTypeName("unsigned int *")] uint* height_return);

        [DllImport(libraryPath, EntryPoint = "XPeekEvent", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XPeekEvent([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("XEvent *")] XEvent* event_return);

        [DllImport(libraryPath, EntryPoint = "XPeekIfEvent", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XPeekIfEvent([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("XEvent *")] XEvent* event_return, [NativeTypeName("int (*)(Display *, XEvent *, XPointer)")] IntPtr predicate, [NativeTypeName("XPointer")] sbyte* arg);

        [DllImport(libraryPath, EntryPoint = "XPending", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XPending([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(libraryPath, EntryPoint = "XPlanesOfScreen", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XPlanesOfScreen([NativeTypeName("Screen *")] Screen* screen);

        [DllImport(libraryPath, EntryPoint = "XProtocolRevision", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XProtocolRevision([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(libraryPath, EntryPoint = "XProtocolVersion", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XProtocolVersion([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(libraryPath, EntryPoint = "XPutBackEvent", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XPutBackEvent([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("XEvent *")] XEvent* c_event);

        [DllImport(libraryPath, EntryPoint = "XPutImage", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XPutImage([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("GC")] XGC* gc, [NativeTypeName("XImage *")] XImage* image, int src_x, int src_y, int dest_x, int dest_y, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height);

        [DllImport(libraryPath, EntryPoint = "XQLength", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XQLength([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(libraryPath, EntryPoint = "XQueryBestCursor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XQueryBestCursor([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height, [NativeTypeName("unsigned int *")] uint* width_return, [NativeTypeName("unsigned int *")] uint* height_return);

        [DllImport(libraryPath, EntryPoint = "XQueryBestSize", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XQueryBestSize([NativeTypeName("Display *")] UIntPtr display, int c_class, [NativeTypeName("Drawable")] UIntPtr which_screen, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height, [NativeTypeName("unsigned int *")] uint* width_return, [NativeTypeName("unsigned int *")] uint* height_return);

        [DllImport(libraryPath, EntryPoint = "XQueryBestStipple", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XQueryBestStipple([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr which_screen, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height, [NativeTypeName("unsigned int *")] uint* width_return, [NativeTypeName("unsigned int *")] uint* height_return);

        [DllImport(libraryPath, EntryPoint = "XQueryBestTile", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XQueryBestTile([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr which_screen, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height, [NativeTypeName("unsigned int *")] uint* width_return, [NativeTypeName("unsigned int *")] uint* height_return);

        [DllImport(libraryPath, EntryPoint = "XQueryColor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XQueryColor([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Colormap")] UIntPtr colormap, [NativeTypeName("XColor *")] XColor* def_in_out);

        [DllImport(libraryPath, EntryPoint = "XQueryColors", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XQueryColors([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Colormap")] UIntPtr colormap, [NativeTypeName("XColor *")] XColor* defs_in_out, int ncolors);

        [DllImport(libraryPath, EntryPoint = "XQueryExtension", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XQueryExtension([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("int *")] int* major_opcode_return, [NativeTypeName("int *")] int* first_event_return, [NativeTypeName("int *")] int* first_error_return);

        [DllImport(libraryPath, EntryPoint = "XQueryKeymap", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XQueryKeymap([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("char [32]")] sbyte keys_return);

        [DllImport(libraryPath, EntryPoint = "XQueryPointer", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XQueryPointer([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("Window *")] UIntPtr* root_return, [NativeTypeName("Window *")] UIntPtr* child_return, [NativeTypeName("int *")] int* root_x_return, [NativeTypeName("int *")] int* root_y_return, [NativeTypeName("int *")] int* win_x_return, [NativeTypeName("int *")] int* win_y_return, [NativeTypeName("unsigned int *")] uint* mask_return);

        [DllImport(libraryPath, EntryPoint = "XQueryTextExtents", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XQueryTextExtents([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("XID")] UIntPtr font_ID, [NativeTypeName("const char *")] sbyte* c_string, int nchars, [NativeTypeName("int *")] int* direction_return, [NativeTypeName("int *")] int* font_ascent_return, [NativeTypeName("int *")] int* font_descent_return, [NativeTypeName("XCharStruct *")] XCharStruct* overall_return);

        [DllImport(libraryPath, EntryPoint = "XQueryTextExtents16", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XQueryTextExtents16([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("XID")] UIntPtr font_ID, [NativeTypeName("const XChar2b *")] XChar2b* c_string, int nchars, [NativeTypeName("int *")] int* direction_return, [NativeTypeName("int *")] int* font_ascent_return, [NativeTypeName("int *")] int* font_descent_return, [NativeTypeName("XCharStruct *")] XCharStruct* overall_return);

        [DllImport(libraryPath, EntryPoint = "XQueryTree", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XQueryTree([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("Window *")] UIntPtr* root_return, [NativeTypeName("Window *")] UIntPtr* parent_return, [NativeTypeName("Window **")] UIntPtr** children_return, [NativeTypeName("unsigned int *")] uint* nchildren_return);

        [DllImport(libraryPath, EntryPoint = "XRaiseWindow", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XRaiseWindow([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w);

        [DllImport(libraryPath, EntryPoint = "XReadBitmapFile", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XReadBitmapFile([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("const char *")] sbyte* filename, [NativeTypeName("unsigned int *")] uint* width_return, [NativeTypeName("unsigned int *")] uint* height_return, [NativeTypeName("Pixmap *")] UIntPtr* bitmap_return, [NativeTypeName("int *")] int* x_hot_return, [NativeTypeName("int *")] int* y_hot_return);

        [DllImport(libraryPath, EntryPoint = "XReadBitmapFileData", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XReadBitmapFileData([NativeTypeName("const char *")] sbyte* filename, [NativeTypeName("unsigned int *")] uint* width_return, [NativeTypeName("unsigned int *")] uint* height_return, [NativeTypeName("unsigned char **")] byte** data_return, [NativeTypeName("int *")] int* x_hot_return, [NativeTypeName("int *")] int* y_hot_return);

        [DllImport(libraryPath, EntryPoint = "XRebindKeysym", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XRebindKeysym([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("KeySym")] UIntPtr keysym, [NativeTypeName("KeySym *")] UIntPtr* list, int mod_count, [NativeTypeName("const unsigned char *")] byte* c_string, int bytes_string);

        [DllImport(libraryPath, EntryPoint = "XRecolorCursor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XRecolorCursor([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Cursor")] UIntPtr cursor, [NativeTypeName("XColor *")] XColor* foreground_color, [NativeTypeName("XColor *")] XColor* background_color);

        [DllImport(libraryPath, EntryPoint = "XRefreshKeyboardMapping", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XRefreshKeyboardMapping([NativeTypeName("XMappingEvent *")] XMappingEvent* event_map);

        [DllImport(libraryPath, EntryPoint = "XRemoveFromSaveSet", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XRemoveFromSaveSet([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w);

        [DllImport(libraryPath, EntryPoint = "XRemoveHost", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XRemoveHost([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("XHostAddress *")] XHostAddress* host);

        [DllImport(libraryPath, EntryPoint = "XRemoveHosts", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XRemoveHosts([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("XHostAddress *")] XHostAddress* hosts, int num_hosts);

        [DllImport(libraryPath, EntryPoint = "XReparentWindow", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XReparentWindow([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("Window")] UIntPtr parent, int x, int y);

        [DllImport(libraryPath, EntryPoint = "XResetScreenSaver", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XResetScreenSaver([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(libraryPath, EntryPoint = "XResizeWindow", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XResizeWindow([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height);

        [DllImport(libraryPath, EntryPoint = "XRestackWindows", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XRestackWindows([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window *")] UIntPtr* windows, int nwindows);

        [DllImport(libraryPath, EntryPoint = "XRotateBuffers", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XRotateBuffers([NativeTypeName("Display *")] UIntPtr display, int rotate);

        [DllImport(libraryPath, EntryPoint = "XRotateWindowProperties", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XRotateWindowProperties([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("Atom *")] UIntPtr* properties, int num_prop, int npositions);

        [DllImport(libraryPath, EntryPoint = "XScreenCount", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XScreenCount([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(libraryPath, EntryPoint = "XSelectInput", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSelectInput([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("long")] IntPtr event_mask);

        [DllImport(libraryPath, EntryPoint = "XSendEvent", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSendEvent([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, int propagate, [NativeTypeName("long")] IntPtr event_mask, [NativeTypeName("XEvent *")] XEvent* event_send);

        [DllImport(libraryPath, EntryPoint = "XSetAccessControl", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetAccessControl([NativeTypeName("Display *")] UIntPtr display, int mode);

        [DllImport(libraryPath, EntryPoint = "XSetArcMode", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetArcMode([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("GC")] XGC* gc, int arc_mode);

        [DllImport(libraryPath, EntryPoint = "XSetBackground", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetBackground([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("GC")] XGC* gc, [NativeTypeName("unsigned long")] UIntPtr background);

        [DllImport(libraryPath, EntryPoint = "XSetClipMask", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetClipMask([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("GC")] XGC* gc, [NativeTypeName("Pixmap")] UIntPtr pixmap);

        [DllImport(libraryPath, EntryPoint = "XSetClipOrigin", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetClipOrigin([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("GC")] XGC* gc, int clip_x_origin, int clip_y_origin);

        [DllImport(libraryPath, EntryPoint = "XSetClipRectangles", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetClipRectangles([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("GC")] XGC* gc, int clip_x_origin, int clip_y_origin, [NativeTypeName("XRectangle *")] XRectangle* rectangles, int n, int ordering);

        [DllImport(libraryPath, EntryPoint = "XSetCloseDownMode", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetCloseDownMode([NativeTypeName("Display *")] UIntPtr display, int close_mode);

        [DllImport(libraryPath, EntryPoint = "XSetCommand", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetCommand([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("char **")] sbyte** argv, int argc);

        [DllImport(libraryPath, EntryPoint = "XSetDashes", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetDashes([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("GC")] XGC* gc, int dash_offset, [NativeTypeName("const char *")] sbyte* dash_list, int n);

        [DllImport(libraryPath, EntryPoint = "XSetFillRule", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetFillRule([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("GC")] XGC* gc, int fill_rule);

        [DllImport(libraryPath, EntryPoint = "XSetFillStyle", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetFillStyle([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("GC")] XGC* gc, int fill_style);

        [DllImport(libraryPath, EntryPoint = "XSetFont", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetFont([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("GC")] XGC* gc, [NativeTypeName("Font")] UIntPtr font);

        [DllImport(libraryPath, EntryPoint = "XSetFontPath", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetFontPath([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("char **")] sbyte** directories, int ndirs);

        [DllImport(libraryPath, EntryPoint = "XSetForeground", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetForeground([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("GC")] XGC* gc, [NativeTypeName("unsigned long")] UIntPtr foreground);

        [DllImport(libraryPath, EntryPoint = "XSetFunction", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetFunction([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("GC")] XGC* gc, int function);

        [DllImport(libraryPath, EntryPoint = "XSetGraphicsExposures", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetGraphicsExposures([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("GC")] XGC* gc, int graphics_exposures);

        [DllImport(libraryPath, EntryPoint = "XSetIconName", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetIconName([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("const char *")] sbyte* icon_name);

        [DllImport(libraryPath, EntryPoint = "XSetInputFocus", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetInputFocus([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr focus, int revert_to, [NativeTypeName("Time")] UIntPtr time);

        [DllImport(libraryPath, EntryPoint = "XSetLineAttributes", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetLineAttributes([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("GC")] XGC* gc, [NativeTypeName("unsigned int")] uint line_width, int line_style, int cap_style, int join_style);

        [DllImport(libraryPath, EntryPoint = "XSetModifierMapping", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetModifierMapping([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("XModifierKeymap *")] XModifierKeymap* modmap);

        [DllImport(libraryPath, EntryPoint = "XSetPlaneMask", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetPlaneMask([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("GC")] XGC* gc, [NativeTypeName("unsigned long")] UIntPtr plane_mask);

        [DllImport(libraryPath, EntryPoint = "XSetPointerMapping", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetPointerMapping([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("const unsigned char *")] byte* map, int nmap);

        [DllImport(libraryPath, EntryPoint = "XSetScreenSaver", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetScreenSaver([NativeTypeName("Display *")] UIntPtr display, int timeout, int interval, int prefer_blanking, int allow_exposures);

        [DllImport(libraryPath, EntryPoint = "XSetSelectionOwner", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetSelectionOwner([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Atom")] UIntPtr selection, [NativeTypeName("Window")] UIntPtr owner, [NativeTypeName("Time")] UIntPtr time);

        [DllImport(libraryPath, EntryPoint = "XSetState", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetState([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("GC")] XGC* gc, [NativeTypeName("unsigned long")] UIntPtr foreground, [NativeTypeName("unsigned long")] UIntPtr background, int function, [NativeTypeName("unsigned long")] UIntPtr plane_mask);

        [DllImport(libraryPath, EntryPoint = "XSetStipple", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetStipple([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("GC")] XGC* gc, [NativeTypeName("Pixmap")] UIntPtr stipple);

        [DllImport(libraryPath, EntryPoint = "XSetSubwindowMode", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetSubwindowMode([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("GC")] XGC* gc, int subwindow_mode);

        [DllImport(libraryPath, EntryPoint = "XSetTSOrigin", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetTSOrigin([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("GC")] XGC* gc, int ts_x_origin, int ts_y_origin);

        [DllImport(libraryPath, EntryPoint = "XSetTile", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetTile([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("GC")] XGC* gc, [NativeTypeName("Pixmap")] UIntPtr tile);

        [DllImport(libraryPath, EntryPoint = "XSetWindowBackground", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetWindowBackground([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("unsigned long")] UIntPtr background_pixel);

        [DllImport(libraryPath, EntryPoint = "XSetWindowBackgroundPixmap", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetWindowBackgroundPixmap([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("Pixmap")] UIntPtr background_pixmap);

        [DllImport(libraryPath, EntryPoint = "XSetWindowBorder", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetWindowBorder([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("unsigned long")] UIntPtr border_pixel);

        [DllImport(libraryPath, EntryPoint = "XSetWindowBorderPixmap", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetWindowBorderPixmap([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("Pixmap")] UIntPtr border_pixmap);

        [DllImport(libraryPath, EntryPoint = "XSetWindowBorderWidth", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetWindowBorderWidth([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("unsigned int")] uint width);

        [DllImport(libraryPath, EntryPoint = "XSetWindowColormap", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetWindowColormap([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("Colormap")] UIntPtr colormap);

        [DllImport(libraryPath, EntryPoint = "XStoreBuffer", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XStoreBuffer([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("const char *")] sbyte* bytes, int nbytes, int buffer);

        [DllImport(libraryPath, EntryPoint = "XStoreBytes", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XStoreBytes([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("const char *")] sbyte* bytes, int nbytes);

        [DllImport(libraryPath, EntryPoint = "XStoreColor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XStoreColor([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Colormap")] UIntPtr colormap, [NativeTypeName("XColor *")] XColor* color);

        [DllImport(libraryPath, EntryPoint = "XStoreColors", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XStoreColors([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Colormap")] UIntPtr colormap, [NativeTypeName("XColor *")] XColor* color, int ncolors);

        [DllImport(libraryPath, EntryPoint = "XStoreName", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XStoreName([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("const char *")] sbyte* window_name);

        [DllImport(libraryPath, EntryPoint = "XStoreNamedColor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XStoreNamedColor([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Colormap")] UIntPtr colormap, [NativeTypeName("const char *")] sbyte* color, [NativeTypeName("unsigned long")] UIntPtr pixel, int flags);

        [DllImport(libraryPath, EntryPoint = "XSync", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSync([NativeTypeName("Display *")] UIntPtr display, int discard);

        [DllImport(libraryPath, EntryPoint = "XTextExtents", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XTextExtents([NativeTypeName("XFontStruct *")] XFontStruct* font_struct, [NativeTypeName("const char *")] sbyte* c_string, int nchars, [NativeTypeName("int *")] int* direction_return, [NativeTypeName("int *")] int* font_ascent_return, [NativeTypeName("int *")] int* font_descent_return, [NativeTypeName("XCharStruct *")] XCharStruct* overall_return);

        [DllImport(libraryPath, EntryPoint = "XTextExtents16", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XTextExtents16([NativeTypeName("XFontStruct *")] XFontStruct* font_struct, [NativeTypeName("const XChar2b *")] XChar2b* c_string, int nchars, [NativeTypeName("int *")] int* direction_return, [NativeTypeName("int *")] int* font_ascent_return, [NativeTypeName("int *")] int* font_descent_return, [NativeTypeName("XCharStruct *")] XCharStruct* overall_return);

        [DllImport(libraryPath, EntryPoint = "XTextWidth", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XTextWidth([NativeTypeName("XFontStruct *")] XFontStruct* font_struct, [NativeTypeName("const char *")] sbyte* c_string, int count);

        [DllImport(libraryPath, EntryPoint = "XTextWidth16", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XTextWidth16([NativeTypeName("XFontStruct *")] XFontStruct* font_struct, [NativeTypeName("const XChar2b *")] XChar2b* c_string, int count);

        [DllImport(libraryPath, EntryPoint = "XTranslateCoordinates", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XTranslateCoordinates([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr src_w, [NativeTypeName("Window")] UIntPtr dest_w, int src_x, int src_y, [NativeTypeName("int *")] int* dest_x_return, [NativeTypeName("int *")] int* dest_y_return, [NativeTypeName("Window *")] UIntPtr* child_return);

        [DllImport(libraryPath, EntryPoint = "XUndefineCursor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XUndefineCursor([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w);

        [DllImport(libraryPath, EntryPoint = "XUngrabButton", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XUngrabButton([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("unsigned int")] uint button, [NativeTypeName("unsigned int")] uint modifiers, [NativeTypeName("Window")] UIntPtr grab_window);

        [DllImport(libraryPath, EntryPoint = "XUngrabKey", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XUngrabKey([NativeTypeName("Display *")] UIntPtr display, int keycode, [NativeTypeName("unsigned int")] uint modifiers, [NativeTypeName("Window")] UIntPtr grab_window);

        [DllImport(libraryPath, EntryPoint = "XUngrabKeyboard", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XUngrabKeyboard([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Time")] UIntPtr time);

        [DllImport(libraryPath, EntryPoint = "XUngrabPointer", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XUngrabPointer([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Time")] UIntPtr time);

        [DllImport(libraryPath, EntryPoint = "XUngrabServer", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XUngrabServer([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(libraryPath, EntryPoint = "XUninstallColormap", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XUninstallColormap([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Colormap")] UIntPtr colormap);

        [DllImport(libraryPath, EntryPoint = "XUnloadFont", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XUnloadFont([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Font")] UIntPtr font);

        [DllImport(libraryPath, EntryPoint = "XUnmapSubwindows", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XUnmapSubwindows([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w);

        [DllImport(libraryPath, EntryPoint = "XUnmapWindow", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XUnmapWindow([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w);

        [DllImport(libraryPath, EntryPoint = "XVendorRelease", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XVendorRelease([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(libraryPath, EntryPoint = "XWarpPointer", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XWarpPointer([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr src_w, [NativeTypeName("Window")] UIntPtr dest_w, int src_x, int src_y, [NativeTypeName("unsigned int")] uint src_width, [NativeTypeName("unsigned int")] uint src_height, int dest_x, int dest_y);

        [DllImport(libraryPath, EntryPoint = "XWidthMMOfScreen", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XWidthMMOfScreen([NativeTypeName("Screen *")] Screen* screen);

        [DllImport(libraryPath, EntryPoint = "XWidthOfScreen", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XWidthOfScreen([NativeTypeName("Screen *")] Screen* screen);

        [DllImport(libraryPath, EntryPoint = "XWindowEvent", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XWindowEvent([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("long")] IntPtr event_mask, [NativeTypeName("XEvent *")] XEvent* event_return);

        [DllImport(libraryPath, EntryPoint = "XWriteBitmapFile", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XWriteBitmapFile([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("const char *")] sbyte* filename, [NativeTypeName("Pixmap")] UIntPtr bitmap, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height, int x_hot, int y_hot);

        [DllImport(libraryPath, EntryPoint = "XSupportsLocale", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSupportsLocale();

        [DllImport(libraryPath, EntryPoint = "XSetLocaleModifiers", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XSetLocaleModifiers([NativeTypeName("const char *")] sbyte* modifier_list);

        [DllImport(libraryPath, EntryPoint = "XOpenOM", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XOM")]
        public static extern XOM* XOpenOM([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("struct XrmHashBucketRec *")] XrmHashBucketRec* rdb, [NativeTypeName("const char *")] sbyte* res_name, [NativeTypeName("const char *")] sbyte* res_class);

        [DllImport(libraryPath, EntryPoint = "XCloseOM", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XCloseOM([NativeTypeName("XOM")] XOM* om);

        [DllImport(libraryPath, EntryPoint = "XSetOMValues", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XSetOMValues([NativeTypeName("XOM")] XOM* om);

        [DllImport(libraryPath, EntryPoint = "XGetOMValues", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XGetOMValues([NativeTypeName("XOM")] XOM* om);

        [DllImport(libraryPath, EntryPoint = "XDisplayOfOM", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Display *")]
        public static extern UIntPtr XDisplayOfOM([NativeTypeName("XOM")] XOM* om);

        [DllImport(libraryPath, EntryPoint = "XLocaleOfOM", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XLocaleOfOM([NativeTypeName("XOM")] XOM* om);

        [DllImport(libraryPath, EntryPoint = "XCreateOC", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XOC")]
        public static extern XOC* XCreateOC([NativeTypeName("XOM")] XOM* om);

        [DllImport(libraryPath, EntryPoint = "XDestroyOC", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XDestroyOC([NativeTypeName("XOC")] XOC* oc);

        [DllImport(libraryPath, EntryPoint = "XOMOfOC", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XOM")]
        public static extern XOM* XOMOfOC([NativeTypeName("XOC")] XOC* oc);

        [DllImport(libraryPath, EntryPoint = "XSetOCValues", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XSetOCValues([NativeTypeName("XOC")] XOC* oc);

        [DllImport(libraryPath, EntryPoint = "XGetOCValues", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XGetOCValues([NativeTypeName("XOC")] XOC* oc);

        [DllImport(libraryPath, EntryPoint = "XCreateFontSet", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XFontSet")]
        public static extern XOC* XCreateFontSet([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("const char *")] sbyte* base_font_name_list, [NativeTypeName("char ***")] sbyte*** missing_charset_list, [NativeTypeName("int *")] int* missing_charset_count, [NativeTypeName("char **")] sbyte** def_string);

        [DllImport(libraryPath, EntryPoint = "XFreeFontSet", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XFreeFontSet([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("XFontSet")] XOC* font_set);

        [DllImport(libraryPath, EntryPoint = "XFontsOfFontSet", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XFontsOfFontSet([NativeTypeName("XFontSet")] XOC* font_set, [NativeTypeName("XFontStruct ***")] XFontStruct*** font_struct_list, [NativeTypeName("char ***")] sbyte*** font_name_list);

        [DllImport(libraryPath, EntryPoint = "XBaseFontNameListOfFontSet", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XBaseFontNameListOfFontSet([NativeTypeName("XFontSet")] XOC* font_set);

        [DllImport(libraryPath, EntryPoint = "XLocaleOfFontSet", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XLocaleOfFontSet([NativeTypeName("XFontSet")] XOC* font_set);

        [DllImport(libraryPath, EntryPoint = "XContextDependentDrawing", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XContextDependentDrawing([NativeTypeName("XFontSet")] XOC* font_set);

        [DllImport(libraryPath, EntryPoint = "XDirectionalDependentDrawing", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDirectionalDependentDrawing([NativeTypeName("XFontSet")] XOC* font_set);

        [DllImport(libraryPath, EntryPoint = "XContextualDrawing", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XContextualDrawing([NativeTypeName("XFontSet")] XOC* font_set);

        [DllImport(libraryPath, EntryPoint = "XExtentsOfFontSet", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XFontSetExtents *")]
        public static extern XFontSetExtents* XExtentsOfFontSet([NativeTypeName("XFontSet")] XOC* font_set);

        [DllImport(libraryPath, EntryPoint = "XmbTextEscapement", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XmbTextEscapement([NativeTypeName("XFontSet")] XOC* font_set, [NativeTypeName("const char *")] sbyte* text, int bytes_text);

        [DllImport(libraryPath, EntryPoint = "XwcTextEscapement", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XwcTextEscapement([NativeTypeName("XFontSet")] XOC* font_set, [NativeTypeName("const wchar_t *")] int* text, int num_wchars);

        [DllImport(libraryPath, EntryPoint = "Xutf8TextEscapement", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Xutf8TextEscapement([NativeTypeName("XFontSet")] XOC* font_set, [NativeTypeName("const char *")] sbyte* text, int bytes_text);

        [DllImport(libraryPath, EntryPoint = "XmbTextExtents", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XmbTextExtents([NativeTypeName("XFontSet")] XOC* font_set, [NativeTypeName("const char *")] sbyte* text, int bytes_text, [NativeTypeName("XRectangle *")] XRectangle* overall_ink_return, [NativeTypeName("XRectangle *")] XRectangle* overall_logical_return);

        [DllImport(libraryPath, EntryPoint = "XwcTextExtents", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XwcTextExtents([NativeTypeName("XFontSet")] XOC* font_set, [NativeTypeName("const wchar_t *")] int* text, int num_wchars, [NativeTypeName("XRectangle *")] XRectangle* overall_ink_return, [NativeTypeName("XRectangle *")] XRectangle* overall_logical_return);

        [DllImport(libraryPath, EntryPoint = "Xutf8TextExtents", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Xutf8TextExtents([NativeTypeName("XFontSet")] XOC* font_set, [NativeTypeName("const char *")] sbyte* text, int bytes_text, [NativeTypeName("XRectangle *")] XRectangle* overall_ink_return, [NativeTypeName("XRectangle *")] XRectangle* overall_logical_return);

        [DllImport(libraryPath, EntryPoint = "XmbTextPerCharExtents", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XmbTextPerCharExtents([NativeTypeName("XFontSet")] XOC* font_set, [NativeTypeName("const char *")] sbyte* text, int bytes_text, [NativeTypeName("XRectangle *")] XRectangle* ink_extents_buffer, [NativeTypeName("XRectangle *")] XRectangle* logical_extents_buffer, int buffer_size, [NativeTypeName("int *")] int* num_chars, [NativeTypeName("XRectangle *")] XRectangle* overall_ink_return, [NativeTypeName("XRectangle *")] XRectangle* overall_logical_return);

        [DllImport(libraryPath, EntryPoint = "XwcTextPerCharExtents", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XwcTextPerCharExtents([NativeTypeName("XFontSet")] XOC* font_set, [NativeTypeName("const wchar_t *")] int* text, int num_wchars, [NativeTypeName("XRectangle *")] XRectangle* ink_extents_buffer, [NativeTypeName("XRectangle *")] XRectangle* logical_extents_buffer, int buffer_size, [NativeTypeName("int *")] int* num_chars, [NativeTypeName("XRectangle *")] XRectangle* overall_ink_return, [NativeTypeName("XRectangle *")] XRectangle* overall_logical_return);

        [DllImport(libraryPath, EntryPoint = "Xutf8TextPerCharExtents", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Xutf8TextPerCharExtents([NativeTypeName("XFontSet")] XOC* font_set, [NativeTypeName("const char *")] sbyte* text, int bytes_text, [NativeTypeName("XRectangle *")] XRectangle* ink_extents_buffer, [NativeTypeName("XRectangle *")] XRectangle* logical_extents_buffer, int buffer_size, [NativeTypeName("int *")] int* num_chars, [NativeTypeName("XRectangle *")] XRectangle* overall_ink_return, [NativeTypeName("XRectangle *")] XRectangle* overall_logical_return);

        [DllImport(libraryPath, EntryPoint = "XmbDrawText", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XmbDrawText([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("GC")] XGC* gc, int x, int y, [NativeTypeName("XmbTextItem *")] XmbTextItem* text_items, int nitems);

        [DllImport(libraryPath, EntryPoint = "XwcDrawText", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XwcDrawText([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("GC")] XGC* gc, int x, int y, [NativeTypeName("XwcTextItem *")] XwcTextItem* text_items, int nitems);

        [DllImport(libraryPath, EntryPoint = "Xutf8DrawText", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Xutf8DrawText([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("GC")] XGC* gc, int x, int y, [NativeTypeName("XmbTextItem *")] XmbTextItem* text_items, int nitems);

        [DllImport(libraryPath, EntryPoint = "XmbDrawString", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XmbDrawString([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("XFontSet")] XOC* font_set, [NativeTypeName("GC")] XGC* gc, int x, int y, [NativeTypeName("const char *")] sbyte* text, int bytes_text);

        [DllImport(libraryPath, EntryPoint = "XwcDrawString", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XwcDrawString([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("XFontSet")] XOC* font_set, [NativeTypeName("GC")] XGC* gc, int x, int y, [NativeTypeName("const wchar_t *")] int* text, int num_wchars);

        [DllImport(libraryPath, EntryPoint = "Xutf8DrawString", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Xutf8DrawString([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("XFontSet")] XOC* font_set, [NativeTypeName("GC")] XGC* gc, int x, int y, [NativeTypeName("const char *")] sbyte* text, int bytes_text);

        [DllImport(libraryPath, EntryPoint = "XmbDrawImageString", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XmbDrawImageString([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("XFontSet")] XOC* font_set, [NativeTypeName("GC")] XGC* gc, int x, int y, [NativeTypeName("const char *")] sbyte* text, int bytes_text);

        [DllImport(libraryPath, EntryPoint = "XwcDrawImageString", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XwcDrawImageString([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("XFontSet")] XOC* font_set, [NativeTypeName("GC")] XGC* gc, int x, int y, [NativeTypeName("const wchar_t *")] int* text, int num_wchars);

        [DllImport(libraryPath, EntryPoint = "Xutf8DrawImageString", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Xutf8DrawImageString([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("XFontSet")] XOC* font_set, [NativeTypeName("GC")] XGC* gc, int x, int y, [NativeTypeName("const char *")] sbyte* text, int bytes_text);

        [DllImport(libraryPath, EntryPoint = "XOpenIM", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XIM")]
        public static extern XIM* XOpenIM([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("struct XrmHashBucketRec *")] XrmHashBucketRec* rdb, [NativeTypeName("char *")] sbyte* res_name, [NativeTypeName("char *")] sbyte* res_class);

        [DllImport(libraryPath, EntryPoint = "XCloseIM", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XCloseIM([NativeTypeName("XIM")] XIM* im);

        [DllImport(libraryPath, EntryPoint = "XGetIMValues", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XGetIMValues([NativeTypeName("XIM")] XIM* im);

        [DllImport(libraryPath, EntryPoint = "XSetIMValues", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XSetIMValues([NativeTypeName("XIM")] XIM* im);

        [DllImport(libraryPath, EntryPoint = "XDisplayOfIM", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("Display *")]
        public static extern UIntPtr XDisplayOfIM([NativeTypeName("XIM")] XIM* im);

        [DllImport(libraryPath, EntryPoint = "XLocaleOfIM", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XLocaleOfIM([NativeTypeName("XIM")] XIM* im);

        [DllImport(libraryPath, EntryPoint = "XCreateIC", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XIC")]
        public static extern XIC* XCreateIC([NativeTypeName("XIM")] XIM* im);

        [DllImport(libraryPath, EntryPoint = "XDestroyIC", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XDestroyIC([NativeTypeName("XIC")] XIC* ic);

        [DllImport(libraryPath, EntryPoint = "XSetICFocus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XSetICFocus([NativeTypeName("XIC")] XIC* ic);

        [DllImport(libraryPath, EntryPoint = "XUnsetICFocus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XUnsetICFocus([NativeTypeName("XIC")] XIC* ic);

        [DllImport(libraryPath, EntryPoint = "XwcResetIC", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("wchar_t *")]
        public static extern int* XwcResetIC([NativeTypeName("XIC")] XIC* ic);

        [DllImport(libraryPath, EntryPoint = "XmbResetIC", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XmbResetIC([NativeTypeName("XIC")] XIC* ic);

        [DllImport(libraryPath, EntryPoint = "Xutf8ResetIC", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* Xutf8ResetIC([NativeTypeName("XIC")] XIC* ic);

        [DllImport(libraryPath, EntryPoint = "XSetICValues", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XSetICValues([NativeTypeName("XIC")] XIC* ic);

        [DllImport(libraryPath, EntryPoint = "XGetICValues", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XGetICValues([NativeTypeName("XIC")] XIC* ic);

        [DllImport(libraryPath, EntryPoint = "XIMOfIC", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XIM")]
        public static extern XIM* XIMOfIC([NativeTypeName("XIC")] XIC* ic);

        [DllImport(libraryPath, EntryPoint = "XFilterEvent", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XFilterEvent([NativeTypeName("XEvent *")] XEvent* c_event, [NativeTypeName("Window")] UIntPtr window);

        [DllImport(libraryPath, EntryPoint = "XmbLookupString", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XmbLookupString([NativeTypeName("XIC")] XIC* ic, [NativeTypeName("XKeyPressedEvent *")] XKeyEvent* c_event, [NativeTypeName("char *")] sbyte* buffer_return, int bytes_buffer, [NativeTypeName("KeySym *")] UIntPtr* keysym_return, [NativeTypeName("int *")] int* status_return);

        [DllImport(libraryPath, EntryPoint = "XwcLookupString", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XwcLookupString([NativeTypeName("XIC")] XIC* ic, [NativeTypeName("XKeyPressedEvent *")] XKeyEvent* c_event, [NativeTypeName("wchar_t *")] int* buffer_return, int wchars_buffer, [NativeTypeName("KeySym *")] UIntPtr* keysym_return, [NativeTypeName("int *")] int* status_return);

        [DllImport(libraryPath, EntryPoint = "Xutf8LookupString", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Xutf8LookupString([NativeTypeName("XIC")] XIC* ic, [NativeTypeName("XKeyPressedEvent *")] XKeyEvent* c_event, [NativeTypeName("char *")] sbyte* buffer_return, int bytes_return, [NativeTypeName("KeySym *")] UIntPtr* keysym_return, [NativeTypeName("int *")] int* status_return);

        [DllImport(libraryPath, EntryPoint = "XVaCreateNestedList", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XVaNestedList")]
        public static extern void* XVaCreateNestedList(int unused);

        [DllImport(libraryPath, EntryPoint = "XRegisterIMInstantiateCallback", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XRegisterIMInstantiateCallback([NativeTypeName("Display *")] UIntPtr dpy, [NativeTypeName("struct XrmHashBucketRec *")] XrmHashBucketRec* rdb, [NativeTypeName("char *")] sbyte* res_name, [NativeTypeName("char *")] sbyte* res_class, [NativeTypeName("XIDProc")] IntPtr callback, [NativeTypeName("XPointer")] sbyte* client_data);

        [DllImport(libraryPath, EntryPoint = "XUnregisterIMInstantiateCallback", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XUnregisterIMInstantiateCallback([NativeTypeName("Display *")] UIntPtr dpy, [NativeTypeName("struct XrmHashBucketRec *")] XrmHashBucketRec* rdb, [NativeTypeName("char *")] sbyte* res_name, [NativeTypeName("char *")] sbyte* res_class, [NativeTypeName("XIDProc")] IntPtr callback, [NativeTypeName("XPointer")] sbyte* client_data);

        [DllImport(libraryPath, EntryPoint = "XInternalConnectionNumbers", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XInternalConnectionNumbers([NativeTypeName("Display *")] UIntPtr dpy, [NativeTypeName("int **")] int** fd_return, [NativeTypeName("int *")] int* count_return);

        [DllImport(libraryPath, EntryPoint = "XProcessInternalConnection", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XProcessInternalConnection([NativeTypeName("Display *")] UIntPtr dpy, int fd);

        [DllImport(libraryPath, EntryPoint = "XAddConnectionWatch", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XAddConnectionWatch([NativeTypeName("Display *")] UIntPtr dpy, [NativeTypeName("XConnectionWatchProc")] IntPtr callback, [NativeTypeName("XPointer")] sbyte* client_data);

        [DllImport(libraryPath, EntryPoint = "XRemoveConnectionWatch", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XRemoveConnectionWatch([NativeTypeName("Display *")] UIntPtr dpy, [NativeTypeName("XConnectionWatchProc")] IntPtr callback, [NativeTypeName("XPointer")] sbyte* client_data);

        [DllImport(libraryPath, EntryPoint = "XSetAuthorization", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XSetAuthorization([NativeTypeName("char *")] sbyte* name, int namelen, [NativeTypeName("char *")] sbyte* data, int datalen);

        [DllImport(libraryPath, EntryPoint = "_Xmbtowc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _Xmbtowc([NativeTypeName("wchar_t *")] int* wstr, [NativeTypeName("char *")] sbyte* str, int len);

        [DllImport(libraryPath, EntryPoint = "_Xwctomb", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _Xwctomb([NativeTypeName("char *")] sbyte* str, [NativeTypeName("wchar_t")] int wc);

        [DllImport(libraryPath, EntryPoint = "XGetEventData", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetEventData([NativeTypeName("Display *")] UIntPtr dpy, [NativeTypeName("XGenericEventCookie *")] XGenericEventCookie* cookie);

        [DllImport(libraryPath, EntryPoint = "XFreeEventData", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XFreeEventData([NativeTypeName("Display *")] UIntPtr dpy, [NativeTypeName("XGenericEventCookie *")] XGenericEventCookie* cookie);
    }
}
