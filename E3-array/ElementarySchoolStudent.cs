using System;
using System.Collections.Generic;
using System.Text;

namespace Exam3
{
    class EsStudent : Student, IMathClass
    {
       
        public override string ToString()
        {
            return "My name is " + this.FstNm + " " + this.LstNm + ". I am an elementary school student. I will go on a " + this.ImprtntThng() + " I'm learning " + this.Math();
        }
        // constructor
        public EsStudent(string name, string last, string id) : base(last, id, name)
        {
        }
        // Interface 
        public string Math()
        {
            return "basic math.";
        }
        // override
        public override string ImprtntThng()
        {
            return "farm field trip!";
        }

    }
}

