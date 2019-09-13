// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\Xutil.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group and Digital Equipment Corporation, Maynard, Massachusetts.

using System;

namespace TerraFX.Interop
{
    public static unsafe partial class Xlib
    {
        public const int NoValue = 0x0000;

        public const int XValue = 0x0001;

        public const int YValue = 0x0002;

        public const int WidthValue = 0x0004;

        public const int HeightValue = 0x0008;

        public const int AllValues = 0x000F;

        public const int XNegative = 0x0010;

        public const int YNegative = 0x0020;

        public const int USPosition = 1 << 0;

        public const int USSize = 1 << 1;

        public const int PPosition = 1 << 2;

        public const int PSize = 1 << 3;

        public const int PMinSize = 1 << 4;

        public const int PMaxSize = 1 << 5;

        public const int PResizeInc = 1 << 6;

        public const int PAspect = 1 << 7;

        public const int PBaseSize = 1 << 8;

        public const int PWinGravity = 1 << 9;

        [Obsolete]
        public const int PAllHints = PPosition | PSize | PMinSize | PMaxSize | PResizeInc | PAspect;

        public const int InputHint = 1 << 0;

        public const int StateHint = 1 << 1;

        public const int IconPixmapHint = 1 << 2;

        public const int IconWindowHint = 1 << 3;

        public const int IconPositionHint = 1 << 4;

        public const int IconMaskHint = 1 << 5;

        public const int WindowGroupHint = 1 << 6;

        public const int AllHints = InputHint | StateHint | IconPixmapHint | IconWindowHint | IconPositionHint | IconMaskHint | WindowGroupHint;

        public const int XUrgencyHint = 1 << 8;

        public const int WithdrawnState = 0;

        public const int NormalState = 1;

        public const int IconicState = 3;

        public const int DontCareState = 0;

        public const int ZoomState = 2;

        public const int InactiveState = 4;

        public const int XNoMemory = -1;

        public const int XLocaleNotSupported = -2;

        public const int XConverterNotFound = -3;

        public const int RectangleOut = 0;

        public const int RectangleIn = 1;

        public const int RectanglePart = 2;

        public const int VisualNoMask = 0x0;

        public const int VisualIDMask = 0x1;

        public const int VisualScreenMask = 0x2;

        public const int VisualDepthMask = 0x4;

        public const int VisualClassMask = 0x8;

        public const int VisualRedMaskMask = 0x10;

        public const int VisualGreenMaskMask = 0x20;

        public const int VisualBlueMaskMask = 0x40;

        public const int VisualColormapSizeMask = 0x80;

        public const int VisualBitsPerRGBMask = 0x100;

        public const int VisualAllMask = 0x1FF;

        public const uint ReleaseByFreeingColormap = 1;

        public const int BitmapSuccess = 0;

        public const int BitmapOpenFailed = 1;

        public const int BitmapFileInvalid = 2;

        public const int BitmapNoMemory = 3;

        public const int XCSUCCESS = 0;

        public const int XCNOMEM = 1;

        public const int XCNOENT = 2;

        public static bool IsKeypadKey([NativeTypeName("KeySym")] UIntPtr keysym) => (keysym.ToPointer() >= (void*)XK_KP_Space) && (keysym.ToPointer() <= (void*)XK_KP_Equal);

        public static bool IsPrivateKeypadKey([NativeTypeName("KeySym")] UIntPtr keysym) => (keysym.ToPointer() >= (void*)0x11000000) && (keysym.ToPointer() <= (void*)0x1100FFFF);

        public static bool IsCursorKey([NativeTypeName("KeySym")] UIntPtr keysym) => (keysym.ToPointer() >= (void*)XK_Home) && (keysym.ToPointer() < (void*)XK_Select);

        public static bool IsPFKey([NativeTypeName("KeySym")] UIntPtr keysym) => (keysym.ToPointer() >= (void*)XK_KP_F1) && (keysym.ToPointer() <= (void*)XK_KP_F4);

        public static bool IsFunctionKey([NativeTypeName("KeySym")] UIntPtr keysym) => (keysym.ToPointer() >= (void*)XK_F1) && (keysym.ToPointer() <= (void*)XK_F35);

        public static bool IsMiscFunctionKey([NativeTypeName("KeySym")] UIntPtr keysym) => (keysym.ToPointer() >= (void*)XK_Select) && (keysym.ToPointer() <= (void*)XK_Break);

        public static bool IsModifierKey([NativeTypeName("KeySym")] UIntPtr keysym) => ((keysym.ToPointer() >= (void*)XK_Shift_L) && (keysym.ToPointer() <= (void*)XK_Hyper_R)) || ((keysym.ToPointer() >= (void*)XK_ISO_Lock) && (keysym.ToPointer() <= (void*)XK_ISO_Level5_Lock)) || (keysym.ToPointer() == (void*)XK_Mode_switch) || (keysym.ToPointer() == (void*)XK_Num_Lock);

        [return: NativeTypeName("XContext")]
        public static int XUniqueContext() => XrmUniqueQuark();

        [return: NativeTypeName("XContext")]
        public static int XStringToContext([NativeTypeName("const char *")] sbyte* c_string) => XrmStringToQuark(c_string);
    }
}
