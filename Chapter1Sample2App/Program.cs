using System;

namespace Chapter1Sample2App
{
	class Program
	{
		static void Main(string[] args)
		{
			#region Generator
			RandomGenerator generator = new RandomGenerator();
			
			string result = generator.RollTheDice(generatedNumber => generatedNumber == 6 ? "Hurra!" : $"Wylosowano liczbę: {generatedNumber}");

			Action<int> foo = Foo;


			
			Console.WriteLine(result);
			#endregion


			Console.ReadKey();
		}

		static string DisplayMyMessage(int generatedNumber)
		{
			if (generatedNumber == 6)
			{
				return "Hurra!";
			}
			return $"Wylosowano liczbę: {generatedNumber}";

		}

		static void Foo(int x)
		{

		}

		static bool Bar(int x, decimal y)
		{
			return true;
		}
	}
}
