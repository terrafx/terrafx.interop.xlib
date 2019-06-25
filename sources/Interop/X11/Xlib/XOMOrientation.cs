namespace TerraFX.Interop
{
    public unsafe partial struct XOMOrientation
    {
        public int num_orientation;

        [NativeTypeName("XOrientation *")]
        public XOrientation* orientation;
    }
}
