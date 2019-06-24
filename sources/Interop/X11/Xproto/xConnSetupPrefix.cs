namespace TerraFX.Interop
{
    public partial struct xConnSetupPrefix
    {
        [NativeTypeName("CARD8")]
        public byte success;

        [NativeTypeName("BYTE")]
        public byte lengthReason;

        [NativeTypeName("CARD16")]
        public ushort majorVersion;

        [NativeTypeName("CARD16")]
        public ushort minorVersion;

        [NativeTypeName("CARD16")]
        public ushort length;
    }
}
