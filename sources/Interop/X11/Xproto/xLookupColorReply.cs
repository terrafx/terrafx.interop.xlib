namespace TerraFX.Interop
{
    public partial struct xLookupColorReply
    {
        [NativeTypeName("BYTE")]
        public byte type;

        [NativeTypeName("BYTE")]
        public byte pad1;

        [NativeTypeName("CARD16")]
        public ushort sequenceNumber;

        [NativeTypeName("CARD32")]
        public uint length;

        [NativeTypeName("CARD16")]
        public ushort exactRed;

        [NativeTypeName("CARD16")]
        public ushort exactGreen;

        [NativeTypeName("CARD16")]
        public ushort exactBlue;

        [NativeTypeName("CARD16")]
        public ushort screenRed;

        [NativeTypeName("CARD16")]
        public ushort screenGreen;

        [NativeTypeName("CARD16")]
        public ushort screenBlue;

        [NativeTypeName("CARD32")]
        public uint pad3;

        [NativeTypeName("CARD32")]
        public uint pad4;

        [NativeTypeName("CARD32")]
        public uint pad5;
    }
}
