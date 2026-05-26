using System;
using System.Collections.Generic;
using System.Text;

namespace Exam3
{
    class HsStudent :Student, IMathClass
    {
      
        public override string ToString()
        {
            return "My name is " + this.FstNm + " " + this.LstNm + ". I'm a high school student. I will have a " + this.ImprtntThng() + " I'm learning " + this.Math();
        }
        // constructor
        public HsStudent(string name, string last, string id) : base(last, id, name)
        {
        }
        // Interface 
        public string Math()
        {
            return "basic algebra.";
        }
        // override
        public override string ImprtntThng()
        {
            return "SAT exam.";
        }

       
    }
}
    
