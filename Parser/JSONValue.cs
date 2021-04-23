

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
    public abstract class JSONValue
    {
        private JSONMemberType Type;
        private Token[] Value;

        public JSONObject getObject() {return null;}
        public JSONArray getArray() {return null;}
        public JSONString getString() {return null;}
        public JSONNumber getNumber() {return null;}
        public JSONNull getNull() {return null;}
        public JSONTrue getTrue() {return null;}
        public JSONFalse getFalse() {return null;}


    }

    public enum JSONMemberType
    {
        String,
        Array,
        Number,
        Object,
        Null,
        False,
        True
    }
}
