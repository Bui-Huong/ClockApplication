using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClockApplication.Events;
using System.IO;

namespace ClockApplication.Business
{
    public class LogClockToFile
    {
        public void Subcrise(Clock clock)
        {
            clock.SecondChange += new Clock.SecondChangeHandler(WriteToFile);
        }
        public void WriteToFile(object clock, TimeInfoEventAgrs timeInfo)
        {
            string outputString = "Time: " + timeInfo.minute + ":" + timeInfo.second;
            using (FileStream stream = File.Open("C://text//logStreamWriter.txt", FileMode.OpenOrCreate))
            {
                byte[] bytes = new System.Text.UTF8Encoding(true).GetBytes(outputString);
                stream.Write(bytes, 0, bytes.Length);
            }
            using (StreamWriter writer = new StreamWriter("C://text//logStreamWriter.txt", true))
            {
                writer.WriteLine(outputString);
            }

        }
    }
}