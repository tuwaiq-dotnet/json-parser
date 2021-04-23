

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
    public class JSONElement
    {
        private string key;
        private JSONValue value;
        public override string ToString()
        {
            return $"\"{key}\": {value}";
        }
    }
}

