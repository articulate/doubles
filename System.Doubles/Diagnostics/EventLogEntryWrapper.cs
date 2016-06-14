namespace System.Diagnostics
{
    public sealed class EventLogEntryWrapper : IEventLogEntry
    {
        public long InstanceId => eventLogEntry.InstanceId;

        public string Message => eventLogEntry.Message;

        private readonly EventLogEntry eventLogEntry;

        public EventLogEntryWrapper(EventLogEntry eventLogEntry)
        {
            this.eventLogEntry = eventLogEntry;
        }
    }
}