

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
    public class JTrue : Value
    {
        Token token;
        new public static readonly JSONMemberType type = JSONMemberType.True;
        public JTrue(Token token)
        {
            this.token = token;
        }

        public override bool IsTrue() { return true; }
        public override JTrue getTrue() { return this; }
        public bool getValue() { return true; }
        public override string ToString()
        {
            return "true";
        }

    }
}