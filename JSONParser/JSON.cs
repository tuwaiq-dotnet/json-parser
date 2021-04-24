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
    public class JSON
    {
        private Value root;
        private int elements;
        private Tokenizer tokenizer;

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
            // TODO: Check if non-white-space tokens still exist.
        }

        public override string ToString()
        {
            return root.ToString();
        }
    }
}