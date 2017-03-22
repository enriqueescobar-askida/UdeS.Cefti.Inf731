namespace Common.Lab
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class JournalLog
    {
        public List<EntryLog> EntryLogList { get; internal set; }
        public int Count { get; internal set; }

        public JournalLog()
        {
            this.EntryLogList = new List<EntryLog>();
        }

        protected EntryLog GetCopy(int index) => new EntryLog(this.EntryLogList.ElementAt(index));

        public void Publish(string message)
        {
            this.EntryLogList.Add(new EntryLog(DateTime.Now, message));
            this.Count = this.EntryLogList.Count;
        }
    }
}
