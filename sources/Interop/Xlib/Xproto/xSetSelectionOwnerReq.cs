namespace TerraFX.Interop
{
    public partial struct xSetSelectionOwnerReq
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
        public uint selection;

        [NativeTypeName("CARD32")]
        public uint time;
    }
}
