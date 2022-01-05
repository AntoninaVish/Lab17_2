using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17_2
{
    class Check <T>
    {
        private T num;
        private double balance;
        private string name;
        
        public T Num // свойство
        {
            set
            {
                num = value;
            }
            get
            {
                return num;
            }
        }
        public double Balance // свойство
        {
            set
            {
               if (value>=0)
               {
                    balance = value;
               }
                else
                {
                    Console.WriteLine("Баланс не может быть отрицательным");
                }
            }
            get
            {
                return balance;
            }
        }
        public string Name // свойство 
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public Check(T num, double balance, string name)//конструктор
        {
            Num = num; // параметры конструктора
            Balance = balance;
            Name = name;
        }
        public void GetInfo() // метод для чтения
        {
            Console.WriteLine ($"Номер счета: {Num}; баланс: {Balance}; Ф.И.О: {Name}");
        }
        
                 
    }

}
