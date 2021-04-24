

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
        public JTrue(Token token)
        {
            this.token = token;
        }

        public override bool IsTrue() { return true; }
        public override JTrue getTrue() { return this; }
        public bool getValue() { return true; }
        public override string ToString() { return "true"; }
        public override JSONMemberType getType() { return JSONMemberType.True; }

        public override string Indent(uint indentation = 0)
        {
            return this.ToString();
        }
    }
}