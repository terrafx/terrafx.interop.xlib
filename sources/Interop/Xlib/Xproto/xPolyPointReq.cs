namespace TerraFX.Interop
{
    public partial struct xPolyPointReq
    {
        [NativeTypeName("CARD8")]
        public byte reqType;

        [NativeTypeName("BYTE")]
        public byte coordMode;

        [NativeTypeName("CARD16")]
        public ushort length;

        [NativeTypeName("CARD32")]
        public uint drawable;

        [NativeTypeName("CARD32")]
        public uint gc;
    }
}
