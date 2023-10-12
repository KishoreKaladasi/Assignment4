using System;
using Assignment4Library;

namespace Assignment4_1
{
    internal class FirstMain
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Maths = 98;
            s.English = 99;
            s.Science = 93;
            s.Calculate();

            Employee e = new Employee(101, " kishore", 60000, 101, 22);
            e.Calculate();

            Console.ReadLine();


        }
    }
}
