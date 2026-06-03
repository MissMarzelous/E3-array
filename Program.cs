using System;

namespace Exam3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Student Hierarchy Demo ===\n");

            Student[] students =
            {
                new ElementarySchoolStudent("Robert", "Jonas",  "967418"),
                new MiddleSchoolStudent    ("Jill",   "Waters", "451209"),
                new HighSchoolStudent      ("Patrick","Star",   "325903"),
                new CollegeStudent         ("Susan",  "Mamula", "561208")
            };

            foreach (Student student in students)
            {
                Console.WriteLine(student.ToString());
                Console.WriteLine();
            }

            Console.WriteLine("Press any key to exit...");
            Console.Read();
        }
    }
}
