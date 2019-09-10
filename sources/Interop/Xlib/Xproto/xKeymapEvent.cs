namespace TerraFX.Interop
{
    public unsafe partial struct xKeymapEvent
    {
        [NativeTypeName("BYTE")]
        public byte type;

        [NativeTypeName("BYTE [31]")]
        public fixed byte map[31];
    }
}
