namespace TerraFX.Interop
{
    public partial struct xGetWindowAttributesReply
    {
        [NativeTypeName("BYTE")]
        public byte type;

        [NativeTypeName("CARD8")]
        public byte backingStore;

        [NativeTypeName("CARD16")]
        public ushort sequenceNumber;

        [NativeTypeName("CARD32")]
        public uint length;

        [NativeTypeName("CARD32")]
        public uint visualID;

        [NativeTypeName("CARD16")]
        public ushort c_class;

        [NativeTypeName("CARD8")]
        public byte bitGravity;

        [NativeTypeName("CARD8")]
        public byte winGravity;

        [NativeTypeName("CARD32")]
        public uint backingBitPlanes;

        [NativeTypeName("CARD32")]
        public uint backingPixel;

        [NativeTypeName("BOOL")]
        public byte saveUnder;

        [NativeTypeName("BOOL")]
        public byte mapInstalled;

        [NativeTypeName("CARD8")]
        public byte mapState;

        [NativeTypeName("BOOL")]
        public byte @override;

        [NativeTypeName("CARD32")]
        public uint colormap;

        [NativeTypeName("CARD32")]
        public uint allEventMasks;

        [NativeTypeName("CARD32")]
        public uint yourEventMask;

        [NativeTypeName("CARD16")]
        public ushort doNotPropagateMask;

        [NativeTypeName("CARD16")]
        public ushort pad;
    }
}
