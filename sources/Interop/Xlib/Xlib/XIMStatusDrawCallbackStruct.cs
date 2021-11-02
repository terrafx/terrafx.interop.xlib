// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct XIMStatusDrawCallbackStruct
    {
        public XIMStatusDataType type;

        [NativeTypeName("union (anonymous union at /usr/include/X11/Xlib.h:1359:5)")]
        public _data_e__Union data;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _data_e__Union
        {
            [FieldOffset(0)]
            public XIMText* text;

            [FieldOffset(0)]
            public Pixmap bitmap;
        }
    }
}
