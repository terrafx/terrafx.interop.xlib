// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/X.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop.Xlib;

public static partial class Xlib
{
    [NativeTypeName("#define X_PROTOCOL 11")]
    public const int X_PROTOCOL = 11;

    [NativeTypeName("#define X_PROTOCOL_REVISION 0")]
    public const int X_PROTOCOL_REVISION = 0;

    [NativeTypeName("#define None 0L")]
    public const nint None = 0;

    [NativeTypeName("#define ParentRelative 1L")]
    public const nint ParentRelative = 1;

    [NativeTypeName("#define CopyFromParent 0L")]
    public const nint CopyFromParent = 0;

    [NativeTypeName("#define PointerWindow 0L")]
    public const nint PointerWindow = 0;

    [NativeTypeName("#define InputFocus 1L")]
    public const nint InputFocus = 1;

    [NativeTypeName("#define PointerRoot 1L")]
    public const nint PointerRoot = 1;

    [NativeTypeName("#define AnyPropertyType 0L")]
    public const nint AnyPropertyType = 0;

    [NativeTypeName("#define AnyKey 0L")]
    public const nint AnyKey = 0;

    [NativeTypeName("#define AnyButton 0L")]
    public const nint AnyButton = 0;

    [NativeTypeName("#define AllTemporary 0L")]
    public const nint AllTemporary = 0;

    [NativeTypeName("#define CurrentTime 0L")]
    public const nint CurrentTime = 0;

    [NativeTypeName("#define NoSymbol 0L")]
    public const nint NoSymbol = 0;

    [NativeTypeName("#define NoEventMask 0L")]
    public const nint NoEventMask = 0;

    [NativeTypeName("#define KeyPressMask (1L<<0)")]
    public const nint KeyPressMask = (1 << 0);

    [NativeTypeName("#define KeyReleaseMask (1L<<1)")]
    public const nint KeyReleaseMask = (1 << 1);

    [NativeTypeName("#define ButtonPressMask (1L<<2)")]
    public const nint ButtonPressMask = (1 << 2);

    [NativeTypeName("#define ButtonReleaseMask (1L<<3)")]
    public const nint ButtonReleaseMask = (1 << 3);

    [NativeTypeName("#define EnterWindowMask (1L<<4)")]
    public const nint EnterWindowMask = (1 << 4);

    [NativeTypeName("#define LeaveWindowMask (1L<<5)")]
    public const nint LeaveWindowMask = (1 << 5);

    [NativeTypeName("#define PointerMotionMask (1L<<6)")]
    public const nint PointerMotionMask = (1 << 6);

    [NativeTypeName("#define PointerMotionHintMask (1L<<7)")]
    public const nint PointerMotionHintMask = (1 << 7);

    [NativeTypeName("#define Button1MotionMask (1L<<8)")]
    public const nint Button1MotionMask = (1 << 8);

    [NativeTypeName("#define Button2MotionMask (1L<<9)")]
    public const nint Button2MotionMask = (1 << 9);

    [NativeTypeName("#define Button3MotionMask (1L<<10)")]
    public const nint Button3MotionMask = (1 << 10);

    [NativeTypeName("#define Button4MotionMask (1L<<11)")]
    public const nint Button4MotionMask = (1 << 11);

    [NativeTypeName("#define Button5MotionMask (1L<<12)")]
    public const nint Button5MotionMask = (1 << 12);

    [NativeTypeName("#define ButtonMotionMask (1L<<13)")]
    public const nint ButtonMotionMask = (1 << 13);

    [NativeTypeName("#define KeymapStateMask (1L<<14)")]
    public const nint KeymapStateMask = (1 << 14);

    [NativeTypeName("#define ExposureMask (1L<<15)")]
    public const nint ExposureMask = (1 << 15);

    [NativeTypeName("#define VisibilityChangeMask (1L<<16)")]
    public const nint VisibilityChangeMask = (1 << 16);

    [NativeTypeName("#define StructureNotifyMask (1L<<17)")]
    public const nint StructureNotifyMask = (1 << 17);

    [NativeTypeName("#define ResizeRedirectMask (1L<<18)")]
    public const nint ResizeRedirectMask = (1 << 18);

    [NativeTypeName("#define SubstructureNotifyMask (1L<<19)")]
    public const nint SubstructureNotifyMask = (1 << 19);

    [NativeTypeName("#define SubstructureRedirectMask (1L<<20)")]
    public const nint SubstructureRedirectMask = (1 << 20);

    [NativeTypeName("#define FocusChangeMask (1L<<21)")]
    public const nint FocusChangeMask = (1 << 21);

    [NativeTypeName("#define PropertyChangeMask (1L<<22)")]
    public const nint PropertyChangeMask = (1 << 22);

    [NativeTypeName("#define ColormapChangeMask (1L<<23)")]
    public const nint ColormapChangeMask = (1 << 23);

    [NativeTypeName("#define OwnerGrabButtonMask (1L<<24)")]
    public const nint OwnerGrabButtonMask = (1 << 24);

    [NativeTypeName("#define KeyPress 2")]
    public const int KeyPress = 2;

    [NativeTypeName("#define KeyRelease 3")]
    public const int KeyRelease = 3;

    [NativeTypeName("#define ButtonPress 4")]
    public const int ButtonPress = 4;

    [NativeTypeName("#define ButtonRelease 5")]
    public const int ButtonRelease = 5;

    [NativeTypeName("#define MotionNotify 6")]
    public const int MotionNotify = 6;

    [NativeTypeName("#define EnterNotify 7")]
    public const int EnterNotify = 7;

    [NativeTypeName("#define LeaveNotify 8")]
    public const int LeaveNotify = 8;

    [NativeTypeName("#define FocusIn 9")]
    public const int FocusIn = 9;

    [NativeTypeName("#define FocusOut 10")]
    public const int FocusOut = 10;

    [NativeTypeName("#define KeymapNotify 11")]
    public const int KeymapNotify = 11;

    [NativeTypeName("#define Expose 12")]
    public const int Expose = 12;

    [NativeTypeName("#define GraphicsExpose 13")]
    public const int GraphicsExpose = 13;

    [NativeTypeName("#define NoExpose 14")]
    public const int NoExpose = 14;

    [NativeTypeName("#define VisibilityNotify 15")]
    public const int VisibilityNotify = 15;

    [NativeTypeName("#define CreateNotify 16")]
    public const int CreateNotify = 16;

    [NativeTypeName("#define DestroyNotify 17")]
    public const int DestroyNotify = 17;

    [NativeTypeName("#define UnmapNotify 18")]
    public const int UnmapNotify = 18;

    [NativeTypeName("#define MapNotify 19")]
    public const int MapNotify = 19;

    [NativeTypeName("#define MapRequest 20")]
    public const int MapRequest = 20;

    [NativeTypeName("#define ReparentNotify 21")]
    public const int ReparentNotify = 21;

    [NativeTypeName("#define ConfigureNotify 22")]
    public const int ConfigureNotify = 22;

    [NativeTypeName("#define ConfigureRequest 23")]
    public const int ConfigureRequest = 23;

    [NativeTypeName("#define GravityNotify 24")]
    public const int GravityNotify = 24;

    [NativeTypeName("#define ResizeRequest 25")]
    public const int ResizeRequest = 25;

    [NativeTypeName("#define CirculateNotify 26")]
    public const int CirculateNotify = 26;

    [NativeTypeName("#define CirculateRequest 27")]
    public const int CirculateRequest = 27;

    [NativeTypeName("#define PropertyNotify 28")]
    public const int PropertyNotify = 28;

    [NativeTypeName("#define SelectionClear 29")]
    public const int SelectionClear = 29;

    [NativeTypeName("#define SelectionRequest 30")]
    public const int SelectionRequest = 30;

    [NativeTypeName("#define SelectionNotify 31")]
    public const int SelectionNotify = 31;

    [NativeTypeName("#define ColormapNotify 32")]
    public const int ColormapNotify = 32;

    [NativeTypeName("#define ClientMessage 33")]
    public const int ClientMessage = 33;

    [NativeTypeName("#define MappingNotify 34")]
    public const int MappingNotify = 34;

    [NativeTypeName("#define GenericEvent 35")]
    public const int GenericEvent = 35;

    [NativeTypeName("#define LASTEvent 36")]
    public const int LASTEvent = 36;

    [NativeTypeName("#define ShiftMask (1<<0)")]
    public const int ShiftMask = (1 << 0);

    [NativeTypeName("#define LockMask (1<<1)")]
    public const int LockMask = (1 << 1);

    [NativeTypeName("#define ControlMask (1<<2)")]
    public const int ControlMask = (1 << 2);

    [NativeTypeName("#define Mod1Mask (1<<3)")]
    public const int Mod1Mask = (1 << 3);

    [NativeTypeName("#define Mod2Mask (1<<4)")]
    public const int Mod2Mask = (1 << 4);

    [NativeTypeName("#define Mod3Mask (1<<5)")]
    public const int Mod3Mask = (1 << 5);

    [NativeTypeName("#define Mod4Mask (1<<6)")]
    public const int Mod4Mask = (1 << 6);

    [NativeTypeName("#define Mod5Mask (1<<7)")]
    public const int Mod5Mask = (1 << 7);

    [NativeTypeName("#define ShiftMapIndex 0")]
    public const int ShiftMapIndex = 0;

    [NativeTypeName("#define LockMapIndex 1")]
    public const int LockMapIndex = 1;

    [NativeTypeName("#define ControlMapIndex 2")]
    public const int ControlMapIndex = 2;

    [NativeTypeName("#define Mod1MapIndex 3")]
    public const int Mod1MapIndex = 3;

    [NativeTypeName("#define Mod2MapIndex 4")]
    public const int Mod2MapIndex = 4;

    [NativeTypeName("#define Mod3MapIndex 5")]
    public const int Mod3MapIndex = 5;

    [NativeTypeName("#define Mod4MapIndex 6")]
    public const int Mod4MapIndex = 6;

    [NativeTypeName("#define Mod5MapIndex 7")]
    public const int Mod5MapIndex = 7;

    [NativeTypeName("#define Button1Mask (1<<8)")]
    public const int Button1Mask = (1 << 8);

    [NativeTypeName("#define Button2Mask (1<<9)")]
    public const int Button2Mask = (1 << 9);

    [NativeTypeName("#define Button3Mask (1<<10)")]
    public const int Button3Mask = (1 << 10);

    [NativeTypeName("#define Button4Mask (1<<11)")]
    public const int Button4Mask = (1 << 11);

    [NativeTypeName("#define Button5Mask (1<<12)")]
    public const int Button5Mask = (1 << 12);

    [NativeTypeName("#define AnyModifier (1<<15)")]
    public const int AnyModifier = (1 << 15);

    [NativeTypeName("#define Button1 1")]
    public const int Button1 = 1;

    [NativeTypeName("#define Button2 2")]
    public const int Button2 = 2;

    [NativeTypeName("#define Button3 3")]
    public const int Button3 = 3;

    [NativeTypeName("#define Button4 4")]
    public const int Button4 = 4;

    [NativeTypeName("#define Button5 5")]
    public const int Button5 = 5;

    [NativeTypeName("#define NotifyNormal 0")]
    public const int NotifyNormal = 0;

    [NativeTypeName("#define NotifyGrab 1")]
    public const int NotifyGrab = 1;

    [NativeTypeName("#define NotifyUngrab 2")]
    public const int NotifyUngrab = 2;

    [NativeTypeName("#define NotifyWhileGrabbed 3")]
    public const int NotifyWhileGrabbed = 3;

    [NativeTypeName("#define NotifyHint 1")]
    public const int NotifyHint = 1;

    [NativeTypeName("#define NotifyAncestor 0")]
    public const int NotifyAncestor = 0;

    [NativeTypeName("#define NotifyVirtual 1")]
    public const int NotifyVirtual = 1;

    [NativeTypeName("#define NotifyInferior 2")]
    public const int NotifyInferior = 2;

    [NativeTypeName("#define NotifyNonlinear 3")]
    public const int NotifyNonlinear = 3;

    [NativeTypeName("#define NotifyNonlinearVirtual 4")]
    public const int NotifyNonlinearVirtual = 4;

    [NativeTypeName("#define NotifyPointer 5")]
    public const int NotifyPointer = 5;

    [NativeTypeName("#define NotifyPointerRoot 6")]
    public const int NotifyPointerRoot = 6;

    [NativeTypeName("#define NotifyDetailNone 7")]
    public const int NotifyDetailNone = 7;

    [NativeTypeName("#define VisibilityUnobscured 0")]
    public const int VisibilityUnobscured = 0;

    [NativeTypeName("#define VisibilityPartiallyObscured 1")]
    public const int VisibilityPartiallyObscured = 1;

    [NativeTypeName("#define VisibilityFullyObscured 2")]
    public const int VisibilityFullyObscured = 2;

    [NativeTypeName("#define PlaceOnTop 0")]
    public const int PlaceOnTop = 0;

    [NativeTypeName("#define PlaceOnBottom 1")]
    public const int PlaceOnBottom = 1;

    [NativeTypeName("#define FamilyInternet 0")]
    public const int FamilyInternet = 0;

    [NativeTypeName("#define FamilyDECnet 1")]
    public const int FamilyDECnet = 1;

    [NativeTypeName("#define FamilyChaos 2")]
    public const int FamilyChaos = 2;

    [NativeTypeName("#define FamilyInternet6 6")]
    public const int FamilyInternet6 = 6;

    [NativeTypeName("#define FamilyServerInterpreted 5")]
    public const int FamilyServerInterpreted = 5;

    [NativeTypeName("#define PropertyNewValue 0")]
    public const int PropertyNewValue = 0;

    [NativeTypeName("#define PropertyDelete 1")]
    public const int PropertyDelete = 1;

    [NativeTypeName("#define ColormapUninstalled 0")]
    public const int ColormapUninstalled = 0;

    [NativeTypeName("#define ColormapInstalled 1")]
    public const int ColormapInstalled = 1;

    [NativeTypeName("#define GrabModeSync 0")]
    public const int GrabModeSync = 0;

    [NativeTypeName("#define GrabModeAsync 1")]
    public const int GrabModeAsync = 1;

    [NativeTypeName("#define GrabSuccess 0")]
    public const int GrabSuccess = 0;

    [NativeTypeName("#define AlreadyGrabbed 1")]
    public const int AlreadyGrabbed = 1;

    [NativeTypeName("#define GrabInvalidTime 2")]
    public const int GrabInvalidTime = 2;

    [NativeTypeName("#define GrabNotViewable 3")]
    public const int GrabNotViewable = 3;

    [NativeTypeName("#define GrabFrozen 4")]
    public const int GrabFrozen = 4;

    [NativeTypeName("#define AsyncPointer 0")]
    public const int AsyncPointer = 0;

    [NativeTypeName("#define SyncPointer 1")]
    public const int SyncPointer = 1;

    [NativeTypeName("#define ReplayPointer 2")]
    public const int ReplayPointer = 2;

    [NativeTypeName("#define AsyncKeyboard 3")]
    public const int AsyncKeyboard = 3;

    [NativeTypeName("#define SyncKeyboard 4")]
    public const int SyncKeyboard = 4;

    [NativeTypeName("#define ReplayKeyboard 5")]
    public const int ReplayKeyboard = 5;

    [NativeTypeName("#define AsyncBoth 6")]
    public const int AsyncBoth = 6;

    [NativeTypeName("#define SyncBoth 7")]
    public const int SyncBoth = 7;

    [NativeTypeName("#define RevertToNone (int)None")]
    public const int RevertToNone = (int)(0);

    [NativeTypeName("#define RevertToPointerRoot (int)PointerRoot")]
    public const int RevertToPointerRoot = (int)(1);

    [NativeTypeName("#define RevertToParent 2")]
    public const int RevertToParent = 2;

    [NativeTypeName("#define Success 0")]
    public const int Success = 0;

    [NativeTypeName("#define BadRequest 1")]
    public const int BadRequest = 1;

    [NativeTypeName("#define BadValue 2")]
    public const int BadValue = 2;

    [NativeTypeName("#define BadWindow 3")]
    public const int BadWindow = 3;

    [NativeTypeName("#define BadPixmap 4")]
    public const int BadPixmap = 4;

    [NativeTypeName("#define BadAtom 5")]
    public const int BadAtom = 5;

    [NativeTypeName("#define BadCursor 6")]
    public const int BadCursor = 6;

    [NativeTypeName("#define BadFont 7")]
    public const int BadFont = 7;

    [NativeTypeName("#define BadMatch 8")]
    public const int BadMatch = 8;

    [NativeTypeName("#define BadDrawable 9")]
    public const int BadDrawable = 9;

    [NativeTypeName("#define BadAccess 10")]
    public const int BadAccess = 10;

    [NativeTypeName("#define BadAlloc 11")]
    public const int BadAlloc = 11;

    [NativeTypeName("#define BadColor 12")]
    public const int BadColor = 12;

    [NativeTypeName("#define BadGC 13")]
    public const int BadGC = 13;

    [NativeTypeName("#define BadIDChoice 14")]
    public const int BadIDChoice = 14;

    [NativeTypeName("#define BadName 15")]
    public const int BadName = 15;

    [NativeTypeName("#define BadLength 16")]
    public const int BadLength = 16;

    [NativeTypeName("#define BadImplementation 17")]
    public const int BadImplementation = 17;

    [NativeTypeName("#define FirstExtensionError 128")]
    public const int FirstExtensionError = 128;

    [NativeTypeName("#define LastExtensionError 255")]
    public const int LastExtensionError = 255;

    [NativeTypeName("#define InputOutput 1")]
    public const int InputOutput = 1;

    [NativeTypeName("#define InputOnly 2")]
    public const int InputOnly = 2;

    [NativeTypeName("#define CWBackPixmap (1L<<0)")]
    public const nint CWBackPixmap = (1 << 0);

    [NativeTypeName("#define CWBackPixel (1L<<1)")]
    public const nint CWBackPixel = (1 << 1);

    [NativeTypeName("#define CWBorderPixmap (1L<<2)")]
    public const nint CWBorderPixmap = (1 << 2);

    [NativeTypeName("#define CWBorderPixel (1L<<3)")]
    public const nint CWBorderPixel = (1 << 3);

    [NativeTypeName("#define CWBitGravity (1L<<4)")]
    public const nint CWBitGravity = (1 << 4);

    [NativeTypeName("#define CWWinGravity (1L<<5)")]
    public const nint CWWinGravity = (1 << 5);

    [NativeTypeName("#define CWBackingStore (1L<<6)")]
    public const nint CWBackingStore = (1 << 6);

    [NativeTypeName("#define CWBackingPlanes (1L<<7)")]
    public const nint CWBackingPlanes = (1 << 7);

    [NativeTypeName("#define CWBackingPixel (1L<<8)")]
    public const nint CWBackingPixel = (1 << 8);

    [NativeTypeName("#define CWOverrideRedirect (1L<<9)")]
    public const nint CWOverrideRedirect = (1 << 9);

    [NativeTypeName("#define CWSaveUnder (1L<<10)")]
    public const nint CWSaveUnder = (1 << 10);

    [NativeTypeName("#define CWEventMask (1L<<11)")]
    public const nint CWEventMask = (1 << 11);

    [NativeTypeName("#define CWDontPropagate (1L<<12)")]
    public const nint CWDontPropagate = (1 << 12);

    [NativeTypeName("#define CWColormap (1L<<13)")]
    public const nint CWColormap = (1 << 13);

    [NativeTypeName("#define CWCursor (1L<<14)")]
    public const nint CWCursor = (1 << 14);

    [NativeTypeName("#define CWX (1<<0)")]
    public const int CWX = (1 << 0);

    [NativeTypeName("#define CWY (1<<1)")]
    public const int CWY = (1 << 1);

    [NativeTypeName("#define CWWidth (1<<2)")]
    public const int CWWidth = (1 << 2);

    [NativeTypeName("#define CWHeight (1<<3)")]
    public const int CWHeight = (1 << 3);

    [NativeTypeName("#define CWBorderWidth (1<<4)")]
    public const int CWBorderWidth = (1 << 4);

    [NativeTypeName("#define CWSibling (1<<5)")]
    public const int CWSibling = (1 << 5);

    [NativeTypeName("#define CWStackMode (1<<6)")]
    public const int CWStackMode = (1 << 6);

    [NativeTypeName("#define ForgetGravity 0")]
    public const int ForgetGravity = 0;

    [NativeTypeName("#define NorthWestGravity 1")]
    public const int NorthWestGravity = 1;

    [NativeTypeName("#define NorthGravity 2")]
    public const int NorthGravity = 2;

    [NativeTypeName("#define NorthEastGravity 3")]
    public const int NorthEastGravity = 3;

    [NativeTypeName("#define WestGravity 4")]
    public const int WestGravity = 4;

    [NativeTypeName("#define CenterGravity 5")]
    public const int CenterGravity = 5;

    [NativeTypeName("#define EastGravity 6")]
    public const int EastGravity = 6;

    [NativeTypeName("#define SouthWestGravity 7")]
    public const int SouthWestGravity = 7;

    [NativeTypeName("#define SouthGravity 8")]
    public const int SouthGravity = 8;

    [NativeTypeName("#define SouthEastGravity 9")]
    public const int SouthEastGravity = 9;

    [NativeTypeName("#define StaticGravity 10")]
    public const int StaticGravity = 10;

    [NativeTypeName("#define UnmapGravity 0")]
    public const int UnmapGravity = 0;

    [NativeTypeName("#define NotUseful 0")]
    public const int NotUseful = 0;

    [NativeTypeName("#define WhenMapped 1")]
    public const int WhenMapped = 1;

    [NativeTypeName("#define Always 2")]
    public const int Always = 2;

    [NativeTypeName("#define IsUnmapped 0")]
    public const int IsUnmapped = 0;

    [NativeTypeName("#define IsUnviewable 1")]
    public const int IsUnviewable = 1;

    [NativeTypeName("#define IsViewable 2")]
    public const int IsViewable = 2;

    [NativeTypeName("#define SetModeInsert 0")]
    public const int SetModeInsert = 0;

    [NativeTypeName("#define SetModeDelete 1")]
    public const int SetModeDelete = 1;

    [NativeTypeName("#define DestroyAll 0")]
    public const int DestroyAll = 0;

    [NativeTypeName("#define RetainPermanent 1")]
    public const int RetainPermanent = 1;

    [NativeTypeName("#define RetainTemporary 2")]
    public const int RetainTemporary = 2;

    [NativeTypeName("#define Above 0")]
    public const int Above = 0;

    [NativeTypeName("#define Below 1")]
    public const int Below = 1;

    [NativeTypeName("#define TopIf 2")]
    public const int TopIf = 2;

    [NativeTypeName("#define BottomIf 3")]
    public const int BottomIf = 3;

    [NativeTypeName("#define Opposite 4")]
    public const int Opposite = 4;

    [NativeTypeName("#define RaiseLowest 0")]
    public const int RaiseLowest = 0;

    [NativeTypeName("#define LowerHighest 1")]
    public const int LowerHighest = 1;

    [NativeTypeName("#define PropModeReplace 0")]
    public const int PropModeReplace = 0;

    [NativeTypeName("#define PropModePrepend 1")]
    public const int PropModePrepend = 1;

    [NativeTypeName("#define PropModeAppend 2")]
    public const int PropModeAppend = 2;

    [NativeTypeName("#define GXclear 0x0")]
    public const int GXclear = 0x0;

    [NativeTypeName("#define GXand 0x1")]
    public const int GXand = 0x1;

    [NativeTypeName("#define GXandReverse 0x2")]
    public const int GXandReverse = 0x2;

    [NativeTypeName("#define GXcopy 0x3")]
    public const int GXcopy = 0x3;

    [NativeTypeName("#define GXandInverted 0x4")]
    public const int GXandInverted = 0x4;

    [NativeTypeName("#define GXnoop 0x5")]
    public const int GXnoop = 0x5;

    [NativeTypeName("#define GXxor 0x6")]
    public const int GXxor = 0x6;

    [NativeTypeName("#define GXor 0x7")]
    public const int GXor = 0x7;

    [NativeTypeName("#define GXnor 0x8")]
    public const int GXnor = 0x8;

    [NativeTypeName("#define GXequiv 0x9")]
    public const int GXequiv = 0x9;

    [NativeTypeName("#define GXinvert 0xa")]
    public const int GXinvert = 0xa;

    [NativeTypeName("#define GXorReverse 0xb")]
    public const int GXorReverse = 0xb;

    [NativeTypeName("#define GXcopyInverted 0xc")]
    public const int GXcopyInverted = 0xc;

    [NativeTypeName("#define GXorInverted 0xd")]
    public const int GXorInverted = 0xd;

    [NativeTypeName("#define GXnand 0xe")]
    public const int GXnand = 0xe;

    [NativeTypeName("#define GXset 0xf")]
    public const int GXset = 0xf;

    [NativeTypeName("#define LineSolid 0")]
    public const int LineSolid = 0;

    [NativeTypeName("#define LineOnOffDash 1")]
    public const int LineOnOffDash = 1;

    [NativeTypeName("#define LineDoubleDash 2")]
    public const int LineDoubleDash = 2;

    [NativeTypeName("#define CapNotLast 0")]
    public const int CapNotLast = 0;

    [NativeTypeName("#define CapButt 1")]
    public const int CapButt = 1;

    [NativeTypeName("#define CapRound 2")]
    public const int CapRound = 2;

    [NativeTypeName("#define CapProjecting 3")]
    public const int CapProjecting = 3;

    [NativeTypeName("#define JoinMiter 0")]
    public const int JoinMiter = 0;

    [NativeTypeName("#define JoinRound 1")]
    public const int JoinRound = 1;

    [NativeTypeName("#define JoinBevel 2")]
    public const int JoinBevel = 2;

    [NativeTypeName("#define FillSolid 0")]
    public const int FillSolid = 0;

    [NativeTypeName("#define FillTiled 1")]
    public const int FillTiled = 1;

    [NativeTypeName("#define FillStippled 2")]
    public const int FillStippled = 2;

    [NativeTypeName("#define FillOpaqueStippled 3")]
    public const int FillOpaqueStippled = 3;

    [NativeTypeName("#define EvenOddRule 0")]
    public const int EvenOddRule = 0;

    [NativeTypeName("#define WindingRule 1")]
    public const int WindingRule = 1;

    [NativeTypeName("#define ClipByChildren 0")]
    public const int ClipByChildren = 0;

    [NativeTypeName("#define IncludeInferiors 1")]
    public const int IncludeInferiors = 1;

    [NativeTypeName("#define Unsorted 0")]
    public const int Unsorted = 0;

    [NativeTypeName("#define YSorted 1")]
    public const int YSorted = 1;

    [NativeTypeName("#define YXSorted 2")]
    public const int YXSorted = 2;

    [NativeTypeName("#define YXBanded 3")]
    public const int YXBanded = 3;

    [NativeTypeName("#define CoordModeOrigin 0")]
    public const int CoordModeOrigin = 0;

    [NativeTypeName("#define CoordModePrevious 1")]
    public const int CoordModePrevious = 1;

    [NativeTypeName("#define Complex 0")]
    public const int Complex = 0;

    [NativeTypeName("#define Nonconvex 1")]
    public const int Nonconvex = 1;

    [NativeTypeName("#define Convex 2")]
    public const int Convex = 2;

    [NativeTypeName("#define ArcChord 0")]
    public const int ArcChord = 0;

    [NativeTypeName("#define ArcPieSlice 1")]
    public const int ArcPieSlice = 1;

    [NativeTypeName("#define GCFunction (1L<<0)")]
    public const nint GCFunction = (1 << 0);

    [NativeTypeName("#define GCPlaneMask (1L<<1)")]
    public const nint GCPlaneMask = (1 << 1);

    [NativeTypeName("#define GCForeground (1L<<2)")]
    public const nint GCForeground = (1 << 2);

    [NativeTypeName("#define GCBackground (1L<<3)")]
    public const nint GCBackground = (1 << 3);

    [NativeTypeName("#define GCLineWidth (1L<<4)")]
    public const nint GCLineWidth = (1 << 4);

    [NativeTypeName("#define GCLineStyle (1L<<5)")]
    public const nint GCLineStyle = (1 << 5);

    [NativeTypeName("#define GCCapStyle (1L<<6)")]
    public const nint GCCapStyle = (1 << 6);

    [NativeTypeName("#define GCJoinStyle (1L<<7)")]
    public const nint GCJoinStyle = (1 << 7);

    [NativeTypeName("#define GCFillStyle (1L<<8)")]
    public const nint GCFillStyle = (1 << 8);

    [NativeTypeName("#define GCFillRule (1L<<9)")]
    public const nint GCFillRule = (1 << 9);

    [NativeTypeName("#define GCTile (1L<<10)")]
    public const nint GCTile = (1 << 10);

    [NativeTypeName("#define GCStipple (1L<<11)")]
    public const nint GCStipple = (1 << 11);

    [NativeTypeName("#define GCTileStipXOrigin (1L<<12)")]
    public const nint GCTileStipXOrigin = (1 << 12);

    [NativeTypeName("#define GCTileStipYOrigin (1L<<13)")]
    public const nint GCTileStipYOrigin = (1 << 13);

    [NativeTypeName("#define GCFont (1L<<14)")]
    public const nint GCFont = (1 << 14);

    [NativeTypeName("#define GCSubwindowMode (1L<<15)")]
    public const nint GCSubwindowMode = (1 << 15);

    [NativeTypeName("#define GCGraphicsExposures (1L<<16)")]
    public const nint GCGraphicsExposures = (1 << 16);

    [NativeTypeName("#define GCClipXOrigin (1L<<17)")]
    public const nint GCClipXOrigin = (1 << 17);

    [NativeTypeName("#define GCClipYOrigin (1L<<18)")]
    public const nint GCClipYOrigin = (1 << 18);

    [NativeTypeName("#define GCClipMask (1L<<19)")]
    public const nint GCClipMask = (1 << 19);

    [NativeTypeName("#define GCDashOffset (1L<<20)")]
    public const nint GCDashOffset = (1 << 20);

    [NativeTypeName("#define GCDashList (1L<<21)")]
    public const nint GCDashList = (1 << 21);

    [NativeTypeName("#define GCArcMode (1L<<22)")]
    public const nint GCArcMode = (1 << 22);

    [NativeTypeName("#define GCLastBit 22")]
    public const int GCLastBit = 22;

    [NativeTypeName("#define FontLeftToRight 0")]
    public const int FontLeftToRight = 0;

    [NativeTypeName("#define FontRightToLeft 1")]
    public const int FontRightToLeft = 1;

    [NativeTypeName("#define FontChange 255")]
    public const int FontChange = 255;

    [NativeTypeName("#define XYBitmap 0")]
    public const int XYBitmap = 0;

    [NativeTypeName("#define XYPixmap 1")]
    public const int XYPixmap = 1;

    [NativeTypeName("#define ZPixmap 2")]
    public const int ZPixmap = 2;

    [NativeTypeName("#define AllocNone 0")]
    public const int AllocNone = 0;

    [NativeTypeName("#define AllocAll 1")]
    public const int AllocAll = 1;

    [NativeTypeName("#define DoRed (1<<0)")]
    public const int DoRed = (1 << 0);

    [NativeTypeName("#define DoGreen (1<<1)")]
    public const int DoGreen = (1 << 1);

    [NativeTypeName("#define DoBlue (1<<2)")]
    public const int DoBlue = (1 << 2);

    [NativeTypeName("#define CursorShape 0")]
    public const int CursorShape = 0;

    [NativeTypeName("#define TileShape 1")]
    public const int TileShape = 1;

    [NativeTypeName("#define StippleShape 2")]
    public const int StippleShape = 2;

    [NativeTypeName("#define AutoRepeatModeOff 0")]
    public const int AutoRepeatModeOff = 0;

    [NativeTypeName("#define AutoRepeatModeOn 1")]
    public const int AutoRepeatModeOn = 1;

    [NativeTypeName("#define AutoRepeatModeDefault 2")]
    public const int AutoRepeatModeDefault = 2;

    [NativeTypeName("#define LedModeOff 0")]
    public const int LedModeOff = 0;

    [NativeTypeName("#define LedModeOn 1")]
    public const int LedModeOn = 1;

    [NativeTypeName("#define KBKeyClickPercent (1L<<0)")]
    public const nint KBKeyClickPercent = (1 << 0);

    [NativeTypeName("#define KBBellPercent (1L<<1)")]
    public const nint KBBellPercent = (1 << 1);

    [NativeTypeName("#define KBBellPitch (1L<<2)")]
    public const nint KBBellPitch = (1 << 2);

    [NativeTypeName("#define KBBellDuration (1L<<3)")]
    public const nint KBBellDuration = (1 << 3);

    [NativeTypeName("#define KBLed (1L<<4)")]
    public const nint KBLed = (1 << 4);

    [NativeTypeName("#define KBLedMode (1L<<5)")]
    public const nint KBLedMode = (1 << 5);

    [NativeTypeName("#define KBKey (1L<<6)")]
    public const nint KBKey = (1 << 6);

    [NativeTypeName("#define KBAutoRepeatMode (1L<<7)")]
    public const nint KBAutoRepeatMode = (1 << 7);

    [NativeTypeName("#define MappingSuccess 0")]
    public const int MappingSuccess = 0;

    [NativeTypeName("#define MappingBusy 1")]
    public const int MappingBusy = 1;

    [NativeTypeName("#define MappingFailed 2")]
    public const int MappingFailed = 2;

    [NativeTypeName("#define MappingModifier 0")]
    public const int MappingModifier = 0;

    [NativeTypeName("#define MappingKeyboard 1")]
    public const int MappingKeyboard = 1;

    [NativeTypeName("#define MappingPointer 2")]
    public const int MappingPointer = 2;

    [NativeTypeName("#define DontPreferBlanking 0")]
    public const int DontPreferBlanking = 0;

    [NativeTypeName("#define PreferBlanking 1")]
    public const int PreferBlanking = 1;

    [NativeTypeName("#define DefaultBlanking 2")]
    public const int DefaultBlanking = 2;

    [NativeTypeName("#define DisableScreenSaver 0")]
    public const int DisableScreenSaver = 0;

    [NativeTypeName("#define DisableScreenInterval 0")]
    public const int DisableScreenInterval = 0;

    [NativeTypeName("#define DontAllowExposures 0")]
    public const int DontAllowExposures = 0;

    [NativeTypeName("#define AllowExposures 1")]
    public const int AllowExposures = 1;

    [NativeTypeName("#define DefaultExposures 2")]
    public const int DefaultExposures = 2;

    [NativeTypeName("#define ScreenSaverReset 0")]
    public const int ScreenSaverReset = 0;

    [NativeTypeName("#define ScreenSaverActive 1")]
    public const int ScreenSaverActive = 1;

    [NativeTypeName("#define HostInsert 0")]
    public const int HostInsert = 0;

    [NativeTypeName("#define HostDelete 1")]
    public const int HostDelete = 1;

    [NativeTypeName("#define EnableAccess 1")]
    public const int EnableAccess = 1;

    [NativeTypeName("#define DisableAccess 0")]
    public const int DisableAccess = 0;

    [NativeTypeName("#define StaticGray 0")]
    public const int StaticGray = 0;

    [NativeTypeName("#define GrayScale 1")]
    public const int GrayScale = 1;

    [NativeTypeName("#define StaticColor 2")]
    public const int StaticColor = 2;

    [NativeTypeName("#define PseudoColor 3")]
    public const int PseudoColor = 3;

    [NativeTypeName("#define TrueColor 4")]
    public const int TrueColor = 4;

    [NativeTypeName("#define DirectColor 5")]
    public const int DirectColor = 5;

    [NativeTypeName("#define LSBFirst 0")]
    public const int LSBFirst = 0;

    [NativeTypeName("#define MSBFirst 1")]
    public const int MSBFirst = 1;
}
