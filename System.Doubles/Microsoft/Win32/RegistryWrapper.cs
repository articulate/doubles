namespace Microsoft.Win32
{
    public sealed class RegistryWrapper : IRegistry
    {
        public object GetValue(string keyName, string valueName, object defaultValue)
        {
            return Registry.GetValue(keyName, valueName, defaultValue);
        }

        public void SetValue(string keyName, string valueName, object value)
        {
            Registry.SetValue(keyName, valueName, value);
        }

        public IRegistryKey OpenBaseKey(RegistryHive registryHive, RegistryView registryView)
        {
            return new RegistryKeyWrapper(RegistryKey.OpenBaseKey(registryHive, registryView));
        }
    }
}