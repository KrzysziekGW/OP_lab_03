using System;

namespace OP_lab_03.Logger
{
    class ConsoleLogger : WriterLogger
    {
        public ConsoleLogger()
        {
            writer = Console.Out;
        }

        public void Dispose() {

        }

        
        
    }
}
