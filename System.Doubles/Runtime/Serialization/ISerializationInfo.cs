namespace System.Runtime.Serialization
{
    public interface ISerializationInfo
    {
        object GetValue(string name, Type type);

        void AddValue(string name, object value);
    }
}