namespace System.Windows.Forms
{
    public sealed class ClipboardWrapper : IClipboard
    {
        public IDataObject GetDataObject()
        {
            return Clipboard.GetDataObject();
        }
    }
}