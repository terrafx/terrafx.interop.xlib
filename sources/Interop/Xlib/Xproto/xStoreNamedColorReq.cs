namespace TerraFX.Interop
{
    public partial struct xStoreNamedColorReq
    {
        [NativeTypeName("CARD8")]
        public byte reqType;

        [NativeTypeName("CARD8")]
        public byte flags;

        [NativeTypeName("CARD16")]
        public ushort length;

        [NativeTypeName("CARD32")]
        public uint cmap;

        [NativeTypeName("CARD32")]
        public uint pixel;

        [NativeTypeName("CARD16")]
        public ushort nbytes;

        [NativeTypeName("BYTE")]
        public byte pad1;

        [NativeTypeName("BYTE")]
        public byte pad2;
    }
}
