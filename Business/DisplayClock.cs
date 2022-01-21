using System;
using ClockApplication.Events;

namespace ClockApplication.Business
{
    public class DisplayClock
    {
        public void Subcrise(Clock clock)
        {
            clock.SecondChange += new Clock.SecondChangeHandler(TimeHasChanged);
        }

        private void TimeHasChanged(object clock, TimeInfoEventAgrs agrs)
        {
            Console.WriteLine("{0} {1} {2}", agrs.hour, agrs.minute, agrs.second);
        }
    }
}