/*
 * Tuwaiq .NET Bootcamp
 * 
 * Authors
 * 
 *  Younes Alturkey
 *  Abdulrahman Bin Maneea
 *  Abdullah Albagshi
 *  Ibrahim Alobaysi
 */
using System;

namespace JSONParser
{
	public class JNumber : Value
	{
		Token token;
		public JNumber(Token token)
		{
			this.token = token;
		}

		public override string ToString()
		{
			return token.Value;
		}

		public override JSONMemberType getType()
		{
			return JSONMemberType.Number;
		}

		public override JNumber getNumber()
		{
			return this;
		}

		public override string Indent(uint indentation = 0)
		{
			return this.ToString();
		}

		public override Value ConsoleColorization(int indentation = 0)
		{
			Console.ResetColor();
			Console.ForegroundColor = ConsoleColor.DarkMagenta;
			Console.Write(this);
			Console.ResetColor();
			return this;
		}
	}
}