namespace TerraFX.Interop
{
    public unsafe partial struct XwcTextItem
    {
        [NativeTypeName("wchar_t *")]
        public int* chars;

        public int nchars;

        public int delta;

        [NativeTypeName("XFontSet")]
        public XOC* font_set;
    }
}
