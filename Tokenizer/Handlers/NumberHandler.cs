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
	/*
     * JSON numbers follow JavaScript’s double-precision floating-point format
     * {
     *   "number_1" : 210,
     *   "number_2" : -210,
     *   "number_3" : 21.05,
     *   "number_4" : 1.0E+2
     * }
     */
	public class NumberHandler : Tokenizable
	{
		static protected bool readDot = false;
		static protected bool readNegative = false;
		static protected bool readExponent = false;
		static protected bool readExponentSign = false;
		public override bool tokenizable(Input input)
		{
			rest();
			char currentCharacter = input.peek();
			char nextCharacter = input.lookAhead(1);
			return Char.IsDigit(currentCharacter) || (currentCharacter == '-' && Char.IsDigit(nextCharacter));
		}

		static bool isJSONNumber(Input input)
		{
			char currentCharacter = input.peek();
			char nextCharacter = input.lookAhead(1);
			return Char.IsDigit(currentCharacter) || isDot(currentCharacter, nextCharacter) || isNegative(currentCharacter, nextCharacter) || isExponent(currentCharacter, nextCharacter) || isExponentSign(currentCharacter, nextCharacter);
		}

		static bool isDot(char currentC, char nextC)
		{
			if (currentC == '.' && !readDot && Char.IsDigit(nextC))
			{
				readDot = true;
				return true;
			}

			return false;
		}

		static bool isNegative(char currentC, char nextC)
		{
			if (currentC == '-' && !readNegative && Char.IsDigit(nextC))
			{
				readNegative = true;
				return true;
			}

			return false;
		}

		static bool isExponent(char currentC, char nextC)
		{
			if (Char.ToLower(currentC) == 'e' && !readExponent && (Char.IsDigit(nextC) || nextC == '+' || nextC == '-'))
			{
				readExponent = true;
				return true;
			}

			return false;
		}

		static bool isExponentSign(char currentC, char nextC)
		{
			if ((currentC == '-' || currentC == '+') && readExponent && !readExponentSign && Char.IsDigit(nextC))
			{
				readExponentSign = true;
				return true;
			}

			return false;
		}

		public void rest()
		{
			readDot = false;
			readNegative = false;
			readExponent = false;
			readExponentSign = false;
		}

		public override Token tokenize(Input input)
		{
			return new Token(input.Position, input.LineNumber, TokenType.Number, input.loop(isJSONNumber));
		}
	}
}