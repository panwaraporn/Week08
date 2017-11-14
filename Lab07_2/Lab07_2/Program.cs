using System;
namespace ConsoleAppArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] GPS = new double[8];
            double GPA = 0;
            for (int i = 0; i < GPS.Length; i++)
                
        {
                Console.Write("Grade on semester {0} : ", i + 1);
                GPS[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine(">>>>>>>>>>>>");
            for (int i = 0; i < GPS.Length; i++)
            {
                Console.WriteLine("Grade on semester {0} : {1}", i + 1, GPS[i]);
            }
            Console.WriteLine(">>>>>>>>>>>>");
            for (int i = 0; i < GPS.Length; i++)
            {
                GPA += GPS[i];
            }
            Console.WriteLine("GPA is : " + GPA / GPS.Length);
            Console.ReadKey();
        }
    }
}