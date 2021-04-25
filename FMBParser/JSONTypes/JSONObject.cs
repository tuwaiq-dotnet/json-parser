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
using System.Collections.Generic;

namespace JSONParser
{
    public class JSONObject : JSONType
    {
        public JSONObject()
        {
            value = new Dictionary<string, JSONType>();
            type = TokenType.OpeningCurlyBracket;
        }

        public override string ToString()
        {
            string obj = "";
            obj += "   {";
            int i = 0;
            foreach (KeyValuePair<string, JSONType> kvp in value)
            {
                obj += "\n      " + kvp.Key + ": " + kvp.Value;
                if (i < value.Count - 1)
                    obj += ", ";
                else
                    obj += "\n   }";
                i++;
            }

            return obj;
        }
    }
}