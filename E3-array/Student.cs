using System;
using System.Collections.Generic;
using System.Text;

namespace Exam3
{
    abstract class Student
    {
        // read-only
        public string LstNm { get; }
        public string StdntID { get; }
        public string FstNm { get; }

        // Abstract 
        public abstract string ImprtntThng();

        // constructor
        public Student(string last, string id, string name)
        {
            LstNm = last;
            StdntID = id;
            FstNm = name;
        }

        //  variables
        private string fstName, lstName, stdntID;


    }
}
