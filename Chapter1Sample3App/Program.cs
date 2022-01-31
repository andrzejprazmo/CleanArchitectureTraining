using System;

namespace Chapter1Sample3App
{
	class Program
	{
		static void Main(string[] args)
		{
			DateTime someBirthDate = new DateTime(1988, 3, 1);
			//int age = Age(someBirthDate);
			int age = someBirthDate.Age();

			Console.WriteLine($"Twój wiek (lata): {age}");
		}

		static int Age(DateTime birthDate)
		{
			DateTime today = DateTime.Today;

			int age = today.Year - birthDate.Year;

			if (birthDate.Date > today.AddYears(-age)) age--;

			return age;
		}
	}
}
