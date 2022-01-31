using System;

namespace Chapter1Sample1App
{

	class Program
	{
		static void Main(string[] args)
		{
			var personService = new PersonService();

			var result = personService.CreatePerson("Jan", "Kowalski");
			if (result.Succeded)
			{
				var person = result.Value;
			}
		}
	}
}
