

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
        public JNumber(Token token)
        {
            this.Children = 0;
            this.token = token;
        }

        public override string ToString()
        {
            return token.Value;
        }


        public override JSONMemberType getType()
        {
            return JSONMemberType.Number;
        }

        public override string Indent(uint indentation = 0)
        {
            return this.ToString();
        }
    }
}