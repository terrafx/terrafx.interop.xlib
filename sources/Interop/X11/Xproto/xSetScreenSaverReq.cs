namespace TerraFX.Interop
{
    public partial struct xSetScreenSaverReq
    {
        [NativeTypeName("CARD8")]
        public byte reqType;

        [NativeTypeName("BYTE")]
        public byte pad;

        [NativeTypeName("CARD16")]
        public ushort length;

        [NativeTypeName("INT16")]
        public short timeout;

        [NativeTypeName("INT16")]
        public short interval;

        [NativeTypeName("BYTE")]
        public byte preferBlank;

        [NativeTypeName("BYTE")]
        public byte allowExpose;

        [NativeTypeName("CARD16")]
        public ushort pad2;
    }
}
