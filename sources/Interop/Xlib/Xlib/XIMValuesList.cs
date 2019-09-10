namespace TerraFX.Interop
{
    public unsafe partial struct XIMValuesList
    {
        [NativeTypeName("unsigned short")]
        public ushort count_values;

        [NativeTypeName("char **")]
        public sbyte** supported_values;
    }
}
