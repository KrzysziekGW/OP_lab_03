
using System;

namespace OP_lab_03.Logger
{
    class CommonLogger : ILogger
    {
        private ILogger[] loggers;

        public CommonLogger(ILogger[] loggers)
        {
            Console.WriteLine();
        }

        public void Log(params string[] messages) 
        {
            
        }
        public void Dispose()
        {

        }
    }
}
