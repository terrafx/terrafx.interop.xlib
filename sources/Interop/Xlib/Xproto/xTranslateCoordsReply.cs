namespace TerraFX.Interop
{
    public partial struct xTranslateCoordsReply
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
        public uint child;

        [NativeTypeName("INT16")]
        public short dstX;

        [NativeTypeName("INT16")]
        public short dstY;

        [NativeTypeName("CARD32")]
        public uint pad2;

        [NativeTypeName("CARD32")]
        public uint pad3;

        [NativeTypeName("CARD32")]
        public uint pad4;

        [NativeTypeName("CARD32")]
        public uint pad5;
    }
}
