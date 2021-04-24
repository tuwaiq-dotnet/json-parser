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
    public class JObject : Value
    {
        new public static readonly JSONMemberType type = JSONMemberType.Object;

        public JObject()
        {
            Items = new List<JKeyValue>();
        }
        public List<JKeyValue> Items;
        public override JObject getObject() { return this; }
        public JKeyValue getElement(int index) { return this.Items[index]; }
        public override bool IsObject() { return true; }

        public override string ToString()
        {
            return $"{string.Join(",", this.Items)}";
        }
    }
}