// Asking user for number of wheels 

using FactoryPatternExercise;

Console.WriteLine("Please enter the number of wheels that you want your vehicle to have: ");

int wheelNumber = int.Parse(Console.ReadLine());
IVehicle wheelInstance = VehicleFactory.GetVehicle(wheelNumber);
wheelInstance.Drive();
