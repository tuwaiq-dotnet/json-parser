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
	public class JSONNull : JSONType
	{
		public JSONNull()
		{
			this.value = "null";
			type = TokenType.Null;
		}
	}
}