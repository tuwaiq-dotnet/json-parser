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
    public class JObject : Value
    {
        private List<Element> elements;
        public JObject(Token token, Tokenizer tokenizer)
        {

        }
        public override JObject getObject() { return this; }
        public Element getElement(int index) { return this.elements[index]; }
        public override bool IsObject() { return true; }
        // public static bool isObject(Token t){return false;}
        public override string ToString()
        {
            string s = "";
            foreach (var element in elements)
                s += element;
            return s;
        }
    }
}