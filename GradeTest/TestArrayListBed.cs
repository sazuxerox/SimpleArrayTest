
using System;

namespace GradeTest
{
    class TestArrayListBed
    {

        int[] grades = new int[] { 78, 85, 86, 80, 75 };

        //find the average of the array values
        public double Average()
        {
            int total = 0;

            //get the length of the array
            int len = grades.Length;

            //traveres through the array.
            for (int i = 0; i < len; i++)
            {
                //find the total of the array values.
                total += grades[i];
            }
            //find the average calculation by dividing the total by the 
            //number of array values.
            double average = (double)total / len;
            return average;
        }

        //Display the array values and the total
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


        //find the highest value of the array
        public int HighestGrade()
        {
            //assign the first array values to the variable
            int highestGrade = grades[0];
            for (int i = 0; i <= grades.GetUpperBound(0); i++)
            {
                //check if the traveresed value is greater than the previous value
                if (grades[i] > highestGrade)
                {
                    //assigning the new highest value to the declared variable
                    highestGrade = grades[i];
                }
            }
            return highestGrade;  //return the value
        }

        //find the lowest value of the array
        public int LowestGrade()
        {
            //assign the first array values to the variable
            int lowestGrade = grades[0];

            //traversing through the array
            for (int i = 0; i <= grades.GetUpperBound(0); i++)
            {
                //checking if the current traversed value is smaller than the assigned value in the variable.
                if (grades[i] < lowestGrade)
                {
                    //assigning the new smallest value to the variable
                    lowestGrade = grades[i];
                }
            }
            return lowestGrade;  //return the value
        }
    }
}
