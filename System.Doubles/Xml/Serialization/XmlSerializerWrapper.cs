using System.IO;

namespace System.Xml.Serialization
{
    public sealed class XmlSerializerWrapper<T> : IXmlSerializer<T>
    {
        private readonly XmlSerializer xmlSerializer;

        public XmlSerializerWrapper(XmlSerializer xmlSerializer)
        {
            this.xmlSerializer = xmlSerializer;
        }

        public void Serialize(Stream stream, T value)
        {
            xmlSerializer.Serialize(stream, value);
        }

        public T Deserialize(Stream stream)
        {
            return (T) xmlSerializer.Deserialize(stream);
        }
    }
}