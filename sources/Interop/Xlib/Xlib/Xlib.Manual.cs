// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Xlib
    {
        public static int ConnectionNumber([NativeTypeName("Display *")] IntPtr dpy) => ((XPrivDisplay*)dpy)->fd;

        [return: NativeTypeName("Window")]
        public static nuint RootWindow([NativeTypeName("Display *")] IntPtr dpy, int scr) => ScreenOfDisplay(dpy, scr)->root;

        public static int DefaultScreen([NativeTypeName("Display *")] IntPtr dpy) => ((XPrivDisplay*)dpy)->default_screen;

        [return: NativeTypeName("Window")]
        public static nuint DefaultRootWindow([NativeTypeName("Display *")] IntPtr dpy) => ScreenOfDisplay(dpy, DefaultScreen(dpy))->root;

        [return: NativeTypeName("Visual *")]
        public static Visual* DefaultVisual([NativeTypeName("Display *")] IntPtr dpy, int scr) => ScreenOfDisplay(dpy, scr)->root_visual;

        [return: NativeTypeName("GC")]
        public static IntPtr DefaultGC([NativeTypeName("Display *")] IntPtr dpy, int scr) => ScreenOfDisplay(dpy, scr)->default_gc;

        [return: NativeTypeName("unsigned long")]
        public static nuint BlackPixel([NativeTypeName("Display *")] IntPtr dpy, int scr) => ScreenOfDisplay(dpy, scr)->black_pixel;

        [return: NativeTypeName("unsigned long")]
        public static nuint WhitePixel([NativeTypeName("Display *")] IntPtr dpy, int scr) => ScreenOfDisplay(dpy, scr)->white_pixel;

        public static int QLength([NativeTypeName("Display *")] IntPtr dpy) => ((XPrivDisplay*)dpy)->qlen;

        public static int DisplayWidth([NativeTypeName("Display *")] IntPtr dpy, int scr) => ScreenOfDisplay(dpy, scr)->width;

        public static int DisplayHeight([NativeTypeName("Display *")] IntPtr dpy, int scr) => ScreenOfDisplay(dpy, scr)->height;

        public static int DisplayWidthMM([NativeTypeName("Display *")] IntPtr dpy, int scr) => ScreenOfDisplay(dpy, scr)->mwidth;

        public static int DisplayHeightMM([NativeTypeName("Display *")] IntPtr dpy, int scr) => ScreenOfDisplay(dpy, scr)->mheight;

        public static int DisplayPlanes([NativeTypeName("Display *")] IntPtr dpy, int scr) => ScreenOfDisplay(dpy, scr)->root_depth;

        public static int DisplayCells([NativeTypeName("Display *")] IntPtr dpy, int scr) => DefaultVisual(dpy, scr)->map_entries;

        public static int ScreenCount([NativeTypeName("Display *")] IntPtr dpy) => ((XPrivDisplay*)dpy)->nscreens;

        [return: NativeTypeName("char *")]
        public static sbyte* ServerVendor([NativeTypeName("Display *")] IntPtr dpy) => ((XPrivDisplay*)dpy)->vendor;

        public static int ProtocolVersion([NativeTypeName("Display *")] IntPtr dpy) => ((XPrivDisplay*)dpy)->proto_major_version;

        public static int ProtocolRevision([NativeTypeName("Display *")] IntPtr dpy) => ((XPrivDisplay*)dpy)->proto_minor_version;

        public static int VendorRelease([NativeTypeName("Display *")] IntPtr dpy) => ((XPrivDisplay*)dpy)->release;

        [return: NativeTypeName("char *")]
        public static sbyte* DisplayString([NativeTypeName("Display *")] IntPtr dpy) => ((XPrivDisplay*)dpy)->display_name;

        public static int DefaultDepth([NativeTypeName("Display *")] IntPtr dpy, int scr) => ScreenOfDisplay(dpy, scr)->root_depth;

        [return: NativeTypeName("Colormap")]
        public static nuint DefaultColormap([NativeTypeName("Display *")] IntPtr dpy, int scr) => ScreenOfDisplay(dpy, scr)->cmap;

        public static int BitmapUnit([NativeTypeName("Display *")] IntPtr dpy) => ((XPrivDisplay*)dpy)->bitmap_unit;

        public static int BitmapBitOrder([NativeTypeName("Display *")] IntPtr dpy) => ((XPrivDisplay*)dpy)->bitmap_bit_order;

        public static int BitmapPad([NativeTypeName("Display *")] IntPtr dpy) => ((XPrivDisplay*)dpy)->bitmap_pad;

        public static int ImageByteOrder([NativeTypeName("Display *")] IntPtr dpy) => ((XPrivDisplay*)dpy)->byte_order;

        [return: NativeTypeName("unsigned long")]
        public static nuint NextRequest([NativeTypeName("Display *")] IntPtr dpy) => ((XPrivDisplay*)dpy)->request + 1;

        [return: NativeTypeName("unsigned long")]
        public static nuint LastKnownRequestProcessed([NativeTypeName("Display *")] IntPtr dpy) => ((XPrivDisplay*)dpy)->last_request_read;

        [return: NativeTypeName("Screen *")]
        public static Screen* ScreenOfDisplay([NativeTypeName("Display *")] IntPtr dpy, int scr) => &((XPrivDisplay*)dpy)->screens[scr];

        [return: NativeTypeName("Screen *")]
        public static Screen* DefaultScreenOfDisplay([NativeTypeName("Display *")] IntPtr dpy) => ScreenOfDisplay(dpy, DefaultScreen(dpy));

        [return: NativeTypeName("Display *")]
        public static IntPtr DisplayOfScreen([NativeTypeName("Screen *")] Screen* s) => s->display;

        [return: NativeTypeName("Window")]
        public static nuint RootWindowOfScreen([NativeTypeName("Screen *")] Screen* s) => s->root;

        public static nuint BlackPixelOfScreen([NativeTypeName("Screen *")] Screen* s) => s->black_pixel;

        public static nuint WhitePixelOfScreen([NativeTypeName("Screen *")] Screen* s) => s->white_pixel;

        [return: NativeTypeName("Colormap")]
        public static nuint DefaultColormapOfScreen([NativeTypeName("Screen *")] Screen* s) => s->cmap;

        public static int DefaultDepthOfScreen([NativeTypeName("Screen *")] Screen* s) => s->root_depth;

        [return: NativeTypeName("GC")]
        public static IntPtr DefaultGCOfScreen([NativeTypeName("Screen *")] Screen* s) => s->default_gc;

        [return: NativeTypeName("Visual *")]
        public static Visual* DefaultVisualOfScreen([NativeTypeName("Screen *")] Screen* s) => s->root_visual;

        public static int WidthOfScreen([NativeTypeName("Screen *")] Screen* s) => s->width;

        public static int HeightOfScreen([NativeTypeName("Screen *")] Screen* s) => s->height;

        public static int WidthMMOfScreen([NativeTypeName("Screen *")] Screen* s) => s->mwidth;

        public static int HeightMMOfScreen([NativeTypeName("Screen *")] Screen* s) => s->mheight;

        public static int PlanesOfScreen([NativeTypeName("Screen *")] Screen* s) => s->root_depth;

        public static int CellsOfScreen([NativeTypeName("Screen *")] Screen* s) => DefaultVisualOfScreen(s)->map_entries;

        public static int MinCmapsOfScreen([NativeTypeName("Screen *")] Screen* s) => s->min_maps;

        public static int MaxCmapsOfScreen([NativeTypeName("Screen *")] Screen* s) => s->max_maps;

        public static int DoesSaveUnders([NativeTypeName("Screen *")] Screen* s) => s->save_unders;

        public static int DoesBackingStore([NativeTypeName("Screen *")] Screen* s) => s->backing_store;

        [return: NativeTypeName("long")]
        public static IntPtr EventMaskOfScreen([NativeTypeName("Screen *")] Screen* s) => s->root_input_mask;

        [return: NativeTypeName("XID")]
        public static nuint XAllocID([NativeTypeName("Display *")] IntPtr dpy) => ((XPrivDisplay*)dpy)->resource_alloc(dpy);
    }
}
