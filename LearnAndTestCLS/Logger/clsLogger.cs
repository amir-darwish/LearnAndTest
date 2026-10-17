namespace LearnAndTestCLS.Logger
{

    public delegate void LogAction(string message);
    public class clsLogger
    {
        public delegate void LogAction(string message);
        private LogAction _logAction;
        public clsLogger(LogAction logAction)
        {
            _logAction = logAction;
        }
        public void Log(string message)
        {
            _logAction(message);
        }
    }
}
