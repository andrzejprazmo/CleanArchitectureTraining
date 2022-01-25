using System;

namespace Chapter3Sample1App
{
	class Program
	{
		static void Main(string[] args)
		{
            // Inicjalizacja
            Console.Clear();

            // Petla główna programu
            while (true)
            {
                Console.WriteLine("Witamy w naszej aplikacji");
                Console.WriteLine("Naciśnij klawisz 'Q', żeby zobaczyć efekt.");
                Console.WriteLine("Naciśnij klawisz 'W', żeby zobaczyć efekt.");
                Console.WriteLine("Naciśnij klawisz 'Esc', żeby zakończyć.");

                var keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    break;
                }
				if (keyInfo.KeyChar == 'q')
				{
                    Console.WriteLine("Naciśnąłeś klawisz 'Q'");
                }
                if (keyInfo.KeyChar == 'w')
                {
                    Console.WriteLine("Naciśnąłeś klawisz 'W'");
                }
            }
        }
	}
}
