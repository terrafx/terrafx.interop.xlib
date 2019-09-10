namespace TerraFX.Interop
{
    public unsafe partial struct XIMPreeditDrawCallbackStruct
    {
        public int caret;

        public int chg_first;

        public int chg_length;

        [NativeTypeName("XIMText *")]
        public XIMText* text;
    }
}
