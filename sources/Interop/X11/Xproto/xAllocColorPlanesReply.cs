namespace TerraFX.Interop
{
    public partial struct xAllocColorPlanesReply
    {
        [NativeTypeName("BYTE")]
        public byte type;

        [NativeTypeName("BYTE")]
        public byte pad1;

        [NativeTypeName("CARD16")]
        public ushort sequenceNumber;

        [NativeTypeName("CARD32")]
        public uint length;

        [NativeTypeName("CARD16")]
        public ushort nPixels;

        [NativeTypeName("CARD16")]
        public ushort pad2;

        [NativeTypeName("CARD32")]
        public uint redMask;

        [NativeTypeName("CARD32")]
        public uint greenMask;

        [NativeTypeName("CARD32")]
        public uint blueMask;

        [NativeTypeName("CARD32")]
        public uint pad3;

        [NativeTypeName("CARD32")]
        public uint pad4;
    }
}
