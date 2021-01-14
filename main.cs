using System;
using System.Collections.Generic;

namespace Learn_Colemak
{
	class main
	{
		static void Main(string[] args)
		{
			int numCorrect = 0;
			int numIncorrect = 0;
			char currentChar = ' ';
			List<char> charList = new List<char> {};
			char currentCorrectChar = args[new Random().Next(args.Length)][0];
			ConsoleKeyInfo currentKey = new ConsoleKeyInfo();
			for (int i = 0; i < 10; i++) {
				charList.Add(args[new Random().Next(args.Length)][0]);
			}
			Console.WriteLine("Ready: ");
			while (currentKey.Key != ConsoleKey.Escape) {
				currentChar = ' ';
				charList.RemoveAt(0);
				charList.Add(args[new Random().Next(args.Length)][0]);
				currentCorrectChar = charList[0];
				while (currentKey.Key != ConsoleKey.Escape && currentChar != currentCorrectChar) {
					Console.Clear();
					Console.WriteLine($"Correct: {numCorrect}  Incorrect: {numIncorrect}");
					foreach (char futureCorrectChar in charList){
						Console.Write(futureCorrectChar + " ");
					}
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
