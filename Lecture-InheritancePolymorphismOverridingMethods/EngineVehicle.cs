using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_InheritancePolymorphismOverridingMethods
{
    abstract class EngineVehicle {
        public int FuelLeft { get; set; }
        public abstract void Drive();
    }
}
