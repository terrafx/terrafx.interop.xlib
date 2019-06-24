namespace TerraFX.Interop
{
    public partial struct xCopyAreaReq
    {
        [NativeTypeName("CARD8")]
        public byte reqType;

        [NativeTypeName("BYTE")]
        public byte pad;

        [NativeTypeName("CARD16")]
        public ushort length;

        [NativeTypeName("CARD32")]
        public uint srcDrawable;

        [NativeTypeName("CARD32")]
        public uint dstDrawable;

        [NativeTypeName("CARD32")]
        public uint gc;

        [NativeTypeName("INT16")]
        public short srcX;

        [NativeTypeName("INT16")]
        public short srcY;

        [NativeTypeName("INT16")]
        public short dstX;

        [NativeTypeName("INT16")]
        public short dstY;

        [NativeTypeName("CARD16")]
        public ushort width;

        [NativeTypeName("CARD16")]
        public ushort height;
    }
}
