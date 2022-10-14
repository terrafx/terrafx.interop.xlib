// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop.Xlib;

public partial struct XKeyboardControl
{
    public int key_click_percent;

    public int bell_percent;

    public int bell_pitch;

    public int bell_duration;

    public int led;

    public int led_mode;

    public int key;

    public int auto_repeat_mode;
}
