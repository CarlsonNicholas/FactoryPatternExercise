using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    internal class Car : IVehicle
    {
        public int Wheels { get; set; } = 4;
        public void Drive()
        { Console.WriteLine("The motor vehicle with 4 wheels is most commonly called a car."); }
    }
}
