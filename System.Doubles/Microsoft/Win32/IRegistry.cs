namespace Microsoft.Win32
{
    public interface IRegistry
    {
        object GetValue(string keyName, string valueName, object defaultValue);

        void SetValue(string keyName, string valueName, object value);

        IRegistryKey OpenBaseKey(RegistryHive registryHive, RegistryView registryView);
    }
}