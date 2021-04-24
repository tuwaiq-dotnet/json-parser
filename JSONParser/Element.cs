

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
    public class Element
    {
        private string key;
        private Value value;

        public Element(){
            
        }

        public override string ToString()
        {
            return $"\"{key}\": {value}";
        }
    }
}

