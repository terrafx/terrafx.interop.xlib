// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xatom.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop
{
    public static partial class Xlib
    {
        [NativeTypeName("#define XA_PRIMARY ((Atom) 1)")]
        public const nuint XA_PRIMARY = ((nuint)(1));

        [NativeTypeName("#define XA_SECONDARY ((Atom) 2)")]
        public const nuint XA_SECONDARY = ((nuint)(2));

        [NativeTypeName("#define XA_ARC ((Atom) 3)")]
        public const nuint XA_ARC = ((nuint)(3));

        [NativeTypeName("#define XA_ATOM ((Atom) 4)")]
        public const nuint XA_ATOM = ((nuint)(4));

        [NativeTypeName("#define XA_BITMAP ((Atom) 5)")]
        public const nuint XA_BITMAP = ((nuint)(5));

        [NativeTypeName("#define XA_CARDINAL ((Atom) 6)")]
        public const nuint XA_CARDINAL = ((nuint)(6));

        [NativeTypeName("#define XA_COLORMAP ((Atom) 7)")]
        public const nuint XA_COLORMAP = ((nuint)(7));

        [NativeTypeName("#define XA_CURSOR ((Atom) 8)")]
        public const nuint XA_CURSOR = ((nuint)(8));

        [NativeTypeName("#define XA_CUT_BUFFER0 ((Atom) 9)")]
        public const nuint XA_CUT_BUFFER0 = ((nuint)(9));

        [NativeTypeName("#define XA_CUT_BUFFER1 ((Atom) 10)")]
        public const nuint XA_CUT_BUFFER1 = ((nuint)(10));

        [NativeTypeName("#define XA_CUT_BUFFER2 ((Atom) 11)")]
        public const nuint XA_CUT_BUFFER2 = ((nuint)(11));

        [NativeTypeName("#define XA_CUT_BUFFER3 ((Atom) 12)")]
        public const nuint XA_CUT_BUFFER3 = ((nuint)(12));

        [NativeTypeName("#define XA_CUT_BUFFER4 ((Atom) 13)")]
        public const nuint XA_CUT_BUFFER4 = ((nuint)(13));

        [NativeTypeName("#define XA_CUT_BUFFER5 ((Atom) 14)")]
        public const nuint XA_CUT_BUFFER5 = ((nuint)(14));

        [NativeTypeName("#define XA_CUT_BUFFER6 ((Atom) 15)")]
        public const nuint XA_CUT_BUFFER6 = ((nuint)(15));

        [NativeTypeName("#define XA_CUT_BUFFER7 ((Atom) 16)")]
        public const nuint XA_CUT_BUFFER7 = ((nuint)(16));

        [NativeTypeName("#define XA_DRAWABLE ((Atom) 17)")]
        public const nuint XA_DRAWABLE = ((nuint)(17));

        [NativeTypeName("#define XA_FONT ((Atom) 18)")]
        public const nuint XA_FONT = ((nuint)(18));

        [NativeTypeName("#define XA_INTEGER ((Atom) 19)")]
        public const nuint XA_INTEGER = ((nuint)(19));

        [NativeTypeName("#define XA_PIXMAP ((Atom) 20)")]
        public const nuint XA_PIXMAP = ((nuint)(20));

        [NativeTypeName("#define XA_POINT ((Atom) 21)")]
        public const nuint XA_POINT = ((nuint)(21));

        [NativeTypeName("#define XA_RECTANGLE ((Atom) 22)")]
        public const nuint XA_RECTANGLE = ((nuint)(22));

        [NativeTypeName("#define XA_RESOURCE_MANAGER ((Atom) 23)")]
        public const nuint XA_RESOURCE_MANAGER = ((nuint)(23));

        [NativeTypeName("#define XA_RGB_COLOR_MAP ((Atom) 24)")]
        public const nuint XA_RGB_COLOR_MAP = ((nuint)(24));

        [NativeTypeName("#define XA_RGB_BEST_MAP ((Atom) 25)")]
        public const nuint XA_RGB_BEST_MAP = ((nuint)(25));

        [NativeTypeName("#define XA_RGB_BLUE_MAP ((Atom) 26)")]
        public const nuint XA_RGB_BLUE_MAP = ((nuint)(26));

        [NativeTypeName("#define XA_RGB_DEFAULT_MAP ((Atom) 27)")]
        public const nuint XA_RGB_DEFAULT_MAP = ((nuint)(27));

        [NativeTypeName("#define XA_RGB_GRAY_MAP ((Atom) 28)")]
        public const nuint XA_RGB_GRAY_MAP = ((nuint)(28));

        [NativeTypeName("#define XA_RGB_GREEN_MAP ((Atom) 29)")]
        public const nuint XA_RGB_GREEN_MAP = ((nuint)(29));

        [NativeTypeName("#define XA_RGB_RED_MAP ((Atom) 30)")]
        public const nuint XA_RGB_RED_MAP = ((nuint)(30));

        [NativeTypeName("#define XA_STRING ((Atom) 31)")]
        public const nuint XA_STRING = ((nuint)(31));

        [NativeTypeName("#define XA_VISUALID ((Atom) 32)")]
        public const nuint XA_VISUALID = ((nuint)(32));

        [NativeTypeName("#define XA_WINDOW ((Atom) 33)")]
        public const nuint XA_WINDOW = ((nuint)(33));

        [NativeTypeName("#define XA_WM_COMMAND ((Atom) 34)")]
        public const nuint XA_WM_COMMAND = ((nuint)(34));

        [NativeTypeName("#define XA_WM_HINTS ((Atom) 35)")]
        public const nuint XA_WM_HINTS = ((nuint)(35));

        [NativeTypeName("#define XA_WM_CLIENT_MACHINE ((Atom) 36)")]
        public const nuint XA_WM_CLIENT_MACHINE = ((nuint)(36));

        [NativeTypeName("#define XA_WM_ICON_NAME ((Atom) 37)")]
        public const nuint XA_WM_ICON_NAME = ((nuint)(37));

        [NativeTypeName("#define XA_WM_ICON_SIZE ((Atom) 38)")]
        public const nuint XA_WM_ICON_SIZE = ((nuint)(38));

        [NativeTypeName("#define XA_WM_NAME ((Atom) 39)")]
        public const nuint XA_WM_NAME = ((nuint)(39));

        [NativeTypeName("#define XA_WM_NORMAL_HINTS ((Atom) 40)")]
        public const nuint XA_WM_NORMAL_HINTS = ((nuint)(40));

        [NativeTypeName("#define XA_WM_SIZE_HINTS ((Atom) 41)")]
        public const nuint XA_WM_SIZE_HINTS = ((nuint)(41));

        [NativeTypeName("#define XA_WM_ZOOM_HINTS ((Atom) 42)")]
        public const nuint XA_WM_ZOOM_HINTS = ((nuint)(42));

        [NativeTypeName("#define XA_MIN_SPACE ((Atom) 43)")]
        public const nuint XA_MIN_SPACE = ((nuint)(43));

        [NativeTypeName("#define XA_NORM_SPACE ((Atom) 44)")]
        public const nuint XA_NORM_SPACE = ((nuint)(44));

        [NativeTypeName("#define XA_MAX_SPACE ((Atom) 45)")]
        public const nuint XA_MAX_SPACE = ((nuint)(45));

        [NativeTypeName("#define XA_END_SPACE ((Atom) 46)")]
        public const nuint XA_END_SPACE = ((nuint)(46));

        [NativeTypeName("#define XA_SUPERSCRIPT_X ((Atom) 47)")]
        public const nuint XA_SUPERSCRIPT_X = ((nuint)(47));

        [NativeTypeName("#define XA_SUPERSCRIPT_Y ((Atom) 48)")]
        public const nuint XA_SUPERSCRIPT_Y = ((nuint)(48));

        [NativeTypeName("#define XA_SUBSCRIPT_X ((Atom) 49)")]
        public const nuint XA_SUBSCRIPT_X = ((nuint)(49));

        [NativeTypeName("#define XA_SUBSCRIPT_Y ((Atom) 50)")]
        public const nuint XA_SUBSCRIPT_Y = ((nuint)(50));

        [NativeTypeName("#define XA_UNDERLINE_POSITION ((Atom) 51)")]
        public const nuint XA_UNDERLINE_POSITION = ((nuint)(51));

        [NativeTypeName("#define XA_UNDERLINE_THICKNESS ((Atom) 52)")]
        public const nuint XA_UNDERLINE_THICKNESS = ((nuint)(52));

        [NativeTypeName("#define XA_STRIKEOUT_ASCENT ((Atom) 53)")]
        public const nuint XA_STRIKEOUT_ASCENT = ((nuint)(53));

        [NativeTypeName("#define XA_STRIKEOUT_DESCENT ((Atom) 54)")]
        public const nuint XA_STRIKEOUT_DESCENT = ((nuint)(54));

        [NativeTypeName("#define XA_ITALIC_ANGLE ((Atom) 55)")]
        public const nuint XA_ITALIC_ANGLE = ((nuint)(55));

        [NativeTypeName("#define XA_X_HEIGHT ((Atom) 56)")]
        public const nuint XA_X_HEIGHT = ((nuint)(56));

        [NativeTypeName("#define XA_QUAD_WIDTH ((Atom) 57)")]
        public const nuint XA_QUAD_WIDTH = ((nuint)(57));

        [NativeTypeName("#define XA_WEIGHT ((Atom) 58)")]
        public const nuint XA_WEIGHT = ((nuint)(58));

        [NativeTypeName("#define XA_POINT_SIZE ((Atom) 59)")]
        public const nuint XA_POINT_SIZE = ((nuint)(59));

        [NativeTypeName("#define XA_RESOLUTION ((Atom) 60)")]
        public const nuint XA_RESOLUTION = ((nuint)(60));

        [NativeTypeName("#define XA_COPYRIGHT ((Atom) 61)")]
        public const nuint XA_COPYRIGHT = ((nuint)(61));

        [NativeTypeName("#define XA_NOTICE ((Atom) 62)")]
        public const nuint XA_NOTICE = ((nuint)(62));

        [NativeTypeName("#define XA_FONT_NAME ((Atom) 63)")]
        public const nuint XA_FONT_NAME = ((nuint)(63));

        [NativeTypeName("#define XA_FAMILY_NAME ((Atom) 64)")]
        public const nuint XA_FAMILY_NAME = ((nuint)(64));

        [NativeTypeName("#define XA_FULL_NAME ((Atom) 65)")]
        public const nuint XA_FULL_NAME = ((nuint)(65));

        [NativeTypeName("#define XA_CAP_HEIGHT ((Atom) 66)")]
        public const nuint XA_CAP_HEIGHT = ((nuint)(66));

        [NativeTypeName("#define XA_WM_CLASS ((Atom) 67)")]
        public const nuint XA_WM_CLASS = ((nuint)(67));

        [NativeTypeName("#define XA_WM_TRANSIENT_FOR ((Atom) 68)")]
        public const nuint XA_WM_TRANSIENT_FOR = ((nuint)(68));

        [NativeTypeName("#define XA_LAST_PREDEFINED ((Atom) 68)")]
        public const nuint XA_LAST_PREDEFINED = ((nuint)(68));
    }
}
