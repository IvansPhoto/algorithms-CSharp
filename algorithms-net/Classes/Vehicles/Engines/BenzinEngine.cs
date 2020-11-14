using System;
using algorithms_net.Interfaces;

namespace algorithms_net.Classes.Engines
{
	public class BenzinEngine : IEngine
	{
		public string SerialNumber { get; set; }

		public FuelTypes FuelType { get; set; }

		public int EnginePower { get; set; }
		public EngineTypes EngineType { get; set; } = EngineTypes.Piston;

		public void StartProcedure()
		{
			Console.WriteLine($"Start fuel pump...");
		}

		public void StopProcedure()
		{
			Console.WriteLine($"Stop fuel pump...");
		}

		public BenzinEngine(int enginePower, FuelTypes fuelType = FuelTypes.BenzinA95, string serialNumber = "0000000")
		{
			SerialNumber = serialNumber;
			FuelType = fuelType;
			EnginePower = enginePower;
		}
	}
}