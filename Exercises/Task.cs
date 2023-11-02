using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    enum TaskStatus
    {
        Appointed,
        InProgress,
        Test,
        Completed
    }
    internal class Task
    {
        private string description { get; set; }
        private DateTime deadline { get; set; }
        private Person customer { get; set; }
        private Person executor { get; set; }
        private TaskStatus status { get; set; }

        private List<Report> reports { get; set; }
        public Task(string description, DateTime deadline, Person customer, Person executor)
        {
            this.description = description;
            this.deadline = deadline;
            this.customer = customer;
            this.executor = executor;
            status = TaskStatus.Appointed;
            reports = new List<Report>();
        }
        public void StartTask()
        {
            status = TaskStatus.InProgress;
        }
        public void TestTask() 
        {
            status = TaskStatus.Test;
        }
        public void ClosedTask()
        {
            status = TaskStatus.Completed;
        }
        public TaskStatus GetStatus()
        {
            return status;
        }
        public void AddReport(Report report)
        {
            reports.Add(report);
        }
        public void RejectTask()
        {
            executor = null;
            status = TaskStatus.Appointed;
        }
    }
}
