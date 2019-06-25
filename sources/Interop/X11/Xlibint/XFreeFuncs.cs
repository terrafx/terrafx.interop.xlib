// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\Xlibint.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System;

namespace TerraFX.Interop
{
    public partial struct XFreeFuncs
    {
        [NativeTypeName("FreeFuncType")]
        public IntPtr atoms;

        [NativeTypeName("FreeModmapType")]
        public IntPtr modifiermap;

        [NativeTypeName("FreeFuncType")]
        public IntPtr key_bindings;

        [NativeTypeName("FreeFuncType")]
        public IntPtr context_db;

        [NativeTypeName("FreeFuncType")]
        public IntPtr defaultCCCs;

        [NativeTypeName("FreeFuncType")]
        public IntPtr clientCmaps;

        [NativeTypeName("FreeFuncType")]
        public IntPtr intensityMaps;

        [NativeTypeName("FreeFuncType")]
        public IntPtr im_filters;

        [NativeTypeName("FreeFuncType")]
        public IntPtr xkb;
    }
}
