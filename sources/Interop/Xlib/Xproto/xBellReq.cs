namespace TerraFX.Interop
{
    public partial struct xBellReq
    {
        [NativeTypeName("CARD8")]
        public byte reqType;

        [NativeTypeName("INT8")]
        public sbyte percent;

        [NativeTypeName("CARD16")]
        public ushort length;
    }
}
