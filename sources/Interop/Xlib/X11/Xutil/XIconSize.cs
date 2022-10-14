// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xutil.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop.Xlib;

public partial struct XIconSize
{
    public int min_width;

    public int min_height;

    public int max_width;

    public int max_height;

    public int width_inc;

    public int height_inc;
}
