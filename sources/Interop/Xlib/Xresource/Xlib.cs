// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\Xresource.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group and Digital Equipment Corporation, Maynard, Massachusetts.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Xlib
    {
        [DllImport(LibraryPath, EntryPoint = "Xpermalloc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* Xpermalloc([NativeTypeName("unsigned int")] uint size);

        [DllImport(LibraryPath, EntryPoint = "XrmStringToQuark", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XrmQuark")]
        public static extern int XrmStringToQuark([NativeTypeName("const char *")] sbyte* c_string);

        [DllImport(LibraryPath, EntryPoint = "XrmPermStringToQuark", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XrmQuark")]
        public static extern int XrmPermStringToQuark([NativeTypeName("const char *")] sbyte* c_string);

        [DllImport(LibraryPath, EntryPoint = "XrmQuarkToString", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XrmString")]
        public static extern sbyte* XrmQuarkToString([NativeTypeName("XrmQuark")] int quark);

        [DllImport(LibraryPath, EntryPoint = "XrmUniqueQuark", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XrmQuark")]
        public static extern int XrmUniqueQuark();

        [DllImport(LibraryPath, EntryPoint = "XrmStringToQuarkList", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XrmStringToQuarkList([NativeTypeName("const char *")] sbyte* c_string, [NativeTypeName("XrmQuarkList")] int* quarks_return);

        [DllImport(LibraryPath, EntryPoint = "XrmStringToBindingQuarkList", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XrmStringToBindingQuarkList([NativeTypeName("const char *")] sbyte* c_string, [NativeTypeName("XrmBindingList")] XrmBinding* bindings_return, [NativeTypeName("XrmQuarkList")] int* quarks_return);

        [DllImport(LibraryPath, EntryPoint = "XrmDestroyDatabase", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XrmDestroyDatabase([NativeTypeName("XrmDatabase")] XrmHashBucketRec* database);

        [DllImport(LibraryPath, EntryPoint = "XrmQPutResource", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XrmQPutResource([NativeTypeName("XrmDatabase *")] XrmHashBucketRec** database, [NativeTypeName("XrmBindingList")] XrmBinding* bindings, [NativeTypeName("XrmQuarkList")] int* quarks, [NativeTypeName("XrmRepresentation")] int type, [NativeTypeName("XrmValue *")] XrmValue* value);

        [DllImport(LibraryPath, EntryPoint = "XrmPutResource", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XrmPutResource([NativeTypeName("XrmDatabase *")] XrmHashBucketRec** database, [NativeTypeName("const char *")] sbyte* specifier, [NativeTypeName("const char *")] sbyte* type, [NativeTypeName("XrmValue *")] XrmValue* value);

        [DllImport(LibraryPath, EntryPoint = "XrmQPutStringResource", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XrmQPutStringResource([NativeTypeName("XrmDatabase *")] XrmHashBucketRec** database, [NativeTypeName("XrmBindingList")] XrmBinding* bindings, [NativeTypeName("XrmQuarkList")] int* quarks, [NativeTypeName("const char *")] sbyte* value);

        [DllImport(LibraryPath, EntryPoint = "XrmPutStringResource", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XrmPutStringResource([NativeTypeName("XrmDatabase *")] XrmHashBucketRec** database, [NativeTypeName("const char *")] sbyte* specifier, [NativeTypeName("const char *")] sbyte* value);

        [DllImport(LibraryPath, EntryPoint = "XrmPutLineResource", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XrmPutLineResource([NativeTypeName("XrmDatabase *")] XrmHashBucketRec** database, [NativeTypeName("const char *")] sbyte* line);

        [DllImport(LibraryPath, EntryPoint = "XrmQGetResource", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XrmQGetResource([NativeTypeName("XrmDatabase")] XrmHashBucketRec* database, [NativeTypeName("XrmNameList")] int* quark_name, [NativeTypeName("XrmClassList")] int* quark_class, [NativeTypeName("XrmRepresentation *")] int* quark_type_return, [NativeTypeName("XrmValue *")] XrmValue* value_return);

        [DllImport(LibraryPath, EntryPoint = "XrmGetResource", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XrmGetResource([NativeTypeName("XrmDatabase")] XrmHashBucketRec* database, [NativeTypeName("const char *")] sbyte* str_name, [NativeTypeName("const char *")] sbyte* str_class, [NativeTypeName("char **")] sbyte** str_type_return, [NativeTypeName("XrmValue *")] XrmValue* value_return);

        [DllImport(LibraryPath, EntryPoint = "XrmQGetSearchList", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XrmQGetSearchList([NativeTypeName("XrmDatabase")] XrmHashBucketRec* database, [NativeTypeName("XrmNameList")] int* names, [NativeTypeName("XrmClassList")] int* classes, [NativeTypeName("XrmSearchList")] XrmHashBucketRec** list_return, int list_length);

        [DllImport(LibraryPath, EntryPoint = "XrmQGetSearchResource", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XrmQGetSearchResource([NativeTypeName("XrmSearchList")] XrmHashBucketRec** list, [NativeTypeName("XrmName")] int name, [NativeTypeName("XrmClass")] int c_class, [NativeTypeName("XrmRepresentation *")] int* type_return, [NativeTypeName("XrmValue *")] XrmValue* value_return);

        [DllImport(LibraryPath, EntryPoint = "XrmSetDatabase", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XrmSetDatabase([NativeTypeName("Display *")] UIntPtr display, [NativeTypeName("XrmDatabase")] XrmHashBucketRec* database);

        [DllImport(LibraryPath, EntryPoint = "XrmGetDatabase", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XrmDatabase")]
        public static extern XrmHashBucketRec* XrmGetDatabase([NativeTypeName("Display *")] UIntPtr display);

        [DllImport(LibraryPath, EntryPoint = "XrmGetFileDatabase", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XrmDatabase")]
        public static extern XrmHashBucketRec* XrmGetFileDatabase([NativeTypeName("const char *")] sbyte* filename);

        [DllImport(LibraryPath, EntryPoint = "XrmCombineFileDatabase", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XrmCombineFileDatabase([NativeTypeName("const char *")] sbyte* filename, [NativeTypeName("XrmDatabase *")] XrmHashBucketRec** target, int c_override);

        [DllImport(LibraryPath, EntryPoint = "XrmGetStringDatabase", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XrmDatabase")]
        public static extern XrmHashBucketRec* XrmGetStringDatabase([NativeTypeName("const char *")] sbyte* data);

        [DllImport(LibraryPath, EntryPoint = "XrmPutFileDatabase", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XrmPutFileDatabase([NativeTypeName("XrmDatabase")] XrmHashBucketRec* database, [NativeTypeName("const char *")] sbyte* filename);

        [DllImport(LibraryPath, EntryPoint = "XrmMergeDatabases", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XrmMergeDatabases([NativeTypeName("XrmDatabase")] XrmHashBucketRec* source_db, [NativeTypeName("XrmDatabase *")] XrmHashBucketRec** target_db);

        [DllImport(LibraryPath, EntryPoint = "XrmCombineDatabase", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XrmCombineDatabase([NativeTypeName("XrmDatabase")] XrmHashBucketRec* source_db, [NativeTypeName("XrmDatabase *")] XrmHashBucketRec** target_db, int c_override);

        [DllImport(LibraryPath, EntryPoint = "XrmEnumerateDatabase", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XrmEnumerateDatabase([NativeTypeName("XrmDatabase")] XrmHashBucketRec* db, [NativeTypeName("XrmNameList")] int* name_prefix, [NativeTypeName("XrmClassList")] int* class_prefix, int mode, [NativeTypeName("int (*)(XrmDatabase *, XrmBindingList, XrmQuarkList, XrmRepresentation *, XrmValue *, XPointer)")] IntPtr proc, [NativeTypeName("XPointer")] sbyte* closure);

        [DllImport(LibraryPath, EntryPoint = "XrmLocaleOfDatabase", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* XrmLocaleOfDatabase([NativeTypeName("XrmDatabase")] XrmHashBucketRec* database);

        [DllImport(LibraryPath, EntryPoint = "XrmParseCommand", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XrmParseCommand([NativeTypeName("XrmDatabase *")] XrmHashBucketRec** database, [NativeTypeName("XrmOptionDescList")] XrmOptionDescRec* table, int table_count, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("int *")] int* argc_in_out, [NativeTypeName("char **")] sbyte** argv_in_out);
    }
}
