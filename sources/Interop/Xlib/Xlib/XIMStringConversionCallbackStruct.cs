namespace TerraFX.Interop
{
    public unsafe partial struct XIMStringConversionCallbackStruct
    {
        [NativeTypeName("XIMStringConversionPosition")]
        public ushort position;

        public XIMCaretDirection direction;

        [NativeTypeName("XIMStringConversionOperation")]
        public ushort operation;

        [NativeTypeName("unsigned short")]
        public ushort factor;

        [NativeTypeName("XIMStringConversionText *")]
        public XIMStringConversionText* text;
    }
}
