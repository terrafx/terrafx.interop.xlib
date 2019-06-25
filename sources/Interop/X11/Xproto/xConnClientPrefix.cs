namespace TerraFX.Interop
{
    public partial struct xConnClientPrefix
    {
        [NativeTypeName("CARD8")]
        public byte byteOrder;

        [NativeTypeName("BYTE")]
        public byte pad;

        [NativeTypeName("CARD16")]
        public ushort majorVersion;

        [NativeTypeName("CARD16")]
        public ushort minorVersion;

        [NativeTypeName("CARD16")]
        public ushort nbytesAuthProto;

        [NativeTypeName("CARD16")]
        public ushort nbytesAuthString;

        [NativeTypeName("CARD16")]
        public ushort pad2;
    }
}
