namespace TerraFX.Interop
{
    public partial struct xTimecoord
    {
        [NativeTypeName("CARD32")]
        public uint time;

        [NativeTypeName("INT16")]
        public short x;

        [NativeTypeName("INT16")]
        public short y;
    }
}
