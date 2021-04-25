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
	public class JSONFalse : JSONType
	{
		public JSONFalse()
		{
			value = "false";
			type = TokenType.False;
		}
	}
}