using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    internal class Basic : IVehicle
    {
        public int Wheels { get; set; } = 0;
        public void Drive()
        { Console.WriteLine("Hrmmm this is awkward.. Try a vehicle with either 2 or 4 wheels!"); }
    }
}
