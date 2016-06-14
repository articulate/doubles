namespace System.Diagnostics
{
    public interface IEventLogEntry
    {
        long InstanceId
        {
            get;
        }

        string Message
        {
            get;
        }
    }
}