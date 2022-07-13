using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_InheritancePolymorphismOverridingMethods
{
    class Administrator : Employee{
        public List<string>? Departments { get; set; }
        public List<Employee>? Employees { get; set; }

        public Administrator() : base() {
            this.Name += "(Administrator)";
        }
        public override string ToString() {
            return base.ToString() + "(Administrator)";
        }
    }
}
