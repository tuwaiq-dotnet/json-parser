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
using System.Collections.Generic;

namespace JSONParser
{
    public class SingleWordHandler : Tokenizable
    {
        private List<string> keywords;
        public SingleWordHandler()
        {
        }

        public SingleWordHandler(List<string> keywords)
        {
            this.keywords = keywords;
        }

        public override bool tokenizable(Input input)
        {
            string peekedWord = "" + input.lookAhead() + input.lookAhead(1) + input.lookAhead(2) + input.lookAhead(3);
            char fifthCharacter = input.lookAhead(4);
            char sixthCharacter = input.lookAhead(5);
            return isNull(peekedWord, fifthCharacter) || isTrue(peekedWord, fifthCharacter) || isFalse(peekedWord += fifthCharacter, sixthCharacter);
        }

        static bool isNull(string word, char c)
        {
            return word == "null" && !Char.IsLetterOrDigit(c);
        }

        static bool isTrue(string word, char c)
        {
            return word == "true" && !Char.IsLetterOrDigit(c);
        }

        static bool isFalse(string word, char c)
        {
            return word == "false" && !Char.IsLetterOrDigit(c);
        }

        public override Token tokenize(Input input)
        {
            string word = "" + input.step().Character + input.step().Character + input.step().Character + input.step().Character;
            if (word == "null")
                return new Token(input.Position, input.LineNumber, TokenType.Null, word);
            else if (word == "true")
                return new Token(input.Position, input.LineNumber, TokenType.True, word);
            else
                return new Token(input.Position, input.LineNumber, TokenType.False, word += input.step().Character);
        }
    }
}