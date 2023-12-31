﻿using System;
using System.Collections.Generic;


namespace Exercises
{
    internal class Program
    {

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
                "3. Выход\n");
            byte choise;
            do
            {
                Console.WriteLine("Сделайте выбор\n");
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


                        do
                        {   
                            
                            task1.GenerateReports();
                            task2.GenerateReports();
                            task3.GenerateReports();
                            task4.GenerateReports();
                            task5.GenerateReports();
                            task6.GenerateReports();
                            task7.GenerateReports();
                            task8.GenerateReports();
                            task9.GenerateReports();
                            task10.GenerateReports();
                            
                            
                            /*
                            Report report1 = new Report("Отчет по заданию 1", junior); //Кусок кода для моментального ответа, но нет периодичности отчетов.
                            Report report2 = new Report("Отчет по заданию 2", junior); //Если хотите проверить вывод не ожидая месяц, расскоментите эту часть, и закоментите ту, что выше
                            Report report3 = new Report("Отчет по заданию 3", junior);
                            Report report4 = new Report("Отчет по заданию 4", junior);
                            Report report5 = new Report("Отчет по заданию 5", junior);
                            Report report6 = new Report("Отчет по заданию 6", junior);
                            Report report7 = new Report("Отчет по заданию 7", junior);
                            Report report8 = new Report("Отчет по заданию 8", junior);
                            Report report9 = new Report("Отчет по заданию 9", junior);
                            Report report10 = new Report("Отчет по заданию 10", junior);

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

                            if (report1.Approve())
                            {
                                task1.ClosedTask();
                            }
                            if (report2.Approve())
                            {
                                task2.ClosedTask();
                            }
                            if (report3.Approve())
                            {
                                task3.ClosedTask();
                            }
                            if (report4.Approve())
                            {
                                task4.ClosedTask();
                            }
                            if (report5.Approve())
                            {
                                task5.ClosedTask();
                            }
                            if (report6.Approve())
                            {
                                task6.ClosedTask();
                            }
                            if (report7.Approve())
                            {
                                task7.ClosedTask();
                            }
                            if (report8.Approve())
                            {
                                task8.ClosedTask();
                            }
                            if (report9.Approve())
                            {
                                task9.ClosedTask();
                            }
                            if (report10.Approve())
                            {
                                task10.ClosedTask();
                            }




                            if (project1.IsCompleted())
                            {
                                project1.CloseProject();
                            }
                            */
                            
                        } while (project1.Status != Status.Closed);

                        Console.WriteLine("Ваш проект готов\n");

                    break;

                    case 2:

                        Project project2 = new Project("Сделать мобильную игру", new DateTime(2023, 12, 20), customer, team_leader);
                        projects.Add(project2);
                        Task webtask1 = new Task("Верстка", new DateTime(2023, 11, 20), customer, ReportFrequency.Daily);
                        Task webtask2 = new Task("Скрипты", new DateTime(2023, 11, 22), customer, ReportFrequency.Daily);
                        Task webtask3 = new Task("Дизайн", new DateTime(2023, 11, 24), customer, ReportFrequency.Daily);
                        Task webtask4 = new Task("Слоган", new DateTime(2023, 11, 25), customer, ReportFrequency.Weekly);
                        Task webtask5 = new Task("PR", new DateTime(2023, 11, 28), customer, ReportFrequency.Weekly);
                        Task webtask6 = new Task("База данных", new DateTime(2023, 11, 20), customer, ReportFrequency.Daily);
                        Task webtask7 = new Task("Нейросети", new DateTime(2023, 12, 10), customer, ReportFrequency.Monthly);
                        Task webtask8 = new Task("Создать чат окно", new DateTime(2023, 11, 25), customer, ReportFrequency.Weekly);
                        Task webtask9 = new Task("Создать бургер меню", new DateTime(2023, 12, 5), customer, ReportFrequency.Daily);
                        Task webtask10 = new Task("Протестировать", new DateTime(2023, 12, 15), customer, ReportFrequency.Monthly);

                        project2.AddTask(webtask1);
                        junior.AddTask(webtask1);
                        project2.AddTask(webtask2);
                        junior1.AddTask(webtask2);
                        project2.AddTask(webtask3);
                        junior2.AddTask(webtask3);
                        project2.AddTask(webtask4);
                        junior3.AddTask(webtask4);
                        project2.AddTask(webtask5);
                        middle.AddTask(webtask5);
                        project2.AddTask(webtask1);
                        middle1.AddTask(webtask6);
                        project2.AddTask(webtask7);
                        middle2.AddTask(webtask7);
                        project2.AddTask(webtask8);
                        senior.AddTask(webtask9);
                        project2.AddTask(webtask9);
                        senior1.AddTask(webtask9);
                        project2.AddTask(webtask10);
                        team_leader.AddTask(webtask10);

                        project2.StartProject();

                        webtask1.StartTask(junior);
                        webtask2.StartTask(junior1);
                        webtask3.StartTask(junior2);
                        webtask4.StartTask(junior3);
                        webtask5.StartTask(middle);
                        webtask6.StartTask(middle1);
                        webtask7.StartTask(middle2);
                        webtask8.StartTask(senior);
                        webtask9.StartTask(senior1);
                        webtask10.StartTask(team_leader);
                        do
                        {
                            webtask1.GenerateReports();
                            webtask2.GenerateReports();
                            webtask3.GenerateReports();
                            webtask4.GenerateReports();
                            webtask5.GenerateReports();
                            webtask6.GenerateReports();
                            webtask7.GenerateReports();
                            webtask8.GenerateReports();
                            webtask9.GenerateReports();
                            webtask10.GenerateReports();
                            /*
                            Report report1 = new Report("Отчет по заданию 1", junior); //Кусок кода для моментального ответа, но нет периодичности отчетов.
                            Report report2 = new Report("Отчет по заданию 2", junior); //Если хотите проверить вывод не ожидая месяц, расскоментите эту часть, и закоментите ту, что выше
                            Report report3 = new Report("Отчет по заданию 3", junior);
                            Report report4 = new Report("Отчет по заданию 4", junior);
                            Report report5 = new Report("Отчет по заданию 5", junior);
                            Report report6 = new Report("Отчет по заданию 6", junior);
                            Report report7 = new Report("Отчет по заданию 7", junior);
                            Report report8 = new Report("Отчет по заданию 8", junior);
                            Report report9 = new Report("Отчет по заданию 9", junior);
                            Report report10 = new Report("Отчет по заданию 10", junior);

                            webtask1.AddReport(report1);
                            webtask2.AddReport(report2);
                            webtask3.AddReport(report3);
                            webtask4.AddReport(report4);
                            webtask5.AddReport(report5);
                            webtask6.AddReport(report6);
                            webtask7.AddReport(report7);
                            webtask8.AddReport(report8);
                            webtask9.AddReport(report9);
                            webtask10.AddReport(report10);

                            if (report1.Approve())
                            {
                                webtask1.ClosedTask();
                            }
                            if (report2.Approve())
                            {
                                webtask2.ClosedTask();
                            }
                            if (report3.Approve())
                            {
                                webtask3.ClosedTask();
                            }
                            if (report4.Approve())
                            {
                                webtask4.ClosedTask();
                            }
                            if (report5.Approve())
                            {
                                webtask5.ClosedTask();
                            }
                            if (report6.Approve())
                            {
                                webtask6.ClosedTask();
                            }
                            if (report7.Approve())
                            {
                                webtask7.ClosedTask();
                            }
                            if (report8.Approve())
                            {
                                webtask8.ClosedTask();
                            }
                            if (report9.Approve())
                            {
                                webtask9.ClosedTask();
                            }
                            if (report10.Approve())
                            {
                                webtask10.ClosedTask();
                            }

                            
                            */
                            if (project2.IsCompleted())
                            {
                                project2.CloseProject();
                            }

                        } while (project2.Status != Status.Closed);

                        Console.WriteLine("Ваш проект готов\n");
                    break;

                    case 3:
                        Console.WriteLine("Выходим");
                        break;
                    default:
                        Console.WriteLine("Нет такой команды\n");
                        break;
                }


            } while (choise != 3);

            Console.ReadKey();

        }
    }
}
