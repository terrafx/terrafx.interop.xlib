namespace TerraFX.Interop
{
    public unsafe partial struct XHostAddress
    {
        public int family;

        public int length;

        [NativeTypeName("char *")]
        public sbyte* address;
    }
}
