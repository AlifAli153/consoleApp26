using ConsoleApp26.CourseService;
using System;

namespace ConsoleApp26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CourceServicecs courseServicecs = new CourceServicecs();
            var CourseServicecs = new CourceServicecs();
            Console.WriteLine("CourseServicecs");
            int selection;
            
            
                Console.WriteLine("1.Create Group");
                Console.WriteLine("2.Edit Group");
                Console.WriteLine("3.Get All Group");
                Console.WriteLine("4.Get All Student");
                Console.WriteLine("0.Exit");
                string strSelection = Console.ReadLine();
                bool result = int.TryParse(strSelection, out selection);
            
        }
    }
}
