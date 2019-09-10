namespace TerraFX.Interop
{
    public unsafe partial struct XmbTextItem
    {
        [NativeTypeName("char *")]
        public sbyte* chars;

        public int nchars;

        public int delta;

        [NativeTypeName("XFontSet")]
        public XOC* font_set;
    }
}
