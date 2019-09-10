// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\Xresource.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group and Digital Equipment Corporation, Maynard, Massachusetts.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Xlib
    {
        [DllImport(libraryPath, EntryPoint = "Xpermalloc", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* Xpermalloc([NativeTypeName("unsigned int")] uint param0);

        [DllImport(libraryPath, EntryPoint = "XrmStringToQuark", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XrmQuark")]
        public static extern int XrmStringToQuark([NativeTypeName("const char *")] sbyte* param0);

        [DllImport(libraryPath, EntryPoint = "XrmPermStringToQuark", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XrmQuark")]
        public static extern int XrmPermStringToQuark([NativeTypeName("const char *")] sbyte* param0);

        [DllImport(libraryPath, EntryPoint = "XrmQuarkToString", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XrmString")]
        public static extern sbyte* XrmQuarkToString([NativeTypeName("XrmQuark")] int param0);

        [DllImport(libraryPath, EntryPoint = "XrmUniqueQuark", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XrmQuark")]
        public static extern int XrmUniqueQuark();

        [DllImport(libraryPath, EntryPoint = "XrmStringToQuarkList", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XrmStringToQuarkList([NativeTypeName("const char *")] sbyte* param0, [NativeTypeName("XrmQuarkList")] int* param1);

        [DllImport(libraryPath, EntryPoint = "XrmStringToBindingQuarkList", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XrmStringToBindingQuarkList([NativeTypeName("const char *")] sbyte* param0, [NativeTypeName("XrmBindingList")] XrmBinding* param1, [NativeTypeName("XrmQuarkList")] int* param2);

        [DllImport(libraryPath, EntryPoint = "XrmDestroyDatabase", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XrmDestroyDatabase([NativeTypeName("XrmDatabase")] XrmHashBucketRec* param0);

        [DllImport(libraryPath, EntryPoint = "XrmQPutResource", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XrmQPutResource([NativeTypeName("XrmDatabase *")] XrmHashBucketRec** param0, [NativeTypeName("XrmBindingList")] XrmBinding* param1, [NativeTypeName("XrmQuarkList")] int* param2, [NativeTypeName("XrmRepresentation")] int param3, [NativeTypeName("XrmValue *")] XrmValue* param4);

        [DllImport(libraryPath, EntryPoint = "XrmPutResource", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XrmPutResource([NativeTypeName("XrmDatabase *")] XrmHashBucketRec** param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("XrmValue *")] XrmValue* param3);

        [DllImport(libraryPath, EntryPoint = "XrmQPutStringResource", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XrmQPutStringResource([NativeTypeName("XrmDatabase *")] XrmHashBucketRec** param0, [NativeTypeName("XrmBindingList")] XrmBinding* param1, [NativeTypeName("XrmQuarkList")] int* param2, [NativeTypeName("const char *")] sbyte* param3);

        [DllImport(libraryPath, EntryPoint = "XrmPutStringResource", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XrmPutStringResource([NativeTypeName("XrmDatabase *")] XrmHashBucketRec** param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("const char *")] sbyte* param2);

        [DllImport(libraryPath, EntryPoint = "XrmPutLineResource", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XrmPutLineResource([NativeTypeName("XrmDatabase *")] XrmHashBucketRec** param0, [NativeTypeName("const char *")] sbyte* param1);

        [DllImport(libraryPath, EntryPoint = "XrmQGetResource", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XrmQGetResource([NativeTypeName("XrmDatabase")] XrmHashBucketRec* param0, [NativeTypeName("XrmNameList")] int* param1, [NativeTypeName("XrmClassList")] int* param2, [NativeTypeName("XrmRepresentation *")] int* param3, [NativeTypeName("XrmValue *")] XrmValue* param4);

        [DllImport(libraryPath, EntryPoint = "XrmGetResource", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XrmGetResource([NativeTypeName("XrmDatabase")] XrmHashBucketRec* param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("char **")] sbyte** param3, [NativeTypeName("XrmValue *")] XrmValue* param4);

        [DllImport(libraryPath, EntryPoint = "XrmQGetSearchList", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XrmQGetSearchList([NativeTypeName("XrmDatabase")] XrmHashBucketRec* param0, [NativeTypeName("XrmNameList")] int* param1, [NativeTypeName("XrmClassList")] int* param2, [NativeTypeName("XrmSearchList")] XrmHashBucketRec** param3, int param4);

        [DllImport(libraryPath, EntryPoint = "XrmQGetSearchResource", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XrmQGetSearchResource([NativeTypeName("XrmSearchList")] XrmHashBucketRec** param0, [NativeTypeName("XrmName")] int param1, [NativeTypeName("XrmClass")] int param2, [NativeTypeName("XrmRepresentation *")] int* param3, [NativeTypeName("XrmValue *")] XrmValue* param4);

        [DllImport(libraryPath, EntryPoint = "XrmSetDatabase", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XrmSetDatabase([NativeTypeName("Display *")] XDisplay* param0, [NativeTypeName("XrmDatabase")] XrmHashBucketRec* param1);

        [DllImport(libraryPath, EntryPoint = "XrmGetDatabase", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XrmDatabase")]
        public static extern XrmHashBucketRec* XrmGetDatabase([NativeTypeName("Display *")] XDisplay* param0);

        [DllImport(libraryPath, EntryPoint = "XrmGetFileDatabase", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XrmDatabase")]
        public static extern XrmHashBucketRec* XrmGetFileDatabase([NativeTypeName("const char *")] sbyte* param0);

        [DllImport(libraryPath, EntryPoint = "XrmCombineFileDatabase", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XrmCombineFileDatabase([NativeTypeName("const char *")] sbyte* param0, [NativeTypeName("XrmDatabase *")] XrmHashBucketRec** param1, int param2);

        [DllImport(libraryPath, EntryPoint = "XrmGetStringDatabase", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XrmDatabase")]
        public static extern XrmHashBucketRec* XrmGetStringDatabase([NativeTypeName("const char *")] sbyte* param0);

        [DllImport(libraryPath, EntryPoint = "XrmPutFileDatabase", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XrmPutFileDatabase([NativeTypeName("XrmDatabase")] XrmHashBucketRec* param0, [NativeTypeName("const char *")] sbyte* param1);

        [DllImport(libraryPath, EntryPoint = "XrmMergeDatabases", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XrmMergeDatabases([NativeTypeName("XrmDatabase")] XrmHashBucketRec* param0, [NativeTypeName("XrmDatabase *")] XrmHashBucketRec** param1);

        [DllImport(libraryPath, EntryPoint = "XrmCombineDatabase", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XrmCombineDatabase([NativeTypeName("XrmDatabase")] XrmHashBucketRec* param0, [NativeTypeName("XrmDatabase *")] XrmHashBucketRec** param1, int param2);

        [DllImport(libraryPath, EntryPoint = "XrmEnumerateDatabase", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XrmEnumerateDatabase([NativeTypeName("XrmDatabase")] XrmHashBucketRec* param0, [NativeTypeName("XrmNameList")] int* param1, [NativeTypeName("XrmClassList")] int* param2, int param3, [NativeTypeName("int (*)(XrmDatabase *, XrmBindingList, XrmQuarkList, XrmRepresentation *, XrmValue *, XPointer)")] IntPtr param4, [NativeTypeName("XPointer")] sbyte* param5);

        [DllImport(libraryPath, EntryPoint = "XrmLocaleOfDatabase", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* XrmLocaleOfDatabase([NativeTypeName("XrmDatabase")] XrmHashBucketRec* param0);

        [DllImport(libraryPath, EntryPoint = "XrmParseCommand", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XrmParseCommand([NativeTypeName("XrmDatabase *")] XrmHashBucketRec** param0, [NativeTypeName("XrmOptionDescList")] XrmOptionDescRec* param1, int param2, [NativeTypeName("const char *")] sbyte* param3, [NativeTypeName("int *")] int* param4, [NativeTypeName("char **")] sbyte** param5);
    }
}
