namespace TerraFX.Interop
{
    public unsafe partial struct XComposeStatus
    {
        [NativeTypeName("XPointer")]
        public sbyte* compose_ptr;

        public int chars_matched;
    }
}
