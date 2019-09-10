namespace TerraFX.Interop
{
    public partial struct xSetPointerMappingReq
    {
        [NativeTypeName("CARD8")]
        public byte reqType;

        [NativeTypeName("CARD8")]
        public byte nElts;

        [NativeTypeName("CARD16")]
        public ushort length;
    }
}
