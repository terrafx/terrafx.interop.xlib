namespace TerraFX.Interop
{
    public partial struct xWarpPointerReq
    {
        [NativeTypeName("CARD8")]
        public byte reqType;

        [NativeTypeName("BYTE")]
        public byte pad;

        [NativeTypeName("CARD16")]
        public ushort length;

        [NativeTypeName("CARD32")]
        public uint srcWid;

        [NativeTypeName("CARD32")]
        public uint dstWid;

        [NativeTypeName("INT16")]
        public short srcX;

        [NativeTypeName("INT16")]
        public short srcY;

        [NativeTypeName("CARD16")]
        public ushort srcWidth;

        [NativeTypeName("CARD16")]
        public ushort srcHeight;

        [NativeTypeName("INT16")]
        public short dstX;

        [NativeTypeName("INT16")]
        public short dstY;
    }
}
