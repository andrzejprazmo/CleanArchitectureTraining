using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter1Sample1App
{
	public interface IEntity
	{
		int Id { get; set; }
	}
	public class InsertResult<TEntity>
		where TEntity : IEntity
	{
		public InsertResult(TEntity value)
		{
			Value = value;
		}
		public TEntity Value { get; set; }

		public bool Succeded
		{
			get
			{
				if (Value != null && Value.Id > 0)
				{
					return true;
				}
				return false;
			}
		}
	}
	public class Person : IEntity
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
	}
	public class Address : IEntity
	{
		public int Id { get; set; }
		public string City { get; set; }
		public string ZipCode { get; set; }
		public string StreetNumber { get; set; }
	}
	public class PersonService
	{
		public InsertResult<Person> CreatePerson(string firstName, string lastName)
		{
			var person = new Person();
			person.FirstName = firstName;
			person.LastName = lastName;

			// TODO zapis do DB

			return new InsertResult<Person>(person);
		}

		public InsertResult<Address> CreateAddress(string city, string zipCode, string streetNumber)
		{
			var address = new Address();
			address.City = city;
			address.ZipCode = zipCode;
			address.StreetNumber = streetNumber;

			// TODO zapis do DB

			return new InsertResult<Address>(address);
		}
	}
}
