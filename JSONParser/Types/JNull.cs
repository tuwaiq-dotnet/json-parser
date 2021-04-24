

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
    public class JNull : Value
    {
        Token token;
        new public static readonly JSONMemberType type = JSONMemberType.Null;
        public JNull(Token token)
        {
            this.token = token;
        }
        public override bool IsNull() { return true; }
        public override JNull getNull() { return this; }
        public override string ToString()
        {
            return "null";
        }
    }
}