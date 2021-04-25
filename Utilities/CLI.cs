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
using System.IO;

namespace JSONParser
{
    public class CLI
    {
        public static void run()
        {
            System.Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Clear();
            setConsoleForegroundColor(ConsoleColor.Blue);
            Console.WriteLine(@"       _  _____  ____  _   _ _____                            _____ _      _____ 
      | |/ ____|/ __ \| \ | |  __ \                          / ____| |    |_   _|
      | | (___ | |  | |  \| | |__) |_ _ _ __ ___  ___ _ __  | |    | |      | |  
  _   | |\___ \| |  | | . ` |  ___/ _` | '__/ __|/ _ \ '__| | |    | |      | |  
 | |__| |____) | |__| | |\  | |  | (_| | |  \__ \  __/ |    | |____| |____ _| |_ 
  \____/|_____/ \____/|_| \_|_|   \__,_|_|  |___/\___|_|     \_____|______|_____|
                                                                                 
                                                                                 ");
            Console.WriteLine("Version 1.0.0(1)-alpha");
            Console.WriteLine("The CLI provides commands to parse a JSON string into JSON object and generate JSON file");
            Console.WriteLine("These commands are defined internally\n\ttype 'help' to see this list \n\ttype 'quit' to exit the CLI");
            resetConsoleForegroundColor();
            string command;
            do
            {
                Console.Write("\nPlease, type a command or 'help' to list see of commands\n> ");
                command = Console.ReadLine();
                if (command.ToLower().Equals("help"))
                {
                    setConsoleForegroundColor(ConsoleColor.Blue);
                    Console.Write("\n--------------------------Main Menu--------------------------");
                    Console.Write("\nJSONParser offers ");
                    setConsoleForegroundColor(ConsoleColor.Magenta);
                    Console.Write("1 JSON Tokenizer ");
                    setConsoleForegroundColor(ConsoleColor.Blue);
                    Console.Write("and ");
                    setConsoleForegroundColor(ConsoleColor.Yellow);
                    Console.Write("2 JSON Parsers");
                    setConsoleForegroundColor(ConsoleColor.Blue);
                    Console.WriteLine("\n\nWhat is the difference between parsers you might wonder?");
                    Console.Write("\tJSONParser ");
                    setConsoleForegroundColor(ConsoleColor.DarkGreen);
                    Console.Write("100% ");
                    setConsoleForegroundColor(ConsoleColor.Blue);
                    Console.Write("of the time works everytime\n");
                    Console.Write("\tFMBParser ");
                    setConsoleForegroundColor(ConsoleColor.DarkYellow);
                    Console.Write("98% ");
                    setConsoleForegroundColor(ConsoleColor.Blue);
                    Console.Write("of the time works everytime\n");
                    setConsoleForegroundColor(ConsoleColor.Blue);
                    Console.Write("\n\ttype '1' to select JSONParser with default Tokenizer\n\ttype '2' to select FMBParser with default Tokenizer\n\ttype 'quit' to exit the CLI\n");
                    resetConsoleForegroundColor();
                }
                else if (command.ToLower().Equals("1"))
                {
                    do
                    {
                        setConsoleForegroundColor(ConsoleColor.Blue);
                        Console.Write("\n--------------------------JSONParser--------------------------");
                        setConsoleForegroundColor(ConsoleColor.Green);
                        Console.Write("\n> JSONParser with default Tokenizer selected\n");
                        setConsoleForegroundColor(ConsoleColor.Blue);
                        Console.Write("\n\ttype '1' to run predefined test case\n\ttype '2' to enter a JSON string\n\ttype 'back' to return to main menu\n\ttype 'quit' to exit the CLI\n");
                        resetConsoleForegroundColor();
                        Console.Write("\nPlease, type a command\n> ");
                        command = Console.ReadLine();
                        Console.WriteLine();
                        string testInput;
                        if (command.ToLower().Equals("1"))
                        {
                            testInput = @"{""k1"": ""Value"",""k2"": true,""k3"":null,""k4"":false,""k5"": [1,55,-3,""meow"",[null, {""younes"": null, ""abdul"": [1,2,3]}],{""Abdullah"": ""Is Awesome!"",""And"": 18,""Wa"": null}],""key6"": {""key7"": {""key8"": 1}}}";
                            Console.Write("Test Case Input: ");
                            setConsoleForegroundColor(ConsoleColor.DarkYellow);
                            Console.Write(testInput);
                            Console.WriteLine();
                            runJSONParserWithDefaultTokenizer(testInput);
                        }
                        else if (command.ToLower().Equals("2"))
                        {
                            resetConsoleForegroundColor();
                            Console.Write("Please, enter JSON string\n> ");
                            testInput = Console.ReadLine();
                            Console.WriteLine();
                            runJSONParserWithDefaultTokenizer(testInput);
                        }
                    }
                    while (command.ToLower() != "back" && command.ToLower() != "quit");
                }
                else if (command.ToLower().Equals("2"))
                {
                    do
                    {
                        setConsoleForegroundColor(ConsoleColor.Blue);
                        Console.Write("\n--------------------------FMBParser--------------------------");
                        setConsoleForegroundColor(ConsoleColor.Green);
                        Console.Write("\n> FMBParser with default Tokenizer selected\n");
                        setConsoleForegroundColor(ConsoleColor.Blue);
                        Console.Write("\n\ttype '1' to run predefined test case\n\ttype '2' to enter a JSON string\n\ttype 'back' to return to main menu\n\ttype 'quit' to exit the CLI\n");
                        resetConsoleForegroundColor();
                        Console.Write("\nPlease, type a command\n> ");
                        command = Console.ReadLine();
                        Console.WriteLine();
                        string testInput;
                        if (command.ToLower().Equals("1"))
                        {
                            testInput = @"{""younes"": 123, ""obj"": {""ids"": 123, ""age"": 25, ""isFire"": null}, ""id"": [""stromg"", 123, true, false, null, {""please"": ""wrok""}, [1,2, [1, 2, 3], 3,4]], ""obj2"": {""younes"": ""this actually works"", ""holy"": ""shit"", ""nowaythisis"": ""stupid"", ""arr"": [""somesd"", 12e-5, ""hjaja"", null]}, ""cool"": [1,2, [true, false], 3,4]}";
                            Console.Write("Test Case Input: ");
                            setConsoleForegroundColor(ConsoleColor.DarkYellow);
                            Console.Write(testInput);
                            Console.WriteLine();
                            runFMBParserWithDefaultTokenizer(testInput);
                        }
                        else if (command.ToLower().Equals("2"))
                        {
                            resetConsoleForegroundColor();
                            Console.Write("Please, enter JSON string\n> ");
                            testInput = Console.ReadLine();
                            Console.WriteLine();
                            runFMBParserWithDefaultTokenizer(testInput);
                        }
                    }
                    while (command.ToLower() != "back" && command.ToLower() != "quit");
                }
            }
            while (command.ToLower() != "quit");
            setConsoleForegroundColor(ConsoleColor.Green);
            Console.WriteLine("\nJSONParser CLI Exit Code: 0");
            setConsoleForegroundColor(ConsoleColor.Blue);
            Console.WriteLine("\nJSONParser CLI © 2021: version 1.0.0(1)-alpha");
            Console.Write("\nThank You! Don't forget to check out your file.");
            setConsoleForegroundColor(ConsoleColor.Yellow);
            Console.Write("\n\n\toutput.json\n\n");
            setConsoleForegroundColor(ConsoleColor.Blue);
            Console.WriteLine("By Trainees of Tuwaiq .NET Bootcamp");
            setConsoleForegroundColor(ConsoleColor.DarkBlue);
            Console.WriteLine("Abdulrahman Bin Maneea (@AWManeea)\nYounes Alturkey (@younes-alturkey)\nAbdullah Albagshi (@A-Albagshi)\nIbrahim Alobaysi (@ibra0022)");
            resetConsoleForegroundColor();
        }

        public static void runJSONParserWithDefaultTokenizer(string input)
        {
            List<Token> tokens = CLI.tokenize(input);
            CLI.printTokens(tokens);
            JSON json = new JSON(input);
            string jsonString = json.ToString();
            CLI.setConsoleForegroundColor(ConsoleColor.Blue);
            Console.WriteLine("\nStarting the Parsing Process");
            Console.WriteLine("Parsing tokens...");
            CLI.setConsoleForegroundColor(ConsoleColor.Green);
            Console.WriteLine("Parsing Complete!");
            Console.Write("New object ");
            CLI.setConsoleForegroundColor(ConsoleColor.Yellow);
            Console.Write("json ");
            CLI.setConsoleForegroundColor(ConsoleColor.Green);
            Console.Write("of type ");
            CLI.setConsoleForegroundColor(ConsoleColor.Yellow);
            Console.Write("JSON ");
            CLI.setConsoleForegroundColor(ConsoleColor.Green);
            Console.Write("created\n");
            CLI.setConsoleForegroundColor(ConsoleColor.Blue);
            Console.WriteLine("Outputing JSON object...\n");
            CLI.setConsoleForegroundColor(ConsoleColor.DarkYellow);
            Console.WriteLine("Stringifying JSON object...\n");
            Console.WriteLine(jsonString);
            toJSON(jsonString);
        }

        public static void runFMBParserWithDefaultTokenizer(string input)
        {
            List<Token> tokens = CLI.tokenize(input);
            CLI.printTokens(tokens);
            JSONDict json = new JSONDict(tokens);
            CLI.setConsoleForegroundColor(ConsoleColor.Blue);
            Console.WriteLine("\nStarting the Parsing Process");
            Console.WriteLine("Parsing tokens...");
            CLI.setConsoleForegroundColor(ConsoleColor.Green);
            Console.WriteLine("Parsing Complete!");
            Console.Write("New object ");
            CLI.setConsoleForegroundColor(ConsoleColor.Yellow);
            Console.Write("json ");
            CLI.setConsoleForegroundColor(ConsoleColor.Green);
            Console.Write("of type ");
            CLI.setConsoleForegroundColor(ConsoleColor.Yellow);
            Console.Write("JSONDict ");
            CLI.setConsoleForegroundColor(ConsoleColor.Green);
            Console.Write("created\n");
            CLI.setConsoleForegroundColor(ConsoleColor.Blue);
            Console.WriteLine("Outputing JSON object...\n");
            CLI.setConsoleForegroundColor(ConsoleColor.DarkYellow);
            Console.WriteLine("Stringifying JSON object...\n");
            json.print();
            CLI.toJSON(json.ToString());
        }

        public static void error(string errorMessage)
        {
            setConsoleForegroundColor(ConsoleColor.Red);
            Console.Beep();
            Console.WriteLine("JSONParser ERROR: {0}", errorMessage);
            Console.WriteLine("JSONParser CLI Exit Code: 1");
            resetConsoleForegroundColor();
        }

        public static List<Token> tokenize(string source)
        {
            Input input = new Input(source);
            Tokenizer t = new Tokenizer(input, new Tokenizable[] { new StringHandler(), new WhitespaceHandler(), new NumberHandler(), new SingleWordHandler(), new SingleCharHandler() });
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

            return tokens;
        }

        public static void printTokens(List<Token> tokens)
        {
            setConsoleForegroundColor(ConsoleColor.Blue);
            Console.WriteLine("\nStarting the Tokenization Process");
            Console.WriteLine("Tokenizing...");
            setConsoleForegroundColor(ConsoleColor.Green);
            Console.WriteLine("Tokenization Complete!");
            setConsoleForegroundColor(ConsoleColor.Blue);
            Console.WriteLine($"\n{"Token",-30}Type");
            setConsoleForegroundColor(ConsoleColor.DarkMagenta);
            foreach (var tkn in tokens)
            {
                setConsoleForegroundColor(ConsoleColor.Green);
                Console.Write($"{tkn.Value,-30}");
                setConsoleForegroundColor(ConsoleColor.White);
                Console.WriteLine($"{tkn.Type}");
            }

            resetConsoleForegroundColor();
        }

        public static void toJSON(string json)
        {
            File.WriteAllTextAsync("output.json", json);
            setConsoleForegroundColor(ConsoleColor.Blue);
            Console.Write("\nSuccessfully generated ");
            setConsoleForegroundColor(ConsoleColor.DarkYellow);
            Console.Write("output.json");
            setConsoleForegroundColor(ConsoleColor.Blue);
            Console.WriteLine(" to the current directory.");
            resetConsoleForegroundColor();
        }

        public static void setConsoleForegroundColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }

        public static void resetConsoleForegroundColor()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}