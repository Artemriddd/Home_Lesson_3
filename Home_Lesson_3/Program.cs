using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем счет мужа
            Check checkOne = new Check();
            checkOne.balance = 100;
            checkOne.number = 1;
            checkOne.type = Type.Husband;

            // Выводим на экран данные о счете мужа
            PrintType(checkOne.type);
            Console.WriteLine($"Баланс = {checkOne.balance} рублей");
            Console.WriteLine($"Номер счета: {checkOne.number}\n");

            // Создаем счет жены
            Check checkTwo = new Check();
            checkTwo.balance = 200;
            checkTwo.number = 2;
            checkTwo.type = Type.Wife;

            // Выводим на экран данные о счете жены
            PrintType(checkTwo.type);
            Console.WriteLine($"Баланс = {checkTwo.balance} рублей");
            Console.WriteLine($"Номер счета: {checkTwo.number}\n");

            // Мужу пришла зарплата
            Console.WriteLine("Пришла зарплата мужу");
            checkOne.AddMoney(1000);
            PrintType(checkOne.type);
            Console.WriteLine($"Баланс = {checkOne.balance} рублей\n");

            // Жена сказала дай денег на ноготочки
            Console.WriteLine("Жена требует деньги на ноготочки");
            checkTwo.TransferMoney(checkOne, 1000);

            // Баланс денег у жены
            PrintType(checkTwo.type);
            Console.WriteLine($"Баланс = {checkTwo.balance} рублей\n");

            // Баланс денег у мужа
            PrintType(checkOne.type);
            Console.WriteLine($"Баланс = {checkOne.balance} рублей\n");

        }
        // Перенес метод в Main согласно вашему Code Review
        public static void PrintType(Type type)
        {
            switch (type)
            {
                case Type.Husband:
                    Console.WriteLine("Счет мужа");
                    break;
                case Type.Wife:
                    Console.WriteLine("Счет жены");
                    break;
            }
        }

    }
}


