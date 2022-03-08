using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningLinq
{
	public class Employee
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public string Gender { get; set; }
		public int Salary { get; set; }

		public Employee(string name, int age, string gender, int salary)
		{
			Name = name;
			Age = age;
			Gender = gender;
			Salary = salary;
		}

	}

	public class MyEmployees
	{
		public static List<Employee> GetEmployees()
		{
			return new List<Employee>
			{
				new Employee("hagai",43,"Male",30000),
				new Employee("dana",25,"Female",32000),
				new Employee("shuki",20,"Male",18000),
				new Employee("avi",45,"Male",20000),
				new Employee("michal",40,"Female",28000),
				new Employee("dina",30,"Female",20000)
			};
		}
	}
}
