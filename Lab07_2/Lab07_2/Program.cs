using System;
namespace ConsoleAppArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] months = new string[12];
            months[0] = "January";
            months[1] = "February";
            months[2] = "March";
            months[3] = "April";
         
            months[4] = "May";
            months[5] = "June";
            months[6] = "July";
            months[7] = "August";
            months[8] = "September";
            months[9] = "October";
            months[10] = "November";
            months[11] = "December";

            string value1 = Array.Find(months,
            element => element.Length == 3);
            // b) ค้นหาชื่อเดือนแรกที่มีความยาวมากกว่า 10 ตัวอักษร
            string value2 = Array.Find(months,
            element => element.Length > 10);
            // c) ค้นหาชื่อเดือนที่มีตัวอักษรตัวแรกเหมือนเดือนมกราคม แ ล้วนำมาแสดงรวมกันในบรรทัดเดียว คั่นด้วย,
            string[] array1 = Array.FindAll(months,
            element => element.StartsWith("J", StringComparison.Ordinal));
            Console.WriteLine(value1);
            Console.WriteLine(value2);
            Console.WriteLine(string.Join(",", array1));
            Console.ReadKey();
        }
    }
}