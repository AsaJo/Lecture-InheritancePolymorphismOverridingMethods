using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_InheritancePolymorphismOverridingMethods
{
    class DerivedClass : BaseClass {
        public override void DoStuff() {
            base.DoStuff();
            //New code
        }
    }
    // public string? Name { get; set; }
} //public new void DoStuff() {/* code */}
