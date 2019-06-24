namespace TerraFX.Interop
{
    public partial struct xInternAtomReply
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
        public uint atom;

        [NativeTypeName("CARD32")]
        public uint pad2;

        [NativeTypeName("CARD32")]
        public uint pad3;

        [NativeTypeName("CARD32")]
        public uint pad4;

        [NativeTypeName("CARD32")]
        public uint pad5;

        [NativeTypeName("CARD32")]
        public uint pad6;
    }
}
