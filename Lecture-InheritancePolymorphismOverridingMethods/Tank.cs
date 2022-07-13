using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_InheritancePolymorphismOverridingMethods
{
    class Tank : EngineVehicle {
        public override void Drive() {
            /* Code for Tank´s Drive()*/
            this.FuelLeft -= 10;
        }
    }
}
