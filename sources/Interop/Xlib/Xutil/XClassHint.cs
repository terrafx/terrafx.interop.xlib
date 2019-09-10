namespace TerraFX.Interop
{
    public unsafe partial struct XClassHint
    {
        [NativeTypeName("char *")]
        public sbyte* res_name;

        [NativeTypeName("char *")]
        public sbyte* res_class;
    }
}
