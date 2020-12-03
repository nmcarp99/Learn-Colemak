using System;

namespace Learn_Colemak
{
	class main
	{
		static void Main(string[] args)
		{
			int numCorrect = 0;
			int numIncorrect = 0;
			char currentChar = ' ';
			char currentCorrectChar = args[new Random().Next(args.Length)][0];
			ConsoleKeyInfo currentKey = new ConsoleKeyInfo();
			Console.WriteLine("Ready: ");
			while (currentKey.Key != ConsoleKey.Escape) {
				currentChar = ' ';
				currentCorrectChar = args[new Random().Next(args.Length)][0];
				while (currentKey.Key != ConsoleKey.Escape && currentChar != currentCorrectChar) {
					Console.Clear();
					Console.WriteLine($"Correct: {numCorrect}  Incorrect: {numIncorrect}\n{currentCorrectChar}");
					currentKey = Console.ReadKey();
					currentChar = currentKey.KeyChar;
					if (currentChar == currentCorrectChar) {
						numCorrect++;
					} else {
						numIncorrect++;
					}
				}
			}
		}
	}
}
