namespace System
{
    public interface IDateTimeOffset
    {
        DateTimeOffset Now
        {
            get;
        }

        DateTimeOffset UtcNow
        {
            get;
        }
    }
}
