

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
        public JNull(Token token)
        {
            this.token = token;
        }
        public override JNull getNull() { return this; }


        public override JSONMemberType getType()
        {
            return JSONMemberType.Null;
        }

        public override string ToString()
        {
            return "null";
        }

        public override string Indent(uint indentation = 0)
        {
            return this.ToString();
        }
    }
}