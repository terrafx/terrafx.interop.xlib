// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\Xlibint.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System;

namespace TerraFX.Interop
{
    public partial struct XAsyncEState
    {
        [NativeTypeName("unsigned long")]
        public UIntPtr min_sequence_number;

        [NativeTypeName("unsigned long")]
        public UIntPtr max_sequence_number;

        [NativeTypeName("unsigned char")]
        public byte error_code;

        [NativeTypeName("unsigned char")]
        public byte major_opcode;

        [NativeTypeName("unsigned short")]
        public ushort minor_opcode;

        [NativeTypeName("unsigned char")]
        public byte last_error_received;

        public int error_count;
    }
}
