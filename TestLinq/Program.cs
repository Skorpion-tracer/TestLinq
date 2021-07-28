using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLinq.Extensions;

namespace TestLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("".CountSymbols());
            Console.WriteLine("Hello".CountSymbols());
            Console.WriteLine("Hello World".CountSymbols());
            Console.WriteLine();

            List<int> integers = new List<int>()
            {
                1, 6, 6, 5, 3, 3, 3
            };
            Console.WriteLine(CountUniqueElement(integers));

            List<string> strings = new List<string>()
            {
                "Петр", "Вова", "Вова", "Громила"
            };
            Console.WriteLine(CountUniqueElement(strings));

            Console.ReadLine();
        }

        public static string CountUniqueElement<T>(List<T> collection) where T : IComparable
        {
            string result = string.Empty;
            Dictionary<T, List<T>> elements = new Dictionary<T, List<T>>();

            foreach(T item in collection)
            {
                if (!elements.ContainsKey(item))
                {
                    List<T> value = new List<T>();

                    elements.Add(item, value);
                    elements[item].Add(item);
                }
                else
                {
                    elements[item].Add(item);
                }
            }            

            foreach (KeyValuePair<T, List<T>> pair in elements)
            {
                result += $" Значений {pair.Key }: {pair.Value.Count}\n";
            }            

            return result;
        }        
    }
}
