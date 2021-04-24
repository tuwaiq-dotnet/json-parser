

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
    public class JNumber : Value
    {
        Token token;
        new public static readonly JSONMemberType type = JSONMemberType.Number;
        public JNumber(Token token)
        {
            this.token = token;
        }

        public override string ToString()
        {
            return token.Value;
        }
    }
}