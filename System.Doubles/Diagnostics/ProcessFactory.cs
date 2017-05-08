using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace System.Diagnostics
{
    public sealed class ProcessFactory : IProcessFactory
    {
        public IEnumerable<IProcess> Get(string filePath)
        {
            return Process.GetProcessesByName(Path.GetFileNameWithoutExtension(filePath)).Select(process => new ProcessWrapper(process)).ToList();
        }

        public IProcess Create(ProcessStartInfo processStartInfo)
        {
            return new ProcessWrapper(new Process {StartInfo = processStartInfo});
        }

        public IProcess GetByProcessId(int processId)
        {
            return new ProcessWrapper(Process.GetProcessById(processId));
        }
    }
}