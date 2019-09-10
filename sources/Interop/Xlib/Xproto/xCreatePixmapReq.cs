namespace TerraFX.Interop
{
    public partial struct xCreatePixmapReq
    {
        [NativeTypeName("CARD8")]
        public byte reqType;

        [NativeTypeName("CARD8")]
        public byte depth;

        [NativeTypeName("CARD16")]
        public ushort length;

        [NativeTypeName("CARD32")]
        public uint pid;

        [NativeTypeName("CARD32")]
        public uint drawable;

        [NativeTypeName("CARD16")]
        public ushort width;

        [NativeTypeName("CARD16")]
        public ushort height;
    }
}
