
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
     class Student
    {
        public string Name;
        public double GPA;

        public string getData()
        {
            return this.Name + " has a GPA of " + this. GPA;    
        }
    }
}
