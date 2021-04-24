

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
    public class JFalse : Value
    {
        Token token;
        new public static readonly JSONMemberType type = JSONMemberType.False;
        public JFalse(Token token)
        {
            this.token = token;
        }
        public override bool IsFalse() { return true; }
        public override JFalse getFalse() { return this; }
        public bool getValue() { return false; }
        public override string ToString()
        {
            return "false";
        }
    }
}