namespace TerraFX.Interop
{
    public unsafe partial struct xQueryKeymapReply
    {
        [NativeTypeName("BYTE")]
        public byte type;

        [NativeTypeName("BYTE")]
        public byte pad1;

        [NativeTypeName("CARD16")]
        public ushort sequenceNumber;

        [NativeTypeName("CARD32")]
        public uint length;

        [NativeTypeName("BYTE [32]")]
        public fixed byte map[32];
    }
}
