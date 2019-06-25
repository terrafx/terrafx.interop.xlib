namespace TerraFX.Interop
{
    public partial struct xChangeKeyboardMappingReq
    {
        [NativeTypeName("CARD8")]
        public byte reqType;

        [NativeTypeName("CARD8")]
        public byte keyCodes;

        [NativeTypeName("CARD16")]
        public ushort length;

        [NativeTypeName("CARD8")]
        public byte firstKeyCode;

        [NativeTypeName("CARD8")]
        public byte keySymsPerKeyCode;

        [NativeTypeName("CARD16")]
        public ushort pad1;
    }
}
