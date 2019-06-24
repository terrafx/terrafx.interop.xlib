namespace TerraFX.Interop
{
    public partial struct xCopyColormapAndFreeReq
    {
        [NativeTypeName("CARD8")]
        public byte reqType;

        [NativeTypeName("BYTE")]
        public byte pad;

        [NativeTypeName("CARD16")]
        public ushort length;

        [NativeTypeName("CARD32")]
        public uint mid;

        [NativeTypeName("CARD32")]
        public uint srcCmap;
    }
}
