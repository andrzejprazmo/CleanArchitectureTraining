using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter1Sample2App
{
	//public delegate string RollTheDiceAction(int generatedNumber);
	public class RandomGenerator
	{
		public string RollTheDice(Func<int, string> action)
		{
			Random random = new Random();
			int generatedNumber = random.Next(1, 6);
			if (action != null)
			{
				return action(generatedNumber);
			}
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
