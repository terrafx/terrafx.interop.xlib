namespace TerraFX.Interop
{
    public unsafe partial struct XrmValue
    {
        [NativeTypeName("unsigned int")]
        public uint size;

        [NativeTypeName("XPointer")]
        public sbyte* addr;
    }
}
