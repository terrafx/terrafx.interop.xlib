// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\Xlibint.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct XGC
    {
        [NativeTypeName("XExtData *")]
        public XExtData* ext_data;

        [NativeTypeName("GContext")]
        public UIntPtr gid;

        public int rects;

        public int dashes;

        [NativeTypeName("unsigned long")]
        public UIntPtr dirty;

        public XGCValues values;
    }
}
