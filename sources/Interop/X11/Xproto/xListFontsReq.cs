namespace TerraFX.Interop
{
    public partial struct xListFontsReq
    {
        [NativeTypeName("CARD8")]
        public byte reqType;

        [NativeTypeName("BYTE")]
        public byte pad;

        [NativeTypeName("CARD16")]
        public ushort length;

        [NativeTypeName("CARD16")]
        public ushort maxNames;

        [NativeTypeName("CARD16")]
        public ushort nbytes;
    }
}
