using System;

namespace OP_lab_03.Logger
{
    class SocketLogger : ClientSocket, IDisposable, ILogger
    {
        private ClientSocket clientSocket;

        public SocketLogger(string host, int port) : base(host,port)
        {
            
        }

        ~SocketLogger()
        {
            this.Dispose(false);
        }
        public void Log(params string[] messages) {

        }
        public new void Dispose()
        {
            
        }                              
    }
}
