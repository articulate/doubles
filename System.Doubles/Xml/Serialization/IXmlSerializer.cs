using System.IO;

namespace System.Xml.Serialization
{
    public interface IXmlSerializer<T>
    {
        void Serialize(Stream stream, T value);

        T Deserialize(Stream stream);
    }
}