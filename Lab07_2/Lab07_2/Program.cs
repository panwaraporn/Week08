using System;
namespace ConsoleAppArray
{
class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[10];
            int p = 0;
            for (int i = 0; i < data.Length; i++) { data[i] = i; }
            Console.WriteLine("data[7] : " + data[7]);
            Console.WriteLine("data[4] + data[9] : " + (data[4] + data[9]));
            Console.WriteLine("data[2] == data[6] ? : "
                + (data[2]==data[6] ? "eq" : "n eq"));
            for (int i = 0; i < data.Length; i++)
            { p += data[i]; }
            Console.WriteLine("Sum : " + p);

            Console.Write("All values : ");
            for (int i = 0; i < data.Length; i++)
            { Console.Write(data[i] + " "); }
            Console.ReadLine();
        }
    }
}
