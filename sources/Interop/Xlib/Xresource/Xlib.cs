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
        public static extern sbyte* Xpermalloc([NativeTypeName("unsigned int")] uint size);

        [DllImport(libraryPath, EntryPoint = "XrmStringToQuark", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XrmQuark")]
        public static extern int XrmStringToQuark([NativeTypeName("const char *")] sbyte* c_string);

        [DllImport(libraryPath, EntryPoint = "XrmPermStringToQuark", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XrmQuark")]
        public static extern int XrmPermStringToQuark([NativeTypeName("const char *")] sbyte* c_string);

        [DllImport(libraryPath, EntryPoint = "XrmQuarkToString", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XrmString")]
        public static extern sbyte* XrmQuarkToString([NativeTypeName("XrmQuark")] int quark);

        [DllImport(libraryPath, EntryPoint = "XrmUniqueQuark", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XrmQuark")]
        public static extern int XrmUniqueQuark();

        [DllImport(libraryPath, EntryPoint = "XrmStringToQuarkList", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XrmStringToQuarkList([NativeTypeName("const char *")] sbyte* c_string, [NativeTypeName("XrmQuarkList")] int* quarks_return);

        [DllImport(libraryPath, EntryPoint = "XrmStringToBindingQuarkList", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XrmStringToBindingQuarkList([NativeTypeName("const char *")] sbyte* c_string, [NativeTypeName("XrmBindingList")] XrmBinding* bindings_return, [NativeTypeName("XrmQuarkList")] int* quarks_return);

        [DllImport(libraryPath, EntryPoint = "XrmDestroyDatabase", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XrmDestroyDatabase([NativeTypeName("XrmDatabase")] XrmHashBucketRec* database);

        [DllImport(libraryPath, EntryPoint = "XrmQPutResource", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XrmQPutResource([NativeTypeName("XrmDatabase *")] XrmHashBucketRec** database, [NativeTypeName("XrmBindingList")] XrmBinding* bindings, [NativeTypeName("XrmQuarkList")] int* quarks, [NativeTypeName("XrmRepresentation")] int type, [NativeTypeName("XrmValue *")] XrmValue* value);

        [DllImport(libraryPath, EntryPoint = "XrmPutResource", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XrmPutResource([NativeTypeName("XrmDatabase *")] XrmHashBucketRec** database, [NativeTypeName("const char *")] sbyte* specifier, [NativeTypeName("const char *")] sbyte* type, [NativeTypeName("XrmValue *")] XrmValue* value);

        [DllImport(libraryPath, EntryPoint = "XrmQPutStringResource", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XrmQPutStringResource([NativeTypeName("XrmDatabase *")] XrmHashBucketRec** database, [NativeTypeName("XrmBindingList")] XrmBinding* bindings, [NativeTypeName("XrmQuarkList")] int* quarks, [NativeTypeName("const char *")] sbyte* value);

        [DllImport(libraryPath, EntryPoint = "XrmPutStringResource", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XrmPutStringResource([NativeTypeName("XrmDatabase *")] XrmHashBucketRec** database, [NativeTypeName("const char *")] sbyte* specifier, [NativeTypeName("const char *")] sbyte* value);

        [DllImport(libraryPath, EntryPoint = "XrmPutLineResource", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XrmPutLineResource([NativeTypeName("XrmDatabase *")] XrmHashBucketRec** database, [NativeTypeName("const char *")] sbyte* line);

        [DllImport(libraryPath, EntryPoint = "XrmQGetResource", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XrmQGetResource([NativeTypeName("XrmDatabase")] XrmHashBucketRec* database, [NativeTypeName("XrmNameList")] int* quark_name, [NativeTypeName("XrmClassList")] int* quark_class, [NativeTypeName("XrmRepresentation *")] int* quark_type_return, [NativeTypeName("XrmValue *")] XrmValue* value_return);

        [DllImport(libraryPath, EntryPoint = "XrmGetResource", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XrmGetResource([NativeTypeName("XrmDatabase")] XrmHashBucketRec* database, [NativeTypeName("const char *")] sbyte* str_name, [NativeTypeName("const char *")] sbyte* str_class, [NativeTypeName("char **")] sbyte** str_type_return, [NativeTypeName("XrmValue *")] XrmValue* value_return);

        [DllImport(libraryPath, EntryPoint = "XrmQGetSearchList", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XrmQGetSearchList([NativeTypeName("XrmDatabase")] XrmHashBucketRec* database, [NativeTypeName("XrmNameList")] int* names, [NativeTypeName("XrmClassList")] int* classes, [NativeTypeName("XrmSearchList")] XrmHashBucketRec** list_return, int list_length);

        [DllImport(libraryPath, EntryPoint = "XrmQGetSearchResource", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XrmQGetSearchResource([NativeTypeName("XrmSearchList")] XrmHashBucketRec** list, [NativeTypeName("XrmName")] int name, [NativeTypeName("XrmClass")] int c_class, [NativeTypeName("XrmRepresentation *")] int* type_return, [NativeTypeName("XrmValue *")] XrmValue* value_return);

        [DllImport(libraryPath, EntryPoint = "XrmSetDatabase", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XrmSetDatabase([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("XrmDatabase")] XrmHashBucketRec* database);

        [DllImport(libraryPath, EntryPoint = "XrmGetDatabase", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XrmDatabase")]
        public static extern XrmHashBucketRec* XrmGetDatabase([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(libraryPath, EntryPoint = "XrmGetFileDatabase", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XrmDatabase")]
        public static extern XrmHashBucketRec* XrmGetFileDatabase([NativeTypeName("const char *")] sbyte* filename);

        [DllImport(libraryPath, EntryPoint = "XrmCombineFileDatabase", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XrmCombineFileDatabase([NativeTypeName("const char *")] sbyte* filename, [NativeTypeName("XrmDatabase *")] XrmHashBucketRec** target, int c_override);

        [DllImport(libraryPath, EntryPoint = "XrmGetStringDatabase", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("XrmDatabase")]
        public static extern XrmHashBucketRec* XrmGetStringDatabase([NativeTypeName("const char *")] sbyte* data);

        [DllImport(libraryPath, EntryPoint = "XrmPutFileDatabase", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XrmPutFileDatabase([NativeTypeName("XrmDatabase")] XrmHashBucketRec* database, [NativeTypeName("const char *")] sbyte* filename);

        [DllImport(libraryPath, EntryPoint = "XrmMergeDatabases", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XrmMergeDatabases([NativeTypeName("XrmDatabase")] XrmHashBucketRec* source_db, [NativeTypeName("XrmDatabase *")] XrmHashBucketRec** target_db);

        [DllImport(libraryPath, EntryPoint = "XrmCombineDatabase", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XrmCombineDatabase([NativeTypeName("XrmDatabase")] XrmHashBucketRec* source_db, [NativeTypeName("XrmDatabase *")] XrmHashBucketRec** target_db, int c_override);

        [DllImport(libraryPath, EntryPoint = "XrmEnumerateDatabase", CallingConvention = CallingConvention.Cdecl)]
        public static extern int XrmEnumerateDatabase([NativeTypeName("XrmDatabase")] XrmHashBucketRec* db, [NativeTypeName("XrmNameList")] int* name_prefix, [NativeTypeName("XrmClassList")] int* class_prefix, int mode, [NativeTypeName("int (*)(XrmDatabase *, XrmBindingList, XrmQuarkList, XrmRepresentation *, XrmValue *, XPointer)")] IntPtr proc, [NativeTypeName("XPointer")] sbyte* closure);

        [DllImport(libraryPath, EntryPoint = "XrmLocaleOfDatabase", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* XrmLocaleOfDatabase([NativeTypeName("XrmDatabase")] XrmHashBucketRec* database);

        [DllImport(libraryPath, EntryPoint = "XrmParseCommand", CallingConvention = CallingConvention.Cdecl)]
        public static extern void XrmParseCommand([NativeTypeName("XrmDatabase *")] XrmHashBucketRec** database, [NativeTypeName("XrmOptionDescList")] XrmOptionDescRec* table, int table_count, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("int *")] int* argc_in_out, [NativeTypeName("char **")] sbyte** argv_in_out);
    }
}
