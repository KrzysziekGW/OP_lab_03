using System;

namespace OP_lab_03.Logger
{
    public interface ILogger : IDisposable
    {     
        void Log(params String[] messages);
    }
}
