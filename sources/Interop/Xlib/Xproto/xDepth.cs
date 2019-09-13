namespace TerraFX.Interop
{
    public partial struct xDepth
    {
        [NativeTypeName("CARD8")]
        public byte depth;

        [NativeTypeName("CARD8")]
        public byte pad1;

        [NativeTypeName("CARD16")]
        public ushort nVisuals;

        [NativeTypeName("CARD32")]
        public uint pad2;
    }
}
