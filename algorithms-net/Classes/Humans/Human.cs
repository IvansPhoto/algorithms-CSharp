using System;

namespace algorithms_net
{
	public abstract class Human
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		
		private static int _humansNumbers;

		public static int ShowHumansNumbers() => _humansNumbers;
		
		public Human(string name, string surname = "Default surname")
		{
			Name = name;
			Surname = surname;
			_humansNumbers++;
		}

		static Human() => _humansNumbers = 0;
	}
}