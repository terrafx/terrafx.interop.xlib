namespace TerraFX.Interop
{
    public partial struct xSetClipRectanglesReq
    {
        [NativeTypeName("CARD8")]
        public byte reqType;

        [NativeTypeName("BYTE")]
        public byte ordering;

        [NativeTypeName("CARD16")]
        public ushort length;

        [NativeTypeName("CARD32")]
        public uint gc;

        [NativeTypeName("INT16")]
        public short xOrigin;

        [NativeTypeName("INT16")]
        public short yOrigin;
    }
}
