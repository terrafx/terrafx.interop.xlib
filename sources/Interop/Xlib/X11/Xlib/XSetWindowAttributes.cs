// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop.Xlib;

public partial struct XSetWindowAttributes
{
    public Pixmap background_pixmap;

    [NativeTypeName("unsigned long")]
    public nuint background_pixel;

    public Pixmap border_pixmap;

    [NativeTypeName("unsigned long")]
    public nuint border_pixel;

    public int bit_gravity;

    public int win_gravity;

    public int backing_store;

    [NativeTypeName("unsigned long")]
    public nuint backing_planes;

    [NativeTypeName("unsigned long")]
    public nuint backing_pixel;

    public int save_under;

    [NativeTypeName("long")]
    public nint event_mask;

    [NativeTypeName("long")]
    public nint do_not_propagate_mask;

    public int override_redirect;

    public Colormap colormap;

    public Cursor cursor;
}
