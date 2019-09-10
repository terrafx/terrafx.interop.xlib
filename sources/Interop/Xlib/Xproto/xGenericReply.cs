namespace TerraFX.Interop
{
    public partial struct xGenericReply
    {
        [NativeTypeName("BYTE")]
        public byte type;

        [NativeTypeName("BYTE")]
        public byte data1;

        [NativeTypeName("CARD16")]
        public ushort sequenceNumber;

        [NativeTypeName("CARD32")]
        public uint length;

        [NativeTypeName("CARD32")]
        public uint data00;

        [NativeTypeName("CARD32")]
        public uint data01;

        [NativeTypeName("CARD32")]
        public uint data02;

        [NativeTypeName("CARD32")]
        public uint data03;

        [NativeTypeName("CARD32")]
        public uint data04;

        [NativeTypeName("CARD32")]
        public uint data05;
    }
}
