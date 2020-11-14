using System;

namespace algorithms_net.Classes
{
	public class CarD : Vehicle, IDates
	{
		public DateTime StartDate { get; set; } = new DateTime(year: 2010, month: 01, day: 01);
		public int SeatNumber { get; set; } = 4;
	}
}