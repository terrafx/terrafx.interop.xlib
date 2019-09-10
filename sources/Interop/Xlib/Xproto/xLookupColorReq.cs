namespace TerraFX.Interop
{
    public partial struct xLookupColorReq
    {
        [NativeTypeName("CARD8")]
        public byte reqType;

        [NativeTypeName("BYTE")]
        public byte pad;

        [NativeTypeName("CARD16")]
        public ushort length;

        [NativeTypeName("CARD32")]
        public uint cmap;

        [NativeTypeName("CARD16")]
        public ushort nbytes;

        [NativeTypeName("BYTE")]
        public byte pad1;

        [NativeTypeName("BYTE")]
        public byte pad2;
    }
}
