// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System;

namespace TerraFX.Interop.Xlib;

public static unsafe partial class Xlib
{
    [NativeTypeName("#define AllPlanes ((unsigned long)~0L)")]
    public static readonly nuint AllPlanes = unchecked((nuint)(~0));

    public static int ConnectionNumber(Display* dpy) => dpy->fd;

    public static Window RootWindow(Display* dpy, int scr) => ScreenOfDisplay(dpy, scr)->root;

    public static int DefaultScreen(Display* dpy) => dpy->default_screen;

    public static Window DefaultRootWindow(Display* dpy) => ScreenOfDisplay(dpy, DefaultScreen(dpy))->root;

    public static Visual* DefaultVisual(Display* dpy, int scr) => ScreenOfDisplay(dpy, scr)->root_visual;

    public static GC DefaultGC(Display* dpy, int scr) => ScreenOfDisplay(dpy, scr)->default_gc;

    [return: NativeTypeName("unsigned long")]
    public static nuint BlackPixel(Display* dpy, int scr) => ScreenOfDisplay(dpy, scr)->black_pixel;

    [return: NativeTypeName("unsigned long")]
    public static nuint WhitePixel(Display* dpy, int scr) => ScreenOfDisplay(dpy, scr)->white_pixel;

    public static int QLength(Display* dpy) => dpy->qlen;

    public static int DisplayWidth(Display* dpy, int scr) => ScreenOfDisplay(dpy, scr)->width;

    public static int DisplayHeight(Display* dpy, int scr) => ScreenOfDisplay(dpy, scr)->height;

    public static int DisplayWidthMM(Display* dpy, int scr) => ScreenOfDisplay(dpy, scr)->mwidth;

    public static int DisplayHeightMM(Display* dpy, int scr) => ScreenOfDisplay(dpy, scr)->mheight;

    public static int DisplayPlanes(Display* dpy, int scr) => ScreenOfDisplay(dpy, scr)->root_depth;

    public static int DisplayCells(Display* dpy, int scr) => DefaultVisual(dpy, scr)->map_entries;

    public static int ScreenCount(Display* dpy) => dpy->nscreens;

    [return: NativeTypeName("char *")]
    public static sbyte* ServerVendor(Display* dpy) => dpy->vendor;

    public static int ProtocolVersion(Display* dpy) => dpy->proto_major_version;

    public static int ProtocolRevision(Display* dpy) => dpy->proto_minor_version;

    public static int VendorRelease(Display* dpy) => dpy->release;

    [return: NativeTypeName("char *")]
    public static sbyte* DisplayString(Display* dpy) => dpy->display_name;

    public static int DefaultDepth(Display* dpy, int scr) => ScreenOfDisplay(dpy, scr)->root_depth;

    public static Colormap DefaultColormap(Display* dpy, int scr) => ScreenOfDisplay(dpy, scr)->cmap;

    public static int BitmapUnit(Display* dpy) => dpy->bitmap_unit;

    public static int BitmapBitOrder(Display* dpy) => dpy->bitmap_bit_order;

    public static int BitmapPad(Display* dpy) => dpy->bitmap_pad;

    public static int ImageByteOrder(Display* dpy) => dpy->byte_order;

    [return: NativeTypeName("unsigned long")]
    public static nuint NextRequest(Display* dpy) => dpy->request + 1;

    [return: NativeTypeName("unsigned long")]
    public static nuint LastKnownRequestProcessed(Display* dpy) => dpy->last_request_read;

    public static Screen* ScreenOfDisplay(Display* dpy, int scr) => &dpy->screens[scr];

    public static Screen* DefaultScreenOfDisplay(Display* dpy) => ScreenOfDisplay(dpy, DefaultScreen(dpy));

    public static Display* DisplayOfScreen(Screen* s) => s->display;

    public static Window RootWindowOfScreen(Screen* s) => s->root;

    public static nuint BlackPixelOfScreen(Screen* s) => s->black_pixel;

    public static nuint WhitePixelOfScreen(Screen* s) => s->white_pixel;

    public static Colormap DefaultColormapOfScreen(Screen* s) => s->cmap;

    public static int DefaultDepthOfScreen(Screen* s) => s->root_depth;

    public static GC DefaultGCOfScreen(Screen* s) => s->default_gc;

    public static Visual* DefaultVisualOfScreen(Screen* s) => s->root_visual;

    public static int WidthOfScreen(Screen* s) => s->width;

    public static int HeightOfScreen(Screen* s) => s->height;

    public static int WidthMMOfScreen(Screen* s) => s->mwidth;

    public static int HeightMMOfScreen(Screen* s) => s->mheight;

    public static int PlanesOfScreen(Screen* s) => s->root_depth;

    public static int CellsOfScreen(Screen* s) => DefaultVisualOfScreen(s)->map_entries;

    public static int MinCmapsOfScreen(Screen* s) => s->min_maps;

    public static int MaxCmapsOfScreen(Screen* s) => s->max_maps;

    public static int DoesSaveUnders(Screen* s) => s->save_unders;

    public static int DoesBackingStore(Screen* s) => s->backing_store;

    [return: NativeTypeName("long")]
    public static IntPtr EventMaskOfScreen(Screen* s) => s->root_input_mask;

    public static XID XAllocID(Display* dpy) => dpy->resource_alloc(dpy);
}
