using System;

namespace Chapter1Sample1App
{
	class Program
	{
		static void Main(string[] args)
		{
			var personService = new PersonService();

			personService.CreatePerson("Jan", "Kowalski");
		}
	}
}
