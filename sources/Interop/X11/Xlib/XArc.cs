namespace TerraFX.Interop
{
    public partial struct XArc
    {
        public short x;

        public short y;

        [NativeTypeName("unsigned short")]
        public ushort width;

        [NativeTypeName("unsigned short")]
        public ushort height;

        public short angle1;

        public short angle2;
    }
}
