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



            
            JSON j = new JSON(@"{""k1"": ""Value"",""k2"": true,""k3"":null,""k4"":false,""k5"": [1,55,-3,""meow"",[null, {""younes"": null, ""abdul"": [1,2,3]}],{""Abdullah"": ""Is Awesome!"",""And"": 18,""Wa"": null}],""key6"": {""key7"": {""key8"": 
            1}}} ");
            // System.Console.WriteLine(j);
            System.Console.WriteLine(j.Indent());
            





            Environment.Exit(0);


            // Utilities.run();
            try
            {
                Input input = new Input(" : ,, { }: [[] ]] true false null 3443 -23 23e+3 \"dwoidjoqijdooqdj\"");
                Tokenizer t = new Tokenizer(input, new Tokenizable[]
                {
                    new StringHandler(),
                    new WhitespaceHandler(),
                    new NumberHandler(),
                    new SingleWordHandler(),
                    new SingleCharHandler()
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