using System.Collections.Generic;

namespace System.Diagnostics
{
    public interface IProcessFactory
    {
        IEnumerable<IProcess> Get(string filePath);

        IProcess Create(ProcessStartInfo processStartInfo);

        IProcess GetByProcessId(int processid);
    }
}