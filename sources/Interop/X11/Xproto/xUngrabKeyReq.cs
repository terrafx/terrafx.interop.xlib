namespace TerraFX.Interop
{
    public partial struct xUngrabKeyReq
    {
        [NativeTypeName("CARD8")]
        public byte reqType;

        [NativeTypeName("CARD8")]
        public byte key;

        [NativeTypeName("CARD16")]
        public ushort length;

        [NativeTypeName("CARD32")]
        public uint grabWindow;

        [NativeTypeName("CARD16")]
        public ushort modifiers;

        [NativeTypeName("CARD16")]
        public ushort pad;
    }
}
