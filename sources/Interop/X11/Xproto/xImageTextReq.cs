namespace TerraFX.Interop
{
    public partial struct xImageTextReq
    {
        [NativeTypeName("CARD8")]
        public byte reqType;

        [NativeTypeName("BYTE")]
        public byte nChars;

        [NativeTypeName("CARD16")]
        public ushort length;

        [NativeTypeName("CARD32")]
        public uint drawable;

        [NativeTypeName("CARD32")]
        public uint gc;

        [NativeTypeName("INT16")]
        public short x;

        [NativeTypeName("INT16")]
        public short y;
    }
}
