using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    interface ILogger : IDisposable
    {
        void Log(params string[] messages);
    }
}