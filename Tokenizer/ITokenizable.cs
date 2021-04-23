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
    public abstract class ITokenizable
    {
        public abstract bool tokenizable(Input input);
        public abstract Token tokenize(Input input);
    }
}