

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
    public abstract class JSONType
    {
        public dynamic value;
        public TokenType type;

        public override string ToString()
        {
            return value.ToString();
        }
    }

    public enum JSONTypes
    {
        String,
        Array,
        Number,
        Object,
        Null,
        False,
        True
    }
}
