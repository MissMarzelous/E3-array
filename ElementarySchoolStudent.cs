using System;

namespace Exam3
{
    /// <summary>
    /// Represents an elementary school student.
    /// Implements IMathClass — learns basic math.
    /// </summary>
    class ElementarySchoolStudent : Student, IMathClass
    {
        public ElementarySchoolStudent(string firstName, string lastName, string studentId)
            : base(lastName, studentId, firstName)
        {
        }

        public override string ImportantThing()
        {
            return "farm field trip!";
        }

        public string Math()
        {
            return "basic math.";
        }

        public override string ToString()
        {
            string math = ((IMathClass)this).Math();
            return $"My name is {FirstName} {LastName}. " +
                   $"I am an elementary school student. " +
                   $"I will go on a {this.ImportantThing()} " +
                   $"I'm learning {math}";
        }
    }
}
