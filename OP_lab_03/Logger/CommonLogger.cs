
using System;

namespace OP_lab_03.Logger
{
    class CommonLogger : ILogger
    {
        private ILogger loggers;

        public CommonLogger(ILogger loggers)
        {
            DateTime time = DateTime.Now;
            DateTime utcTime = DateTime.UtcNow;
            // when we want local time with offset
            Console.WriteLine(time.ToString("yyyy-MM-ddTHH:mm:sszzz"));   // 2020-07-28T08:40:39+00:00

            // when we want world global time
            Console.WriteLine(utcTime.ToString("yyyy-MM-ddTHH:mm:ssZ"));  // 2020-07-28T08:40:39Z
        }

        public void Log(params string[] messages) 
        {
            
        }
        public void Dispose()
        {

        }
    }
}
