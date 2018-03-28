namespace System.Windows
{
    public sealed class ClipboardWrapper : IClipboard
    {
        public void SetText(string text)
        {
            Clipboard.SetText(text);
        }

        public void SetDataObject(object data, bool copy)
        {
            Clipboard.SetDataObject(data, copy);
        }
    }
}