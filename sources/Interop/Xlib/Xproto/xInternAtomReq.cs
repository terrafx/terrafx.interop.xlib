namespace TerraFX.Interop
{
    public partial struct xInternAtomReq
    {
        [NativeTypeName("CARD8")]
        public byte reqType;

        [NativeTypeName("BOOL")]
        public byte onlyIfExists;

        [NativeTypeName("CARD16")]
        public ushort length;

        [NativeTypeName("CARD16")]
        public ushort nbytes;

        [NativeTypeName("CARD16")]
        public ushort pad;
    }
}
