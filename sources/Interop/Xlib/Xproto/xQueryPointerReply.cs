namespace TerraFX.Interop
{
    public partial struct xQueryPointerReply
    {
        [NativeTypeName("BYTE")]
        public byte type;

        [NativeTypeName("BOOL")]
        public byte sameScreen;

        [NativeTypeName("CARD16")]
        public ushort sequenceNumber;

        [NativeTypeName("CARD32")]
        public uint length;

        [NativeTypeName("CARD32")]
        public uint root;

        [NativeTypeName("CARD32")]
        public uint child;

        [NativeTypeName("INT16")]
        public short rootX;

        [NativeTypeName("INT16")]
        public short rootY;

        [NativeTypeName("INT16")]
        public short winX;

        [NativeTypeName("INT16")]
        public short winY;

        [NativeTypeName("CARD16")]
        public ushort mask;

        [NativeTypeName("CARD16")]
        public ushort pad1;

        [NativeTypeName("CARD32")]
        public uint pad;
    }
}
