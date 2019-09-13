namespace TerraFX.Interop
{
    public partial struct xRecolorCursorReq
    {
        [NativeTypeName("CARD8")]
        public byte reqType;

        [NativeTypeName("BYTE")]
        public byte pad;

        [NativeTypeName("CARD16")]
        public ushort length;

        [NativeTypeName("CARD32")]
        public uint cursor;

        [NativeTypeName("CARD16")]
        public ushort foreRed;

        [NativeTypeName("CARD16")]
        public ushort foreGreen;

        [NativeTypeName("CARD16")]
        public ushort foreBlue;

        [NativeTypeName("CARD16")]
        public ushort backRed;

        [NativeTypeName("CARD16")]
        public ushort backGreen;

        [NativeTypeName("CARD16")]
        public ushort backBlue;
    }
}
