// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xproto.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Xlib;

[StructLayout(LayoutKind.Explicit)]
public partial struct xReply
{
    [FieldOffset(0)]
    public xGenericReply generic;

    [FieldOffset(0)]
    public xGetGeometryReply geom;

    [FieldOffset(0)]
    public xQueryTreeReply tree;

    [FieldOffset(0)]
    public xInternAtomReply atom;

    [FieldOffset(0)]
    public xGetAtomNameReply atomName;

    [FieldOffset(0)]
    public xGetPropertyReply property;

    [FieldOffset(0)]
    public xListPropertiesReply listProperties;

    [FieldOffset(0)]
    public xGetSelectionOwnerReply selection;

    [FieldOffset(0)]
    public xGrabPointerReply grabPointer;

    [FieldOffset(0)]
    [NativeTypeName("xGrabKeyboardReply")]
    public xGrabPointerReply grabKeyboard;

    [FieldOffset(0)]
    public xQueryPointerReply pointer;

    [FieldOffset(0)]
    public xGetMotionEventsReply motionEvents;

    [FieldOffset(0)]
    public xTranslateCoordsReply coords;

    [FieldOffset(0)]
    public xGetInputFocusReply inputFocus;

    [FieldOffset(0)]
    public xQueryTextExtentsReply textExtents;

    [FieldOffset(0)]
    public xListFontsReply fonts;

    [FieldOffset(0)]
    public xGetFontPathReply fontPath;

    [FieldOffset(0)]
    public xGetImageReply image;

    [FieldOffset(0)]
    public xListInstalledColormapsReply colormaps;

    [FieldOffset(0)]
    public xAllocColorReply allocColor;

    [FieldOffset(0)]
    public xAllocNamedColorReply allocNamedColor;

    [FieldOffset(0)]
    public xAllocColorCellsReply colorCells;

    [FieldOffset(0)]
    public xAllocColorPlanesReply colorPlanes;

    [FieldOffset(0)]
    public xQueryColorsReply colors;

    [FieldOffset(0)]
    public xLookupColorReply lookupColor;

    [FieldOffset(0)]
    public xQueryBestSizeReply bestSize;

    [FieldOffset(0)]
    public xQueryExtensionReply extension;

    [FieldOffset(0)]
    public xListExtensionsReply extensions;

    [FieldOffset(0)]
    [NativeTypeName("xSetModifierMappingReply")]
    public xSetMappingReply setModifierMapping;

    [FieldOffset(0)]
    public xGetModifierMappingReply getModifierMapping;

    [FieldOffset(0)]
    [NativeTypeName("xSetPointerMappingReply")]
    public xSetMappingReply setPointerMapping;

    [FieldOffset(0)]
    public xGetKeyboardMappingReply getKeyboardMapping;

    [FieldOffset(0)]
    public xGetPointerMappingReply getPointerMapping;

    [FieldOffset(0)]
    public xGetPointerControlReply pointerControl;

    [FieldOffset(0)]
    public xGetScreenSaverReply screenSaver;

    [FieldOffset(0)]
    public xListHostsReply hosts;

    [FieldOffset(0)]
    public xError error;

    [FieldOffset(0)]
    public xEvent @event;
}
