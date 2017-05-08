using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {

#if DEBUG
            Console.SetIn(new System.IO.StreamReader(@"E:\input.txt"));
#endif
            var input = int.Parse(Console.ReadLine());
            var cities = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < input; i++)
            {
                string[] read = Console.ReadLine().Split().ToArray();
                string continent = read[0];
                string country = read[1];
                string city = read[2];

                if(!cities.ContainsKey(continent)) cities[continent] = new Dictionary<string, List<string>>();

                if (!cities[continent].ContainsKey(country)) cities[continent][country] = new List<string>();

                cities[continent][country].Add(city);
            }

            foreach (var item in cities)
            {
                var continent = item.Key;
                var country = item.Value;

                Console.WriteLine(continent + ":");

                foreach (var city in country)
                {
                    var myCountry = city.Key;
                    var myCity = city.Value;

                    Console.WriteLine($"{myCountry} -> {String.Join(", ", myCity)}");
                }
            }

        }
    }
}
