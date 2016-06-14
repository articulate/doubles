namespace System.Windows
{
    public sealed class ClipboardWrapper : IClipboard
    {
        public void SetText(string text)
        {
            Clipboard.SetText(text);
        }
    }
}