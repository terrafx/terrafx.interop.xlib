// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop.Xlib;

public unsafe partial struct XKeyboardState
{
    public int key_click_percent;

    public int bell_percent;

    [NativeTypeName("unsigned int")]
    public uint bell_pitch;

    [NativeTypeName("unsigned int")]
    public uint bell_duration;

    [NativeTypeName("unsigned long")]
    public nuint led_mask;

    public int global_auto_repeat;

    [NativeTypeName("char[32]")]
    public fixed sbyte auto_repeats[32];
}
