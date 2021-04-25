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

namespace JSONParser
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				CLI.run();
			}
			catch (Exception error)
			{
				CLI.error(error.Message);
			}
		}
	}
}