using System;
using System.Collections.Generic;

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

namespace JSONParser
{
    public class Tokenizer
    {
        public Input input;
        public Tokenizable[] handlers;
        public Tokenizer(Input input, Tokenizable[] handlers)
        {
            this.input = input;
            this.handlers = handlers;
        }
        public Token tokenize()
        {
            foreach (var handler in this.handlers)
                if (handler.tokenizable(this.input)) return handler.tokenize(this.input);
            return null;
        }
    }
}
