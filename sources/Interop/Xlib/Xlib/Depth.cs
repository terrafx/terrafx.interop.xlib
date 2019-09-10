namespace TerraFX.Interop
{
    public unsafe partial struct Depth
    {
        public int depth;

        public int nvisuals;

        [NativeTypeName("Visual *")]
        public Visual* visuals;
    }
}
