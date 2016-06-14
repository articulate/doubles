namespace System.Runtime.Serialization
{
    public sealed class SerializationInfoWrapper : ISerializationInfo
    {
        private readonly SerializationInfo serializationInfo;

        public SerializationInfoWrapper(SerializationInfo serializationInfo)
        {
            this.serializationInfo = serializationInfo;
        }

        public object GetValue(string name, Type type)
        {
            return serializationInfo.GetValue(name, type);
        }

        public void AddValue(string name, object value)
        {
            serializationInfo.AddValue(name, value);
        }
    }
}