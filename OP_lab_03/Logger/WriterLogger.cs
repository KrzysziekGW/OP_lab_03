using System;
using System.Text;
using System.IO;

namespace OP_lab_03.Logger
{
      abstract public class WriterLogger : ILogger,IDisposable
    {
        protected TextWriter writer;
        public void Log(params string[] messages)
        {            
    
        }

        abstract public void Dispose();
    }
}
