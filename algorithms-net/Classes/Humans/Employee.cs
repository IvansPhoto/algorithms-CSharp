using System;
using System.Collections.Generic;

namespace algorithms_net.Classes
{
	public class Employee : Human, IDates
	{
		public List<Children> Children { get; set; } = new List<Children>();

		private static int _numbers;
		private IDates _datesImplementation;

		static Employee() => _numbers = 0;

		public static int ShowEmployeeNumbers() => _numbers;

		public Employee(string name, string surname) : base(name, surname)
		{
			Id = _numbers++;
		}
		/// <summary>
		/// Constructor 
		/// </summary>
		/// <param name="name">
		///	Name of an employy
		/// </param>
		/// <param name="surname"></param>
		/// <param name="children"></param>
		public Employee(string name, string surname, IEnumerable<Children> children) : this(name, surname)
		{
			Children.AddRange(children);
		}

		public DateTime StartDate { get; set; } = new DateTime(year: 2020, month: 1, day: 1);
	}
}