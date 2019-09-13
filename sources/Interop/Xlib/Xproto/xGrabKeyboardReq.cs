namespace TerraFX.Interop
{
    public partial struct xGrabKeyboardReq
    {
        [NativeTypeName("CARD8")]
        public byte reqType;

        [NativeTypeName("BOOL")]
        public byte ownerEvents;

        [NativeTypeName("CARD16")]
        public ushort length;

        [NativeTypeName("CARD32")]
        public uint grabWindow;

        [NativeTypeName("CARD32")]
        public uint time;

        [NativeTypeName("BYTE")]
        public byte pointerMode;

        [NativeTypeName("BYTE")]
        public byte keyboardMode;

        [NativeTypeName("CARD16")]
        public ushort pad;
    }
}
