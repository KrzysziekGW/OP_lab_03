using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP_lab_03
{
    public interface ILogger : IDisposable
    {
        void Log(params String[] messages);
    }
}
