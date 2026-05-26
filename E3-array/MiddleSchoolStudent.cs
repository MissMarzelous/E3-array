using System;
using System.Collections.Generic;
using System.Text;

namespace Exam3
{
    class MsStudent: Student, IMathClass
    {
        public override string ToString()
        {
            return "My name is " + this.FstNm + " " + this.LstNm + ". I am a middle school student. I will go to a " + this.ImprtntThng() + " I'm learning " + this.Math();
        }

        // constructor
        public MsStudent(string name, string last, string id) : base(last, id, name)
        {

        }
        // Interface 
        public string Math()
        {
            return "geometry.";
        }

        //  override
        public override string ImprtntThng()
        {
            return "summer camp!";
        }



    }
}
    
