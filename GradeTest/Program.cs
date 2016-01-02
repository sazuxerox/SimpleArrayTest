
using System;

namespace GradeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare an object of TestArrayListBed class to access it.
            var ts = new TestArrayListBed();

            //display the array values.
            ts.Display();

            //display the average value of the array
            double average = ts.Average();
            Console.WriteLine("Average Grade is: {0}", average);

            //display the highest value of the array
            double highestGrade = ts.HighestGrade();
            Console.WriteLine("Highest Grade is: {0}", highestGrade);

            //display the lowest value of the array. 
            double lowestGrade = ts.LowestGrade();
            Console.WriteLine("Lowest Grade is : {0}", lowestGrade);
        }

    }
}
