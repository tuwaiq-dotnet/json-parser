

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
    public class JString : Value
    {
        Token token;
        public JString(Token token)
        {
            this.token = token;
        }

        public override string ToString()
        {
            return token.Value;
        }


        public override JSONMemberType getType()
        {
            return JSONMemberType.String;
        }

        public override string Indent(uint indentation = 0)
        {
            return this.ToString();
        }
    }
}