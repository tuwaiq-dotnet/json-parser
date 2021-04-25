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
	public class JSONNumber : JSONType
	{
		public JSONNumber(double value)
		{
			this.value = value;
			type = TokenType.Number;
		}
	}
}