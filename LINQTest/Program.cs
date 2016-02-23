using System;

namespace LINQTest
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass1.GetShortNames();
            Console.WriteLine("\n---------------------------------------");
            TestClass1.GetShortNamesAnotherWay();
            Console.WriteLine("\n---------------------------------------");
            TestClass1.GetNumbers();

            Console.ReadKey();
        }
    }
}
