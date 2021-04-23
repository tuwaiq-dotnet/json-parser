

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

        public virtual JSONObject getObject() { return null; }
        public virtual JSONArray getArray() { return null; }
        public virtual JSONString getString() { return null; }
        public virtual JSONNumber getNumber() { return null; }
        public virtual JSONNull getNull() { return null; }
        public virtual JSONTrue getTrue() { return null; }
        public virtual JSONFalse getFalse() { return null; }


        public virtual bool IsObject() { return false; }
        public virtual bool IsArray() { return false; }
        public virtual bool IsString() { return false; }
        public virtual bool IsNumber() { return false; }
        public virtual bool IsNull() { return false; }
        public virtual bool IsTrue() { return false; }
        public virtual bool IsFalse() { return false; }
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
