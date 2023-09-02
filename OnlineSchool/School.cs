using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineSchool
{
    internal class School
    {
        private string Name { get; }
        private List<Student> student = new List<Student>();

        public School(string name)
        {
            Name = name;
        }

    }
}
