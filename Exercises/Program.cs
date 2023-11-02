using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercises
{
    internal class Program
    {
        static bool ApproveReport(Report report)
        {
            if (report.Approve())
            {
                Console.WriteLine("Отчет утвержден\n");
                return true;
            }
            else
            {
                Console.WriteLine("На доработку\n");
                return false;
            }
        }

        static void MakeMobileApp(string name)
        {
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя\n");
            string name = Console.ReadLine();
            Person customer = new Person(name, Position.Customer);
            Person team_leader = new Person("Вася", Position.TeamLeader);
            Person senior = new Person("3Hunna", Position.Senior);
            Person middle = new Person("ChiefKeef", Position.Midlle);
            Person junior = new Person("Леха", Position.Junior);
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
                        Project project1 = new Project("Сделать мобильную игру", new DateTime(2023, 12, 1), customer, team_leader);
                        projects.Add(project1);
                        Task task1 = new Task("Сделать локации", new DateTime(2023, 11, 12), customer, junior);
                        Task task2 = new Task("Создать скрипты", new DateTime(2023, 11, 20), customer, middle);
                        project1.AddTask(task1);
                        junior.AddTask(task1);
                        project1.AddTask(task2);
                        middle.AddTask(task2);
                        project1.StartProject();
                        task1.StartTask();
                        task2.StartTask();
                        Report report1 = new Report("Отчет по задаче 1", junior);
                        Report report2 = new Report("Отчет по задаче 2", middle);
                        task1.AddReport(report1);
                        task2.AddReport(report2);
                        ApproveReport(report1);
                        ApproveReport(report2);


                        break;
                    case 2:

                        break;

                }


            } while (choise != 4);
            


        }
    }
}
