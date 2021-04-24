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



            
            JSON j = new JSON(@"{""k1"": ""Value"",""k2"":
            true,""k3"":null,""k4"":false,""k5"":
            [1,55,-3,""meow"",[null, {""younes"": null, ""abdul"": [1,2,3]}],{""Abdullah"": ""Is Awesome!"",""And"": 18,""Wa"": null}],""key6"":
            {""key7"": {""key8"":
            1}}}");

            System.Console.WriteLine(j.Indent());
            System.Console.WriteLine(j);

        }
    }
}