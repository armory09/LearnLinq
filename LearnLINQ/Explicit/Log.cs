using System;
using System.IO;

namespace LearnLINQ.Explicit
{
    class ConsoleLog : ILog
    {
        public void Log(string msgToLog)
        {
            Console.WriteLine(msgToLog);
        }
    }
    
    class Filelog : ILog
    {
        public void Log(string msgToLog)
        {
            File.AppendText(@"C:\Log.text").Write(msgToLog);
        }
    }

    class ConsoleLogExplicit : ILog
    {
        void ILog.Log(string msgToLog)
        {
            Console.WriteLine(msgToLog);
        }
    }
}
