using System;

namespace Exam3
{
    /// <summary>
    /// Represents a middle school student.
    /// Implements IMathClass — learns geometry.
    /// </summary>
    class MiddleSchoolStudent : Student, IMathClass
    {
        public MiddleSchoolStudent(string firstName, string lastName, string studentId)
            : base(lastName, studentId, firstName)
        {
        }

        public override string ImportantThing()
        {
            return "summer camp!";
        }

        public string Math()
        {
            return "geometry.";
        }

        public override string ToString()
        {
            string math = ((IMathClass)this).Math();
            return $"My name is {FirstName} {LastName}. " +
                   $"I am a middle school student. " +
                   $"I will go to a {this.ImportantThing()} " +
                   $"I'm learning {math}";
        }
    }
}
