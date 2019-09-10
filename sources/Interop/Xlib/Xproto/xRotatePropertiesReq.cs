namespace TerraFX.Interop
{
    public partial struct xRotatePropertiesReq
    {
        [NativeTypeName("CARD8")]
        public byte reqType;

        [NativeTypeName("BYTE")]
        public byte pad;

        [NativeTypeName("CARD16")]
        public ushort length;

        [NativeTypeName("CARD32")]
        public uint window;

        [NativeTypeName("CARD16")]
        public ushort nAtoms;

        [NativeTypeName("INT16")]
        public short nPositions;
    }
}
