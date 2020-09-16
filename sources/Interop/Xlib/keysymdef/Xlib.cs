// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/keysymdef.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop
{
    public static partial class Xlib
    {
        [NativeTypeName("#define XK_VoidSymbol 0xffffff")]
        public const int XK_VoidSymbol = 0xffffff;

        [NativeTypeName("#define XK_BackSpace 0xff08")]
        public const int XK_BackSpace = 0xff08;

        [NativeTypeName("#define XK_Tab 0xff09")]
        public const int XK_Tab = 0xff09;

        [NativeTypeName("#define XK_Linefeed 0xff0a")]
        public const int XK_Linefeed = 0xff0a;

        [NativeTypeName("#define XK_Clear 0xff0b")]
        public const int XK_Clear = 0xff0b;

        [NativeTypeName("#define XK_Return 0xff0d")]
        public const int XK_Return = 0xff0d;

        [NativeTypeName("#define XK_Pause 0xff13")]
        public const int XK_Pause = 0xff13;

        [NativeTypeName("#define XK_Scroll_Lock 0xff14")]
        public const int XK_Scroll_Lock = 0xff14;

        [NativeTypeName("#define XK_Sys_Req 0xff15")]
        public const int XK_Sys_Req = 0xff15;

        [NativeTypeName("#define XK_Escape 0xff1b")]
        public const int XK_Escape = 0xff1b;

        [NativeTypeName("#define XK_Delete 0xffff")]
        public const int XK_Delete = 0xffff;

        [NativeTypeName("#define XK_Multi_key 0xff20")]
        public const int XK_Multi_key = 0xff20;

        [NativeTypeName("#define XK_Codeinput 0xff37")]
        public const int XK_Codeinput = 0xff37;

        [NativeTypeName("#define XK_SingleCandidate 0xff3c")]
        public const int XK_SingleCandidate = 0xff3c;

        [NativeTypeName("#define XK_MultipleCandidate 0xff3d")]
        public const int XK_MultipleCandidate = 0xff3d;

        [NativeTypeName("#define XK_PreviousCandidate 0xff3e")]
        public const int XK_PreviousCandidate = 0xff3e;

        [NativeTypeName("#define XK_Kanji 0xff21")]
        public const int XK_Kanji = 0xff21;

        [NativeTypeName("#define XK_Muhenkan 0xff22")]
        public const int XK_Muhenkan = 0xff22;

        [NativeTypeName("#define XK_Henkan_Mode 0xff23")]
        public const int XK_Henkan_Mode = 0xff23;

        [NativeTypeName("#define XK_Henkan 0xff23")]
        public const int XK_Henkan = 0xff23;

        [NativeTypeName("#define XK_Romaji 0xff24")]
        public const int XK_Romaji = 0xff24;

        [NativeTypeName("#define XK_Hiragana 0xff25")]
        public const int XK_Hiragana = 0xff25;

        [NativeTypeName("#define XK_Katakana 0xff26")]
        public const int XK_Katakana = 0xff26;

        [NativeTypeName("#define XK_Hiragana_Katakana 0xff27")]
        public const int XK_Hiragana_Katakana = 0xff27;

        [NativeTypeName("#define XK_Zenkaku 0xff28")]
        public const int XK_Zenkaku = 0xff28;

        [NativeTypeName("#define XK_Hankaku 0xff29")]
        public const int XK_Hankaku = 0xff29;

        [NativeTypeName("#define XK_Zenkaku_Hankaku 0xff2a")]
        public const int XK_Zenkaku_Hankaku = 0xff2a;

        [NativeTypeName("#define XK_Touroku 0xff2b")]
        public const int XK_Touroku = 0xff2b;

        [NativeTypeName("#define XK_Massyo 0xff2c")]
        public const int XK_Massyo = 0xff2c;

        [NativeTypeName("#define XK_Kana_Lock 0xff2d")]
        public const int XK_Kana_Lock = 0xff2d;

        [NativeTypeName("#define XK_Kana_Shift 0xff2e")]
        public const int XK_Kana_Shift = 0xff2e;

        [NativeTypeName("#define XK_Eisu_Shift 0xff2f")]
        public const int XK_Eisu_Shift = 0xff2f;

        [NativeTypeName("#define XK_Eisu_toggle 0xff30")]
        public const int XK_Eisu_toggle = 0xff30;

        [NativeTypeName("#define XK_Kanji_Bangou 0xff37")]
        public const int XK_Kanji_Bangou = 0xff37;

        [NativeTypeName("#define XK_Zen_Koho 0xff3d")]
        public const int XK_Zen_Koho = 0xff3d;

        [NativeTypeName("#define XK_Mae_Koho 0xff3e")]
        public const int XK_Mae_Koho = 0xff3e;

        [NativeTypeName("#define XK_Home 0xff50")]
        public const int XK_Home = 0xff50;

        [NativeTypeName("#define XK_Left 0xff51")]
        public const int XK_Left = 0xff51;

        [NativeTypeName("#define XK_Up 0xff52")]
        public const int XK_Up = 0xff52;

        [NativeTypeName("#define XK_Right 0xff53")]
        public const int XK_Right = 0xff53;

        [NativeTypeName("#define XK_Down 0xff54")]
        public const int XK_Down = 0xff54;

        [NativeTypeName("#define XK_Prior 0xff55")]
        public const int XK_Prior = 0xff55;

        [NativeTypeName("#define XK_Page_Up 0xff55")]
        public const int XK_Page_Up = 0xff55;

        [NativeTypeName("#define XK_Next 0xff56")]
        public const int XK_Next = 0xff56;

        [NativeTypeName("#define XK_Page_Down 0xff56")]
        public const int XK_Page_Down = 0xff56;

        [NativeTypeName("#define XK_End 0xff57")]
        public const int XK_End = 0xff57;

        [NativeTypeName("#define XK_Begin 0xff58")]
        public const int XK_Begin = 0xff58;

        [NativeTypeName("#define XK_Select 0xff60")]
        public const int XK_Select = 0xff60;

        [NativeTypeName("#define XK_Print 0xff61")]
        public const int XK_Print = 0xff61;

        [NativeTypeName("#define XK_Execute 0xff62")]
        public const int XK_Execute = 0xff62;

        [NativeTypeName("#define XK_Insert 0xff63")]
        public const int XK_Insert = 0xff63;

        [NativeTypeName("#define XK_Undo 0xff65")]
        public const int XK_Undo = 0xff65;

        [NativeTypeName("#define XK_Redo 0xff66")]
        public const int XK_Redo = 0xff66;

        [NativeTypeName("#define XK_Menu 0xff67")]
        public const int XK_Menu = 0xff67;

        [NativeTypeName("#define XK_Find 0xff68")]
        public const int XK_Find = 0xff68;

        [NativeTypeName("#define XK_Cancel 0xff69")]
        public const int XK_Cancel = 0xff69;

        [NativeTypeName("#define XK_Help 0xff6a")]
        public const int XK_Help = 0xff6a;

        [NativeTypeName("#define XK_Break 0xff6b")]
        public const int XK_Break = 0xff6b;

        [NativeTypeName("#define XK_Mode_switch 0xff7e")]
        public const int XK_Mode_switch = 0xff7e;

        [NativeTypeName("#define XK_script_switch 0xff7e")]
        public const int XK_script_switch = 0xff7e;

        [NativeTypeName("#define XK_Num_Lock 0xff7f")]
        public const int XK_Num_Lock = 0xff7f;

        [NativeTypeName("#define XK_KP_Space 0xff80")]
        public const int XK_KP_Space = 0xff80;

        [NativeTypeName("#define XK_KP_Tab 0xff89")]
        public const int XK_KP_Tab = 0xff89;

        [NativeTypeName("#define XK_KP_Enter 0xff8d")]
        public const int XK_KP_Enter = 0xff8d;

        [NativeTypeName("#define XK_KP_F1 0xff91")]
        public const int XK_KP_F1 = 0xff91;

        [NativeTypeName("#define XK_KP_F2 0xff92")]
        public const int XK_KP_F2 = 0xff92;

        [NativeTypeName("#define XK_KP_F3 0xff93")]
        public const int XK_KP_F3 = 0xff93;

        [NativeTypeName("#define XK_KP_F4 0xff94")]
        public const int XK_KP_F4 = 0xff94;

        [NativeTypeName("#define XK_KP_Home 0xff95")]
        public const int XK_KP_Home = 0xff95;

        [NativeTypeName("#define XK_KP_Left 0xff96")]
        public const int XK_KP_Left = 0xff96;

        [NativeTypeName("#define XK_KP_Up 0xff97")]
        public const int XK_KP_Up = 0xff97;

        [NativeTypeName("#define XK_KP_Right 0xff98")]
        public const int XK_KP_Right = 0xff98;

        [NativeTypeName("#define XK_KP_Down 0xff99")]
        public const int XK_KP_Down = 0xff99;

        [NativeTypeName("#define XK_KP_Prior 0xff9a")]
        public const int XK_KP_Prior = 0xff9a;

        [NativeTypeName("#define XK_KP_Page_Up 0xff9a")]
        public const int XK_KP_Page_Up = 0xff9a;

        [NativeTypeName("#define XK_KP_Next 0xff9b")]
        public const int XK_KP_Next = 0xff9b;

        [NativeTypeName("#define XK_KP_Page_Down 0xff9b")]
        public const int XK_KP_Page_Down = 0xff9b;

        [NativeTypeName("#define XK_KP_End 0xff9c")]
        public const int XK_KP_End = 0xff9c;

        [NativeTypeName("#define XK_KP_Begin 0xff9d")]
        public const int XK_KP_Begin = 0xff9d;

        [NativeTypeName("#define XK_KP_Insert 0xff9e")]
        public const int XK_KP_Insert = 0xff9e;

        [NativeTypeName("#define XK_KP_Delete 0xff9f")]
        public const int XK_KP_Delete = 0xff9f;

        [NativeTypeName("#define XK_KP_Equal 0xffbd")]
        public const int XK_KP_Equal = 0xffbd;

        [NativeTypeName("#define XK_KP_Multiply 0xffaa")]
        public const int XK_KP_Multiply = 0xffaa;

        [NativeTypeName("#define XK_KP_Add 0xffab")]
        public const int XK_KP_Add = 0xffab;

        [NativeTypeName("#define XK_KP_Separator 0xffac")]
        public const int XK_KP_Separator = 0xffac;

        [NativeTypeName("#define XK_KP_Subtract 0xffad")]
        public const int XK_KP_Subtract = 0xffad;

        [NativeTypeName("#define XK_KP_Decimal 0xffae")]
        public const int XK_KP_Decimal = 0xffae;

        [NativeTypeName("#define XK_KP_Divide 0xffaf")]
        public const int XK_KP_Divide = 0xffaf;

        [NativeTypeName("#define XK_KP_0 0xffb0")]
        public const int XK_KP_0 = 0xffb0;

        [NativeTypeName("#define XK_KP_1 0xffb1")]
        public const int XK_KP_1 = 0xffb1;

        [NativeTypeName("#define XK_KP_2 0xffb2")]
        public const int XK_KP_2 = 0xffb2;

        [NativeTypeName("#define XK_KP_3 0xffb3")]
        public const int XK_KP_3 = 0xffb3;

        [NativeTypeName("#define XK_KP_4 0xffb4")]
        public const int XK_KP_4 = 0xffb4;

        [NativeTypeName("#define XK_KP_5 0xffb5")]
        public const int XK_KP_5 = 0xffb5;

        [NativeTypeName("#define XK_KP_6 0xffb6")]
        public const int XK_KP_6 = 0xffb6;

        [NativeTypeName("#define XK_KP_7 0xffb7")]
        public const int XK_KP_7 = 0xffb7;

        [NativeTypeName("#define XK_KP_8 0xffb8")]
        public const int XK_KP_8 = 0xffb8;

        [NativeTypeName("#define XK_KP_9 0xffb9")]
        public const int XK_KP_9 = 0xffb9;

        [NativeTypeName("#define XK_F1 0xffbe")]
        public const int XK_F1 = 0xffbe;

        [NativeTypeName("#define XK_F2 0xffbf")]
        public const int XK_F2 = 0xffbf;

        [NativeTypeName("#define XK_F3 0xffc0")]
        public const int XK_F3 = 0xffc0;

        [NativeTypeName("#define XK_F4 0xffc1")]
        public const int XK_F4 = 0xffc1;

        [NativeTypeName("#define XK_F5 0xffc2")]
        public const int XK_F5 = 0xffc2;

        [NativeTypeName("#define XK_F6 0xffc3")]
        public const int XK_F6 = 0xffc3;

        [NativeTypeName("#define XK_F7 0xffc4")]
        public const int XK_F7 = 0xffc4;

        [NativeTypeName("#define XK_F8 0xffc5")]
        public const int XK_F8 = 0xffc5;

        [NativeTypeName("#define XK_F9 0xffc6")]
        public const int XK_F9 = 0xffc6;

        [NativeTypeName("#define XK_F10 0xffc7")]
        public const int XK_F10 = 0xffc7;

        [NativeTypeName("#define XK_F11 0xffc8")]
        public const int XK_F11 = 0xffc8;

        [NativeTypeName("#define XK_L1 0xffc8")]
        public const int XK_L1 = 0xffc8;

        [NativeTypeName("#define XK_F12 0xffc9")]
        public const int XK_F12 = 0xffc9;

        [NativeTypeName("#define XK_L2 0xffc9")]
        public const int XK_L2 = 0xffc9;

        [NativeTypeName("#define XK_F13 0xffca")]
        public const int XK_F13 = 0xffca;

        [NativeTypeName("#define XK_L3 0xffca")]
        public const int XK_L3 = 0xffca;

        [NativeTypeName("#define XK_F14 0xffcb")]
        public const int XK_F14 = 0xffcb;

        [NativeTypeName("#define XK_L4 0xffcb")]
        public const int XK_L4 = 0xffcb;

        [NativeTypeName("#define XK_F15 0xffcc")]
        public const int XK_F15 = 0xffcc;

        [NativeTypeName("#define XK_L5 0xffcc")]
        public const int XK_L5 = 0xffcc;

        [NativeTypeName("#define XK_F16 0xffcd")]
        public const int XK_F16 = 0xffcd;

        [NativeTypeName("#define XK_L6 0xffcd")]
        public const int XK_L6 = 0xffcd;

        [NativeTypeName("#define XK_F17 0xffce")]
        public const int XK_F17 = 0xffce;

        [NativeTypeName("#define XK_L7 0xffce")]
        public const int XK_L7 = 0xffce;

        [NativeTypeName("#define XK_F18 0xffcf")]
        public const int XK_F18 = 0xffcf;

        [NativeTypeName("#define XK_L8 0xffcf")]
        public const int XK_L8 = 0xffcf;

        [NativeTypeName("#define XK_F19 0xffd0")]
        public const int XK_F19 = 0xffd0;

        [NativeTypeName("#define XK_L9 0xffd0")]
        public const int XK_L9 = 0xffd0;

        [NativeTypeName("#define XK_F20 0xffd1")]
        public const int XK_F20 = 0xffd1;

        [NativeTypeName("#define XK_L10 0xffd1")]
        public const int XK_L10 = 0xffd1;

        [NativeTypeName("#define XK_F21 0xffd2")]
        public const int XK_F21 = 0xffd2;

        [NativeTypeName("#define XK_R1 0xffd2")]
        public const int XK_R1 = 0xffd2;

        [NativeTypeName("#define XK_F22 0xffd3")]
        public const int XK_F22 = 0xffd3;

        [NativeTypeName("#define XK_R2 0xffd3")]
        public const int XK_R2 = 0xffd3;

        [NativeTypeName("#define XK_F23 0xffd4")]
        public const int XK_F23 = 0xffd4;

        [NativeTypeName("#define XK_R3 0xffd4")]
        public const int XK_R3 = 0xffd4;

        [NativeTypeName("#define XK_F24 0xffd5")]
        public const int XK_F24 = 0xffd5;

        [NativeTypeName("#define XK_R4 0xffd5")]
        public const int XK_R4 = 0xffd5;

        [NativeTypeName("#define XK_F25 0xffd6")]
        public const int XK_F25 = 0xffd6;

        [NativeTypeName("#define XK_R5 0xffd6")]
        public const int XK_R5 = 0xffd6;

        [NativeTypeName("#define XK_F26 0xffd7")]
        public const int XK_F26 = 0xffd7;

        [NativeTypeName("#define XK_R6 0xffd7")]
        public const int XK_R6 = 0xffd7;

        [NativeTypeName("#define XK_F27 0xffd8")]
        public const int XK_F27 = 0xffd8;

        [NativeTypeName("#define XK_R7 0xffd8")]
        public const int XK_R7 = 0xffd8;

        [NativeTypeName("#define XK_F28 0xffd9")]
        public const int XK_F28 = 0xffd9;

        [NativeTypeName("#define XK_R8 0xffd9")]
        public const int XK_R8 = 0xffd9;

        [NativeTypeName("#define XK_F29 0xffda")]
        public const int XK_F29 = 0xffda;

        [NativeTypeName("#define XK_R9 0xffda")]
        public const int XK_R9 = 0xffda;

        [NativeTypeName("#define XK_F30 0xffdb")]
        public const int XK_F30 = 0xffdb;

        [NativeTypeName("#define XK_R10 0xffdb")]
        public const int XK_R10 = 0xffdb;

        [NativeTypeName("#define XK_F31 0xffdc")]
        public const int XK_F31 = 0xffdc;

        [NativeTypeName("#define XK_R11 0xffdc")]
        public const int XK_R11 = 0xffdc;

        [NativeTypeName("#define XK_F32 0xffdd")]
        public const int XK_F32 = 0xffdd;

        [NativeTypeName("#define XK_R12 0xffdd")]
        public const int XK_R12 = 0xffdd;

        [NativeTypeName("#define XK_F33 0xffde")]
        public const int XK_F33 = 0xffde;

        [NativeTypeName("#define XK_R13 0xffde")]
        public const int XK_R13 = 0xffde;

        [NativeTypeName("#define XK_F34 0xffdf")]
        public const int XK_F34 = 0xffdf;

        [NativeTypeName("#define XK_R14 0xffdf")]
        public const int XK_R14 = 0xffdf;

        [NativeTypeName("#define XK_F35 0xffe0")]
        public const int XK_F35 = 0xffe0;

        [NativeTypeName("#define XK_R15 0xffe0")]
        public const int XK_R15 = 0xffe0;

        [NativeTypeName("#define XK_Shift_L 0xffe1")]
        public const int XK_Shift_L = 0xffe1;

        [NativeTypeName("#define XK_Shift_R 0xffe2")]
        public const int XK_Shift_R = 0xffe2;

        [NativeTypeName("#define XK_Control_L 0xffe3")]
        public const int XK_Control_L = 0xffe3;

        [NativeTypeName("#define XK_Control_R 0xffe4")]
        public const int XK_Control_R = 0xffe4;

        [NativeTypeName("#define XK_Caps_Lock 0xffe5")]
        public const int XK_Caps_Lock = 0xffe5;

        [NativeTypeName("#define XK_Shift_Lock 0xffe6")]
        public const int XK_Shift_Lock = 0xffe6;

        [NativeTypeName("#define XK_Meta_L 0xffe7")]
        public const int XK_Meta_L = 0xffe7;

        [NativeTypeName("#define XK_Meta_R 0xffe8")]
        public const int XK_Meta_R = 0xffe8;

        [NativeTypeName("#define XK_Alt_L 0xffe9")]
        public const int XK_Alt_L = 0xffe9;

        [NativeTypeName("#define XK_Alt_R 0xffea")]
        public const int XK_Alt_R = 0xffea;

        [NativeTypeName("#define XK_Super_L 0xffeb")]
        public const int XK_Super_L = 0xffeb;

        [NativeTypeName("#define XK_Super_R 0xffec")]
        public const int XK_Super_R = 0xffec;

        [NativeTypeName("#define XK_Hyper_L 0xffed")]
        public const int XK_Hyper_L = 0xffed;

        [NativeTypeName("#define XK_Hyper_R 0xffee")]
        public const int XK_Hyper_R = 0xffee;

        [NativeTypeName("#define XK_ISO_Lock 0xfe01")]
        public const int XK_ISO_Lock = 0xfe01;

        [NativeTypeName("#define XK_ISO_Level2_Latch 0xfe02")]
        public const int XK_ISO_Level2_Latch = 0xfe02;

        [NativeTypeName("#define XK_ISO_Level3_Shift 0xfe03")]
        public const int XK_ISO_Level3_Shift = 0xfe03;

        [NativeTypeName("#define XK_ISO_Level3_Latch 0xfe04")]
        public const int XK_ISO_Level3_Latch = 0xfe04;

        [NativeTypeName("#define XK_ISO_Level3_Lock 0xfe05")]
        public const int XK_ISO_Level3_Lock = 0xfe05;

        [NativeTypeName("#define XK_ISO_Level5_Shift 0xfe11")]
        public const int XK_ISO_Level5_Shift = 0xfe11;

        [NativeTypeName("#define XK_ISO_Level5_Latch 0xfe12")]
        public const int XK_ISO_Level5_Latch = 0xfe12;

        [NativeTypeName("#define XK_ISO_Level5_Lock 0xfe13")]
        public const int XK_ISO_Level5_Lock = 0xfe13;

        [NativeTypeName("#define XK_ISO_Group_Shift 0xff7e")]
        public const int XK_ISO_Group_Shift = 0xff7e;

        [NativeTypeName("#define XK_ISO_Group_Latch 0xfe06")]
        public const int XK_ISO_Group_Latch = 0xfe06;

        [NativeTypeName("#define XK_ISO_Group_Lock 0xfe07")]
        public const int XK_ISO_Group_Lock = 0xfe07;

        [NativeTypeName("#define XK_ISO_Next_Group 0xfe08")]
        public const int XK_ISO_Next_Group = 0xfe08;

        [NativeTypeName("#define XK_ISO_Next_Group_Lock 0xfe09")]
        public const int XK_ISO_Next_Group_Lock = 0xfe09;

        [NativeTypeName("#define XK_ISO_Prev_Group 0xfe0a")]
        public const int XK_ISO_Prev_Group = 0xfe0a;

        [NativeTypeName("#define XK_ISO_Prev_Group_Lock 0xfe0b")]
        public const int XK_ISO_Prev_Group_Lock = 0xfe0b;

        [NativeTypeName("#define XK_ISO_First_Group 0xfe0c")]
        public const int XK_ISO_First_Group = 0xfe0c;

        [NativeTypeName("#define XK_ISO_First_Group_Lock 0xfe0d")]
        public const int XK_ISO_First_Group_Lock = 0xfe0d;

        [NativeTypeName("#define XK_ISO_Last_Group 0xfe0e")]
        public const int XK_ISO_Last_Group = 0xfe0e;

        [NativeTypeName("#define XK_ISO_Last_Group_Lock 0xfe0f")]
        public const int XK_ISO_Last_Group_Lock = 0xfe0f;

        [NativeTypeName("#define XK_ISO_Left_Tab 0xfe20")]
        public const int XK_ISO_Left_Tab = 0xfe20;

        [NativeTypeName("#define XK_ISO_Move_Line_Up 0xfe21")]
        public const int XK_ISO_Move_Line_Up = 0xfe21;

        [NativeTypeName("#define XK_ISO_Move_Line_Down 0xfe22")]
        public const int XK_ISO_Move_Line_Down = 0xfe22;

        [NativeTypeName("#define XK_ISO_Partial_Line_Up 0xfe23")]
        public const int XK_ISO_Partial_Line_Up = 0xfe23;

        [NativeTypeName("#define XK_ISO_Partial_Line_Down 0xfe24")]
        public const int XK_ISO_Partial_Line_Down = 0xfe24;

        [NativeTypeName("#define XK_ISO_Partial_Space_Left 0xfe25")]
        public const int XK_ISO_Partial_Space_Left = 0xfe25;

        [NativeTypeName("#define XK_ISO_Partial_Space_Right 0xfe26")]
        public const int XK_ISO_Partial_Space_Right = 0xfe26;

        [NativeTypeName("#define XK_ISO_Set_Margin_Left 0xfe27")]
        public const int XK_ISO_Set_Margin_Left = 0xfe27;

        [NativeTypeName("#define XK_ISO_Set_Margin_Right 0xfe28")]
        public const int XK_ISO_Set_Margin_Right = 0xfe28;

        [NativeTypeName("#define XK_ISO_Release_Margin_Left 0xfe29")]
        public const int XK_ISO_Release_Margin_Left = 0xfe29;

        [NativeTypeName("#define XK_ISO_Release_Margin_Right 0xfe2a")]
        public const int XK_ISO_Release_Margin_Right = 0xfe2a;

        [NativeTypeName("#define XK_ISO_Release_Both_Margins 0xfe2b")]
        public const int XK_ISO_Release_Both_Margins = 0xfe2b;

        [NativeTypeName("#define XK_ISO_Fast_Cursor_Left 0xfe2c")]
        public const int XK_ISO_Fast_Cursor_Left = 0xfe2c;

        [NativeTypeName("#define XK_ISO_Fast_Cursor_Right 0xfe2d")]
        public const int XK_ISO_Fast_Cursor_Right = 0xfe2d;

        [NativeTypeName("#define XK_ISO_Fast_Cursor_Up 0xfe2e")]
        public const int XK_ISO_Fast_Cursor_Up = 0xfe2e;

        [NativeTypeName("#define XK_ISO_Fast_Cursor_Down 0xfe2f")]
        public const int XK_ISO_Fast_Cursor_Down = 0xfe2f;

        [NativeTypeName("#define XK_ISO_Continuous_Underline 0xfe30")]
        public const int XK_ISO_Continuous_Underline = 0xfe30;

        [NativeTypeName("#define XK_ISO_Discontinuous_Underline 0xfe31")]
        public const int XK_ISO_Discontinuous_Underline = 0xfe31;

        [NativeTypeName("#define XK_ISO_Emphasize 0xfe32")]
        public const int XK_ISO_Emphasize = 0xfe32;

        [NativeTypeName("#define XK_ISO_Center_Object 0xfe33")]
        public const int XK_ISO_Center_Object = 0xfe33;

        [NativeTypeName("#define XK_ISO_Enter 0xfe34")]
        public const int XK_ISO_Enter = 0xfe34;

        [NativeTypeName("#define XK_dead_grave 0xfe50")]
        public const int XK_dead_grave = 0xfe50;

        [NativeTypeName("#define XK_dead_acute 0xfe51")]
        public const int XK_dead_acute = 0xfe51;

        [NativeTypeName("#define XK_dead_circumflex 0xfe52")]
        public const int XK_dead_circumflex = 0xfe52;

        [NativeTypeName("#define XK_dead_tilde 0xfe53")]
        public const int XK_dead_tilde = 0xfe53;

        [NativeTypeName("#define XK_dead_perispomeni 0xfe53")]
        public const int XK_dead_perispomeni = 0xfe53;

        [NativeTypeName("#define XK_dead_macron 0xfe54")]
        public const int XK_dead_macron = 0xfe54;

        [NativeTypeName("#define XK_dead_breve 0xfe55")]
        public const int XK_dead_breve = 0xfe55;

        [NativeTypeName("#define XK_dead_abovedot 0xfe56")]
        public const int XK_dead_abovedot = 0xfe56;

        [NativeTypeName("#define XK_dead_diaeresis 0xfe57")]
        public const int XK_dead_diaeresis = 0xfe57;

        [NativeTypeName("#define XK_dead_abovering 0xfe58")]
        public const int XK_dead_abovering = 0xfe58;

        [NativeTypeName("#define XK_dead_doubleacute 0xfe59")]
        public const int XK_dead_doubleacute = 0xfe59;

        [NativeTypeName("#define XK_dead_caron 0xfe5a")]
        public const int XK_dead_caron = 0xfe5a;

        [NativeTypeName("#define XK_dead_cedilla 0xfe5b")]
        public const int XK_dead_cedilla = 0xfe5b;

        [NativeTypeName("#define XK_dead_ogonek 0xfe5c")]
        public const int XK_dead_ogonek = 0xfe5c;

        [NativeTypeName("#define XK_dead_iota 0xfe5d")]
        public const int XK_dead_iota = 0xfe5d;

        [NativeTypeName("#define XK_dead_voiced_sound 0xfe5e")]
        public const int XK_dead_voiced_sound = 0xfe5e;

        [NativeTypeName("#define XK_dead_semivoiced_sound 0xfe5f")]
        public const int XK_dead_semivoiced_sound = 0xfe5f;

        [NativeTypeName("#define XK_dead_belowdot 0xfe60")]
        public const int XK_dead_belowdot = 0xfe60;

        [NativeTypeName("#define XK_dead_hook 0xfe61")]
        public const int XK_dead_hook = 0xfe61;

        [NativeTypeName("#define XK_dead_horn 0xfe62")]
        public const int XK_dead_horn = 0xfe62;

        [NativeTypeName("#define XK_dead_stroke 0xfe63")]
        public const int XK_dead_stroke = 0xfe63;

        [NativeTypeName("#define XK_dead_abovecomma 0xfe64")]
        public const int XK_dead_abovecomma = 0xfe64;

        [NativeTypeName("#define XK_dead_psili 0xfe64")]
        public const int XK_dead_psili = 0xfe64;

        [NativeTypeName("#define XK_dead_abovereversedcomma 0xfe65")]
        public const int XK_dead_abovereversedcomma = 0xfe65;

        [NativeTypeName("#define XK_dead_dasia 0xfe65")]
        public const int XK_dead_dasia = 0xfe65;

        [NativeTypeName("#define XK_dead_doublegrave 0xfe66")]
        public const int XK_dead_doublegrave = 0xfe66;

        [NativeTypeName("#define XK_dead_belowring 0xfe67")]
        public const int XK_dead_belowring = 0xfe67;

        [NativeTypeName("#define XK_dead_belowmacron 0xfe68")]
        public const int XK_dead_belowmacron = 0xfe68;

        [NativeTypeName("#define XK_dead_belowcircumflex 0xfe69")]
        public const int XK_dead_belowcircumflex = 0xfe69;

        [NativeTypeName("#define XK_dead_belowtilde 0xfe6a")]
        public const int XK_dead_belowtilde = 0xfe6a;

        [NativeTypeName("#define XK_dead_belowbreve 0xfe6b")]
        public const int XK_dead_belowbreve = 0xfe6b;

        [NativeTypeName("#define XK_dead_belowdiaeresis 0xfe6c")]
        public const int XK_dead_belowdiaeresis = 0xfe6c;

        [NativeTypeName("#define XK_dead_invertedbreve 0xfe6d")]
        public const int XK_dead_invertedbreve = 0xfe6d;

        [NativeTypeName("#define XK_dead_belowcomma 0xfe6e")]
        public const int XK_dead_belowcomma = 0xfe6e;

        [NativeTypeName("#define XK_dead_currency 0xfe6f")]
        public const int XK_dead_currency = 0xfe6f;

        [NativeTypeName("#define XK_dead_lowline 0xfe90")]
        public const int XK_dead_lowline = 0xfe90;

        [NativeTypeName("#define XK_dead_aboveverticalline 0xfe91")]
        public const int XK_dead_aboveverticalline = 0xfe91;

        [NativeTypeName("#define XK_dead_belowverticalline 0xfe92")]
        public const int XK_dead_belowverticalline = 0xfe92;

        [NativeTypeName("#define XK_dead_longsolidusoverlay 0xfe93")]
        public const int XK_dead_longsolidusoverlay = 0xfe93;

        [NativeTypeName("#define XK_dead_a 0xfe80")]
        public const int XK_dead_a = 0xfe80;

        [NativeTypeName("#define XK_dead_A 0xfe81")]
        public const int XK_dead_A = 0xfe81;

        [NativeTypeName("#define XK_dead_e 0xfe82")]
        public const int XK_dead_e = 0xfe82;

        [NativeTypeName("#define XK_dead_E 0xfe83")]
        public const int XK_dead_E = 0xfe83;

        [NativeTypeName("#define XK_dead_i 0xfe84")]
        public const int XK_dead_i = 0xfe84;

        [NativeTypeName("#define XK_dead_I 0xfe85")]
        public const int XK_dead_I = 0xfe85;

        [NativeTypeName("#define XK_dead_o 0xfe86")]
        public const int XK_dead_o = 0xfe86;

        [NativeTypeName("#define XK_dead_O 0xfe87")]
        public const int XK_dead_O = 0xfe87;

        [NativeTypeName("#define XK_dead_u 0xfe88")]
        public const int XK_dead_u = 0xfe88;

        [NativeTypeName("#define XK_dead_U 0xfe89")]
        public const int XK_dead_U = 0xfe89;

        [NativeTypeName("#define XK_dead_small_schwa 0xfe8a")]
        public const int XK_dead_small_schwa = 0xfe8a;

        [NativeTypeName("#define XK_dead_capital_schwa 0xfe8b")]
        public const int XK_dead_capital_schwa = 0xfe8b;

        [NativeTypeName("#define XK_dead_greek 0xfe8c")]
        public const int XK_dead_greek = 0xfe8c;

        [NativeTypeName("#define XK_First_Virtual_Screen 0xfed0")]
        public const int XK_First_Virtual_Screen = 0xfed0;

        [NativeTypeName("#define XK_Prev_Virtual_Screen 0xfed1")]
        public const int XK_Prev_Virtual_Screen = 0xfed1;

        [NativeTypeName("#define XK_Next_Virtual_Screen 0xfed2")]
        public const int XK_Next_Virtual_Screen = 0xfed2;

        [NativeTypeName("#define XK_Last_Virtual_Screen 0xfed4")]
        public const int XK_Last_Virtual_Screen = 0xfed4;

        [NativeTypeName("#define XK_Terminate_Server 0xfed5")]
        public const int XK_Terminate_Server = 0xfed5;

        [NativeTypeName("#define XK_AccessX_Enable 0xfe70")]
        public const int XK_AccessX_Enable = 0xfe70;

        [NativeTypeName("#define XK_AccessX_Feedback_Enable 0xfe71")]
        public const int XK_AccessX_Feedback_Enable = 0xfe71;

        [NativeTypeName("#define XK_RepeatKeys_Enable 0xfe72")]
        public const int XK_RepeatKeys_Enable = 0xfe72;

        [NativeTypeName("#define XK_SlowKeys_Enable 0xfe73")]
        public const int XK_SlowKeys_Enable = 0xfe73;

        [NativeTypeName("#define XK_BounceKeys_Enable 0xfe74")]
        public const int XK_BounceKeys_Enable = 0xfe74;

        [NativeTypeName("#define XK_StickyKeys_Enable 0xfe75")]
        public const int XK_StickyKeys_Enable = 0xfe75;

        [NativeTypeName("#define XK_MouseKeys_Enable 0xfe76")]
        public const int XK_MouseKeys_Enable = 0xfe76;

        [NativeTypeName("#define XK_MouseKeys_Accel_Enable 0xfe77")]
        public const int XK_MouseKeys_Accel_Enable = 0xfe77;

        [NativeTypeName("#define XK_Overlay1_Enable 0xfe78")]
        public const int XK_Overlay1_Enable = 0xfe78;

        [NativeTypeName("#define XK_Overlay2_Enable 0xfe79")]
        public const int XK_Overlay2_Enable = 0xfe79;

        [NativeTypeName("#define XK_AudibleBell_Enable 0xfe7a")]
        public const int XK_AudibleBell_Enable = 0xfe7a;

        [NativeTypeName("#define XK_Pointer_Left 0xfee0")]
        public const int XK_Pointer_Left = 0xfee0;

        [NativeTypeName("#define XK_Pointer_Right 0xfee1")]
        public const int XK_Pointer_Right = 0xfee1;

        [NativeTypeName("#define XK_Pointer_Up 0xfee2")]
        public const int XK_Pointer_Up = 0xfee2;

        [NativeTypeName("#define XK_Pointer_Down 0xfee3")]
        public const int XK_Pointer_Down = 0xfee3;

        [NativeTypeName("#define XK_Pointer_UpLeft 0xfee4")]
        public const int XK_Pointer_UpLeft = 0xfee4;

        [NativeTypeName("#define XK_Pointer_UpRight 0xfee5")]
        public const int XK_Pointer_UpRight = 0xfee5;

        [NativeTypeName("#define XK_Pointer_DownLeft 0xfee6")]
        public const int XK_Pointer_DownLeft = 0xfee6;

        [NativeTypeName("#define XK_Pointer_DownRight 0xfee7")]
        public const int XK_Pointer_DownRight = 0xfee7;

        [NativeTypeName("#define XK_Pointer_Button_Dflt 0xfee8")]
        public const int XK_Pointer_Button_Dflt = 0xfee8;

        [NativeTypeName("#define XK_Pointer_Button1 0xfee9")]
        public const int XK_Pointer_Button1 = 0xfee9;

        [NativeTypeName("#define XK_Pointer_Button2 0xfeea")]
        public const int XK_Pointer_Button2 = 0xfeea;

        [NativeTypeName("#define XK_Pointer_Button3 0xfeeb")]
        public const int XK_Pointer_Button3 = 0xfeeb;

        [NativeTypeName("#define XK_Pointer_Button4 0xfeec")]
        public const int XK_Pointer_Button4 = 0xfeec;

        [NativeTypeName("#define XK_Pointer_Button5 0xfeed")]
        public const int XK_Pointer_Button5 = 0xfeed;

        [NativeTypeName("#define XK_Pointer_DblClick_Dflt 0xfeee")]
        public const int XK_Pointer_DblClick_Dflt = 0xfeee;

        [NativeTypeName("#define XK_Pointer_DblClick1 0xfeef")]
        public const int XK_Pointer_DblClick1 = 0xfeef;

        [NativeTypeName("#define XK_Pointer_DblClick2 0xfef0")]
        public const int XK_Pointer_DblClick2 = 0xfef0;

        [NativeTypeName("#define XK_Pointer_DblClick3 0xfef1")]
        public const int XK_Pointer_DblClick3 = 0xfef1;

        [NativeTypeName("#define XK_Pointer_DblClick4 0xfef2")]
        public const int XK_Pointer_DblClick4 = 0xfef2;

        [NativeTypeName("#define XK_Pointer_DblClick5 0xfef3")]
        public const int XK_Pointer_DblClick5 = 0xfef3;

        [NativeTypeName("#define XK_Pointer_Drag_Dflt 0xfef4")]
        public const int XK_Pointer_Drag_Dflt = 0xfef4;

        [NativeTypeName("#define XK_Pointer_Drag1 0xfef5")]
        public const int XK_Pointer_Drag1 = 0xfef5;

        [NativeTypeName("#define XK_Pointer_Drag2 0xfef6")]
        public const int XK_Pointer_Drag2 = 0xfef6;

        [NativeTypeName("#define XK_Pointer_Drag3 0xfef7")]
        public const int XK_Pointer_Drag3 = 0xfef7;

        [NativeTypeName("#define XK_Pointer_Drag4 0xfef8")]
        public const int XK_Pointer_Drag4 = 0xfef8;

        [NativeTypeName("#define XK_Pointer_Drag5 0xfefd")]
        public const int XK_Pointer_Drag5 = 0xfefd;

        [NativeTypeName("#define XK_Pointer_EnableKeys 0xfef9")]
        public const int XK_Pointer_EnableKeys = 0xfef9;

        [NativeTypeName("#define XK_Pointer_Accelerate 0xfefa")]
        public const int XK_Pointer_Accelerate = 0xfefa;

        [NativeTypeName("#define XK_Pointer_DfltBtnNext 0xfefb")]
        public const int XK_Pointer_DfltBtnNext = 0xfefb;

        [NativeTypeName("#define XK_Pointer_DfltBtnPrev 0xfefc")]
        public const int XK_Pointer_DfltBtnPrev = 0xfefc;

        [NativeTypeName("#define XK_ch 0xfea0")]
        public const int XK_ch = 0xfea0;

        [NativeTypeName("#define XK_Ch 0xfea1")]
        public const int XK_Ch = 0xfea1;

        [NativeTypeName("#define XK_CH 0xfea2")]
        public const int XK_CH = 0xfea2;

        [NativeTypeName("#define XK_c_h 0xfea3")]
        public const int XK_c_h = 0xfea3;

        [NativeTypeName("#define XK_C_h 0xfea4")]
        public const int XK_C_h = 0xfea4;

        [NativeTypeName("#define XK_C_H 0xfea5")]
        public const int XK_C_H = 0xfea5;

        [NativeTypeName("#define XK_3270_Duplicate 0xfd01")]
        public const int XK_3270_Duplicate = 0xfd01;

        [NativeTypeName("#define XK_3270_FieldMark 0xfd02")]
        public const int XK_3270_FieldMark = 0xfd02;

        [NativeTypeName("#define XK_3270_Right2 0xfd03")]
        public const int XK_3270_Right2 = 0xfd03;

        [NativeTypeName("#define XK_3270_Left2 0xfd04")]
        public const int XK_3270_Left2 = 0xfd04;

        [NativeTypeName("#define XK_3270_BackTab 0xfd05")]
        public const int XK_3270_BackTab = 0xfd05;

        [NativeTypeName("#define XK_3270_EraseEOF 0xfd06")]
        public const int XK_3270_EraseEOF = 0xfd06;

        [NativeTypeName("#define XK_3270_EraseInput 0xfd07")]
        public const int XK_3270_EraseInput = 0xfd07;

        [NativeTypeName("#define XK_3270_Reset 0xfd08")]
        public const int XK_3270_Reset = 0xfd08;

        [NativeTypeName("#define XK_3270_Quit 0xfd09")]
        public const int XK_3270_Quit = 0xfd09;

        [NativeTypeName("#define XK_3270_PA1 0xfd0a")]
        public const int XK_3270_PA1 = 0xfd0a;

        [NativeTypeName("#define XK_3270_PA2 0xfd0b")]
        public const int XK_3270_PA2 = 0xfd0b;

        [NativeTypeName("#define XK_3270_PA3 0xfd0c")]
        public const int XK_3270_PA3 = 0xfd0c;

        [NativeTypeName("#define XK_3270_Test 0xfd0d")]
        public const int XK_3270_Test = 0xfd0d;

        [NativeTypeName("#define XK_3270_Attn 0xfd0e")]
        public const int XK_3270_Attn = 0xfd0e;

        [NativeTypeName("#define XK_3270_CursorBlink 0xfd0f")]
        public const int XK_3270_CursorBlink = 0xfd0f;

        [NativeTypeName("#define XK_3270_AltCursor 0xfd10")]
        public const int XK_3270_AltCursor = 0xfd10;

        [NativeTypeName("#define XK_3270_KeyClick 0xfd11")]
        public const int XK_3270_KeyClick = 0xfd11;

        [NativeTypeName("#define XK_3270_Jump 0xfd12")]
        public const int XK_3270_Jump = 0xfd12;

        [NativeTypeName("#define XK_3270_Ident 0xfd13")]
        public const int XK_3270_Ident = 0xfd13;

        [NativeTypeName("#define XK_3270_Rule 0xfd14")]
        public const int XK_3270_Rule = 0xfd14;

        [NativeTypeName("#define XK_3270_Copy 0xfd15")]
        public const int XK_3270_Copy = 0xfd15;

        [NativeTypeName("#define XK_3270_Play 0xfd16")]
        public const int XK_3270_Play = 0xfd16;

        [NativeTypeName("#define XK_3270_Setup 0xfd17")]
        public const int XK_3270_Setup = 0xfd17;

        [NativeTypeName("#define XK_3270_Record 0xfd18")]
        public const int XK_3270_Record = 0xfd18;

        [NativeTypeName("#define XK_3270_ChangeScreen 0xfd19")]
        public const int XK_3270_ChangeScreen = 0xfd19;

        [NativeTypeName("#define XK_3270_DeleteWord 0xfd1a")]
        public const int XK_3270_DeleteWord = 0xfd1a;

        [NativeTypeName("#define XK_3270_ExSelect 0xfd1b")]
        public const int XK_3270_ExSelect = 0xfd1b;

        [NativeTypeName("#define XK_3270_CursorSelect 0xfd1c")]
        public const int XK_3270_CursorSelect = 0xfd1c;

        [NativeTypeName("#define XK_3270_PrintScreen 0xfd1d")]
        public const int XK_3270_PrintScreen = 0xfd1d;

        [NativeTypeName("#define XK_3270_Enter 0xfd1e")]
        public const int XK_3270_Enter = 0xfd1e;

        [NativeTypeName("#define XK_space 0x0020")]
        public const int XK_space = 0x0020;

        [NativeTypeName("#define XK_exclam 0x0021")]
        public const int XK_exclam = 0x0021;

        [NativeTypeName("#define XK_quotedbl 0x0022")]
        public const int XK_quotedbl = 0x0022;

        [NativeTypeName("#define XK_numbersign 0x0023")]
        public const int XK_numbersign = 0x0023;

        [NativeTypeName("#define XK_dollar 0x0024")]
        public const int XK_dollar = 0x0024;

        [NativeTypeName("#define XK_percent 0x0025")]
        public const int XK_percent = 0x0025;

        [NativeTypeName("#define XK_ampersand 0x0026")]
        public const int XK_ampersand = 0x0026;

        [NativeTypeName("#define XK_apostrophe 0x0027")]
        public const int XK_apostrophe = 0x0027;

        [NativeTypeName("#define XK_quoteright 0x0027")]
        public const int XK_quoteright = 0x0027;

        [NativeTypeName("#define XK_parenleft 0x0028")]
        public const int XK_parenleft = 0x0028;

        [NativeTypeName("#define XK_parenright 0x0029")]
        public const int XK_parenright = 0x0029;

        [NativeTypeName("#define XK_asterisk 0x002a")]
        public const int XK_asterisk = 0x002a;

        [NativeTypeName("#define XK_plus 0x002b")]
        public const int XK_plus = 0x002b;

        [NativeTypeName("#define XK_comma 0x002c")]
        public const int XK_comma = 0x002c;

        [NativeTypeName("#define XK_minus 0x002d")]
        public const int XK_minus = 0x002d;

        [NativeTypeName("#define XK_period 0x002e")]
        public const int XK_period = 0x002e;

        [NativeTypeName("#define XK_slash 0x002f")]
        public const int XK_slash = 0x002f;

        [NativeTypeName("#define XK_0 0x0030")]
        public const int XK_0 = 0x0030;

        [NativeTypeName("#define XK_1 0x0031")]
        public const int XK_1 = 0x0031;

        [NativeTypeName("#define XK_2 0x0032")]
        public const int XK_2 = 0x0032;

        [NativeTypeName("#define XK_3 0x0033")]
        public const int XK_3 = 0x0033;

        [NativeTypeName("#define XK_4 0x0034")]
        public const int XK_4 = 0x0034;

        [NativeTypeName("#define XK_5 0x0035")]
        public const int XK_5 = 0x0035;

        [NativeTypeName("#define XK_6 0x0036")]
        public const int XK_6 = 0x0036;

        [NativeTypeName("#define XK_7 0x0037")]
        public const int XK_7 = 0x0037;

        [NativeTypeName("#define XK_8 0x0038")]
        public const int XK_8 = 0x0038;

        [NativeTypeName("#define XK_9 0x0039")]
        public const int XK_9 = 0x0039;

        [NativeTypeName("#define XK_colon 0x003a")]
        public const int XK_colon = 0x003a;

        [NativeTypeName("#define XK_semicolon 0x003b")]
        public const int XK_semicolon = 0x003b;

        [NativeTypeName("#define XK_less 0x003c")]
        public const int XK_less = 0x003c;

        [NativeTypeName("#define XK_equal 0x003d")]
        public const int XK_equal = 0x003d;

        [NativeTypeName("#define XK_greater 0x003e")]
        public const int XK_greater = 0x003e;

        [NativeTypeName("#define XK_question 0x003f")]
        public const int XK_question = 0x003f;

        [NativeTypeName("#define XK_at 0x0040")]
        public const int XK_at = 0x0040;

        [NativeTypeName("#define XK_A 0x0041")]
        public const int XK_A = 0x0041;

        [NativeTypeName("#define XK_B 0x0042")]
        public const int XK_B = 0x0042;

        [NativeTypeName("#define XK_C 0x0043")]
        public const int XK_C = 0x0043;

        [NativeTypeName("#define XK_D 0x0044")]
        public const int XK_D = 0x0044;

        [NativeTypeName("#define XK_E 0x0045")]
        public const int XK_E = 0x0045;

        [NativeTypeName("#define XK_F 0x0046")]
        public const int XK_F = 0x0046;

        [NativeTypeName("#define XK_G 0x0047")]
        public const int XK_G = 0x0047;

        [NativeTypeName("#define XK_H 0x0048")]
        public const int XK_H = 0x0048;

        [NativeTypeName("#define XK_I 0x0049")]
        public const int XK_I = 0x0049;

        [NativeTypeName("#define XK_J 0x004a")]
        public const int XK_J = 0x004a;

        [NativeTypeName("#define XK_K 0x004b")]
        public const int XK_K = 0x004b;

        [NativeTypeName("#define XK_L 0x004c")]
        public const int XK_L = 0x004c;

        [NativeTypeName("#define XK_M 0x004d")]
        public const int XK_M = 0x004d;

        [NativeTypeName("#define XK_N 0x004e")]
        public const int XK_N = 0x004e;

        [NativeTypeName("#define XK_O 0x004f")]
        public const int XK_O = 0x004f;

        [NativeTypeName("#define XK_P 0x0050")]
        public const int XK_P = 0x0050;

        [NativeTypeName("#define XK_Q 0x0051")]
        public const int XK_Q = 0x0051;

        [NativeTypeName("#define XK_R 0x0052")]
        public const int XK_R = 0x0052;

        [NativeTypeName("#define XK_S 0x0053")]
        public const int XK_S = 0x0053;

        [NativeTypeName("#define XK_T 0x0054")]
        public const int XK_T = 0x0054;

        [NativeTypeName("#define XK_U 0x0055")]
        public const int XK_U = 0x0055;

        [NativeTypeName("#define XK_V 0x0056")]
        public const int XK_V = 0x0056;

        [NativeTypeName("#define XK_W 0x0057")]
        public const int XK_W = 0x0057;

        [NativeTypeName("#define XK_X 0x0058")]
        public const int XK_X = 0x0058;

        [NativeTypeName("#define XK_Y 0x0059")]
        public const int XK_Y = 0x0059;

        [NativeTypeName("#define XK_Z 0x005a")]
        public const int XK_Z = 0x005a;

        [NativeTypeName("#define XK_bracketleft 0x005b")]
        public const int XK_bracketleft = 0x005b;

        [NativeTypeName("#define XK_backslash 0x005c")]
        public const int XK_backslash = 0x005c;

        [NativeTypeName("#define XK_bracketright 0x005d")]
        public const int XK_bracketright = 0x005d;

        [NativeTypeName("#define XK_asciicircum 0x005e")]
        public const int XK_asciicircum = 0x005e;

        [NativeTypeName("#define XK_underscore 0x005f")]
        public const int XK_underscore = 0x005f;

        [NativeTypeName("#define XK_grave 0x0060")]
        public const int XK_grave = 0x0060;

        [NativeTypeName("#define XK_quoteleft 0x0060")]
        public const int XK_quoteleft = 0x0060;

        [NativeTypeName("#define XK_a 0x0061")]
        public const int XK_a = 0x0061;

        [NativeTypeName("#define XK_b 0x0062")]
        public const int XK_b = 0x0062;

        [NativeTypeName("#define XK_c 0x0063")]
        public const int XK_c = 0x0063;

        [NativeTypeName("#define XK_d 0x0064")]
        public const int XK_d = 0x0064;

        [NativeTypeName("#define XK_e 0x0065")]
        public const int XK_e = 0x0065;

        [NativeTypeName("#define XK_f 0x0066")]
        public const int XK_f = 0x0066;

        [NativeTypeName("#define XK_g 0x0067")]
        public const int XK_g = 0x0067;

        [NativeTypeName("#define XK_h 0x0068")]
        public const int XK_h = 0x0068;

        [NativeTypeName("#define XK_i 0x0069")]
        public const int XK_i = 0x0069;

        [NativeTypeName("#define XK_j 0x006a")]
        public const int XK_j = 0x006a;

        [NativeTypeName("#define XK_k 0x006b")]
        public const int XK_k = 0x006b;

        [NativeTypeName("#define XK_l 0x006c")]
        public const int XK_l = 0x006c;

        [NativeTypeName("#define XK_m 0x006d")]
        public const int XK_m = 0x006d;

        [NativeTypeName("#define XK_n 0x006e")]
        public const int XK_n = 0x006e;

        [NativeTypeName("#define XK_o 0x006f")]
        public const int XK_o = 0x006f;

        [NativeTypeName("#define XK_p 0x0070")]
        public const int XK_p = 0x0070;

        [NativeTypeName("#define XK_q 0x0071")]
        public const int XK_q = 0x0071;

        [NativeTypeName("#define XK_r 0x0072")]
        public const int XK_r = 0x0072;

        [NativeTypeName("#define XK_s 0x0073")]
        public const int XK_s = 0x0073;

        [NativeTypeName("#define XK_t 0x0074")]
        public const int XK_t = 0x0074;

        [NativeTypeName("#define XK_u 0x0075")]
        public const int XK_u = 0x0075;

        [NativeTypeName("#define XK_v 0x0076")]
        public const int XK_v = 0x0076;

        [NativeTypeName("#define XK_w 0x0077")]
        public const int XK_w = 0x0077;

        [NativeTypeName("#define XK_x 0x0078")]
        public const int XK_x = 0x0078;

        [NativeTypeName("#define XK_y 0x0079")]
        public const int XK_y = 0x0079;

        [NativeTypeName("#define XK_z 0x007a")]
        public const int XK_z = 0x007a;

        [NativeTypeName("#define XK_braceleft 0x007b")]
        public const int XK_braceleft = 0x007b;

        [NativeTypeName("#define XK_bar 0x007c")]
        public const int XK_bar = 0x007c;

        [NativeTypeName("#define XK_braceright 0x007d")]
        public const int XK_braceright = 0x007d;

        [NativeTypeName("#define XK_asciitilde 0x007e")]
        public const int XK_asciitilde = 0x007e;

        [NativeTypeName("#define XK_nobreakspace 0x00a0")]
        public const int XK_nobreakspace = 0x00a0;

        [NativeTypeName("#define XK_exclamdown 0x00a1")]
        public const int XK_exclamdown = 0x00a1;

        [NativeTypeName("#define XK_cent 0x00a2")]
        public const int XK_cent = 0x00a2;

        [NativeTypeName("#define XK_sterling 0x00a3")]
        public const int XK_sterling = 0x00a3;

        [NativeTypeName("#define XK_currency 0x00a4")]
        public const int XK_currency = 0x00a4;

        [NativeTypeName("#define XK_yen 0x00a5")]
        public const int XK_yen = 0x00a5;

        [NativeTypeName("#define XK_brokenbar 0x00a6")]
        public const int XK_brokenbar = 0x00a6;

        [NativeTypeName("#define XK_section 0x00a7")]
        public const int XK_section = 0x00a7;

        [NativeTypeName("#define XK_diaeresis 0x00a8")]
        public const int XK_diaeresis = 0x00a8;

        [NativeTypeName("#define XK_copyright 0x00a9")]
        public const int XK_copyright = 0x00a9;

        [NativeTypeName("#define XK_ordfeminine 0x00aa")]
        public const int XK_ordfeminine = 0x00aa;

        [NativeTypeName("#define XK_guillemotleft 0x00ab")]
        public const int XK_guillemotleft = 0x00ab;

        [NativeTypeName("#define XK_notsign 0x00ac")]
        public const int XK_notsign = 0x00ac;

        [NativeTypeName("#define XK_hyphen 0x00ad")]
        public const int XK_hyphen = 0x00ad;

        [NativeTypeName("#define XK_registered 0x00ae")]
        public const int XK_registered = 0x00ae;

        [NativeTypeName("#define XK_macron 0x00af")]
        public const int XK_macron = 0x00af;

        [NativeTypeName("#define XK_degree 0x00b0")]
        public const int XK_degree = 0x00b0;

        [NativeTypeName("#define XK_plusminus 0x00b1")]
        public const int XK_plusminus = 0x00b1;

        [NativeTypeName("#define XK_twosuperior 0x00b2")]
        public const int XK_twosuperior = 0x00b2;

        [NativeTypeName("#define XK_threesuperior 0x00b3")]
        public const int XK_threesuperior = 0x00b3;

        [NativeTypeName("#define XK_acute 0x00b4")]
        public const int XK_acute = 0x00b4;

        [NativeTypeName("#define XK_mu 0x00b5")]
        public const int XK_mu = 0x00b5;

        [NativeTypeName("#define XK_paragraph 0x00b6")]
        public const int XK_paragraph = 0x00b6;

        [NativeTypeName("#define XK_periodcentered 0x00b7")]
        public const int XK_periodcentered = 0x00b7;

        [NativeTypeName("#define XK_cedilla 0x00b8")]
        public const int XK_cedilla = 0x00b8;

        [NativeTypeName("#define XK_onesuperior 0x00b9")]
        public const int XK_onesuperior = 0x00b9;

        [NativeTypeName("#define XK_masculine 0x00ba")]
        public const int XK_masculine = 0x00ba;

        [NativeTypeName("#define XK_guillemotright 0x00bb")]
        public const int XK_guillemotright = 0x00bb;

        [NativeTypeName("#define XK_onequarter 0x00bc")]
        public const int XK_onequarter = 0x00bc;

        [NativeTypeName("#define XK_onehalf 0x00bd")]
        public const int XK_onehalf = 0x00bd;

        [NativeTypeName("#define XK_threequarters 0x00be")]
        public const int XK_threequarters = 0x00be;

        [NativeTypeName("#define XK_questiondown 0x00bf")]
        public const int XK_questiondown = 0x00bf;

        [NativeTypeName("#define XK_Agrave 0x00c0")]
        public const int XK_Agrave = 0x00c0;

        [NativeTypeName("#define XK_Aacute 0x00c1")]
        public const int XK_Aacute = 0x00c1;

        [NativeTypeName("#define XK_Acircumflex 0x00c2")]
        public const int XK_Acircumflex = 0x00c2;

        [NativeTypeName("#define XK_Atilde 0x00c3")]
        public const int XK_Atilde = 0x00c3;

        [NativeTypeName("#define XK_Adiaeresis 0x00c4")]
        public const int XK_Adiaeresis = 0x00c4;

        [NativeTypeName("#define XK_Aring 0x00c5")]
        public const int XK_Aring = 0x00c5;

        [NativeTypeName("#define XK_AE 0x00c6")]
        public const int XK_AE = 0x00c6;

        [NativeTypeName("#define XK_Ccedilla 0x00c7")]
        public const int XK_Ccedilla = 0x00c7;

        [NativeTypeName("#define XK_Egrave 0x00c8")]
        public const int XK_Egrave = 0x00c8;

        [NativeTypeName("#define XK_Eacute 0x00c9")]
        public const int XK_Eacute = 0x00c9;

        [NativeTypeName("#define XK_Ecircumflex 0x00ca")]
        public const int XK_Ecircumflex = 0x00ca;

        [NativeTypeName("#define XK_Ediaeresis 0x00cb")]
        public const int XK_Ediaeresis = 0x00cb;

        [NativeTypeName("#define XK_Igrave 0x00cc")]
        public const int XK_Igrave = 0x00cc;

        [NativeTypeName("#define XK_Iacute 0x00cd")]
        public const int XK_Iacute = 0x00cd;

        [NativeTypeName("#define XK_Icircumflex 0x00ce")]
        public const int XK_Icircumflex = 0x00ce;

        [NativeTypeName("#define XK_Idiaeresis 0x00cf")]
        public const int XK_Idiaeresis = 0x00cf;

        [NativeTypeName("#define XK_ETH 0x00d0")]
        public const int XK_ETH = 0x00d0;

        [NativeTypeName("#define XK_Eth 0x00d0")]
        public const int XK_Eth = 0x00d0;

        [NativeTypeName("#define XK_Ntilde 0x00d1")]
        public const int XK_Ntilde = 0x00d1;

        [NativeTypeName("#define XK_Ograve 0x00d2")]
        public const int XK_Ograve = 0x00d2;

        [NativeTypeName("#define XK_Oacute 0x00d3")]
        public const int XK_Oacute = 0x00d3;

        [NativeTypeName("#define XK_Ocircumflex 0x00d4")]
        public const int XK_Ocircumflex = 0x00d4;

        [NativeTypeName("#define XK_Otilde 0x00d5")]
        public const int XK_Otilde = 0x00d5;

        [NativeTypeName("#define XK_Odiaeresis 0x00d6")]
        public const int XK_Odiaeresis = 0x00d6;

        [NativeTypeName("#define XK_multiply 0x00d7")]
        public const int XK_multiply = 0x00d7;

        [NativeTypeName("#define XK_Oslash 0x00d8")]
        public const int XK_Oslash = 0x00d8;

        [NativeTypeName("#define XK_Ooblique 0x00d8")]
        public const int XK_Ooblique = 0x00d8;

        [NativeTypeName("#define XK_Ugrave 0x00d9")]
        public const int XK_Ugrave = 0x00d9;

        [NativeTypeName("#define XK_Uacute 0x00da")]
        public const int XK_Uacute = 0x00da;

        [NativeTypeName("#define XK_Ucircumflex 0x00db")]
        public const int XK_Ucircumflex = 0x00db;

        [NativeTypeName("#define XK_Udiaeresis 0x00dc")]
        public const int XK_Udiaeresis = 0x00dc;

        [NativeTypeName("#define XK_Yacute 0x00dd")]
        public const int XK_Yacute = 0x00dd;

        [NativeTypeName("#define XK_THORN 0x00de")]
        public const int XK_THORN = 0x00de;

        [NativeTypeName("#define XK_Thorn 0x00de")]
        public const int XK_Thorn = 0x00de;

        [NativeTypeName("#define XK_ssharp 0x00df")]
        public const int XK_ssharp = 0x00df;

        [NativeTypeName("#define XK_agrave 0x00e0")]
        public const int XK_agrave = 0x00e0;

        [NativeTypeName("#define XK_aacute 0x00e1")]
        public const int XK_aacute = 0x00e1;

        [NativeTypeName("#define XK_acircumflex 0x00e2")]
        public const int XK_acircumflex = 0x00e2;

        [NativeTypeName("#define XK_atilde 0x00e3")]
        public const int XK_atilde = 0x00e3;

        [NativeTypeName("#define XK_adiaeresis 0x00e4")]
        public const int XK_adiaeresis = 0x00e4;

        [NativeTypeName("#define XK_aring 0x00e5")]
        public const int XK_aring = 0x00e5;

        [NativeTypeName("#define XK_ae 0x00e6")]
        public const int XK_ae = 0x00e6;

        [NativeTypeName("#define XK_ccedilla 0x00e7")]
        public const int XK_ccedilla = 0x00e7;

        [NativeTypeName("#define XK_egrave 0x00e8")]
        public const int XK_egrave = 0x00e8;

        [NativeTypeName("#define XK_eacute 0x00e9")]
        public const int XK_eacute = 0x00e9;

        [NativeTypeName("#define XK_ecircumflex 0x00ea")]
        public const int XK_ecircumflex = 0x00ea;

        [NativeTypeName("#define XK_ediaeresis 0x00eb")]
        public const int XK_ediaeresis = 0x00eb;

        [NativeTypeName("#define XK_igrave 0x00ec")]
        public const int XK_igrave = 0x00ec;

        [NativeTypeName("#define XK_iacute 0x00ed")]
        public const int XK_iacute = 0x00ed;

        [NativeTypeName("#define XK_icircumflex 0x00ee")]
        public const int XK_icircumflex = 0x00ee;

        [NativeTypeName("#define XK_idiaeresis 0x00ef")]
        public const int XK_idiaeresis = 0x00ef;

        [NativeTypeName("#define XK_eth 0x00f0")]
        public const int XK_eth = 0x00f0;

        [NativeTypeName("#define XK_ntilde 0x00f1")]
        public const int XK_ntilde = 0x00f1;

        [NativeTypeName("#define XK_ograve 0x00f2")]
        public const int XK_ograve = 0x00f2;

        [NativeTypeName("#define XK_oacute 0x00f3")]
        public const int XK_oacute = 0x00f3;

        [NativeTypeName("#define XK_ocircumflex 0x00f4")]
        public const int XK_ocircumflex = 0x00f4;

        [NativeTypeName("#define XK_otilde 0x00f5")]
        public const int XK_otilde = 0x00f5;

        [NativeTypeName("#define XK_odiaeresis 0x00f6")]
        public const int XK_odiaeresis = 0x00f6;

        [NativeTypeName("#define XK_division 0x00f7")]
        public const int XK_division = 0x00f7;

        [NativeTypeName("#define XK_oslash 0x00f8")]
        public const int XK_oslash = 0x00f8;

        [NativeTypeName("#define XK_ooblique 0x00f8")]
        public const int XK_ooblique = 0x00f8;

        [NativeTypeName("#define XK_ugrave 0x00f9")]
        public const int XK_ugrave = 0x00f9;

        [NativeTypeName("#define XK_uacute 0x00fa")]
        public const int XK_uacute = 0x00fa;

        [NativeTypeName("#define XK_ucircumflex 0x00fb")]
        public const int XK_ucircumflex = 0x00fb;

        [NativeTypeName("#define XK_udiaeresis 0x00fc")]
        public const int XK_udiaeresis = 0x00fc;

        [NativeTypeName("#define XK_yacute 0x00fd")]
        public const int XK_yacute = 0x00fd;

        [NativeTypeName("#define XK_thorn 0x00fe")]
        public const int XK_thorn = 0x00fe;

        [NativeTypeName("#define XK_ydiaeresis 0x00ff")]
        public const int XK_ydiaeresis = 0x00ff;

        [NativeTypeName("#define XK_Aogonek 0x01a1")]
        public const int XK_Aogonek = 0x01a1;

        [NativeTypeName("#define XK_breve 0x01a2")]
        public const int XK_breve = 0x01a2;

        [NativeTypeName("#define XK_Lstroke 0x01a3")]
        public const int XK_Lstroke = 0x01a3;

        [NativeTypeName("#define XK_Lcaron 0x01a5")]
        public const int XK_Lcaron = 0x01a5;

        [NativeTypeName("#define XK_Sacute 0x01a6")]
        public const int XK_Sacute = 0x01a6;

        [NativeTypeName("#define XK_Scaron 0x01a9")]
        public const int XK_Scaron = 0x01a9;

        [NativeTypeName("#define XK_Scedilla 0x01aa")]
        public const int XK_Scedilla = 0x01aa;

        [NativeTypeName("#define XK_Tcaron 0x01ab")]
        public const int XK_Tcaron = 0x01ab;

        [NativeTypeName("#define XK_Zacute 0x01ac")]
        public const int XK_Zacute = 0x01ac;

        [NativeTypeName("#define XK_Zcaron 0x01ae")]
        public const int XK_Zcaron = 0x01ae;

        [NativeTypeName("#define XK_Zabovedot 0x01af")]
        public const int XK_Zabovedot = 0x01af;

        [NativeTypeName("#define XK_aogonek 0x01b1")]
        public const int XK_aogonek = 0x01b1;

        [NativeTypeName("#define XK_ogonek 0x01b2")]
        public const int XK_ogonek = 0x01b2;

        [NativeTypeName("#define XK_lstroke 0x01b3")]
        public const int XK_lstroke = 0x01b3;

        [NativeTypeName("#define XK_lcaron 0x01b5")]
        public const int XK_lcaron = 0x01b5;

        [NativeTypeName("#define XK_sacute 0x01b6")]
        public const int XK_sacute = 0x01b6;

        [NativeTypeName("#define XK_caron 0x01b7")]
        public const int XK_caron = 0x01b7;

        [NativeTypeName("#define XK_scaron 0x01b9")]
        public const int XK_scaron = 0x01b9;

        [NativeTypeName("#define XK_scedilla 0x01ba")]
        public const int XK_scedilla = 0x01ba;

        [NativeTypeName("#define XK_tcaron 0x01bb")]
        public const int XK_tcaron = 0x01bb;

        [NativeTypeName("#define XK_zacute 0x01bc")]
        public const int XK_zacute = 0x01bc;

        [NativeTypeName("#define XK_doubleacute 0x01bd")]
        public const int XK_doubleacute = 0x01bd;

        [NativeTypeName("#define XK_zcaron 0x01be")]
        public const int XK_zcaron = 0x01be;

        [NativeTypeName("#define XK_zabovedot 0x01bf")]
        public const int XK_zabovedot = 0x01bf;

        [NativeTypeName("#define XK_Racute 0x01c0")]
        public const int XK_Racute = 0x01c0;

        [NativeTypeName("#define XK_Abreve 0x01c3")]
        public const int XK_Abreve = 0x01c3;

        [NativeTypeName("#define XK_Lacute 0x01c5")]
        public const int XK_Lacute = 0x01c5;

        [NativeTypeName("#define XK_Cacute 0x01c6")]
        public const int XK_Cacute = 0x01c6;

        [NativeTypeName("#define XK_Ccaron 0x01c8")]
        public const int XK_Ccaron = 0x01c8;

        [NativeTypeName("#define XK_Eogonek 0x01ca")]
        public const int XK_Eogonek = 0x01ca;

        [NativeTypeName("#define XK_Ecaron 0x01cc")]
        public const int XK_Ecaron = 0x01cc;

        [NativeTypeName("#define XK_Dcaron 0x01cf")]
        public const int XK_Dcaron = 0x01cf;

        [NativeTypeName("#define XK_Dstroke 0x01d0")]
        public const int XK_Dstroke = 0x01d0;

        [NativeTypeName("#define XK_Nacute 0x01d1")]
        public const int XK_Nacute = 0x01d1;

        [NativeTypeName("#define XK_Ncaron 0x01d2")]
        public const int XK_Ncaron = 0x01d2;

        [NativeTypeName("#define XK_Odoubleacute 0x01d5")]
        public const int XK_Odoubleacute = 0x01d5;

        [NativeTypeName("#define XK_Rcaron 0x01d8")]
        public const int XK_Rcaron = 0x01d8;

        [NativeTypeName("#define XK_Uring 0x01d9")]
        public const int XK_Uring = 0x01d9;

        [NativeTypeName("#define XK_Udoubleacute 0x01db")]
        public const int XK_Udoubleacute = 0x01db;

        [NativeTypeName("#define XK_Tcedilla 0x01de")]
        public const int XK_Tcedilla = 0x01de;

        [NativeTypeName("#define XK_racute 0x01e0")]
        public const int XK_racute = 0x01e0;

        [NativeTypeName("#define XK_abreve 0x01e3")]
        public const int XK_abreve = 0x01e3;

        [NativeTypeName("#define XK_lacute 0x01e5")]
        public const int XK_lacute = 0x01e5;

        [NativeTypeName("#define XK_cacute 0x01e6")]
        public const int XK_cacute = 0x01e6;

        [NativeTypeName("#define XK_ccaron 0x01e8")]
        public const int XK_ccaron = 0x01e8;

        [NativeTypeName("#define XK_eogonek 0x01ea")]
        public const int XK_eogonek = 0x01ea;

        [NativeTypeName("#define XK_ecaron 0x01ec")]
        public const int XK_ecaron = 0x01ec;

        [NativeTypeName("#define XK_dcaron 0x01ef")]
        public const int XK_dcaron = 0x01ef;

        [NativeTypeName("#define XK_dstroke 0x01f0")]
        public const int XK_dstroke = 0x01f0;

        [NativeTypeName("#define XK_nacute 0x01f1")]
        public const int XK_nacute = 0x01f1;

        [NativeTypeName("#define XK_ncaron 0x01f2")]
        public const int XK_ncaron = 0x01f2;

        [NativeTypeName("#define XK_odoubleacute 0x01f5")]
        public const int XK_odoubleacute = 0x01f5;

        [NativeTypeName("#define XK_rcaron 0x01f8")]
        public const int XK_rcaron = 0x01f8;

        [NativeTypeName("#define XK_uring 0x01f9")]
        public const int XK_uring = 0x01f9;

        [NativeTypeName("#define XK_udoubleacute 0x01fb")]
        public const int XK_udoubleacute = 0x01fb;

        [NativeTypeName("#define XK_tcedilla 0x01fe")]
        public const int XK_tcedilla = 0x01fe;

        [NativeTypeName("#define XK_abovedot 0x01ff")]
        public const int XK_abovedot = 0x01ff;

        [NativeTypeName("#define XK_Hstroke 0x02a1")]
        public const int XK_Hstroke = 0x02a1;

        [NativeTypeName("#define XK_Hcircumflex 0x02a6")]
        public const int XK_Hcircumflex = 0x02a6;

        [NativeTypeName("#define XK_Iabovedot 0x02a9")]
        public const int XK_Iabovedot = 0x02a9;

        [NativeTypeName("#define XK_Gbreve 0x02ab")]
        public const int XK_Gbreve = 0x02ab;

        [NativeTypeName("#define XK_Jcircumflex 0x02ac")]
        public const int XK_Jcircumflex = 0x02ac;

        [NativeTypeName("#define XK_hstroke 0x02b1")]
        public const int XK_hstroke = 0x02b1;

        [NativeTypeName("#define XK_hcircumflex 0x02b6")]
        public const int XK_hcircumflex = 0x02b6;

        [NativeTypeName("#define XK_idotless 0x02b9")]
        public const int XK_idotless = 0x02b9;

        [NativeTypeName("#define XK_gbreve 0x02bb")]
        public const int XK_gbreve = 0x02bb;

        [NativeTypeName("#define XK_jcircumflex 0x02bc")]
        public const int XK_jcircumflex = 0x02bc;

        [NativeTypeName("#define XK_Cabovedot 0x02c5")]
        public const int XK_Cabovedot = 0x02c5;

        [NativeTypeName("#define XK_Ccircumflex 0x02c6")]
        public const int XK_Ccircumflex = 0x02c6;

        [NativeTypeName("#define XK_Gabovedot 0x02d5")]
        public const int XK_Gabovedot = 0x02d5;

        [NativeTypeName("#define XK_Gcircumflex 0x02d8")]
        public const int XK_Gcircumflex = 0x02d8;

        [NativeTypeName("#define XK_Ubreve 0x02dd")]
        public const int XK_Ubreve = 0x02dd;

        [NativeTypeName("#define XK_Scircumflex 0x02de")]
        public const int XK_Scircumflex = 0x02de;

        [NativeTypeName("#define XK_cabovedot 0x02e5")]
        public const int XK_cabovedot = 0x02e5;

        [NativeTypeName("#define XK_ccircumflex 0x02e6")]
        public const int XK_ccircumflex = 0x02e6;

        [NativeTypeName("#define XK_gabovedot 0x02f5")]
        public const int XK_gabovedot = 0x02f5;

        [NativeTypeName("#define XK_gcircumflex 0x02f8")]
        public const int XK_gcircumflex = 0x02f8;

        [NativeTypeName("#define XK_ubreve 0x02fd")]
        public const int XK_ubreve = 0x02fd;

        [NativeTypeName("#define XK_scircumflex 0x02fe")]
        public const int XK_scircumflex = 0x02fe;

        [NativeTypeName("#define XK_kra 0x03a2")]
        public const int XK_kra = 0x03a2;

        [NativeTypeName("#define XK_kappa 0x03a2")]
        public const int XK_kappa = 0x03a2;

        [NativeTypeName("#define XK_Rcedilla 0x03a3")]
        public const int XK_Rcedilla = 0x03a3;

        [NativeTypeName("#define XK_Itilde 0x03a5")]
        public const int XK_Itilde = 0x03a5;

        [NativeTypeName("#define XK_Lcedilla 0x03a6")]
        public const int XK_Lcedilla = 0x03a6;

        [NativeTypeName("#define XK_Emacron 0x03aa")]
        public const int XK_Emacron = 0x03aa;

        [NativeTypeName("#define XK_Gcedilla 0x03ab")]
        public const int XK_Gcedilla = 0x03ab;

        [NativeTypeName("#define XK_Tslash 0x03ac")]
        public const int XK_Tslash = 0x03ac;

        [NativeTypeName("#define XK_rcedilla 0x03b3")]
        public const int XK_rcedilla = 0x03b3;

        [NativeTypeName("#define XK_itilde 0x03b5")]
        public const int XK_itilde = 0x03b5;

        [NativeTypeName("#define XK_lcedilla 0x03b6")]
        public const int XK_lcedilla = 0x03b6;

        [NativeTypeName("#define XK_emacron 0x03ba")]
        public const int XK_emacron = 0x03ba;

        [NativeTypeName("#define XK_gcedilla 0x03bb")]
        public const int XK_gcedilla = 0x03bb;

        [NativeTypeName("#define XK_tslash 0x03bc")]
        public const int XK_tslash = 0x03bc;

        [NativeTypeName("#define XK_ENG 0x03bd")]
        public const int XK_ENG = 0x03bd;

        [NativeTypeName("#define XK_eng 0x03bf")]
        public const int XK_eng = 0x03bf;

        [NativeTypeName("#define XK_Amacron 0x03c0")]
        public const int XK_Amacron = 0x03c0;

        [NativeTypeName("#define XK_Iogonek 0x03c7")]
        public const int XK_Iogonek = 0x03c7;

        [NativeTypeName("#define XK_Eabovedot 0x03cc")]
        public const int XK_Eabovedot = 0x03cc;

        [NativeTypeName("#define XK_Imacron 0x03cf")]
        public const int XK_Imacron = 0x03cf;

        [NativeTypeName("#define XK_Ncedilla 0x03d1")]
        public const int XK_Ncedilla = 0x03d1;

        [NativeTypeName("#define XK_Omacron 0x03d2")]
        public const int XK_Omacron = 0x03d2;

        [NativeTypeName("#define XK_Kcedilla 0x03d3")]
        public const int XK_Kcedilla = 0x03d3;

        [NativeTypeName("#define XK_Uogonek 0x03d9")]
        public const int XK_Uogonek = 0x03d9;

        [NativeTypeName("#define XK_Utilde 0x03dd")]
        public const int XK_Utilde = 0x03dd;

        [NativeTypeName("#define XK_Umacron 0x03de")]
        public const int XK_Umacron = 0x03de;

        [NativeTypeName("#define XK_amacron 0x03e0")]
        public const int XK_amacron = 0x03e0;

        [NativeTypeName("#define XK_iogonek 0x03e7")]
        public const int XK_iogonek = 0x03e7;

        [NativeTypeName("#define XK_eabovedot 0x03ec")]
        public const int XK_eabovedot = 0x03ec;

        [NativeTypeName("#define XK_imacron 0x03ef")]
        public const int XK_imacron = 0x03ef;

        [NativeTypeName("#define XK_ncedilla 0x03f1")]
        public const int XK_ncedilla = 0x03f1;

        [NativeTypeName("#define XK_omacron 0x03f2")]
        public const int XK_omacron = 0x03f2;

        [NativeTypeName("#define XK_kcedilla 0x03f3")]
        public const int XK_kcedilla = 0x03f3;

        [NativeTypeName("#define XK_uogonek 0x03f9")]
        public const int XK_uogonek = 0x03f9;

        [NativeTypeName("#define XK_utilde 0x03fd")]
        public const int XK_utilde = 0x03fd;

        [NativeTypeName("#define XK_umacron 0x03fe")]
        public const int XK_umacron = 0x03fe;

        [NativeTypeName("#define XK_Wcircumflex 0x1000174")]
        public const int XK_Wcircumflex = 0x1000174;

        [NativeTypeName("#define XK_wcircumflex 0x1000175")]
        public const int XK_wcircumflex = 0x1000175;

        [NativeTypeName("#define XK_Ycircumflex 0x1000176")]
        public const int XK_Ycircumflex = 0x1000176;

        [NativeTypeName("#define XK_ycircumflex 0x1000177")]
        public const int XK_ycircumflex = 0x1000177;

        [NativeTypeName("#define XK_Babovedot 0x1001e02")]
        public const int XK_Babovedot = 0x1001e02;

        [NativeTypeName("#define XK_babovedot 0x1001e03")]
        public const int XK_babovedot = 0x1001e03;

        [NativeTypeName("#define XK_Dabovedot 0x1001e0a")]
        public const int XK_Dabovedot = 0x1001e0a;

        [NativeTypeName("#define XK_dabovedot 0x1001e0b")]
        public const int XK_dabovedot = 0x1001e0b;

        [NativeTypeName("#define XK_Fabovedot 0x1001e1e")]
        public const int XK_Fabovedot = 0x1001e1e;

        [NativeTypeName("#define XK_fabovedot 0x1001e1f")]
        public const int XK_fabovedot = 0x1001e1f;

        [NativeTypeName("#define XK_Mabovedot 0x1001e40")]
        public const int XK_Mabovedot = 0x1001e40;

        [NativeTypeName("#define XK_mabovedot 0x1001e41")]
        public const int XK_mabovedot = 0x1001e41;

        [NativeTypeName("#define XK_Pabovedot 0x1001e56")]
        public const int XK_Pabovedot = 0x1001e56;

        [NativeTypeName("#define XK_pabovedot 0x1001e57")]
        public const int XK_pabovedot = 0x1001e57;

        [NativeTypeName("#define XK_Sabovedot 0x1001e60")]
        public const int XK_Sabovedot = 0x1001e60;

        [NativeTypeName("#define XK_sabovedot 0x1001e61")]
        public const int XK_sabovedot = 0x1001e61;

        [NativeTypeName("#define XK_Tabovedot 0x1001e6a")]
        public const int XK_Tabovedot = 0x1001e6a;

        [NativeTypeName("#define XK_tabovedot 0x1001e6b")]
        public const int XK_tabovedot = 0x1001e6b;

        [NativeTypeName("#define XK_Wgrave 0x1001e80")]
        public const int XK_Wgrave = 0x1001e80;

        [NativeTypeName("#define XK_wgrave 0x1001e81")]
        public const int XK_wgrave = 0x1001e81;

        [NativeTypeName("#define XK_Wacute 0x1001e82")]
        public const int XK_Wacute = 0x1001e82;

        [NativeTypeName("#define XK_wacute 0x1001e83")]
        public const int XK_wacute = 0x1001e83;

        [NativeTypeName("#define XK_Wdiaeresis 0x1001e84")]
        public const int XK_Wdiaeresis = 0x1001e84;

        [NativeTypeName("#define XK_wdiaeresis 0x1001e85")]
        public const int XK_wdiaeresis = 0x1001e85;

        [NativeTypeName("#define XK_Ygrave 0x1001ef2")]
        public const int XK_Ygrave = 0x1001ef2;

        [NativeTypeName("#define XK_ygrave 0x1001ef3")]
        public const int XK_ygrave = 0x1001ef3;

        [NativeTypeName("#define XK_OE 0x13bc")]
        public const int XK_OE = 0x13bc;

        [NativeTypeName("#define XK_oe 0x13bd")]
        public const int XK_oe = 0x13bd;

        [NativeTypeName("#define XK_Ydiaeresis 0x13be")]
        public const int XK_Ydiaeresis = 0x13be;

        [NativeTypeName("#define XK_overline 0x047e")]
        public const int XK_overline = 0x047e;

        [NativeTypeName("#define XK_kana_fullstop 0x04a1")]
        public const int XK_kana_fullstop = 0x04a1;

        [NativeTypeName("#define XK_kana_openingbracket 0x04a2")]
        public const int XK_kana_openingbracket = 0x04a2;

        [NativeTypeName("#define XK_kana_closingbracket 0x04a3")]
        public const int XK_kana_closingbracket = 0x04a3;

        [NativeTypeName("#define XK_kana_comma 0x04a4")]
        public const int XK_kana_comma = 0x04a4;

        [NativeTypeName("#define XK_kana_conjunctive 0x04a5")]
        public const int XK_kana_conjunctive = 0x04a5;

        [NativeTypeName("#define XK_kana_middledot 0x04a5")]
        public const int XK_kana_middledot = 0x04a5;

        [NativeTypeName("#define XK_kana_WO 0x04a6")]
        public const int XK_kana_WO = 0x04a6;

        [NativeTypeName("#define XK_kana_a 0x04a7")]
        public const int XK_kana_a = 0x04a7;

        [NativeTypeName("#define XK_kana_i 0x04a8")]
        public const int XK_kana_i = 0x04a8;

        [NativeTypeName("#define XK_kana_u 0x04a9")]
        public const int XK_kana_u = 0x04a9;

        [NativeTypeName("#define XK_kana_e 0x04aa")]
        public const int XK_kana_e = 0x04aa;

        [NativeTypeName("#define XK_kana_o 0x04ab")]
        public const int XK_kana_o = 0x04ab;

        [NativeTypeName("#define XK_kana_ya 0x04ac")]
        public const int XK_kana_ya = 0x04ac;

        [NativeTypeName("#define XK_kana_yu 0x04ad")]
        public const int XK_kana_yu = 0x04ad;

        [NativeTypeName("#define XK_kana_yo 0x04ae")]
        public const int XK_kana_yo = 0x04ae;

        [NativeTypeName("#define XK_kana_tsu 0x04af")]
        public const int XK_kana_tsu = 0x04af;

        [NativeTypeName("#define XK_kana_tu 0x04af")]
        public const int XK_kana_tu = 0x04af;

        [NativeTypeName("#define XK_prolongedsound 0x04b0")]
        public const int XK_prolongedsound = 0x04b0;

        [NativeTypeName("#define XK_kana_A 0x04b1")]
        public const int XK_kana_A = 0x04b1;

        [NativeTypeName("#define XK_kana_I 0x04b2")]
        public const int XK_kana_I = 0x04b2;

        [NativeTypeName("#define XK_kana_U 0x04b3")]
        public const int XK_kana_U = 0x04b3;

        [NativeTypeName("#define XK_kana_E 0x04b4")]
        public const int XK_kana_E = 0x04b4;

        [NativeTypeName("#define XK_kana_O 0x04b5")]
        public const int XK_kana_O = 0x04b5;

        [NativeTypeName("#define XK_kana_KA 0x04b6")]
        public const int XK_kana_KA = 0x04b6;

        [NativeTypeName("#define XK_kana_KI 0x04b7")]
        public const int XK_kana_KI = 0x04b7;

        [NativeTypeName("#define XK_kana_KU 0x04b8")]
        public const int XK_kana_KU = 0x04b8;

        [NativeTypeName("#define XK_kana_KE 0x04b9")]
        public const int XK_kana_KE = 0x04b9;

        [NativeTypeName("#define XK_kana_KO 0x04ba")]
        public const int XK_kana_KO = 0x04ba;

        [NativeTypeName("#define XK_kana_SA 0x04bb")]
        public const int XK_kana_SA = 0x04bb;

        [NativeTypeName("#define XK_kana_SHI 0x04bc")]
        public const int XK_kana_SHI = 0x04bc;

        [NativeTypeName("#define XK_kana_SU 0x04bd")]
        public const int XK_kana_SU = 0x04bd;

        [NativeTypeName("#define XK_kana_SE 0x04be")]
        public const int XK_kana_SE = 0x04be;

        [NativeTypeName("#define XK_kana_SO 0x04bf")]
        public const int XK_kana_SO = 0x04bf;

        [NativeTypeName("#define XK_kana_TA 0x04c0")]
        public const int XK_kana_TA = 0x04c0;

        [NativeTypeName("#define XK_kana_CHI 0x04c1")]
        public const int XK_kana_CHI = 0x04c1;

        [NativeTypeName("#define XK_kana_TI 0x04c1")]
        public const int XK_kana_TI = 0x04c1;

        [NativeTypeName("#define XK_kana_TSU 0x04c2")]
        public const int XK_kana_TSU = 0x04c2;

        [NativeTypeName("#define XK_kana_TU 0x04c2")]
        public const int XK_kana_TU = 0x04c2;

        [NativeTypeName("#define XK_kana_TE 0x04c3")]
        public const int XK_kana_TE = 0x04c3;

        [NativeTypeName("#define XK_kana_TO 0x04c4")]
        public const int XK_kana_TO = 0x04c4;

        [NativeTypeName("#define XK_kana_NA 0x04c5")]
        public const int XK_kana_NA = 0x04c5;

        [NativeTypeName("#define XK_kana_NI 0x04c6")]
        public const int XK_kana_NI = 0x04c6;

        [NativeTypeName("#define XK_kana_NU 0x04c7")]
        public const int XK_kana_NU = 0x04c7;

        [NativeTypeName("#define XK_kana_NE 0x04c8")]
        public const int XK_kana_NE = 0x04c8;

        [NativeTypeName("#define XK_kana_NO 0x04c9")]
        public const int XK_kana_NO = 0x04c9;

        [NativeTypeName("#define XK_kana_HA 0x04ca")]
        public const int XK_kana_HA = 0x04ca;

        [NativeTypeName("#define XK_kana_HI 0x04cb")]
        public const int XK_kana_HI = 0x04cb;

        [NativeTypeName("#define XK_kana_FU 0x04cc")]
        public const int XK_kana_FU = 0x04cc;

        [NativeTypeName("#define XK_kana_HU 0x04cc")]
        public const int XK_kana_HU = 0x04cc;

        [NativeTypeName("#define XK_kana_HE 0x04cd")]
        public const int XK_kana_HE = 0x04cd;

        [NativeTypeName("#define XK_kana_HO 0x04ce")]
        public const int XK_kana_HO = 0x04ce;

        [NativeTypeName("#define XK_kana_MA 0x04cf")]
        public const int XK_kana_MA = 0x04cf;

        [NativeTypeName("#define XK_kana_MI 0x04d0")]
        public const int XK_kana_MI = 0x04d0;

        [NativeTypeName("#define XK_kana_MU 0x04d1")]
        public const int XK_kana_MU = 0x04d1;

        [NativeTypeName("#define XK_kana_ME 0x04d2")]
        public const int XK_kana_ME = 0x04d2;

        [NativeTypeName("#define XK_kana_MO 0x04d3")]
        public const int XK_kana_MO = 0x04d3;

        [NativeTypeName("#define XK_kana_YA 0x04d4")]
        public const int XK_kana_YA = 0x04d4;

        [NativeTypeName("#define XK_kana_YU 0x04d5")]
        public const int XK_kana_YU = 0x04d5;

        [NativeTypeName("#define XK_kana_YO 0x04d6")]
        public const int XK_kana_YO = 0x04d6;

        [NativeTypeName("#define XK_kana_RA 0x04d7")]
        public const int XK_kana_RA = 0x04d7;

        [NativeTypeName("#define XK_kana_RI 0x04d8")]
        public const int XK_kana_RI = 0x04d8;

        [NativeTypeName("#define XK_kana_RU 0x04d9")]
        public const int XK_kana_RU = 0x04d9;

        [NativeTypeName("#define XK_kana_RE 0x04da")]
        public const int XK_kana_RE = 0x04da;

        [NativeTypeName("#define XK_kana_RO 0x04db")]
        public const int XK_kana_RO = 0x04db;

        [NativeTypeName("#define XK_kana_WA 0x04dc")]
        public const int XK_kana_WA = 0x04dc;

        [NativeTypeName("#define XK_kana_N 0x04dd")]
        public const int XK_kana_N = 0x04dd;

        [NativeTypeName("#define XK_voicedsound 0x04de")]
        public const int XK_voicedsound = 0x04de;

        [NativeTypeName("#define XK_semivoicedsound 0x04df")]
        public const int XK_semivoicedsound = 0x04df;

        [NativeTypeName("#define XK_kana_switch 0xff7e")]
        public const int XK_kana_switch = 0xff7e;

        [NativeTypeName("#define XK_Farsi_0 0x10006f0")]
        public const int XK_Farsi_0 = 0x10006f0;

        [NativeTypeName("#define XK_Farsi_1 0x10006f1")]
        public const int XK_Farsi_1 = 0x10006f1;

        [NativeTypeName("#define XK_Farsi_2 0x10006f2")]
        public const int XK_Farsi_2 = 0x10006f2;

        [NativeTypeName("#define XK_Farsi_3 0x10006f3")]
        public const int XK_Farsi_3 = 0x10006f3;

        [NativeTypeName("#define XK_Farsi_4 0x10006f4")]
        public const int XK_Farsi_4 = 0x10006f4;

        [NativeTypeName("#define XK_Farsi_5 0x10006f5")]
        public const int XK_Farsi_5 = 0x10006f5;

        [NativeTypeName("#define XK_Farsi_6 0x10006f6")]
        public const int XK_Farsi_6 = 0x10006f6;

        [NativeTypeName("#define XK_Farsi_7 0x10006f7")]
        public const int XK_Farsi_7 = 0x10006f7;

        [NativeTypeName("#define XK_Farsi_8 0x10006f8")]
        public const int XK_Farsi_8 = 0x10006f8;

        [NativeTypeName("#define XK_Farsi_9 0x10006f9")]
        public const int XK_Farsi_9 = 0x10006f9;

        [NativeTypeName("#define XK_Arabic_percent 0x100066a")]
        public const int XK_Arabic_percent = 0x100066a;

        [NativeTypeName("#define XK_Arabic_superscript_alef 0x1000670")]
        public const int XK_Arabic_superscript_alef = 0x1000670;

        [NativeTypeName("#define XK_Arabic_tteh 0x1000679")]
        public const int XK_Arabic_tteh = 0x1000679;

        [NativeTypeName("#define XK_Arabic_peh 0x100067e")]
        public const int XK_Arabic_peh = 0x100067e;

        [NativeTypeName("#define XK_Arabic_tcheh 0x1000686")]
        public const int XK_Arabic_tcheh = 0x1000686;

        [NativeTypeName("#define XK_Arabic_ddal 0x1000688")]
        public const int XK_Arabic_ddal = 0x1000688;

        [NativeTypeName("#define XK_Arabic_rreh 0x1000691")]
        public const int XK_Arabic_rreh = 0x1000691;

        [NativeTypeName("#define XK_Arabic_comma 0x05ac")]
        public const int XK_Arabic_comma = 0x05ac;

        [NativeTypeName("#define XK_Arabic_fullstop 0x10006d4")]
        public const int XK_Arabic_fullstop = 0x10006d4;

        [NativeTypeName("#define XK_Arabic_0 0x1000660")]
        public const int XK_Arabic_0 = 0x1000660;

        [NativeTypeName("#define XK_Arabic_1 0x1000661")]
        public const int XK_Arabic_1 = 0x1000661;

        [NativeTypeName("#define XK_Arabic_2 0x1000662")]
        public const int XK_Arabic_2 = 0x1000662;

        [NativeTypeName("#define XK_Arabic_3 0x1000663")]
        public const int XK_Arabic_3 = 0x1000663;

        [NativeTypeName("#define XK_Arabic_4 0x1000664")]
        public const int XK_Arabic_4 = 0x1000664;

        [NativeTypeName("#define XK_Arabic_5 0x1000665")]
        public const int XK_Arabic_5 = 0x1000665;

        [NativeTypeName("#define XK_Arabic_6 0x1000666")]
        public const int XK_Arabic_6 = 0x1000666;

        [NativeTypeName("#define XK_Arabic_7 0x1000667")]
        public const int XK_Arabic_7 = 0x1000667;

        [NativeTypeName("#define XK_Arabic_8 0x1000668")]
        public const int XK_Arabic_8 = 0x1000668;

        [NativeTypeName("#define XK_Arabic_9 0x1000669")]
        public const int XK_Arabic_9 = 0x1000669;

        [NativeTypeName("#define XK_Arabic_semicolon 0x05bb")]
        public const int XK_Arabic_semicolon = 0x05bb;

        [NativeTypeName("#define XK_Arabic_question_mark 0x05bf")]
        public const int XK_Arabic_question_mark = 0x05bf;

        [NativeTypeName("#define XK_Arabic_hamza 0x05c1")]
        public const int XK_Arabic_hamza = 0x05c1;

        [NativeTypeName("#define XK_Arabic_maddaonalef 0x05c2")]
        public const int XK_Arabic_maddaonalef = 0x05c2;

        [NativeTypeName("#define XK_Arabic_hamzaonalef 0x05c3")]
        public const int XK_Arabic_hamzaonalef = 0x05c3;

        [NativeTypeName("#define XK_Arabic_hamzaonwaw 0x05c4")]
        public const int XK_Arabic_hamzaonwaw = 0x05c4;

        [NativeTypeName("#define XK_Arabic_hamzaunderalef 0x05c5")]
        public const int XK_Arabic_hamzaunderalef = 0x05c5;

        [NativeTypeName("#define XK_Arabic_hamzaonyeh 0x05c6")]
        public const int XK_Arabic_hamzaonyeh = 0x05c6;

        [NativeTypeName("#define XK_Arabic_alef 0x05c7")]
        public const int XK_Arabic_alef = 0x05c7;

        [NativeTypeName("#define XK_Arabic_beh 0x05c8")]
        public const int XK_Arabic_beh = 0x05c8;

        [NativeTypeName("#define XK_Arabic_tehmarbuta 0x05c9")]
        public const int XK_Arabic_tehmarbuta = 0x05c9;

        [NativeTypeName("#define XK_Arabic_teh 0x05ca")]
        public const int XK_Arabic_teh = 0x05ca;

        [NativeTypeName("#define XK_Arabic_theh 0x05cb")]
        public const int XK_Arabic_theh = 0x05cb;

        [NativeTypeName("#define XK_Arabic_jeem 0x05cc")]
        public const int XK_Arabic_jeem = 0x05cc;

        [NativeTypeName("#define XK_Arabic_hah 0x05cd")]
        public const int XK_Arabic_hah = 0x05cd;

        [NativeTypeName("#define XK_Arabic_khah 0x05ce")]
        public const int XK_Arabic_khah = 0x05ce;

        [NativeTypeName("#define XK_Arabic_dal 0x05cf")]
        public const int XK_Arabic_dal = 0x05cf;

        [NativeTypeName("#define XK_Arabic_thal 0x05d0")]
        public const int XK_Arabic_thal = 0x05d0;

        [NativeTypeName("#define XK_Arabic_ra 0x05d1")]
        public const int XK_Arabic_ra = 0x05d1;

        [NativeTypeName("#define XK_Arabic_zain 0x05d2")]
        public const int XK_Arabic_zain = 0x05d2;

        [NativeTypeName("#define XK_Arabic_seen 0x05d3")]
        public const int XK_Arabic_seen = 0x05d3;

        [NativeTypeName("#define XK_Arabic_sheen 0x05d4")]
        public const int XK_Arabic_sheen = 0x05d4;

        [NativeTypeName("#define XK_Arabic_sad 0x05d5")]
        public const int XK_Arabic_sad = 0x05d5;

        [NativeTypeName("#define XK_Arabic_dad 0x05d6")]
        public const int XK_Arabic_dad = 0x05d6;

        [NativeTypeName("#define XK_Arabic_tah 0x05d7")]
        public const int XK_Arabic_tah = 0x05d7;

        [NativeTypeName("#define XK_Arabic_zah 0x05d8")]
        public const int XK_Arabic_zah = 0x05d8;

        [NativeTypeName("#define XK_Arabic_ain 0x05d9")]
        public const int XK_Arabic_ain = 0x05d9;

        [NativeTypeName("#define XK_Arabic_ghain 0x05da")]
        public const int XK_Arabic_ghain = 0x05da;

        [NativeTypeName("#define XK_Arabic_tatweel 0x05e0")]
        public const int XK_Arabic_tatweel = 0x05e0;

        [NativeTypeName("#define XK_Arabic_feh 0x05e1")]
        public const int XK_Arabic_feh = 0x05e1;

        [NativeTypeName("#define XK_Arabic_qaf 0x05e2")]
        public const int XK_Arabic_qaf = 0x05e2;

        [NativeTypeName("#define XK_Arabic_kaf 0x05e3")]
        public const int XK_Arabic_kaf = 0x05e3;

        [NativeTypeName("#define XK_Arabic_lam 0x05e4")]
        public const int XK_Arabic_lam = 0x05e4;

        [NativeTypeName("#define XK_Arabic_meem 0x05e5")]
        public const int XK_Arabic_meem = 0x05e5;

        [NativeTypeName("#define XK_Arabic_noon 0x05e6")]
        public const int XK_Arabic_noon = 0x05e6;

        [NativeTypeName("#define XK_Arabic_ha 0x05e7")]
        public const int XK_Arabic_ha = 0x05e7;

        [NativeTypeName("#define XK_Arabic_heh 0x05e7")]
        public const int XK_Arabic_heh = 0x05e7;

        [NativeTypeName("#define XK_Arabic_waw 0x05e8")]
        public const int XK_Arabic_waw = 0x05e8;

        [NativeTypeName("#define XK_Arabic_alefmaksura 0x05e9")]
        public const int XK_Arabic_alefmaksura = 0x05e9;

        [NativeTypeName("#define XK_Arabic_yeh 0x05ea")]
        public const int XK_Arabic_yeh = 0x05ea;

        [NativeTypeName("#define XK_Arabic_fathatan 0x05eb")]
        public const int XK_Arabic_fathatan = 0x05eb;

        [NativeTypeName("#define XK_Arabic_dammatan 0x05ec")]
        public const int XK_Arabic_dammatan = 0x05ec;

        [NativeTypeName("#define XK_Arabic_kasratan 0x05ed")]
        public const int XK_Arabic_kasratan = 0x05ed;

        [NativeTypeName("#define XK_Arabic_fatha 0x05ee")]
        public const int XK_Arabic_fatha = 0x05ee;

        [NativeTypeName("#define XK_Arabic_damma 0x05ef")]
        public const int XK_Arabic_damma = 0x05ef;

        [NativeTypeName("#define XK_Arabic_kasra 0x05f0")]
        public const int XK_Arabic_kasra = 0x05f0;

        [NativeTypeName("#define XK_Arabic_shadda 0x05f1")]
        public const int XK_Arabic_shadda = 0x05f1;

        [NativeTypeName("#define XK_Arabic_sukun 0x05f2")]
        public const int XK_Arabic_sukun = 0x05f2;

        [NativeTypeName("#define XK_Arabic_madda_above 0x1000653")]
        public const int XK_Arabic_madda_above = 0x1000653;

        [NativeTypeName("#define XK_Arabic_hamza_above 0x1000654")]
        public const int XK_Arabic_hamza_above = 0x1000654;

        [NativeTypeName("#define XK_Arabic_hamza_below 0x1000655")]
        public const int XK_Arabic_hamza_below = 0x1000655;

        [NativeTypeName("#define XK_Arabic_jeh 0x1000698")]
        public const int XK_Arabic_jeh = 0x1000698;

        [NativeTypeName("#define XK_Arabic_veh 0x10006a4")]
        public const int XK_Arabic_veh = 0x10006a4;

        [NativeTypeName("#define XK_Arabic_keheh 0x10006a9")]
        public const int XK_Arabic_keheh = 0x10006a9;

        [NativeTypeName("#define XK_Arabic_gaf 0x10006af")]
        public const int XK_Arabic_gaf = 0x10006af;

        [NativeTypeName("#define XK_Arabic_noon_ghunna 0x10006ba")]
        public const int XK_Arabic_noon_ghunna = 0x10006ba;

        [NativeTypeName("#define XK_Arabic_heh_doachashmee 0x10006be")]
        public const int XK_Arabic_heh_doachashmee = 0x10006be;

        [NativeTypeName("#define XK_Farsi_yeh 0x10006cc")]
        public const int XK_Farsi_yeh = 0x10006cc;

        [NativeTypeName("#define XK_Arabic_farsi_yeh 0x10006cc")]
        public const int XK_Arabic_farsi_yeh = 0x10006cc;

        [NativeTypeName("#define XK_Arabic_yeh_baree 0x10006d2")]
        public const int XK_Arabic_yeh_baree = 0x10006d2;

        [NativeTypeName("#define XK_Arabic_heh_goal 0x10006c1")]
        public const int XK_Arabic_heh_goal = 0x10006c1;

        [NativeTypeName("#define XK_Arabic_switch 0xff7e")]
        public const int XK_Arabic_switch = 0xff7e;

        [NativeTypeName("#define XK_Cyrillic_GHE_bar 0x1000492")]
        public const int XK_Cyrillic_GHE_bar = 0x1000492;

        [NativeTypeName("#define XK_Cyrillic_ghe_bar 0x1000493")]
        public const int XK_Cyrillic_ghe_bar = 0x1000493;

        [NativeTypeName("#define XK_Cyrillic_ZHE_descender 0x1000496")]
        public const int XK_Cyrillic_ZHE_descender = 0x1000496;

        [NativeTypeName("#define XK_Cyrillic_zhe_descender 0x1000497")]
        public const int XK_Cyrillic_zhe_descender = 0x1000497;

        [NativeTypeName("#define XK_Cyrillic_KA_descender 0x100049a")]
        public const int XK_Cyrillic_KA_descender = 0x100049a;

        [NativeTypeName("#define XK_Cyrillic_ka_descender 0x100049b")]
        public const int XK_Cyrillic_ka_descender = 0x100049b;

        [NativeTypeName("#define XK_Cyrillic_KA_vertstroke 0x100049c")]
        public const int XK_Cyrillic_KA_vertstroke = 0x100049c;

        [NativeTypeName("#define XK_Cyrillic_ka_vertstroke 0x100049d")]
        public const int XK_Cyrillic_ka_vertstroke = 0x100049d;

        [NativeTypeName("#define XK_Cyrillic_EN_descender 0x10004a2")]
        public const int XK_Cyrillic_EN_descender = 0x10004a2;

        [NativeTypeName("#define XK_Cyrillic_en_descender 0x10004a3")]
        public const int XK_Cyrillic_en_descender = 0x10004a3;

        [NativeTypeName("#define XK_Cyrillic_U_straight 0x10004ae")]
        public const int XK_Cyrillic_U_straight = 0x10004ae;

        [NativeTypeName("#define XK_Cyrillic_u_straight 0x10004af")]
        public const int XK_Cyrillic_u_straight = 0x10004af;

        [NativeTypeName("#define XK_Cyrillic_U_straight_bar 0x10004b0")]
        public const int XK_Cyrillic_U_straight_bar = 0x10004b0;

        [NativeTypeName("#define XK_Cyrillic_u_straight_bar 0x10004b1")]
        public const int XK_Cyrillic_u_straight_bar = 0x10004b1;

        [NativeTypeName("#define XK_Cyrillic_HA_descender 0x10004b2")]
        public const int XK_Cyrillic_HA_descender = 0x10004b2;

        [NativeTypeName("#define XK_Cyrillic_ha_descender 0x10004b3")]
        public const int XK_Cyrillic_ha_descender = 0x10004b3;

        [NativeTypeName("#define XK_Cyrillic_CHE_descender 0x10004b6")]
        public const int XK_Cyrillic_CHE_descender = 0x10004b6;

        [NativeTypeName("#define XK_Cyrillic_che_descender 0x10004b7")]
        public const int XK_Cyrillic_che_descender = 0x10004b7;

        [NativeTypeName("#define XK_Cyrillic_CHE_vertstroke 0x10004b8")]
        public const int XK_Cyrillic_CHE_vertstroke = 0x10004b8;

        [NativeTypeName("#define XK_Cyrillic_che_vertstroke 0x10004b9")]
        public const int XK_Cyrillic_che_vertstroke = 0x10004b9;

        [NativeTypeName("#define XK_Cyrillic_SHHA 0x10004ba")]
        public const int XK_Cyrillic_SHHA = 0x10004ba;

        [NativeTypeName("#define XK_Cyrillic_shha 0x10004bb")]
        public const int XK_Cyrillic_shha = 0x10004bb;

        [NativeTypeName("#define XK_Cyrillic_SCHWA 0x10004d8")]
        public const int XK_Cyrillic_SCHWA = 0x10004d8;

        [NativeTypeName("#define XK_Cyrillic_schwa 0x10004d9")]
        public const int XK_Cyrillic_schwa = 0x10004d9;

        [NativeTypeName("#define XK_Cyrillic_I_macron 0x10004e2")]
        public const int XK_Cyrillic_I_macron = 0x10004e2;

        [NativeTypeName("#define XK_Cyrillic_i_macron 0x10004e3")]
        public const int XK_Cyrillic_i_macron = 0x10004e3;

        [NativeTypeName("#define XK_Cyrillic_O_bar 0x10004e8")]
        public const int XK_Cyrillic_O_bar = 0x10004e8;

        [NativeTypeName("#define XK_Cyrillic_o_bar 0x10004e9")]
        public const int XK_Cyrillic_o_bar = 0x10004e9;

        [NativeTypeName("#define XK_Cyrillic_U_macron 0x10004ee")]
        public const int XK_Cyrillic_U_macron = 0x10004ee;

        [NativeTypeName("#define XK_Cyrillic_u_macron 0x10004ef")]
        public const int XK_Cyrillic_u_macron = 0x10004ef;

        [NativeTypeName("#define XK_Serbian_dje 0x06a1")]
        public const int XK_Serbian_dje = 0x06a1;

        [NativeTypeName("#define XK_Macedonia_gje 0x06a2")]
        public const int XK_Macedonia_gje = 0x06a2;

        [NativeTypeName("#define XK_Cyrillic_io 0x06a3")]
        public const int XK_Cyrillic_io = 0x06a3;

        [NativeTypeName("#define XK_Ukrainian_ie 0x06a4")]
        public const int XK_Ukrainian_ie = 0x06a4;

        [NativeTypeName("#define XK_Ukranian_je 0x06a4")]
        public const int XK_Ukranian_je = 0x06a4;

        [NativeTypeName("#define XK_Macedonia_dse 0x06a5")]
        public const int XK_Macedonia_dse = 0x06a5;

        [NativeTypeName("#define XK_Ukrainian_i 0x06a6")]
        public const int XK_Ukrainian_i = 0x06a6;

        [NativeTypeName("#define XK_Ukranian_i 0x06a6")]
        public const int XK_Ukranian_i = 0x06a6;

        [NativeTypeName("#define XK_Ukrainian_yi 0x06a7")]
        public const int XK_Ukrainian_yi = 0x06a7;

        [NativeTypeName("#define XK_Ukranian_yi 0x06a7")]
        public const int XK_Ukranian_yi = 0x06a7;

        [NativeTypeName("#define XK_Cyrillic_je 0x06a8")]
        public const int XK_Cyrillic_je = 0x06a8;

        [NativeTypeName("#define XK_Serbian_je 0x06a8")]
        public const int XK_Serbian_je = 0x06a8;

        [NativeTypeName("#define XK_Cyrillic_lje 0x06a9")]
        public const int XK_Cyrillic_lje = 0x06a9;

        [NativeTypeName("#define XK_Serbian_lje 0x06a9")]
        public const int XK_Serbian_lje = 0x06a9;

        [NativeTypeName("#define XK_Cyrillic_nje 0x06aa")]
        public const int XK_Cyrillic_nje = 0x06aa;

        [NativeTypeName("#define XK_Serbian_nje 0x06aa")]
        public const int XK_Serbian_nje = 0x06aa;

        [NativeTypeName("#define XK_Serbian_tshe 0x06ab")]
        public const int XK_Serbian_tshe = 0x06ab;

        [NativeTypeName("#define XK_Macedonia_kje 0x06ac")]
        public const int XK_Macedonia_kje = 0x06ac;

        [NativeTypeName("#define XK_Ukrainian_ghe_with_upturn 0x06ad")]
        public const int XK_Ukrainian_ghe_with_upturn = 0x06ad;

        [NativeTypeName("#define XK_Byelorussian_shortu 0x06ae")]
        public const int XK_Byelorussian_shortu = 0x06ae;

        [NativeTypeName("#define XK_Cyrillic_dzhe 0x06af")]
        public const int XK_Cyrillic_dzhe = 0x06af;

        [NativeTypeName("#define XK_Serbian_dze 0x06af")]
        public const int XK_Serbian_dze = 0x06af;

        [NativeTypeName("#define XK_numerosign 0x06b0")]
        public const int XK_numerosign = 0x06b0;

        [NativeTypeName("#define XK_Serbian_DJE 0x06b1")]
        public const int XK_Serbian_DJE = 0x06b1;

        [NativeTypeName("#define XK_Macedonia_GJE 0x06b2")]
        public const int XK_Macedonia_GJE = 0x06b2;

        [NativeTypeName("#define XK_Cyrillic_IO 0x06b3")]
        public const int XK_Cyrillic_IO = 0x06b3;

        [NativeTypeName("#define XK_Ukrainian_IE 0x06b4")]
        public const int XK_Ukrainian_IE = 0x06b4;

        [NativeTypeName("#define XK_Ukranian_JE 0x06b4")]
        public const int XK_Ukranian_JE = 0x06b4;

        [NativeTypeName("#define XK_Macedonia_DSE 0x06b5")]
        public const int XK_Macedonia_DSE = 0x06b5;

        [NativeTypeName("#define XK_Ukrainian_I 0x06b6")]
        public const int XK_Ukrainian_I = 0x06b6;

        [NativeTypeName("#define XK_Ukranian_I 0x06b6")]
        public const int XK_Ukranian_I = 0x06b6;

        [NativeTypeName("#define XK_Ukrainian_YI 0x06b7")]
        public const int XK_Ukrainian_YI = 0x06b7;

        [NativeTypeName("#define XK_Ukranian_YI 0x06b7")]
        public const int XK_Ukranian_YI = 0x06b7;

        [NativeTypeName("#define XK_Cyrillic_JE 0x06b8")]
        public const int XK_Cyrillic_JE = 0x06b8;

        [NativeTypeName("#define XK_Serbian_JE 0x06b8")]
        public const int XK_Serbian_JE = 0x06b8;

        [NativeTypeName("#define XK_Cyrillic_LJE 0x06b9")]
        public const int XK_Cyrillic_LJE = 0x06b9;

        [NativeTypeName("#define XK_Serbian_LJE 0x06b9")]
        public const int XK_Serbian_LJE = 0x06b9;

        [NativeTypeName("#define XK_Cyrillic_NJE 0x06ba")]
        public const int XK_Cyrillic_NJE = 0x06ba;

        [NativeTypeName("#define XK_Serbian_NJE 0x06ba")]
        public const int XK_Serbian_NJE = 0x06ba;

        [NativeTypeName("#define XK_Serbian_TSHE 0x06bb")]
        public const int XK_Serbian_TSHE = 0x06bb;

        [NativeTypeName("#define XK_Macedonia_KJE 0x06bc")]
        public const int XK_Macedonia_KJE = 0x06bc;

        [NativeTypeName("#define XK_Ukrainian_GHE_WITH_UPTURN 0x06bd")]
        public const int XK_Ukrainian_GHE_WITH_UPTURN = 0x06bd;

        [NativeTypeName("#define XK_Byelorussian_SHORTU 0x06be")]
        public const int XK_Byelorussian_SHORTU = 0x06be;

        [NativeTypeName("#define XK_Cyrillic_DZHE 0x06bf")]
        public const int XK_Cyrillic_DZHE = 0x06bf;

        [NativeTypeName("#define XK_Serbian_DZE 0x06bf")]
        public const int XK_Serbian_DZE = 0x06bf;

        [NativeTypeName("#define XK_Cyrillic_yu 0x06c0")]
        public const int XK_Cyrillic_yu = 0x06c0;

        [NativeTypeName("#define XK_Cyrillic_a 0x06c1")]
        public const int XK_Cyrillic_a = 0x06c1;

        [NativeTypeName("#define XK_Cyrillic_be 0x06c2")]
        public const int XK_Cyrillic_be = 0x06c2;

        [NativeTypeName("#define XK_Cyrillic_tse 0x06c3")]
        public const int XK_Cyrillic_tse = 0x06c3;

        [NativeTypeName("#define XK_Cyrillic_de 0x06c4")]
        public const int XK_Cyrillic_de = 0x06c4;

        [NativeTypeName("#define XK_Cyrillic_ie 0x06c5")]
        public const int XK_Cyrillic_ie = 0x06c5;

        [NativeTypeName("#define XK_Cyrillic_ef 0x06c6")]
        public const int XK_Cyrillic_ef = 0x06c6;

        [NativeTypeName("#define XK_Cyrillic_ghe 0x06c7")]
        public const int XK_Cyrillic_ghe = 0x06c7;

        [NativeTypeName("#define XK_Cyrillic_ha 0x06c8")]
        public const int XK_Cyrillic_ha = 0x06c8;

        [NativeTypeName("#define XK_Cyrillic_i 0x06c9")]
        public const int XK_Cyrillic_i = 0x06c9;

        [NativeTypeName("#define XK_Cyrillic_shorti 0x06ca")]
        public const int XK_Cyrillic_shorti = 0x06ca;

        [NativeTypeName("#define XK_Cyrillic_ka 0x06cb")]
        public const int XK_Cyrillic_ka = 0x06cb;

        [NativeTypeName("#define XK_Cyrillic_el 0x06cc")]
        public const int XK_Cyrillic_el = 0x06cc;

        [NativeTypeName("#define XK_Cyrillic_em 0x06cd")]
        public const int XK_Cyrillic_em = 0x06cd;

        [NativeTypeName("#define XK_Cyrillic_en 0x06ce")]
        public const int XK_Cyrillic_en = 0x06ce;

        [NativeTypeName("#define XK_Cyrillic_o 0x06cf")]
        public const int XK_Cyrillic_o = 0x06cf;

        [NativeTypeName("#define XK_Cyrillic_pe 0x06d0")]
        public const int XK_Cyrillic_pe = 0x06d0;

        [NativeTypeName("#define XK_Cyrillic_ya 0x06d1")]
        public const int XK_Cyrillic_ya = 0x06d1;

        [NativeTypeName("#define XK_Cyrillic_er 0x06d2")]
        public const int XK_Cyrillic_er = 0x06d2;

        [NativeTypeName("#define XK_Cyrillic_es 0x06d3")]
        public const int XK_Cyrillic_es = 0x06d3;

        [NativeTypeName("#define XK_Cyrillic_te 0x06d4")]
        public const int XK_Cyrillic_te = 0x06d4;

        [NativeTypeName("#define XK_Cyrillic_u 0x06d5")]
        public const int XK_Cyrillic_u = 0x06d5;

        [NativeTypeName("#define XK_Cyrillic_zhe 0x06d6")]
        public const int XK_Cyrillic_zhe = 0x06d6;

        [NativeTypeName("#define XK_Cyrillic_ve 0x06d7")]
        public const int XK_Cyrillic_ve = 0x06d7;

        [NativeTypeName("#define XK_Cyrillic_softsign 0x06d8")]
        public const int XK_Cyrillic_softsign = 0x06d8;

        [NativeTypeName("#define XK_Cyrillic_yeru 0x06d9")]
        public const int XK_Cyrillic_yeru = 0x06d9;

        [NativeTypeName("#define XK_Cyrillic_ze 0x06da")]
        public const int XK_Cyrillic_ze = 0x06da;

        [NativeTypeName("#define XK_Cyrillic_sha 0x06db")]
        public const int XK_Cyrillic_sha = 0x06db;

        [NativeTypeName("#define XK_Cyrillic_e 0x06dc")]
        public const int XK_Cyrillic_e = 0x06dc;

        [NativeTypeName("#define XK_Cyrillic_shcha 0x06dd")]
        public const int XK_Cyrillic_shcha = 0x06dd;

        [NativeTypeName("#define XK_Cyrillic_che 0x06de")]
        public const int XK_Cyrillic_che = 0x06de;

        [NativeTypeName("#define XK_Cyrillic_hardsign 0x06df")]
        public const int XK_Cyrillic_hardsign = 0x06df;

        [NativeTypeName("#define XK_Cyrillic_YU 0x06e0")]
        public const int XK_Cyrillic_YU = 0x06e0;

        [NativeTypeName("#define XK_Cyrillic_A 0x06e1")]
        public const int XK_Cyrillic_A = 0x06e1;

        [NativeTypeName("#define XK_Cyrillic_BE 0x06e2")]
        public const int XK_Cyrillic_BE = 0x06e2;

        [NativeTypeName("#define XK_Cyrillic_TSE 0x06e3")]
        public const int XK_Cyrillic_TSE = 0x06e3;

        [NativeTypeName("#define XK_Cyrillic_DE 0x06e4")]
        public const int XK_Cyrillic_DE = 0x06e4;

        [NativeTypeName("#define XK_Cyrillic_IE 0x06e5")]
        public const int XK_Cyrillic_IE = 0x06e5;

        [NativeTypeName("#define XK_Cyrillic_EF 0x06e6")]
        public const int XK_Cyrillic_EF = 0x06e6;

        [NativeTypeName("#define XK_Cyrillic_GHE 0x06e7")]
        public const int XK_Cyrillic_GHE = 0x06e7;

        [NativeTypeName("#define XK_Cyrillic_HA 0x06e8")]
        public const int XK_Cyrillic_HA = 0x06e8;

        [NativeTypeName("#define XK_Cyrillic_I 0x06e9")]
        public const int XK_Cyrillic_I = 0x06e9;

        [NativeTypeName("#define XK_Cyrillic_SHORTI 0x06ea")]
        public const int XK_Cyrillic_SHORTI = 0x06ea;

        [NativeTypeName("#define XK_Cyrillic_KA 0x06eb")]
        public const int XK_Cyrillic_KA = 0x06eb;

        [NativeTypeName("#define XK_Cyrillic_EL 0x06ec")]
        public const int XK_Cyrillic_EL = 0x06ec;

        [NativeTypeName("#define XK_Cyrillic_EM 0x06ed")]
        public const int XK_Cyrillic_EM = 0x06ed;

        [NativeTypeName("#define XK_Cyrillic_EN 0x06ee")]
        public const int XK_Cyrillic_EN = 0x06ee;

        [NativeTypeName("#define XK_Cyrillic_O 0x06ef")]
        public const int XK_Cyrillic_O = 0x06ef;

        [NativeTypeName("#define XK_Cyrillic_PE 0x06f0")]
        public const int XK_Cyrillic_PE = 0x06f0;

        [NativeTypeName("#define XK_Cyrillic_YA 0x06f1")]
        public const int XK_Cyrillic_YA = 0x06f1;

        [NativeTypeName("#define XK_Cyrillic_ER 0x06f2")]
        public const int XK_Cyrillic_ER = 0x06f2;

        [NativeTypeName("#define XK_Cyrillic_ES 0x06f3")]
        public const int XK_Cyrillic_ES = 0x06f3;

        [NativeTypeName("#define XK_Cyrillic_TE 0x06f4")]
        public const int XK_Cyrillic_TE = 0x06f4;

        [NativeTypeName("#define XK_Cyrillic_U 0x06f5")]
        public const int XK_Cyrillic_U = 0x06f5;

        [NativeTypeName("#define XK_Cyrillic_ZHE 0x06f6")]
        public const int XK_Cyrillic_ZHE = 0x06f6;

        [NativeTypeName("#define XK_Cyrillic_VE 0x06f7")]
        public const int XK_Cyrillic_VE = 0x06f7;

        [NativeTypeName("#define XK_Cyrillic_SOFTSIGN 0x06f8")]
        public const int XK_Cyrillic_SOFTSIGN = 0x06f8;

        [NativeTypeName("#define XK_Cyrillic_YERU 0x06f9")]
        public const int XK_Cyrillic_YERU = 0x06f9;

        [NativeTypeName("#define XK_Cyrillic_ZE 0x06fa")]
        public const int XK_Cyrillic_ZE = 0x06fa;

        [NativeTypeName("#define XK_Cyrillic_SHA 0x06fb")]
        public const int XK_Cyrillic_SHA = 0x06fb;

        [NativeTypeName("#define XK_Cyrillic_E 0x06fc")]
        public const int XK_Cyrillic_E = 0x06fc;

        [NativeTypeName("#define XK_Cyrillic_SHCHA 0x06fd")]
        public const int XK_Cyrillic_SHCHA = 0x06fd;

        [NativeTypeName("#define XK_Cyrillic_CHE 0x06fe")]
        public const int XK_Cyrillic_CHE = 0x06fe;

        [NativeTypeName("#define XK_Cyrillic_HARDSIGN 0x06ff")]
        public const int XK_Cyrillic_HARDSIGN = 0x06ff;

        [NativeTypeName("#define XK_Greek_ALPHAaccent 0x07a1")]
        public const int XK_Greek_ALPHAaccent = 0x07a1;

        [NativeTypeName("#define XK_Greek_EPSILONaccent 0x07a2")]
        public const int XK_Greek_EPSILONaccent = 0x07a2;

        [NativeTypeName("#define XK_Greek_ETAaccent 0x07a3")]
        public const int XK_Greek_ETAaccent = 0x07a3;

        [NativeTypeName("#define XK_Greek_IOTAaccent 0x07a4")]
        public const int XK_Greek_IOTAaccent = 0x07a4;

        [NativeTypeName("#define XK_Greek_IOTAdieresis 0x07a5")]
        public const int XK_Greek_IOTAdieresis = 0x07a5;

        [NativeTypeName("#define XK_Greek_IOTAdiaeresis 0x07a5")]
        public const int XK_Greek_IOTAdiaeresis = 0x07a5;

        [NativeTypeName("#define XK_Greek_OMICRONaccent 0x07a7")]
        public const int XK_Greek_OMICRONaccent = 0x07a7;

        [NativeTypeName("#define XK_Greek_UPSILONaccent 0x07a8")]
        public const int XK_Greek_UPSILONaccent = 0x07a8;

        [NativeTypeName("#define XK_Greek_UPSILONdieresis 0x07a9")]
        public const int XK_Greek_UPSILONdieresis = 0x07a9;

        [NativeTypeName("#define XK_Greek_OMEGAaccent 0x07ab")]
        public const int XK_Greek_OMEGAaccent = 0x07ab;

        [NativeTypeName("#define XK_Greek_accentdieresis 0x07ae")]
        public const int XK_Greek_accentdieresis = 0x07ae;

        [NativeTypeName("#define XK_Greek_horizbar 0x07af")]
        public const int XK_Greek_horizbar = 0x07af;

        [NativeTypeName("#define XK_Greek_alphaaccent 0x07b1")]
        public const int XK_Greek_alphaaccent = 0x07b1;

        [NativeTypeName("#define XK_Greek_epsilonaccent 0x07b2")]
        public const int XK_Greek_epsilonaccent = 0x07b2;

        [NativeTypeName("#define XK_Greek_etaaccent 0x07b3")]
        public const int XK_Greek_etaaccent = 0x07b3;

        [NativeTypeName("#define XK_Greek_iotaaccent 0x07b4")]
        public const int XK_Greek_iotaaccent = 0x07b4;

        [NativeTypeName("#define XK_Greek_iotadieresis 0x07b5")]
        public const int XK_Greek_iotadieresis = 0x07b5;

        [NativeTypeName("#define XK_Greek_iotaaccentdieresis 0x07b6")]
        public const int XK_Greek_iotaaccentdieresis = 0x07b6;

        [NativeTypeName("#define XK_Greek_omicronaccent 0x07b7")]
        public const int XK_Greek_omicronaccent = 0x07b7;

        [NativeTypeName("#define XK_Greek_upsilonaccent 0x07b8")]
        public const int XK_Greek_upsilonaccent = 0x07b8;

        [NativeTypeName("#define XK_Greek_upsilondieresis 0x07b9")]
        public const int XK_Greek_upsilondieresis = 0x07b9;

        [NativeTypeName("#define XK_Greek_upsilonaccentdieresis 0x07ba")]
        public const int XK_Greek_upsilonaccentdieresis = 0x07ba;

        [NativeTypeName("#define XK_Greek_omegaaccent 0x07bb")]
        public const int XK_Greek_omegaaccent = 0x07bb;

        [NativeTypeName("#define XK_Greek_ALPHA 0x07c1")]
        public const int XK_Greek_ALPHA = 0x07c1;

        [NativeTypeName("#define XK_Greek_BETA 0x07c2")]
        public const int XK_Greek_BETA = 0x07c2;

        [NativeTypeName("#define XK_Greek_GAMMA 0x07c3")]
        public const int XK_Greek_GAMMA = 0x07c3;

        [NativeTypeName("#define XK_Greek_DELTA 0x07c4")]
        public const int XK_Greek_DELTA = 0x07c4;

        [NativeTypeName("#define XK_Greek_EPSILON 0x07c5")]
        public const int XK_Greek_EPSILON = 0x07c5;

        [NativeTypeName("#define XK_Greek_ZETA 0x07c6")]
        public const int XK_Greek_ZETA = 0x07c6;

        [NativeTypeName("#define XK_Greek_ETA 0x07c7")]
        public const int XK_Greek_ETA = 0x07c7;

        [NativeTypeName("#define XK_Greek_THETA 0x07c8")]
        public const int XK_Greek_THETA = 0x07c8;

        [NativeTypeName("#define XK_Greek_IOTA 0x07c9")]
        public const int XK_Greek_IOTA = 0x07c9;

        [NativeTypeName("#define XK_Greek_KAPPA 0x07ca")]
        public const int XK_Greek_KAPPA = 0x07ca;

        [NativeTypeName("#define XK_Greek_LAMDA 0x07cb")]
        public const int XK_Greek_LAMDA = 0x07cb;

        [NativeTypeName("#define XK_Greek_LAMBDA 0x07cb")]
        public const int XK_Greek_LAMBDA = 0x07cb;

        [NativeTypeName("#define XK_Greek_MU 0x07cc")]
        public const int XK_Greek_MU = 0x07cc;

        [NativeTypeName("#define XK_Greek_NU 0x07cd")]
        public const int XK_Greek_NU = 0x07cd;

        [NativeTypeName("#define XK_Greek_XI 0x07ce")]
        public const int XK_Greek_XI = 0x07ce;

        [NativeTypeName("#define XK_Greek_OMICRON 0x07cf")]
        public const int XK_Greek_OMICRON = 0x07cf;

        [NativeTypeName("#define XK_Greek_PI 0x07d0")]
        public const int XK_Greek_PI = 0x07d0;

        [NativeTypeName("#define XK_Greek_RHO 0x07d1")]
        public const int XK_Greek_RHO = 0x07d1;

        [NativeTypeName("#define XK_Greek_SIGMA 0x07d2")]
        public const int XK_Greek_SIGMA = 0x07d2;

        [NativeTypeName("#define XK_Greek_TAU 0x07d4")]
        public const int XK_Greek_TAU = 0x07d4;

        [NativeTypeName("#define XK_Greek_UPSILON 0x07d5")]
        public const int XK_Greek_UPSILON = 0x07d5;

        [NativeTypeName("#define XK_Greek_PHI 0x07d6")]
        public const int XK_Greek_PHI = 0x07d6;

        [NativeTypeName("#define XK_Greek_CHI 0x07d7")]
        public const int XK_Greek_CHI = 0x07d7;

        [NativeTypeName("#define XK_Greek_PSI 0x07d8")]
        public const int XK_Greek_PSI = 0x07d8;

        [NativeTypeName("#define XK_Greek_OMEGA 0x07d9")]
        public const int XK_Greek_OMEGA = 0x07d9;

        [NativeTypeName("#define XK_Greek_alpha 0x07e1")]
        public const int XK_Greek_alpha = 0x07e1;

        [NativeTypeName("#define XK_Greek_beta 0x07e2")]
        public const int XK_Greek_beta = 0x07e2;

        [NativeTypeName("#define XK_Greek_gamma 0x07e3")]
        public const int XK_Greek_gamma = 0x07e3;

        [NativeTypeName("#define XK_Greek_delta 0x07e4")]
        public const int XK_Greek_delta = 0x07e4;

        [NativeTypeName("#define XK_Greek_epsilon 0x07e5")]
        public const int XK_Greek_epsilon = 0x07e5;

        [NativeTypeName("#define XK_Greek_zeta 0x07e6")]
        public const int XK_Greek_zeta = 0x07e6;

        [NativeTypeName("#define XK_Greek_eta 0x07e7")]
        public const int XK_Greek_eta = 0x07e7;

        [NativeTypeName("#define XK_Greek_theta 0x07e8")]
        public const int XK_Greek_theta = 0x07e8;

        [NativeTypeName("#define XK_Greek_iota 0x07e9")]
        public const int XK_Greek_iota = 0x07e9;

        [NativeTypeName("#define XK_Greek_kappa 0x07ea")]
        public const int XK_Greek_kappa = 0x07ea;

        [NativeTypeName("#define XK_Greek_lamda 0x07eb")]
        public const int XK_Greek_lamda = 0x07eb;

        [NativeTypeName("#define XK_Greek_lambda 0x07eb")]
        public const int XK_Greek_lambda = 0x07eb;

        [NativeTypeName("#define XK_Greek_mu 0x07ec")]
        public const int XK_Greek_mu = 0x07ec;

        [NativeTypeName("#define XK_Greek_nu 0x07ed")]
        public const int XK_Greek_nu = 0x07ed;

        [NativeTypeName("#define XK_Greek_xi 0x07ee")]
        public const int XK_Greek_xi = 0x07ee;

        [NativeTypeName("#define XK_Greek_omicron 0x07ef")]
        public const int XK_Greek_omicron = 0x07ef;

        [NativeTypeName("#define XK_Greek_pi 0x07f0")]
        public const int XK_Greek_pi = 0x07f0;

        [NativeTypeName("#define XK_Greek_rho 0x07f1")]
        public const int XK_Greek_rho = 0x07f1;

        [NativeTypeName("#define XK_Greek_sigma 0x07f2")]
        public const int XK_Greek_sigma = 0x07f2;

        [NativeTypeName("#define XK_Greek_finalsmallsigma 0x07f3")]
        public const int XK_Greek_finalsmallsigma = 0x07f3;

        [NativeTypeName("#define XK_Greek_tau 0x07f4")]
        public const int XK_Greek_tau = 0x07f4;

        [NativeTypeName("#define XK_Greek_upsilon 0x07f5")]
        public const int XK_Greek_upsilon = 0x07f5;

        [NativeTypeName("#define XK_Greek_phi 0x07f6")]
        public const int XK_Greek_phi = 0x07f6;

        [NativeTypeName("#define XK_Greek_chi 0x07f7")]
        public const int XK_Greek_chi = 0x07f7;

        [NativeTypeName("#define XK_Greek_psi 0x07f8")]
        public const int XK_Greek_psi = 0x07f8;

        [NativeTypeName("#define XK_Greek_omega 0x07f9")]
        public const int XK_Greek_omega = 0x07f9;

        [NativeTypeName("#define XK_Greek_switch 0xff7e")]
        public const int XK_Greek_switch = 0xff7e;

        [NativeTypeName("#define XK_leftradical 0x08a1")]
        public const int XK_leftradical = 0x08a1;

        [NativeTypeName("#define XK_topleftradical 0x08a2")]
        public const int XK_topleftradical = 0x08a2;

        [NativeTypeName("#define XK_horizconnector 0x08a3")]
        public const int XK_horizconnector = 0x08a3;

        [NativeTypeName("#define XK_topintegral 0x08a4")]
        public const int XK_topintegral = 0x08a4;

        [NativeTypeName("#define XK_botintegral 0x08a5")]
        public const int XK_botintegral = 0x08a5;

        [NativeTypeName("#define XK_vertconnector 0x08a6")]
        public const int XK_vertconnector = 0x08a6;

        [NativeTypeName("#define XK_topleftsqbracket 0x08a7")]
        public const int XK_topleftsqbracket = 0x08a7;

        [NativeTypeName("#define XK_botleftsqbracket 0x08a8")]
        public const int XK_botleftsqbracket = 0x08a8;

        [NativeTypeName("#define XK_toprightsqbracket 0x08a9")]
        public const int XK_toprightsqbracket = 0x08a9;

        [NativeTypeName("#define XK_botrightsqbracket 0x08aa")]
        public const int XK_botrightsqbracket = 0x08aa;

        [NativeTypeName("#define XK_topleftparens 0x08ab")]
        public const int XK_topleftparens = 0x08ab;

        [NativeTypeName("#define XK_botleftparens 0x08ac")]
        public const int XK_botleftparens = 0x08ac;

        [NativeTypeName("#define XK_toprightparens 0x08ad")]
        public const int XK_toprightparens = 0x08ad;

        [NativeTypeName("#define XK_botrightparens 0x08ae")]
        public const int XK_botrightparens = 0x08ae;

        [NativeTypeName("#define XK_leftmiddlecurlybrace 0x08af")]
        public const int XK_leftmiddlecurlybrace = 0x08af;

        [NativeTypeName("#define XK_rightmiddlecurlybrace 0x08b0")]
        public const int XK_rightmiddlecurlybrace = 0x08b0;

        [NativeTypeName("#define XK_topleftsummation 0x08b1")]
        public const int XK_topleftsummation = 0x08b1;

        [NativeTypeName("#define XK_botleftsummation 0x08b2")]
        public const int XK_botleftsummation = 0x08b2;

        [NativeTypeName("#define XK_topvertsummationconnector 0x08b3")]
        public const int XK_topvertsummationconnector = 0x08b3;

        [NativeTypeName("#define XK_botvertsummationconnector 0x08b4")]
        public const int XK_botvertsummationconnector = 0x08b4;

        [NativeTypeName("#define XK_toprightsummation 0x08b5")]
        public const int XK_toprightsummation = 0x08b5;

        [NativeTypeName("#define XK_botrightsummation 0x08b6")]
        public const int XK_botrightsummation = 0x08b6;

        [NativeTypeName("#define XK_rightmiddlesummation 0x08b7")]
        public const int XK_rightmiddlesummation = 0x08b7;

        [NativeTypeName("#define XK_lessthanequal 0x08bc")]
        public const int XK_lessthanequal = 0x08bc;

        [NativeTypeName("#define XK_notequal 0x08bd")]
        public const int XK_notequal = 0x08bd;

        [NativeTypeName("#define XK_greaterthanequal 0x08be")]
        public const int XK_greaterthanequal = 0x08be;

        [NativeTypeName("#define XK_integral 0x08bf")]
        public const int XK_integral = 0x08bf;

        [NativeTypeName("#define XK_therefore 0x08c0")]
        public const int XK_therefore = 0x08c0;

        [NativeTypeName("#define XK_variation 0x08c1")]
        public const int XK_variation = 0x08c1;

        [NativeTypeName("#define XK_infinity 0x08c2")]
        public const int XK_infinity = 0x08c2;

        [NativeTypeName("#define XK_nabla 0x08c5")]
        public const int XK_nabla = 0x08c5;

        [NativeTypeName("#define XK_approximate 0x08c8")]
        public const int XK_approximate = 0x08c8;

        [NativeTypeName("#define XK_similarequal 0x08c9")]
        public const int XK_similarequal = 0x08c9;

        [NativeTypeName("#define XK_ifonlyif 0x08cd")]
        public const int XK_ifonlyif = 0x08cd;

        [NativeTypeName("#define XK_implies 0x08ce")]
        public const int XK_implies = 0x08ce;

        [NativeTypeName("#define XK_identical 0x08cf")]
        public const int XK_identical = 0x08cf;

        [NativeTypeName("#define XK_radical 0x08d6")]
        public const int XK_radical = 0x08d6;

        [NativeTypeName("#define XK_includedin 0x08da")]
        public const int XK_includedin = 0x08da;

        [NativeTypeName("#define XK_includes 0x08db")]
        public const int XK_includes = 0x08db;

        [NativeTypeName("#define XK_intersection 0x08dc")]
        public const int XK_intersection = 0x08dc;

        [NativeTypeName("#define XK_union 0x08dd")]
        public const int XK_union = 0x08dd;

        [NativeTypeName("#define XK_logicaland 0x08de")]
        public const int XK_logicaland = 0x08de;

        [NativeTypeName("#define XK_logicalor 0x08df")]
        public const int XK_logicalor = 0x08df;

        [NativeTypeName("#define XK_partialderivative 0x08ef")]
        public const int XK_partialderivative = 0x08ef;

        [NativeTypeName("#define XK_function 0x08f6")]
        public const int XK_function = 0x08f6;

        [NativeTypeName("#define XK_leftarrow 0x08fb")]
        public const int XK_leftarrow = 0x08fb;

        [NativeTypeName("#define XK_uparrow 0x08fc")]
        public const int XK_uparrow = 0x08fc;

        [NativeTypeName("#define XK_rightarrow 0x08fd")]
        public const int XK_rightarrow = 0x08fd;

        [NativeTypeName("#define XK_downarrow 0x08fe")]
        public const int XK_downarrow = 0x08fe;

        [NativeTypeName("#define XK_blank 0x09df")]
        public const int XK_blank = 0x09df;

        [NativeTypeName("#define XK_soliddiamond 0x09e0")]
        public const int XK_soliddiamond = 0x09e0;

        [NativeTypeName("#define XK_checkerboard 0x09e1")]
        public const int XK_checkerboard = 0x09e1;

        [NativeTypeName("#define XK_ht 0x09e2")]
        public const int XK_ht = 0x09e2;

        [NativeTypeName("#define XK_ff 0x09e3")]
        public const int XK_ff = 0x09e3;

        [NativeTypeName("#define XK_cr 0x09e4")]
        public const int XK_cr = 0x09e4;

        [NativeTypeName("#define XK_lf 0x09e5")]
        public const int XK_lf = 0x09e5;

        [NativeTypeName("#define XK_nl 0x09e8")]
        public const int XK_nl = 0x09e8;

        [NativeTypeName("#define XK_vt 0x09e9")]
        public const int XK_vt = 0x09e9;

        [NativeTypeName("#define XK_lowrightcorner 0x09ea")]
        public const int XK_lowrightcorner = 0x09ea;

        [NativeTypeName("#define XK_uprightcorner 0x09eb")]
        public const int XK_uprightcorner = 0x09eb;

        [NativeTypeName("#define XK_upleftcorner 0x09ec")]
        public const int XK_upleftcorner = 0x09ec;

        [NativeTypeName("#define XK_lowleftcorner 0x09ed")]
        public const int XK_lowleftcorner = 0x09ed;

        [NativeTypeName("#define XK_crossinglines 0x09ee")]
        public const int XK_crossinglines = 0x09ee;

        [NativeTypeName("#define XK_horizlinescan1 0x09ef")]
        public const int XK_horizlinescan1 = 0x09ef;

        [NativeTypeName("#define XK_horizlinescan3 0x09f0")]
        public const int XK_horizlinescan3 = 0x09f0;

        [NativeTypeName("#define XK_horizlinescan5 0x09f1")]
        public const int XK_horizlinescan5 = 0x09f1;

        [NativeTypeName("#define XK_horizlinescan7 0x09f2")]
        public const int XK_horizlinescan7 = 0x09f2;

        [NativeTypeName("#define XK_horizlinescan9 0x09f3")]
        public const int XK_horizlinescan9 = 0x09f3;

        [NativeTypeName("#define XK_leftt 0x09f4")]
        public const int XK_leftt = 0x09f4;

        [NativeTypeName("#define XK_rightt 0x09f5")]
        public const int XK_rightt = 0x09f5;

        [NativeTypeName("#define XK_bott 0x09f6")]
        public const int XK_bott = 0x09f6;

        [NativeTypeName("#define XK_topt 0x09f7")]
        public const int XK_topt = 0x09f7;

        [NativeTypeName("#define XK_vertbar 0x09f8")]
        public const int XK_vertbar = 0x09f8;

        [NativeTypeName("#define XK_emspace 0x0aa1")]
        public const int XK_emspace = 0x0aa1;

        [NativeTypeName("#define XK_enspace 0x0aa2")]
        public const int XK_enspace = 0x0aa2;

        [NativeTypeName("#define XK_em3space 0x0aa3")]
        public const int XK_em3space = 0x0aa3;

        [NativeTypeName("#define XK_em4space 0x0aa4")]
        public const int XK_em4space = 0x0aa4;

        [NativeTypeName("#define XK_digitspace 0x0aa5")]
        public const int XK_digitspace = 0x0aa5;

        [NativeTypeName("#define XK_punctspace 0x0aa6")]
        public const int XK_punctspace = 0x0aa6;

        [NativeTypeName("#define XK_thinspace 0x0aa7")]
        public const int XK_thinspace = 0x0aa7;

        [NativeTypeName("#define XK_hairspace 0x0aa8")]
        public const int XK_hairspace = 0x0aa8;

        [NativeTypeName("#define XK_emdash 0x0aa9")]
        public const int XK_emdash = 0x0aa9;

        [NativeTypeName("#define XK_endash 0x0aaa")]
        public const int XK_endash = 0x0aaa;

        [NativeTypeName("#define XK_signifblank 0x0aac")]
        public const int XK_signifblank = 0x0aac;

        [NativeTypeName("#define XK_ellipsis 0x0aae")]
        public const int XK_ellipsis = 0x0aae;

        [NativeTypeName("#define XK_doubbaselinedot 0x0aaf")]
        public const int XK_doubbaselinedot = 0x0aaf;

        [NativeTypeName("#define XK_onethird 0x0ab0")]
        public const int XK_onethird = 0x0ab0;

        [NativeTypeName("#define XK_twothirds 0x0ab1")]
        public const int XK_twothirds = 0x0ab1;

        [NativeTypeName("#define XK_onefifth 0x0ab2")]
        public const int XK_onefifth = 0x0ab2;

        [NativeTypeName("#define XK_twofifths 0x0ab3")]
        public const int XK_twofifths = 0x0ab3;

        [NativeTypeName("#define XK_threefifths 0x0ab4")]
        public const int XK_threefifths = 0x0ab4;

        [NativeTypeName("#define XK_fourfifths 0x0ab5")]
        public const int XK_fourfifths = 0x0ab5;

        [NativeTypeName("#define XK_onesixth 0x0ab6")]
        public const int XK_onesixth = 0x0ab6;

        [NativeTypeName("#define XK_fivesixths 0x0ab7")]
        public const int XK_fivesixths = 0x0ab7;

        [NativeTypeName("#define XK_careof 0x0ab8")]
        public const int XK_careof = 0x0ab8;

        [NativeTypeName("#define XK_figdash 0x0abb")]
        public const int XK_figdash = 0x0abb;

        [NativeTypeName("#define XK_leftanglebracket 0x0abc")]
        public const int XK_leftanglebracket = 0x0abc;

        [NativeTypeName("#define XK_decimalpoint 0x0abd")]
        public const int XK_decimalpoint = 0x0abd;

        [NativeTypeName("#define XK_rightanglebracket 0x0abe")]
        public const int XK_rightanglebracket = 0x0abe;

        [NativeTypeName("#define XK_marker 0x0abf")]
        public const int XK_marker = 0x0abf;

        [NativeTypeName("#define XK_oneeighth 0x0ac3")]
        public const int XK_oneeighth = 0x0ac3;

        [NativeTypeName("#define XK_threeeighths 0x0ac4")]
        public const int XK_threeeighths = 0x0ac4;

        [NativeTypeName("#define XK_fiveeighths 0x0ac5")]
        public const int XK_fiveeighths = 0x0ac5;

        [NativeTypeName("#define XK_seveneighths 0x0ac6")]
        public const int XK_seveneighths = 0x0ac6;

        [NativeTypeName("#define XK_trademark 0x0ac9")]
        public const int XK_trademark = 0x0ac9;

        [NativeTypeName("#define XK_signaturemark 0x0aca")]
        public const int XK_signaturemark = 0x0aca;

        [NativeTypeName("#define XK_trademarkincircle 0x0acb")]
        public const int XK_trademarkincircle = 0x0acb;

        [NativeTypeName("#define XK_leftopentriangle 0x0acc")]
        public const int XK_leftopentriangle = 0x0acc;

        [NativeTypeName("#define XK_rightopentriangle 0x0acd")]
        public const int XK_rightopentriangle = 0x0acd;

        [NativeTypeName("#define XK_emopencircle 0x0ace")]
        public const int XK_emopencircle = 0x0ace;

        [NativeTypeName("#define XK_emopenrectangle 0x0acf")]
        public const int XK_emopenrectangle = 0x0acf;

        [NativeTypeName("#define XK_leftsinglequotemark 0x0ad0")]
        public const int XK_leftsinglequotemark = 0x0ad0;

        [NativeTypeName("#define XK_rightsinglequotemark 0x0ad1")]
        public const int XK_rightsinglequotemark = 0x0ad1;

        [NativeTypeName("#define XK_leftdoublequotemark 0x0ad2")]
        public const int XK_leftdoublequotemark = 0x0ad2;

        [NativeTypeName("#define XK_rightdoublequotemark 0x0ad3")]
        public const int XK_rightdoublequotemark = 0x0ad3;

        [NativeTypeName("#define XK_prescription 0x0ad4")]
        public const int XK_prescription = 0x0ad4;

        [NativeTypeName("#define XK_permille 0x0ad5")]
        public const int XK_permille = 0x0ad5;

        [NativeTypeName("#define XK_minutes 0x0ad6")]
        public const int XK_minutes = 0x0ad6;

        [NativeTypeName("#define XK_seconds 0x0ad7")]
        public const int XK_seconds = 0x0ad7;

        [NativeTypeName("#define XK_latincross 0x0ad9")]
        public const int XK_latincross = 0x0ad9;

        [NativeTypeName("#define XK_hexagram 0x0ada")]
        public const int XK_hexagram = 0x0ada;

        [NativeTypeName("#define XK_filledrectbullet 0x0adb")]
        public const int XK_filledrectbullet = 0x0adb;

        [NativeTypeName("#define XK_filledlefttribullet 0x0adc")]
        public const int XK_filledlefttribullet = 0x0adc;

        [NativeTypeName("#define XK_filledrighttribullet 0x0add")]
        public const int XK_filledrighttribullet = 0x0add;

        [NativeTypeName("#define XK_emfilledcircle 0x0ade")]
        public const int XK_emfilledcircle = 0x0ade;

        [NativeTypeName("#define XK_emfilledrect 0x0adf")]
        public const int XK_emfilledrect = 0x0adf;

        [NativeTypeName("#define XK_enopencircbullet 0x0ae0")]
        public const int XK_enopencircbullet = 0x0ae0;

        [NativeTypeName("#define XK_enopensquarebullet 0x0ae1")]
        public const int XK_enopensquarebullet = 0x0ae1;

        [NativeTypeName("#define XK_openrectbullet 0x0ae2")]
        public const int XK_openrectbullet = 0x0ae2;

        [NativeTypeName("#define XK_opentribulletup 0x0ae3")]
        public const int XK_opentribulletup = 0x0ae3;

        [NativeTypeName("#define XK_opentribulletdown 0x0ae4")]
        public const int XK_opentribulletdown = 0x0ae4;

        [NativeTypeName("#define XK_openstar 0x0ae5")]
        public const int XK_openstar = 0x0ae5;

        [NativeTypeName("#define XK_enfilledcircbullet 0x0ae6")]
        public const int XK_enfilledcircbullet = 0x0ae6;

        [NativeTypeName("#define XK_enfilledsqbullet 0x0ae7")]
        public const int XK_enfilledsqbullet = 0x0ae7;

        [NativeTypeName("#define XK_filledtribulletup 0x0ae8")]
        public const int XK_filledtribulletup = 0x0ae8;

        [NativeTypeName("#define XK_filledtribulletdown 0x0ae9")]
        public const int XK_filledtribulletdown = 0x0ae9;

        [NativeTypeName("#define XK_leftpointer 0x0aea")]
        public const int XK_leftpointer = 0x0aea;

        [NativeTypeName("#define XK_rightpointer 0x0aeb")]
        public const int XK_rightpointer = 0x0aeb;

        [NativeTypeName("#define XK_club 0x0aec")]
        public const int XK_club = 0x0aec;

        [NativeTypeName("#define XK_diamond 0x0aed")]
        public const int XK_diamond = 0x0aed;

        [NativeTypeName("#define XK_heart 0x0aee")]
        public const int XK_heart = 0x0aee;

        [NativeTypeName("#define XK_maltesecross 0x0af0")]
        public const int XK_maltesecross = 0x0af0;

        [NativeTypeName("#define XK_dagger 0x0af1")]
        public const int XK_dagger = 0x0af1;

        [NativeTypeName("#define XK_doubledagger 0x0af2")]
        public const int XK_doubledagger = 0x0af2;

        [NativeTypeName("#define XK_checkmark 0x0af3")]
        public const int XK_checkmark = 0x0af3;

        [NativeTypeName("#define XK_ballotcross 0x0af4")]
        public const int XK_ballotcross = 0x0af4;

        [NativeTypeName("#define XK_musicalsharp 0x0af5")]
        public const int XK_musicalsharp = 0x0af5;

        [NativeTypeName("#define XK_musicalflat 0x0af6")]
        public const int XK_musicalflat = 0x0af6;

        [NativeTypeName("#define XK_malesymbol 0x0af7")]
        public const int XK_malesymbol = 0x0af7;

        [NativeTypeName("#define XK_femalesymbol 0x0af8")]
        public const int XK_femalesymbol = 0x0af8;

        [NativeTypeName("#define XK_telephone 0x0af9")]
        public const int XK_telephone = 0x0af9;

        [NativeTypeName("#define XK_telephonerecorder 0x0afa")]
        public const int XK_telephonerecorder = 0x0afa;

        [NativeTypeName("#define XK_phonographcopyright 0x0afb")]
        public const int XK_phonographcopyright = 0x0afb;

        [NativeTypeName("#define XK_caret 0x0afc")]
        public const int XK_caret = 0x0afc;

        [NativeTypeName("#define XK_singlelowquotemark 0x0afd")]
        public const int XK_singlelowquotemark = 0x0afd;

        [NativeTypeName("#define XK_doublelowquotemark 0x0afe")]
        public const int XK_doublelowquotemark = 0x0afe;

        [NativeTypeName("#define XK_cursor 0x0aff")]
        public const int XK_cursor = 0x0aff;

        [NativeTypeName("#define XK_leftcaret 0x0ba3")]
        public const int XK_leftcaret = 0x0ba3;

        [NativeTypeName("#define XK_rightcaret 0x0ba6")]
        public const int XK_rightcaret = 0x0ba6;

        [NativeTypeName("#define XK_downcaret 0x0ba8")]
        public const int XK_downcaret = 0x0ba8;

        [NativeTypeName("#define XK_upcaret 0x0ba9")]
        public const int XK_upcaret = 0x0ba9;

        [NativeTypeName("#define XK_overbar 0x0bc0")]
        public const int XK_overbar = 0x0bc0;

        [NativeTypeName("#define XK_downtack 0x0bc2")]
        public const int XK_downtack = 0x0bc2;

        [NativeTypeName("#define XK_upshoe 0x0bc3")]
        public const int XK_upshoe = 0x0bc3;

        [NativeTypeName("#define XK_downstile 0x0bc4")]
        public const int XK_downstile = 0x0bc4;

        [NativeTypeName("#define XK_underbar 0x0bc6")]
        public const int XK_underbar = 0x0bc6;

        [NativeTypeName("#define XK_jot 0x0bca")]
        public const int XK_jot = 0x0bca;

        [NativeTypeName("#define XK_quad 0x0bcc")]
        public const int XK_quad = 0x0bcc;

        [NativeTypeName("#define XK_uptack 0x0bce")]
        public const int XK_uptack = 0x0bce;

        [NativeTypeName("#define XK_circle 0x0bcf")]
        public const int XK_circle = 0x0bcf;

        [NativeTypeName("#define XK_upstile 0x0bd3")]
        public const int XK_upstile = 0x0bd3;

        [NativeTypeName("#define XK_downshoe 0x0bd6")]
        public const int XK_downshoe = 0x0bd6;

        [NativeTypeName("#define XK_rightshoe 0x0bd8")]
        public const int XK_rightshoe = 0x0bd8;

        [NativeTypeName("#define XK_leftshoe 0x0bda")]
        public const int XK_leftshoe = 0x0bda;

        [NativeTypeName("#define XK_lefttack 0x0bdc")]
        public const int XK_lefttack = 0x0bdc;

        [NativeTypeName("#define XK_righttack 0x0bfc")]
        public const int XK_righttack = 0x0bfc;

        [NativeTypeName("#define XK_hebrew_doublelowline 0x0cdf")]
        public const int XK_hebrew_doublelowline = 0x0cdf;

        [NativeTypeName("#define XK_hebrew_aleph 0x0ce0")]
        public const int XK_hebrew_aleph = 0x0ce0;

        [NativeTypeName("#define XK_hebrew_bet 0x0ce1")]
        public const int XK_hebrew_bet = 0x0ce1;

        [NativeTypeName("#define XK_hebrew_beth 0x0ce1")]
        public const int XK_hebrew_beth = 0x0ce1;

        [NativeTypeName("#define XK_hebrew_gimel 0x0ce2")]
        public const int XK_hebrew_gimel = 0x0ce2;

        [NativeTypeName("#define XK_hebrew_gimmel 0x0ce2")]
        public const int XK_hebrew_gimmel = 0x0ce2;

        [NativeTypeName("#define XK_hebrew_dalet 0x0ce3")]
        public const int XK_hebrew_dalet = 0x0ce3;

        [NativeTypeName("#define XK_hebrew_daleth 0x0ce3")]
        public const int XK_hebrew_daleth = 0x0ce3;

        [NativeTypeName("#define XK_hebrew_he 0x0ce4")]
        public const int XK_hebrew_he = 0x0ce4;

        [NativeTypeName("#define XK_hebrew_waw 0x0ce5")]
        public const int XK_hebrew_waw = 0x0ce5;

        [NativeTypeName("#define XK_hebrew_zain 0x0ce6")]
        public const int XK_hebrew_zain = 0x0ce6;

        [NativeTypeName("#define XK_hebrew_zayin 0x0ce6")]
        public const int XK_hebrew_zayin = 0x0ce6;

        [NativeTypeName("#define XK_hebrew_chet 0x0ce7")]
        public const int XK_hebrew_chet = 0x0ce7;

        [NativeTypeName("#define XK_hebrew_het 0x0ce7")]
        public const int XK_hebrew_het = 0x0ce7;

        [NativeTypeName("#define XK_hebrew_tet 0x0ce8")]
        public const int XK_hebrew_tet = 0x0ce8;

        [NativeTypeName("#define XK_hebrew_teth 0x0ce8")]
        public const int XK_hebrew_teth = 0x0ce8;

        [NativeTypeName("#define XK_hebrew_yod 0x0ce9")]
        public const int XK_hebrew_yod = 0x0ce9;

        [NativeTypeName("#define XK_hebrew_finalkaph 0x0cea")]
        public const int XK_hebrew_finalkaph = 0x0cea;

        [NativeTypeName("#define XK_hebrew_kaph 0x0ceb")]
        public const int XK_hebrew_kaph = 0x0ceb;

        [NativeTypeName("#define XK_hebrew_lamed 0x0cec")]
        public const int XK_hebrew_lamed = 0x0cec;

        [NativeTypeName("#define XK_hebrew_finalmem 0x0ced")]
        public const int XK_hebrew_finalmem = 0x0ced;

        [NativeTypeName("#define XK_hebrew_mem 0x0cee")]
        public const int XK_hebrew_mem = 0x0cee;

        [NativeTypeName("#define XK_hebrew_finalnun 0x0cef")]
        public const int XK_hebrew_finalnun = 0x0cef;

        [NativeTypeName("#define XK_hebrew_nun 0x0cf0")]
        public const int XK_hebrew_nun = 0x0cf0;

        [NativeTypeName("#define XK_hebrew_samech 0x0cf1")]
        public const int XK_hebrew_samech = 0x0cf1;

        [NativeTypeName("#define XK_hebrew_samekh 0x0cf1")]
        public const int XK_hebrew_samekh = 0x0cf1;

        [NativeTypeName("#define XK_hebrew_ayin 0x0cf2")]
        public const int XK_hebrew_ayin = 0x0cf2;

        [NativeTypeName("#define XK_hebrew_finalpe 0x0cf3")]
        public const int XK_hebrew_finalpe = 0x0cf3;

        [NativeTypeName("#define XK_hebrew_pe 0x0cf4")]
        public const int XK_hebrew_pe = 0x0cf4;

        [NativeTypeName("#define XK_hebrew_finalzade 0x0cf5")]
        public const int XK_hebrew_finalzade = 0x0cf5;

        [NativeTypeName("#define XK_hebrew_finalzadi 0x0cf5")]
        public const int XK_hebrew_finalzadi = 0x0cf5;

        [NativeTypeName("#define XK_hebrew_zade 0x0cf6")]
        public const int XK_hebrew_zade = 0x0cf6;

        [NativeTypeName("#define XK_hebrew_zadi 0x0cf6")]
        public const int XK_hebrew_zadi = 0x0cf6;

        [NativeTypeName("#define XK_hebrew_qoph 0x0cf7")]
        public const int XK_hebrew_qoph = 0x0cf7;

        [NativeTypeName("#define XK_hebrew_kuf 0x0cf7")]
        public const int XK_hebrew_kuf = 0x0cf7;

        [NativeTypeName("#define XK_hebrew_resh 0x0cf8")]
        public const int XK_hebrew_resh = 0x0cf8;

        [NativeTypeName("#define XK_hebrew_shin 0x0cf9")]
        public const int XK_hebrew_shin = 0x0cf9;

        [NativeTypeName("#define XK_hebrew_taw 0x0cfa")]
        public const int XK_hebrew_taw = 0x0cfa;

        [NativeTypeName("#define XK_hebrew_taf 0x0cfa")]
        public const int XK_hebrew_taf = 0x0cfa;

        [NativeTypeName("#define XK_Hebrew_switch 0xff7e")]
        public const int XK_Hebrew_switch = 0xff7e;

        [NativeTypeName("#define XK_Thai_kokai 0x0da1")]
        public const int XK_Thai_kokai = 0x0da1;

        [NativeTypeName("#define XK_Thai_khokhai 0x0da2")]
        public const int XK_Thai_khokhai = 0x0da2;

        [NativeTypeName("#define XK_Thai_khokhuat 0x0da3")]
        public const int XK_Thai_khokhuat = 0x0da3;

        [NativeTypeName("#define XK_Thai_khokhwai 0x0da4")]
        public const int XK_Thai_khokhwai = 0x0da4;

        [NativeTypeName("#define XK_Thai_khokhon 0x0da5")]
        public const int XK_Thai_khokhon = 0x0da5;

        [NativeTypeName("#define XK_Thai_khorakhang 0x0da6")]
        public const int XK_Thai_khorakhang = 0x0da6;

        [NativeTypeName("#define XK_Thai_ngongu 0x0da7")]
        public const int XK_Thai_ngongu = 0x0da7;

        [NativeTypeName("#define XK_Thai_chochan 0x0da8")]
        public const int XK_Thai_chochan = 0x0da8;

        [NativeTypeName("#define XK_Thai_choching 0x0da9")]
        public const int XK_Thai_choching = 0x0da9;

        [NativeTypeName("#define XK_Thai_chochang 0x0daa")]
        public const int XK_Thai_chochang = 0x0daa;

        [NativeTypeName("#define XK_Thai_soso 0x0dab")]
        public const int XK_Thai_soso = 0x0dab;

        [NativeTypeName("#define XK_Thai_chochoe 0x0dac")]
        public const int XK_Thai_chochoe = 0x0dac;

        [NativeTypeName("#define XK_Thai_yoying 0x0dad")]
        public const int XK_Thai_yoying = 0x0dad;

        [NativeTypeName("#define XK_Thai_dochada 0x0dae")]
        public const int XK_Thai_dochada = 0x0dae;

        [NativeTypeName("#define XK_Thai_topatak 0x0daf")]
        public const int XK_Thai_topatak = 0x0daf;

        [NativeTypeName("#define XK_Thai_thothan 0x0db0")]
        public const int XK_Thai_thothan = 0x0db0;

        [NativeTypeName("#define XK_Thai_thonangmontho 0x0db1")]
        public const int XK_Thai_thonangmontho = 0x0db1;

        [NativeTypeName("#define XK_Thai_thophuthao 0x0db2")]
        public const int XK_Thai_thophuthao = 0x0db2;

        [NativeTypeName("#define XK_Thai_nonen 0x0db3")]
        public const int XK_Thai_nonen = 0x0db3;

        [NativeTypeName("#define XK_Thai_dodek 0x0db4")]
        public const int XK_Thai_dodek = 0x0db4;

        [NativeTypeName("#define XK_Thai_totao 0x0db5")]
        public const int XK_Thai_totao = 0x0db5;

        [NativeTypeName("#define XK_Thai_thothung 0x0db6")]
        public const int XK_Thai_thothung = 0x0db6;

        [NativeTypeName("#define XK_Thai_thothahan 0x0db7")]
        public const int XK_Thai_thothahan = 0x0db7;

        [NativeTypeName("#define XK_Thai_thothong 0x0db8")]
        public const int XK_Thai_thothong = 0x0db8;

        [NativeTypeName("#define XK_Thai_nonu 0x0db9")]
        public const int XK_Thai_nonu = 0x0db9;

        [NativeTypeName("#define XK_Thai_bobaimai 0x0dba")]
        public const int XK_Thai_bobaimai = 0x0dba;

        [NativeTypeName("#define XK_Thai_popla 0x0dbb")]
        public const int XK_Thai_popla = 0x0dbb;

        [NativeTypeName("#define XK_Thai_phophung 0x0dbc")]
        public const int XK_Thai_phophung = 0x0dbc;

        [NativeTypeName("#define XK_Thai_fofa 0x0dbd")]
        public const int XK_Thai_fofa = 0x0dbd;

        [NativeTypeName("#define XK_Thai_phophan 0x0dbe")]
        public const int XK_Thai_phophan = 0x0dbe;

        [NativeTypeName("#define XK_Thai_fofan 0x0dbf")]
        public const int XK_Thai_fofan = 0x0dbf;

        [NativeTypeName("#define XK_Thai_phosamphao 0x0dc0")]
        public const int XK_Thai_phosamphao = 0x0dc0;

        [NativeTypeName("#define XK_Thai_moma 0x0dc1")]
        public const int XK_Thai_moma = 0x0dc1;

        [NativeTypeName("#define XK_Thai_yoyak 0x0dc2")]
        public const int XK_Thai_yoyak = 0x0dc2;

        [NativeTypeName("#define XK_Thai_rorua 0x0dc3")]
        public const int XK_Thai_rorua = 0x0dc3;

        [NativeTypeName("#define XK_Thai_ru 0x0dc4")]
        public const int XK_Thai_ru = 0x0dc4;

        [NativeTypeName("#define XK_Thai_loling 0x0dc5")]
        public const int XK_Thai_loling = 0x0dc5;

        [NativeTypeName("#define XK_Thai_lu 0x0dc6")]
        public const int XK_Thai_lu = 0x0dc6;

        [NativeTypeName("#define XK_Thai_wowaen 0x0dc7")]
        public const int XK_Thai_wowaen = 0x0dc7;

        [NativeTypeName("#define XK_Thai_sosala 0x0dc8")]
        public const int XK_Thai_sosala = 0x0dc8;

        [NativeTypeName("#define XK_Thai_sorusi 0x0dc9")]
        public const int XK_Thai_sorusi = 0x0dc9;

        [NativeTypeName("#define XK_Thai_sosua 0x0dca")]
        public const int XK_Thai_sosua = 0x0dca;

        [NativeTypeName("#define XK_Thai_hohip 0x0dcb")]
        public const int XK_Thai_hohip = 0x0dcb;

        [NativeTypeName("#define XK_Thai_lochula 0x0dcc")]
        public const int XK_Thai_lochula = 0x0dcc;

        [NativeTypeName("#define XK_Thai_oang 0x0dcd")]
        public const int XK_Thai_oang = 0x0dcd;

        [NativeTypeName("#define XK_Thai_honokhuk 0x0dce")]
        public const int XK_Thai_honokhuk = 0x0dce;

        [NativeTypeName("#define XK_Thai_paiyannoi 0x0dcf")]
        public const int XK_Thai_paiyannoi = 0x0dcf;

        [NativeTypeName("#define XK_Thai_saraa 0x0dd0")]
        public const int XK_Thai_saraa = 0x0dd0;

        [NativeTypeName("#define XK_Thai_maihanakat 0x0dd1")]
        public const int XK_Thai_maihanakat = 0x0dd1;

        [NativeTypeName("#define XK_Thai_saraaa 0x0dd2")]
        public const int XK_Thai_saraaa = 0x0dd2;

        [NativeTypeName("#define XK_Thai_saraam 0x0dd3")]
        public const int XK_Thai_saraam = 0x0dd3;

        [NativeTypeName("#define XK_Thai_sarai 0x0dd4")]
        public const int XK_Thai_sarai = 0x0dd4;

        [NativeTypeName("#define XK_Thai_saraii 0x0dd5")]
        public const int XK_Thai_saraii = 0x0dd5;

        [NativeTypeName("#define XK_Thai_saraue 0x0dd6")]
        public const int XK_Thai_saraue = 0x0dd6;

        [NativeTypeName("#define XK_Thai_sarauee 0x0dd7")]
        public const int XK_Thai_sarauee = 0x0dd7;

        [NativeTypeName("#define XK_Thai_sarau 0x0dd8")]
        public const int XK_Thai_sarau = 0x0dd8;

        [NativeTypeName("#define XK_Thai_sarauu 0x0dd9")]
        public const int XK_Thai_sarauu = 0x0dd9;

        [NativeTypeName("#define XK_Thai_phinthu 0x0dda")]
        public const int XK_Thai_phinthu = 0x0dda;

        [NativeTypeName("#define XK_Thai_maihanakat_maitho 0x0dde")]
        public const int XK_Thai_maihanakat_maitho = 0x0dde;

        [NativeTypeName("#define XK_Thai_baht 0x0ddf")]
        public const int XK_Thai_baht = 0x0ddf;

        [NativeTypeName("#define XK_Thai_sarae 0x0de0")]
        public const int XK_Thai_sarae = 0x0de0;

        [NativeTypeName("#define XK_Thai_saraae 0x0de1")]
        public const int XK_Thai_saraae = 0x0de1;

        [NativeTypeName("#define XK_Thai_sarao 0x0de2")]
        public const int XK_Thai_sarao = 0x0de2;

        [NativeTypeName("#define XK_Thai_saraaimaimuan 0x0de3")]
        public const int XK_Thai_saraaimaimuan = 0x0de3;

        [NativeTypeName("#define XK_Thai_saraaimaimalai 0x0de4")]
        public const int XK_Thai_saraaimaimalai = 0x0de4;

        [NativeTypeName("#define XK_Thai_lakkhangyao 0x0de5")]
        public const int XK_Thai_lakkhangyao = 0x0de5;

        [NativeTypeName("#define XK_Thai_maiyamok 0x0de6")]
        public const int XK_Thai_maiyamok = 0x0de6;

        [NativeTypeName("#define XK_Thai_maitaikhu 0x0de7")]
        public const int XK_Thai_maitaikhu = 0x0de7;

        [NativeTypeName("#define XK_Thai_maiek 0x0de8")]
        public const int XK_Thai_maiek = 0x0de8;

        [NativeTypeName("#define XK_Thai_maitho 0x0de9")]
        public const int XK_Thai_maitho = 0x0de9;

        [NativeTypeName("#define XK_Thai_maitri 0x0dea")]
        public const int XK_Thai_maitri = 0x0dea;

        [NativeTypeName("#define XK_Thai_maichattawa 0x0deb")]
        public const int XK_Thai_maichattawa = 0x0deb;

        [NativeTypeName("#define XK_Thai_thanthakhat 0x0dec")]
        public const int XK_Thai_thanthakhat = 0x0dec;

        [NativeTypeName("#define XK_Thai_nikhahit 0x0ded")]
        public const int XK_Thai_nikhahit = 0x0ded;

        [NativeTypeName("#define XK_Thai_leksun 0x0df0")]
        public const int XK_Thai_leksun = 0x0df0;

        [NativeTypeName("#define XK_Thai_leknung 0x0df1")]
        public const int XK_Thai_leknung = 0x0df1;

        [NativeTypeName("#define XK_Thai_leksong 0x0df2")]
        public const int XK_Thai_leksong = 0x0df2;

        [NativeTypeName("#define XK_Thai_leksam 0x0df3")]
        public const int XK_Thai_leksam = 0x0df3;

        [NativeTypeName("#define XK_Thai_leksi 0x0df4")]
        public const int XK_Thai_leksi = 0x0df4;

        [NativeTypeName("#define XK_Thai_lekha 0x0df5")]
        public const int XK_Thai_lekha = 0x0df5;

        [NativeTypeName("#define XK_Thai_lekhok 0x0df6")]
        public const int XK_Thai_lekhok = 0x0df6;

        [NativeTypeName("#define XK_Thai_lekchet 0x0df7")]
        public const int XK_Thai_lekchet = 0x0df7;

        [NativeTypeName("#define XK_Thai_lekpaet 0x0df8")]
        public const int XK_Thai_lekpaet = 0x0df8;

        [NativeTypeName("#define XK_Thai_lekkao 0x0df9")]
        public const int XK_Thai_lekkao = 0x0df9;

        [NativeTypeName("#define XK_Hangul 0xff31")]
        public const int XK_Hangul = 0xff31;

        [NativeTypeName("#define XK_Hangul_Start 0xff32")]
        public const int XK_Hangul_Start = 0xff32;

        [NativeTypeName("#define XK_Hangul_End 0xff33")]
        public const int XK_Hangul_End = 0xff33;

        [NativeTypeName("#define XK_Hangul_Hanja 0xff34")]
        public const int XK_Hangul_Hanja = 0xff34;

        [NativeTypeName("#define XK_Hangul_Jamo 0xff35")]
        public const int XK_Hangul_Jamo = 0xff35;

        [NativeTypeName("#define XK_Hangul_Romaja 0xff36")]
        public const int XK_Hangul_Romaja = 0xff36;

        [NativeTypeName("#define XK_Hangul_Codeinput 0xff37")]
        public const int XK_Hangul_Codeinput = 0xff37;

        [NativeTypeName("#define XK_Hangul_Jeonja 0xff38")]
        public const int XK_Hangul_Jeonja = 0xff38;

        [NativeTypeName("#define XK_Hangul_Banja 0xff39")]
        public const int XK_Hangul_Banja = 0xff39;

        [NativeTypeName("#define XK_Hangul_PreHanja 0xff3a")]
        public const int XK_Hangul_PreHanja = 0xff3a;

        [NativeTypeName("#define XK_Hangul_PostHanja 0xff3b")]
        public const int XK_Hangul_PostHanja = 0xff3b;

        [NativeTypeName("#define XK_Hangul_SingleCandidate 0xff3c")]
        public const int XK_Hangul_SingleCandidate = 0xff3c;

        [NativeTypeName("#define XK_Hangul_MultipleCandidate 0xff3d")]
        public const int XK_Hangul_MultipleCandidate = 0xff3d;

        [NativeTypeName("#define XK_Hangul_PreviousCandidate 0xff3e")]
        public const int XK_Hangul_PreviousCandidate = 0xff3e;

        [NativeTypeName("#define XK_Hangul_Special 0xff3f")]
        public const int XK_Hangul_Special = 0xff3f;

        [NativeTypeName("#define XK_Hangul_switch 0xff7e")]
        public const int XK_Hangul_switch = 0xff7e;

        [NativeTypeName("#define XK_Hangul_Kiyeog 0x0ea1")]
        public const int XK_Hangul_Kiyeog = 0x0ea1;

        [NativeTypeName("#define XK_Hangul_SsangKiyeog 0x0ea2")]
        public const int XK_Hangul_SsangKiyeog = 0x0ea2;

        [NativeTypeName("#define XK_Hangul_KiyeogSios 0x0ea3")]
        public const int XK_Hangul_KiyeogSios = 0x0ea3;

        [NativeTypeName("#define XK_Hangul_Nieun 0x0ea4")]
        public const int XK_Hangul_Nieun = 0x0ea4;

        [NativeTypeName("#define XK_Hangul_NieunJieuj 0x0ea5")]
        public const int XK_Hangul_NieunJieuj = 0x0ea5;

        [NativeTypeName("#define XK_Hangul_NieunHieuh 0x0ea6")]
        public const int XK_Hangul_NieunHieuh = 0x0ea6;

        [NativeTypeName("#define XK_Hangul_Dikeud 0x0ea7")]
        public const int XK_Hangul_Dikeud = 0x0ea7;

        [NativeTypeName("#define XK_Hangul_SsangDikeud 0x0ea8")]
        public const int XK_Hangul_SsangDikeud = 0x0ea8;

        [NativeTypeName("#define XK_Hangul_Rieul 0x0ea9")]
        public const int XK_Hangul_Rieul = 0x0ea9;

        [NativeTypeName("#define XK_Hangul_RieulKiyeog 0x0eaa")]
        public const int XK_Hangul_RieulKiyeog = 0x0eaa;

        [NativeTypeName("#define XK_Hangul_RieulMieum 0x0eab")]
        public const int XK_Hangul_RieulMieum = 0x0eab;

        [NativeTypeName("#define XK_Hangul_RieulPieub 0x0eac")]
        public const int XK_Hangul_RieulPieub = 0x0eac;

        [NativeTypeName("#define XK_Hangul_RieulSios 0x0ead")]
        public const int XK_Hangul_RieulSios = 0x0ead;

        [NativeTypeName("#define XK_Hangul_RieulTieut 0x0eae")]
        public const int XK_Hangul_RieulTieut = 0x0eae;

        [NativeTypeName("#define XK_Hangul_RieulPhieuf 0x0eaf")]
        public const int XK_Hangul_RieulPhieuf = 0x0eaf;

        [NativeTypeName("#define XK_Hangul_RieulHieuh 0x0eb0")]
        public const int XK_Hangul_RieulHieuh = 0x0eb0;

        [NativeTypeName("#define XK_Hangul_Mieum 0x0eb1")]
        public const int XK_Hangul_Mieum = 0x0eb1;

        [NativeTypeName("#define XK_Hangul_Pieub 0x0eb2")]
        public const int XK_Hangul_Pieub = 0x0eb2;

        [NativeTypeName("#define XK_Hangul_SsangPieub 0x0eb3")]
        public const int XK_Hangul_SsangPieub = 0x0eb3;

        [NativeTypeName("#define XK_Hangul_PieubSios 0x0eb4")]
        public const int XK_Hangul_PieubSios = 0x0eb4;

        [NativeTypeName("#define XK_Hangul_Sios 0x0eb5")]
        public const int XK_Hangul_Sios = 0x0eb5;

        [NativeTypeName("#define XK_Hangul_SsangSios 0x0eb6")]
        public const int XK_Hangul_SsangSios = 0x0eb6;

        [NativeTypeName("#define XK_Hangul_Ieung 0x0eb7")]
        public const int XK_Hangul_Ieung = 0x0eb7;

        [NativeTypeName("#define XK_Hangul_Jieuj 0x0eb8")]
        public const int XK_Hangul_Jieuj = 0x0eb8;

        [NativeTypeName("#define XK_Hangul_SsangJieuj 0x0eb9")]
        public const int XK_Hangul_SsangJieuj = 0x0eb9;

        [NativeTypeName("#define XK_Hangul_Cieuc 0x0eba")]
        public const int XK_Hangul_Cieuc = 0x0eba;

        [NativeTypeName("#define XK_Hangul_Khieuq 0x0ebb")]
        public const int XK_Hangul_Khieuq = 0x0ebb;

        [NativeTypeName("#define XK_Hangul_Tieut 0x0ebc")]
        public const int XK_Hangul_Tieut = 0x0ebc;

        [NativeTypeName("#define XK_Hangul_Phieuf 0x0ebd")]
        public const int XK_Hangul_Phieuf = 0x0ebd;

        [NativeTypeName("#define XK_Hangul_Hieuh 0x0ebe")]
        public const int XK_Hangul_Hieuh = 0x0ebe;

        [NativeTypeName("#define XK_Hangul_A 0x0ebf")]
        public const int XK_Hangul_A = 0x0ebf;

        [NativeTypeName("#define XK_Hangul_AE 0x0ec0")]
        public const int XK_Hangul_AE = 0x0ec0;

        [NativeTypeName("#define XK_Hangul_YA 0x0ec1")]
        public const int XK_Hangul_YA = 0x0ec1;

        [NativeTypeName("#define XK_Hangul_YAE 0x0ec2")]
        public const int XK_Hangul_YAE = 0x0ec2;

        [NativeTypeName("#define XK_Hangul_EO 0x0ec3")]
        public const int XK_Hangul_EO = 0x0ec3;

        [NativeTypeName("#define XK_Hangul_E 0x0ec4")]
        public const int XK_Hangul_E = 0x0ec4;

        [NativeTypeName("#define XK_Hangul_YEO 0x0ec5")]
        public const int XK_Hangul_YEO = 0x0ec5;

        [NativeTypeName("#define XK_Hangul_YE 0x0ec6")]
        public const int XK_Hangul_YE = 0x0ec6;

        [NativeTypeName("#define XK_Hangul_O 0x0ec7")]
        public const int XK_Hangul_O = 0x0ec7;

        [NativeTypeName("#define XK_Hangul_WA 0x0ec8")]
        public const int XK_Hangul_WA = 0x0ec8;

        [NativeTypeName("#define XK_Hangul_WAE 0x0ec9")]
        public const int XK_Hangul_WAE = 0x0ec9;

        [NativeTypeName("#define XK_Hangul_OE 0x0eca")]
        public const int XK_Hangul_OE = 0x0eca;

        [NativeTypeName("#define XK_Hangul_YO 0x0ecb")]
        public const int XK_Hangul_YO = 0x0ecb;

        [NativeTypeName("#define XK_Hangul_U 0x0ecc")]
        public const int XK_Hangul_U = 0x0ecc;

        [NativeTypeName("#define XK_Hangul_WEO 0x0ecd")]
        public const int XK_Hangul_WEO = 0x0ecd;

        [NativeTypeName("#define XK_Hangul_WE 0x0ece")]
        public const int XK_Hangul_WE = 0x0ece;

        [NativeTypeName("#define XK_Hangul_WI 0x0ecf")]
        public const int XK_Hangul_WI = 0x0ecf;

        [NativeTypeName("#define XK_Hangul_YU 0x0ed0")]
        public const int XK_Hangul_YU = 0x0ed0;

        [NativeTypeName("#define XK_Hangul_EU 0x0ed1")]
        public const int XK_Hangul_EU = 0x0ed1;

        [NativeTypeName("#define XK_Hangul_YI 0x0ed2")]
        public const int XK_Hangul_YI = 0x0ed2;

        [NativeTypeName("#define XK_Hangul_I 0x0ed3")]
        public const int XK_Hangul_I = 0x0ed3;

        [NativeTypeName("#define XK_Hangul_J_Kiyeog 0x0ed4")]
        public const int XK_Hangul_J_Kiyeog = 0x0ed4;

        [NativeTypeName("#define XK_Hangul_J_SsangKiyeog 0x0ed5")]
        public const int XK_Hangul_J_SsangKiyeog = 0x0ed5;

        [NativeTypeName("#define XK_Hangul_J_KiyeogSios 0x0ed6")]
        public const int XK_Hangul_J_KiyeogSios = 0x0ed6;

        [NativeTypeName("#define XK_Hangul_J_Nieun 0x0ed7")]
        public const int XK_Hangul_J_Nieun = 0x0ed7;

        [NativeTypeName("#define XK_Hangul_J_NieunJieuj 0x0ed8")]
        public const int XK_Hangul_J_NieunJieuj = 0x0ed8;

        [NativeTypeName("#define XK_Hangul_J_NieunHieuh 0x0ed9")]
        public const int XK_Hangul_J_NieunHieuh = 0x0ed9;

        [NativeTypeName("#define XK_Hangul_J_Dikeud 0x0eda")]
        public const int XK_Hangul_J_Dikeud = 0x0eda;

        [NativeTypeName("#define XK_Hangul_J_Rieul 0x0edb")]
        public const int XK_Hangul_J_Rieul = 0x0edb;

        [NativeTypeName("#define XK_Hangul_J_RieulKiyeog 0x0edc")]
        public const int XK_Hangul_J_RieulKiyeog = 0x0edc;

        [NativeTypeName("#define XK_Hangul_J_RieulMieum 0x0edd")]
        public const int XK_Hangul_J_RieulMieum = 0x0edd;

        [NativeTypeName("#define XK_Hangul_J_RieulPieub 0x0ede")]
        public const int XK_Hangul_J_RieulPieub = 0x0ede;

        [NativeTypeName("#define XK_Hangul_J_RieulSios 0x0edf")]
        public const int XK_Hangul_J_RieulSios = 0x0edf;

        [NativeTypeName("#define XK_Hangul_J_RieulTieut 0x0ee0")]
        public const int XK_Hangul_J_RieulTieut = 0x0ee0;

        [NativeTypeName("#define XK_Hangul_J_RieulPhieuf 0x0ee1")]
        public const int XK_Hangul_J_RieulPhieuf = 0x0ee1;

        [NativeTypeName("#define XK_Hangul_J_RieulHieuh 0x0ee2")]
        public const int XK_Hangul_J_RieulHieuh = 0x0ee2;

        [NativeTypeName("#define XK_Hangul_J_Mieum 0x0ee3")]
        public const int XK_Hangul_J_Mieum = 0x0ee3;

        [NativeTypeName("#define XK_Hangul_J_Pieub 0x0ee4")]
        public const int XK_Hangul_J_Pieub = 0x0ee4;

        [NativeTypeName("#define XK_Hangul_J_PieubSios 0x0ee5")]
        public const int XK_Hangul_J_PieubSios = 0x0ee5;

        [NativeTypeName("#define XK_Hangul_J_Sios 0x0ee6")]
        public const int XK_Hangul_J_Sios = 0x0ee6;

        [NativeTypeName("#define XK_Hangul_J_SsangSios 0x0ee7")]
        public const int XK_Hangul_J_SsangSios = 0x0ee7;

        [NativeTypeName("#define XK_Hangul_J_Ieung 0x0ee8")]
        public const int XK_Hangul_J_Ieung = 0x0ee8;

        [NativeTypeName("#define XK_Hangul_J_Jieuj 0x0ee9")]
        public const int XK_Hangul_J_Jieuj = 0x0ee9;

        [NativeTypeName("#define XK_Hangul_J_Cieuc 0x0eea")]
        public const int XK_Hangul_J_Cieuc = 0x0eea;

        [NativeTypeName("#define XK_Hangul_J_Khieuq 0x0eeb")]
        public const int XK_Hangul_J_Khieuq = 0x0eeb;

        [NativeTypeName("#define XK_Hangul_J_Tieut 0x0eec")]
        public const int XK_Hangul_J_Tieut = 0x0eec;

        [NativeTypeName("#define XK_Hangul_J_Phieuf 0x0eed")]
        public const int XK_Hangul_J_Phieuf = 0x0eed;

        [NativeTypeName("#define XK_Hangul_J_Hieuh 0x0eee")]
        public const int XK_Hangul_J_Hieuh = 0x0eee;

        [NativeTypeName("#define XK_Hangul_RieulYeorinHieuh 0x0eef")]
        public const int XK_Hangul_RieulYeorinHieuh = 0x0eef;

        [NativeTypeName("#define XK_Hangul_SunkyeongeumMieum 0x0ef0")]
        public const int XK_Hangul_SunkyeongeumMieum = 0x0ef0;

        [NativeTypeName("#define XK_Hangul_SunkyeongeumPieub 0x0ef1")]
        public const int XK_Hangul_SunkyeongeumPieub = 0x0ef1;

        [NativeTypeName("#define XK_Hangul_PanSios 0x0ef2")]
        public const int XK_Hangul_PanSios = 0x0ef2;

        [NativeTypeName("#define XK_Hangul_KkogjiDalrinIeung 0x0ef3")]
        public const int XK_Hangul_KkogjiDalrinIeung = 0x0ef3;

        [NativeTypeName("#define XK_Hangul_SunkyeongeumPhieuf 0x0ef4")]
        public const int XK_Hangul_SunkyeongeumPhieuf = 0x0ef4;

        [NativeTypeName("#define XK_Hangul_YeorinHieuh 0x0ef5")]
        public const int XK_Hangul_YeorinHieuh = 0x0ef5;

        [NativeTypeName("#define XK_Hangul_AraeA 0x0ef6")]
        public const int XK_Hangul_AraeA = 0x0ef6;

        [NativeTypeName("#define XK_Hangul_AraeAE 0x0ef7")]
        public const int XK_Hangul_AraeAE = 0x0ef7;

        [NativeTypeName("#define XK_Hangul_J_PanSios 0x0ef8")]
        public const int XK_Hangul_J_PanSios = 0x0ef8;

        [NativeTypeName("#define XK_Hangul_J_KkogjiDalrinIeung 0x0ef9")]
        public const int XK_Hangul_J_KkogjiDalrinIeung = 0x0ef9;

        [NativeTypeName("#define XK_Hangul_J_YeorinHieuh 0x0efa")]
        public const int XK_Hangul_J_YeorinHieuh = 0x0efa;

        [NativeTypeName("#define XK_Korean_Won 0x0eff")]
        public const int XK_Korean_Won = 0x0eff;

        [NativeTypeName("#define XK_Armenian_ligature_ew 0x1000587")]
        public const int XK_Armenian_ligature_ew = 0x1000587;

        [NativeTypeName("#define XK_Armenian_full_stop 0x1000589")]
        public const int XK_Armenian_full_stop = 0x1000589;

        [NativeTypeName("#define XK_Armenian_verjaket 0x1000589")]
        public const int XK_Armenian_verjaket = 0x1000589;

        [NativeTypeName("#define XK_Armenian_separation_mark 0x100055d")]
        public const int XK_Armenian_separation_mark = 0x100055d;

        [NativeTypeName("#define XK_Armenian_but 0x100055d")]
        public const int XK_Armenian_but = 0x100055d;

        [NativeTypeName("#define XK_Armenian_hyphen 0x100058a")]
        public const int XK_Armenian_hyphen = 0x100058a;

        [NativeTypeName("#define XK_Armenian_yentamna 0x100058a")]
        public const int XK_Armenian_yentamna = 0x100058a;

        [NativeTypeName("#define XK_Armenian_exclam 0x100055c")]
        public const int XK_Armenian_exclam = 0x100055c;

        [NativeTypeName("#define XK_Armenian_amanak 0x100055c")]
        public const int XK_Armenian_amanak = 0x100055c;

        [NativeTypeName("#define XK_Armenian_accent 0x100055b")]
        public const int XK_Armenian_accent = 0x100055b;

        [NativeTypeName("#define XK_Armenian_shesht 0x100055b")]
        public const int XK_Armenian_shesht = 0x100055b;

        [NativeTypeName("#define XK_Armenian_question 0x100055e")]
        public const int XK_Armenian_question = 0x100055e;

        [NativeTypeName("#define XK_Armenian_paruyk 0x100055e")]
        public const int XK_Armenian_paruyk = 0x100055e;

        [NativeTypeName("#define XK_Armenian_AYB 0x1000531")]
        public const int XK_Armenian_AYB = 0x1000531;

        [NativeTypeName("#define XK_Armenian_ayb 0x1000561")]
        public const int XK_Armenian_ayb = 0x1000561;

        [NativeTypeName("#define XK_Armenian_BEN 0x1000532")]
        public const int XK_Armenian_BEN = 0x1000532;

        [NativeTypeName("#define XK_Armenian_ben 0x1000562")]
        public const int XK_Armenian_ben = 0x1000562;

        [NativeTypeName("#define XK_Armenian_GIM 0x1000533")]
        public const int XK_Armenian_GIM = 0x1000533;

        [NativeTypeName("#define XK_Armenian_gim 0x1000563")]
        public const int XK_Armenian_gim = 0x1000563;

        [NativeTypeName("#define XK_Armenian_DA 0x1000534")]
        public const int XK_Armenian_DA = 0x1000534;

        [NativeTypeName("#define XK_Armenian_da 0x1000564")]
        public const int XK_Armenian_da = 0x1000564;

        [NativeTypeName("#define XK_Armenian_YECH 0x1000535")]
        public const int XK_Armenian_YECH = 0x1000535;

        [NativeTypeName("#define XK_Armenian_yech 0x1000565")]
        public const int XK_Armenian_yech = 0x1000565;

        [NativeTypeName("#define XK_Armenian_ZA 0x1000536")]
        public const int XK_Armenian_ZA = 0x1000536;

        [NativeTypeName("#define XK_Armenian_za 0x1000566")]
        public const int XK_Armenian_za = 0x1000566;

        [NativeTypeName("#define XK_Armenian_E 0x1000537")]
        public const int XK_Armenian_E = 0x1000537;

        [NativeTypeName("#define XK_Armenian_e 0x1000567")]
        public const int XK_Armenian_e = 0x1000567;

        [NativeTypeName("#define XK_Armenian_AT 0x1000538")]
        public const int XK_Armenian_AT = 0x1000538;

        [NativeTypeName("#define XK_Armenian_at 0x1000568")]
        public const int XK_Armenian_at = 0x1000568;

        [NativeTypeName("#define XK_Armenian_TO 0x1000539")]
        public const int XK_Armenian_TO = 0x1000539;

        [NativeTypeName("#define XK_Armenian_to 0x1000569")]
        public const int XK_Armenian_to = 0x1000569;

        [NativeTypeName("#define XK_Armenian_ZHE 0x100053a")]
        public const int XK_Armenian_ZHE = 0x100053a;

        [NativeTypeName("#define XK_Armenian_zhe 0x100056a")]
        public const int XK_Armenian_zhe = 0x100056a;

        [NativeTypeName("#define XK_Armenian_INI 0x100053b")]
        public const int XK_Armenian_INI = 0x100053b;

        [NativeTypeName("#define XK_Armenian_ini 0x100056b")]
        public const int XK_Armenian_ini = 0x100056b;

        [NativeTypeName("#define XK_Armenian_LYUN 0x100053c")]
        public const int XK_Armenian_LYUN = 0x100053c;

        [NativeTypeName("#define XK_Armenian_lyun 0x100056c")]
        public const int XK_Armenian_lyun = 0x100056c;

        [NativeTypeName("#define XK_Armenian_KHE 0x100053d")]
        public const int XK_Armenian_KHE = 0x100053d;

        [NativeTypeName("#define XK_Armenian_khe 0x100056d")]
        public const int XK_Armenian_khe = 0x100056d;

        [NativeTypeName("#define XK_Armenian_TSA 0x100053e")]
        public const int XK_Armenian_TSA = 0x100053e;

        [NativeTypeName("#define XK_Armenian_tsa 0x100056e")]
        public const int XK_Armenian_tsa = 0x100056e;

        [NativeTypeName("#define XK_Armenian_KEN 0x100053f")]
        public const int XK_Armenian_KEN = 0x100053f;

        [NativeTypeName("#define XK_Armenian_ken 0x100056f")]
        public const int XK_Armenian_ken = 0x100056f;

        [NativeTypeName("#define XK_Armenian_HO 0x1000540")]
        public const int XK_Armenian_HO = 0x1000540;

        [NativeTypeName("#define XK_Armenian_ho 0x1000570")]
        public const int XK_Armenian_ho = 0x1000570;

        [NativeTypeName("#define XK_Armenian_DZA 0x1000541")]
        public const int XK_Armenian_DZA = 0x1000541;

        [NativeTypeName("#define XK_Armenian_dza 0x1000571")]
        public const int XK_Armenian_dza = 0x1000571;

        [NativeTypeName("#define XK_Armenian_GHAT 0x1000542")]
        public const int XK_Armenian_GHAT = 0x1000542;

        [NativeTypeName("#define XK_Armenian_ghat 0x1000572")]
        public const int XK_Armenian_ghat = 0x1000572;

        [NativeTypeName("#define XK_Armenian_TCHE 0x1000543")]
        public const int XK_Armenian_TCHE = 0x1000543;

        [NativeTypeName("#define XK_Armenian_tche 0x1000573")]
        public const int XK_Armenian_tche = 0x1000573;

        [NativeTypeName("#define XK_Armenian_MEN 0x1000544")]
        public const int XK_Armenian_MEN = 0x1000544;

        [NativeTypeName("#define XK_Armenian_men 0x1000574")]
        public const int XK_Armenian_men = 0x1000574;

        [NativeTypeName("#define XK_Armenian_HI 0x1000545")]
        public const int XK_Armenian_HI = 0x1000545;

        [NativeTypeName("#define XK_Armenian_hi 0x1000575")]
        public const int XK_Armenian_hi = 0x1000575;

        [NativeTypeName("#define XK_Armenian_NU 0x1000546")]
        public const int XK_Armenian_NU = 0x1000546;

        [NativeTypeName("#define XK_Armenian_nu 0x1000576")]
        public const int XK_Armenian_nu = 0x1000576;

        [NativeTypeName("#define XK_Armenian_SHA 0x1000547")]
        public const int XK_Armenian_SHA = 0x1000547;

        [NativeTypeName("#define XK_Armenian_sha 0x1000577")]
        public const int XK_Armenian_sha = 0x1000577;

        [NativeTypeName("#define XK_Armenian_VO 0x1000548")]
        public const int XK_Armenian_VO = 0x1000548;

        [NativeTypeName("#define XK_Armenian_vo 0x1000578")]
        public const int XK_Armenian_vo = 0x1000578;

        [NativeTypeName("#define XK_Armenian_CHA 0x1000549")]
        public const int XK_Armenian_CHA = 0x1000549;

        [NativeTypeName("#define XK_Armenian_cha 0x1000579")]
        public const int XK_Armenian_cha = 0x1000579;

        [NativeTypeName("#define XK_Armenian_PE 0x100054a")]
        public const int XK_Armenian_PE = 0x100054a;

        [NativeTypeName("#define XK_Armenian_pe 0x100057a")]
        public const int XK_Armenian_pe = 0x100057a;

        [NativeTypeName("#define XK_Armenian_JE 0x100054b")]
        public const int XK_Armenian_JE = 0x100054b;

        [NativeTypeName("#define XK_Armenian_je 0x100057b")]
        public const int XK_Armenian_je = 0x100057b;

        [NativeTypeName("#define XK_Armenian_RA 0x100054c")]
        public const int XK_Armenian_RA = 0x100054c;

        [NativeTypeName("#define XK_Armenian_ra 0x100057c")]
        public const int XK_Armenian_ra = 0x100057c;

        [NativeTypeName("#define XK_Armenian_SE 0x100054d")]
        public const int XK_Armenian_SE = 0x100054d;

        [NativeTypeName("#define XK_Armenian_se 0x100057d")]
        public const int XK_Armenian_se = 0x100057d;

        [NativeTypeName("#define XK_Armenian_VEV 0x100054e")]
        public const int XK_Armenian_VEV = 0x100054e;

        [NativeTypeName("#define XK_Armenian_vev 0x100057e")]
        public const int XK_Armenian_vev = 0x100057e;

        [NativeTypeName("#define XK_Armenian_TYUN 0x100054f")]
        public const int XK_Armenian_TYUN = 0x100054f;

        [NativeTypeName("#define XK_Armenian_tyun 0x100057f")]
        public const int XK_Armenian_tyun = 0x100057f;

        [NativeTypeName("#define XK_Armenian_RE 0x1000550")]
        public const int XK_Armenian_RE = 0x1000550;

        [NativeTypeName("#define XK_Armenian_re 0x1000580")]
        public const int XK_Armenian_re = 0x1000580;

        [NativeTypeName("#define XK_Armenian_TSO 0x1000551")]
        public const int XK_Armenian_TSO = 0x1000551;

        [NativeTypeName("#define XK_Armenian_tso 0x1000581")]
        public const int XK_Armenian_tso = 0x1000581;

        [NativeTypeName("#define XK_Armenian_VYUN 0x1000552")]
        public const int XK_Armenian_VYUN = 0x1000552;

        [NativeTypeName("#define XK_Armenian_vyun 0x1000582")]
        public const int XK_Armenian_vyun = 0x1000582;

        [NativeTypeName("#define XK_Armenian_PYUR 0x1000553")]
        public const int XK_Armenian_PYUR = 0x1000553;

        [NativeTypeName("#define XK_Armenian_pyur 0x1000583")]
        public const int XK_Armenian_pyur = 0x1000583;

        [NativeTypeName("#define XK_Armenian_KE 0x1000554")]
        public const int XK_Armenian_KE = 0x1000554;

        [NativeTypeName("#define XK_Armenian_ke 0x1000584")]
        public const int XK_Armenian_ke = 0x1000584;

        [NativeTypeName("#define XK_Armenian_O 0x1000555")]
        public const int XK_Armenian_O = 0x1000555;

        [NativeTypeName("#define XK_Armenian_o 0x1000585")]
        public const int XK_Armenian_o = 0x1000585;

        [NativeTypeName("#define XK_Armenian_FE 0x1000556")]
        public const int XK_Armenian_FE = 0x1000556;

        [NativeTypeName("#define XK_Armenian_fe 0x1000586")]
        public const int XK_Armenian_fe = 0x1000586;

        [NativeTypeName("#define XK_Armenian_apostrophe 0x100055a")]
        public const int XK_Armenian_apostrophe = 0x100055a;

        [NativeTypeName("#define XK_Georgian_an 0x10010d0")]
        public const int XK_Georgian_an = 0x10010d0;

        [NativeTypeName("#define XK_Georgian_ban 0x10010d1")]
        public const int XK_Georgian_ban = 0x10010d1;

        [NativeTypeName("#define XK_Georgian_gan 0x10010d2")]
        public const int XK_Georgian_gan = 0x10010d2;

        [NativeTypeName("#define XK_Georgian_don 0x10010d3")]
        public const int XK_Georgian_don = 0x10010d3;

        [NativeTypeName("#define XK_Georgian_en 0x10010d4")]
        public const int XK_Georgian_en = 0x10010d4;

        [NativeTypeName("#define XK_Georgian_vin 0x10010d5")]
        public const int XK_Georgian_vin = 0x10010d5;

        [NativeTypeName("#define XK_Georgian_zen 0x10010d6")]
        public const int XK_Georgian_zen = 0x10010d6;

        [NativeTypeName("#define XK_Georgian_tan 0x10010d7")]
        public const int XK_Georgian_tan = 0x10010d7;

        [NativeTypeName("#define XK_Georgian_in 0x10010d8")]
        public const int XK_Georgian_in = 0x10010d8;

        [NativeTypeName("#define XK_Georgian_kan 0x10010d9")]
        public const int XK_Georgian_kan = 0x10010d9;

        [NativeTypeName("#define XK_Georgian_las 0x10010da")]
        public const int XK_Georgian_las = 0x10010da;

        [NativeTypeName("#define XK_Georgian_man 0x10010db")]
        public const int XK_Georgian_man = 0x10010db;

        [NativeTypeName("#define XK_Georgian_nar 0x10010dc")]
        public const int XK_Georgian_nar = 0x10010dc;

        [NativeTypeName("#define XK_Georgian_on 0x10010dd")]
        public const int XK_Georgian_on = 0x10010dd;

        [NativeTypeName("#define XK_Georgian_par 0x10010de")]
        public const int XK_Georgian_par = 0x10010de;

        [NativeTypeName("#define XK_Georgian_zhar 0x10010df")]
        public const int XK_Georgian_zhar = 0x10010df;

        [NativeTypeName("#define XK_Georgian_rae 0x10010e0")]
        public const int XK_Georgian_rae = 0x10010e0;

        [NativeTypeName("#define XK_Georgian_san 0x10010e1")]
        public const int XK_Georgian_san = 0x10010e1;

        [NativeTypeName("#define XK_Georgian_tar 0x10010e2")]
        public const int XK_Georgian_tar = 0x10010e2;

        [NativeTypeName("#define XK_Georgian_un 0x10010e3")]
        public const int XK_Georgian_un = 0x10010e3;

        [NativeTypeName("#define XK_Georgian_phar 0x10010e4")]
        public const int XK_Georgian_phar = 0x10010e4;

        [NativeTypeName("#define XK_Georgian_khar 0x10010e5")]
        public const int XK_Georgian_khar = 0x10010e5;

        [NativeTypeName("#define XK_Georgian_ghan 0x10010e6")]
        public const int XK_Georgian_ghan = 0x10010e6;

        [NativeTypeName("#define XK_Georgian_qar 0x10010e7")]
        public const int XK_Georgian_qar = 0x10010e7;

        [NativeTypeName("#define XK_Georgian_shin 0x10010e8")]
        public const int XK_Georgian_shin = 0x10010e8;

        [NativeTypeName("#define XK_Georgian_chin 0x10010e9")]
        public const int XK_Georgian_chin = 0x10010e9;

        [NativeTypeName("#define XK_Georgian_can 0x10010ea")]
        public const int XK_Georgian_can = 0x10010ea;

        [NativeTypeName("#define XK_Georgian_jil 0x10010eb")]
        public const int XK_Georgian_jil = 0x10010eb;

        [NativeTypeName("#define XK_Georgian_cil 0x10010ec")]
        public const int XK_Georgian_cil = 0x10010ec;

        [NativeTypeName("#define XK_Georgian_char 0x10010ed")]
        public const int XK_Georgian_char = 0x10010ed;

        [NativeTypeName("#define XK_Georgian_xan 0x10010ee")]
        public const int XK_Georgian_xan = 0x10010ee;

        [NativeTypeName("#define XK_Georgian_jhan 0x10010ef")]
        public const int XK_Georgian_jhan = 0x10010ef;

        [NativeTypeName("#define XK_Georgian_hae 0x10010f0")]
        public const int XK_Georgian_hae = 0x10010f0;

        [NativeTypeName("#define XK_Georgian_he 0x10010f1")]
        public const int XK_Georgian_he = 0x10010f1;

        [NativeTypeName("#define XK_Georgian_hie 0x10010f2")]
        public const int XK_Georgian_hie = 0x10010f2;

        [NativeTypeName("#define XK_Georgian_we 0x10010f3")]
        public const int XK_Georgian_we = 0x10010f3;

        [NativeTypeName("#define XK_Georgian_har 0x10010f4")]
        public const int XK_Georgian_har = 0x10010f4;

        [NativeTypeName("#define XK_Georgian_hoe 0x10010f5")]
        public const int XK_Georgian_hoe = 0x10010f5;

        [NativeTypeName("#define XK_Georgian_fi 0x10010f6")]
        public const int XK_Georgian_fi = 0x10010f6;

        [NativeTypeName("#define XK_Xabovedot 0x1001e8a")]
        public const int XK_Xabovedot = 0x1001e8a;

        [NativeTypeName("#define XK_Ibreve 0x100012c")]
        public const int XK_Ibreve = 0x100012c;

        [NativeTypeName("#define XK_Zstroke 0x10001b5")]
        public const int XK_Zstroke = 0x10001b5;

        [NativeTypeName("#define XK_Gcaron 0x10001e6")]
        public const int XK_Gcaron = 0x10001e6;

        [NativeTypeName("#define XK_Ocaron 0x10001d1")]
        public const int XK_Ocaron = 0x10001d1;

        [NativeTypeName("#define XK_Obarred 0x100019f")]
        public const int XK_Obarred = 0x100019f;

        [NativeTypeName("#define XK_xabovedot 0x1001e8b")]
        public const int XK_xabovedot = 0x1001e8b;

        [NativeTypeName("#define XK_ibreve 0x100012d")]
        public const int XK_ibreve = 0x100012d;

        [NativeTypeName("#define XK_zstroke 0x10001b6")]
        public const int XK_zstroke = 0x10001b6;

        [NativeTypeName("#define XK_gcaron 0x10001e7")]
        public const int XK_gcaron = 0x10001e7;

        [NativeTypeName("#define XK_ocaron 0x10001d2")]
        public const int XK_ocaron = 0x10001d2;

        [NativeTypeName("#define XK_obarred 0x1000275")]
        public const int XK_obarred = 0x1000275;

        [NativeTypeName("#define XK_SCHWA 0x100018f")]
        public const int XK_SCHWA = 0x100018f;

        [NativeTypeName("#define XK_schwa 0x1000259")]
        public const int XK_schwa = 0x1000259;

        [NativeTypeName("#define XK_EZH 0x10001b7")]
        public const int XK_EZH = 0x10001b7;

        [NativeTypeName("#define XK_ezh 0x1000292")]
        public const int XK_ezh = 0x1000292;

        [NativeTypeName("#define XK_Lbelowdot 0x1001e36")]
        public const int XK_Lbelowdot = 0x1001e36;

        [NativeTypeName("#define XK_lbelowdot 0x1001e37")]
        public const int XK_lbelowdot = 0x1001e37;

        [NativeTypeName("#define XK_Abelowdot 0x1001ea0")]
        public const int XK_Abelowdot = 0x1001ea0;

        [NativeTypeName("#define XK_abelowdot 0x1001ea1")]
        public const int XK_abelowdot = 0x1001ea1;

        [NativeTypeName("#define XK_Ahook 0x1001ea2")]
        public const int XK_Ahook = 0x1001ea2;

        [NativeTypeName("#define XK_ahook 0x1001ea3")]
        public const int XK_ahook = 0x1001ea3;

        [NativeTypeName("#define XK_Acircumflexacute 0x1001ea4")]
        public const int XK_Acircumflexacute = 0x1001ea4;

        [NativeTypeName("#define XK_acircumflexacute 0x1001ea5")]
        public const int XK_acircumflexacute = 0x1001ea5;

        [NativeTypeName("#define XK_Acircumflexgrave 0x1001ea6")]
        public const int XK_Acircumflexgrave = 0x1001ea6;

        [NativeTypeName("#define XK_acircumflexgrave 0x1001ea7")]
        public const int XK_acircumflexgrave = 0x1001ea7;

        [NativeTypeName("#define XK_Acircumflexhook 0x1001ea8")]
        public const int XK_Acircumflexhook = 0x1001ea8;

        [NativeTypeName("#define XK_acircumflexhook 0x1001ea9")]
        public const int XK_acircumflexhook = 0x1001ea9;

        [NativeTypeName("#define XK_Acircumflextilde 0x1001eaa")]
        public const int XK_Acircumflextilde = 0x1001eaa;

        [NativeTypeName("#define XK_acircumflextilde 0x1001eab")]
        public const int XK_acircumflextilde = 0x1001eab;

        [NativeTypeName("#define XK_Acircumflexbelowdot 0x1001eac")]
        public const int XK_Acircumflexbelowdot = 0x1001eac;

        [NativeTypeName("#define XK_acircumflexbelowdot 0x1001ead")]
        public const int XK_acircumflexbelowdot = 0x1001ead;

        [NativeTypeName("#define XK_Abreveacute 0x1001eae")]
        public const int XK_Abreveacute = 0x1001eae;

        [NativeTypeName("#define XK_abreveacute 0x1001eaf")]
        public const int XK_abreveacute = 0x1001eaf;

        [NativeTypeName("#define XK_Abrevegrave 0x1001eb0")]
        public const int XK_Abrevegrave = 0x1001eb0;

        [NativeTypeName("#define XK_abrevegrave 0x1001eb1")]
        public const int XK_abrevegrave = 0x1001eb1;

        [NativeTypeName("#define XK_Abrevehook 0x1001eb2")]
        public const int XK_Abrevehook = 0x1001eb2;

        [NativeTypeName("#define XK_abrevehook 0x1001eb3")]
        public const int XK_abrevehook = 0x1001eb3;

        [NativeTypeName("#define XK_Abrevetilde 0x1001eb4")]
        public const int XK_Abrevetilde = 0x1001eb4;

        [NativeTypeName("#define XK_abrevetilde 0x1001eb5")]
        public const int XK_abrevetilde = 0x1001eb5;

        [NativeTypeName("#define XK_Abrevebelowdot 0x1001eb6")]
        public const int XK_Abrevebelowdot = 0x1001eb6;

        [NativeTypeName("#define XK_abrevebelowdot 0x1001eb7")]
        public const int XK_abrevebelowdot = 0x1001eb7;

        [NativeTypeName("#define XK_Ebelowdot 0x1001eb8")]
        public const int XK_Ebelowdot = 0x1001eb8;

        [NativeTypeName("#define XK_ebelowdot 0x1001eb9")]
        public const int XK_ebelowdot = 0x1001eb9;

        [NativeTypeName("#define XK_Ehook 0x1001eba")]
        public const int XK_Ehook = 0x1001eba;

        [NativeTypeName("#define XK_ehook 0x1001ebb")]
        public const int XK_ehook = 0x1001ebb;

        [NativeTypeName("#define XK_Etilde 0x1001ebc")]
        public const int XK_Etilde = 0x1001ebc;

        [NativeTypeName("#define XK_etilde 0x1001ebd")]
        public const int XK_etilde = 0x1001ebd;

        [NativeTypeName("#define XK_Ecircumflexacute 0x1001ebe")]
        public const int XK_Ecircumflexacute = 0x1001ebe;

        [NativeTypeName("#define XK_ecircumflexacute 0x1001ebf")]
        public const int XK_ecircumflexacute = 0x1001ebf;

        [NativeTypeName("#define XK_Ecircumflexgrave 0x1001ec0")]
        public const int XK_Ecircumflexgrave = 0x1001ec0;

        [NativeTypeName("#define XK_ecircumflexgrave 0x1001ec1")]
        public const int XK_ecircumflexgrave = 0x1001ec1;

        [NativeTypeName("#define XK_Ecircumflexhook 0x1001ec2")]
        public const int XK_Ecircumflexhook = 0x1001ec2;

        [NativeTypeName("#define XK_ecircumflexhook 0x1001ec3")]
        public const int XK_ecircumflexhook = 0x1001ec3;

        [NativeTypeName("#define XK_Ecircumflextilde 0x1001ec4")]
        public const int XK_Ecircumflextilde = 0x1001ec4;

        [NativeTypeName("#define XK_ecircumflextilde 0x1001ec5")]
        public const int XK_ecircumflextilde = 0x1001ec5;

        [NativeTypeName("#define XK_Ecircumflexbelowdot 0x1001ec6")]
        public const int XK_Ecircumflexbelowdot = 0x1001ec6;

        [NativeTypeName("#define XK_ecircumflexbelowdot 0x1001ec7")]
        public const int XK_ecircumflexbelowdot = 0x1001ec7;

        [NativeTypeName("#define XK_Ihook 0x1001ec8")]
        public const int XK_Ihook = 0x1001ec8;

        [NativeTypeName("#define XK_ihook 0x1001ec9")]
        public const int XK_ihook = 0x1001ec9;

        [NativeTypeName("#define XK_Ibelowdot 0x1001eca")]
        public const int XK_Ibelowdot = 0x1001eca;

        [NativeTypeName("#define XK_ibelowdot 0x1001ecb")]
        public const int XK_ibelowdot = 0x1001ecb;

        [NativeTypeName("#define XK_Obelowdot 0x1001ecc")]
        public const int XK_Obelowdot = 0x1001ecc;

        [NativeTypeName("#define XK_obelowdot 0x1001ecd")]
        public const int XK_obelowdot = 0x1001ecd;

        [NativeTypeName("#define XK_Ohook 0x1001ece")]
        public const int XK_Ohook = 0x1001ece;

        [NativeTypeName("#define XK_ohook 0x1001ecf")]
        public const int XK_ohook = 0x1001ecf;

        [NativeTypeName("#define XK_Ocircumflexacute 0x1001ed0")]
        public const int XK_Ocircumflexacute = 0x1001ed0;

        [NativeTypeName("#define XK_ocircumflexacute 0x1001ed1")]
        public const int XK_ocircumflexacute = 0x1001ed1;

        [NativeTypeName("#define XK_Ocircumflexgrave 0x1001ed2")]
        public const int XK_Ocircumflexgrave = 0x1001ed2;

        [NativeTypeName("#define XK_ocircumflexgrave 0x1001ed3")]
        public const int XK_ocircumflexgrave = 0x1001ed3;

        [NativeTypeName("#define XK_Ocircumflexhook 0x1001ed4")]
        public const int XK_Ocircumflexhook = 0x1001ed4;

        [NativeTypeName("#define XK_ocircumflexhook 0x1001ed5")]
        public const int XK_ocircumflexhook = 0x1001ed5;

        [NativeTypeName("#define XK_Ocircumflextilde 0x1001ed6")]
        public const int XK_Ocircumflextilde = 0x1001ed6;

        [NativeTypeName("#define XK_ocircumflextilde 0x1001ed7")]
        public const int XK_ocircumflextilde = 0x1001ed7;

        [NativeTypeName("#define XK_Ocircumflexbelowdot 0x1001ed8")]
        public const int XK_Ocircumflexbelowdot = 0x1001ed8;

        [NativeTypeName("#define XK_ocircumflexbelowdot 0x1001ed9")]
        public const int XK_ocircumflexbelowdot = 0x1001ed9;

        [NativeTypeName("#define XK_Ohornacute 0x1001eda")]
        public const int XK_Ohornacute = 0x1001eda;

        [NativeTypeName("#define XK_ohornacute 0x1001edb")]
        public const int XK_ohornacute = 0x1001edb;

        [NativeTypeName("#define XK_Ohorngrave 0x1001edc")]
        public const int XK_Ohorngrave = 0x1001edc;

        [NativeTypeName("#define XK_ohorngrave 0x1001edd")]
        public const int XK_ohorngrave = 0x1001edd;

        [NativeTypeName("#define XK_Ohornhook 0x1001ede")]
        public const int XK_Ohornhook = 0x1001ede;

        [NativeTypeName("#define XK_ohornhook 0x1001edf")]
        public const int XK_ohornhook = 0x1001edf;

        [NativeTypeName("#define XK_Ohorntilde 0x1001ee0")]
        public const int XK_Ohorntilde = 0x1001ee0;

        [NativeTypeName("#define XK_ohorntilde 0x1001ee1")]
        public const int XK_ohorntilde = 0x1001ee1;

        [NativeTypeName("#define XK_Ohornbelowdot 0x1001ee2")]
        public const int XK_Ohornbelowdot = 0x1001ee2;

        [NativeTypeName("#define XK_ohornbelowdot 0x1001ee3")]
        public const int XK_ohornbelowdot = 0x1001ee3;

        [NativeTypeName("#define XK_Ubelowdot 0x1001ee4")]
        public const int XK_Ubelowdot = 0x1001ee4;

        [NativeTypeName("#define XK_ubelowdot 0x1001ee5")]
        public const int XK_ubelowdot = 0x1001ee5;

        [NativeTypeName("#define XK_Uhook 0x1001ee6")]
        public const int XK_Uhook = 0x1001ee6;

        [NativeTypeName("#define XK_uhook 0x1001ee7")]
        public const int XK_uhook = 0x1001ee7;

        [NativeTypeName("#define XK_Uhornacute 0x1001ee8")]
        public const int XK_Uhornacute = 0x1001ee8;

        [NativeTypeName("#define XK_uhornacute 0x1001ee9")]
        public const int XK_uhornacute = 0x1001ee9;

        [NativeTypeName("#define XK_Uhorngrave 0x1001eea")]
        public const int XK_Uhorngrave = 0x1001eea;

        [NativeTypeName("#define XK_uhorngrave 0x1001eeb")]
        public const int XK_uhorngrave = 0x1001eeb;

        [NativeTypeName("#define XK_Uhornhook 0x1001eec")]
        public const int XK_Uhornhook = 0x1001eec;

        [NativeTypeName("#define XK_uhornhook 0x1001eed")]
        public const int XK_uhornhook = 0x1001eed;

        [NativeTypeName("#define XK_Uhorntilde 0x1001eee")]
        public const int XK_Uhorntilde = 0x1001eee;

        [NativeTypeName("#define XK_uhorntilde 0x1001eef")]
        public const int XK_uhorntilde = 0x1001eef;

        [NativeTypeName("#define XK_Uhornbelowdot 0x1001ef0")]
        public const int XK_Uhornbelowdot = 0x1001ef0;

        [NativeTypeName("#define XK_uhornbelowdot 0x1001ef1")]
        public const int XK_uhornbelowdot = 0x1001ef1;

        [NativeTypeName("#define XK_Ybelowdot 0x1001ef4")]
        public const int XK_Ybelowdot = 0x1001ef4;

        [NativeTypeName("#define XK_ybelowdot 0x1001ef5")]
        public const int XK_ybelowdot = 0x1001ef5;

        [NativeTypeName("#define XK_Yhook 0x1001ef6")]
        public const int XK_Yhook = 0x1001ef6;

        [NativeTypeName("#define XK_yhook 0x1001ef7")]
        public const int XK_yhook = 0x1001ef7;

        [NativeTypeName("#define XK_Ytilde 0x1001ef8")]
        public const int XK_Ytilde = 0x1001ef8;

        [NativeTypeName("#define XK_ytilde 0x1001ef9")]
        public const int XK_ytilde = 0x1001ef9;

        [NativeTypeName("#define XK_Ohorn 0x10001a0")]
        public const int XK_Ohorn = 0x10001a0;

        [NativeTypeName("#define XK_ohorn 0x10001a1")]
        public const int XK_ohorn = 0x10001a1;

        [NativeTypeName("#define XK_Uhorn 0x10001af")]
        public const int XK_Uhorn = 0x10001af;

        [NativeTypeName("#define XK_uhorn 0x10001b0")]
        public const int XK_uhorn = 0x10001b0;

        [NativeTypeName("#define XK_EcuSign 0x10020a0")]
        public const int XK_EcuSign = 0x10020a0;

        [NativeTypeName("#define XK_ColonSign 0x10020a1")]
        public const int XK_ColonSign = 0x10020a1;

        [NativeTypeName("#define XK_CruzeiroSign 0x10020a2")]
        public const int XK_CruzeiroSign = 0x10020a2;

        [NativeTypeName("#define XK_FFrancSign 0x10020a3")]
        public const int XK_FFrancSign = 0x10020a3;

        [NativeTypeName("#define XK_LiraSign 0x10020a4")]
        public const int XK_LiraSign = 0x10020a4;

        [NativeTypeName("#define XK_MillSign 0x10020a5")]
        public const int XK_MillSign = 0x10020a5;

        [NativeTypeName("#define XK_NairaSign 0x10020a6")]
        public const int XK_NairaSign = 0x10020a6;

        [NativeTypeName("#define XK_PesetaSign 0x10020a7")]
        public const int XK_PesetaSign = 0x10020a7;

        [NativeTypeName("#define XK_RupeeSign 0x10020a8")]
        public const int XK_RupeeSign = 0x10020a8;

        [NativeTypeName("#define XK_WonSign 0x10020a9")]
        public const int XK_WonSign = 0x10020a9;

        [NativeTypeName("#define XK_NewSheqelSign 0x10020aa")]
        public const int XK_NewSheqelSign = 0x10020aa;

        [NativeTypeName("#define XK_DongSign 0x10020ab")]
        public const int XK_DongSign = 0x10020ab;

        [NativeTypeName("#define XK_EuroSign 0x20ac")]
        public const int XK_EuroSign = 0x20ac;

        [NativeTypeName("#define XK_zerosuperior 0x1002070")]
        public const int XK_zerosuperior = 0x1002070;

        [NativeTypeName("#define XK_foursuperior 0x1002074")]
        public const int XK_foursuperior = 0x1002074;

        [NativeTypeName("#define XK_fivesuperior 0x1002075")]
        public const int XK_fivesuperior = 0x1002075;

        [NativeTypeName("#define XK_sixsuperior 0x1002076")]
        public const int XK_sixsuperior = 0x1002076;

        [NativeTypeName("#define XK_sevensuperior 0x1002077")]
        public const int XK_sevensuperior = 0x1002077;

        [NativeTypeName("#define XK_eightsuperior 0x1002078")]
        public const int XK_eightsuperior = 0x1002078;

        [NativeTypeName("#define XK_ninesuperior 0x1002079")]
        public const int XK_ninesuperior = 0x1002079;

        [NativeTypeName("#define XK_zerosubscript 0x1002080")]
        public const int XK_zerosubscript = 0x1002080;

        [NativeTypeName("#define XK_onesubscript 0x1002081")]
        public const int XK_onesubscript = 0x1002081;

        [NativeTypeName("#define XK_twosubscript 0x1002082")]
        public const int XK_twosubscript = 0x1002082;

        [NativeTypeName("#define XK_threesubscript 0x1002083")]
        public const int XK_threesubscript = 0x1002083;

        [NativeTypeName("#define XK_foursubscript 0x1002084")]
        public const int XK_foursubscript = 0x1002084;

        [NativeTypeName("#define XK_fivesubscript 0x1002085")]
        public const int XK_fivesubscript = 0x1002085;

        [NativeTypeName("#define XK_sixsubscript 0x1002086")]
        public const int XK_sixsubscript = 0x1002086;

        [NativeTypeName("#define XK_sevensubscript 0x1002087")]
        public const int XK_sevensubscript = 0x1002087;

        [NativeTypeName("#define XK_eightsubscript 0x1002088")]
        public const int XK_eightsubscript = 0x1002088;

        [NativeTypeName("#define XK_ninesubscript 0x1002089")]
        public const int XK_ninesubscript = 0x1002089;

        [NativeTypeName("#define XK_partdifferential 0x1002202")]
        public const int XK_partdifferential = 0x1002202;

        [NativeTypeName("#define XK_emptyset 0x1002205")]
        public const int XK_emptyset = 0x1002205;

        [NativeTypeName("#define XK_elementof 0x1002208")]
        public const int XK_elementof = 0x1002208;

        [NativeTypeName("#define XK_notelementof 0x1002209")]
        public const int XK_notelementof = 0x1002209;

        [NativeTypeName("#define XK_containsas 0x100220B")]
        public const int XK_containsas = 0x100220B;

        [NativeTypeName("#define XK_squareroot 0x100221A")]
        public const int XK_squareroot = 0x100221A;

        [NativeTypeName("#define XK_cuberoot 0x100221B")]
        public const int XK_cuberoot = 0x100221B;

        [NativeTypeName("#define XK_fourthroot 0x100221C")]
        public const int XK_fourthroot = 0x100221C;

        [NativeTypeName("#define XK_dintegral 0x100222C")]
        public const int XK_dintegral = 0x100222C;

        [NativeTypeName("#define XK_tintegral 0x100222D")]
        public const int XK_tintegral = 0x100222D;

        [NativeTypeName("#define XK_because 0x1002235")]
        public const int XK_because = 0x1002235;

        [NativeTypeName("#define XK_approxeq 0x1002248")]
        public const int XK_approxeq = 0x1002248;

        [NativeTypeName("#define XK_notapproxeq 0x1002247")]
        public const int XK_notapproxeq = 0x1002247;

        [NativeTypeName("#define XK_notidentical 0x1002262")]
        public const int XK_notidentical = 0x1002262;

        [NativeTypeName("#define XK_stricteq 0x1002263")]
        public const int XK_stricteq = 0x1002263;

        [NativeTypeName("#define XK_braille_dot_1 0xfff1")]
        public const int XK_braille_dot_1 = 0xfff1;

        [NativeTypeName("#define XK_braille_dot_2 0xfff2")]
        public const int XK_braille_dot_2 = 0xfff2;

        [NativeTypeName("#define XK_braille_dot_3 0xfff3")]
        public const int XK_braille_dot_3 = 0xfff3;

        [NativeTypeName("#define XK_braille_dot_4 0xfff4")]
        public const int XK_braille_dot_4 = 0xfff4;

        [NativeTypeName("#define XK_braille_dot_5 0xfff5")]
        public const int XK_braille_dot_5 = 0xfff5;

        [NativeTypeName("#define XK_braille_dot_6 0xfff6")]
        public const int XK_braille_dot_6 = 0xfff6;

        [NativeTypeName("#define XK_braille_dot_7 0xfff7")]
        public const int XK_braille_dot_7 = 0xfff7;

        [NativeTypeName("#define XK_braille_dot_8 0xfff8")]
        public const int XK_braille_dot_8 = 0xfff8;

        [NativeTypeName("#define XK_braille_dot_9 0xfff9")]
        public const int XK_braille_dot_9 = 0xfff9;

        [NativeTypeName("#define XK_braille_dot_10 0xfffa")]
        public const int XK_braille_dot_10 = 0xfffa;

        [NativeTypeName("#define XK_braille_blank 0x1002800")]
        public const int XK_braille_blank = 0x1002800;

        [NativeTypeName("#define XK_braille_dots_1 0x1002801")]
        public const int XK_braille_dots_1 = 0x1002801;

        [NativeTypeName("#define XK_braille_dots_2 0x1002802")]
        public const int XK_braille_dots_2 = 0x1002802;

        [NativeTypeName("#define XK_braille_dots_12 0x1002803")]
        public const int XK_braille_dots_12 = 0x1002803;

        [NativeTypeName("#define XK_braille_dots_3 0x1002804")]
        public const int XK_braille_dots_3 = 0x1002804;

        [NativeTypeName("#define XK_braille_dots_13 0x1002805")]
        public const int XK_braille_dots_13 = 0x1002805;

        [NativeTypeName("#define XK_braille_dots_23 0x1002806")]
        public const int XK_braille_dots_23 = 0x1002806;

        [NativeTypeName("#define XK_braille_dots_123 0x1002807")]
        public const int XK_braille_dots_123 = 0x1002807;

        [NativeTypeName("#define XK_braille_dots_4 0x1002808")]
        public const int XK_braille_dots_4 = 0x1002808;

        [NativeTypeName("#define XK_braille_dots_14 0x1002809")]
        public const int XK_braille_dots_14 = 0x1002809;

        [NativeTypeName("#define XK_braille_dots_24 0x100280a")]
        public const int XK_braille_dots_24 = 0x100280a;

        [NativeTypeName("#define XK_braille_dots_124 0x100280b")]
        public const int XK_braille_dots_124 = 0x100280b;

        [NativeTypeName("#define XK_braille_dots_34 0x100280c")]
        public const int XK_braille_dots_34 = 0x100280c;

        [NativeTypeName("#define XK_braille_dots_134 0x100280d")]
        public const int XK_braille_dots_134 = 0x100280d;

        [NativeTypeName("#define XK_braille_dots_234 0x100280e")]
        public const int XK_braille_dots_234 = 0x100280e;

        [NativeTypeName("#define XK_braille_dots_1234 0x100280f")]
        public const int XK_braille_dots_1234 = 0x100280f;

        [NativeTypeName("#define XK_braille_dots_5 0x1002810")]
        public const int XK_braille_dots_5 = 0x1002810;

        [NativeTypeName("#define XK_braille_dots_15 0x1002811")]
        public const int XK_braille_dots_15 = 0x1002811;

        [NativeTypeName("#define XK_braille_dots_25 0x1002812")]
        public const int XK_braille_dots_25 = 0x1002812;

        [NativeTypeName("#define XK_braille_dots_125 0x1002813")]
        public const int XK_braille_dots_125 = 0x1002813;

        [NativeTypeName("#define XK_braille_dots_35 0x1002814")]
        public const int XK_braille_dots_35 = 0x1002814;

        [NativeTypeName("#define XK_braille_dots_135 0x1002815")]
        public const int XK_braille_dots_135 = 0x1002815;

        [NativeTypeName("#define XK_braille_dots_235 0x1002816")]
        public const int XK_braille_dots_235 = 0x1002816;

        [NativeTypeName("#define XK_braille_dots_1235 0x1002817")]
        public const int XK_braille_dots_1235 = 0x1002817;

        [NativeTypeName("#define XK_braille_dots_45 0x1002818")]
        public const int XK_braille_dots_45 = 0x1002818;

        [NativeTypeName("#define XK_braille_dots_145 0x1002819")]
        public const int XK_braille_dots_145 = 0x1002819;

        [NativeTypeName("#define XK_braille_dots_245 0x100281a")]
        public const int XK_braille_dots_245 = 0x100281a;

        [NativeTypeName("#define XK_braille_dots_1245 0x100281b")]
        public const int XK_braille_dots_1245 = 0x100281b;

        [NativeTypeName("#define XK_braille_dots_345 0x100281c")]
        public const int XK_braille_dots_345 = 0x100281c;

        [NativeTypeName("#define XK_braille_dots_1345 0x100281d")]
        public const int XK_braille_dots_1345 = 0x100281d;

        [NativeTypeName("#define XK_braille_dots_2345 0x100281e")]
        public const int XK_braille_dots_2345 = 0x100281e;

        [NativeTypeName("#define XK_braille_dots_12345 0x100281f")]
        public const int XK_braille_dots_12345 = 0x100281f;

        [NativeTypeName("#define XK_braille_dots_6 0x1002820")]
        public const int XK_braille_dots_6 = 0x1002820;

        [NativeTypeName("#define XK_braille_dots_16 0x1002821")]
        public const int XK_braille_dots_16 = 0x1002821;

        [NativeTypeName("#define XK_braille_dots_26 0x1002822")]
        public const int XK_braille_dots_26 = 0x1002822;

        [NativeTypeName("#define XK_braille_dots_126 0x1002823")]
        public const int XK_braille_dots_126 = 0x1002823;

        [NativeTypeName("#define XK_braille_dots_36 0x1002824")]
        public const int XK_braille_dots_36 = 0x1002824;

        [NativeTypeName("#define XK_braille_dots_136 0x1002825")]
        public const int XK_braille_dots_136 = 0x1002825;

        [NativeTypeName("#define XK_braille_dots_236 0x1002826")]
        public const int XK_braille_dots_236 = 0x1002826;

        [NativeTypeName("#define XK_braille_dots_1236 0x1002827")]
        public const int XK_braille_dots_1236 = 0x1002827;

        [NativeTypeName("#define XK_braille_dots_46 0x1002828")]
        public const int XK_braille_dots_46 = 0x1002828;

        [NativeTypeName("#define XK_braille_dots_146 0x1002829")]
        public const int XK_braille_dots_146 = 0x1002829;

        [NativeTypeName("#define XK_braille_dots_246 0x100282a")]
        public const int XK_braille_dots_246 = 0x100282a;

        [NativeTypeName("#define XK_braille_dots_1246 0x100282b")]
        public const int XK_braille_dots_1246 = 0x100282b;

        [NativeTypeName("#define XK_braille_dots_346 0x100282c")]
        public const int XK_braille_dots_346 = 0x100282c;

        [NativeTypeName("#define XK_braille_dots_1346 0x100282d")]
        public const int XK_braille_dots_1346 = 0x100282d;

        [NativeTypeName("#define XK_braille_dots_2346 0x100282e")]
        public const int XK_braille_dots_2346 = 0x100282e;

        [NativeTypeName("#define XK_braille_dots_12346 0x100282f")]
        public const int XK_braille_dots_12346 = 0x100282f;

        [NativeTypeName("#define XK_braille_dots_56 0x1002830")]
        public const int XK_braille_dots_56 = 0x1002830;

        [NativeTypeName("#define XK_braille_dots_156 0x1002831")]
        public const int XK_braille_dots_156 = 0x1002831;

        [NativeTypeName("#define XK_braille_dots_256 0x1002832")]
        public const int XK_braille_dots_256 = 0x1002832;

        [NativeTypeName("#define XK_braille_dots_1256 0x1002833")]
        public const int XK_braille_dots_1256 = 0x1002833;

        [NativeTypeName("#define XK_braille_dots_356 0x1002834")]
        public const int XK_braille_dots_356 = 0x1002834;

        [NativeTypeName("#define XK_braille_dots_1356 0x1002835")]
        public const int XK_braille_dots_1356 = 0x1002835;

        [NativeTypeName("#define XK_braille_dots_2356 0x1002836")]
        public const int XK_braille_dots_2356 = 0x1002836;

        [NativeTypeName("#define XK_braille_dots_12356 0x1002837")]
        public const int XK_braille_dots_12356 = 0x1002837;

        [NativeTypeName("#define XK_braille_dots_456 0x1002838")]
        public const int XK_braille_dots_456 = 0x1002838;

        [NativeTypeName("#define XK_braille_dots_1456 0x1002839")]
        public const int XK_braille_dots_1456 = 0x1002839;

        [NativeTypeName("#define XK_braille_dots_2456 0x100283a")]
        public const int XK_braille_dots_2456 = 0x100283a;

        [NativeTypeName("#define XK_braille_dots_12456 0x100283b")]
        public const int XK_braille_dots_12456 = 0x100283b;

        [NativeTypeName("#define XK_braille_dots_3456 0x100283c")]
        public const int XK_braille_dots_3456 = 0x100283c;

        [NativeTypeName("#define XK_braille_dots_13456 0x100283d")]
        public const int XK_braille_dots_13456 = 0x100283d;

        [NativeTypeName("#define XK_braille_dots_23456 0x100283e")]
        public const int XK_braille_dots_23456 = 0x100283e;

        [NativeTypeName("#define XK_braille_dots_123456 0x100283f")]
        public const int XK_braille_dots_123456 = 0x100283f;

        [NativeTypeName("#define XK_braille_dots_7 0x1002840")]
        public const int XK_braille_dots_7 = 0x1002840;

        [NativeTypeName("#define XK_braille_dots_17 0x1002841")]
        public const int XK_braille_dots_17 = 0x1002841;

        [NativeTypeName("#define XK_braille_dots_27 0x1002842")]
        public const int XK_braille_dots_27 = 0x1002842;

        [NativeTypeName("#define XK_braille_dots_127 0x1002843")]
        public const int XK_braille_dots_127 = 0x1002843;

        [NativeTypeName("#define XK_braille_dots_37 0x1002844")]
        public const int XK_braille_dots_37 = 0x1002844;

        [NativeTypeName("#define XK_braille_dots_137 0x1002845")]
        public const int XK_braille_dots_137 = 0x1002845;

        [NativeTypeName("#define XK_braille_dots_237 0x1002846")]
        public const int XK_braille_dots_237 = 0x1002846;

        [NativeTypeName("#define XK_braille_dots_1237 0x1002847")]
        public const int XK_braille_dots_1237 = 0x1002847;

        [NativeTypeName("#define XK_braille_dots_47 0x1002848")]
        public const int XK_braille_dots_47 = 0x1002848;

        [NativeTypeName("#define XK_braille_dots_147 0x1002849")]
        public const int XK_braille_dots_147 = 0x1002849;

        [NativeTypeName("#define XK_braille_dots_247 0x100284a")]
        public const int XK_braille_dots_247 = 0x100284a;

        [NativeTypeName("#define XK_braille_dots_1247 0x100284b")]
        public const int XK_braille_dots_1247 = 0x100284b;

        [NativeTypeName("#define XK_braille_dots_347 0x100284c")]
        public const int XK_braille_dots_347 = 0x100284c;

        [NativeTypeName("#define XK_braille_dots_1347 0x100284d")]
        public const int XK_braille_dots_1347 = 0x100284d;

        [NativeTypeName("#define XK_braille_dots_2347 0x100284e")]
        public const int XK_braille_dots_2347 = 0x100284e;

        [NativeTypeName("#define XK_braille_dots_12347 0x100284f")]
        public const int XK_braille_dots_12347 = 0x100284f;

        [NativeTypeName("#define XK_braille_dots_57 0x1002850")]
        public const int XK_braille_dots_57 = 0x1002850;

        [NativeTypeName("#define XK_braille_dots_157 0x1002851")]
        public const int XK_braille_dots_157 = 0x1002851;

        [NativeTypeName("#define XK_braille_dots_257 0x1002852")]
        public const int XK_braille_dots_257 = 0x1002852;

        [NativeTypeName("#define XK_braille_dots_1257 0x1002853")]
        public const int XK_braille_dots_1257 = 0x1002853;

        [NativeTypeName("#define XK_braille_dots_357 0x1002854")]
        public const int XK_braille_dots_357 = 0x1002854;

        [NativeTypeName("#define XK_braille_dots_1357 0x1002855")]
        public const int XK_braille_dots_1357 = 0x1002855;

        [NativeTypeName("#define XK_braille_dots_2357 0x1002856")]
        public const int XK_braille_dots_2357 = 0x1002856;

        [NativeTypeName("#define XK_braille_dots_12357 0x1002857")]
        public const int XK_braille_dots_12357 = 0x1002857;

        [NativeTypeName("#define XK_braille_dots_457 0x1002858")]
        public const int XK_braille_dots_457 = 0x1002858;

        [NativeTypeName("#define XK_braille_dots_1457 0x1002859")]
        public const int XK_braille_dots_1457 = 0x1002859;

        [NativeTypeName("#define XK_braille_dots_2457 0x100285a")]
        public const int XK_braille_dots_2457 = 0x100285a;

        [NativeTypeName("#define XK_braille_dots_12457 0x100285b")]
        public const int XK_braille_dots_12457 = 0x100285b;

        [NativeTypeName("#define XK_braille_dots_3457 0x100285c")]
        public const int XK_braille_dots_3457 = 0x100285c;

        [NativeTypeName("#define XK_braille_dots_13457 0x100285d")]
        public const int XK_braille_dots_13457 = 0x100285d;

        [NativeTypeName("#define XK_braille_dots_23457 0x100285e")]
        public const int XK_braille_dots_23457 = 0x100285e;

        [NativeTypeName("#define XK_braille_dots_123457 0x100285f")]
        public const int XK_braille_dots_123457 = 0x100285f;

        [NativeTypeName("#define XK_braille_dots_67 0x1002860")]
        public const int XK_braille_dots_67 = 0x1002860;

        [NativeTypeName("#define XK_braille_dots_167 0x1002861")]
        public const int XK_braille_dots_167 = 0x1002861;

        [NativeTypeName("#define XK_braille_dots_267 0x1002862")]
        public const int XK_braille_dots_267 = 0x1002862;

        [NativeTypeName("#define XK_braille_dots_1267 0x1002863")]
        public const int XK_braille_dots_1267 = 0x1002863;

        [NativeTypeName("#define XK_braille_dots_367 0x1002864")]
        public const int XK_braille_dots_367 = 0x1002864;

        [NativeTypeName("#define XK_braille_dots_1367 0x1002865")]
        public const int XK_braille_dots_1367 = 0x1002865;

        [NativeTypeName("#define XK_braille_dots_2367 0x1002866")]
        public const int XK_braille_dots_2367 = 0x1002866;

        [NativeTypeName("#define XK_braille_dots_12367 0x1002867")]
        public const int XK_braille_dots_12367 = 0x1002867;

        [NativeTypeName("#define XK_braille_dots_467 0x1002868")]
        public const int XK_braille_dots_467 = 0x1002868;

        [NativeTypeName("#define XK_braille_dots_1467 0x1002869")]
        public const int XK_braille_dots_1467 = 0x1002869;

        [NativeTypeName("#define XK_braille_dots_2467 0x100286a")]
        public const int XK_braille_dots_2467 = 0x100286a;

        [NativeTypeName("#define XK_braille_dots_12467 0x100286b")]
        public const int XK_braille_dots_12467 = 0x100286b;

        [NativeTypeName("#define XK_braille_dots_3467 0x100286c")]
        public const int XK_braille_dots_3467 = 0x100286c;

        [NativeTypeName("#define XK_braille_dots_13467 0x100286d")]
        public const int XK_braille_dots_13467 = 0x100286d;

        [NativeTypeName("#define XK_braille_dots_23467 0x100286e")]
        public const int XK_braille_dots_23467 = 0x100286e;

        [NativeTypeName("#define XK_braille_dots_123467 0x100286f")]
        public const int XK_braille_dots_123467 = 0x100286f;

        [NativeTypeName("#define XK_braille_dots_567 0x1002870")]
        public const int XK_braille_dots_567 = 0x1002870;

        [NativeTypeName("#define XK_braille_dots_1567 0x1002871")]
        public const int XK_braille_dots_1567 = 0x1002871;

        [NativeTypeName("#define XK_braille_dots_2567 0x1002872")]
        public const int XK_braille_dots_2567 = 0x1002872;

        [NativeTypeName("#define XK_braille_dots_12567 0x1002873")]
        public const int XK_braille_dots_12567 = 0x1002873;

        [NativeTypeName("#define XK_braille_dots_3567 0x1002874")]
        public const int XK_braille_dots_3567 = 0x1002874;

        [NativeTypeName("#define XK_braille_dots_13567 0x1002875")]
        public const int XK_braille_dots_13567 = 0x1002875;

        [NativeTypeName("#define XK_braille_dots_23567 0x1002876")]
        public const int XK_braille_dots_23567 = 0x1002876;

        [NativeTypeName("#define XK_braille_dots_123567 0x1002877")]
        public const int XK_braille_dots_123567 = 0x1002877;

        [NativeTypeName("#define XK_braille_dots_4567 0x1002878")]
        public const int XK_braille_dots_4567 = 0x1002878;

        [NativeTypeName("#define XK_braille_dots_14567 0x1002879")]
        public const int XK_braille_dots_14567 = 0x1002879;

        [NativeTypeName("#define XK_braille_dots_24567 0x100287a")]
        public const int XK_braille_dots_24567 = 0x100287a;

        [NativeTypeName("#define XK_braille_dots_124567 0x100287b")]
        public const int XK_braille_dots_124567 = 0x100287b;

        [NativeTypeName("#define XK_braille_dots_34567 0x100287c")]
        public const int XK_braille_dots_34567 = 0x100287c;

        [NativeTypeName("#define XK_braille_dots_134567 0x100287d")]
        public const int XK_braille_dots_134567 = 0x100287d;

        [NativeTypeName("#define XK_braille_dots_234567 0x100287e")]
        public const int XK_braille_dots_234567 = 0x100287e;

        [NativeTypeName("#define XK_braille_dots_1234567 0x100287f")]
        public const int XK_braille_dots_1234567 = 0x100287f;

        [NativeTypeName("#define XK_braille_dots_8 0x1002880")]
        public const int XK_braille_dots_8 = 0x1002880;

        [NativeTypeName("#define XK_braille_dots_18 0x1002881")]
        public const int XK_braille_dots_18 = 0x1002881;

        [NativeTypeName("#define XK_braille_dots_28 0x1002882")]
        public const int XK_braille_dots_28 = 0x1002882;

        [NativeTypeName("#define XK_braille_dots_128 0x1002883")]
        public const int XK_braille_dots_128 = 0x1002883;

        [NativeTypeName("#define XK_braille_dots_38 0x1002884")]
        public const int XK_braille_dots_38 = 0x1002884;

        [NativeTypeName("#define XK_braille_dots_138 0x1002885")]
        public const int XK_braille_dots_138 = 0x1002885;

        [NativeTypeName("#define XK_braille_dots_238 0x1002886")]
        public const int XK_braille_dots_238 = 0x1002886;

        [NativeTypeName("#define XK_braille_dots_1238 0x1002887")]
        public const int XK_braille_dots_1238 = 0x1002887;

        [NativeTypeName("#define XK_braille_dots_48 0x1002888")]
        public const int XK_braille_dots_48 = 0x1002888;

        [NativeTypeName("#define XK_braille_dots_148 0x1002889")]
        public const int XK_braille_dots_148 = 0x1002889;

        [NativeTypeName("#define XK_braille_dots_248 0x100288a")]
        public const int XK_braille_dots_248 = 0x100288a;

        [NativeTypeName("#define XK_braille_dots_1248 0x100288b")]
        public const int XK_braille_dots_1248 = 0x100288b;

        [NativeTypeName("#define XK_braille_dots_348 0x100288c")]
        public const int XK_braille_dots_348 = 0x100288c;

        [NativeTypeName("#define XK_braille_dots_1348 0x100288d")]
        public const int XK_braille_dots_1348 = 0x100288d;

        [NativeTypeName("#define XK_braille_dots_2348 0x100288e")]
        public const int XK_braille_dots_2348 = 0x100288e;

        [NativeTypeName("#define XK_braille_dots_12348 0x100288f")]
        public const int XK_braille_dots_12348 = 0x100288f;

        [NativeTypeName("#define XK_braille_dots_58 0x1002890")]
        public const int XK_braille_dots_58 = 0x1002890;

        [NativeTypeName("#define XK_braille_dots_158 0x1002891")]
        public const int XK_braille_dots_158 = 0x1002891;

        [NativeTypeName("#define XK_braille_dots_258 0x1002892")]
        public const int XK_braille_dots_258 = 0x1002892;

        [NativeTypeName("#define XK_braille_dots_1258 0x1002893")]
        public const int XK_braille_dots_1258 = 0x1002893;

        [NativeTypeName("#define XK_braille_dots_358 0x1002894")]
        public const int XK_braille_dots_358 = 0x1002894;

        [NativeTypeName("#define XK_braille_dots_1358 0x1002895")]
        public const int XK_braille_dots_1358 = 0x1002895;

        [NativeTypeName("#define XK_braille_dots_2358 0x1002896")]
        public const int XK_braille_dots_2358 = 0x1002896;

        [NativeTypeName("#define XK_braille_dots_12358 0x1002897")]
        public const int XK_braille_dots_12358 = 0x1002897;

        [NativeTypeName("#define XK_braille_dots_458 0x1002898")]
        public const int XK_braille_dots_458 = 0x1002898;

        [NativeTypeName("#define XK_braille_dots_1458 0x1002899")]
        public const int XK_braille_dots_1458 = 0x1002899;

        [NativeTypeName("#define XK_braille_dots_2458 0x100289a")]
        public const int XK_braille_dots_2458 = 0x100289a;

        [NativeTypeName("#define XK_braille_dots_12458 0x100289b")]
        public const int XK_braille_dots_12458 = 0x100289b;

        [NativeTypeName("#define XK_braille_dots_3458 0x100289c")]
        public const int XK_braille_dots_3458 = 0x100289c;

        [NativeTypeName("#define XK_braille_dots_13458 0x100289d")]
        public const int XK_braille_dots_13458 = 0x100289d;

        [NativeTypeName("#define XK_braille_dots_23458 0x100289e")]
        public const int XK_braille_dots_23458 = 0x100289e;

        [NativeTypeName("#define XK_braille_dots_123458 0x100289f")]
        public const int XK_braille_dots_123458 = 0x100289f;

        [NativeTypeName("#define XK_braille_dots_68 0x10028a0")]
        public const int XK_braille_dots_68 = 0x10028a0;

        [NativeTypeName("#define XK_braille_dots_168 0x10028a1")]
        public const int XK_braille_dots_168 = 0x10028a1;

        [NativeTypeName("#define XK_braille_dots_268 0x10028a2")]
        public const int XK_braille_dots_268 = 0x10028a2;

        [NativeTypeName("#define XK_braille_dots_1268 0x10028a3")]
        public const int XK_braille_dots_1268 = 0x10028a3;

        [NativeTypeName("#define XK_braille_dots_368 0x10028a4")]
        public const int XK_braille_dots_368 = 0x10028a4;

        [NativeTypeName("#define XK_braille_dots_1368 0x10028a5")]
        public const int XK_braille_dots_1368 = 0x10028a5;

        [NativeTypeName("#define XK_braille_dots_2368 0x10028a6")]
        public const int XK_braille_dots_2368 = 0x10028a6;

        [NativeTypeName("#define XK_braille_dots_12368 0x10028a7")]
        public const int XK_braille_dots_12368 = 0x10028a7;

        [NativeTypeName("#define XK_braille_dots_468 0x10028a8")]
        public const int XK_braille_dots_468 = 0x10028a8;

        [NativeTypeName("#define XK_braille_dots_1468 0x10028a9")]
        public const int XK_braille_dots_1468 = 0x10028a9;

        [NativeTypeName("#define XK_braille_dots_2468 0x10028aa")]
        public const int XK_braille_dots_2468 = 0x10028aa;

        [NativeTypeName("#define XK_braille_dots_12468 0x10028ab")]
        public const int XK_braille_dots_12468 = 0x10028ab;

        [NativeTypeName("#define XK_braille_dots_3468 0x10028ac")]
        public const int XK_braille_dots_3468 = 0x10028ac;

        [NativeTypeName("#define XK_braille_dots_13468 0x10028ad")]
        public const int XK_braille_dots_13468 = 0x10028ad;

        [NativeTypeName("#define XK_braille_dots_23468 0x10028ae")]
        public const int XK_braille_dots_23468 = 0x10028ae;

        [NativeTypeName("#define XK_braille_dots_123468 0x10028af")]
        public const int XK_braille_dots_123468 = 0x10028af;

        [NativeTypeName("#define XK_braille_dots_568 0x10028b0")]
        public const int XK_braille_dots_568 = 0x10028b0;

        [NativeTypeName("#define XK_braille_dots_1568 0x10028b1")]
        public const int XK_braille_dots_1568 = 0x10028b1;

        [NativeTypeName("#define XK_braille_dots_2568 0x10028b2")]
        public const int XK_braille_dots_2568 = 0x10028b2;

        [NativeTypeName("#define XK_braille_dots_12568 0x10028b3")]
        public const int XK_braille_dots_12568 = 0x10028b3;

        [NativeTypeName("#define XK_braille_dots_3568 0x10028b4")]
        public const int XK_braille_dots_3568 = 0x10028b4;

        [NativeTypeName("#define XK_braille_dots_13568 0x10028b5")]
        public const int XK_braille_dots_13568 = 0x10028b5;

        [NativeTypeName("#define XK_braille_dots_23568 0x10028b6")]
        public const int XK_braille_dots_23568 = 0x10028b6;

        [NativeTypeName("#define XK_braille_dots_123568 0x10028b7")]
        public const int XK_braille_dots_123568 = 0x10028b7;

        [NativeTypeName("#define XK_braille_dots_4568 0x10028b8")]
        public const int XK_braille_dots_4568 = 0x10028b8;

        [NativeTypeName("#define XK_braille_dots_14568 0x10028b9")]
        public const int XK_braille_dots_14568 = 0x10028b9;

        [NativeTypeName("#define XK_braille_dots_24568 0x10028ba")]
        public const int XK_braille_dots_24568 = 0x10028ba;

        [NativeTypeName("#define XK_braille_dots_124568 0x10028bb")]
        public const int XK_braille_dots_124568 = 0x10028bb;

        [NativeTypeName("#define XK_braille_dots_34568 0x10028bc")]
        public const int XK_braille_dots_34568 = 0x10028bc;

        [NativeTypeName("#define XK_braille_dots_134568 0x10028bd")]
        public const int XK_braille_dots_134568 = 0x10028bd;

        [NativeTypeName("#define XK_braille_dots_234568 0x10028be")]
        public const int XK_braille_dots_234568 = 0x10028be;

        [NativeTypeName("#define XK_braille_dots_1234568 0x10028bf")]
        public const int XK_braille_dots_1234568 = 0x10028bf;

        [NativeTypeName("#define XK_braille_dots_78 0x10028c0")]
        public const int XK_braille_dots_78 = 0x10028c0;

        [NativeTypeName("#define XK_braille_dots_178 0x10028c1")]
        public const int XK_braille_dots_178 = 0x10028c1;

        [NativeTypeName("#define XK_braille_dots_278 0x10028c2")]
        public const int XK_braille_dots_278 = 0x10028c2;

        [NativeTypeName("#define XK_braille_dots_1278 0x10028c3")]
        public const int XK_braille_dots_1278 = 0x10028c3;

        [NativeTypeName("#define XK_braille_dots_378 0x10028c4")]
        public const int XK_braille_dots_378 = 0x10028c4;

        [NativeTypeName("#define XK_braille_dots_1378 0x10028c5")]
        public const int XK_braille_dots_1378 = 0x10028c5;

        [NativeTypeName("#define XK_braille_dots_2378 0x10028c6")]
        public const int XK_braille_dots_2378 = 0x10028c6;

        [NativeTypeName("#define XK_braille_dots_12378 0x10028c7")]
        public const int XK_braille_dots_12378 = 0x10028c7;

        [NativeTypeName("#define XK_braille_dots_478 0x10028c8")]
        public const int XK_braille_dots_478 = 0x10028c8;

        [NativeTypeName("#define XK_braille_dots_1478 0x10028c9")]
        public const int XK_braille_dots_1478 = 0x10028c9;

        [NativeTypeName("#define XK_braille_dots_2478 0x10028ca")]
        public const int XK_braille_dots_2478 = 0x10028ca;

        [NativeTypeName("#define XK_braille_dots_12478 0x10028cb")]
        public const int XK_braille_dots_12478 = 0x10028cb;

        [NativeTypeName("#define XK_braille_dots_3478 0x10028cc")]
        public const int XK_braille_dots_3478 = 0x10028cc;

        [NativeTypeName("#define XK_braille_dots_13478 0x10028cd")]
        public const int XK_braille_dots_13478 = 0x10028cd;

        [NativeTypeName("#define XK_braille_dots_23478 0x10028ce")]
        public const int XK_braille_dots_23478 = 0x10028ce;

        [NativeTypeName("#define XK_braille_dots_123478 0x10028cf")]
        public const int XK_braille_dots_123478 = 0x10028cf;

        [NativeTypeName("#define XK_braille_dots_578 0x10028d0")]
        public const int XK_braille_dots_578 = 0x10028d0;

        [NativeTypeName("#define XK_braille_dots_1578 0x10028d1")]
        public const int XK_braille_dots_1578 = 0x10028d1;

        [NativeTypeName("#define XK_braille_dots_2578 0x10028d2")]
        public const int XK_braille_dots_2578 = 0x10028d2;

        [NativeTypeName("#define XK_braille_dots_12578 0x10028d3")]
        public const int XK_braille_dots_12578 = 0x10028d3;

        [NativeTypeName("#define XK_braille_dots_3578 0x10028d4")]
        public const int XK_braille_dots_3578 = 0x10028d4;

        [NativeTypeName("#define XK_braille_dots_13578 0x10028d5")]
        public const int XK_braille_dots_13578 = 0x10028d5;

        [NativeTypeName("#define XK_braille_dots_23578 0x10028d6")]
        public const int XK_braille_dots_23578 = 0x10028d6;

        [NativeTypeName("#define XK_braille_dots_123578 0x10028d7")]
        public const int XK_braille_dots_123578 = 0x10028d7;

        [NativeTypeName("#define XK_braille_dots_4578 0x10028d8")]
        public const int XK_braille_dots_4578 = 0x10028d8;

        [NativeTypeName("#define XK_braille_dots_14578 0x10028d9")]
        public const int XK_braille_dots_14578 = 0x10028d9;

        [NativeTypeName("#define XK_braille_dots_24578 0x10028da")]
        public const int XK_braille_dots_24578 = 0x10028da;

        [NativeTypeName("#define XK_braille_dots_124578 0x10028db")]
        public const int XK_braille_dots_124578 = 0x10028db;

        [NativeTypeName("#define XK_braille_dots_34578 0x10028dc")]
        public const int XK_braille_dots_34578 = 0x10028dc;

        [NativeTypeName("#define XK_braille_dots_134578 0x10028dd")]
        public const int XK_braille_dots_134578 = 0x10028dd;

        [NativeTypeName("#define XK_braille_dots_234578 0x10028de")]
        public const int XK_braille_dots_234578 = 0x10028de;

        [NativeTypeName("#define XK_braille_dots_1234578 0x10028df")]
        public const int XK_braille_dots_1234578 = 0x10028df;

        [NativeTypeName("#define XK_braille_dots_678 0x10028e0")]
        public const int XK_braille_dots_678 = 0x10028e0;

        [NativeTypeName("#define XK_braille_dots_1678 0x10028e1")]
        public const int XK_braille_dots_1678 = 0x10028e1;

        [NativeTypeName("#define XK_braille_dots_2678 0x10028e2")]
        public const int XK_braille_dots_2678 = 0x10028e2;

        [NativeTypeName("#define XK_braille_dots_12678 0x10028e3")]
        public const int XK_braille_dots_12678 = 0x10028e3;

        [NativeTypeName("#define XK_braille_dots_3678 0x10028e4")]
        public const int XK_braille_dots_3678 = 0x10028e4;

        [NativeTypeName("#define XK_braille_dots_13678 0x10028e5")]
        public const int XK_braille_dots_13678 = 0x10028e5;

        [NativeTypeName("#define XK_braille_dots_23678 0x10028e6")]
        public const int XK_braille_dots_23678 = 0x10028e6;

        [NativeTypeName("#define XK_braille_dots_123678 0x10028e7")]
        public const int XK_braille_dots_123678 = 0x10028e7;

        [NativeTypeName("#define XK_braille_dots_4678 0x10028e8")]
        public const int XK_braille_dots_4678 = 0x10028e8;

        [NativeTypeName("#define XK_braille_dots_14678 0x10028e9")]
        public const int XK_braille_dots_14678 = 0x10028e9;

        [NativeTypeName("#define XK_braille_dots_24678 0x10028ea")]
        public const int XK_braille_dots_24678 = 0x10028ea;

        [NativeTypeName("#define XK_braille_dots_124678 0x10028eb")]
        public const int XK_braille_dots_124678 = 0x10028eb;

        [NativeTypeName("#define XK_braille_dots_34678 0x10028ec")]
        public const int XK_braille_dots_34678 = 0x10028ec;

        [NativeTypeName("#define XK_braille_dots_134678 0x10028ed")]
        public const int XK_braille_dots_134678 = 0x10028ed;

        [NativeTypeName("#define XK_braille_dots_234678 0x10028ee")]
        public const int XK_braille_dots_234678 = 0x10028ee;

        [NativeTypeName("#define XK_braille_dots_1234678 0x10028ef")]
        public const int XK_braille_dots_1234678 = 0x10028ef;

        [NativeTypeName("#define XK_braille_dots_5678 0x10028f0")]
        public const int XK_braille_dots_5678 = 0x10028f0;

        [NativeTypeName("#define XK_braille_dots_15678 0x10028f1")]
        public const int XK_braille_dots_15678 = 0x10028f1;

        [NativeTypeName("#define XK_braille_dots_25678 0x10028f2")]
        public const int XK_braille_dots_25678 = 0x10028f2;

        [NativeTypeName("#define XK_braille_dots_125678 0x10028f3")]
        public const int XK_braille_dots_125678 = 0x10028f3;

        [NativeTypeName("#define XK_braille_dots_35678 0x10028f4")]
        public const int XK_braille_dots_35678 = 0x10028f4;

        [NativeTypeName("#define XK_braille_dots_135678 0x10028f5")]
        public const int XK_braille_dots_135678 = 0x10028f5;

        [NativeTypeName("#define XK_braille_dots_235678 0x10028f6")]
        public const int XK_braille_dots_235678 = 0x10028f6;

        [NativeTypeName("#define XK_braille_dots_1235678 0x10028f7")]
        public const int XK_braille_dots_1235678 = 0x10028f7;

        [NativeTypeName("#define XK_braille_dots_45678 0x10028f8")]
        public const int XK_braille_dots_45678 = 0x10028f8;

        [NativeTypeName("#define XK_braille_dots_145678 0x10028f9")]
        public const int XK_braille_dots_145678 = 0x10028f9;

        [NativeTypeName("#define XK_braille_dots_245678 0x10028fa")]
        public const int XK_braille_dots_245678 = 0x10028fa;

        [NativeTypeName("#define XK_braille_dots_1245678 0x10028fb")]
        public const int XK_braille_dots_1245678 = 0x10028fb;

        [NativeTypeName("#define XK_braille_dots_345678 0x10028fc")]
        public const int XK_braille_dots_345678 = 0x10028fc;

        [NativeTypeName("#define XK_braille_dots_1345678 0x10028fd")]
        public const int XK_braille_dots_1345678 = 0x10028fd;

        [NativeTypeName("#define XK_braille_dots_2345678 0x10028fe")]
        public const int XK_braille_dots_2345678 = 0x10028fe;

        [NativeTypeName("#define XK_braille_dots_12345678 0x10028ff")]
        public const int XK_braille_dots_12345678 = 0x10028ff;

        [NativeTypeName("#define XK_Sinh_ng 0x1000d82")]
        public const int XK_Sinh_ng = 0x1000d82;

        [NativeTypeName("#define XK_Sinh_h2 0x1000d83")]
        public const int XK_Sinh_h2 = 0x1000d83;

        [NativeTypeName("#define XK_Sinh_a 0x1000d85")]
        public const int XK_Sinh_a = 0x1000d85;

        [NativeTypeName("#define XK_Sinh_aa 0x1000d86")]
        public const int XK_Sinh_aa = 0x1000d86;

        [NativeTypeName("#define XK_Sinh_ae 0x1000d87")]
        public const int XK_Sinh_ae = 0x1000d87;

        [NativeTypeName("#define XK_Sinh_aee 0x1000d88")]
        public const int XK_Sinh_aee = 0x1000d88;

        [NativeTypeName("#define XK_Sinh_i 0x1000d89")]
        public const int XK_Sinh_i = 0x1000d89;

        [NativeTypeName("#define XK_Sinh_ii 0x1000d8a")]
        public const int XK_Sinh_ii = 0x1000d8a;

        [NativeTypeName("#define XK_Sinh_u 0x1000d8b")]
        public const int XK_Sinh_u = 0x1000d8b;

        [NativeTypeName("#define XK_Sinh_uu 0x1000d8c")]
        public const int XK_Sinh_uu = 0x1000d8c;

        [NativeTypeName("#define XK_Sinh_ri 0x1000d8d")]
        public const int XK_Sinh_ri = 0x1000d8d;

        [NativeTypeName("#define XK_Sinh_rii 0x1000d8e")]
        public const int XK_Sinh_rii = 0x1000d8e;

        [NativeTypeName("#define XK_Sinh_lu 0x1000d8f")]
        public const int XK_Sinh_lu = 0x1000d8f;

        [NativeTypeName("#define XK_Sinh_luu 0x1000d90")]
        public const int XK_Sinh_luu = 0x1000d90;

        [NativeTypeName("#define XK_Sinh_e 0x1000d91")]
        public const int XK_Sinh_e = 0x1000d91;

        [NativeTypeName("#define XK_Sinh_ee 0x1000d92")]
        public const int XK_Sinh_ee = 0x1000d92;

        [NativeTypeName("#define XK_Sinh_ai 0x1000d93")]
        public const int XK_Sinh_ai = 0x1000d93;

        [NativeTypeName("#define XK_Sinh_o 0x1000d94")]
        public const int XK_Sinh_o = 0x1000d94;

        [NativeTypeName("#define XK_Sinh_oo 0x1000d95")]
        public const int XK_Sinh_oo = 0x1000d95;

        [NativeTypeName("#define XK_Sinh_au 0x1000d96")]
        public const int XK_Sinh_au = 0x1000d96;

        [NativeTypeName("#define XK_Sinh_ka 0x1000d9a")]
        public const int XK_Sinh_ka = 0x1000d9a;

        [NativeTypeName("#define XK_Sinh_kha 0x1000d9b")]
        public const int XK_Sinh_kha = 0x1000d9b;

        [NativeTypeName("#define XK_Sinh_ga 0x1000d9c")]
        public const int XK_Sinh_ga = 0x1000d9c;

        [NativeTypeName("#define XK_Sinh_gha 0x1000d9d")]
        public const int XK_Sinh_gha = 0x1000d9d;

        [NativeTypeName("#define XK_Sinh_ng2 0x1000d9e")]
        public const int XK_Sinh_ng2 = 0x1000d9e;

        [NativeTypeName("#define XK_Sinh_nga 0x1000d9f")]
        public const int XK_Sinh_nga = 0x1000d9f;

        [NativeTypeName("#define XK_Sinh_ca 0x1000da0")]
        public const int XK_Sinh_ca = 0x1000da0;

        [NativeTypeName("#define XK_Sinh_cha 0x1000da1")]
        public const int XK_Sinh_cha = 0x1000da1;

        [NativeTypeName("#define XK_Sinh_ja 0x1000da2")]
        public const int XK_Sinh_ja = 0x1000da2;

        [NativeTypeName("#define XK_Sinh_jha 0x1000da3")]
        public const int XK_Sinh_jha = 0x1000da3;

        [NativeTypeName("#define XK_Sinh_nya 0x1000da4")]
        public const int XK_Sinh_nya = 0x1000da4;

        [NativeTypeName("#define XK_Sinh_jnya 0x1000da5")]
        public const int XK_Sinh_jnya = 0x1000da5;

        [NativeTypeName("#define XK_Sinh_nja 0x1000da6")]
        public const int XK_Sinh_nja = 0x1000da6;

        [NativeTypeName("#define XK_Sinh_tta 0x1000da7")]
        public const int XK_Sinh_tta = 0x1000da7;

        [NativeTypeName("#define XK_Sinh_ttha 0x1000da8")]
        public const int XK_Sinh_ttha = 0x1000da8;

        [NativeTypeName("#define XK_Sinh_dda 0x1000da9")]
        public const int XK_Sinh_dda = 0x1000da9;

        [NativeTypeName("#define XK_Sinh_ddha 0x1000daa")]
        public const int XK_Sinh_ddha = 0x1000daa;

        [NativeTypeName("#define XK_Sinh_nna 0x1000dab")]
        public const int XK_Sinh_nna = 0x1000dab;

        [NativeTypeName("#define XK_Sinh_ndda 0x1000dac")]
        public const int XK_Sinh_ndda = 0x1000dac;

        [NativeTypeName("#define XK_Sinh_tha 0x1000dad")]
        public const int XK_Sinh_tha = 0x1000dad;

        [NativeTypeName("#define XK_Sinh_thha 0x1000dae")]
        public const int XK_Sinh_thha = 0x1000dae;

        [NativeTypeName("#define XK_Sinh_dha 0x1000daf")]
        public const int XK_Sinh_dha = 0x1000daf;

        [NativeTypeName("#define XK_Sinh_dhha 0x1000db0")]
        public const int XK_Sinh_dhha = 0x1000db0;

        [NativeTypeName("#define XK_Sinh_na 0x1000db1")]
        public const int XK_Sinh_na = 0x1000db1;

        [NativeTypeName("#define XK_Sinh_ndha 0x1000db3")]
        public const int XK_Sinh_ndha = 0x1000db3;

        [NativeTypeName("#define XK_Sinh_pa 0x1000db4")]
        public const int XK_Sinh_pa = 0x1000db4;

        [NativeTypeName("#define XK_Sinh_pha 0x1000db5")]
        public const int XK_Sinh_pha = 0x1000db5;

        [NativeTypeName("#define XK_Sinh_ba 0x1000db6")]
        public const int XK_Sinh_ba = 0x1000db6;

        [NativeTypeName("#define XK_Sinh_bha 0x1000db7")]
        public const int XK_Sinh_bha = 0x1000db7;

        [NativeTypeName("#define XK_Sinh_ma 0x1000db8")]
        public const int XK_Sinh_ma = 0x1000db8;

        [NativeTypeName("#define XK_Sinh_mba 0x1000db9")]
        public const int XK_Sinh_mba = 0x1000db9;

        [NativeTypeName("#define XK_Sinh_ya 0x1000dba")]
        public const int XK_Sinh_ya = 0x1000dba;

        [NativeTypeName("#define XK_Sinh_ra 0x1000dbb")]
        public const int XK_Sinh_ra = 0x1000dbb;

        [NativeTypeName("#define XK_Sinh_la 0x1000dbd")]
        public const int XK_Sinh_la = 0x1000dbd;

        [NativeTypeName("#define XK_Sinh_va 0x1000dc0")]
        public const int XK_Sinh_va = 0x1000dc0;

        [NativeTypeName("#define XK_Sinh_sha 0x1000dc1")]
        public const int XK_Sinh_sha = 0x1000dc1;

        [NativeTypeName("#define XK_Sinh_ssha 0x1000dc2")]
        public const int XK_Sinh_ssha = 0x1000dc2;

        [NativeTypeName("#define XK_Sinh_sa 0x1000dc3")]
        public const int XK_Sinh_sa = 0x1000dc3;

        [NativeTypeName("#define XK_Sinh_ha 0x1000dc4")]
        public const int XK_Sinh_ha = 0x1000dc4;

        [NativeTypeName("#define XK_Sinh_lla 0x1000dc5")]
        public const int XK_Sinh_lla = 0x1000dc5;

        [NativeTypeName("#define XK_Sinh_fa 0x1000dc6")]
        public const int XK_Sinh_fa = 0x1000dc6;

        [NativeTypeName("#define XK_Sinh_al 0x1000dca")]
        public const int XK_Sinh_al = 0x1000dca;

        [NativeTypeName("#define XK_Sinh_aa2 0x1000dcf")]
        public const int XK_Sinh_aa2 = 0x1000dcf;

        [NativeTypeName("#define XK_Sinh_ae2 0x1000dd0")]
        public const int XK_Sinh_ae2 = 0x1000dd0;

        [NativeTypeName("#define XK_Sinh_aee2 0x1000dd1")]
        public const int XK_Sinh_aee2 = 0x1000dd1;

        [NativeTypeName("#define XK_Sinh_i2 0x1000dd2")]
        public const int XK_Sinh_i2 = 0x1000dd2;

        [NativeTypeName("#define XK_Sinh_ii2 0x1000dd3")]
        public const int XK_Sinh_ii2 = 0x1000dd3;

        [NativeTypeName("#define XK_Sinh_u2 0x1000dd4")]
        public const int XK_Sinh_u2 = 0x1000dd4;

        [NativeTypeName("#define XK_Sinh_uu2 0x1000dd6")]
        public const int XK_Sinh_uu2 = 0x1000dd6;

        [NativeTypeName("#define XK_Sinh_ru2 0x1000dd8")]
        public const int XK_Sinh_ru2 = 0x1000dd8;

        [NativeTypeName("#define XK_Sinh_e2 0x1000dd9")]
        public const int XK_Sinh_e2 = 0x1000dd9;

        [NativeTypeName("#define XK_Sinh_ee2 0x1000dda")]
        public const int XK_Sinh_ee2 = 0x1000dda;

        [NativeTypeName("#define XK_Sinh_ai2 0x1000ddb")]
        public const int XK_Sinh_ai2 = 0x1000ddb;

        [NativeTypeName("#define XK_Sinh_o2 0x1000ddc")]
        public const int XK_Sinh_o2 = 0x1000ddc;

        [NativeTypeName("#define XK_Sinh_oo2 0x1000ddd")]
        public const int XK_Sinh_oo2 = 0x1000ddd;

        [NativeTypeName("#define XK_Sinh_au2 0x1000dde")]
        public const int XK_Sinh_au2 = 0x1000dde;

        [NativeTypeName("#define XK_Sinh_lu2 0x1000ddf")]
        public const int XK_Sinh_lu2 = 0x1000ddf;

        [NativeTypeName("#define XK_Sinh_ruu2 0x1000df2")]
        public const int XK_Sinh_ruu2 = 0x1000df2;

        [NativeTypeName("#define XK_Sinh_luu2 0x1000df3")]
        public const int XK_Sinh_luu2 = 0x1000df3;

        [NativeTypeName("#define XK_Sinh_kunddaliya 0x1000df4")]
        public const int XK_Sinh_kunddaliya = 0x1000df4;
    }
}
