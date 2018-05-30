using System.Collections.Generic;

namespace Microsoft.Win32
{
    internal sealed class RegistryKeyWrapper : IRegistryKey
    {
        private readonly RegistryKey registryKey;

        public RegistryKeyWrapper(RegistryKey registryKey)
        {
            this.registryKey = registryKey;
        }

        public void Dispose()
        {
            registryKey.Dispose();
        }

        public IEnumerable<string> GetSubKeyNames()
        {
            return registryKey.GetSubKeyNames();
        }

        public IRegistryKey OpenSubKey(string keyName)
        {
            var subKey = registryKey.OpenSubKey(keyName);
            return subKey == null ? null : new RegistryKeyWrapper(subKey);
        }

        public IRegistryKey OpenSubKey(string keyName, bool writeable)
        {
            var subKey = registryKey.OpenSubKey(keyName, writeable);
            return subKey == null ? null : new RegistryKeyWrapper(subKey);
        }

        public IRegistryKey CreateSubKey(string keyName)
        {
            var subKey = registryKey.CreateSubKey(keyName);
            return subKey == null ? null : new RegistryKeyWrapper(subKey);
        }

        public RegistryValueKind GetValueKind(string valueName)
        {
            return registryKey.GetValueKind(valueName);
        }

        public object GetValue(string valueName, object defaultValue)
        {
            return registryKey.GetValue(valueName, defaultValue);
        }

        public void SetValue(string valueName, object value, RegistryValueKind registryValueKind)
        {
            registryKey.SetValue(valueName, value, registryValueKind);
        }
    }
}