using System;
using algorithms_net.Classes.Engines;

namespace algorithms_net.Interfaces
{
	public interface IEngine
	{
		public EngineTypes EngineType { get; set; }

		public int EnginePower
		{
			get => EnginePower;
			set
			{
				if (value > 0) EnginePower = value;
			}
		}

		void StartProcedure()
		{
			Console.WriteLine("Default engine start.");
		}

		void StopProcedure();
	}
}