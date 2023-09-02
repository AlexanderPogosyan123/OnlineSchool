using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineSchool
{
    internal class Student
    {
        private string Name { get; }
        private string Sername { get; }
        private int Age { get; }


        public Student(string name,string sername,int age)
        {
            Name = name;
            Sername = sername;
            Age = age;
        }
    }
}
