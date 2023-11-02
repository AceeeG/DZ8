using System;
using System.Collections.Generic;
using System.Linq;


namespace Exercises
{
    enum ReportFrequency
    {
        Daily,
        Weekly,
        Monthly
    }
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
        public ReportFrequency report_frequency { get; set; }

        private List<Report> reports { get; set; }
        public Task(string description, DateTime deadline, Person customer, ReportFrequency report_frequency)
        {
            this.description = description;
            this.deadline = deadline;
            this.customer = customer;
            status = TaskStatus.Appointed;
            reports = new List<Report>();
            this.report_frequency = report_frequency;
        }
        public void StartTask(Person executor)
        {
            status = TaskStatus.InProgress;
            this.executor = executor;
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
        public void DelegateTask(Person executor)
        {
            if (status == TaskStatus.Appointed)
            {
                this.executor = executor;
            }
        }
        public void RejectTask()
        {
            executor = null;
            status = TaskStatus.Appointed;
        }
        public void GenerateReports()
        {
            if (status == TaskStatus.InProgress)
            {
                DateTime today = DateTime.Today;

                if (report_frequency == ReportFrequency.Daily)
                {
                    if (!reports.Any(report => report.GetTime() == today))
                    {
                        Report daily_report = new Report("Дневной отчет", executor);
                        AddReport(daily_report);
                    }
                }
                else if (report_frequency == ReportFrequency.Weekly)
                {
                    if (today.DayOfWeek == DayOfWeek.Monday && !reports.Any(report => report.GetTime().Date >= today.AddDays(-7)))
                    {
                        new Report("Недельный отчет", executor);
                    }
                }
                else if (report_frequency == ReportFrequency.Monthly)
                {
                    if (today.Day == 1 && !reports.Any(report => report.GetTime().Date >= today.AddMonths(-1)))
                    {
                       Report monthly_report = new Report("Месячный отчёт", executor);
                       AddReport(monthly_report);
                    }
                }
            }
        }
    }
}
