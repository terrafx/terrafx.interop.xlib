// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xutil.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group and Digital Equipment Corporation, Maynard, Massachusetts.

namespace TerraFX.Interop.Xlib
{
    public static unsafe partial class Xlib
    {
        [NativeTypeName("#define ReleaseByFreeingColormap ((XID) 1L)")]
        public static XID ReleaseByFreeingColormap => ((XID)(1));

        public static bool IsKeypadKey(KeySym keysym) => (keysym >= (KeySym)(XK_KP_Space)) && (keysym <= (KeySym)(XK_KP_Equal));

        public static bool IsPrivateKeypadKey(KeySym keysym) => (keysym >= (KeySym)(0x11000000)) && (keysym <= (KeySym)(0x1100FFFF));

        public static bool IsCursorKey(KeySym keysym) => (keysym >= (KeySym)(XK_Home)) && (keysym < (KeySym)(XK_Select));

        public static bool IsPFKey(KeySym keysym) => (keysym >= (KeySym)(XK_KP_F1)) && (keysym <= (KeySym)(XK_KP_F4));

        public static bool IsFunctionKey(KeySym keysym) => (keysym >= (KeySym)(XK_F1)) && (keysym <= (KeySym)(XK_F35));

        public static bool IsMiscFunctionKey(KeySym keysym) => (keysym >= (KeySym)(XK_Select)) && (keysym <= (KeySym)(XK_Break));

        public static bool IsModifierKey(KeySym keysym) => ((keysym >= (KeySym)(XK_Shift_L)) && (keysym <= (KeySym)(XK_Hyper_R))) || ((keysym >= (KeySym)(XK_ISO_Lock)) && (keysym <= (KeySym)(XK_ISO_Level5_Lock))) || (keysym == (KeySym)(XK_Mode_switch)) || (keysym == (KeySym)(XK_Num_Lock));

        [return: NativeTypeName("XContext")]
        public static int XUniqueContext() => XrmUniqueQuark();

        [return: NativeTypeName("XContext")]
        public static int XStringToContext([NativeTypeName("const char *")] sbyte* c_string) => XrmStringToQuark(c_string);
    }
}
