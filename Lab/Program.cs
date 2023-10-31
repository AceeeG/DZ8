﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class Program
    {
        static void DoExercise1()
        {
            Console.WriteLine("Упражнения 1 - 3 совмещены\n");

            BankType type = BankType.Сберегательный;
            BankAccount account = new BankAccount(type);
            BankAccount account1 = new BankAccount(800);
            BankAccount account2 = new BankAccount(type, 850);
            account.Print();
            Console.WriteLine("Команды:\n<Внести> - если хотите пополнить счёт\n<Снять> - если хотите снять деньги со счёта\n" +
                    "<Баланс> - если хотите посмотреть баланс\n<Перевести> - если хотите перевести\n<Выход> - если хотите выйти\n");

            string command;
            do
            {
                Console.WriteLine("Введите команду");
                command = Console.ReadLine().ToLower();
                switch (command)
                {
                    case "внести":

                        Console.WriteLine("Введите сумму, которую хотите внести\n");
                        bool dep_money_flag = double.TryParse(Console.ReadLine(), out double dep_money);
                        if (!dep_money_flag)
                        {
                            do
                            {
                                Console.WriteLine("Вы не ввели число, повторите");
                                dep_money_flag = double.TryParse(Console.ReadLine(), out dep_money);
                            } while (!dep_money_flag);
                        }
                        account.DepositMoney(dep_money);
                        account.Dispose();
                        break;
                    case "снять":
                        Console.WriteLine("Введите сумму, которую хотите снять\n");
                        bool take_money_flag = double.TryParse(Console.ReadLine(), out double take_money);
                        if (!take_money_flag)
                        {
                            Console.WriteLine("Вы не ввели число");
                            do
                            {
                                take_money_flag = double.TryParse(Console.ReadLine(), out take_money);
                            } while (!take_money_flag);
                        }
                        account.WithdrawMoney(take_money);
                        account.Dispose();
                        break;
                    case "баланс":
                        account.Balance();
                        break;
                    case "перевести":
                        Console.WriteLine("Введите id пользователя\n");
                        bool id_flag = uint.TryParse(Console.ReadLine(), out uint id);
                        if (!id_flag)
                        {
                            do
                            {
                                Console.WriteLine("Вы не ввели число");
                                id_flag = uint.TryParse(Console.ReadLine(), out id);
                            } while (!id_flag);
                        }
                        Console.WriteLine("Введите сумму\n");
                        bool money_flag = double.TryParse(Console.ReadLine(), out double money);
                        if (!money_flag)
                        {
                            do
                            {
                                Console.WriteLine("Вы не ввели число");
                                money_flag = double.TryParse(Console.ReadLine(), out money);
                            } while (!money_flag);
                        }
                        account.TransferMoney(account1, money);
                        account.Dispose();
                        break;
                    case "выход":
                        break;
                    default:
                        Console.WriteLine("Вы ввели неверную команду\n");
                        break;
                }

            } while (!command.Equals("выход"));
        }


        static void Main(string[] args)
        {
            DoExercise1();

            Console.ReadKey();
        }
    }
}
