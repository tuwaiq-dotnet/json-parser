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
	public class JKeyValue
	{
		public Token key;
		public Value value;
		public JKeyValue(Token key, Value value)
		{
			this.key = key;
			this.value = value;
		}

		public override string ToString()
		{
			// return $@"{this.key}: {this.value}";
			return $"{this.key}:{this.value}";
		}
	}
}