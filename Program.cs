using System;
using ClockApplication.Business;
using ClockApplication.Events;

namespace ClockApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            DisplayClock view = new DisplayClock();
            view.Subcrise(clock);
            LogClockToFile log = new LogClockToFile();
            log.Subcrise(clock);
            clock.Run();
        }
    }
}
