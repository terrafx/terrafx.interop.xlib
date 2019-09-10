namespace TerraFX.Interop
{
    public partial struct xHostEntry
    {
        [NativeTypeName("CARD8")]
        public byte family;

        [NativeTypeName("BYTE")]
        public byte pad;

        [NativeTypeName("CARD16")]
        public ushort length;
    }
}
