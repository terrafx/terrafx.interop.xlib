namespace TerraFX.Interop
{
    public unsafe partial struct XIMHotKeyTriggers
    {
        public int num_hot_key;

        [NativeTypeName("XIMHotKeyTrigger *")]
        public XIMHotKeyTrigger* key;
    }
}
