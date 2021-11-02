// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xresource.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Xlib
    {
        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* Xpermalloc([NativeTypeName("unsigned int")] uint param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("XrmQuark")]
        public static extern int XrmStringToQuark([NativeTypeName("const char *")] sbyte* param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("XrmQuark")]
        public static extern int XrmPermStringToQuark([NativeTypeName("const char *")] sbyte* param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("XrmString")]
        public static extern sbyte* XrmQuarkToString([NativeTypeName("XrmQuark")] int param0);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("XrmQuark")]
        public static extern int XrmUniqueQuark();

        [DllImport("libX11", ExactSpelling = true)]
        public static extern void XrmStringToQuarkList([NativeTypeName("const char *")] sbyte* param0, [NativeTypeName("XrmQuarkList")] int* param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern void XrmStringToBindingQuarkList([NativeTypeName("const char *")] sbyte* param0, [NativeTypeName("XrmBindingList")] XrmBinding* param1, [NativeTypeName("XrmQuarkList")] int* param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern void XrmDestroyDatabase(XrmDatabase param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern void XrmQPutResource(XrmDatabase* param0, [NativeTypeName("XrmBindingList")] XrmBinding* param1, [NativeTypeName("XrmQuarkList")] int* param2, [NativeTypeName("XrmRepresentation")] int param3, XrmValue* param4);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern void XrmPutResource(XrmDatabase* param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("const char *")] sbyte* param2, XrmValue* param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern void XrmQPutStringResource(XrmDatabase* param0, [NativeTypeName("XrmBindingList")] XrmBinding* param1, [NativeTypeName("XrmQuarkList")] int* param2, [NativeTypeName("const char *")] sbyte* param3);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern void XrmPutStringResource(XrmDatabase* param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("const char *")] sbyte* param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern void XrmPutLineResource(XrmDatabase* param0, [NativeTypeName("const char *")] sbyte* param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XrmQGetResource(XrmDatabase param0, [NativeTypeName("XrmNameList")] int* param1, [NativeTypeName("XrmClassList")] int* param2, [NativeTypeName("XrmRepresentation *")] int* param3, XrmValue* param4);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XrmGetResource(XrmDatabase param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("char **")] sbyte** param3, XrmValue* param4);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XrmQGetSearchList(XrmDatabase param0, [NativeTypeName("XrmNameList")] int* param1, [NativeTypeName("XrmClassList")] int* param2, [NativeTypeName("XrmSearchList")] XrmHashBucket** param3, int param4);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XrmQGetSearchResource([NativeTypeName("XrmSearchList")] XrmHashBucket** param0, [NativeTypeName("XrmName")] int param1, [NativeTypeName("XrmClass")] int param2, [NativeTypeName("XrmRepresentation *")] int* param3, XrmValue* param4);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern void XrmSetDatabase(Display* param0, XrmDatabase param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern XrmDatabase XrmGetDatabase(Display* param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern XrmDatabase XrmGetFileDatabase([NativeTypeName("const char *")] sbyte* param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XrmCombineFileDatabase([NativeTypeName("const char *")] sbyte* param0, XrmDatabase* param1, int param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern XrmDatabase XrmGetStringDatabase([NativeTypeName("const char *")] sbyte* param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern void XrmPutFileDatabase(XrmDatabase param0, [NativeTypeName("const char *")] sbyte* param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern void XrmMergeDatabases(XrmDatabase param0, XrmDatabase* param1);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern void XrmCombineDatabase(XrmDatabase param0, XrmDatabase* param1, int param2);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern int XrmEnumerateDatabase(XrmDatabase param0, [NativeTypeName("XrmNameList")] int* param1, [NativeTypeName("XrmClassList")] int* param2, int param3, [NativeTypeName("int (*)(XrmDatabase *, XrmBindingList, XrmQuarkList, XrmRepresentation *, XrmValue *, XPointer)")] delegate* unmanaged<XrmDatabase*, XrmBinding*, int*, int*, XrmValue*, sbyte*, int> param4, [NativeTypeName("XPointer")] sbyte* param5);

        [DllImport("libX11", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* XrmLocaleOfDatabase(XrmDatabase param0);

        [DllImport("libX11", ExactSpelling = true)]
        public static extern void XrmParseCommand(XrmDatabase* param0, [NativeTypeName("XrmOptionDescList")] XrmOptionDescRec* param1, int param2, [NativeTypeName("const char *")] sbyte* param3, int* param4, [NativeTypeName("char **")] sbyte** param5);

        [NativeTypeName("#define NULLQUARK ((XrmQuark) 0)")]
        public const int NULLQUARK = ((int)(0));

        [NativeTypeName("#define NULLSTRING ((XrmString) 0)")]
        public static sbyte* NULLSTRING => ((sbyte*)(0));

        [NativeTypeName("#define XrmEnumAllLevels 0")]
        public const int XrmEnumAllLevels = 0;

        [NativeTypeName("#define XrmEnumOneLevel 1")]
        public const int XrmEnumOneLevel = 1;
    }
}
