namespace TerraFX.Interop
{
    public partial struct xPixmapFormat
    {
        [NativeTypeName("CARD8")]
        public byte depth;

        [NativeTypeName("CARD8")]
        public byte bitsPerPixel;

        [NativeTypeName("CARD8")]
        public byte scanLinePad;

        [NativeTypeName("CARD8")]
        public byte pad1;

        [NativeTypeName("CARD32")]
        public uint pad2;
    }
}
