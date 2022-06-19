using System;
using System.Collections.Generic;
using System.Linq;

namespace lab3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            char C = 's';
            string str1 = "mercedes apple BMW Alibaba Amazon"; // consisits one
            string str2 = "mercedes apple BMW Alibaba Airpods"; // consisits two
            string str3 = "apple BMW Alibaba"; /// consisits none

            string[] arr = str3.Split(" ");
            List<string> list = new List<string>(arr);

            Console.WriteLine("Our string -> " + str1);

            int counter = 0;
            string element = "";

            counter = list.Where(item => item.Last() == C).Count();

            if (counter == 1)
            {
                Console.WriteLine(element);
            }
            else if (counter == 0)
            {
                Console.WriteLine("*Empty line, as there is no words ending with \"" + C + "\"*");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
