namespace System.Xml
{
    public interface IXmlTextWriter
    {
        void WriteStartDocument();

        void WriteStartElement(string localName);

        void WriteAttributeString(string localName, string value);

        void WriteAttributeString(string localName, string ns, string value);

        void WriteAttributeString(string prefix, string localName, string ns, string value);

        void WriteRaw(string data);

        void WriteEndElement();

        void WriteEndDocument();

        void Close();

        void Flush();
    }
}