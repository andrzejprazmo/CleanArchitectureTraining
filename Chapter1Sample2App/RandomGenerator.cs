using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter1Sample2App
{
	public class RandomGenerator
	{
		public string RollTheDice()
		{
			Random random = new Random();
			int generatedNumber = random.Next(1, 6);

			return $"Wylosowano liczbę: {generatedNumber}";
		}

		public string GenerateNumber(int from, int to)
		{
			Random random = new Random();
			int generatedNumber = random.Next(from, to);

			return $"Wylosowano liczbę: {generatedNumber}";
		}
	}
}
