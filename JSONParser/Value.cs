

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
    public abstract class Value
    {
        public uint Children = 1;
        private Token[] Values;

        public abstract JSONMemberType getType();


        public virtual JObject getObject() { return null; }
        public virtual JArray getArray() { return null; }
        public virtual JString getString() { return null; }
        public virtual JNumber getNumber() { return null; }
        public virtual JNull getNull() { return null; }
        public virtual JTrue getTrue() { return null; }
        public virtual JFalse getFalse() { return null; }


        public virtual bool IsObject() { return false; }
        public virtual bool IsArray() { return false; }
        public virtual bool IsString() { return false; }
        public virtual bool IsNumber() { return false; }
        public virtual bool IsNull() { return false; }
        public virtual bool IsTrue() { return false; }
        public virtual bool IsFalse() { return false; }
        public abstract string Indent(uint indentation = 0);
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
