namespace TerraFX.Interop
{
    public partial struct xVisualType
    {
        [NativeTypeName("CARD32")]
        public uint visualID;

        [NativeTypeName("CARD8")]
        public byte c_class;

        [NativeTypeName("CARD8")]
        public byte bitsPerRGB;

        [NativeTypeName("CARD16")]
        public ushort colormapEntries;

        [NativeTypeName("CARD32")]
        public uint redMask;

        [NativeTypeName("CARD32")]
        public uint greenMask;

        [NativeTypeName("CARD32")]
        public uint blueMask;

        [NativeTypeName("CARD32")]
        public uint pad;
    }
}
