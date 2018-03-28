namespace System.Windows
{
    public interface IClipboard
    {
        void SetText(string text);

        void SetDataObject(object data, bool copy);
    }
}