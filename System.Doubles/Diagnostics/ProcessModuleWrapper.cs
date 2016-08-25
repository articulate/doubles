namespace System.Diagnostics
{
    internal sealed class ProcessModuleWrapper : IProcessModule
    {
        public string FileName => processModule.FileName;

        private readonly ProcessModule processModule;

        public ProcessModuleWrapper(ProcessModule processModule)
        {
            this.processModule = processModule;
        }
    }
}