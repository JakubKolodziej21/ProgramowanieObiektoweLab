using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab_3.Logger
{
    public abstract class WriterLogger : ILogger
    {
        protected TextWriter writer;

        public virtual void Log(params string[] messages)
        {
            // Uzupełnić to miejsce o logikę zapisu opartą o TextWriter ...
        }

        public abstract void Dispose();
    }
}