using System;

namespace Exam3
{
    /// <summary>
    /// Represents a college student.
    /// Implements IMathClass — learns advanced algebra.
    /// </summary>
    class CollegeStudent : Student, IMathClass
    {
        public CollegeStudent(string firstName, string lastName, string studentId)
            : base(lastName, studentId, firstName)
        {
        }

        public override string ImportantThing()
        {
            return "major.";
        }

        public string Math()
        {
            return "advanced algebra.";
        }

        public override string ToString()
        {
            string math = ((IMathClass)this).Math();
            return $"My name is {FirstName} {LastName}. " +
                   $"I'm a college student. " +
                   $"I have a {this.ImportantThing()} " +
                   $"I'm learning {math}";
        }
    }
}
