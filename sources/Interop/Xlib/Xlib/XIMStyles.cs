using System;

namespace TerraFX.Interop
{
    public unsafe partial struct XIMStyles
    {
        [NativeTypeName("unsigned short")]
        public ushort count_styles;

        [NativeTypeName("XIMStyle *")]
        public UIntPtr* supported_styles;
    }
}
