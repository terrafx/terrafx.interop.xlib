namespace TerraFX.Interop
{
    public partial struct xConfigureWindowReq
    {
        [NativeTypeName("CARD8")]
        public byte reqType;

        [NativeTypeName("CARD8")]
        public byte pad;

        [NativeTypeName("CARD16")]
        public ushort length;

        [NativeTypeName("CARD32")]
        public uint window;

        [NativeTypeName("CARD16")]
        public ushort mask;

        [NativeTypeName("CARD16")]
        public ushort pad2;
    }
}
