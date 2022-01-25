using System;

namespace Chapter1Sample2App
{
	class Program
	{
		static void Main(string[] args)
		{
			#region Generator
			RandomGenerator generator = new RandomGenerator();
			string result = generator.RollTheDice();
			
			Console.WriteLine(result);
			#endregion


			Console.ReadKey();
		}
	}
}
