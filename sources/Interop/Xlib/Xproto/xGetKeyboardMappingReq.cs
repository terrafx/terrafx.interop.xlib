namespace TerraFX.Interop
{
    public partial struct xGetKeyboardMappingReq
    {
        [NativeTypeName("CARD8")]
        public byte reqType;

        [NativeTypeName("BYTE")]
        public byte pad;

        [NativeTypeName("CARD16")]
        public ushort length;

        [NativeTypeName("CARD8")]
        public byte firstKeyCode;

        [NativeTypeName("CARD8")]
        public byte count;

        [NativeTypeName("CARD16")]
        public ushort pad1;
    }
}
