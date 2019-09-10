namespace TerraFX.Interop
{
    public partial struct xSetModifierMappingReq
    {
        [NativeTypeName("CARD8")]
        public byte reqType;

        [NativeTypeName("CARD8")]
        public byte numKeyPerModifier;

        [NativeTypeName("CARD16")]
        public ushort length;
    }
}
