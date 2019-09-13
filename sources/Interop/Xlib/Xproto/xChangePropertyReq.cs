namespace TerraFX.Interop
{
    public unsafe partial struct xChangePropertyReq
    {
        [NativeTypeName("CARD8")]
        public byte reqType;

        [NativeTypeName("CARD8")]
        public byte mode;

        [NativeTypeName("CARD16")]
        public ushort length;

        [NativeTypeName("CARD32")]
        public uint window;

        [NativeTypeName("CARD32")]
        public uint property;

        [NativeTypeName("CARD32")]
        public uint type;

        [NativeTypeName("CARD8")]
        public byte format;

        [NativeTypeName("BYTE [3]")]
        public fixed byte pad[3];

        [NativeTypeName("CARD32")]
        public uint nUnits;
    }
}
