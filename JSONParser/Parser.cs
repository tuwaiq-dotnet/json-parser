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
	public class Parser
	{
		private Tokenizer tokenizer;
		public Parser(Tokenizer tokenizer)
		{
			this.tokenizer = tokenizer;
		}

		public Value ParseNextType()
		{
			Token token = this.SkipWhiteSpace();
			if (token == null)
				return null;
			switch (token.Type)
			{
				case TokenType.OpeningBracket:
					return this.ParseArray();
				case TokenType.OpeningCurlyBracket:
					return this.ParseObject();
				case TokenType.String:
					return new JString(token);
				case TokenType.Number:
					return new JNumber(token);
				case TokenType.True:
					return new JTrue(token);
				case TokenType.False:
					return new JFalse(token);
				case TokenType.Null:
					return new JNull(token);
			}

			throw new Exception($@"Unexpected token ""{token.Value}"" at position {token.Position} (Line: {token.LineNumber})");
		}

		private JObject ParseObject()
		{
			JObject obj = new JObject();
			Token token = this.SkipWhiteSpace();
			bool firstElement = true;
			while (token.Type != TokenType.ClosingCurlyBracket)
			{
				if (token.Type == TokenType.String)
				{
					obj.Items.Add(ParseKeyValue(token));
					firstElement = false;
				}
				else if (token.Type != TokenType.Comma || firstElement)
					throw new Exception($@"Unexpected token ""{token.Value}"" at position {token.Position} (Line: {token.LineNumber})");
				token = this.SkipWhiteSpace();
				if (token == null)
					throw new Exception($@"EOF reached before closing a JSON object (Missing a curly bracket)");
			}

			return obj;
		}

		private JKeyValue ParseKeyValue(Token key)
		{
			Token token;
			do
			{
				token = tokenizer.tokenize();
				if (token == null)
					throw new Exception($"Either EOF reached or a weird token was encountered while expecting a colon");
			}
			while (token.Type == TokenType.Whitespace);
			if (token.Type != TokenType.Colon)
				throw new Exception($@"Unexpected token ""{key.Value}"" at position {key.Position}, line {key.LineNumber} (Expected a colon)");
			Value value = this.ParseNextType();
			if (value == null)
				throw new Exception($@"Either EOF reached or a weird token was encountered while expecting a JSON data type");
			return new JKeyValue(key, value);
		}

		private JArray ParseArray()
		{
			JArray arr = new JArray();
			while (true)
			{
				arr.Items.Add(this.ParseNextType());
				Token token = this.SkipWhiteSpace();
				if (token == null)
					throw new Exception("Either EOF reached or a weird token was encountered while expecting a JSON data type");
				else if (token.Type == TokenType.Comma)
					continue;
				else if (token.Type == TokenType.ClosingBracket)
					break;
				else
					throw new Exception($@"Unexpected token ""{token.Value}"" at position {token.Position}, line {token.LineNumber} (Expected a colon)");
			}

			return arr;
		}

		private Token SkipWhiteSpace()
		{
			Token token;
			do
			{
				token = this.tokenizer.tokenize();
				if (token == null)
				{
					return null;
				}
			}
			while (token.Type == TokenType.Whitespace);
			return token;
		}
	}
}