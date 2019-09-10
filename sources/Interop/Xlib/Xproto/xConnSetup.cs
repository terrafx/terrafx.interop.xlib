namespace TerraFX.Interop
{
    public partial struct xConnSetup
    {
        [NativeTypeName("CARD32")]
        public uint release;

        [NativeTypeName("CARD32")]
        public uint ridBase;

        [NativeTypeName("CARD32")]
        public uint ridMask;

        [NativeTypeName("CARD32")]
        public uint motionBufferSize;

        [NativeTypeName("CARD16")]
        public ushort nbytesVendor;

        [NativeTypeName("CARD16")]
        public ushort maxRequestSize;

        [NativeTypeName("CARD8")]
        public byte numRoots;

        [NativeTypeName("CARD8")]
        public byte numFormats;

        [NativeTypeName("CARD8")]
        public byte imageByteOrder;

        [NativeTypeName("CARD8")]
        public byte bitmapBitOrder;

        [NativeTypeName("CARD8")]
        public byte bitmapScanlineUnit;

        [NativeTypeName("CARD8")]
        public byte bitmapScanlinePad;

        [NativeTypeName("CARD8")]
        public byte minKeyCode;

        [NativeTypeName("CARD8")]
        public byte maxKeyCode;

        [NativeTypeName("CARD32")]
        public uint pad2;
    }
}
