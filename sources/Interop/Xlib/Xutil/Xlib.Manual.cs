// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xutil.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group and Digital Equipment Corporation, Maynard, Massachusetts.

namespace TerraFX.Interop
{
    public static unsafe partial class Xlib
    {
        public static bool IsKeypadKey([NativeTypeName("KeySym")] nuint keysym) => (keysym >= XK_KP_Space) && (keysym <= XK_KP_Equal);

        public static bool IsPrivateKeypadKey([NativeTypeName("KeySym")] nuint keysym) => (keysym >= 0x11000000) && (keysym <= 0x1100FFFF);

        public static bool IsCursorKey([NativeTypeName("KeySym")] nuint keysym) => (keysym >= XK_Home) && (keysym < XK_Select);

        public static bool IsPFKey([NativeTypeName("KeySym")] nuint keysym) => (keysym >= XK_KP_F1) && (keysym <= XK_KP_F4);

        public static bool IsFunctionKey([NativeTypeName("KeySym")] nuint keysym) => (keysym >= XK_F1) && (keysym <= XK_F35);

        public static bool IsMiscFunctionKey([NativeTypeName("KeySym")] nuint keysym) => (keysym >= XK_Select) && (keysym <= XK_Break);

        public static bool IsModifierKey([NativeTypeName("KeySym")] nuint keysym) => ((keysym >= XK_Shift_L) && (keysym <= XK_Hyper_R)) || ((keysym >=  XK_ISO_Lock) && (keysym <= XK_ISO_Level5_Lock)) || (keysym == XK_Mode_switch) || (keysym == XK_Num_Lock);

        [return: NativeTypeName("XContext")]
        public static int XUniqueContext() => XrmUniqueQuark();

        [return: NativeTypeName("XContext")]
        public static int XStringToContext([NativeTypeName("const char *")] sbyte* c_string) => XrmStringToQuark(c_string);
    }
}
