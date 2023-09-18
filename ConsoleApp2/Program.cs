// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad
{
    class Student
    {
        static void Main(string[] args)
        {
            // 1 student
             string Name = "Балданов Сандан Батоевич";
             int age = 18;

            // 2 student
            string Name2 = "Зубенко Михаил Петрович";
            int age2 = 20;


            //ввод с консоли
            // Console.WriteLine("введите возраст:");
            // int age1 = int.Parse(Console.ReadLine());


            // вывод
            Console.WriteLine($" Name: {Name} ");
            Console.WriteLine($" Name: {Name2} ");


            Console.ReadKey();
        }

    }
}


