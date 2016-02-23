using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LINQTest
{
    public class TestClass1
    {
        static string[] words = { "one", "two", "Bingo - black ear, white fang", "Rembo", "123", "Red Hot Chilli Peppers", "Appollo 17" };
        static int[] numbers = { 105, 34, 28, 456, 78, 1, 15, 94, 61, 38, 14 };

        public static void GetShortNames()
        {
            var results = from word in words
                          where word.Length < 5
                          select word;

            PrintResults(results);
        }

        public static void GetShortNamesAnotherWay()
        {
            var results = words.Where(x => x.Length < 5);
            PrintResults(results);
        }

        public static void GetNumbers()
        {
            var results = numbers.Where(x => x > 70);
            PrintResults(results);
        }

        private static void PrintResults(IEnumerable array)
        {
            foreach (var word in array)
            {
                Console.Write(word + "\t");
            }
        }
    }
}
