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
	public class JSON
	{
		private Value root;
		private Tokenizer tokenizer;
		public Value Root
		{
			get
			{
				return root;
			}
		}

		public uint Elements
		{
			get
			{
				return root.Children;
			}
		}

		public JSON(string source)
		{
			tokenizer = new Tokenizer(new Input(source), new Tokenizable[]{new WhitespaceHandler(), new StringHandler(), new NumberHandler(), new SingleWordHandler(), new SingleCharHandler(), });
			Parser parser = new Parser(tokenizer);
			root = parser.ParseNextType();
			Value tmp = parser.ParseNextType();
			if (tmp != null)
				throw new Exception("More than one root exists!");
		}

		public override string ToString()
		{
			return root.ToString();
		}

		public string Indent()
		{
			return this.Root.Indent(0);
		}

		public JSON ConsoleColorization()
		{
			this.Root.ConsoleColorization(0);
			return this;
		}

		public string Inspect()
		{
			return ""; // TODO: implement
		}
	}
}