﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    abstract class WritterLogger : ILogger
    {
        protected TextWriter writer;

        public virtual void Log(params string[] messages)
        {

        }

        public abstract void Dispose();
    }
}