namespace TerraFX.Interop
{
    public partial struct xListHostsReq
    {
        [NativeTypeName("CARD8")]
        public byte reqType;

        [NativeTypeName("BYTE")]
        public byte pad;

        [NativeTypeName("CARD16")]
        public ushort length;
    }
}
