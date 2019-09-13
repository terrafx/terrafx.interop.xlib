namespace TerraFX.Interop
{
    public partial struct xChangePointerControlReq
    {
        [NativeTypeName("CARD8")]
        public byte reqType;

        [NativeTypeName("BYTE")]
        public byte pad;

        [NativeTypeName("CARD16")]
        public ushort length;

        [NativeTypeName("INT16")]
        public short accelNum;

        [NativeTypeName("INT16")]
        public short accelDenum;

        [NativeTypeName("INT16")]
        public short threshold;

        [NativeTypeName("BOOL")]
        public byte doAccel;

        [NativeTypeName("BOOL")]
        public byte doThresh;
    }
}
