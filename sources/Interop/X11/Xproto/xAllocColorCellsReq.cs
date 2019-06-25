namespace TerraFX.Interop
{
    public partial struct xAllocColorCellsReq
    {
        [NativeTypeName("CARD8")]
        public byte reqType;

        [NativeTypeName("BOOL")]
        public byte contiguous;

        [NativeTypeName("CARD16")]
        public ushort length;

        [NativeTypeName("CARD32")]
        public uint cmap;

        [NativeTypeName("CARD16")]
        public ushort colors;

        [NativeTypeName("CARD16")]
        public ushort planes;
    }
}
