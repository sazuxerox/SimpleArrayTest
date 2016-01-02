
using System;
using System.Collections;

namespace GradeTest
{
    class TestArrayListBed
    {
        
        int[] grades = new int[]{78,85,86,80,75};
        
        public double Average()
        {
            int total = 0;
            int len = grades.Length;
            for (int i = 0; i < len; i++)
            {
                total += grades[i];
            }
            double average = (double)total/len;
            return average;
        }

        public void Display()
        {
            int total = 0;
            for (int i = 0; i <= grades.GetUpperBound(0); i++)
            {
                total += grades[i];
                Console.Write(grades[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Total is : {0}", total);
            Console.WriteLine();
        }
        public int HighestGrade()
        {
            int highestGrade = grades[0];
            for (int i = 0; i <= grades.GetUpperBound(0); i++)
            {
                if (grades[i] > highestGrade)
                {
                    highestGrade = grades[i];
                }
            }
            return highestGrade;
        }
        public int LowestGrade()
        {
            int lowestGrade = grades[0];
            for (int i = 0; i <= grades.GetUpperBound(0); i++)
            {
                if (grades[i] < lowestGrade)
                {
                    lowestGrade = grades[i];
                }
            }
            return lowestGrade;
        }
    }
}
