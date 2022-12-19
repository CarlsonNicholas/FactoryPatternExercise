using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    internal class Motorcycle : IVehicle
    {
        public int Wheels { get; set; } = 2;
        public void Drive()
        { Console.WriteLine("The motor vehicle with 2 wheels is most commonly called a motorcycle."); }
    }
}
