namespace TerraFX.Interop
{
    public partial struct xGetPropertyReply
    {
        [NativeTypeName("BYTE")]
        public byte type;

        [NativeTypeName("CARD8")]
        public byte format;

        [NativeTypeName("CARD16")]
        public ushort sequenceNumber;

        [NativeTypeName("CARD32")]
        public uint length;

        [NativeTypeName("CARD32")]
        public uint propertyType;

        [NativeTypeName("CARD32")]
        public uint bytesAfter;

        [NativeTypeName("CARD32")]
        public uint nItems;

        [NativeTypeName("CARD32")]
        public uint pad1;

        [NativeTypeName("CARD32")]
        public uint pad2;

        [NativeTypeName("CARD32")]
        public uint pad3;
    }
}
