using System;

namespace ConsoleAppArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[10];
            Student[] student = new Student[31]; // สร้างอาร์เรย์ของวัตถุจากคลาส
            Console.WriteLine(data.Length);
            Console.WriteLine(student.Length);
            Console.ReadLine();
        }
        class Student     // nested class
        {
            private string name;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
        }
    }
}
