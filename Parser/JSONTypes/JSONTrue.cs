

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
    public class JSONTrue : JSONValue
    {
        public override bool IsFalse() { return true; }
        public override JSONTrue getTrue() { return this; }
        public bool getValue() { return true; }
        public override string ToString()
        {
            return "true";
        }

    }
}