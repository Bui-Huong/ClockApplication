using System;
using System.Threading;

namespace ClockApplication.Events
{
    public class Clock
    {
        public int _hour;
        public int _minute;
        public int _second;
        public delegate void SecondChangeHandler(object clock, TimeInfoEventAgrs agrs);
        public event SecondChangeHandler SecondChange;
        protected void OnSecondChange(object clock, TimeInfoEventAgrs agrs)
        {
            if (SecondChange != null)
            {
                SecondChange(clock, agrs);
            }
        }
        public void Run()
        {
            for (; ; )
            {
                Thread.Sleep(1000);
                DateTime dateTimeNow = DateTime.Now;
                if (dateTimeNow.Second != _second)
                {
                    TimeInfoEventAgrs timeInfoEventAgrs = new TimeInfoEventAgrs(dateTimeNow.Hour, dateTimeNow.Minute, dateTimeNow.Second);
                    OnSecondChange(this, timeInfoEventAgrs);
                }

                this._hour = dateTimeNow.Hour;
                this._minute = dateTimeNow.Minute;
                this._second = dateTimeNow.Second;
            }
        }
    }
}