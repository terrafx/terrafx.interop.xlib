namespace TerraFX.Interop
{
    public partial struct xSendEventReq
    {
        [NativeTypeName("CARD8")]
        public byte reqType;

        [NativeTypeName("BOOL")]
        public byte propagate;

        [NativeTypeName("CARD16")]
        public ushort length;

        [NativeTypeName("CARD32")]
        public uint destination;

        [NativeTypeName("CARD32")]
        public uint eventMask;

        [NativeTypeName("xEvent")]
        public xEvent @event;
    }
}
