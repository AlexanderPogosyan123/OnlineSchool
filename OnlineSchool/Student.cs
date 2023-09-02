using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineSchool
{
    internal class Student
    {
        public string Name { get; }
        public string Sername { get; }
        public int Age { get; }


        public Student(string name,string sername,int age)
        {
            Name = name;
            Sername = sername;
            Age = age;
        }
    }
}
