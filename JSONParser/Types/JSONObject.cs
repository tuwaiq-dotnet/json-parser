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
    public class JSONObject : JSONValue
    {
        private List<JSONElement> elements;

        public override JSONObject getObject() { return this; }
        public JSONElement getElement(int index) { return this.elements[index]; }
        public override bool IsObject() { return true; }
        public override string ToString()
        {
            string s = "";
            foreach(var element in elements)
                s+=element;
            return s;
        }
    }
}