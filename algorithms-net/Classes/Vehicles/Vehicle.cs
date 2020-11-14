using System;
using algorithms_net.Interfaces;

namespace algorithms_net.Classes
{
	public abstract class Vehicle
	{
		public string Name { get; set; }
		public IEngine Engine { get; set; }
		public string? Color { get; set; }
		
		public virtual void WriteName()
		{
			Console.WriteLine($"Name - {Name}. Color - {Color}");
		}
	}
}