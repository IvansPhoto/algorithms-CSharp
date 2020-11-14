using System;
using algorithms_net.Interfaces;

namespace algorithms_net.Classes.Engines
{
	public class ElectricEngine : IEngine
	{
		public string PlugType { get; set; }
		public int Voltage { get; set; }
		public EngineTypes EngineType { get; set; }
		public int EnginePower { get; set; }
		public void StartProcedure()
		{
			Console.WriteLine($"Connect circuit...");
		}

		public void StopProcedure()
		{
			Console.WriteLine($"Disconnect circuit...");
		}
	}
}