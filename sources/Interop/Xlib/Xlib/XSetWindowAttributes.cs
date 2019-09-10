// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System;

namespace TerraFX.Interop
{
    public partial struct XSetWindowAttributes
    {
        [NativeTypeName("Pixmap")]
        public UIntPtr background_pixmap;

        [NativeTypeName("unsigned long")]
        public UIntPtr background_pixel;

        [NativeTypeName("Pixmap")]
        public UIntPtr border_pixmap;

        [NativeTypeName("unsigned long")]
        public UIntPtr border_pixel;

        public int bit_gravity;

        public int win_gravity;

        public int backing_store;

        [NativeTypeName("unsigned long")]
        public UIntPtr backing_planes;

        [NativeTypeName("unsigned long")]
        public UIntPtr backing_pixel;

        public int save_under;

        [NativeTypeName("long")]
        public IntPtr event_mask;

        [NativeTypeName("long")]
        public IntPtr do_not_propagate_mask;

        public int override_redirect;

        [NativeTypeName("Colormap")]
        public UIntPtr colormap;

        [NativeTypeName("Cursor")]
        public UIntPtr cursor;
    }
}
