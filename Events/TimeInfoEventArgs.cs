namespace ClockApplication
{
    public class TimeInfoEventAgrs
    {
        public readonly int hour;
        public readonly int minute;
        public readonly int second;
        public TimeInfoEventAgrs(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }
    }
}