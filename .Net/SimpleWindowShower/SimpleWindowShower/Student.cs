using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWindowShower
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }

        public override string ToString()
        {
            return $"{Name} {Age}";
        }
    }
}
