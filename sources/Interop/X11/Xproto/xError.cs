namespace TerraFX.Interop
{
    public partial struct xError
    {
        [NativeTypeName("BYTE")]
        public byte type;

        [NativeTypeName("BYTE")]
        public byte errorCode;

        [NativeTypeName("CARD16")]
        public ushort sequenceNumber;

        [NativeTypeName("CARD32")]
        public uint resourceID;

        [NativeTypeName("CARD16")]
        public ushort minorCode;

        [NativeTypeName("CARD8")]
        public byte majorCode;

        [NativeTypeName("BYTE")]
        public byte pad1;

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
