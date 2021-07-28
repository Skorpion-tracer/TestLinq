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


            List<int> integers = new List<int>()
            {
                1, 6, 6, 5, 3, 3, 3
            };

            Console.WriteLine(CountUniqueElement(integers));
            Console.ReadLine();
        }

        public static string CountUniqueElement<T>(List<T> collection)
        {
            string result = string.Empty;

            Dictionary<T, List<T>> elements = new Dictionary<T, List<T>>();

            foreach(T item in collection)
            {
                if (!elements.ContainsKey(item))
                {
                    List<T> value = new List<T>();
                    //value.Add(item);

                    elements.Add(item, value);
                }

                result = $"{elements.Count }";
            }

            foreach (T item in collection)
            {
                foreach (T key in elements.Keys)
                {
                   
                    for (int j = 0; j <= elements[item].Count; j++)
                    {
                        if (elements[item].Contains(item) || elements[item].Count == 0)
                        {
                            elements[item].Add(item);
                        }
                    }
                }
            }

            return result;
        }
    }
}
