using System;
using System.IO;
using System.Text;

namespace OP_lab_03.Logger
{
    class FileLogger : IDisposable
    {
        bool disposed { get; set; }
        protected FileStream stream { get; set; }

        public FileLogger(String path)
        {
            
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
