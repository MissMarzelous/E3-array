using System;

namespace Exam3
{
    /// <summary>
    /// Represents a high school student.
    /// Implements IMathClass — learns basic algebra.
    /// </summary>
    class HighSchoolStudent : Student, IMathClass
    {
        public HighSchoolStudent(string firstName, string lastName, string studentId)
            : base(lastName, studentId, firstName)
        {
        }

        public override string ImportantThing()
        {
            return "SAT exam.";
        }

        public string Math()
        {
            return "basic algebra.";
        }

        public override string ToString()
        {
            string math = ((IMathClass)this).Math();
            return $"My name is {FirstName} {LastName}. " +
                   $"I'm a high school student. " +
                   $"I will have a {this.ImportantThing()} " +
                   $"I'm learning {math}";
        }
    }
}
