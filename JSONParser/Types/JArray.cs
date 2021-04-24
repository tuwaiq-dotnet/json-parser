using System.Collections.Generic;

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
    public class JArray : Value
    {
        public List<Value> Items = new List<Value>();
        new public static readonly JSONMemberType type = JSONMemberType.Array;
        public override string ToString()
        {
            return $"[{string.Join(", ", Items)}]";
        }
    }
    
}