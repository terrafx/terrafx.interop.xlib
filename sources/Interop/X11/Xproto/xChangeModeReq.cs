namespace TerraFX.Interop
{
    public partial struct xChangeModeReq
    {
        [NativeTypeName("CARD8")]
        public byte reqType;

        [NativeTypeName("BYTE")]
        public byte mode;

        [NativeTypeName("CARD16")]
        public ushort length;
    }
}
