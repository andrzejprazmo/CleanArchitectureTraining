using System;

namespace Chapter2Sample2App
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassPresenter classPresenter = new ClassPresenter();

            //ExternalCar externalCar = new ExternalCar();
            //externalCar.Producer = "Mercedes";
            //externalCar.Model = "A200";
            //externalCar.Year = 2016;
            //InternalCar internalCar = new InternalCar();

            //SimplyMapper mapper = new SimplyMapper();
            //mapper.Map(externalCar, internalCar);

            //InternalCar internalCarSecond = mapper.Map<InternalCar>(externalCar);

            //classPresenter.DisplayProperties(internalCarSecond);


            Person person = new Person();
            person.FirstName = "Jan";
            person.LastName = "Kowalski";
            
            classPresenter.DisplayProperties(person);
            
            Console.ReadKey();
        }
    }

    public class ExternalCar
    {
        public string Producer { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }

    public class InternalCar
    {
        public string Producer { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }

    public class Person
    {
        [FamiliarName("Imię")]
        public string FirstName { get; set; }

        [FamiliarName("Nazwisko")]
        public string LastName { get; set; }
    }

    public class FamiliarNameAttribute : Attribute
    {
        public string Name { get; set; }

        public FamiliarNameAttribute(string name)
        {
            Name = name;
        }
    }
}
