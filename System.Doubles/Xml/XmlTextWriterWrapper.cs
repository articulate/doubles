using System.IO;

namespace System.Xml
{
    public sealed class XmlTextWriterWrapper : XmlTextWriter, IXmlTextWriter
    {
        public XmlTextWriterWrapper(TextWriter textWriter)
            : base(textWriter)
        {
        }
    }
}
