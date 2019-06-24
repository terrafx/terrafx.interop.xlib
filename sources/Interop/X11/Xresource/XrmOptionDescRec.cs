namespace TerraFX.Interop
{
    public unsafe partial struct XrmOptionDescRec
    {
        [NativeTypeName("char *")]
        public sbyte* option;

        [NativeTypeName("char *")]
        public sbyte* specifier;

        public XrmOptionKind argKind;

        [NativeTypeName("XPointer")]
        public sbyte* value;
    }
}
