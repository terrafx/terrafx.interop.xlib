namespace TerraFX.Interop
{
    public partial struct FillPolyReq
    {
        [NativeTypeName("CARD8")]
        public byte reqType;

        [NativeTypeName("BYTE")]
        public byte pad;

        [NativeTypeName("CARD16")]
        public ushort length;

        [NativeTypeName("CARD32")]
        public uint drawable;

        [NativeTypeName("CARD32")]
        public uint gc;

        [NativeTypeName("BYTE")]
        public byte shape;

        [NativeTypeName("BYTE")]
        public byte coordMode;

        [NativeTypeName("CARD16")]
        public ushort pad1;
    }
}
