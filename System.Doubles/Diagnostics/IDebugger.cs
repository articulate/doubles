namespace System.Diagnostics
{
    public interface IDebugger
    {
        bool IsAttached
        {
            get;
        }
    }
}