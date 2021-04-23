

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
    public class JSONFalse : JSONValue
    {
        public override bool IsFalse() { return true; }
        public override JSONFalse getFalse() { return this; }
        public bool getValue() { return false; }
        public override string ToString()
        {
            return "false";
        }
    }
}