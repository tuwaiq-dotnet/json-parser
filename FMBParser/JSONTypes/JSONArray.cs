/*
 * Tuwaiq .NET Bootcamp | JSONParser
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
    public class JSONArray : JSONType
    {
        public JSONArray()
        {
            value = new List<JSONType>();
            type = TokenType.OpeningBracket;
        }

        public void Add(JSONType item)
        {
            value.Add(item);
        }

        public override string ToString()
        {
            string list = "";
            list += "[";
            int i = 0;
            foreach (JSONType jt in value)
            {
                if (jt.type == TokenType.OpeningBracket)
                {
                    list += jt.ToString();
                    if (i < value.Count - 1)
                        list += ", ";
                    else
                        list += "]";
                    i++;
                }
                else if (jt.type == TokenType.OpeningCurlyBracket)
                {
                    list += jt.ToString();
                    if (i < value.Count - 1)
                        list += ", ";
                    else
                        list += "]";
                    i++;
                }
                else
                {
                    list += jt.value;
                    if (i < value.Count - 1)
                        list += ", ";
                    else
                        list += "]";
                    i++;
                }
            }

            return list;
        }
    }
}