using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BestUniversity.Enums;

namespace BestUniversity
{
    class Program
    {
        static void Main(string[] args)
        {
            var createSt = CreateStudents(50);

            var bestUni = createSt
              .GroupBy(p => p.University)
              .ToDictionary(p => p.Key, p => p.OrderByDescending(p1 => p1.Mark)
                                              .Take(3)
                                              .Average(p1 => p1.Mark))
              .OrderByDescending(p => p.Value)
              .Take(1);

                Console.ReadLine();
        }
        static IEnumerable<Student> CreateStudents(int count)
        {
            Random rand = new Random();
            for (int i = 0; i < count; i++)
            {
                yield return new Student
                {
                    University = (University)rand.Next(0, Enum.GetValues(typeof(University)).Cast<University>().Distinct().Count()),
                    Name = (Names)rand.Next(0, Enum.GetValues(typeof(Names)).Cast<Names>().Distinct().Count()),
                    Surname = (Surnames)rand.Next(0, Enum.GetValues(typeof(Surnames)).Cast<Surnames>().Distinct().Count()),
                    Gender = (Gender)rand.Next(0, Enum.GetValues(typeof(Gender)).Cast<Gender>().Distinct().Count()),
                    Mark = (byte)rand.Next(0, 21)
                };
            }
        }
    }
}
