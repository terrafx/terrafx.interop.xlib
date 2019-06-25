namespace TerraFX.Interop
{
    public partial struct xGetScreenSaverReply
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
        public ushort timeout;

        [NativeTypeName("CARD16")]
        public ushort interval;

        [NativeTypeName("BOOL")]
        public byte preferBlanking;

        [NativeTypeName("BOOL")]
        public byte allowExposures;

        [NativeTypeName("CARD16")]
        public ushort pad2;

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
