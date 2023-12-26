using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grade
{
    class Grades
    {
        public Grades()
        {

            Console.Write("Enter marks: ");
            int mark = int.Parse(Console.ReadLine());
            string grade;
            if (mark >= 90)
            {
                grade = "A";
            }
            else if (mark >= 80)
            {
                grade = "A-";
            }
            else if (mark >= 70)
            {
                grade = "B";
            }
            else if (mark >= 60)
            {
                grade = "B-";
            }
            else if (mark >= 50)
            {
                grade = "C";
            }
            else
            {
                grade = "D";
            }
            Console.WriteLine($"Grade: {grade}");
        }
    }
}
