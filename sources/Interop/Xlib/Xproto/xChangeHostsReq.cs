namespace TerraFX.Interop
{
    public partial struct xChangeHostsReq
    {
        [NativeTypeName("CARD8")]
        public byte reqType;

        [NativeTypeName("BYTE")]
        public byte mode;

        [NativeTypeName("CARD16")]
        public ushort length;

        [NativeTypeName("CARD8")]
        public byte hostFamily;

        [NativeTypeName("BYTE")]
        public byte pad;

        [NativeTypeName("CARD16")]
        public ushort hostLength;
    }
}
