namespace TerraFX.Interop
{
    public partial struct xAllocColorReq
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
        public ushort red;

        [NativeTypeName("CARD16")]
        public ushort green;

        [NativeTypeName("CARD16")]
        public ushort blue;

        [NativeTypeName("CARD16")]
        public ushort pad2;
    }
}
