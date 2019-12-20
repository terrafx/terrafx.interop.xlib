// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Xlib
    {
        [DllImport(LibraryPath, EntryPoint = "_Xmblen", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int _Xmblen([NativeTypeName("char *")] sbyte* str, int len);

        // public static extern int _Xdebug;

        [DllImport(LibraryPath, EntryPoint = "XLoadQueryFont", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XFontStruct *")]
        public static extern XFontStruct* XLoadQueryFont([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("const char *")] sbyte* name);

        [DllImport(LibraryPath, EntryPoint = "XQueryFont", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XFontStruct *")]
        public static extern XFontStruct* XQueryFont([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("XID")] UIntPtr font_ID);

        [DllImport(LibraryPath, EntryPoint = "XGetMotionEvents", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XTimeCoord *")]
        public static extern XTimeCoord* XGetMotionEvents([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("Time")] UIntPtr start, [NativeTypeName("Time")] UIntPtr stop, [NativeTypeName("int *")] int* nevents_return);

        [DllImport(LibraryPath, EntryPoint = "XDeleteModifiermapEntry", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XModifierKeymap *")]
        public static extern XModifierKeymap* XDeleteModifiermapEntry([NativeTypeName("XModifierKeymap *")] XModifierKeymap* modmap, [NativeTypeName("KeyCode")] byte keycode_entry, int modifier);

        [DllImport(LibraryPath, EntryPoint = "XGetModifierMapping", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XModifierKeymap *")]
        public static extern XModifierKeymap* XGetModifierMapping([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(LibraryPath, EntryPoint = "XInsertModifiermapEntry", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XModifierKeymap *")]
        public static extern XModifierKeymap* XInsertModifiermapEntry([NativeTypeName("XModifierKeymap *")] XModifierKeymap* modmap, [NativeTypeName("KeyCode")] byte keycode_entry, int modifier);

        [DllImport(LibraryPath, EntryPoint = "XNewModifiermap", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XModifierKeymap *")]
        public static extern XModifierKeymap* XNewModifiermap(int max_keys_per_mod);

        [DllImport(LibraryPath, EntryPoint = "XCreateImage", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XImage *")]
        public static extern XImage* XCreateImage([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Visual *")] Visual* visual, [NativeTypeName("unsigned int")] uint depth, int format, int offset, [NativeTypeName("char *")] sbyte* data, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height, int bitmap_pad, int bytes_per_line);

        [DllImport(LibraryPath, EntryPoint = "XInitImage", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XInitImage([NativeTypeName("XImage *")] XImage* image);

        [DllImport(LibraryPath, EntryPoint = "XGetImage", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XImage *")]
        public static extern XImage* XGetImage([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, int x, int y, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height, [NativeTypeName("unsigned long")] UIntPtr plane_mask, int format);

        [DllImport(LibraryPath, EntryPoint = "XGetSubImage", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XImage *")]
        public static extern XImage* XGetSubImage([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, int x, int y, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height, [NativeTypeName("unsigned long")] UIntPtr plane_mask, int format, [NativeTypeName("XImage *")] XImage* dest_image, int dest_x, int dest_y);

        [DllImport(LibraryPath, EntryPoint = "XOpenDisplay", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Display *")]
        public static extern UIntPtr XOpenDisplay([NativeTypeName("const char *")] sbyte* display_name);

        [DllImport(LibraryPath, EntryPoint = "XrmInitialize", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XrmInitialize();

        [DllImport(LibraryPath, EntryPoint = "XFetchBytes", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XFetchBytes([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("int *")] int* nbytes_return);

        [DllImport(LibraryPath, EntryPoint = "XFetchBuffer", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XFetchBuffer([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("int *")] int* nbytes_return, int buffer);

        [DllImport(LibraryPath, EntryPoint = "XGetAtomName", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XGetAtomName([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Atom")] UIntPtr atom);

        [DllImport(LibraryPath, EntryPoint = "XGetAtomNames", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetAtomNames([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Atom *")] UIntPtr* atoms, int count, [NativeTypeName("char **")] sbyte** names_return);

        [DllImport(LibraryPath, EntryPoint = "XGetDefault", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XGetDefault([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("const char *")] sbyte* program, [NativeTypeName("const char *")] sbyte* option);

        [DllImport(LibraryPath, EntryPoint = "XDisplayName", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XDisplayName([NativeTypeName("const char *")] sbyte* c_string);

        [DllImport(LibraryPath, EntryPoint = "XKeysymToString", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XKeysymToString([NativeTypeName("KeySym")] UIntPtr keysym);

        [DllImport(LibraryPath, EntryPoint = "XSynchronize", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int (*)(Display *)")]
        public static extern IntPtr XSynchronize([NativeTypeName("Display *")] UIntPtr display, int onoff);

        [DllImport(LibraryPath, EntryPoint = "XSetAfterFunction", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int (*)(Display *)")]
        public static extern IntPtr XSetAfterFunction([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("int (*)(Display *)")] IntPtr procedure);

        [DllImport(LibraryPath, EntryPoint = "XInternAtom", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Atom")]
        public static extern UIntPtr XInternAtom([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("const char *")] sbyte* atom_name, int only_if_exists);

        [DllImport(LibraryPath, EntryPoint = "XInternAtoms", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XInternAtoms([NativeTypeName("Display *")] UIntPtr dpy, [NativeTypeName("char **")] sbyte** names, int count, int onlyIfExists, [NativeTypeName("Atom *")] UIntPtr* atoms_return);

        [DllImport(LibraryPath, EntryPoint = "XCopyColormapAndFree", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Colormap")]
        public static extern UIntPtr XCopyColormapAndFree([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Colormap")] UIntPtr colormap);

        [DllImport(LibraryPath, EntryPoint = "XCreateColormap", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Colormap")]
        public static extern UIntPtr XCreateColormap([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("Visual *")] Visual* visual, int alloc);

        [DllImport(LibraryPath, EntryPoint = "XCreatePixmapCursor", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Cursor")]
        public static extern UIntPtr XCreatePixmapCursor([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Pixmap")] UIntPtr source, [NativeTypeName("Pixmap")] UIntPtr mask, [NativeTypeName("XColor *")] XColor* foreground_color, [NativeTypeName("XColor *")] XColor* background_color, [NativeTypeName("unsigned int")] uint x, [NativeTypeName("unsigned int")] uint y);

        [DllImport(LibraryPath, EntryPoint = "XCreateGlyphCursor", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Cursor")]
        public static extern UIntPtr XCreateGlyphCursor([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Font")] UIntPtr source_font, [NativeTypeName("Font")] UIntPtr mask_font, [NativeTypeName("unsigned int")] uint source_char, [NativeTypeName("unsigned int")] uint mask_char, [NativeTypeName("const XColor *")] XColor* foreground_color, [NativeTypeName("const XColor *")] XColor* background_color);

        [DllImport(LibraryPath, EntryPoint = "XCreateFontCursor", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Cursor")]
        public static extern UIntPtr XCreateFontCursor([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("unsigned int")] uint shape);

        [DllImport(LibraryPath, EntryPoint = "XLoadFont", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Font")]
        public static extern UIntPtr XLoadFont([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("const char *")] sbyte* name);

        [DllImport(LibraryPath, EntryPoint = "XCreateGC", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GC")]
        public static extern XGC* XCreateGC([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("unsigned long")] UIntPtr valuemask, [NativeTypeName("XGCValues *")] XGCValues* values);

        [DllImport(LibraryPath, EntryPoint = "XGContextFromGC", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GContext")]
        public static extern UIntPtr XGContextFromGC([NativeTypeName("GC")] XGC* gc);

        [DllImport(LibraryPath, EntryPoint = "XFlushGC", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XFlushGC([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("GC")] XGC* gc);

        [DllImport(LibraryPath, EntryPoint = "XCreatePixmap", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Pixmap")]
        public static extern UIntPtr XCreatePixmap([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height, [NativeTypeName("unsigned int")] uint depth);

        [DllImport(LibraryPath, EntryPoint = "XCreateBitmapFromData", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Pixmap")]
        public static extern UIntPtr XCreateBitmapFromData([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("const char *")] sbyte* data, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height);

        [DllImport(LibraryPath, EntryPoint = "XCreatePixmapFromBitmapData", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Pixmap")]
        public static extern UIntPtr XCreatePixmapFromBitmapData([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("char *")] sbyte* data, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height, [NativeTypeName("unsigned long")] UIntPtr fg, [NativeTypeName("unsigned long")] UIntPtr bg, [NativeTypeName("unsigned int")] uint depth);

        [DllImport(LibraryPath, EntryPoint = "XCreateSimpleWindow", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Window")]
        public static extern UIntPtr XCreateSimpleWindow([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr parent, int x, int y, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height, [NativeTypeName("unsigned int")] uint border_width, [NativeTypeName("unsigned long")] UIntPtr border, [NativeTypeName("unsigned long")] UIntPtr background);

        [DllImport(LibraryPath, EntryPoint = "XGetSelectionOwner", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Window")]
        public static extern UIntPtr XGetSelectionOwner([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Atom")] UIntPtr selection);

        [DllImport(LibraryPath, EntryPoint = "XCreateWindow", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Window")]
        public static extern UIntPtr XCreateWindow([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr parent, int x, int y, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height, [NativeTypeName("unsigned int")] uint border_width, int depth, [NativeTypeName("unsigned int")] uint c_class, [NativeTypeName("Visual *")] Visual* visual, [NativeTypeName("unsigned long")] UIntPtr valuemask, [NativeTypeName("XSetWindowAttributes *")] XSetWindowAttributes* attributes);

        [DllImport(LibraryPath, EntryPoint = "XListInstalledColormaps", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Colormap *")]
        public static extern UIntPtr* XListInstalledColormaps([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("int *")] int* num_return);

        [DllImport(LibraryPath, EntryPoint = "XListFonts", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char **")]
        public static extern sbyte** XListFonts([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("const char *")] sbyte* pattern, int maxnames, [NativeTypeName("int *")] int* actual_count_return);

        [DllImport(LibraryPath, EntryPoint = "XListFontsWithInfo", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char **")]
        public static extern sbyte** XListFontsWithInfo([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("const char *")] sbyte* pattern, int maxnames, [NativeTypeName("int *")] int* count_return, [NativeTypeName("XFontStruct **")] XFontStruct** info_return);

        [DllImport(LibraryPath, EntryPoint = "XGetFontPath", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char **")]
        public static extern sbyte** XGetFontPath([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("int *")] int* npaths_return);

        [DllImport(LibraryPath, EntryPoint = "XListExtensions", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char **")]
        public static extern sbyte** XListExtensions([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("int *")] int* nextensions_return);

        [DllImport(LibraryPath, EntryPoint = "XListProperties", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Atom *")]
        public static extern UIntPtr* XListProperties([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("int *")] int* num_prop_Return);

        [DllImport(LibraryPath, EntryPoint = "XListHosts", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XHostAddress *")]
        public static extern XHostAddress* XListHosts([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("int *")] int* nhosts_return, [NativeTypeName("int *")] int* state_return);

        [DllImport(LibraryPath, EntryPoint = "XKeycodeToKeysym", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("KeySym")]
        public static extern UIntPtr XKeycodeToKeysym([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("KeyCode")] byte keycode, int index);

        [DllImport(LibraryPath, EntryPoint = "XLookupKeysym", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("KeySym")]
        public static extern UIntPtr XLookupKeysym([NativeTypeName("XKeyEvent *")] XKeyEvent* key_event, int index);

        [DllImport(LibraryPath, EntryPoint = "XGetKeyboardMapping", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("KeySym *")]
        public static extern UIntPtr* XGetKeyboardMapping([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("KeyCode")] byte first_keycode, int keycode_count, [NativeTypeName("int *")] int* keysyms_per_keycode_return);

        [DllImport(LibraryPath, EntryPoint = "XStringToKeysym", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("KeySym")]
        public static extern UIntPtr XStringToKeysym([NativeTypeName("const char *")] sbyte* c_string);

        [DllImport(LibraryPath, EntryPoint = "XMaxRequestSize", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern IntPtr XMaxRequestSize([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(LibraryPath, EntryPoint = "XExtendedMaxRequestSize", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern IntPtr XExtendedMaxRequestSize([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(LibraryPath, EntryPoint = "XResourceManagerString", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XResourceManagerString([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(LibraryPath, EntryPoint = "XScreenResourceString", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XScreenResourceString([NativeTypeName("Screen *")] Screen* screen);

        [DllImport(LibraryPath, EntryPoint = "XDisplayMotionBufferSize", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned long")]
        public static extern UIntPtr XDisplayMotionBufferSize([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(LibraryPath, EntryPoint = "XVisualIDFromVisual", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("VisualID")]
        public static extern UIntPtr XVisualIDFromVisual([NativeTypeName("Visual *")] Visual* visual);

        [DllImport(LibraryPath, EntryPoint = "XInitThreads", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XInitThreads();

        [DllImport(LibraryPath, EntryPoint = "XLockDisplay", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XLockDisplay([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(LibraryPath, EntryPoint = "XUnlockDisplay", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XUnlockDisplay([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(LibraryPath, EntryPoint = "XInitExtension", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XExtCodes *")]
        public static extern XExtCodes* XInitExtension([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("const char *")] sbyte* name);

        [DllImport(LibraryPath, EntryPoint = "XAddExtension", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XExtCodes *")]
        public static extern XExtCodes* XAddExtension([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(LibraryPath, EntryPoint = "XFindOnExtensionList", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XExtData *")]
        public static extern XExtData* XFindOnExtensionList([NativeTypeName("XExtData **")] XExtData** structure, int number);

        [DllImport(LibraryPath, EntryPoint = "XEHeadOfExtensionList", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XExtData **")]
        public static extern XExtData** XEHeadOfExtensionList(XEDataObject c_object);

        [DllImport(LibraryPath, EntryPoint = "XRootWindow", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Window")]
        public static extern UIntPtr XRootWindow([NativeTypeName("Display *")] UIntPtr display, int screen_number);

        [DllImport(LibraryPath, EntryPoint = "XDefaultRootWindow", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Window")]
        public static extern UIntPtr XDefaultRootWindow([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(LibraryPath, EntryPoint = "XRootWindowOfScreen", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Window")]
        public static extern UIntPtr XRootWindowOfScreen([NativeTypeName("Screen *")] Screen* screen);

        [DllImport(LibraryPath, EntryPoint = "XDefaultVisual", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Visual *")]
        public static extern Visual* XDefaultVisual([NativeTypeName("Display *")] UIntPtr display, int screen_number);

        [DllImport(LibraryPath, EntryPoint = "XDefaultVisualOfScreen", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Visual *")]
        public static extern Visual* XDefaultVisualOfScreen([NativeTypeName("Screen *")] Screen* screen);

        [DllImport(LibraryPath, EntryPoint = "XDefaultGC", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GC")]
        public static extern XGC* XDefaultGC([NativeTypeName("Display *")] UIntPtr display, int screen_number);

        [DllImport(LibraryPath, EntryPoint = "XDefaultGCOfScreen", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GC")]
        public static extern XGC* XDefaultGCOfScreen([NativeTypeName("Screen *")] Screen* screen);

        [DllImport(LibraryPath, EntryPoint = "XBlackPixel", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned long")]
        public static extern UIntPtr XBlackPixel([NativeTypeName("Display *")] UIntPtr display, int screen_number);

        [DllImport(LibraryPath, EntryPoint = "XWhitePixel", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned long")]
        public static extern UIntPtr XWhitePixel([NativeTypeName("Display *")] UIntPtr display, int screen_number);

        [DllImport(LibraryPath, EntryPoint = "XAllPlanes", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned long")]
        public static extern UIntPtr XAllPlanes();

        [DllImport(LibraryPath, EntryPoint = "XBlackPixelOfScreen", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned long")]
        public static extern UIntPtr XBlackPixelOfScreen([NativeTypeName("Screen *")] Screen* screen);

        [DllImport(LibraryPath, EntryPoint = "XWhitePixelOfScreen", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned long")]
        public static extern UIntPtr XWhitePixelOfScreen([NativeTypeName("Screen *")] Screen* screen);

        [DllImport(LibraryPath, EntryPoint = "XNextRequest", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned long")]
        public static extern UIntPtr XNextRequest([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(LibraryPath, EntryPoint = "XLastKnownRequestProcessed", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned long")]
        public static extern UIntPtr XLastKnownRequestProcessed([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(LibraryPath, EntryPoint = "XServerVendor", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XServerVendor([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(LibraryPath, EntryPoint = "XDisplayString", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XDisplayString([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(LibraryPath, EntryPoint = "XDefaultColormap", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Colormap")]
        public static extern UIntPtr XDefaultColormap([NativeTypeName("Display *")] UIntPtr display, int screen_number);

        [DllImport(LibraryPath, EntryPoint = "XDefaultColormapOfScreen", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Colormap")]
        public static extern UIntPtr XDefaultColormapOfScreen([NativeTypeName("Screen *")] Screen* screen);

        [DllImport(LibraryPath, EntryPoint = "XDisplayOfScreen", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Display *")]
        public static extern UIntPtr XDisplayOfScreen([NativeTypeName("Screen *")] Screen* screen);

        [DllImport(LibraryPath, EntryPoint = "XScreenOfDisplay", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Screen *")]
        public static extern Screen* XScreenOfDisplay([NativeTypeName("Display *")] UIntPtr display, int screen_number);

        [DllImport(LibraryPath, EntryPoint = "XDefaultScreenOfDisplay", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Screen *")]
        public static extern Screen* XDefaultScreenOfDisplay([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(LibraryPath, EntryPoint = "XEventMaskOfScreen", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern IntPtr XEventMaskOfScreen([NativeTypeName("Screen *")] Screen* screen);

        [DllImport(LibraryPath, EntryPoint = "XScreenNumberOfScreen", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XScreenNumberOfScreen([NativeTypeName("Screen *")] Screen* screen);

        [DllImport(LibraryPath, EntryPoint = "XSetErrorHandler", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XErrorHandler")]
        public static extern IntPtr XSetErrorHandler([NativeTypeName("XErrorHandler")] IntPtr handler);

        [DllImport(LibraryPath, EntryPoint = "XSetIOErrorHandler", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XIOErrorHandler")]
        public static extern IntPtr XSetIOErrorHandler([NativeTypeName("XIOErrorHandler")] IntPtr handler);

        [DllImport(LibraryPath, EntryPoint = "XListPixmapFormats", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XPixmapFormatValues *")]
        public static extern XPixmapFormatValues* XListPixmapFormats([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("int *")] int* count_return);

        [DllImport(LibraryPath, EntryPoint = "XListDepths", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int *")]
        public static extern int* XListDepths([NativeTypeName("Display *")] UIntPtr display, int screen_number, [NativeTypeName("int *")] int* count_return);

        [DllImport(LibraryPath, EntryPoint = "XReconfigureWMWindow", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XReconfigureWMWindow([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, int screen_number, [NativeTypeName("unsigned int")] uint mask, [NativeTypeName("XWindowChanges *")] XWindowChanges* changes);

        [DllImport(LibraryPath, EntryPoint = "XGetWMProtocols", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetWMProtocols([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("Atom **")] UIntPtr** protocols_return, [NativeTypeName("int *")] int* count_return);

        [DllImport(LibraryPath, EntryPoint = "XSetWMProtocols", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetWMProtocols([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("Atom *")] UIntPtr* protocols, int count);

        [DllImport(LibraryPath, EntryPoint = "XIconifyWindow", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XIconifyWindow([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, int screen_number);

        [DllImport(LibraryPath, EntryPoint = "XWithdrawWindow", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XWithdrawWindow([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, int screen_number);

        [DllImport(LibraryPath, EntryPoint = "XGetCommand", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetCommand([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("char ***")] sbyte*** argv_return, [NativeTypeName("int *")] int* argc_return);

        [DllImport(LibraryPath, EntryPoint = "XGetWMColormapWindows", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetWMColormapWindows([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("Window **")] UIntPtr** windows_return, [NativeTypeName("int *")] int* count_return);

        [DllImport(LibraryPath, EntryPoint = "XSetWMColormapWindows", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetWMColormapWindows([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("Window *")] UIntPtr* colormap_windows, int count);

        [DllImport(LibraryPath, EntryPoint = "XFreeStringList", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XFreeStringList([NativeTypeName("char **")] sbyte** list);

        [DllImport(LibraryPath, EntryPoint = "XSetTransientForHint", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetTransientForHint([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("Window")] UIntPtr prop_window);

        [DllImport(LibraryPath, EntryPoint = "XActivateScreenSaver", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XActivateScreenSaver([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(LibraryPath, EntryPoint = "XAddHost", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XAddHost([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("XHostAddress *")] XHostAddress* host);

        [DllImport(LibraryPath, EntryPoint = "XAddHosts", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XAddHosts([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("XHostAddress *")] XHostAddress* hosts, int num_hosts);

        [DllImport(LibraryPath, EntryPoint = "XAddToExtensionList", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XAddToExtensionList([NativeTypeName("struct XExtData **")] XExtData** structure, [NativeTypeName("XExtData *")] XExtData* ext_data);

        [DllImport(LibraryPath, EntryPoint = "XAddToSaveSet", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XAddToSaveSet([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w);

        [DllImport(LibraryPath, EntryPoint = "XAllocColor", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XAllocColor([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Colormap")] UIntPtr colormap, [NativeTypeName("XColor *")] XColor* screen_in_out);

        [DllImport(LibraryPath, EntryPoint = "XAllocColorCells", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XAllocColorCells([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Colormap")] UIntPtr colormap, int contig, [NativeTypeName("unsigned long *")] UIntPtr* plane_masks_return, [NativeTypeName("unsigned int")] uint nplanes, [NativeTypeName("unsigned long *")] UIntPtr* pixels_return, [NativeTypeName("unsigned int")] uint npixels);

        [DllImport(LibraryPath, EntryPoint = "XAllocColorPlanes", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XAllocColorPlanes([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Colormap")] UIntPtr colormap, int contig, [NativeTypeName("unsigned long *")] UIntPtr* pixels_return, int ncolors, int nreds, int ngreens, int nblues, [NativeTypeName("unsigned long *")] UIntPtr* rmask_return, [NativeTypeName("unsigned long *")] UIntPtr* gmask_return, [NativeTypeName("unsigned long *")] UIntPtr* bmask_return);

        [DllImport(LibraryPath, EntryPoint = "XAllocNamedColor", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XAllocNamedColor([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Colormap")] UIntPtr colormap, [NativeTypeName("const char *")] sbyte* color_name, [NativeTypeName("XColor *")] XColor* screen_def_return, [NativeTypeName("XColor *")] XColor* exact_def_return);

        [DllImport(LibraryPath, EntryPoint = "XAllowEvents", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XAllowEvents([NativeTypeName("Display *")] UIntPtr display, int event_mode, [NativeTypeName("Time")] UIntPtr time);

        [DllImport(LibraryPath, EntryPoint = "XAutoRepeatOff", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XAutoRepeatOff([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(LibraryPath, EntryPoint = "XAutoRepeatOn", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XAutoRepeatOn([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(LibraryPath, EntryPoint = "XBell", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XBell([NativeTypeName("Display *")] UIntPtr display, int percent);

        [DllImport(LibraryPath, EntryPoint = "XBitmapBitOrder", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XBitmapBitOrder([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(LibraryPath, EntryPoint = "XBitmapPad", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XBitmapPad([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(LibraryPath, EntryPoint = "XBitmapUnit", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XBitmapUnit([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(LibraryPath, EntryPoint = "XCellsOfScreen", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XCellsOfScreen([NativeTypeName("Screen *")] Screen* screen);

        [DllImport(LibraryPath, EntryPoint = "XChangeActivePointerGrab", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XChangeActivePointerGrab([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("unsigned int")] uint event_mask, [NativeTypeName("Cursor")] UIntPtr cursor, [NativeTypeName("Time")] UIntPtr time);

        [DllImport(LibraryPath, EntryPoint = "XChangeGC", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XChangeGC([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("GC")] XGC* gc, [NativeTypeName("unsigned long")] UIntPtr valuemask, [NativeTypeName("XGCValues *")] XGCValues* values);

        [DllImport(LibraryPath, EntryPoint = "XChangeKeyboardControl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XChangeKeyboardControl([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("unsigned long")] UIntPtr value_mask, [NativeTypeName("XKeyboardControl *")] XKeyboardControl* values);

        [DllImport(LibraryPath, EntryPoint = "XChangeKeyboardMapping", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XChangeKeyboardMapping([NativeTypeName("Display *")] UIntPtr display, int first_keycode, int keysyms_per_keycode, [NativeTypeName("KeySym *")] UIntPtr* keysyms, int num_codes);

        [DllImport(LibraryPath, EntryPoint = "XChangePointerControl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XChangePointerControl([NativeTypeName("Display *")] UIntPtr display, int do_accel, int do_threshold, int accel_numerator, int accel_denominator, int threshold);

        [DllImport(LibraryPath, EntryPoint = "XChangeProperty", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XChangeProperty([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("Atom")] UIntPtr property, [NativeTypeName("Atom")] UIntPtr type, int format, int mode, [NativeTypeName("const unsigned char *")] byte* data, int nelements);

        [DllImport(LibraryPath, EntryPoint = "XChangeSaveSet", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XChangeSaveSet([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, int change_mode);

        [DllImport(LibraryPath, EntryPoint = "XChangeWindowAttributes", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XChangeWindowAttributes([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("unsigned long")] UIntPtr valuemask, [NativeTypeName("XSetWindowAttributes *")] XSetWindowAttributes* attributes);

        [DllImport(LibraryPath, EntryPoint = "XCheckIfEvent", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XCheckIfEvent([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("XEvent *")] XEvent* event_return, [NativeTypeName("int (*)(Display *, XEvent *, XPointer)")] IntPtr predicate, [NativeTypeName("XPointer")] sbyte* arg);

        [DllImport(LibraryPath, EntryPoint = "XCheckMaskEvent", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XCheckMaskEvent([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("long")] IntPtr event_mask, [NativeTypeName("XEvent *")] XEvent* event_return);

        [DllImport(LibraryPath, EntryPoint = "XCheckTypedEvent", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XCheckTypedEvent([NativeTypeName("Display *")] UIntPtr display, int event_type, [NativeTypeName("XEvent *")] XEvent* event_return);

        [DllImport(LibraryPath, EntryPoint = "XCheckTypedWindowEvent", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XCheckTypedWindowEvent([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, int event_type, [NativeTypeName("XEvent *")] XEvent* event_return);

        [DllImport(LibraryPath, EntryPoint = "XCheckWindowEvent", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XCheckWindowEvent([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("long")] IntPtr event_mask, [NativeTypeName("XEvent *")] XEvent* event_return);

        [DllImport(LibraryPath, EntryPoint = "XCirculateSubwindows", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XCirculateSubwindows([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, int direction);

        [DllImport(LibraryPath, EntryPoint = "XCirculateSubwindowsDown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XCirculateSubwindowsDown([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w);

        [DllImport(LibraryPath, EntryPoint = "XCirculateSubwindowsUp", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XCirculateSubwindowsUp([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w);

        [DllImport(LibraryPath, EntryPoint = "XClearArea", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XClearArea([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, int x, int y, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height, int exposures);

        [DllImport(LibraryPath, EntryPoint = "XClearWindow", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XClearWindow([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w);

        [DllImport(LibraryPath, EntryPoint = "XCloseDisplay", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XCloseDisplay([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(LibraryPath, EntryPoint = "XConfigureWindow", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XConfigureWindow([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("unsigned int")] uint value_mask, [NativeTypeName("XWindowChanges *")] XWindowChanges* values);

        [DllImport(LibraryPath, EntryPoint = "XConnectionNumber", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XConnectionNumber([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(LibraryPath, EntryPoint = "XConvertSelection", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XConvertSelection([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Atom")] UIntPtr selection, [NativeTypeName("Atom")] UIntPtr target, [NativeTypeName("Atom")] UIntPtr property, [NativeTypeName("Window")] UIntPtr requestor, [NativeTypeName("Time")] UIntPtr time);

        [DllImport(LibraryPath, EntryPoint = "XCopyArea", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XCopyArea([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr src, [NativeTypeName("Drawable")] UIntPtr dest, [NativeTypeName("GC")] XGC* gc, int src_x, int src_y, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height, int dest_x, int dest_y);

        [DllImport(LibraryPath, EntryPoint = "XCopyGC", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XCopyGC([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("GC")] XGC* src, [NativeTypeName("unsigned long")] UIntPtr valuemask, [NativeTypeName("GC")] XGC* dest);

        [DllImport(LibraryPath, EntryPoint = "XCopyPlane", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XCopyPlane([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr src, [NativeTypeName("Drawable")] UIntPtr dest, [NativeTypeName("GC")] XGC* gc, int src_x, int src_y, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height, int dest_x, int dest_y, [NativeTypeName("unsigned long")] UIntPtr plane);

        [DllImport(LibraryPath, EntryPoint = "XDefaultDepth", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDefaultDepth([NativeTypeName("Display *")] UIntPtr display, int screen_number);

        [DllImport(LibraryPath, EntryPoint = "XDefaultDepthOfScreen", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDefaultDepthOfScreen([NativeTypeName("Screen *")] Screen* screen);

        [DllImport(LibraryPath, EntryPoint = "XDefaultScreen", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDefaultScreen([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(LibraryPath, EntryPoint = "XDefineCursor", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDefineCursor([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("Cursor")] UIntPtr cursor);

        [DllImport(LibraryPath, EntryPoint = "XDeleteProperty", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDeleteProperty([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("Atom")] UIntPtr property);

        [DllImport(LibraryPath, EntryPoint = "XDestroyWindow", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDestroyWindow([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w);

        [DllImport(LibraryPath, EntryPoint = "XDestroySubwindows", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDestroySubwindows([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w);

        [DllImport(LibraryPath, EntryPoint = "XDoesBackingStore", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDoesBackingStore([NativeTypeName("Screen *")] Screen* screen);

        [DllImport(LibraryPath, EntryPoint = "XDoesSaveUnders", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDoesSaveUnders([NativeTypeName("Screen *")] Screen* screen);

        [DllImport(LibraryPath, EntryPoint = "XDisableAccessControl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDisableAccessControl([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(LibraryPath, EntryPoint = "XDisplayCells", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDisplayCells([NativeTypeName("Display *")] UIntPtr display, int screen_number);

        [DllImport(LibraryPath, EntryPoint = "XDisplayHeight", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDisplayHeight([NativeTypeName("Display *")] UIntPtr display, int screen_number);

        [DllImport(LibraryPath, EntryPoint = "XDisplayHeightMM", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDisplayHeightMM([NativeTypeName("Display *")] UIntPtr display, int screen_number);

        [DllImport(LibraryPath, EntryPoint = "XDisplayKeycodes", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDisplayKeycodes([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("int *")] int* min_keycodes_return, [NativeTypeName("int *")] int* max_keycodes_return);

        [DllImport(LibraryPath, EntryPoint = "XDisplayPlanes", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDisplayPlanes([NativeTypeName("Display *")] UIntPtr display, int screen_numberm1);

        [DllImport(LibraryPath, EntryPoint = "XDisplayWidth", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDisplayWidth([NativeTypeName("Display *")] UIntPtr display, int screen_number);

        [DllImport(LibraryPath, EntryPoint = "XDisplayWidthMM", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDisplayWidthMM([NativeTypeName("Display *")] UIntPtr display, int screen_number);

        [DllImport(LibraryPath, EntryPoint = "XDrawArc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDrawArc([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("GC")] XGC* gc, int x, int y, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height, int angle1, int angle2);

        [DllImport(LibraryPath, EntryPoint = "XDrawArcs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDrawArcs([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("GC")] XGC* gc, [NativeTypeName("XArc *")] XArc* arcs, int narcs);

        [DllImport(LibraryPath, EntryPoint = "XDrawImageString", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDrawImageString([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("GC")] XGC* gc, int x, int y, [NativeTypeName("const char *")] sbyte* c_string, int length);

        [DllImport(LibraryPath, EntryPoint = "XDrawImageString16", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDrawImageString16([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("GC")] XGC* gc, int x, int y, [NativeTypeName("const XChar2b *")] XChar2b* c_string, int length);

        [DllImport(LibraryPath, EntryPoint = "XDrawLine", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDrawLine([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("GC")] XGC* gc, int x1, int y1, int x2, int y2);

        [DllImport(LibraryPath, EntryPoint = "XDrawLines", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDrawLines([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("GC")] XGC* gc, [NativeTypeName("XPoint *")] XPoint* points, int npoints, int mode);

        [DllImport(LibraryPath, EntryPoint = "XDrawPoint", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDrawPoint([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("GC")] XGC* gc, int x, int y);

        [DllImport(LibraryPath, EntryPoint = "XDrawPoints", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDrawPoints([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("GC")] XGC* gc, [NativeTypeName("XPoint *")] XPoint* points, int npoints, int mode);

        [DllImport(LibraryPath, EntryPoint = "XDrawRectangle", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDrawRectangle([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("GC")] XGC* gc, int x, int y, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height);

        [DllImport(LibraryPath, EntryPoint = "XDrawRectangles", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDrawRectangles([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("GC")] XGC* gc, [NativeTypeName("XRectangle *")] XRectangle* rectangles, int nrectangles);

        [DllImport(LibraryPath, EntryPoint = "XDrawSegments", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDrawSegments([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("GC")] XGC* gc, [NativeTypeName("XSegment *")] XSegment* segments, int nsegments);

        [DllImport(LibraryPath, EntryPoint = "XDrawString", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDrawString([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("GC")] XGC* gc, int x, int y, [NativeTypeName("const char *")] sbyte* c_string, int length);

        [DllImport(LibraryPath, EntryPoint = "XDrawString16", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDrawString16([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("GC")] XGC* gc, int x, int y, [NativeTypeName("const XChar2b *")] XChar2b* c_string, int length);

        [DllImport(LibraryPath, EntryPoint = "XDrawText", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDrawText([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("GC")] XGC* gc, int x, int y, [NativeTypeName("XTextItem *")] XTextItem* items, int nitems);

        [DllImport(LibraryPath, EntryPoint = "XDrawText16", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDrawText16([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("GC")] XGC* gc, int x, int y, [NativeTypeName("XTextItem16 *")] XTextItem16* items, int nitems);

        [DllImport(LibraryPath, EntryPoint = "XEnableAccessControl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XEnableAccessControl([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(LibraryPath, EntryPoint = "XEventsQueued", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XEventsQueued([NativeTypeName("Display *")] UIntPtr display, int mode);

        [DllImport(LibraryPath, EntryPoint = "XFetchName", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XFetchName([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("char **")] sbyte** window_name_return);

        [DllImport(LibraryPath, EntryPoint = "XFillArc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XFillArc([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("GC")] XGC* gc, int x, int y, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height, int angle1, int angle2);

        [DllImport(LibraryPath, EntryPoint = "XFillArcs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XFillArcs([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("GC")] XGC* gc, [NativeTypeName("XArc *")] XArc* arcs, int narcs);

        [DllImport(LibraryPath, EntryPoint = "XFillPolygon", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XFillPolygon([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("GC")] XGC* gc, [NativeTypeName("XPoint *")] XPoint* points, int npoints, int shape, int mode);

        [DllImport(LibraryPath, EntryPoint = "XFillRectangle", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XFillRectangle([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("GC")] XGC* gc, int x, int y, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height);

        [DllImport(LibraryPath, EntryPoint = "XFillRectangles", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XFillRectangles([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("GC")] XGC* gc, [NativeTypeName("XRectangle *")] XRectangle* rectangles, int nrectangles);

        [DllImport(LibraryPath, EntryPoint = "XFlush", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XFlush([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(LibraryPath, EntryPoint = "XForceScreenSaver", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XForceScreenSaver([NativeTypeName("Display *")] UIntPtr display, int mode);

        [DllImport(LibraryPath, EntryPoint = "XFree", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XFree([NativeTypeName("void *")] void* data);

        [DllImport(LibraryPath, EntryPoint = "XFreeColormap", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XFreeColormap([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Colormap")] UIntPtr colormap);

        [DllImport(LibraryPath, EntryPoint = "XFreeColors", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XFreeColors([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Colormap")] UIntPtr colormap, [NativeTypeName("unsigned long *")] UIntPtr* pixels, int npixels, [NativeTypeName("unsigned long")] UIntPtr planes);

        [DllImport(LibraryPath, EntryPoint = "XFreeCursor", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XFreeCursor([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Cursor")] UIntPtr cursor);

        [DllImport(LibraryPath, EntryPoint = "XFreeExtensionList", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XFreeExtensionList([NativeTypeName("char **")] sbyte** list);

        [DllImport(LibraryPath, EntryPoint = "XFreeFont", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XFreeFont([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("XFontStruct *")] XFontStruct* font_struct);

        [DllImport(LibraryPath, EntryPoint = "XFreeFontInfo", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XFreeFontInfo([NativeTypeName("char **")] sbyte** names, [NativeTypeName("XFontStruct *")] XFontStruct* free_info, int actual_count);

        [DllImport(LibraryPath, EntryPoint = "XFreeFontNames", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XFreeFontNames([NativeTypeName("char **")] sbyte** list);

        [DllImport(LibraryPath, EntryPoint = "XFreeFontPath", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XFreeFontPath([NativeTypeName("char **")] sbyte** list);

        [DllImport(LibraryPath, EntryPoint = "XFreeGC", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XFreeGC([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("GC")] XGC* gc);

        [DllImport(LibraryPath, EntryPoint = "XFreeModifiermap", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XFreeModifiermap([NativeTypeName("XModifierKeymap *")] XModifierKeymap* modmap);

        [DllImport(LibraryPath, EntryPoint = "XFreePixmap", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XFreePixmap([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Pixmap")] UIntPtr pixmap);

        [DllImport(LibraryPath, EntryPoint = "XGeometry", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGeometry([NativeTypeName("Display *")] UIntPtr display, int screen, [NativeTypeName("const char *")] sbyte* position, [NativeTypeName("const char *")] sbyte* default_position, [NativeTypeName("unsigned int")] uint bwidth, [NativeTypeName("unsigned int")] uint fwidth, [NativeTypeName("unsigned int")] uint fheight, int xadder, int yadder, [NativeTypeName("int *")] int* x_return, [NativeTypeName("int *")] int* y_return, [NativeTypeName("int *")] int* width_return, [NativeTypeName("int *")] int* height_return);

        [DllImport(LibraryPath, EntryPoint = "XGetErrorDatabaseText", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetErrorDatabaseText([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* message, [NativeTypeName("const char *")] sbyte* default_string, [NativeTypeName("char *")] sbyte* buffer_return, int length);

        [DllImport(LibraryPath, EntryPoint = "XGetErrorText", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetErrorText([NativeTypeName("Display *")] UIntPtr display, int code, [NativeTypeName("char *")] sbyte* buffer_return, int length);

        [DllImport(LibraryPath, EntryPoint = "XGetFontProperty", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetFontProperty([NativeTypeName("XFontStruct *")] XFontStruct* font_struct, [NativeTypeName("Atom")] UIntPtr atom, [NativeTypeName("unsigned long *")] UIntPtr* value_return);

        [DllImport(LibraryPath, EntryPoint = "XGetGCValues", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetGCValues([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("GC")] XGC* gc, [NativeTypeName("unsigned long")] UIntPtr valuemask, [NativeTypeName("XGCValues *")] XGCValues* values_return);

        [DllImport(LibraryPath, EntryPoint = "XGetGeometry", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetGeometry([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("Window *")] UIntPtr* root_return, [NativeTypeName("int *")] int* x_return, [NativeTypeName("int *")] int* y_return, [NativeTypeName("unsigned int *")] uint* width_return, [NativeTypeName("unsigned int *")] uint* height_return, [NativeTypeName("unsigned int *")] uint* border_width_return, [NativeTypeName("unsigned int *")] uint* depth_return);

        [DllImport(LibraryPath, EntryPoint = "XGetIconName", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetIconName([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("char **")] sbyte** icon_name_return);

        [DllImport(LibraryPath, EntryPoint = "XGetInputFocus", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetInputFocus([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window *")] UIntPtr* focus_return, [NativeTypeName("int *")] int* revert_to_return);

        [DllImport(LibraryPath, EntryPoint = "XGetKeyboardControl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetKeyboardControl([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("XKeyboardState *")] XKeyboardState* values_return);

        [DllImport(LibraryPath, EntryPoint = "XGetPointerControl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetPointerControl([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("int *")] int* accel_numerator_return, [NativeTypeName("int *")] int* accel_denominator_return, [NativeTypeName("int *")] int* threshold_return);

        [DllImport(LibraryPath, EntryPoint = "XGetPointerMapping", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetPointerMapping([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("unsigned char *")] byte* map_return, int map);

        [DllImport(LibraryPath, EntryPoint = "XGetScreenSaver", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetScreenSaver([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("int *")] int* timeout_return, [NativeTypeName("int *")] int* interval_return, [NativeTypeName("int *")] int* prefer_blanking_return, [NativeTypeName("int *")] int* allow_exposures_return);

        [DllImport(LibraryPath, EntryPoint = "XGetTransientForHint", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetTransientForHint([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("Window *")] UIntPtr* prop_window_return);

        [DllImport(LibraryPath, EntryPoint = "XGetWindowProperty", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetWindowProperty([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("Atom")] UIntPtr property, [NativeTypeName("long")] IntPtr long_offset, [NativeTypeName("long")] IntPtr long_length, int delete, [NativeTypeName("Atom")] UIntPtr req_type, [NativeTypeName("Atom *")] UIntPtr* actual_type_return, [NativeTypeName("int *")] int* actual_format_return, [NativeTypeName("unsigned long *")] UIntPtr* nitems_return, [NativeTypeName("unsigned long *")] UIntPtr* bytes_after_return, [NativeTypeName("unsigned char **")] byte** prop_return);

        [DllImport(LibraryPath, EntryPoint = "XGetWindowAttributes", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetWindowAttributes([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("XWindowAttributes *")] XWindowAttributes* window_attributes_return);

        [DllImport(LibraryPath, EntryPoint = "XGrabButton", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGrabButton([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("unsigned int")] uint button, [NativeTypeName("unsigned int")] uint modifiers, [NativeTypeName("Window")] UIntPtr grab_window, int owner_events, [NativeTypeName("unsigned int")] uint event_mask, int pointer_mode, int keyboard_mode, [NativeTypeName("Window")] UIntPtr confine_to, [NativeTypeName("Cursor")] UIntPtr cursor);

        [DllImport(LibraryPath, EntryPoint = "XGrabKey", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGrabKey([NativeTypeName("Display *")] UIntPtr display, int keycode, [NativeTypeName("unsigned int")] uint modifiers, [NativeTypeName("Window")] UIntPtr grab_window, int owner_events, int pointer_mode, int keyboard_mode);

        [DllImport(LibraryPath, EntryPoint = "XGrabKeyboard", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGrabKeyboard([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr grab_window, int owner_events, int pointer_mode, int keyboard_mode, [NativeTypeName("Time")] UIntPtr time);

        [DllImport(LibraryPath, EntryPoint = "XGrabPointer", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGrabPointer([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr grab_window, int owner_events, [NativeTypeName("unsigned int")] uint event_mask, int pointer_mode, int keyboard_mode, [NativeTypeName("Window")] UIntPtr confine_to, [NativeTypeName("Cursor")] UIntPtr cursor, [NativeTypeName("Time")] UIntPtr time);

        [DllImport(LibraryPath, EntryPoint = "XGrabServer", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGrabServer([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(LibraryPath, EntryPoint = "XHeightMMOfScreen", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XHeightMMOfScreen([NativeTypeName("Screen *")] Screen* screen);

        [DllImport(LibraryPath, EntryPoint = "XHeightOfScreen", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XHeightOfScreen([NativeTypeName("Screen *")] Screen* screen);

        [DllImport(LibraryPath, EntryPoint = "XIfEvent", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XIfEvent([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("XEvent *")] XEvent* event_return, [NativeTypeName("int (*)(Display *, XEvent *, XPointer)")] IntPtr predicate, [NativeTypeName("XPointer")] sbyte* arg);

        [DllImport(LibraryPath, EntryPoint = "XImageByteOrder", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XImageByteOrder([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(LibraryPath, EntryPoint = "XInstallColormap", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XInstallColormap([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Colormap")] UIntPtr colormap);

        [DllImport(LibraryPath, EntryPoint = "XKeysymToKeycode", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("KeyCode")]
        public static extern byte XKeysymToKeycode([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("KeySym")] UIntPtr keysym);

        [DllImport(LibraryPath, EntryPoint = "XKillClient", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XKillClient([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("XID")] UIntPtr resource);

        [DllImport(LibraryPath, EntryPoint = "XLookupColor", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XLookupColor([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Colormap")] UIntPtr colormap, [NativeTypeName("const char *")] sbyte* color_name, [NativeTypeName("XColor *")] XColor* exact_def_return, [NativeTypeName("XColor *")] XColor* screen_def_return);

        [DllImport(LibraryPath, EntryPoint = "XLowerWindow", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XLowerWindow([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w);

        [DllImport(LibraryPath, EntryPoint = "XMapRaised", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XMapRaised([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w);

        [DllImport(LibraryPath, EntryPoint = "XMapSubwindows", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XMapSubwindows([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w);

        [DllImport(LibraryPath, EntryPoint = "XMapWindow", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XMapWindow([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w);

        [DllImport(LibraryPath, EntryPoint = "XMaskEvent", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XMaskEvent([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("long")] IntPtr event_mask, [NativeTypeName("XEvent *")] XEvent* event_return);

        [DllImport(LibraryPath, EntryPoint = "XMaxCmapsOfScreen", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XMaxCmapsOfScreen([NativeTypeName("Screen *")] Screen* screen);

        [DllImport(LibraryPath, EntryPoint = "XMinCmapsOfScreen", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XMinCmapsOfScreen([NativeTypeName("Screen *")] Screen* screen);

        [DllImport(LibraryPath, EntryPoint = "XMoveResizeWindow", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XMoveResizeWindow([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, int x, int y, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height);

        [DllImport(LibraryPath, EntryPoint = "XMoveWindow", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XMoveWindow([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, int x, int y);

        [DllImport(LibraryPath, EntryPoint = "XNextEvent", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XNextEvent([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("XEvent *")] XEvent* event_return);

        [DllImport(LibraryPath, EntryPoint = "XNoOp", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XNoOp([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(LibraryPath, EntryPoint = "XParseColor", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XParseColor([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Colormap")] UIntPtr colormap, [NativeTypeName("const char *")] sbyte* spec, [NativeTypeName("XColor *")] XColor* exact_def_return);

        [DllImport(LibraryPath, EntryPoint = "XParseGeometry", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XParseGeometry([NativeTypeName("const char *")] sbyte* parsestring, [NativeTypeName("int *")] int* x_return, [NativeTypeName("int *")] int* y_return, [NativeTypeName("unsigned int *")] uint* width_return, [NativeTypeName("unsigned int *")] uint* height_return);

        [DllImport(LibraryPath, EntryPoint = "XPeekEvent", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XPeekEvent([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("XEvent *")] XEvent* event_return);

        [DllImport(LibraryPath, EntryPoint = "XPeekIfEvent", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XPeekIfEvent([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("XEvent *")] XEvent* event_return, [NativeTypeName("int (*)(Display *, XEvent *, XPointer)")] IntPtr predicate, [NativeTypeName("XPointer")] sbyte* arg);

        [DllImport(LibraryPath, EntryPoint = "XPending", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XPending([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(LibraryPath, EntryPoint = "XPlanesOfScreen", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XPlanesOfScreen([NativeTypeName("Screen *")] Screen* screen);

        [DllImport(LibraryPath, EntryPoint = "XProtocolRevision", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XProtocolRevision([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(LibraryPath, EntryPoint = "XProtocolVersion", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XProtocolVersion([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(LibraryPath, EntryPoint = "XPutBackEvent", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XPutBackEvent([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("XEvent *")] XEvent* c_event);

        [DllImport(LibraryPath, EntryPoint = "XPutImage", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XPutImage([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("GC")] XGC* gc, [NativeTypeName("XImage *")] XImage* image, int src_x, int src_y, int dest_x, int dest_y, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height);

        [DllImport(LibraryPath, EntryPoint = "XQLength", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XQLength([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(LibraryPath, EntryPoint = "XQueryBestCursor", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XQueryBestCursor([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height, [NativeTypeName("unsigned int *")] uint* width_return, [NativeTypeName("unsigned int *")] uint* height_return);

        [DllImport(LibraryPath, EntryPoint = "XQueryBestSize", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XQueryBestSize([NativeTypeName("Display *")] UIntPtr display, int c_class, [NativeTypeName("Drawable")] UIntPtr which_screen, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height, [NativeTypeName("unsigned int *")] uint* width_return, [NativeTypeName("unsigned int *")] uint* height_return);

        [DllImport(LibraryPath, EntryPoint = "XQueryBestStipple", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XQueryBestStipple([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr which_screen, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height, [NativeTypeName("unsigned int *")] uint* width_return, [NativeTypeName("unsigned int *")] uint* height_return);

        [DllImport(LibraryPath, EntryPoint = "XQueryBestTile", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XQueryBestTile([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr which_screen, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height, [NativeTypeName("unsigned int *")] uint* width_return, [NativeTypeName("unsigned int *")] uint* height_return);

        [DllImport(LibraryPath, EntryPoint = "XQueryColor", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XQueryColor([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Colormap")] UIntPtr colormap, [NativeTypeName("XColor *")] XColor* def_in_out);

        [DllImport(LibraryPath, EntryPoint = "XQueryColors", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XQueryColors([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Colormap")] UIntPtr colormap, [NativeTypeName("XColor *")] XColor* defs_in_out, int ncolors);

        [DllImport(LibraryPath, EntryPoint = "XQueryExtension", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XQueryExtension([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("int *")] int* major_opcode_return, [NativeTypeName("int *")] int* first_event_return, [NativeTypeName("int *")] int* first_error_return);

        [DllImport(LibraryPath, EntryPoint = "XQueryKeymap", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XQueryKeymap([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("char [32]")] sbyte keys_return);

        [DllImport(LibraryPath, EntryPoint = "XQueryPointer", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XQueryPointer([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("Window *")] UIntPtr* root_return, [NativeTypeName("Window *")] UIntPtr* child_return, [NativeTypeName("int *")] int* root_x_return, [NativeTypeName("int *")] int* root_y_return, [NativeTypeName("int *")] int* win_x_return, [NativeTypeName("int *")] int* win_y_return, [NativeTypeName("unsigned int *")] uint* mask_return);

        [DllImport(LibraryPath, EntryPoint = "XQueryTextExtents", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XQueryTextExtents([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("XID")] UIntPtr font_ID, [NativeTypeName("const char *")] sbyte* c_string, int nchars, [NativeTypeName("int *")] int* direction_return, [NativeTypeName("int *")] int* font_ascent_return, [NativeTypeName("int *")] int* font_descent_return, [NativeTypeName("XCharStruct *")] XCharStruct* overall_return);

        [DllImport(LibraryPath, EntryPoint = "XQueryTextExtents16", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XQueryTextExtents16([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("XID")] UIntPtr font_ID, [NativeTypeName("const XChar2b *")] XChar2b* c_string, int nchars, [NativeTypeName("int *")] int* direction_return, [NativeTypeName("int *")] int* font_ascent_return, [NativeTypeName("int *")] int* font_descent_return, [NativeTypeName("XCharStruct *")] XCharStruct* overall_return);

        [DllImport(LibraryPath, EntryPoint = "XQueryTree", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XQueryTree([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("Window *")] UIntPtr* root_return, [NativeTypeName("Window *")] UIntPtr* parent_return, [NativeTypeName("Window **")] UIntPtr** children_return, [NativeTypeName("unsigned int *")] uint* nchildren_return);

        [DllImport(LibraryPath, EntryPoint = "XRaiseWindow", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XRaiseWindow([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w);

        [DllImport(LibraryPath, EntryPoint = "XReadBitmapFile", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XReadBitmapFile([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("const char *")] sbyte* filename, [NativeTypeName("unsigned int *")] uint* width_return, [NativeTypeName("unsigned int *")] uint* height_return, [NativeTypeName("Pixmap *")] UIntPtr* bitmap_return, [NativeTypeName("int *")] int* x_hot_return, [NativeTypeName("int *")] int* y_hot_return);

        [DllImport(LibraryPath, EntryPoint = "XReadBitmapFileData", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XReadBitmapFileData([NativeTypeName("const char *")] sbyte* filename, [NativeTypeName("unsigned int *")] uint* width_return, [NativeTypeName("unsigned int *")] uint* height_return, [NativeTypeName("unsigned char **")] byte** data_return, [NativeTypeName("int *")] int* x_hot_return, [NativeTypeName("int *")] int* y_hot_return);

        [DllImport(LibraryPath, EntryPoint = "XRebindKeysym", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XRebindKeysym([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("KeySym")] UIntPtr keysym, [NativeTypeName("KeySym *")] UIntPtr* list, int mod_count, [NativeTypeName("const unsigned char *")] byte* c_string, int bytes_string);

        [DllImport(LibraryPath, EntryPoint = "XRecolorCursor", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XRecolorCursor([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Cursor")] UIntPtr cursor, [NativeTypeName("XColor *")] XColor* foreground_color, [NativeTypeName("XColor *")] XColor* background_color);

        [DllImport(LibraryPath, EntryPoint = "XRefreshKeyboardMapping", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XRefreshKeyboardMapping([NativeTypeName("XMappingEvent *")] XMappingEvent* event_map);

        [DllImport(LibraryPath, EntryPoint = "XRemoveFromSaveSet", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XRemoveFromSaveSet([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w);

        [DllImport(LibraryPath, EntryPoint = "XRemoveHost", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XRemoveHost([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("XHostAddress *")] XHostAddress* host);

        [DllImport(LibraryPath, EntryPoint = "XRemoveHosts", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XRemoveHosts([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("XHostAddress *")] XHostAddress* hosts, int num_hosts);

        [DllImport(LibraryPath, EntryPoint = "XReparentWindow", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XReparentWindow([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("Window")] UIntPtr parent, int x, int y);

        [DllImport(LibraryPath, EntryPoint = "XResetScreenSaver", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XResetScreenSaver([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(LibraryPath, EntryPoint = "XResizeWindow", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XResizeWindow([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height);

        [DllImport(LibraryPath, EntryPoint = "XRestackWindows", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XRestackWindows([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window *")] UIntPtr* windows, int nwindows);

        [DllImport(LibraryPath, EntryPoint = "XRotateBuffers", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XRotateBuffers([NativeTypeName("Display *")] UIntPtr display, int rotate);

        [DllImport(LibraryPath, EntryPoint = "XRotateWindowProperties", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XRotateWindowProperties([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("Atom *")] UIntPtr* properties, int num_prop, int npositions);

        [DllImport(LibraryPath, EntryPoint = "XScreenCount", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XScreenCount([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(LibraryPath, EntryPoint = "XSelectInput", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSelectInput([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("long")] IntPtr event_mask);

        [DllImport(LibraryPath, EntryPoint = "XSendEvent", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSendEvent([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, int propagate, [NativeTypeName("long")] IntPtr event_mask, [NativeTypeName("XEvent *")] XEvent* event_send);

        [DllImport(LibraryPath, EntryPoint = "XSetAccessControl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetAccessControl([NativeTypeName("Display *")] UIntPtr display, int mode);

        [DllImport(LibraryPath, EntryPoint = "XSetArcMode", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetArcMode([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("GC")] XGC* gc, int arc_mode);

        [DllImport(LibraryPath, EntryPoint = "XSetBackground", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetBackground([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("GC")] XGC* gc, [NativeTypeName("unsigned long")] UIntPtr background);

        [DllImport(LibraryPath, EntryPoint = "XSetClipMask", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetClipMask([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("GC")] XGC* gc, [NativeTypeName("Pixmap")] UIntPtr pixmap);

        [DllImport(LibraryPath, EntryPoint = "XSetClipOrigin", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetClipOrigin([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("GC")] XGC* gc, int clip_x_origin, int clip_y_origin);

        [DllImport(LibraryPath, EntryPoint = "XSetClipRectangles", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetClipRectangles([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("GC")] XGC* gc, int clip_x_origin, int clip_y_origin, [NativeTypeName("XRectangle *")] XRectangle* rectangles, int n, int ordering);

        [DllImport(LibraryPath, EntryPoint = "XSetCloseDownMode", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetCloseDownMode([NativeTypeName("Display *")] UIntPtr display, int close_mode);

        [DllImport(LibraryPath, EntryPoint = "XSetCommand", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetCommand([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("char **")] sbyte** argv, int argc);

        [DllImport(LibraryPath, EntryPoint = "XSetDashes", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetDashes([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("GC")] XGC* gc, int dash_offset, [NativeTypeName("const char *")] sbyte* dash_list, int n);

        [DllImport(LibraryPath, EntryPoint = "XSetFillRule", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetFillRule([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("GC")] XGC* gc, int fill_rule);

        [DllImport(LibraryPath, EntryPoint = "XSetFillStyle", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetFillStyle([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("GC")] XGC* gc, int fill_style);

        [DllImport(LibraryPath, EntryPoint = "XSetFont", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetFont([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("GC")] XGC* gc, [NativeTypeName("Font")] UIntPtr font);

        [DllImport(LibraryPath, EntryPoint = "XSetFontPath", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetFontPath([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("char **")] sbyte** directories, int ndirs);

        [DllImport(LibraryPath, EntryPoint = "XSetForeground", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetForeground([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("GC")] XGC* gc, [NativeTypeName("unsigned long")] UIntPtr foreground);

        [DllImport(LibraryPath, EntryPoint = "XSetFunction", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetFunction([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("GC")] XGC* gc, int function);

        [DllImport(LibraryPath, EntryPoint = "XSetGraphicsExposures", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetGraphicsExposures([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("GC")] XGC* gc, int graphics_exposures);

        [DllImport(LibraryPath, EntryPoint = "XSetIconName", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetIconName([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("const char *")] sbyte* icon_name);

        [DllImport(LibraryPath, EntryPoint = "XSetInputFocus", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetInputFocus([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr focus, int revert_to, [NativeTypeName("Time")] UIntPtr time);

        [DllImport(LibraryPath, EntryPoint = "XSetLineAttributes", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetLineAttributes([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("GC")] XGC* gc, [NativeTypeName("unsigned int")] uint line_width, int line_style, int cap_style, int join_style);

        [DllImport(LibraryPath, EntryPoint = "XSetModifierMapping", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetModifierMapping([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("XModifierKeymap *")] XModifierKeymap* modmap);

        [DllImport(LibraryPath, EntryPoint = "XSetPlaneMask", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetPlaneMask([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("GC")] XGC* gc, [NativeTypeName("unsigned long")] UIntPtr plane_mask);

        [DllImport(LibraryPath, EntryPoint = "XSetPointerMapping", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetPointerMapping([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("const unsigned char *")] byte* map, int nmap);

        [DllImport(LibraryPath, EntryPoint = "XSetScreenSaver", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetScreenSaver([NativeTypeName("Display *")] UIntPtr display, int timeout, int interval, int prefer_blanking, int allow_exposures);

        [DllImport(LibraryPath, EntryPoint = "XSetSelectionOwner", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetSelectionOwner([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Atom")] UIntPtr selection, [NativeTypeName("Window")] UIntPtr owner, [NativeTypeName("Time")] UIntPtr time);

        [DllImport(LibraryPath, EntryPoint = "XSetState", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetState([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("GC")] XGC* gc, [NativeTypeName("unsigned long")] UIntPtr foreground, [NativeTypeName("unsigned long")] UIntPtr background, int function, [NativeTypeName("unsigned long")] UIntPtr plane_mask);

        [DllImport(LibraryPath, EntryPoint = "XSetStipple", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetStipple([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("GC")] XGC* gc, [NativeTypeName("Pixmap")] UIntPtr stipple);

        [DllImport(LibraryPath, EntryPoint = "XSetSubwindowMode", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetSubwindowMode([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("GC")] XGC* gc, int subwindow_mode);

        [DllImport(LibraryPath, EntryPoint = "XSetTSOrigin", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetTSOrigin([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("GC")] XGC* gc, int ts_x_origin, int ts_y_origin);

        [DllImport(LibraryPath, EntryPoint = "XSetTile", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetTile([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("GC")] XGC* gc, [NativeTypeName("Pixmap")] UIntPtr tile);

        [DllImport(LibraryPath, EntryPoint = "XSetWindowBackground", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetWindowBackground([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("unsigned long")] UIntPtr background_pixel);

        [DllImport(LibraryPath, EntryPoint = "XSetWindowBackgroundPixmap", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetWindowBackgroundPixmap([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("Pixmap")] UIntPtr background_pixmap);

        [DllImport(LibraryPath, EntryPoint = "XSetWindowBorder", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetWindowBorder([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("unsigned long")] UIntPtr border_pixel);

        [DllImport(LibraryPath, EntryPoint = "XSetWindowBorderPixmap", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetWindowBorderPixmap([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("Pixmap")] UIntPtr border_pixmap);

        [DllImport(LibraryPath, EntryPoint = "XSetWindowBorderWidth", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetWindowBorderWidth([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("unsigned int")] uint width);

        [DllImport(LibraryPath, EntryPoint = "XSetWindowColormap", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetWindowColormap([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("Colormap")] UIntPtr colormap);

        [DllImport(LibraryPath, EntryPoint = "XStoreBuffer", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XStoreBuffer([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("const char *")] sbyte* bytes, int nbytes, int buffer);

        [DllImport(LibraryPath, EntryPoint = "XStoreBytes", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XStoreBytes([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("const char *")] sbyte* bytes, int nbytes);

        [DllImport(LibraryPath, EntryPoint = "XStoreColor", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XStoreColor([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Colormap")] UIntPtr colormap, [NativeTypeName("XColor *")] XColor* color);

        [DllImport(LibraryPath, EntryPoint = "XStoreColors", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XStoreColors([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Colormap")] UIntPtr colormap, [NativeTypeName("XColor *")] XColor* color, int ncolors);

        [DllImport(LibraryPath, EntryPoint = "XStoreName", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XStoreName([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("const char *")] sbyte* window_name);

        [DllImport(LibraryPath, EntryPoint = "XStoreNamedColor", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XStoreNamedColor([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Colormap")] UIntPtr colormap, [NativeTypeName("const char *")] sbyte* color, [NativeTypeName("unsigned long")] UIntPtr pixel, int flags);

        [DllImport(LibraryPath, EntryPoint = "XSync", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSync([NativeTypeName("Display *")] UIntPtr display, int discard);

        [DllImport(LibraryPath, EntryPoint = "XTextExtents", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XTextExtents([NativeTypeName("XFontStruct *")] XFontStruct* font_struct, [NativeTypeName("const char *")] sbyte* c_string, int nchars, [NativeTypeName("int *")] int* direction_return, [NativeTypeName("int *")] int* font_ascent_return, [NativeTypeName("int *")] int* font_descent_return, [NativeTypeName("XCharStruct *")] XCharStruct* overall_return);

        [DllImport(LibraryPath, EntryPoint = "XTextExtents16", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XTextExtents16([NativeTypeName("XFontStruct *")] XFontStruct* font_struct, [NativeTypeName("const XChar2b *")] XChar2b* c_string, int nchars, [NativeTypeName("int *")] int* direction_return, [NativeTypeName("int *")] int* font_ascent_return, [NativeTypeName("int *")] int* font_descent_return, [NativeTypeName("XCharStruct *")] XCharStruct* overall_return);

        [DllImport(LibraryPath, EntryPoint = "XTextWidth", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XTextWidth([NativeTypeName("XFontStruct *")] XFontStruct* font_struct, [NativeTypeName("const char *")] sbyte* c_string, int count);

        [DllImport(LibraryPath, EntryPoint = "XTextWidth16", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XTextWidth16([NativeTypeName("XFontStruct *")] XFontStruct* font_struct, [NativeTypeName("const XChar2b *")] XChar2b* c_string, int count);

        [DllImport(LibraryPath, EntryPoint = "XTranslateCoordinates", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XTranslateCoordinates([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr src_w, [NativeTypeName("Window")] UIntPtr dest_w, int src_x, int src_y, [NativeTypeName("int *")] int* dest_x_return, [NativeTypeName("int *")] int* dest_y_return, [NativeTypeName("Window *")] UIntPtr* child_return);

        [DllImport(LibraryPath, EntryPoint = "XUndefineCursor", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XUndefineCursor([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w);

        [DllImport(LibraryPath, EntryPoint = "XUngrabButton", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XUngrabButton([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("unsigned int")] uint button, [NativeTypeName("unsigned int")] uint modifiers, [NativeTypeName("Window")] UIntPtr grab_window);

        [DllImport(LibraryPath, EntryPoint = "XUngrabKey", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XUngrabKey([NativeTypeName("Display *")] UIntPtr display, int keycode, [NativeTypeName("unsigned int")] uint modifiers, [NativeTypeName("Window")] UIntPtr grab_window);

        [DllImport(LibraryPath, EntryPoint = "XUngrabKeyboard", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XUngrabKeyboard([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Time")] UIntPtr time);

        [DllImport(LibraryPath, EntryPoint = "XUngrabPointer", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XUngrabPointer([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Time")] UIntPtr time);

        [DllImport(LibraryPath, EntryPoint = "XUngrabServer", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XUngrabServer([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(LibraryPath, EntryPoint = "XUninstallColormap", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XUninstallColormap([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Colormap")] UIntPtr colormap);

        [DllImport(LibraryPath, EntryPoint = "XUnloadFont", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XUnloadFont([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Font")] UIntPtr font);

        [DllImport(LibraryPath, EntryPoint = "XUnmapSubwindows", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XUnmapSubwindows([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w);

        [DllImport(LibraryPath, EntryPoint = "XUnmapWindow", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XUnmapWindow([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w);

        [DllImport(LibraryPath, EntryPoint = "XVendorRelease", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XVendorRelease([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(LibraryPath, EntryPoint = "XWarpPointer", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XWarpPointer([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr src_w, [NativeTypeName("Window")] UIntPtr dest_w, int src_x, int src_y, [NativeTypeName("unsigned int")] uint src_width, [NativeTypeName("unsigned int")] uint src_height, int dest_x, int dest_y);

        [DllImport(LibraryPath, EntryPoint = "XWidthMMOfScreen", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XWidthMMOfScreen([NativeTypeName("Screen *")] Screen* screen);

        [DllImport(LibraryPath, EntryPoint = "XWidthOfScreen", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XWidthOfScreen([NativeTypeName("Screen *")] Screen* screen);

        [DllImport(LibraryPath, EntryPoint = "XWindowEvent", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XWindowEvent([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Window")] UIntPtr w, [NativeTypeName("long")] IntPtr event_mask, [NativeTypeName("XEvent *")] XEvent* event_return);

        [DllImport(LibraryPath, EntryPoint = "XWriteBitmapFile", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XWriteBitmapFile([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("const char *")] sbyte* filename, [NativeTypeName("Pixmap")] UIntPtr bitmap, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height, int x_hot, int y_hot);

        [DllImport(LibraryPath, EntryPoint = "XSupportsLocale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSupportsLocale();

        [DllImport(LibraryPath, EntryPoint = "XSetLocaleModifiers", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XSetLocaleModifiers([NativeTypeName("const char *")] sbyte* modifier_list);

        [DllImport(LibraryPath, EntryPoint = "XOpenOM", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XOM")]
        public static extern XOM* XOpenOM([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("struct XrmHashBucketRec *")] XrmHashBucketRec* rdb, [NativeTypeName("const char *")] sbyte* res_name, [NativeTypeName("const char *")] sbyte* res_class);

        [DllImport(LibraryPath, EntryPoint = "XCloseOM", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XCloseOM([NativeTypeName("XOM")] XOM* om);

        [DllImport(LibraryPath, EntryPoint = "XSetOMValues", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XSetOMValues([NativeTypeName("XOM")] XOM* om);

        [DllImport(LibraryPath, EntryPoint = "XGetOMValues", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XGetOMValues([NativeTypeName("XOM")] XOM* om);

        [DllImport(LibraryPath, EntryPoint = "XDisplayOfOM", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Display *")]
        public static extern UIntPtr XDisplayOfOM([NativeTypeName("XOM")] XOM* om);

        [DllImport(LibraryPath, EntryPoint = "XLocaleOfOM", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XLocaleOfOM([NativeTypeName("XOM")] XOM* om);

        [DllImport(LibraryPath, EntryPoint = "XCreateOC", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XOC")]
        public static extern XOC* XCreateOC([NativeTypeName("XOM")] XOM* om);

        [DllImport(LibraryPath, EntryPoint = "XDestroyOC", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XDestroyOC([NativeTypeName("XOC")] XOC* oc);

        [DllImport(LibraryPath, EntryPoint = "XOMOfOC", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XOM")]
        public static extern XOM* XOMOfOC([NativeTypeName("XOC")] XOC* oc);

        [DllImport(LibraryPath, EntryPoint = "XSetOCValues", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XSetOCValues([NativeTypeName("XOC")] XOC* oc);

        [DllImport(LibraryPath, EntryPoint = "XGetOCValues", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XGetOCValues([NativeTypeName("XOC")] XOC* oc);

        [DllImport(LibraryPath, EntryPoint = "XCreateFontSet", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XFontSet")]
        public static extern XOC* XCreateFontSet([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("const char *")] sbyte* base_font_name_list, [NativeTypeName("char ***")] sbyte*** missing_charset_list, [NativeTypeName("int *")] int* missing_charset_count, [NativeTypeName("char **")] sbyte** def_string);

        [DllImport(LibraryPath, EntryPoint = "XFreeFontSet", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XFreeFontSet([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("XFontSet")] XOC* font_set);

        [DllImport(LibraryPath, EntryPoint = "XFontsOfFontSet", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XFontsOfFontSet([NativeTypeName("XFontSet")] XOC* font_set, [NativeTypeName("XFontStruct ***")] XFontStruct*** font_struct_list, [NativeTypeName("char ***")] sbyte*** font_name_list);

        [DllImport(LibraryPath, EntryPoint = "XBaseFontNameListOfFontSet", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XBaseFontNameListOfFontSet([NativeTypeName("XFontSet")] XOC* font_set);

        [DllImport(LibraryPath, EntryPoint = "XLocaleOfFontSet", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XLocaleOfFontSet([NativeTypeName("XFontSet")] XOC* font_set);

        [DllImport(LibraryPath, EntryPoint = "XContextDependentDrawing", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XContextDependentDrawing([NativeTypeName("XFontSet")] XOC* font_set);

        [DllImport(LibraryPath, EntryPoint = "XDirectionalDependentDrawing", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDirectionalDependentDrawing([NativeTypeName("XFontSet")] XOC* font_set);

        [DllImport(LibraryPath, EntryPoint = "XContextualDrawing", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XContextualDrawing([NativeTypeName("XFontSet")] XOC* font_set);

        [DllImport(LibraryPath, EntryPoint = "XExtentsOfFontSet", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XFontSetExtents *")]
        public static extern XFontSetExtents* XExtentsOfFontSet([NativeTypeName("XFontSet")] XOC* font_set);

        [DllImport(LibraryPath, EntryPoint = "XmbTextEscapement", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XmbTextEscapement([NativeTypeName("XFontSet")] XOC* font_set, [NativeTypeName("const char *")] sbyte* text, int bytes_text);

        [DllImport(LibraryPath, EntryPoint = "XwcTextEscapement", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XwcTextEscapement([NativeTypeName("XFontSet")] XOC* font_set, [NativeTypeName("const wchar_t *")] int* text, int num_wchars);

        [DllImport(LibraryPath, EntryPoint = "Xutf8TextEscapement", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int Xutf8TextEscapement([NativeTypeName("XFontSet")] XOC* font_set, [NativeTypeName("const char *")] sbyte* text, int bytes_text);

        [DllImport(LibraryPath, EntryPoint = "XmbTextExtents", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XmbTextExtents([NativeTypeName("XFontSet")] XOC* font_set, [NativeTypeName("const char *")] sbyte* text, int bytes_text, [NativeTypeName("XRectangle *")] XRectangle* overall_ink_return, [NativeTypeName("XRectangle *")] XRectangle* overall_logical_return);

        [DllImport(LibraryPath, EntryPoint = "XwcTextExtents", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XwcTextExtents([NativeTypeName("XFontSet")] XOC* font_set, [NativeTypeName("const wchar_t *")] int* text, int num_wchars, [NativeTypeName("XRectangle *")] XRectangle* overall_ink_return, [NativeTypeName("XRectangle *")] XRectangle* overall_logical_return);

        [DllImport(LibraryPath, EntryPoint = "Xutf8TextExtents", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int Xutf8TextExtents([NativeTypeName("XFontSet")] XOC* font_set, [NativeTypeName("const char *")] sbyte* text, int bytes_text, [NativeTypeName("XRectangle *")] XRectangle* overall_ink_return, [NativeTypeName("XRectangle *")] XRectangle* overall_logical_return);

        [DllImport(LibraryPath, EntryPoint = "XmbTextPerCharExtents", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XmbTextPerCharExtents([NativeTypeName("XFontSet")] XOC* font_set, [NativeTypeName("const char *")] sbyte* text, int bytes_text, [NativeTypeName("XRectangle *")] XRectangle* ink_extents_buffer, [NativeTypeName("XRectangle *")] XRectangle* logical_extents_buffer, int buffer_size, [NativeTypeName("int *")] int* num_chars, [NativeTypeName("XRectangle *")] XRectangle* overall_ink_return, [NativeTypeName("XRectangle *")] XRectangle* overall_logical_return);

        [DllImport(LibraryPath, EntryPoint = "XwcTextPerCharExtents", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XwcTextPerCharExtents([NativeTypeName("XFontSet")] XOC* font_set, [NativeTypeName("const wchar_t *")] int* text, int num_wchars, [NativeTypeName("XRectangle *")] XRectangle* ink_extents_buffer, [NativeTypeName("XRectangle *")] XRectangle* logical_extents_buffer, int buffer_size, [NativeTypeName("int *")] int* num_chars, [NativeTypeName("XRectangle *")] XRectangle* overall_ink_return, [NativeTypeName("XRectangle *")] XRectangle* overall_logical_return);

        [DllImport(LibraryPath, EntryPoint = "Xutf8TextPerCharExtents", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int Xutf8TextPerCharExtents([NativeTypeName("XFontSet")] XOC* font_set, [NativeTypeName("const char *")] sbyte* text, int bytes_text, [NativeTypeName("XRectangle *")] XRectangle* ink_extents_buffer, [NativeTypeName("XRectangle *")] XRectangle* logical_extents_buffer, int buffer_size, [NativeTypeName("int *")] int* num_chars, [NativeTypeName("XRectangle *")] XRectangle* overall_ink_return, [NativeTypeName("XRectangle *")] XRectangle* overall_logical_return);

        [DllImport(LibraryPath, EntryPoint = "XmbDrawText", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XmbDrawText([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("GC")] XGC* gc, int x, int y, [NativeTypeName("XmbTextItem *")] XmbTextItem* text_items, int nitems);

        [DllImport(LibraryPath, EntryPoint = "XwcDrawText", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XwcDrawText([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("GC")] XGC* gc, int x, int y, [NativeTypeName("XwcTextItem *")] XwcTextItem* text_items, int nitems);

        [DllImport(LibraryPath, EntryPoint = "Xutf8DrawText", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void Xutf8DrawText([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("GC")] XGC* gc, int x, int y, [NativeTypeName("XmbTextItem *")] XmbTextItem* text_items, int nitems);

        [DllImport(LibraryPath, EntryPoint = "XmbDrawString", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XmbDrawString([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("XFontSet")] XOC* font_set, [NativeTypeName("GC")] XGC* gc, int x, int y, [NativeTypeName("const char *")] sbyte* text, int bytes_text);

        [DllImport(LibraryPath, EntryPoint = "XwcDrawString", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XwcDrawString([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("XFontSet")] XOC* font_set, [NativeTypeName("GC")] XGC* gc, int x, int y, [NativeTypeName("const wchar_t *")] int* text, int num_wchars);

        [DllImport(LibraryPath, EntryPoint = "Xutf8DrawString", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void Xutf8DrawString([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("XFontSet")] XOC* font_set, [NativeTypeName("GC")] XGC* gc, int x, int y, [NativeTypeName("const char *")] sbyte* text, int bytes_text);

        [DllImport(LibraryPath, EntryPoint = "XmbDrawImageString", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XmbDrawImageString([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("XFontSet")] XOC* font_set, [NativeTypeName("GC")] XGC* gc, int x, int y, [NativeTypeName("const char *")] sbyte* text, int bytes_text);

        [DllImport(LibraryPath, EntryPoint = "XwcDrawImageString", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XwcDrawImageString([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("XFontSet")] XOC* font_set, [NativeTypeName("GC")] XGC* gc, int x, int y, [NativeTypeName("const wchar_t *")] int* text, int num_wchars);

        [DllImport(LibraryPath, EntryPoint = "Xutf8DrawImageString", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void Xutf8DrawImageString([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("Drawable")] UIntPtr d, [NativeTypeName("XFontSet")] XOC* font_set, [NativeTypeName("GC")] XGC* gc, int x, int y, [NativeTypeName("const char *")] sbyte* text, int bytes_text);

        [DllImport(LibraryPath, EntryPoint = "XOpenIM", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XIM")]
        public static extern XIM* XOpenIM([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("struct XrmHashBucketRec *")] XrmHashBucketRec* rdb, [NativeTypeName("char *")] sbyte* res_name, [NativeTypeName("char *")] sbyte* res_class);

        [DllImport(LibraryPath, EntryPoint = "XCloseIM", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XCloseIM([NativeTypeName("XIM")] XIM* im);

        [DllImport(LibraryPath, EntryPoint = "XGetIMValues", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XGetIMValues([NativeTypeName("XIM")] XIM* im);

        [DllImport(LibraryPath, EntryPoint = "XSetIMValues", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XSetIMValues([NativeTypeName("XIM")] XIM* im);

        [DllImport(LibraryPath, EntryPoint = "XDisplayOfIM", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Display *")]
        public static extern UIntPtr XDisplayOfIM([NativeTypeName("XIM")] XIM* im);

        [DllImport(LibraryPath, EntryPoint = "XLocaleOfIM", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XLocaleOfIM([NativeTypeName("XIM")] XIM* im);

        [DllImport(LibraryPath, EntryPoint = "XCreateIC", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XIC")]
        public static extern XIC* XCreateIC([NativeTypeName("XIM")] XIM* im);

        [DllImport(LibraryPath, EntryPoint = "XDestroyIC", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XDestroyIC([NativeTypeName("XIC")] XIC* ic);

        [DllImport(LibraryPath, EntryPoint = "XSetICFocus", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XSetICFocus([NativeTypeName("XIC")] XIC* ic);

        [DllImport(LibraryPath, EntryPoint = "XUnsetICFocus", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XUnsetICFocus([NativeTypeName("XIC")] XIC* ic);

        [DllImport(LibraryPath, EntryPoint = "XwcResetIC", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("wchar_t *")]
        public static extern int* XwcResetIC([NativeTypeName("XIC")] XIC* ic);

        [DllImport(LibraryPath, EntryPoint = "XmbResetIC", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XmbResetIC([NativeTypeName("XIC")] XIC* ic);

        [DllImport(LibraryPath, EntryPoint = "Xutf8ResetIC", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* Xutf8ResetIC([NativeTypeName("XIC")] XIC* ic);

        [DllImport(LibraryPath, EntryPoint = "XSetICValues", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XSetICValues([NativeTypeName("XIC")] XIC* ic);

        [DllImport(LibraryPath, EntryPoint = "XGetICValues", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XGetICValues([NativeTypeName("XIC")] XIC* ic);

        [DllImport(LibraryPath, EntryPoint = "XIMOfIC", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XIM")]
        public static extern XIM* XIMOfIC([NativeTypeName("XIC")] XIC* ic);

        [DllImport(LibraryPath, EntryPoint = "XFilterEvent", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XFilterEvent([NativeTypeName("XEvent *")] XEvent* c_event, [NativeTypeName("Window")] UIntPtr window);

        [DllImport(LibraryPath, EntryPoint = "XmbLookupString", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XmbLookupString([NativeTypeName("XIC")] XIC* ic, [NativeTypeName("XKeyPressedEvent *")] XKeyEvent* c_event, [NativeTypeName("char *")] sbyte* buffer_return, int bytes_buffer, [NativeTypeName("KeySym *")] UIntPtr* keysym_return, [NativeTypeName("int *")] int* status_return);

        [DllImport(LibraryPath, EntryPoint = "XwcLookupString", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XwcLookupString([NativeTypeName("XIC")] XIC* ic, [NativeTypeName("XKeyPressedEvent *")] XKeyEvent* c_event, [NativeTypeName("wchar_t *")] int* buffer_return, int wchars_buffer, [NativeTypeName("KeySym *")] UIntPtr* keysym_return, [NativeTypeName("int *")] int* status_return);

        [DllImport(LibraryPath, EntryPoint = "Xutf8LookupString", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int Xutf8LookupString([NativeTypeName("XIC")] XIC* ic, [NativeTypeName("XKeyPressedEvent *")] XKeyEvent* c_event, [NativeTypeName("char *")] sbyte* buffer_return, int bytes_return, [NativeTypeName("KeySym *")] UIntPtr* keysym_return, [NativeTypeName("int *")] int* status_return);

        [DllImport(LibraryPath, EntryPoint = "XVaCreateNestedList", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XVaNestedList")]
        public static extern void* XVaCreateNestedList(int unused);

        [DllImport(LibraryPath, EntryPoint = "XRegisterIMInstantiateCallback", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XRegisterIMInstantiateCallback([NativeTypeName("Display *")] UIntPtr dpy, [NativeTypeName("struct XrmHashBucketRec *")] XrmHashBucketRec* rdb, [NativeTypeName("char *")] sbyte* res_name, [NativeTypeName("char *")] sbyte* res_class, [NativeTypeName("XIDProc")] IntPtr callback, [NativeTypeName("XPointer")] sbyte* client_data);

        [DllImport(LibraryPath, EntryPoint = "XUnregisterIMInstantiateCallback", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XUnregisterIMInstantiateCallback([NativeTypeName("Display *")] UIntPtr dpy, [NativeTypeName("struct XrmHashBucketRec *")] XrmHashBucketRec* rdb, [NativeTypeName("char *")] sbyte* res_name, [NativeTypeName("char *")] sbyte* res_class, [NativeTypeName("XIDProc")] IntPtr callback, [NativeTypeName("XPointer")] sbyte* client_data);

        [DllImport(LibraryPath, EntryPoint = "XInternalConnectionNumbers", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XInternalConnectionNumbers([NativeTypeName("Display *")] UIntPtr dpy, [NativeTypeName("int **")] int** fd_return, [NativeTypeName("int *")] int* count_return);

        [DllImport(LibraryPath, EntryPoint = "XProcessInternalConnection", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XProcessInternalConnection([NativeTypeName("Display *")] UIntPtr dpy, int fd);

        [DllImport(LibraryPath, EntryPoint = "XAddConnectionWatch", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XAddConnectionWatch([NativeTypeName("Display *")] UIntPtr dpy, [NativeTypeName("XConnectionWatchProc")] IntPtr callback, [NativeTypeName("XPointer")] sbyte* client_data);

        [DllImport(LibraryPath, EntryPoint = "XRemoveConnectionWatch", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XRemoveConnectionWatch([NativeTypeName("Display *")] UIntPtr dpy, [NativeTypeName("XConnectionWatchProc")] IntPtr callback, [NativeTypeName("XPointer")] sbyte* client_data);

        [DllImport(LibraryPath, EntryPoint = "XSetAuthorization", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XSetAuthorization([NativeTypeName("char *")] sbyte* name, int namelen, [NativeTypeName("char *")] sbyte* data, int datalen);

        [DllImport(LibraryPath, EntryPoint = "_Xmbtowc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int _Xmbtowc([NativeTypeName("wchar_t *")] int* wstr, [NativeTypeName("char *")] sbyte* str, int len);

        [DllImport(LibraryPath, EntryPoint = "_Xwctomb", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int _Xwctomb([NativeTypeName("char *")] sbyte* str, [NativeTypeName("wchar_t")] int wc);

        [DllImport(LibraryPath, EntryPoint = "XGetEventData", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetEventData([NativeTypeName("Display *")] UIntPtr dpy, [NativeTypeName("XGenericEventCookie *")] XGenericEventCookie* cookie);

        [DllImport(LibraryPath, EntryPoint = "XFreeEventData", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XFreeEventData([NativeTypeName("Display *")] UIntPtr dpy, [NativeTypeName("XGenericEventCookie *")] XGenericEventCookie* cookie);
    }
}
