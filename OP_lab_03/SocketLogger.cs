using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP_lab_03
{
    class SocketLogger : ClientSocket
    {
        private ClientSocket clientSocket;

        public SocketLogger(string host, int port) : base(host,port)
        {

        }

        ~SocketLogger()
        {
            this.Dispose(false);
        }
    }
}
