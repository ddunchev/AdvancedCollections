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

            var grades = new Dictionary<string, List<string>>();

            for (int i = 0; i < input; i++)
            {
                string[] read = Console.ReadLine().Split().ToArray();
                string name = read[0];
                double grade = float.Parse(read[1]);
                if (!grades.ContainsKey(name)) grades[name] = new List<string>();
                grades[name].Add(String.Format("{0:0.00}", grade));
            }

            foreach (var item in grades)
            {
                Console.WriteLine($"{item.Key} -> {String.Join(" ", item.Value)} (avg: {item.Value.Select(x => double.Parse(x)).ToList().Average():0.00})");

            }

        }
    }
}
