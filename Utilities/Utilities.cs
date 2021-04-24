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
using System.Threading.Tasks;

namespace JSONParser
{
    public class Utilities
    {
        public static void run()
        {
            System.Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Clear();
            setConsoleForegroundColor(ConsoleColor.Blue);
            Console.WriteLine("JSONParser CLI © 2021: version 1.0.0(1)-release");
            Console.WriteLine("The CLI provides commands to parse a JSON string into JSON object");
            Console.WriteLine("These commands are defined internally\n\ttype 'help' to see this list \n\ttype 'quit' to exit the CLI");
            Console.WriteLine("\nBy Tuwaiq .NET Bootcamp Trainees\n\tAbdulrahman Bin Maneea (@AWManeea)\n\tYounes Alturkey (@YounesAlturkey)\n\tAbdullah Albagshi (@A-Albagshi)\n\tIbrahim Alobaysi (@ibra0022)");
            resetConsoleForegroundColor();
        }

        public static void error(string errorMessage)
        {
            setConsoleForegroundColor(ConsoleColor.Red);
            Console.Beep(); // I'm sorry
            Console.WriteLine("JSONParser ERROR: {0}", errorMessage);
            resetConsoleForegroundColor();
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
            Console.WriteLine(" to the current dirctory.");
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