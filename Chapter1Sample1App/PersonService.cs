using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter1Sample1App
{
	public class Person
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
	}
	public class Address
	{
		public int Id { get; set; }
		public string City { get; set; }
		public string ZipCode { get; set; }
		public string StreetNumber { get; set; }
	}
	public class PersonService
	{
		public Person CreatePerson(string firstName, string lastName)
		{
			var person = new Person();
			person.FirstName = firstName;
			person.LastName = lastName;

			// TODO zapis do DB

			return person;
		}

		public Address CreateAddress(string city, string zipCode, string streetNumber)
		{
			var address = new Address();
			address.City = city;
			address.ZipCode = zipCode;
			address.StreetNumber = streetNumber;

			// TODO zapis do DB

			return address;
		}
	}
}
