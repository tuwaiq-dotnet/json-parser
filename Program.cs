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
using System.Diagnostics;
using System.IO;

namespace JSONParser
{
    class Program
    {
        // Driver method
        static void Main(string[] args)
        {
            Utilities.run();
            try
            {
                Input input = new Input(@"{""younes"": 123, ""obj"": {""ids"": 123, ""age"": 25, ""isFire"": null}, ""id"": [""stromg"", 123, true, false, null, {""please"": ""wrok""}, [1,2, [1, 2, 3], 3,4]], ""obj2"": {""younes"": ""this actually works"", ""holy"": ""shit"", ""thisis"": ""stupid"", ""arr"": [""somesd"", 12e-5, ""hjaja"", null]}, ""cool"": [1,2, [true, false], 3,4]}");
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
                    throw new Exception($"Unexpected token encountered at Ln { input.LineNumber } Col { input.Position + 1}");
                }

                Utilities.printTokens(tokens);

                JSON json = new JSON(tokens);
                Utilities.setConsoleForegroundColor(ConsoleColor.Blue);
                Console.WriteLine("\nStarting the Parsing Process");
                Console.WriteLine("Parsing tokens...");
                Utilities.setConsoleForegroundColor(ConsoleColor.Green);
                Console.WriteLine("Parsing Complete!");
                Utilities.setConsoleForegroundColor(ConsoleColor.Blue);
                Console.WriteLine("Printing Parsed JSON...\n");
                Utilities.setConsoleForegroundColor(ConsoleColor.DarkYellow);
                Console.WriteLine("Parsed JSON String\n");

                json.print();

                // Console.WriteLine(json.getValue("obj2"));

                Utilities.toJSON(json.ToString());
            }
            catch (Exception error)
            {
                // Console.WriteLine(error.Message);
                Utilities.error(error.Message);
            }
        }
    }
}