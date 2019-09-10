namespace TerraFX.Interop
{
    public partial struct xArc
    {
        [NativeTypeName("INT16")]
        public short x;

        [NativeTypeName("INT16")]
        public short y;

        [NativeTypeName("CARD16")]
        public ushort width;

        [NativeTypeName("CARD16")]
        public ushort height;

        [NativeTypeName("INT16")]
        public short angle1;

        [NativeTypeName("INT16")]
        public short angle2;
    }
}
