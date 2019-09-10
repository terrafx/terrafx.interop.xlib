namespace TerraFX.Interop
{
    public unsafe partial struct XOMCharSetList
    {
        public int charset_count;

        [NativeTypeName("char **")]
        public sbyte** charset_list;
    }
}
