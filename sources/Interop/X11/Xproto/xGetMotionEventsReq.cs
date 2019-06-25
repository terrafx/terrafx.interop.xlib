namespace TerraFX.Interop
{
    public partial struct xGetMotionEventsReq
    {
        [NativeTypeName("CARD8")]
        public byte reqType;

        [NativeTypeName("BYTE")]
        public byte pad;

        [NativeTypeName("CARD16")]
        public ushort length;

        [NativeTypeName("CARD32")]
        public uint window;

        [NativeTypeName("CARD32")]
        public uint start;

        [NativeTypeName("CARD32")]
        public uint stop;
    }
}
