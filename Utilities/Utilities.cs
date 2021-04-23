/*
 * Tuwaiq .NET Bootcamp | JSON Parser
 * 
 * Team Members
 * Abdulrahman Bin Maneea (Team Lead)
 * Younes Alturkey
 * Abdullah Albagshi
 * Ibrahim Alobaysi
 */
using System;
using System.Collections.Generic;

namespace JSONParser
{
	public class Utilities
	{
		public static void run()
		{
			System.Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.Clear();
			setConsoleForegroundColor(ConsoleColor.Blue);
			Console.WriteLine("JSONParser CLI © 2021: version 1.0.0(1)-release");
			Console.WriteLine("The CLI provides commands to parse a JSON string into JSON object");
			Console.WriteLine("These commands are defined internally\n\ttype 'help' to see this list \n\ttype 'quit' to exit the CLI");
			Console.WriteLine("\nBy Tuwaiq .NET Bootcamp Trainees\n\tAbdulrahman Bin Maneea (@AWManeea)\n\tYounes Alturkey (@YounesAlturkey)\n\tAbdullah Albagshi (@A-Albagshi)\n\tIbrahim Alobaysi (@ibra0022)");
			resetConsoleForegroundColor();
		}

		public static void error(string errorMessage)
		{
			setConsoleForegroundColor(ConsoleColor.Red);
			Console.Beep(); // I'm sorry
			Console.WriteLine("JSONParser: {0}", errorMessage);
			resetConsoleForegroundColor();
		}

		public static void printTokens(List<Token> tokens)
		{
			Console.WriteLine($"{"Token", -30}Type");
			foreach (var tkn in tokens)
			{
				Console.WriteLine($"{tkn.Value, -30}{tkn.Type}");
			}
		}

		public static void setConsoleForegroundColor(ConsoleColor color)
		{
			Console.ForegroundColor = color;
		}

		public static void resetConsoleForegroundColor()
		{
			Console.ForegroundColor = ConsoleColor.White;
		}
	}
}