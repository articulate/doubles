using System;
using System.Collections.Generic;

namespace Microsoft.Win32
{
    public interface IRegistryKey : IDisposable
    {
        IEnumerable<string> GetSubKeyNames();

        IRegistryKey OpenSubKey(string keyName);

        RegistryValueKind GetValueKind(string valueName);

        object GetValue(string valueName, object defaultValue);

        void SetValue(string valueName, object value, RegistryValueKind registryValueKind);
    }
}