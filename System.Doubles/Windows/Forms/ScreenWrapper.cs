namespace System.Windows.Forms
{
    public sealed class ScreenWrapper : IScreen
    {
        public Screen FromPoint(Drawing.Point point)
        {
            return Screen.FromPoint(point);
        }
    }
}