using System;
using algorithms_net.Classes;
using algorithms_net.Classes.Engines;
using algorithms_net.Interfaces;

namespace algorithms_net
{
	class Program
	{
		public static void Main(string[] args)
		{
			var busOne = new Bus {Name = "base", Color = "Red", PassengersNumber = 150};
			busOne.WriteName();
			busOne.PassengersToString();
			
			BenzinEngine benzinEngine = new BenzinEngine(enginePower: 300, fuelType: FuelTypes.BenzinA98, serialNumber: "001");
			Console.WriteLine(benzinEngine.EnginePower);
			if(busOne is Vehicle busVehicle) busVehicle.WriteName();
			if(benzinEngine is IEngine benzinIEngine) benzinIEngine.StartProcedure();
		}
	}
}