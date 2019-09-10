namespace TerraFX.Interop
{
    public partial struct xClearAreaReq
    {
        [NativeTypeName("CARD8")]
        public byte reqType;

        [NativeTypeName("BOOL")]
        public byte exposures;

        [NativeTypeName("CARD16")]
        public ushort length;

        [NativeTypeName("CARD32")]
        public uint window;

        [NativeTypeName("INT16")]
        public short x;

        [NativeTypeName("INT16")]
        public short y;

        [NativeTypeName("CARD16")]
        public ushort width;

        [NativeTypeName("CARD16")]
        public ushort height;
    }
}
