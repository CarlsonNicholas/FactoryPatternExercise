using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    internal interface IVehicle
    {
        public int Wheels { get; set; }
        public void Drive();

    }
}
