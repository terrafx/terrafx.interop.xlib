namespace TerraFX.Interop
{
    public partial struct xQueryExtensionReply
    {
        [NativeTypeName("BYTE")]
        public byte type;

        [NativeTypeName("BYTE")]
        public byte pad1;

        [NativeTypeName("CARD16")]
        public ushort sequenceNumber;

        [NativeTypeName("CARD32")]
        public uint length;

        [NativeTypeName("BOOL")]
        public byte present;

        [NativeTypeName("CARD8")]
        public byte major_opcode;

        [NativeTypeName("CARD8")]
        public byte first_event;

        [NativeTypeName("CARD8")]
        public byte first_error;

        [NativeTypeName("CARD32")]
        public uint pad3;

        [NativeTypeName("CARD32")]
        public uint pad4;

        [NativeTypeName("CARD32")]
        public uint pad5;

        [NativeTypeName("CARD32")]
        public uint pad6;

        [NativeTypeName("CARD32")]
        public uint pad7;
    }
}
