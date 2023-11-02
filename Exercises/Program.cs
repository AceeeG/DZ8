using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercises
{
    internal class Program
    {
        static bool ApproveReport(Report report, Task task)
        {
            if (report.Approve(task))
            {
                Console.WriteLine("Отчет утвержден\n");
                task.ClosedTask();
                return true;
            }
            else
            {
                Console.WriteLine("На доработку\n");
                return false;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя\n");
            string name = Console.ReadLine();
            Person customer = new Person(name, Position.Customer);
            Person team_leader = new Person("Вася", Position.TeamLeader);
            Person senior = new Person("3Hunna", Position.Senior);
            Person senior1 = new Person("2Hunna", Position.Senior);
            Person middle = new Person("ChiefKeef", Position.Midlle);
            Person middle1 = new Person("KeefChief", Position.Midlle);
            Person middle2 = new Person("BigBallz", Position.Midlle);
            Person junior = new Person("Леха", Position.Junior);
            Person junior1 = new Person("Леха1", Position.Junior);
            Person junior2 = new Person("Леха2", Position.Junior);
            Person junior3 = new Person("Леха3", Position.Junior);

            List<Project> projects = new List<Project>();

            Console.WriteLine("Наша команда предоставляет следующие услуги:\n" +
                "Нажмите на цифру проекта, который хотите заказать\n" +
                "1. Создание приложений на мобильные платформы.\n" +
                "2. Создание веб - сайта.\n" +
                "3. Создание игр на Windows.\n" +
                "4. Выход.\n");
            byte choise;
            do
            {
                bool choise_flag = byte.TryParse(Console.ReadLine(), out choise);
                if (!choise_flag || (choise < 1 || choise > 4))
                {
                    do
                    {
                        Console.WriteLine("Нет такого выбора, сделайте выбор повторно");
                        choise_flag = byte.TryParse(Console.ReadLine(), out choise);
                    } while (!choise_flag);
                }
                switch (choise)
                {
                    case 1:
                        List<Task> task_list = new List<Task>();
                        Project project1 = new Project("Сделать мобильную игру", new DateTime(2023, 12, 20), customer, team_leader);
                        projects.Add(project1);
                        Task task1 = new Task("Сделать локации", new DateTime(2023, 11, 20), customer, ReportFrequency.Daily);
                        Task task2 = new Task("Создать персонажей", new DateTime(2023, 11, 22), customer, ReportFrequency.Daily);
                        Task task3 = new Task("Создать музыку", new DateTime(2023, 11, 24), customer, ReportFrequency.Daily);
                        Task task4 = new Task("Придумать лор", new DateTime(2023, 11, 25), customer, ReportFrequency.Daily);
                        Task task5 = new Task("Сделать физику", new DateTime(2023, 11, 28), customer, ReportFrequency.Weekly);
                        Task task6 = new Task("Придумать сюжет", new DateTime(2023, 11, 20), customer, ReportFrequency.Daily);
                        Task task7 = new Task("Отрисовать кат-сцены", new DateTime(2023, 12, 10), customer, ReportFrequency.Weekly);
                        Task task8 = new Task("Придумать персонажей", new DateTime(2023, 11, 25), customer, ReportFrequency.Weekly);
                        Task task9 = new Task("Создать скрипты", new DateTime(2023, 12, 5), customer, ReportFrequency.Weekly);
                        Task task10 = new Task("Протестировать", new DateTime(2023, 12, 15), customer, ReportFrequency.Monthly);


                        project1.AddTask(task1);
                        junior.AddTask(task1);
                        project1.AddTask(task2);
                        junior1.AddTask(task2);
                        project1.AddTask(task3);
                        junior2.AddTask(task3);
                        project1.AddTask(task4);
                        junior3.AddTask(task4);
                        project1.AddTask(task5);
                        middle.AddTask(task5);
                        project1.AddTask(task6);
                        middle1.AddTask(task6);
                        project1.AddTask(task7);
                        middle2.AddTask(task7);
                        project1.AddTask(task8);
                        senior.AddTask(task9);
                        project1.AddTask(task9);
                        senior1.AddTask(task9);
                        project1.AddTask(task10);
                        team_leader.AddTask(task10);

                        project1.StartProject();
                        task1.StartTask(junior);
                        task2.StartTask(junior1);
                        task3.StartTask(junior2);
                        task4.StartTask(junior3);
                        task5.StartTask(middle);
                        task6.StartTask(middle1);
                        task7.StartTask(middle2);
                        task8.StartTask(senior);
                        task9.StartTask(senior1);
                        task10.StartTask(team_leader);

                        Report report1 = new Report("Отчет по задаче 1", junior);
                        Report report2 = new Report("Отчет по задаче 2", junior1);
                        Report report3 = new Report("Отчет по задаче 3", junior2);
                        Report report4 = new Report("Отчет по задаче 4", junior3);
                        Report report5 = new Report("Отчет по задаче 5", middle);
                        Report report6 = new Report("Отчет по задаче 6", middle1);
                        Report report7 = new Report("Отчет по задаче 7", middle2);
                        Report report8 = new Report("Отчет по задаче 8", senior);
                        Report report9 = new Report("Отчет по задаче 9", senior1);
                        Report report10 = new Report("Отчет по задаче 10", team_leader);

                        task1.AddReport(report1);
                        task2.AddReport(report2);
                        task3.AddReport(report3);
                        task4.AddReport(report4);
                        task5.AddReport(report5);
                        task6.AddReport(report6);
                        task7.AddReport(report7);
                        task8.AddReport(report8);
                        task9.AddReport(report9);
                        task10.AddReport(report10);

                        task1.TestTask();
                        task2.TestTask();
                        task3.TestTask();
                        task4.TestTask();
                        task5.TestTask();
                        task6.TestTask();
                        task7.TestTask();
                        task8.TestTask();
                        task9.TestTask();
                        task10.TestTask();

                        ApproveReport(report1, task1);
                        ApproveReport(report2, task2);
                        ApproveReport(report3, task3);
                        ApproveReport(report4, task4);
                        ApproveReport(report5, task5);
                        ApproveReport(report6, task6);
                        ApproveReport(report7, task7);
                        ApproveReport(report8, task8);
                        ApproveReport(report9, task9);
                        ApproveReport(report10, task10);

                        




                    break;

                    case 2:

                        break;

                }


            } while (choise != 4);
            


        }
    }
}
