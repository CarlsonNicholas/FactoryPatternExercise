using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    internal static class VehicleFactory
    {
        public static IVehicle GetVehicle(int choice)
        {
            switch(choice)
            {
                case 2:
                    return new Motorcycle();
                case 4:
                    return new Car();

            default:
                return new Basic();
           }
        }
    }
}
