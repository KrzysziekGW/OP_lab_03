using System;
using System.Text;
using System.IO;

namespace OP_lab_03.Logger
{
    public abstract class WriterLogger : ILogger,IDisposable
    {
        protected TextWriter writer { get; set; }
        public void Log(params string[] messages)
        {
            

            
            {
                FileStream stream = new FileStream("file.txt", FileMode.Append);

                writer = new StreamWriter(stream, Encoding.UTF8);

                // stream and writer should be closed and destroyed when not needed, eg.
                //
                //     writer.Close();   stream.Close();
                //     writer.Dispose(); stream.Dispose();
            }

            // when we want to write text into console:
            {
                writer = Console.Out;

                // writer is not created by programmer so we should not close or destroy it
            }
        }

        public abstract void Dispose();
    }
}
