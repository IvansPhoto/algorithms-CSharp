using System;

namespace algorithms_net.Classes
{
	public sealed class Bus : Vehicle, IDates
	{
		public DateTime StartDate { get; set; } = new DateTime(year: 2010, month: 01, day: 01);
		private int _passengersNumber;
		public int PassengersNumber
		{
			get => _passengersNumber;
			set
			{
				if (value > 5) _passengersNumber = value;
			}
		}

		public override void WriteName()
		{
			Console.WriteLine($"PassengersNumber: {_passengersNumber} Name - {Name}. Color - {Color}");
		}

		public void PassengersToString() => Console.WriteLine($"PassengersNumber {_passengersNumber}");
	}
}