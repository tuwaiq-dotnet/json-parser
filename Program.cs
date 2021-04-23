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
    class Program
    {
        // Driver method
        static void Main(string[] args)
        {
            // Utilities.run();
            try
            {
                Input input = new Input("\r");
                Tokenizer t = new Tokenizer(input, new Tokenizable[]
                {
                    new StringHandler(),
                    new WhitespaceHandler(),
                    new NumberHandler()
                });
                Token token = new Token();
                List<Token> tokens = new List<Token>();
                while (token != null)
                {
                    token = t.tokenize();
                    if (token != null)
                        tokens.Add(token);
                }

                if (!input.isConsumed())
                {
                    tokens = null;
                    throw new Exception($"Unexpected token encountered at Ln {input.LineNumber} Col {input.Position + 1}");
                }

                Utilities.printTokens(tokens);
            }
            catch (Exception error)
            {
                // Console.WriteLine(error.Message);
                Utilities.error(error.Message);
            }
        }
    }
}