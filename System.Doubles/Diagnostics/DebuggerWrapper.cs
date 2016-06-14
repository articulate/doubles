namespace System.Diagnostics
{
    public sealed class DebuggerWrapper : IDebugger
    {
        public bool IsAttached => Debugger.IsAttached;
    }
}