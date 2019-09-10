namespace TerraFX.Interop
{
    public partial struct xGrabKeyReq
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
        public ushort modifiers;

        [NativeTypeName("CARD8")]
        public byte key;

        [NativeTypeName("BYTE")]
        public byte pointerMode;

        [NativeTypeName("BYTE")]
        public byte keyboardMode;

        [NativeTypeName("BYTE")]
        public byte pad1;

        [NativeTypeName("BYTE")]
        public byte pad2;

        [NativeTypeName("BYTE")]
        public byte pad3;
    }
}
