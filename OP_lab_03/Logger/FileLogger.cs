using System;
using System.IO;
using System.Text;

namespace OP_lab_03.Logger
{
    class FileLogger : WriterLogger,IDisposable
    {
        bool disposed;
        protected FileStream stream;

        public FileLogger(String path)
        {
            path = @"F:\path\to\file.txt";
            stream = new FileStream(path, FileMode.Append);
            writer = new StreamWriter(stream, Encoding.UTF8);
        }
        ~FileLogger()
        {
            this.Dispose(false);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                    this.stream.Dispose();

                this.disposed = true;
            }
        }
        public void Dispose()
        {
            this.Dispose(disposing: true);

            GC.SuppressFinalize(this);
        }
    }
}
