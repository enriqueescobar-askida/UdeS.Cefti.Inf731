namespace Common.Lab
{
    using System;

    public class EntryLog
    {
        public EntryLog(EntryLog entryLog)
        {
            this.Message = entryLog.Message;
            this.DateTime = entryLog.DateTime;
        }

        public EntryLog(DateTime timing, string message)
        {
            this.Message = message;
            this.DateTime = timing;
        }

        public DateTime DateTime { get; set; }

        public string Message { get; set; }

        public override string ToString()
        {
            return string.Format("{0} : {1}", this.DateTime, this.Message);
        }
    }
}
