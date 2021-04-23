

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
    public class JSONParser
    {
        private JSONValue root;
        private int elements;
        private Tokenizer tokenizer;
        public JSONParser(string source)
        {
            tokenizer = new Tokenizer(new Input(source), new Tokenizable[]{
                new StringHandler(),
                // new SingleWordHandler(),
                // new SingleCharHandler()
            });
            // root = new JSONValue(t);
        }
    }
}