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
	public class Tokenizer
	{
		public List<Token> tokens;
		public bool enableHistory;
		public Input input;
		public ITokenizable[] handlers;
		public Tokenizer(string source, ITokenizable[] handlers)
		{
			this.input = new Input(source);
			this.handlers = handlers;
		}

		public Tokenizer(Input source, ITokenizable[] handlers)
		{
			this.input = source;
			this.handlers = handlers;
		}

		public Token tokenize()
		{
			foreach (var handler in this.handlers)
				if (handler.tokenizable(this.input))
					return handler.tokenize(this.input);
			return null;
		}

		public List<Token> all()
		{
			return null;
		}
	}
}