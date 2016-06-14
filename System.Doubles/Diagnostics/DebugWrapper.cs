namespace System.Diagnostics
{
    public sealed class DebugWrapper : IDebug
    {
        public void Fail(string message)
        {
            Debug.Fail(message);
        }
    }
}