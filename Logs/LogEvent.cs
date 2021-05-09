using System;

namespace TetraConnector.Logs
{
    public abstract class LogEvent
    { 
        protected string PrefixTitle = "";
        protected string Message;

        protected ConsoleColor ForeColor = ConsoleColor.White;
        protected ConsoleColor BackgroundColor = ConsoleColor.Black;

        protected LogEvent(string message)
        {
            this.Message = message;
        }

    }
}
