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
	public abstract class Tokenizable
	{
		public abstract bool tokenizable(Input input);
		public abstract Token tokenize(Input input);
	}
}