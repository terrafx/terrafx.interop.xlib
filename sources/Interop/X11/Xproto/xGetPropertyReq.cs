namespace TerraFX.Interop
{
    public partial struct xGetPropertyReq
    {
        [NativeTypeName("CARD8")]
        public byte reqType;

        [NativeTypeName("BOOL")]
        public byte c_delete;

        [NativeTypeName("CARD16")]
        public ushort length;

        [NativeTypeName("CARD32")]
        public uint window;

        [NativeTypeName("CARD32")]
        public uint property;

        [NativeTypeName("CARD32")]
        public uint type;

        [NativeTypeName("CARD32")]
        public uint longOffset;

        [NativeTypeName("CARD32")]
        public uint longLength;
    }
}
