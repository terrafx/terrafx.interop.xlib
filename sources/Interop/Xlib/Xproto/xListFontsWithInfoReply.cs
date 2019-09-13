namespace TerraFX.Interop
{
    public partial struct xListFontsWithInfoReply
    {
        [NativeTypeName("BYTE")]
        public byte type;

        [NativeTypeName("CARD8")]
        public byte nameLength;

        [NativeTypeName("CARD16")]
        public ushort sequenceNumber;

        [NativeTypeName("CARD32")]
        public uint length;

        public xCharInfo minBounds;

        [NativeTypeName("CARD32")]
        public uint walign1;

        public xCharInfo maxBounds;

        [NativeTypeName("CARD32")]
        public uint walign2;

        [NativeTypeName("CARD16")]
        public ushort minCharOrByte2;

        [NativeTypeName("CARD16")]
        public ushort maxCharOrByte2;

        [NativeTypeName("CARD16")]
        public ushort defaultChar;

        [NativeTypeName("CARD16")]
        public ushort nFontProps;

        [NativeTypeName("CARD8")]
        public byte drawDirection;

        [NativeTypeName("CARD8")]
        public byte minByte1;

        [NativeTypeName("CARD8")]
        public byte maxByte1;

        [NativeTypeName("BOOL")]
        public byte allCharsExist;

        [NativeTypeName("INT16")]
        public short fontAscent;

        [NativeTypeName("INT16")]
        public short fontDescent;

        [NativeTypeName("CARD32")]
        public uint nReplies;
    }
}
