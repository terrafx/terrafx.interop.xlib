namespace TerraFX.Interop
{
    public partial struct xConvertSelectionReq
    {
        [NativeTypeName("CARD8")]
        public byte reqType;

        [NativeTypeName("BYTE")]
        public byte pad;

        [NativeTypeName("CARD16")]
        public ushort length;

        [NativeTypeName("CARD32")]
        public uint requestor;

        [NativeTypeName("CARD32")]
        public uint selection;

        [NativeTypeName("CARD32")]
        public uint target;

        [NativeTypeName("CARD32")]
        public uint property;

        [NativeTypeName("CARD32")]
        public uint time;
    }
}
