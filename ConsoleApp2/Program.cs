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
            double physics = 70;
            double chemistry = 55;
            double biology = 60;
            string forma = "ochnaya";
            double sredniy = ((physics + chemistry + biology) / 3);


            // 2 student
            string Name2 = "Зубенко Михаил Петрович";
            int age2 = 20;
            double physics2 = 75;
            double chemistry2 = 50;
            double biology2 = 60;
            string forma2 = "ochnaya";

            double sredniy2 = ((physics2 + chemistry2 + biology2) / 3);

            //ввод с консоли
            // Console.WriteLine("введите возраст:");
            // int age1 = int.Parse(Console.ReadLine());


            // вывод
            Console.WriteLine($" Name: {Name} {physics} {chemistry}{biology} {forma} {sredniy}");
            Console.WriteLine($" Name: {Name2} {physics2} {chemistry} {biology2} {forma2} {sredniy2}");


            Console.ReadKey();
        }

    }
}


