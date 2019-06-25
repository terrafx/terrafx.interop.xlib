namespace TerraFX.Interop
{
    public partial struct xColorItem
    {
        [NativeTypeName("CARD32")]
        public uint pixel;

        [NativeTypeName("CARD16")]
        public ushort red;

        [NativeTypeName("CARD16")]
        public ushort green;

        [NativeTypeName("CARD16")]
        public ushort blue;

        [NativeTypeName("CARD8")]
        public byte flags;

        [NativeTypeName("CARD8")]
        public byte pad;
    }
}
