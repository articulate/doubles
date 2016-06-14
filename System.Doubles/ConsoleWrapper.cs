using System.Windows.Forms;

namespace System
{
    public sealed class ConsoleWrapper : IConsole
    {
        public bool Attach()
        {
            return NativeMethods.AttachConsole(-1);
        }

        public void Release()
        {
            SendKeys.SendWait("{ENTER}");
            NativeMethods.FreeConsole();
        }

        public void WriteLine(object value)
        {
            Console.WriteLine(value);
        }
    }
}