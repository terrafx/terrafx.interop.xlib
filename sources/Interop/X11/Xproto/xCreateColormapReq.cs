namespace TerraFX.Interop
{
    public partial struct xCreateColormapReq
    {
        [NativeTypeName("CARD8")]
        public byte reqType;

        [NativeTypeName("BYTE")]
        public byte alloc;

        [NativeTypeName("CARD16")]
        public ushort length;

        [NativeTypeName("CARD32")]
        public uint mid;

        [NativeTypeName("CARD32")]
        public uint window;

        [NativeTypeName("CARD32")]
        public uint visual;
    }
}
