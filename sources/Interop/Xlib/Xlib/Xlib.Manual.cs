// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Xlib
    {
        public const int X_HAVE_UTF8_STRING = 1;

        public const int True = 1;

        public const int False = 0;

        public const int QueuedAlready = 0;

        public const int QueuedAfterReading = 1;

        public const int QueuedAfterFlush = 2;

        public const uint AllPlanes = ~0u;

        public const int XIMPreeditArea = 0x0001;

        public const int XIMPreeditCallbacks = 0x0002;

        public const int XIMPreeditPosition = 0x0004;

        public const int XIMPreeditNothing = 0x0008;

        public const int XIMPreeditNone = 0x0010;

        public const int XIMStatusArea = 0x0100;

        public const int XIMStatusCallbacks = 0x0200;

        public const int XIMStatusNothing = 0x0400;

        public const int XIMStatusNone = 0x0800;

        public const int XBufferOverflow = -1;

        public const int XLookupNone = 1;

        public const int XLookupChars = 2;

        public const int XLookupKeySym = 3;

        public const int XLookupBoth = 4;

        public const int XIMReverse = 1;

        public const int XIMUnderline = 1 << 1;

        public const int XIMHighlight = 1 << 2;

        public const int XIMPrimary = 1 << 5;

        public const int XIMSecondary = 1 << 6;

        public const int XIMTertiary = 1 << 7;

        public const int XIMVisibleToForward = 1 << 8;

        public const int XIMVisibleToBackword = 1 << 9;

        public const int XIMVisibleToCenter = 1 << 10;

        public const int XIMPreeditUnKnown = 0;

        public const int XIMPreeditEnable = 1;

        public const int XIMPreeditDisable = 1 << 1;

        public const int XIMInitialState = 1;

        public const int XIMPreserveState = 1 << 1;

        public const int XIMStringConversionLeftEdge = 0x00000001;

        public const int XIMStringConversionRightEdge = 0x00000002;

        public const int XIMStringConversionTopEdge = 0x00000004;

        public const int XIMStringConversionBottomEdge = 0x00000008;

        public const int XIMStringConversionConcealed = 0x00000010;

        public const int XIMStringConversionWrapped = 0x00000020;

        public const int XIMStringConversionBuffer = 0x0001;

        public const int XIMStringConversionLine = 0x0002;

        public const int XIMStringConversionWord = 0x0003;

        public const int XIMStringConversionChar = 0x0004;

        public const int XIMStringConversionSubstitution = 0x0001;

        public const int XIMStringConversionRetrieval = 0x0002;

        public const int XIMHotKeyStateON = 0x0001;

        public const int XIMHotKeyStateOFF = 0x0002;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int procedure([NativeTypeName("Display*")] UIntPtr display);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int predicate([NativeTypeName("Display*")] UIntPtr display, XEvent* c_event, [NativeTypeName("XPointer")] sbyte* arg);

        // requiredCharSet
        public static ReadOnlySpan<byte> XNRequiredCharSet => new byte[] { 0x72, 0x65, 0x71, 0x75, 0x69, 0x72, 0x65, 0x64, 0x43, 0x68, 0x61, 0x72, 0x53, 0x65, 0x74, 0x00 };

        // queryOrientation
        public static ReadOnlySpan<byte> XNQueryOrientation => new byte[] { 0x71, 0x75, 0x65, 0x72, 0x79, 0x4F, 0x72, 0x69, 0x65, 0x6E, 0x74, 0x61, 0x74, 0x69, 0x6F, 0x6E, 0x00 };

        // baseFontName
        public static ReadOnlySpan<byte> XNBaseFontName => new byte[] { 0x62, 0x61, 0x73, 0x65, 0x46, 0x6F, 0x6E, 0x74, 0x4E, 0x61, 0x6D, 0x65, 0x00 };

        // omAutomatic
        public static ReadOnlySpan<byte> XNOMAutomatic => new byte[] { 0x6F, 0x6D, 0x41, 0x75, 0x74, 0x6F, 0x6D, 0x61, 0x74, 0x69, 0x63, 0x00 };

        // missingCharSet
        public static ReadOnlySpan<byte> XNMissingCharSet => new byte[] { 0x6D, 0x69, 0x73, 0x73, 0x69, 0x6E, 0x67, 0x43, 0x68, 0x61, 0x72, 0x53, 0x65, 0x74, 0x00 };

        // defaultString
        public static ReadOnlySpan<byte> XNDefaultString => new byte[] { 0x64, 0x65, 0x66, 0x61, 0x75, 0x6C, 0x74, 0x53, 0x74, 0x72, 0x69, 0x6E, 0x67, 0x00 };

        // orientation
        public static ReadOnlySpan<byte> XNOrientation => new byte[] { 0x6F, 0x72, 0x69, 0x65, 0x6E, 0x74, 0x61, 0x74, 0x69, 0x6F, 0x6E, 0x00 };

        // directionalDependentDrawing
        public static ReadOnlySpan<byte> XNDirectionalDependentDrawing => new byte[] { 0x64, 0x69, 0x72, 0x65, 0x63, 0x74, 0x69, 0x6F, 0x6E, 0x61, 0x6C, 0x44, 0x65, 0x70, 0x65, 0x6E, 0x64, 0x65, 0x6E, 0x74, 0x44, 0x72, 0x61, 0x77, 0x69, 0x6E, 0x67, 0x00 };

        // contextualDrawing
        public static ReadOnlySpan<byte> XNContextualDrawing => new byte[] { 0x63, 0x6F, 0x6E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x61, 0x6C, 0x44, 0x72, 0x61, 0x77, 0x69, 0x6E, 0x67, 0x00 };

        // fontInfo
        public static ReadOnlySpan<byte> XNFontInfo => new byte[] { 0x66, 0x6F, 0x6E, 0x74, 0x49, 0x6E, 0x66, 0x6F, 0x00 };

        // XNVaNestedList
        public static ReadOnlySpan<byte> XNVaNestedList => new byte[] { 0x58, 0x4E, 0x56, 0x61, 0x4E, 0x65, 0x73, 0x74, 0x65, 0x64, 0x4C, 0x69, 0x73, 0x74, 0x00 };

        // queryInputStyle
        public static ReadOnlySpan<byte> XNQueryInputStyle => new byte[] { 0x71, 0x75, 0x65, 0x72, 0x79, 0x49, 0x6E, 0x70, 0x75, 0x74, 0x53, 0x74, 0x79, 0x6C, 0x65, 0x00 };

        // clientWindow
        public static ReadOnlySpan<byte> XNClientWindow => new byte[] { 0x63, 0x6C, 0x69, 0x65, 0x6E, 0x74, 0x57, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x00 };

        // inputStyle
        public static ReadOnlySpan<byte> XNInputStyle => new byte[] { 0x69, 0x6E, 0x70, 0x75, 0x74, 0x53, 0x74, 0x79, 0x6C, 0x65, 0x00 };

        // focusWindow
        public static ReadOnlySpan<byte> XNFocusWindow => new byte[] { 0x66, 0x6F, 0x63, 0x75, 0x73, 0x57, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x00 };

        // resourceName
        public static ReadOnlySpan<byte> XNResourceName => new byte[] { 0x72, 0x65, 0x73, 0x6F, 0x75, 0x72, 0x63, 0x65, 0x4E, 0x61, 0x6D, 0x65, 0x00 };

        // resourceClass
        public static ReadOnlySpan<byte> XNResourceClass => new byte[] { 0x72, 0x65, 0x73, 0x6F, 0x75, 0x72, 0x63, 0x65, 0x43, 0x6C, 0x61, 0x73, 0x73, 0x00 };

        // geometryCallback
        public static ReadOnlySpan<byte> XNGeometryCallback => new byte[] { 0x67, 0x65, 0x6F, 0x6D, 0x65, 0x74, 0x72, 0x79, 0x43, 0x61, 0x6C, 0x6C, 0x62, 0x61, 0x63, 0x6B, 0x00 };

        // destroyCallback
        public static ReadOnlySpan<byte> XNDestroyCallback => new byte[] { 0x64, 0x65, 0x73, 0x74, 0x72, 0x6F, 0x79, 0x43, 0x61, 0x6C, 0x6C, 0x62, 0x61, 0x63, 0x6B, 0x00 };

        // filterEvents
        public static ReadOnlySpan<byte> XNFilterEvents => new byte[] { 0x66, 0x69, 0x6C, 0x74, 0x65, 0x72, 0x45, 0x76, 0x65, 0x6E, 0x74, 0x73, 0x00 };

        // preeditStartCallback
        public static ReadOnlySpan<byte> XNPreeditStartCallback => new byte[] { 0x70, 0x72, 0x65, 0x65, 0x64, 0x69, 0x74, 0x53, 0x74, 0x61, 0x72, 0x74, 0x43, 0x61, 0x6C, 0x6C, 0x62, 0x61, 0x63, 0x6B, 0x00 };

        // preeditDoneCallback
        public static ReadOnlySpan<byte> XNPreeditDoneCallback => new byte[] { 0x70, 0x72, 0x65, 0x65, 0x64, 0x69, 0x74, 0x44, 0x6F, 0x6E, 0x65, 0x43, 0x61, 0x6C, 0x6C, 0x62, 0x61, 0x63, 0x6B, 0x00 };

        // preeditDrawCallback
        public static ReadOnlySpan<byte> XNPreeditDrawCallback => new byte[] { 0x70, 0x72, 0x65, 0x65, 0x64, 0x69, 0x74, 0x44, 0x72, 0x61, 0x77, 0x43, 0x61, 0x6C, 0x6C, 0x62, 0x61, 0x63, 0x6B, 0x00 };

        // preeditCaretCallback
        public static ReadOnlySpan<byte> XNPreeditCaretCallback => new byte[] { 0x70, 0x72, 0x65, 0x65, 0x64, 0x69, 0x74, 0x43, 0x61, 0x72, 0x65, 0x74, 0x43, 0x61, 0x6C, 0x6C, 0x62, 0x61, 0x63, 0x6B, 0x00 };

        // preeditStateNotifyCallback
        public static ReadOnlySpan<byte> XNPreeditStateNotifyCallback => new byte[] { 0x70, 0x72, 0x65, 0x65, 0x64, 0x69, 0x74, 0x53, 0x74, 0x61, 0x74, 0x65, 0x4E, 0x6F, 0x74, 0x69, 0x66, 0x79, 0x43, 0x61, 0x6C, 0x6C, 0x62, 0x61, 0x63, 0x6B, 0x00 };

        // preeditAttributes
        public static ReadOnlySpan<byte> XNPreeditAttributes => new byte[] { 0x70, 0x72, 0x65, 0x65, 0x64, 0x69, 0x74, 0x41, 0x74, 0x74, 0x72, 0x69, 0x62, 0x75, 0x74, 0x65, 0x73, 0x00 };

        // statusStartCallback
        public static ReadOnlySpan<byte> XNStatusStartCallback => new byte[] { 0x73, 0x74, 0x61, 0x74, 0x75, 0x73, 0x53, 0x74, 0x61, 0x72, 0x74, 0x43, 0x61, 0x6C, 0x6C, 0x62, 0x61, 0x63, 0x6B, 0x00 };

        // statusDoneCallback
        public static ReadOnlySpan<byte> XNStatusDoneCallback => new byte[] { 0x73, 0x74, 0x61, 0x74, 0x75, 0x73, 0x44, 0x6F, 0x6E, 0x65, 0x43, 0x61, 0x6C, 0x6C, 0x62, 0x61, 0x63, 0x6B, 0x00 };

        // statusDrawCallback
        public static ReadOnlySpan<byte> XNStatusDrawCallback => new byte[] { 0x73, 0x74, 0x61, 0x74, 0x75, 0x73, 0x44, 0x72, 0x61, 0x77, 0x43, 0x61, 0x6C, 0x6C, 0x62, 0x61, 0x63, 0x6B, 0x00 };

        // statusAttributes
        public static ReadOnlySpan<byte> XNStatusAttributes => new byte[] { 0x73, 0x74, 0x61, 0x74, 0x75, 0x73, 0x41, 0x74, 0x74, 0x72, 0x69, 0x62, 0x75, 0x74, 0x65, 0x73, 0x00 };

        // area
        public static ReadOnlySpan<byte> XNArea => new byte[] { 0x61, 0x72, 0x65, 0x61, 0x00 };

        // areaNeeded
        public static ReadOnlySpan<byte> XNAreaNeeded => new byte[] { 0x61, 0x72, 0x65, 0x61, 0x4E, 0x65, 0x65, 0x64, 0x65, 0x64, 0x00 };

        // spotLocation
        public static ReadOnlySpan<byte> XNSpotLocation => new byte[] { 0x73, 0x70, 0x6F, 0x74, 0x4C, 0x6F, 0x63, 0x61, 0x74, 0x69, 0x6F, 0x6E, 0x00 };

        // colorMap
        public static ReadOnlySpan<byte> XNColormap => new byte[] { 0x63, 0x6F, 0x6C, 0x6F, 0x72, 0x4D, 0x61, 0x70, 0x00 };

        // stdColorMap
        public static ReadOnlySpan<byte> XNStdColormap => new byte[] { 0x73, 0x74, 0x64, 0x43, 0x6F, 0x6C, 0x6F, 0x72, 0x4D, 0x61, 0x70, 0x00 };

        // foreground
        public static ReadOnlySpan<byte> XNForeground => new byte[] { 0x66, 0x6F, 0x72, 0x65, 0x67, 0x72, 0x6F, 0x75, 0x6E, 0x64, 0x00 };

        // background
        public static ReadOnlySpan<byte> XNBackground => new byte[] { 0x62, 0x61, 0x63, 0x6B, 0x67, 0x72, 0x6F, 0x75, 0x6E, 0x64, 0x00 };

        // backgroundPixmap
        public static ReadOnlySpan<byte> XNBackgroundPixmap => new byte[] { 0x62, 0x61, 0x63, 0x6B, 0x67, 0x72, 0x6F, 0x75, 0x6E, 0x64, 0x50, 0x69, 0x78, 0x6D, 0x61, 0x70, 0x00 };

        // fontSet
        public static ReadOnlySpan<byte> XNFontSet => new byte[] { 0x66, 0x6F, 0x6E, 0x74, 0x53, 0x65, 0x74, 0x00 };

        // lineSpace
        public static ReadOnlySpan<byte> XNLineSpace => new byte[] { 0x6C, 0x69, 0x6E, 0x65, 0x53, 0x70, 0x61, 0x63, 0x65, 0x00 };

        // cursor
        public static ReadOnlySpan<byte> XNCursor => new byte[] { 0x63, 0x75, 0x72, 0x73, 0x6F, 0x72, 0x00 };

        // queryIMValuesList
        public static ReadOnlySpan<byte> XNQueryIMValuesList => new byte[] { 0x71, 0x75, 0x65, 0x72, 0x79, 0x49, 0x4D, 0x56, 0x61, 0x6C, 0x75, 0x65, 0x73, 0x4C, 0x69, 0x73, 0x74, 0x00 };

        // queryICValuesList
        public static ReadOnlySpan<byte> XNQueryICValuesList => new byte[] { 0x71, 0x75, 0x65, 0x72, 0x79, 0x49, 0x43, 0x56, 0x61, 0x6C, 0x75, 0x65, 0x73, 0x4C, 0x69, 0x73, 0x74, 0x00 };

        // visiblePosition
        public static ReadOnlySpan<byte> XNVisiblePosition => new byte[] { 0x76, 0x69, 0x73, 0x69, 0x62, 0x6C, 0x65, 0x50, 0x6F, 0x73, 0x69, 0x74, 0x69, 0x6F, 0x6E, 0x00 };

        // r6PreeditCallback
        public static ReadOnlySpan<byte> XNR6PreeditCallback => new byte[] { 0x72, 0x36, 0x50, 0x72, 0x65, 0x65, 0x64, 0x69, 0x74, 0x43, 0x61, 0x6C, 0x6C, 0x62, 0x61, 0x63, 0x6B, 0x00 };

        // stringConversionCallback
        public static ReadOnlySpan<byte> XNStringConversionCallback => new byte[] { 0x73, 0x74, 0x72, 0x69, 0x6E, 0x67, 0x43, 0x6F, 0x6E, 0x76, 0x65, 0x72, 0x73, 0x69, 0x6F, 0x6E, 0x43, 0x61, 0x6C, 0x6C, 0x62, 0x61, 0x63, 0x6B, 0x00 };

        // stringConversion
        public static ReadOnlySpan<byte> XNStringConversion => new byte[] { 0x73, 0x74, 0x72, 0x69, 0x6E, 0x67, 0x43, 0x6F, 0x6E, 0x76, 0x65, 0x72, 0x73, 0x69, 0x6F, 0x6E, 0x43, 0x61, 0x6C, 0x6C, 0x62, 0x61, 0x63, 0x6B, 0x00 };

        // resetState
        public static ReadOnlySpan<byte> XNResetState => new byte[] { 0x72, 0x65, 0x73, 0x65, 0x74, 0x53, 0x74, 0x61, 0x74, 0x65 , 0x00};

        // hotKey
        public static ReadOnlySpan<byte> XNHotKey => new byte[] { 0x68, 0x6F, 0x74, 0x4B, 0x65, 0x79, 0x00 };

        // hotKeyState
        public static ReadOnlySpan<byte> XNHotKeyState => new byte[] { 0x68, 0x6F, 0x74, 0x4B, 0x65, 0x79, 0x53, 0x74, 0x61, 0x74, 0x65, 0x00 };

        // preeditState
        public static ReadOnlySpan<byte> XNPreeditState => new byte[] { 0x70, 0x72, 0x65, 0x65, 0x64, 0x69, 0x74, 0x53, 0x74, 0x61, 0x74, 0x65, 0x00 };

        // separatorofNestedList
        public static ReadOnlySpan<byte> XNSeparatorofNestedList => new byte[] { 0x73, 0x65, 0x70, 0x61, 0x72, 0x61, 0x74, 0x6F, 0x72, 0x6F, 0x66, 0x4E, 0x65, 0x73, 0x74, 0x65, 0x64, 0x4C, 0x69, 0x73, 0x74, 0x00 };

        public static int ConnectionNumber([NativeTypeName("Display *")] UIntPtr dpy) => ((XPrivDisplay*)dpy)->fd;

        [return: NativeTypeName("Window")]
        public static UIntPtr RootWindow([NativeTypeName("Display *")] UIntPtr dpy, int scr) => ScreenOfDisplay(dpy, scr)->root;

        public static int DefaultScreen([NativeTypeName("Display *")] UIntPtr dpy) => ((XPrivDisplay*)dpy)->default_screen;

        [return: NativeTypeName("Window")]
        public static UIntPtr DefaultRootWindow([NativeTypeName("Display *")] UIntPtr dpy) => ScreenOfDisplay(dpy, DefaultScreen(dpy))->root;

        [return: NativeTypeName("Visual *")]
        public static Visual* DefaultVisual([NativeTypeName("Display *")] UIntPtr dpy, int scr) => ScreenOfDisplay(dpy, scr)->root_visual;

        [return: NativeTypeName("GC")]
        public static XGC* DefaultGC([NativeTypeName("Display *")] UIntPtr dpy, int scr) => ScreenOfDisplay(dpy, scr)->default_gc;

        [return: NativeTypeName("unsigned long")]
        public static UIntPtr BlackPixel([NativeTypeName("Display *")] UIntPtr dpy, int scr) => ScreenOfDisplay(dpy, scr)->black_pixel;

        [return: NativeTypeName("unsigned long")]
        public static UIntPtr WhitePixel([NativeTypeName("Display *")] UIntPtr dpy, int scr) => ScreenOfDisplay(dpy, scr)->white_pixel;

        public static int QLength([NativeTypeName("Display *")] UIntPtr dpy) => ((XPrivDisplay*)dpy)->qlen;

        public static int DisplayWidth([NativeTypeName("Display *")] UIntPtr dpy, int scr) => ScreenOfDisplay(dpy, scr)->width;

        public static int DisplayHeight([NativeTypeName("Display *")] UIntPtr dpy, int scr) => ScreenOfDisplay(dpy, scr)->height;

        public static int DisplayWidthMM([NativeTypeName("Display *")] UIntPtr dpy, int scr) => ScreenOfDisplay(dpy, scr)->mwidth;

        public static int DisplayHeightMM([NativeTypeName("Display *")] UIntPtr dpy, int scr) => ScreenOfDisplay(dpy, scr)->mheight;

        public static int DisplayPlanes([NativeTypeName("Display *")] UIntPtr dpy, int scr) => ScreenOfDisplay(dpy, scr)->root_depth;

        public static int DisplayCells([NativeTypeName("Display *")] UIntPtr dpy, int scr) => DefaultVisual(dpy, scr)->map_entries;

        public static int ScreenCount([NativeTypeName("Display *")] UIntPtr dpy) => ((XPrivDisplay*)dpy)->nscreens;

        [return: NativeTypeName("char *")]
        public static sbyte* ServerVendor([NativeTypeName("Display *")] UIntPtr dpy) => ((XPrivDisplay*)dpy)->vendor;

        public static int ProtocolVersion([NativeTypeName("Display *")] UIntPtr dpy) => ((XPrivDisplay*)dpy)->proto_major_version;

        public static int ProtocolRevision([NativeTypeName("Display *")] UIntPtr dpy) => ((XPrivDisplay*)dpy)->proto_minor_version;

        public static int VendorRelease([NativeTypeName("Display *")] UIntPtr dpy) => ((XPrivDisplay*)dpy)->release;

        [return: NativeTypeName("char *")]
        public static sbyte* DisplayString([NativeTypeName("Display *")] UIntPtr dpy) => ((XPrivDisplay*)dpy)->display_name;

        public static int DefaultDepth([NativeTypeName("Display *")] UIntPtr dpy, int scr) => ScreenOfDisplay(dpy, scr)->root_depth;

        [return: NativeTypeName("Colormap")]
        public static UIntPtr DefaultColormap([NativeTypeName("Display *")] UIntPtr dpy, int scr) => ScreenOfDisplay(dpy, scr)->cmap;

        public static int BitmapUnit([NativeTypeName("Display *")] UIntPtr dpy) => ((XPrivDisplay*)dpy)->bitmap_unit;

        public static int BitmapBitOrder([NativeTypeName("Display *")] UIntPtr dpy) => ((XPrivDisplay*)dpy)->bitmap_bit_order;

        public static int BitmapPad([NativeTypeName("Display *")] UIntPtr dpy) => ((XPrivDisplay*)dpy)->bitmap_pad;

        public static int ImageByteOrder([NativeTypeName("Display *")] UIntPtr dpy) => ((XPrivDisplay*)dpy)->byte_order;

        [return: NativeTypeName("unsigned long")]
        public static UIntPtr NextRequest([NativeTypeName("Display *")] UIntPtr dpy) => ((XPrivDisplay*)dpy)->request + 1;

        [return: NativeTypeName("unsigned long")]
        public static UIntPtr LastKnownRequestProcessed([NativeTypeName("Display *")] UIntPtr dpy) => ((XPrivDisplay*)dpy)->last_request_read;

        [return: NativeTypeName("Screen *")]
        public static Screen* ScreenOfDisplay([NativeTypeName("Display *")] UIntPtr dpy, int scr) => &((XPrivDisplay*)dpy)->screens[scr];

        [return: NativeTypeName("Screen *")]
        public static Screen* DefaultScreenOfDisplay([NativeTypeName("Display *")] UIntPtr dpy) => ScreenOfDisplay(dpy, DefaultScreen(dpy));

        [return: NativeTypeName("Display *")]
        public static UIntPtr DisplayOfScreen([NativeTypeName("Screen *")] Screen* s) => s->display;

        [return: NativeTypeName("Window")]
        public static UIntPtr RootWindowOfScreen([NativeTypeName("Screen *")] Screen* s) => s->root;

        public static UIntPtr BlackPixelOfScreen([NativeTypeName("Screen *")] Screen* s) => s->black_pixel;

        public static UIntPtr WhitePixelOfScreen([NativeTypeName("Screen *")] Screen* s) => s->white_pixel;

        [return: NativeTypeName("Colormap")]
        public static UIntPtr DefaultColormapOfScreen([NativeTypeName("Screen *")] Screen* s) => s->cmap;

        public static int DefaultDepthOfScreen([NativeTypeName("Screen *")] Screen* s) => s->root_depth;

        [return: NativeTypeName("GC")]
        public static XGC* DefaultGCOfScreen([NativeTypeName("Screen *")] Screen* s) => s->default_gc;

        [return: NativeTypeName("Visual *")]
        public static Visual* DefaultVisualOfScreen([NativeTypeName("Screen *")] Screen* s) => s->root_visual;

        public static int WidthOfScreen([NativeTypeName("Screen *")] Screen* s) => s->width;

        public static int HeightOfScreen([NativeTypeName("Screen *")] Screen* s) => s->height;

        public static int WidthMMOfScreen([NativeTypeName("Screen *")] Screen* s) => s->mwidth;

        public static int HeightMMOfScreen([NativeTypeName("Screen *")] Screen* s) => s->mheight;

        public static int PlanesOfScreen([NativeTypeName("Screen *")] Screen* s) => s->root_depth;

        public static int CellsOfScreen([NativeTypeName("Screen *")] Screen* s) => DefaultVisualOfScreen(s)->map_entries;

        public static int MinCmapsOfScreen([NativeTypeName("Screen *")] Screen* s) => s->min_maps;

        public static int MaxCmapsOfScreen([NativeTypeName("Screen *")] Screen* s) => s->max_maps;

        public static int DoesSaveUnders([NativeTypeName("Screen *")] Screen* s) => s->save_unders;

        public static int DoesBackingStore([NativeTypeName("Screen *")] Screen* s) => s->backing_store;

        [return: NativeTypeName("long")]
        public static IntPtr EventMaskOfScreen([NativeTypeName("Screen *")] Screen* s) => s->root_input_mask;

        [return: NativeTypeName("XID")]
        public static UIntPtr XAllocID([NativeTypeName("Display *")] UIntPtr dpy) => Marshal.GetDelegateForFunctionPointer<XPrivDisplay._resource_alloc>(((XPrivDisplay*)dpy)->resource_alloc)(dpy);
    }
}
