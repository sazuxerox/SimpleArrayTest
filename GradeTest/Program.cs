
using System;

namespace GradeTest
{
    class Program
    {
        static void Main(string[] args)
        {
          var ts = new TestArrayListBed();

            ts.Display();
            double average = ts.Average();
            Console.WriteLine("Average Grade is: {0}", average);

            double highestGrade = ts.HighestGrade();
            Console.WriteLine("Highest Grade is: {0}", highestGrade);

            double lowestGrade = ts.LowestGrade();
            Console.WriteLine("Lowest Grade is : {0}", lowestGrade);
        }

    }
}
