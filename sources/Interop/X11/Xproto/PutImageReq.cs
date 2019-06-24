namespace TerraFX.Interop
{
    public partial struct PutImageReq
    {
        [NativeTypeName("CARD8")]
        public byte reqType;

        [NativeTypeName("CARD8")]
        public byte format;

        [NativeTypeName("CARD16")]
        public ushort length;

        [NativeTypeName("CARD32")]
        public uint drawable;

        [NativeTypeName("CARD32")]
        public uint gc;

        [NativeTypeName("CARD16")]
        public ushort width;

        [NativeTypeName("CARD16")]
        public ushort height;

        [NativeTypeName("INT16")]
        public short dstX;

        [NativeTypeName("INT16")]
        public short dstY;

        [NativeTypeName("CARD8")]
        public byte leftPad;

        [NativeTypeName("CARD8")]
        public byte depth;

        [NativeTypeName("CARD16")]
        public ushort pad;
    }
}
