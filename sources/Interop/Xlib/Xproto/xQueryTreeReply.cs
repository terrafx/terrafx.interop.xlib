namespace TerraFX.Interop
{
    public partial struct xQueryTreeReply
    {
        [NativeTypeName("BYTE")]
        public byte type;

        [NativeTypeName("BYTE")]
        public byte pad1;

        [NativeTypeName("CARD16")]
        public ushort sequenceNumber;

        [NativeTypeName("CARD32")]
        public uint length;

        [NativeTypeName("CARD32")]
        public uint root;

        [NativeTypeName("CARD32")]
        public uint parent;

        [NativeTypeName("CARD16")]
        public ushort nChildren;

        [NativeTypeName("CARD16")]
        public ushort pad2;

        [NativeTypeName("CARD32")]
        public uint pad3;

        [NativeTypeName("CARD32")]
        public uint pad4;

        [NativeTypeName("CARD32")]
        public uint pad5;
    }
}
