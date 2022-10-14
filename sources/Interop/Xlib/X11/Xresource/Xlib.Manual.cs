// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xresource.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group and Digital Equipment Corporation, Maynard, Massachusetts.

namespace TerraFX.Interop.Xlib;

public static unsafe partial class Xlib
{
    public static bool XrmStringsEqual([NativeTypeName("const char *")] sbyte* a1, [NativeTypeName("const char *")] sbyte* a2) => false; // strcmp(a1, a2) == 0

    [return: NativeTypeName("XrmString")]
    public static sbyte* XrmNameToString([NativeTypeName("XrmQuark")] int name) => XrmQuarkToString(name);

    [return: NativeTypeName("XrmQuark")]
    public static int XrmStringToName([NativeTypeName("const char *")] sbyte* c_string) => XrmStringToQuark(c_string);

    public static void XrmStringToNameList([NativeTypeName("const char *")] sbyte* str, [NativeTypeName("XrmQuarkList")] int* name) => XrmStringToQuarkList(str, name);

    [return: NativeTypeName("XrmString")]
    public static sbyte* XrmClassToString([NativeTypeName("XrmQuark")] int c_class) => XrmQuarkToString(c_class);

    [return: NativeTypeName("XrmQuark")]
    public static int XrmStringToClass([NativeTypeName("const char *")] sbyte* c_class) => XrmStringToQuark(c_class);

    public static void XrmStringToClassList([NativeTypeName("const char *")] sbyte* str, [NativeTypeName("XrmQuarkList")] int* c_class) => XrmStringToQuarkList(str, c_class);

    [return: NativeTypeName("XrmQuark")]
    public static int XrmStringToRepresentation([NativeTypeName("const char *")] sbyte* c_string) => XrmStringToQuark(c_string);

    [return: NativeTypeName("XrmString")]
    public static sbyte* XrmRepresentationToString([NativeTypeName("XrmQuark")] int type) => XrmQuarkToString(type);
}
