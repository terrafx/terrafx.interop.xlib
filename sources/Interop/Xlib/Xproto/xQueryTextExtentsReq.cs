namespace TerraFX.Interop
{
    public partial struct xQueryTextExtentsReq
    {
        [NativeTypeName("CARD8")]
        public byte reqType;

        [NativeTypeName("BOOL")]
        public byte oddLength;

        [NativeTypeName("CARD16")]
        public ushort length;

        [NativeTypeName("CARD32")]
        public uint fid;
    }
}
