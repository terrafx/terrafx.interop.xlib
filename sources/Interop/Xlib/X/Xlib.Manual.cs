// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\X.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop
{
    public static unsafe partial class Xlib
    {
        public const int X_PROTOCOL = 11;

        public const int X_PROTOCOL_REVISION = 0;

        public const int None = 0;

        public const int ParentRelative = 1;

        public const int CopyFromParent = 0;

        public const int PointerWindow = 0;

        public const int InputFocus = 1;

        public const int PointerRoot = 1;

        public const int AnyPropertyType = 0;

        public const int AnyKey = 0;

        public const int AnyButton = 0;

        public const int AllTemporary = 0;

        public const int CurrentTime = 0;

        public const int NoSymbol = 0;

        public const int NoEventMask = 0;

        public const int KeyPressMask = 1 << 0;

        public const int KeyReleaseMask = 1 << 1;

        public const int ButtonPressMask = 1 << 2;

        public const int ButtonReleaseMask = 1 << 3;

        public const int EnterWindowMask = 1 << 4;

        public const int LeaveWindowMask = 1 << 5;

        public const int PointerMotionMask = 1 << 6;

        public const int PointerMotionHintMask = 1 << 7;

        public const int Button1MotionMask = 1 << 8;

        public const int Button2MotionMask = 1 << 9;

        public const int Button3MotionMask = 1 << 10;

        public const int Button4MotionMask = 1 << 11;

        public const int Button5MotionMask = 1 << 12;

        public const int ButtonMotionMask = 1 << 13;

        public const int KeymapStateMask = 1 << 14;

        public const int ExposureMask = 1 << 15;

        public const int VisibilityChangeMask = 1 << 16;

        public const int StructureNotifyMask = 1 << 17;

        public const int ResizeRedirectMask = 1 << 18;

        public const int SubstructureNotifyMask = 1 << 19;

        public const int SubstructureRedirectMask = 1 << 20;

        public const int FocusChangeMask = 1 << 21;

        public const int PropertyChangeMask = 1 << 22;

        public const int ColormapChangeMask = 1 << 23;

        public const int OwnerGrabButtonMask = 1 << 24;

        public const int KeyPress = 2;

        public const int KeyRelease = 3;

        public const int ButtonPress = 4;

        public const int ButtonRelease = 5;

        public const int MotionNotify = 6;

        public const int EnterNotify = 7;

        public const int LeaveNotify = 8;

        public const int FocusIn = 9;

        public const int FocusOut = 10;

        public const int KeymapNotify = 11;

        public const int Expose = 12;

        public const int GraphicsExpose = 13;

        public const int NoExpose = 14;

        public const int VisibilityNotify = 15;

        public const int CreateNotify = 16;

        public const int DestroyNotify = 17;

        public const int UnmapNotify = 18;

        public const int MapNotify = 19;

        public const int MapRequest = 20;

        public const int ReparentNotify = 21;

        public const int ConfigureNotify = 22;

        public const int ConfigureRequest = 23;

        public const int GravityNotify = 24;

        public const int ResizeRequest = 25;

        public const int CirculateNotify = 26;

        public const int CirculateRequest = 27;

        public const int PropertyNotify = 28;

        public const int SelectionClear = 29;

        public const int SelectionRequest = 30;

        public const int SelectionNotify = 31;

        public const int ColormapNotify = 32;

        public const int ClientMessage = 33;

        public const int MappingNotify = 34;

        public const int GenericEvent = 35;

        public const int LASTEvent = 36;

        public const int ShiftMask = 1 << 0;

        public const int LockMask = 1 << 1;

        public const int ControlMask = 1 << 2;

        public const int Mod1Mask = 1 << 3;

        public const int Mod2Mask = 1 << 4;

        public const int Mod3Mask = 1 << 5;

        public const int Mod4Mask = 1 << 6;

        public const int Mod5Mask = 1 << 7;

        public const int ShiftMapIndex = 0;

        public const int LockMapIndex = 1;

        public const int ControlMapIndex = 2;

        public const int Mod1MapIndex = 3;

        public const int Mod2MapIndex = 4;

        public const int Mod3MapIndex = 5;

        public const int Mod4MapIndex = 6;

        public const int Mod5MapIndex = 7;

        public const int Button1Mask = 1 << 8;

        public const int Button2Mask = 1 << 9;

        public const int Button3Mask = 1 << 10;

        public const int Button4Mask = 1 << 11;

        public const int Button5Mask = 1 << 12;

        public const int AnyModifier = 1 << 15;

        public const int Button1 = 1;

        public const int Button2 = 2;

        public const int Button3 = 3;

        public const int Button4 = 4;

        public const int Button5 = 5;

        public const int NotifyNormal = 0;

        public const int NotifyGrab = 1;

        public const int NotifyUngrab = 2;

        public const int NotifyWhileGrabbed = 3;

        public const int NotifyHint = 1;

        public const int NotifyAncestor = 0;

        public const int NotifyVirtual = 1;

        public const int NotifyInferior = 2;

        public const int NotifyNonlinear = 3;

        public const int NotifyNonlinearVirtual = 4;

        public const int NotifyPointer = 5;

        public const int NotifyPointerRoot = 6;

        public const int NotifyDetailNone = 7;

        public const int VisibilityUnobscured = 0;

        public const int VisibilityPartiallyObscured = 1;

        public const int VisibilityFullyObscured = 2;

        public const int PlaceOnTop = 0;

        public const int PlaceOnBottom = 1;

        public const int FamilyInternet = 0;

        public const int FamilyDECnet = 1;

        public const int FamilyChaos = 2;

        public const int FamilyInternet6 = 6;

        public const int FamilyServerInterpreted = 5;

        public const int PropertyNewValue = 0;

        public const int PropertyDelete = 1;

        public const int ColormapUninstalled = 0;

        public const int ColormapInstalled = 1;

        public const int GrabModeSync = 0;

        public const int GrabModeAsync = 1;

        public const int GrabSuccess = 0;

        public const int AlreadyGrabbed = 1;

        public const int GrabInvalidTime = 2;

        public const int GrabNotViewable = 3;

        public const int GrabFrozen = 4;

        public const int AsyncPointer = 0;

        public const int SyncPointer = 1;

        public const int ReplayPointer = 2;

        public const int AsyncKeyboard = 3;

        public const int SyncKeyboard = 4;

        public const int ReplayKeyboard = 5;

        public const int AsyncBoth = 6;

        public const int SyncBoth = 7;

        public const int RevertToNone = (int)None;

        public const int RevertToPointerRoot = (int)PointerRoot;

        public const int RevertToParent = 2;

        public const int Success = 0;

        public const int BadRequest = 1;

        public const int BadValue = 2;

        public const int BadWindow = 3;

        public const int BadPixmap = 4;

        public const int BadAtom = 5;

        public const int BadCursor = 6;

        public const int BadFont = 7;

        public const int BadMatch = 8;

        public const int BadDrawable = 9;

        public const int BadAccess = 10;

        public const int BadAlloc = 11;

        public const int BadColor = 12;

        public const int BadGC = 13;

        public const int BadIDChoice = 14;

        public const int BadName = 15;

        public const int BadLength = 16;

        public const int BadImplementation = 17;

        public const int FirstExtensionError = 128;

        public const int LastExtensionError = 255;

        public const int InputOutput = 1;

        public const int InputOnly = 2;

        public const int CWBackPixmap = 1 << 0;

        public const int CWBackPixel = 1 << 1;

        public const int CWBorderPixmap = 1 << 2;

        public const int CWBorderPixel = 1 << 3;

        public const int CWBitGravity = 1 << 4;

        public const int CWWinGravity = 1 << 5;

        public const int CWBackingStore = 1 << 6;

        public const int CWBackingPlanes = 1 << 7;

        public const int CWBackingPixel = 1 << 8;

        public const int CWOverrideRedirect = 1 << 9;

        public const int CWSaveUnder = 1 << 10;

        public const int CWEventMask = 1 << 11;

        public const int CWDontPropagate = 1 << 12;

        public const int CWColormap = 1 << 13;

        public const int CWCursor = 1 << 14;

        public const int CWX = 1 << 0;

        public const int CWY = 1 << 1;

        public const int CWWidth = 1 << 2;

        public const int CWHeight = 1 << 3;

        public const int CWBorderWidth = 1 << 4;

        public const int CWSibling = 1 << 5;

        public const int CWStackMode = 1 << 6;

        public const int ForgetGravity = 0;

        public const int NorthWestGravity = 1;

        public const int NorthGravity = 2;

        public const int NorthEastGravity = 3;

        public const int WestGravity = 4;

        public const int CenterGravity = 5;

        public const int EastGravity = 6;

        public const int SouthWestGravity = 7;

        public const int SouthGravity = 8;

        public const int SouthEastGravity = 9;

        public const int StaticGravity = 10;

        public const int UnmapGravity = 0;

        public const int NotUseful = 0;

        public const int WhenMapped = 1;

        public const int Always = 2;

        public const int IsUnmapped = 0;

        public const int IsUnviewable = 1;

        public const int IsViewable = 2;

        public const int SetModeInsert = 0;

        public const int SetModeDelete = 1;

        public const int DestroyAll = 0;

        public const int RetainPermanent = 1;

        public const int RetainTemporary = 2;

        public const int Above = 0;

        public const int Below = 1;

        public const int TopIf = 2;

        public const int BottomIf = 3;

        public const int Opposite = 4;

        public const int RaiseLowest = 0;

        public const int LowerHighest = 1;

        public const int PropModeReplace = 0;

        public const int PropModePrepend = 1;

        public const int PropModeAppend = 2;

        public const int GXclear = 0x0;

        public const int GXand = 0x1;

        public const int GXandReverse = 0x2;

        public const int GXcopy = 0x3;

        public const int GXandInverted = 0x4;

        public const int GXnoop = 0x5;

        public const int GXxor = 0x6;

        public const int GXor = 0x7;

        public const int GXnor = 0x8;

        public const int GXequiv = 0x9;

        public const int GXinvert = 0xa;

        public const int GXorReverse = 0xb;

        public const int GXcopyInverted = 0xc;

        public const int GXorInverted = 0xd;

        public const int GXnand = 0xe;

        public const int GXset = 0xf;

        public const int LineSolid = 0;

        public const int LineOnOffDash = 1;

        public const int LineDoubleDash = 2;

        public const int CapNotLast = 0;

        public const int CapButt = 1;

        public const int CapRound = 2;

        public const int CapProjecting = 3;

        public const int JoinMiter = 0;

        public const int JoinRound = 1;

        public const int JoinBevel = 2;

        public const int FillSolid = 0;

        public const int FillTiled = 1;

        public const int FillStippled = 2;

        public const int FillOpaqueStippled = 3;

        public const int EvenOddRule = 0;

        public const int WindingRule = 1;

        public const int ClipByChildren = 0;

        public const int IncludeInferiors = 1;

        public const int Unsorted = 0;

        public const int YSorted = 1;

        public const int YXSorted = 2;

        public const int YXBanded = 3;

        public const int CoordModeOrigin = 0;

        public const int CoordModePrevious = 1;

        public const int Complex = 0;

        public const int Nonconvex = 1;

        public const int Convex = 2;

        public const int ArcChord = 0;

        public const int ArcPieSlice = 1;

        public const int GCFunction = 1 << 0;

        public const int GCPlaneMask = 1 << 1;

        public const int GCForeground = 1 << 2;

        public const int GCBackground = 1 << 3;

        public const int GCLineWidth = 1 << 4;

        public const int GCLineStyle = 1 << 5;

        public const int GCCapStyle = 1 << 6;

        public const int GCJoinStyle = 1 << 7;

        public const int GCFillStyle = 1 << 8;

        public const int GCFillRule = 1 << 9;

        public const int GCTile = 1 << 10;

        public const int GCStipple = 1 << 11;

        public const int GCTileStipXOrigin = 1 << 12;

        public const int GCTileStipYOrigin = 1 << 13;

        public const int GCFont = 1 << 14;

        public const int GCSubwindowMode = 1 << 15;

        public const int GCGraphicsExposures = 1 << 16;

        public const int GCClipXOrigin = 1 << 17;

        public const int GCClipYOrigin = 1 << 18;

        public const int GCClipMask = 1 << 19;

        public const int GCDashOffset = 1 << 20;

        public const int GCDashList = 1 << 21;

        public const int GCArcMode = 1 << 22;

        public const int GCLastBit = 22;

        public const int FontLeftToRight = 0;

        public const int FontRightToLeft = 1;

        public const int FontChange = 255;

        public const int XYBitmap = 0;

        public const int XYPixmap = 1;

        public const int ZPixmap = 2;

        public const int AllocNone = 0;

        public const int AllocAll = 1;

        public const int DoRed = 1 << 0;

        public const int DoGreen = 1 << 1;

        public const int DoBlue = 1 << 2;

        public const int CursorShape = 0;

        public const int TileShape = 1;

        public const int StippleShape = 2;

        public const int AutoRepeatModeOff = 0;

        public const int AutoRepeatModeOn = 1;

        public const int AutoRepeatModeDefault = 2;

        public const int LedModeOff = 0;

        public const int LedModeOn = 1;

        public const int KBKeyClickPercent = 1 << 0;

        public const int KBBellPercent = 1 << 1;

        public const int KBBellPitch = 1 << 2;

        public const int KBBellDuration = 1 << 3;

        public const int KBLed = 1 << 4;

        public const int KBLedMode = 1 << 5;

        public const int KBKey = 1 << 6;

        public const int KBAutoRepeatMode = 1 << 7;

        public const int MappingSuccess = 0;

        public const int MappingBusy = 1;

        public const int MappingFailed = 2;

        public const int MappingModifier = 0;

        public const int MappingKeyboard = 1;

        public const int MappingPointer = 2;

        public const int DontPreferBlanking = 0;

        public const int PreferBlanking = 1;

        public const int DefaultBlanking = 2;

        public const int DisableScreenSaver = 0;

        public const int DisableScreenInterval = 0;

        public const int DontAllowExposures = 0;

        public const int AllowExposures = 1;

        public const int DefaultExposures = 2;

        public const int ScreenSaverReset = 0;

        public const int ScreenSaverActive = 1;

        public const int HostInsert = 0;

        public const int HostDelete = 1;

        public const int EnableAccess = 1;

        public const int DisableAccess = 0;

        public const int StaticGray = 0;

        public const int GrayScale = 1;

        public const int StaticColor = 2;

        public const int PseudoColor = 3;

        public const int TrueColor = 4;

        public const int DirectColor = 5;

        public const int LSBFirst = 0;

        public const int MSBFirst = 1;
    }
}
