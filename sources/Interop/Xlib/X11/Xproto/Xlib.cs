// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xproto.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop.Xlib;

public static partial class Xlib
{
    [NativeTypeName("#define sz_xSegment 8")]
    public const int sz_xSegment = 8;

    [NativeTypeName("#define sz_xPoint 4")]
    public const int sz_xPoint = 4;

    [NativeTypeName("#define sz_xRectangle 8")]
    public const int sz_xRectangle = 8;

    [NativeTypeName("#define sz_xArc 12")]
    public const int sz_xArc = 12;

    [NativeTypeName("#define sz_xConnClientPrefix 12")]
    public const int sz_xConnClientPrefix = 12;

    [NativeTypeName("#define sz_xConnSetupPrefix 8")]
    public const int sz_xConnSetupPrefix = 8;

    [NativeTypeName("#define sz_xConnSetup 32")]
    public const int sz_xConnSetup = 32;

    [NativeTypeName("#define sz_xPixmapFormat 8")]
    public const int sz_xPixmapFormat = 8;

    [NativeTypeName("#define sz_xDepth 8")]
    public const int sz_xDepth = 8;

    [NativeTypeName("#define sz_xVisualType 24")]
    public const int sz_xVisualType = 24;

    [NativeTypeName("#define sz_xWindowRoot 40")]
    public const int sz_xWindowRoot = 40;

    [NativeTypeName("#define sz_xTimecoord 8")]
    public const int sz_xTimecoord = 8;

    [NativeTypeName("#define sz_xHostEntry 4")]
    public const int sz_xHostEntry = 4;

    [NativeTypeName("#define sz_xCharInfo 12")]
    public const int sz_xCharInfo = 12;

    [NativeTypeName("#define sz_xFontProp 8")]
    public const int sz_xFontProp = 8;

    [NativeTypeName("#define sz_xTextElt 2")]
    public const int sz_xTextElt = 2;

    [NativeTypeName("#define sz_xColorItem 12")]
    public const int sz_xColorItem = 12;

    [NativeTypeName("#define sz_xrgb 8")]
    public const int sz_xrgb = 8;

    [NativeTypeName("#define sz_xGenericReply 32")]
    public const int sz_xGenericReply = 32;

    [NativeTypeName("#define sz_xGetWindowAttributesReply 44")]
    public const int sz_xGetWindowAttributesReply = 44;

    [NativeTypeName("#define sz_xGetGeometryReply 32")]
    public const int sz_xGetGeometryReply = 32;

    [NativeTypeName("#define sz_xQueryTreeReply 32")]
    public const int sz_xQueryTreeReply = 32;

    [NativeTypeName("#define sz_xInternAtomReply 32")]
    public const int sz_xInternAtomReply = 32;

    [NativeTypeName("#define sz_xGetAtomNameReply 32")]
    public const int sz_xGetAtomNameReply = 32;

    [NativeTypeName("#define sz_xGetPropertyReply 32")]
    public const int sz_xGetPropertyReply = 32;

    [NativeTypeName("#define sz_xListPropertiesReply 32")]
    public const int sz_xListPropertiesReply = 32;

    [NativeTypeName("#define sz_xGetSelectionOwnerReply 32")]
    public const int sz_xGetSelectionOwnerReply = 32;

    [NativeTypeName("#define sz_xGrabPointerReply 32")]
    public const int sz_xGrabPointerReply = 32;

    [NativeTypeName("#define sz_xQueryPointerReply 32")]
    public const int sz_xQueryPointerReply = 32;

    [NativeTypeName("#define sz_xGetMotionEventsReply 32")]
    public const int sz_xGetMotionEventsReply = 32;

    [NativeTypeName("#define sz_xTranslateCoordsReply 32")]
    public const int sz_xTranslateCoordsReply = 32;

    [NativeTypeName("#define sz_xGetInputFocusReply 32")]
    public const int sz_xGetInputFocusReply = 32;

    [NativeTypeName("#define sz_xQueryKeymapReply 40")]
    public const int sz_xQueryKeymapReply = 40;

    [NativeTypeName("#define sz_xQueryFontReply 60")]
    public const int sz_xQueryFontReply = 60;

    [NativeTypeName("#define sz_xQueryTextExtentsReply 32")]
    public const int sz_xQueryTextExtentsReply = 32;

    [NativeTypeName("#define sz_xListFontsReply 32")]
    public const int sz_xListFontsReply = 32;

    [NativeTypeName("#define sz_xGetFontPathReply 32")]
    public const int sz_xGetFontPathReply = 32;

    [NativeTypeName("#define sz_xGetImageReply 32")]
    public const int sz_xGetImageReply = 32;

    [NativeTypeName("#define sz_xListInstalledColormapsReply 32")]
    public const int sz_xListInstalledColormapsReply = 32;

    [NativeTypeName("#define sz_xAllocColorReply 32")]
    public const int sz_xAllocColorReply = 32;

    [NativeTypeName("#define sz_xAllocNamedColorReply 32")]
    public const int sz_xAllocNamedColorReply = 32;

    [NativeTypeName("#define sz_xAllocColorCellsReply 32")]
    public const int sz_xAllocColorCellsReply = 32;

    [NativeTypeName("#define sz_xAllocColorPlanesReply 32")]
    public const int sz_xAllocColorPlanesReply = 32;

    [NativeTypeName("#define sz_xQueryColorsReply 32")]
    public const int sz_xQueryColorsReply = 32;

    [NativeTypeName("#define sz_xLookupColorReply 32")]
    public const int sz_xLookupColorReply = 32;

    [NativeTypeName("#define sz_xQueryBestSizeReply 32")]
    public const int sz_xQueryBestSizeReply = 32;

    [NativeTypeName("#define sz_xQueryExtensionReply 32")]
    public const int sz_xQueryExtensionReply = 32;

    [NativeTypeName("#define sz_xListExtensionsReply 32")]
    public const int sz_xListExtensionsReply = 32;

    [NativeTypeName("#define sz_xSetMappingReply 32")]
    public const int sz_xSetMappingReply = 32;

    [NativeTypeName("#define sz_xGetKeyboardControlReply 52")]
    public const int sz_xGetKeyboardControlReply = 52;

    [NativeTypeName("#define sz_xGetPointerControlReply 32")]
    public const int sz_xGetPointerControlReply = 32;

    [NativeTypeName("#define sz_xGetScreenSaverReply 32")]
    public const int sz_xGetScreenSaverReply = 32;

    [NativeTypeName("#define sz_xListHostsReply 32")]
    public const int sz_xListHostsReply = 32;

    [NativeTypeName("#define sz_xSetModifierMappingReply 32")]
    public const int sz_xSetModifierMappingReply = 32;

    [NativeTypeName("#define sz_xError 32")]
    public const int sz_xError = 32;

    [NativeTypeName("#define sz_xEvent 32")]
    public const int sz_xEvent = 32;

    [NativeTypeName("#define sz_xKeymapEvent 32")]
    public const int sz_xKeymapEvent = 32;

    [NativeTypeName("#define sz_xReq 4")]
    public const int sz_xReq = 4;

    [NativeTypeName("#define sz_xResourceReq 8")]
    public const int sz_xResourceReq = 8;

    [NativeTypeName("#define sz_xCreateWindowReq 32")]
    public const int sz_xCreateWindowReq = 32;

    [NativeTypeName("#define sz_xChangeWindowAttributesReq 12")]
    public const int sz_xChangeWindowAttributesReq = 12;

    [NativeTypeName("#define sz_xChangeSaveSetReq 8")]
    public const int sz_xChangeSaveSetReq = 8;

    [NativeTypeName("#define sz_xReparentWindowReq 16")]
    public const int sz_xReparentWindowReq = 16;

    [NativeTypeName("#define sz_xConfigureWindowReq 12")]
    public const int sz_xConfigureWindowReq = 12;

    [NativeTypeName("#define sz_xCirculateWindowReq 8")]
    public const int sz_xCirculateWindowReq = 8;

    [NativeTypeName("#define sz_xInternAtomReq 8")]
    public const int sz_xInternAtomReq = 8;

    [NativeTypeName("#define sz_xChangePropertyReq 24")]
    public const int sz_xChangePropertyReq = 24;

    [NativeTypeName("#define sz_xDeletePropertyReq 12")]
    public const int sz_xDeletePropertyReq = 12;

    [NativeTypeName("#define sz_xGetPropertyReq 24")]
    public const int sz_xGetPropertyReq = 24;

    [NativeTypeName("#define sz_xSetSelectionOwnerReq 16")]
    public const int sz_xSetSelectionOwnerReq = 16;

    [NativeTypeName("#define sz_xConvertSelectionReq 24")]
    public const int sz_xConvertSelectionReq = 24;

    [NativeTypeName("#define sz_xSendEventReq 44")]
    public const int sz_xSendEventReq = 44;

    [NativeTypeName("#define sz_xGrabPointerReq 24")]
    public const int sz_xGrabPointerReq = 24;

    [NativeTypeName("#define sz_xGrabButtonReq 24")]
    public const int sz_xGrabButtonReq = 24;

    [NativeTypeName("#define sz_xUngrabButtonReq 12")]
    public const int sz_xUngrabButtonReq = 12;

    [NativeTypeName("#define sz_xChangeActivePointerGrabReq 16")]
    public const int sz_xChangeActivePointerGrabReq = 16;

    [NativeTypeName("#define sz_xGrabKeyboardReq 16")]
    public const int sz_xGrabKeyboardReq = 16;

    [NativeTypeName("#define sz_xGrabKeyReq 16")]
    public const int sz_xGrabKeyReq = 16;

    [NativeTypeName("#define sz_xUngrabKeyReq 12")]
    public const int sz_xUngrabKeyReq = 12;

    [NativeTypeName("#define sz_xAllowEventsReq 8")]
    public const int sz_xAllowEventsReq = 8;

    [NativeTypeName("#define sz_xGetMotionEventsReq 16")]
    public const int sz_xGetMotionEventsReq = 16;

    [NativeTypeName("#define sz_xTranslateCoordsReq 16")]
    public const int sz_xTranslateCoordsReq = 16;

    [NativeTypeName("#define sz_xWarpPointerReq 24")]
    public const int sz_xWarpPointerReq = 24;

    [NativeTypeName("#define sz_xSetInputFocusReq 12")]
    public const int sz_xSetInputFocusReq = 12;

    [NativeTypeName("#define sz_xOpenFontReq 12")]
    public const int sz_xOpenFontReq = 12;

    [NativeTypeName("#define sz_xQueryTextExtentsReq 8")]
    public const int sz_xQueryTextExtentsReq = 8;

    [NativeTypeName("#define sz_xListFontsReq 8")]
    public const int sz_xListFontsReq = 8;

    [NativeTypeName("#define sz_xSetFontPathReq 8")]
    public const int sz_xSetFontPathReq = 8;

    [NativeTypeName("#define sz_xCreatePixmapReq 16")]
    public const int sz_xCreatePixmapReq = 16;

    [NativeTypeName("#define sz_xCreateGCReq 16")]
    public const int sz_xCreateGCReq = 16;

    [NativeTypeName("#define sz_xChangeGCReq 12")]
    public const int sz_xChangeGCReq = 12;

    [NativeTypeName("#define sz_xCopyGCReq 16")]
    public const int sz_xCopyGCReq = 16;

    [NativeTypeName("#define sz_xSetDashesReq 12")]
    public const int sz_xSetDashesReq = 12;

    [NativeTypeName("#define sz_xSetClipRectanglesReq 12")]
    public const int sz_xSetClipRectanglesReq = 12;

    [NativeTypeName("#define sz_xCopyAreaReq 28")]
    public const int sz_xCopyAreaReq = 28;

    [NativeTypeName("#define sz_xCopyPlaneReq 32")]
    public const int sz_xCopyPlaneReq = 32;

    [NativeTypeName("#define sz_xPolyPointReq 12")]
    public const int sz_xPolyPointReq = 12;

    [NativeTypeName("#define sz_xPolySegmentReq 12")]
    public const int sz_xPolySegmentReq = 12;

    [NativeTypeName("#define sz_xFillPolyReq 16")]
    public const int sz_xFillPolyReq = 16;

    [NativeTypeName("#define sz_xPutImageReq 24")]
    public const int sz_xPutImageReq = 24;

    [NativeTypeName("#define sz_xGetImageReq 20")]
    public const int sz_xGetImageReq = 20;

    [NativeTypeName("#define sz_xPolyTextReq 16")]
    public const int sz_xPolyTextReq = 16;

    [NativeTypeName("#define sz_xImageTextReq 16")]
    public const int sz_xImageTextReq = 16;

    [NativeTypeName("#define sz_xCreateColormapReq 16")]
    public const int sz_xCreateColormapReq = 16;

    [NativeTypeName("#define sz_xCopyColormapAndFreeReq 12")]
    public const int sz_xCopyColormapAndFreeReq = 12;

    [NativeTypeName("#define sz_xAllocColorReq 16")]
    public const int sz_xAllocColorReq = 16;

    [NativeTypeName("#define sz_xAllocNamedColorReq 12")]
    public const int sz_xAllocNamedColorReq = 12;

    [NativeTypeName("#define sz_xAllocColorCellsReq 12")]
    public const int sz_xAllocColorCellsReq = 12;

    [NativeTypeName("#define sz_xAllocColorPlanesReq 16")]
    public const int sz_xAllocColorPlanesReq = 16;

    [NativeTypeName("#define sz_xFreeColorsReq 12")]
    public const int sz_xFreeColorsReq = 12;

    [NativeTypeName("#define sz_xStoreColorsReq 8")]
    public const int sz_xStoreColorsReq = 8;

    [NativeTypeName("#define sz_xStoreNamedColorReq 16")]
    public const int sz_xStoreNamedColorReq = 16;

    [NativeTypeName("#define sz_xQueryColorsReq 8")]
    public const int sz_xQueryColorsReq = 8;

    [NativeTypeName("#define sz_xLookupColorReq 12")]
    public const int sz_xLookupColorReq = 12;

    [NativeTypeName("#define sz_xCreateCursorReq 32")]
    public const int sz_xCreateCursorReq = 32;

    [NativeTypeName("#define sz_xCreateGlyphCursorReq 32")]
    public const int sz_xCreateGlyphCursorReq = 32;

    [NativeTypeName("#define sz_xRecolorCursorReq 20")]
    public const int sz_xRecolorCursorReq = 20;

    [NativeTypeName("#define sz_xQueryBestSizeReq 12")]
    public const int sz_xQueryBestSizeReq = 12;

    [NativeTypeName("#define sz_xQueryExtensionReq 8")]
    public const int sz_xQueryExtensionReq = 8;

    [NativeTypeName("#define sz_xChangeKeyboardControlReq 8")]
    public const int sz_xChangeKeyboardControlReq = 8;

    [NativeTypeName("#define sz_xBellReq 4")]
    public const int sz_xBellReq = 4;

    [NativeTypeName("#define sz_xChangePointerControlReq 12")]
    public const int sz_xChangePointerControlReq = 12;

    [NativeTypeName("#define sz_xSetScreenSaverReq 12")]
    public const int sz_xSetScreenSaverReq = 12;

    [NativeTypeName("#define sz_xChangeHostsReq 8")]
    public const int sz_xChangeHostsReq = 8;

    [NativeTypeName("#define sz_xListHostsReq 4")]
    public const int sz_xListHostsReq = 4;

    [NativeTypeName("#define sz_xChangeModeReq 4")]
    public const int sz_xChangeModeReq = 4;

    [NativeTypeName("#define sz_xRotatePropertiesReq 12")]
    public const int sz_xRotatePropertiesReq = 12;

    [NativeTypeName("#define sz_xReply 32")]
    public const int sz_xReply = 32;

    [NativeTypeName("#define sz_xGrabKeyboardReply 32")]
    public const int sz_xGrabKeyboardReply = 32;

    [NativeTypeName("#define sz_xListFontsWithInfoReply 60")]
    public const int sz_xListFontsWithInfoReply = 60;

    [NativeTypeName("#define sz_xSetPointerMappingReply 32")]
    public const int sz_xSetPointerMappingReply = 32;

    [NativeTypeName("#define sz_xGetKeyboardMappingReply 32")]
    public const int sz_xGetKeyboardMappingReply = 32;

    [NativeTypeName("#define sz_xGetPointerMappingReply 32")]
    public const int sz_xGetPointerMappingReply = 32;

    [NativeTypeName("#define sz_xGetModifierMappingReply 32")]
    public const int sz_xGetModifierMappingReply = 32;

    [NativeTypeName("#define sz_xListFontsWithInfoReq 8")]
    public const int sz_xListFontsWithInfoReq = 8;

    [NativeTypeName("#define sz_xPolyLineReq 12")]
    public const int sz_xPolyLineReq = 12;

    [NativeTypeName("#define sz_xPolyArcReq 12")]
    public const int sz_xPolyArcReq = 12;

    [NativeTypeName("#define sz_xPolyRectangleReq 12")]
    public const int sz_xPolyRectangleReq = 12;

    [NativeTypeName("#define sz_xPolyFillRectangleReq 12")]
    public const int sz_xPolyFillRectangleReq = 12;

    [NativeTypeName("#define sz_xPolyFillArcReq 12")]
    public const int sz_xPolyFillArcReq = 12;

    [NativeTypeName("#define sz_xPolyText8Req 16")]
    public const int sz_xPolyText8Req = 16;

    [NativeTypeName("#define sz_xPolyText16Req 16")]
    public const int sz_xPolyText16Req = 16;

    [NativeTypeName("#define sz_xImageText8Req 16")]
    public const int sz_xImageText8Req = 16;

    [NativeTypeName("#define sz_xImageText16Req 16")]
    public const int sz_xImageText16Req = 16;

    [NativeTypeName("#define sz_xSetPointerMappingReq 4")]
    public const int sz_xSetPointerMappingReq = 4;

    [NativeTypeName("#define sz_xForceScreenSaverReq 4")]
    public const int sz_xForceScreenSaverReq = 4;

    [NativeTypeName("#define sz_xSetCloseDownModeReq 4")]
    public const int sz_xSetCloseDownModeReq = 4;

    [NativeTypeName("#define sz_xClearAreaReq 16")]
    public const int sz_xClearAreaReq = 16;

    [NativeTypeName("#define sz_xSetAccessControlReq 4")]
    public const int sz_xSetAccessControlReq = 4;

    [NativeTypeName("#define sz_xGetKeyboardMappingReq 8")]
    public const int sz_xGetKeyboardMappingReq = 8;

    [NativeTypeName("#define sz_xSetModifierMappingReq 4")]
    public const int sz_xSetModifierMappingReq = 4;

    [NativeTypeName("#define sz_xPropIconSize 24")]
    public const int sz_xPropIconSize = 24;

    [NativeTypeName("#define sz_xChangeKeyboardMappingReq 8")]
    public const int sz_xChangeKeyboardMappingReq = 8;

    [NativeTypeName("#define X_TCP_PORT 6000")]
    public const int X_TCP_PORT = 6000;

    [NativeTypeName("#define xTrue 1")]
    public const int xTrue = 1;

    [NativeTypeName("#define xFalse 0")]
    public const int xFalse = 0;

    [NativeTypeName("#define ELFlagFocus (1<<0)")]
    public const int ELFlagFocus = (1 << 0);

    [NativeTypeName("#define ELFlagSameScreen (1<<1)")]
    public const int ELFlagSameScreen = (1 << 1);

    [NativeTypeName("#define XEventSize (sizeof(xEvent))")]
    public const nuint XEventSize = (32);

    [NativeTypeName("#define X_Reply 1")]
    public const int X_Reply = 1;

    [NativeTypeName("#define X_Error 0")]
    public const int X_Error = 0;

    [NativeTypeName("#define X_CreateWindow 1")]
    public const int X_CreateWindow = 1;

    [NativeTypeName("#define X_ChangeWindowAttributes 2")]
    public const int X_ChangeWindowAttributes = 2;

    [NativeTypeName("#define X_GetWindowAttributes 3")]
    public const int X_GetWindowAttributes = 3;

    [NativeTypeName("#define X_DestroyWindow 4")]
    public const int X_DestroyWindow = 4;

    [NativeTypeName("#define X_DestroySubwindows 5")]
    public const int X_DestroySubwindows = 5;

    [NativeTypeName("#define X_ChangeSaveSet 6")]
    public const int X_ChangeSaveSet = 6;

    [NativeTypeName("#define X_ReparentWindow 7")]
    public const int X_ReparentWindow = 7;

    [NativeTypeName("#define X_MapWindow 8")]
    public const int X_MapWindow = 8;

    [NativeTypeName("#define X_MapSubwindows 9")]
    public const int X_MapSubwindows = 9;

    [NativeTypeName("#define X_UnmapWindow 10")]
    public const int X_UnmapWindow = 10;

    [NativeTypeName("#define X_UnmapSubwindows 11")]
    public const int X_UnmapSubwindows = 11;

    [NativeTypeName("#define X_ConfigureWindow 12")]
    public const int X_ConfigureWindow = 12;

    [NativeTypeName("#define X_CirculateWindow 13")]
    public const int X_CirculateWindow = 13;

    [NativeTypeName("#define X_GetGeometry 14")]
    public const int X_GetGeometry = 14;

    [NativeTypeName("#define X_QueryTree 15")]
    public const int X_QueryTree = 15;

    [NativeTypeName("#define X_InternAtom 16")]
    public const int X_InternAtom = 16;

    [NativeTypeName("#define X_GetAtomName 17")]
    public const int X_GetAtomName = 17;

    [NativeTypeName("#define X_ChangeProperty 18")]
    public const int X_ChangeProperty = 18;

    [NativeTypeName("#define X_DeleteProperty 19")]
    public const int X_DeleteProperty = 19;

    [NativeTypeName("#define X_GetProperty 20")]
    public const int X_GetProperty = 20;

    [NativeTypeName("#define X_ListProperties 21")]
    public const int X_ListProperties = 21;

    [NativeTypeName("#define X_SetSelectionOwner 22")]
    public const int X_SetSelectionOwner = 22;

    [NativeTypeName("#define X_GetSelectionOwner 23")]
    public const int X_GetSelectionOwner = 23;

    [NativeTypeName("#define X_ConvertSelection 24")]
    public const int X_ConvertSelection = 24;

    [NativeTypeName("#define X_SendEvent 25")]
    public const int X_SendEvent = 25;

    [NativeTypeName("#define X_GrabPointer 26")]
    public const int X_GrabPointer = 26;

    [NativeTypeName("#define X_UngrabPointer 27")]
    public const int X_UngrabPointer = 27;

    [NativeTypeName("#define X_GrabButton 28")]
    public const int X_GrabButton = 28;

    [NativeTypeName("#define X_UngrabButton 29")]
    public const int X_UngrabButton = 29;

    [NativeTypeName("#define X_ChangeActivePointerGrab 30")]
    public const int X_ChangeActivePointerGrab = 30;

    [NativeTypeName("#define X_GrabKeyboard 31")]
    public const int X_GrabKeyboard = 31;

    [NativeTypeName("#define X_UngrabKeyboard 32")]
    public const int X_UngrabKeyboard = 32;

    [NativeTypeName("#define X_GrabKey 33")]
    public const int X_GrabKey = 33;

    [NativeTypeName("#define X_UngrabKey 34")]
    public const int X_UngrabKey = 34;

    [NativeTypeName("#define X_AllowEvents 35")]
    public const int X_AllowEvents = 35;

    [NativeTypeName("#define X_GrabServer 36")]
    public const int X_GrabServer = 36;

    [NativeTypeName("#define X_UngrabServer 37")]
    public const int X_UngrabServer = 37;

    [NativeTypeName("#define X_QueryPointer 38")]
    public const int X_QueryPointer = 38;

    [NativeTypeName("#define X_GetMotionEvents 39")]
    public const int X_GetMotionEvents = 39;

    [NativeTypeName("#define X_TranslateCoords 40")]
    public const int X_TranslateCoords = 40;

    [NativeTypeName("#define X_WarpPointer 41")]
    public const int X_WarpPointer = 41;

    [NativeTypeName("#define X_SetInputFocus 42")]
    public const int X_SetInputFocus = 42;

    [NativeTypeName("#define X_GetInputFocus 43")]
    public const int X_GetInputFocus = 43;

    [NativeTypeName("#define X_QueryKeymap 44")]
    public const int X_QueryKeymap = 44;

    [NativeTypeName("#define X_OpenFont 45")]
    public const int X_OpenFont = 45;

    [NativeTypeName("#define X_CloseFont 46")]
    public const int X_CloseFont = 46;

    [NativeTypeName("#define X_QueryFont 47")]
    public const int X_QueryFont = 47;

    [NativeTypeName("#define X_QueryTextExtents 48")]
    public const int X_QueryTextExtents = 48;

    [NativeTypeName("#define X_ListFonts 49")]
    public const int X_ListFonts = 49;

    [NativeTypeName("#define X_ListFontsWithInfo 50")]
    public const int X_ListFontsWithInfo = 50;

    [NativeTypeName("#define X_SetFontPath 51")]
    public const int X_SetFontPath = 51;

    [NativeTypeName("#define X_GetFontPath 52")]
    public const int X_GetFontPath = 52;

    [NativeTypeName("#define X_CreatePixmap 53")]
    public const int X_CreatePixmap = 53;

    [NativeTypeName("#define X_FreePixmap 54")]
    public const int X_FreePixmap = 54;

    [NativeTypeName("#define X_CreateGC 55")]
    public const int X_CreateGC = 55;

    [NativeTypeName("#define X_ChangeGC 56")]
    public const int X_ChangeGC = 56;

    [NativeTypeName("#define X_CopyGC 57")]
    public const int X_CopyGC = 57;

    [NativeTypeName("#define X_SetDashes 58")]
    public const int X_SetDashes = 58;

    [NativeTypeName("#define X_SetClipRectangles 59")]
    public const int X_SetClipRectangles = 59;

    [NativeTypeName("#define X_FreeGC 60")]
    public const int X_FreeGC = 60;

    [NativeTypeName("#define X_ClearArea 61")]
    public const int X_ClearArea = 61;

    [NativeTypeName("#define X_CopyArea 62")]
    public const int X_CopyArea = 62;

    [NativeTypeName("#define X_CopyPlane 63")]
    public const int X_CopyPlane = 63;

    [NativeTypeName("#define X_PolyPoint 64")]
    public const int X_PolyPoint = 64;

    [NativeTypeName("#define X_PolyLine 65")]
    public const int X_PolyLine = 65;

    [NativeTypeName("#define X_PolySegment 66")]
    public const int X_PolySegment = 66;

    [NativeTypeName("#define X_PolyRectangle 67")]
    public const int X_PolyRectangle = 67;

    [NativeTypeName("#define X_PolyArc 68")]
    public const int X_PolyArc = 68;

    [NativeTypeName("#define X_FillPoly 69")]
    public const int X_FillPoly = 69;

    [NativeTypeName("#define X_PolyFillRectangle 70")]
    public const int X_PolyFillRectangle = 70;

    [NativeTypeName("#define X_PolyFillArc 71")]
    public const int X_PolyFillArc = 71;

    [NativeTypeName("#define X_PutImage 72")]
    public const int X_PutImage = 72;

    [NativeTypeName("#define X_GetImage 73")]
    public const int X_GetImage = 73;

    [NativeTypeName("#define X_PolyText8 74")]
    public const int X_PolyText8 = 74;

    [NativeTypeName("#define X_PolyText16 75")]
    public const int X_PolyText16 = 75;

    [NativeTypeName("#define X_ImageText8 76")]
    public const int X_ImageText8 = 76;

    [NativeTypeName("#define X_ImageText16 77")]
    public const int X_ImageText16 = 77;

    [NativeTypeName("#define X_CreateColormap 78")]
    public const int X_CreateColormap = 78;

    [NativeTypeName("#define X_FreeColormap 79")]
    public const int X_FreeColormap = 79;

    [NativeTypeName("#define X_CopyColormapAndFree 80")]
    public const int X_CopyColormapAndFree = 80;

    [NativeTypeName("#define X_InstallColormap 81")]
    public const int X_InstallColormap = 81;

    [NativeTypeName("#define X_UninstallColormap 82")]
    public const int X_UninstallColormap = 82;

    [NativeTypeName("#define X_ListInstalledColormaps 83")]
    public const int X_ListInstalledColormaps = 83;

    [NativeTypeName("#define X_AllocColor 84")]
    public const int X_AllocColor = 84;

    [NativeTypeName("#define X_AllocNamedColor 85")]
    public const int X_AllocNamedColor = 85;

    [NativeTypeName("#define X_AllocColorCells 86")]
    public const int X_AllocColorCells = 86;

    [NativeTypeName("#define X_AllocColorPlanes 87")]
    public const int X_AllocColorPlanes = 87;

    [NativeTypeName("#define X_FreeColors 88")]
    public const int X_FreeColors = 88;

    [NativeTypeName("#define X_StoreColors 89")]
    public const int X_StoreColors = 89;

    [NativeTypeName("#define X_StoreNamedColor 90")]
    public const int X_StoreNamedColor = 90;

    [NativeTypeName("#define X_QueryColors 91")]
    public const int X_QueryColors = 91;

    [NativeTypeName("#define X_LookupColor 92")]
    public const int X_LookupColor = 92;

    [NativeTypeName("#define X_CreateCursor 93")]
    public const int X_CreateCursor = 93;

    [NativeTypeName("#define X_CreateGlyphCursor 94")]
    public const int X_CreateGlyphCursor = 94;

    [NativeTypeName("#define X_FreeCursor 95")]
    public const int X_FreeCursor = 95;

    [NativeTypeName("#define X_RecolorCursor 96")]
    public const int X_RecolorCursor = 96;

    [NativeTypeName("#define X_QueryBestSize 97")]
    public const int X_QueryBestSize = 97;

    [NativeTypeName("#define X_QueryExtension 98")]
    public const int X_QueryExtension = 98;

    [NativeTypeName("#define X_ListExtensions 99")]
    public const int X_ListExtensions = 99;

    [NativeTypeName("#define X_ChangeKeyboardMapping 100")]
    public const int X_ChangeKeyboardMapping = 100;

    [NativeTypeName("#define X_GetKeyboardMapping 101")]
    public const int X_GetKeyboardMapping = 101;

    [NativeTypeName("#define X_ChangeKeyboardControl 102")]
    public const int X_ChangeKeyboardControl = 102;

    [NativeTypeName("#define X_GetKeyboardControl 103")]
    public const int X_GetKeyboardControl = 103;

    [NativeTypeName("#define X_Bell 104")]
    public const int X_Bell = 104;

    [NativeTypeName("#define X_ChangePointerControl 105")]
    public const int X_ChangePointerControl = 105;

    [NativeTypeName("#define X_GetPointerControl 106")]
    public const int X_GetPointerControl = 106;

    [NativeTypeName("#define X_SetScreenSaver 107")]
    public const int X_SetScreenSaver = 107;

    [NativeTypeName("#define X_GetScreenSaver 108")]
    public const int X_GetScreenSaver = 108;

    [NativeTypeName("#define X_ChangeHosts 109")]
    public const int X_ChangeHosts = 109;

    [NativeTypeName("#define X_ListHosts 110")]
    public const int X_ListHosts = 110;

    [NativeTypeName("#define X_SetAccessControl 111")]
    public const int X_SetAccessControl = 111;

    [NativeTypeName("#define X_SetCloseDownMode 112")]
    public const int X_SetCloseDownMode = 112;

    [NativeTypeName("#define X_KillClient 113")]
    public const int X_KillClient = 113;

    [NativeTypeName("#define X_RotateProperties 114")]
    public const int X_RotateProperties = 114;

    [NativeTypeName("#define X_ForceScreenSaver 115")]
    public const int X_ForceScreenSaver = 115;

    [NativeTypeName("#define X_SetPointerMapping 116")]
    public const int X_SetPointerMapping = 116;

    [NativeTypeName("#define X_GetPointerMapping 117")]
    public const int X_GetPointerMapping = 117;

    [NativeTypeName("#define X_SetModifierMapping 118")]
    public const int X_SetModifierMapping = 118;

    [NativeTypeName("#define X_GetModifierMapping 119")]
    public const int X_GetModifierMapping = 119;

    [NativeTypeName("#define X_NoOperation 127")]
    public const int X_NoOperation = 127;
}
