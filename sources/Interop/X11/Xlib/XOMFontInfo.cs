namespace TerraFX.Interop
{
    public unsafe partial struct XOMFontInfo
    {
        public int num_font;

        [NativeTypeName("XFontStruct **")]
        public XFontStruct** font_struct_list;

        [NativeTypeName("char **")]
        public sbyte** font_name_list;
    }
}
