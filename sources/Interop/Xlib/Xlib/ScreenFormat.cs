namespace TerraFX.Interop
{
    public unsafe partial struct ScreenFormat
    {
        [NativeTypeName("XExtData *")]
        public XExtData* ext_data;

        public int depth;

        public int bits_per_pixel;

        public int scanline_pad;
    }
}
