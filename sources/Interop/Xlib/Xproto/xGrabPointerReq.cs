namespace TerraFX.Interop
{
    public partial struct xGrabPointerReq
    {
        [NativeTypeName("CARD8")]
        public byte reqType;

        [NativeTypeName("BOOL")]
        public byte ownerEvents;

        [NativeTypeName("CARD16")]
        public ushort length;

        [NativeTypeName("CARD32")]
        public uint grabWindow;

        [NativeTypeName("CARD16")]
        public ushort eventMask;

        [NativeTypeName("BYTE")]
        public byte pointerMode;

        [NativeTypeName("BYTE")]
        public byte keyboardMode;

        [NativeTypeName("CARD32")]
        public uint confineTo;

        [NativeTypeName("CARD32")]
        public uint cursor;

        [NativeTypeName("CARD32")]
        public uint time;
    }
}
