using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15ex01_02_03.src
{
    internal class Teacher
    {
        private string Name { get; set; }
        private List<string> courses = new List<string>();

        public Teacher(string name, List<string> courses)
        {
            Name = name;
            this.courses = courses;
        }
    }
}
