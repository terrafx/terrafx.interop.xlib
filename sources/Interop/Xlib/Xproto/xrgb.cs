namespace TerraFX.Interop
{
    public partial struct xrgb
    {
        [NativeTypeName("CARD16")]
        public ushort red;

        [NativeTypeName("CARD16")]
        public ushort green;

        [NativeTypeName("CARD16")]
        public ushort blue;

        [NativeTypeName("CARD16")]
        public ushort pad;
    }
}
