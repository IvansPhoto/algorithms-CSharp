namespace algorithms_net.Classes
{
	public sealed class Children : Human
	{
		
		public int EmployeeId { get; set; }
		public Employee? Employee { get; set; }

		private static int _numbers;

		static Children() => _numbers = 0;

		public static int ShowNumbers() => _numbers;

		public Children(string name, string surname) : base(name, surname)
		{
			Id = _numbers++;
		}

		public Children(string name, string surname, int employeeId, Employee employee) : this(name, surname)
		{
			Id = _numbers++;
			EmployeeId = employeeId;
			Employee = employee;
		}
		
	}
}