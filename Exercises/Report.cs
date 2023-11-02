using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Report
    {
        private string text { get; set; }
        private DateTime time { get; set; }
        private Person executor { get; set; }
        private bool approved { get; set; }
        public Report(string text, Person executor) 
        {
            this.text = text;
            time = DateTime.Now;
            this.executor = executor;
        }
        public bool Approve(Task task)
        {
            approved = true;
            return approved;
        }
        public DateTime GetTime()
        {
            return time;
        }

    }
}
