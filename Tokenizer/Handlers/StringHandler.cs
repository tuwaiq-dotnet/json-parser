/*
 * Tuwaiq .NET Bootcamp | JSON Parser
 * 
 * Team Members
 * Abdulrahman Bin Maneea (Team Lead)
 * Younes Alturkey
 * Abdullah Albagshi
 * Ibrahim Alobaysi
 */
namespace JSONParser
{
    public class StringHandler : ITokenizable
    {
        private const char DOUBLE_QOUTE = '"';
        private const char SLASH = '\\';
        public override bool tokenizable(Input input)
        {
            return input.peek() == DOUBLE_QOUTE;
        }

        public override Token tokenize(Input input)
        {
            int initPos = input.Position;
            int ln = input.LineNumber;
            string val = input.step().Character + "";
            while (input.hasMore())
            {
                val += input.step().Character;
                if (input.Character == SLASH)
                    val += input.step().Character;
                else if (input.Character == DOUBLE_QOUTE)
                    return new Token(input.Position, input.LineNumber, TokenType.String, val);
            }

            throw new System.Exception($"EOF reached without finding a closing '\"' at Ln {ln} Col {initPos}");
        }
    }
}