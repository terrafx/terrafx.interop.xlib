namespace TerraFX.Interop
{
    public partial struct xListHostsReply
    {
        [NativeTypeName("BYTE")]
        public byte type;

        [NativeTypeName("BOOL")]
        public byte enabled;

        [NativeTypeName("CARD16")]
        public ushort sequenceNumber;

        [NativeTypeName("CARD32")]
        public uint length;

        [NativeTypeName("CARD16")]
        public ushort nHosts;

        [NativeTypeName("CARD16")]
        public ushort pad1;

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
