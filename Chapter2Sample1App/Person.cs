using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter2Sample1App
{
    public interface IEntity
    {
        int Id { get; set; }
    }

    public class EntityBase
    {

    }

    public class Person : EntityBase, IEntity
    {
        public Person()
        {

        }

        public Person(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetFullName(string format)
        {
            if (format == "H")
            {
                return $"{LastName}, {FirstName}";
            }
            return $"{FirstName} {LastName}";
        }
    }
}
