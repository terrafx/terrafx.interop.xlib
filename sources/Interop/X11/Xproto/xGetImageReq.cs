namespace TerraFX.Interop
{
    public partial struct xGetImageReq
    {
        [NativeTypeName("CARD8")]
        public byte reqType;

        [NativeTypeName("CARD8")]
        public byte format;

        [NativeTypeName("CARD16")]
        public ushort length;

        [NativeTypeName("CARD32")]
        public uint drawable;

        [NativeTypeName("INT16")]
        public short x;

        [NativeTypeName("INT16")]
        public short y;

        [NativeTypeName("CARD16")]
        public ushort width;

        [NativeTypeName("CARD16")]
        public ushort height;

        [NativeTypeName("CARD32")]
        public uint planeMask;
    }
}
