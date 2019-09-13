namespace TerraFX.Interop
{
    public partial struct xGrabButtonReq
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

        [NativeTypeName("CARD8")]
        public byte button;

        [NativeTypeName("BYTE")]
        public byte pad;

        [NativeTypeName("CARD16")]
        public ushort modifiers;
    }
}
