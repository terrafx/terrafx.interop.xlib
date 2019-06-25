namespace TerraFX.Interop
{
    public partial struct xSetInputFocusReq
    {
        [NativeTypeName("CARD8")]
        public byte reqType;

        [NativeTypeName("CARD8")]
        public byte revertTo;

        [NativeTypeName("CARD16")]
        public ushort length;

        [NativeTypeName("CARD32")]
        public uint focus;

        [NativeTypeName("CARD32")]
        public uint time;
    }
}
