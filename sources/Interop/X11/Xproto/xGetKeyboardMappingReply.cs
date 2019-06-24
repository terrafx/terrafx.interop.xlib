namespace TerraFX.Interop
{
    public partial struct xGetKeyboardMappingReply
    {
        [NativeTypeName("BYTE")]
        public byte type;

        [NativeTypeName("CARD8")]
        public byte keySymsPerKeyCode;

        [NativeTypeName("CARD16")]
        public ushort sequenceNumber;

        [NativeTypeName("CARD32")]
        public uint length;

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

        [NativeTypeName("CARD32")]
        public uint pad7;
    }
}
