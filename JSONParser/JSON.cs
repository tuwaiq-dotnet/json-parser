using System.Collections.Generic;
using System;
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
    public class JSON
    {
        private Value root;
        private int elements;
        private Tokenizer tokenizer;

        
        public Value Root { get { return root; } }
        public uint Elements { get { return root.Children; } }

        public JSON(string source)
        {
            tokenizer = new Tokenizer(new Input(source), new Tokenizable[]{
                new WhitespaceHandler(),
                new StringHandler(),
                new NumberHandler(),
                new SingleWordHandler(),
                new SingleCharHandler(),
            });

            Parser parser = new Parser(tokenizer);
            root = parser.ParseNextType();

            Value tmp = parser.ParseNextType();
            if (tmp != null) throw new Exception("More than one root exists!");
        }

        public override string ToString()
        {
            return root.ToString();
        }

        public string Indent()
        {
            return this.Root.Indent(0);
        }

        public string Inspect(){
            return ""; // TODO: implement
        }
    }
}