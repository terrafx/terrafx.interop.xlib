namespace TerraFX.Interop
{
    public unsafe partial struct xGetKeyboardControlReply
    {
        [NativeTypeName("BYTE")]
        public byte type;

        [NativeTypeName("BOOL")]
        public byte globalAutoRepeat;

        [NativeTypeName("CARD16")]
        public ushort sequenceNumber;

        [NativeTypeName("CARD32")]
        public uint length;

        [NativeTypeName("CARD32")]
        public uint ledMask;

        [NativeTypeName("CARD8")]
        public byte keyClickPercent;

        [NativeTypeName("CARD8")]
        public byte bellPercent;

        [NativeTypeName("CARD16")]
        public ushort bellPitch;

        [NativeTypeName("CARD16")]
        public ushort bellDuration;

        [NativeTypeName("CARD16")]
        public ushort pad;

        [NativeTypeName("BYTE [32]")]
        public fixed byte map[32];
    }
}
