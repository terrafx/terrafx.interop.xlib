namespace TerraFX.Interop
{
    public partial struct xCharInfo
    {
        [NativeTypeName("INT16")]
        public short leftSideBearing;

        [NativeTypeName("INT16")]
        public short rightSideBearing;

        [NativeTypeName("INT16")]
        public short characterWidth;

        [NativeTypeName("INT16")]
        public short ascent;

        [NativeTypeName("INT16")]
        public short descent;

        [NativeTypeName("CARD16")]
        public ushort attributes;
    }
}
