using System;

namespace Exam3
{
    abstract class Student
    {
        // Read-only properties shared by all student types
        public string FirstName { get; }
        public string LastName { get; }
        public string StudentId { get; }

        /// <summary>
        /// Abstract method — every derived class must provide
        /// its own implementation describing something important
        /// about that education level.
        /// </summary>
        public abstract string ImportantThing();

        /// <summary>
        /// Base constructor — sets the student's name and ID.
        /// Called by all derived classes using base().
        /// </summary>
        public Student(string lastName, string studentId, string firstName)
        {
            LastName  = lastName;
            StudentId = studentId;
            FirstName = firstName;
        }
    }
}
