using System;
using System.Collections.Generic;

namespace CommonApp
{

    public class Program
    {
        public static void Main(string[] args)
        {
			// Faza run time

			// Reference type
			var person = new Person();
			Person person2 = person;

			// Value type
			int x = 1;
			int y = x;

			var myGeneric = new MyGenericType<Person, MyClass, BaseClass>();

			var list = new List<string>();


			DisplayFullNameType myMethod = new DisplayFullNameType(person.DisplayFullName);

			DisplayFullNameType myMethod2 = person.DisplayFullName;

			Func<string, string> myMethod3 = s =>
			{
				return "Ala ma kota";
			};

			myMethod3("Kot");

			myMethod("Alama kota");
		}
    }

	public delegate string DisplayFullNameType(string format);

	// Faza design time
	public class Person
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }

        public string DisplayFullName(string format)
		{
			if (format == "H")
			{
				return $"{LastName}, {FirstName}";
			}
			return $"{FirstName} {LastName}";
		}
	}

	public interface IMyInterface
	{

	}

	public class MyClass : IMyInterface
	{

	}

	public class BaseClass
	{
		public T1 Foo<T1, T2>(T2 param1) where T1: IMyInterface, new()
		{
			return new T1();
		}
	}

	public class MyGenericType<TObject, TMyInterface, TBaseClass> 
		where TObject : class, new() 
		where TMyInterface : IMyInterface
		where TBaseClass : BaseClass
	{
		public TObject SomeValue { get; set; }

		public TMyInterface SomeMethod(TBaseClass x)
		{
			TObject y = new TObject();

			throw new NotImplementedException();
		}
	}
}
