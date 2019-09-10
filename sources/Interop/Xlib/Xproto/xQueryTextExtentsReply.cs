namespace TerraFX.Interop
{
    public partial struct xQueryTextExtentsReply
    {
        [NativeTypeName("BYTE")]
        public byte type;

        [NativeTypeName("CARD8")]
        public byte drawDirection;

        [NativeTypeName("CARD16")]
        public ushort sequenceNumber;

        [NativeTypeName("CARD32")]
        public uint length;

        [NativeTypeName("INT16")]
        public short fontAscent;

        [NativeTypeName("INT16")]
        public short fontDescent;

        [NativeTypeName("INT16")]
        public short overallAscent;

        [NativeTypeName("INT16")]
        public short overallDescent;

        [NativeTypeName("INT32")]
        public int overallWidth;

        [NativeTypeName("INT32")]
        public int overallLeft;

        [NativeTypeName("INT32")]
        public int overallRight;

        [NativeTypeName("CARD32")]
        public uint pad;
    }
}
