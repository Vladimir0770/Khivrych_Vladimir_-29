using System;
using System.Collections.Generic;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            for (int i = 1; i < 15; i++)
            {
                numbers.Add(i);
            }

            Console.WriteLine("Before remove");
            printList(numbers);
            Console.WriteLine();

            int k = 7;

            Console.WriteLine("After remove");
            printList(removeNumber(k, numbers));

        }
        // Удаляет элемент по индексу, а все элементы, которые были ниже удаленного, перемещает в начало списка.
        // Возвращает измененную коллекцию
        private static List<int> removeNumber(int index, List<int> numbers)
        {
            int nextIndex = index + 1;

            List<int> belowNum = new List<int>();

            for (int i = nextIndex; i < numbers.Count; i++)
            {
                belowNum.Add(numbers[i]);
            }


            numbers.RemoveAt(index);

            for (int i = 0; i < index; i++)
            {
                belowNum.Add(numbers[i]);
            }

            return belowNum;
        }

        private static void printList(List<int> numbers)
        {
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
        }
    }
}
