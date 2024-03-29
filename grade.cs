using System;

namespace StudentGradingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName;
            int rollNumber, m1, m2, m3, m4;
            int total=0;
            double percentage;

            Console.Write("Enter student name: ");
            studentName = Console.ReadLine();

            Console.Write("Enter roll number: ");
            rollNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks for subject 1: ");
            m1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks for subject 2: ");
            m2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks for subject 3: ");
            m3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks for subject 4: ");
            m4 = Convert.ToInt32(Console.ReadLine());

            total = (m1+m2+m3+m4);
            percentage = (double)total / 4;

            Console.WriteLine($"Student Name: {studentName}");
            Console.WriteLine($"Roll Number: {rollNumber}");
            Console.WriteLine($"Total Marks: {total}");
            Console.WriteLine($"Percentage: {percentage}%");

            if (percentage >= 95)
            {
                Console.WriteLine("Grade: A+");
            }
            else if (percentage >= 90)
            {
                Console.WriteLine("Grade: A");
            }
            else if (percentage >= 85)
            {
                Console.WriteLine("Grade: B+");
            }
            else if (percentage >= 80)
            {
                Console.WriteLine("Grade: B");
            }
            else if (percentage >= 75)
            {
                Console.WriteLine("Grade: C");
            }
            else if (percentage >= 70)
            {
                Console.WriteLine("Grade: D");
            }
            else
            {
                Console.WriteLine("Grade: F");
            }

                Console.ReadKey();
            }
        }
    }
