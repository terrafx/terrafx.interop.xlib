namespace TerraFX.Interop
{
    public partial struct xReq
    {
        [NativeTypeName("CARD8")]
        public byte reqType;

        [NativeTypeName("CARD8")]
        public byte data;

        [NativeTypeName("CARD16")]
        public ushort length;
    }
}
