using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace lab3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> numbers = new Dictionary<string, int>()
            {
                { "c", 56},
                { "g", 24},
                { "a", 47},
                { "e", 1},
                { "y", 44},
                { "z", 9},
                { "b", 27},
                { "d", 55},
                { "x", 97},
                { "f", -12}
            };

            Console.WriteLine("Our dictionaty before operatoins");
            printDictionary(numbers);

            deleteMinAndMaxNumber(numbers);
            numbers = sortDictionaryByKey(numbers);

            Console.WriteLine("Our dictionaty after operatoins");
            printDictionary(numbers);

            string filePath = "sortedDictionary";

            jsonSerialize(numbers, filePath);
        }

        private static void deleteMinAndMaxNumber(Dictionary<string, int> numbers)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            string keyOfMinNum = "", keyOfMaxNum = "";

            foreach (var item in numbers)
            {
                if (item.Value < min)
                {
                    min = item.Value;
                    keyOfMinNum = item.Key;
                }
                else if (item.Value > max)
                {
                    max = item.Value;
                    keyOfMaxNum = item.Key;
                }
            }

            Console.WriteLine("The biggest number is " + max);
            Console.WriteLine("The least number is " + min);

            numbers.Remove(keyOfMinNum);
            numbers.Remove(keyOfMaxNum);
        }

        private static void printDictionary(Dictionary<string, int> numbers)
        {
            foreach (var item in numbers)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }

        private static Dictionary<string, int> sortDictionaryByKey(Dictionary<string, int> numbers)
        {
            return numbers.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
        }

        private static void jsonSerialize(object data, string filePath)
        {
            JsonSerializer jsonSerializer = new JsonSerializer();
            if (File.Exists(filePath)) File.Delete(filePath);

            StreamWriter sw = new StreamWriter(filePath);
            JsonWriter jsonWriter = new JsonTextWriter(sw);

            jsonSerializer.Serialize(jsonWriter, data);

            jsonWriter.Close();
            sw.Close();
        }
    }
}
