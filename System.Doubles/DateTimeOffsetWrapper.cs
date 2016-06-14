namespace System
{
    public sealed class DateTimeOffsetWrapper : IDateTimeOffset
    {
        public DateTimeOffset Now => DateTimeOffset.Now;

        public DateTimeOffset UtcNow => DateTimeOffset.UtcNow;
    }
}
