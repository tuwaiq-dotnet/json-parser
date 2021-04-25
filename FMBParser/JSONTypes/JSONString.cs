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
	public class JSONString : JSONType
	{
		public JSONString(string value)
		{
			this.value = value;
			type = TokenType.String;
		}
	}
}