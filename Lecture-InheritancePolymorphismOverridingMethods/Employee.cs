using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_InheritancePolymorphismOverridingMethods
{
    class Employee: Person {
        public int Salary { get; set; }
        public string? Department { get; set; }
        public Administrator? Boss { get; set; }
    }
}
