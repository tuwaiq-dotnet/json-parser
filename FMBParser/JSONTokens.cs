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
	public class JSONTokens
	{
		private readonly List<Token> tokens;
		private readonly int count;
		private int position;
		public int Count
		{
			get
			{
				return this.count;
			}
		}

		public int Position
		{
			get
			{
				return this.position;
			}
		}

		public int NextPosition
		{
			get
			{
				return this.position + 1;
			}
		}

		public Token Token
		{
			get
			{
				if (this.position > -1)
					return this.tokens[this.position];
				else
					return null;
			}
		}

		public JSONTokens(List<Token> tokens)
		{
			if (tokens.Count == 0)
				throw new Exception("empty list is not allowed");
			this.tokens = tokens;
			this.count = tokens.Count;
			this.position = -1;
		}

		public bool hasMore(int numOfSteps = 1)
		{
			if (numOfSteps <= 0)
				throw new Exception("Invalid number of steps");
			int t = (this.position + numOfSteps);
			return 0 <= t && t < this.Count;
		}

		public bool hasLess(int numOfSteps = 1)
		{
			if (numOfSteps <= 0)
				throw new Exception("Invalid number of steps");
			return (this.position - numOfSteps) > -1;
		}

		public Token step(int numOfSteps = 1)
		{
			if (this.hasMore(numOfSteps))
				this.position += numOfSteps;
			else
			{
				throw new Exception("There is no more step");
			}

			return this.tokens[this.Position];
		}

		public Token back(int numOfSteps = 1)
		{
			if (this.hasLess(numOfSteps))
				this.position -= numOfSteps;
			else
			{
				throw new Exception("There is no more step");
			}

			return this.tokens[this.position];
		}

		public JSONTokens reset()
		{
			this.position = -1;
			return this;
		}

		public Token peek(int numOfSteps = 1)
		{
			if (this.hasMore())
				return this.tokens[this.NextPosition];
			return null;
		}

		public Token lookAhead(int numOfSteps = 0)
		{
			int distance = this.NextPosition + numOfSteps;
			if (this.hasMore() && distance < this.Count)
				return this.tokens[distance];
			return null;
		}

		public bool isConsumed()
		{
			return Position == Count - 1;
		}
	}
}