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
	public class JSONTrue : JSONType
	{
		public JSONTrue()
		{
			value = "true";
			type = TokenType.True;
		}
	}
}