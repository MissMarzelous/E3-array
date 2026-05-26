using System;
using System.Collections.Generic;
using System.Text;

namespace Exam3
{
    class CllgStdnt : Student, IMathClass

    {
        public override string ToString()
        {
            return "My name is " + this.FstNm + " " + this.LstNm + ". I'm a college student. I have a " + this.ImprtntThng() + " I'm learning " + this.Math();
        }
        // constructor
        public CllgStdnt(string name, string last, string id) : base(last, id, name)
        {

        }
        // Interface 
        public string Math()
        {
            return "advanced algebra.";
        }

        // override
        public override string ImprtntThng()
        {
            return "major.";
        }

    }
}

