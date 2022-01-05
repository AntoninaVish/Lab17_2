using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числовой номер:");
            int numInt = Convert.ToInt32(Console.ReadLine()); //метод для заполнения пользователем
            Console.WriteLine("Введите баланс:");
            double balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Ф.И.О:");
            string name = Console.ReadLine();
            Check<int> check1 = new Check<int> (numInt,balance,name); // создаем экземпляр класса Check
            check1.GetInfo(); // вызываем метод

            Console.WriteLine("Введите строковый номер:");
            string numString = Console.ReadLine();
            Console.WriteLine("Введите баланс:");
            balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Ф.И.О:");
            name = Console.ReadLine();
            Check<string> check2 = new Check<string>(numString, balance, name);
            check2.GetInfo();

            Console.ReadKey();

        }
    }
}
