namespace System
{
    public interface IConsole
    {
        bool Attach();

        void Release();

        void WriteLine(object value);
    }
}