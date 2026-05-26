using System;

namespace Exam3
{
    class Program
    {
        static void Main(string[] args)
        {

            // Initialize array
            Student[] stdnts = { new EsStudent("Robert", "Jonas", "967418"),
                                   new MsStudent("Jill", "Waters", "451209"),
                                   new HsStudent("Patrick", "Star", "325903"),
                                   new CllgStdnt("Susan", "Mamula", "561208")
                                 };

           

            foreach (var stud in stdnts)
            {
                Console.WriteLine(stud.ToString());
                Console.WriteLine();
            }

            // Wait for user exit
            Console.WriteLine("Press any key to exit...");
            Console.Read();

        }
    }
}
