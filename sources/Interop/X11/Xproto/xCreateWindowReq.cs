namespace TerraFX.Interop
{
    public partial struct xCreateWindowReq
    {
        [NativeTypeName("CARD8")]
        public byte reqType;

        [NativeTypeName("CARD8")]
        public byte depth;

        [NativeTypeName("CARD16")]
        public ushort length;

        [NativeTypeName("CARD32")]
        public uint wid;

        [NativeTypeName("CARD32")]
        public uint parent;

        [NativeTypeName("INT16")]
        public short x;

        [NativeTypeName("INT16")]
        public short y;

        [NativeTypeName("CARD16")]
        public ushort width;

        [NativeTypeName("CARD16")]
        public ushort height;

        [NativeTypeName("CARD16")]
        public ushort borderWidth;

        [NativeTypeName("CARD16")]
        public ushort c_class;

        [NativeTypeName("CARD32")]
        public uint visual;

        [NativeTypeName("CARD32")]
        public uint mask;
    }
}
