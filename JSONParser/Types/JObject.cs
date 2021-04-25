using System.Collections.Generic;
using System;
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
        public List<JKeyValue> Items;
        new public uint Children
        {
            get
            {
                uint sum = 0;
                foreach (var item in Items)
                    sum += item.value.Children;
                return sum + 1;
            }
        }

        public JObject()
        {
            Items = new List<JKeyValue>();
        }


        public override JSONMemberType getType() { return JSONMemberType.Object; }
        public override JObject getObject() { return this; }
        public JKeyValue getElement(int index) { return this.Items[index]; }
        public override string ToString() { return $"{{{string.Join(",", this.Items)}}}"; }

        public Value getItem(int i)
        {

            return this.Items.Count > i ? this.Items[i].value : null;

        }

        public Value getItem(string key)
        {
            foreach (var item in this.Items)
                if (item.key.Value == $@"""{key}""")
                    return item.value;
            return null;
        }

        public override string Indent(uint indentation = 0)
        {
            string ret = "{\n";
            foreach (var item in this.Items)
            {
                for (uint i = 0; i <= indentation; i++) ret += '\t';
                ret += $"{item.key.Value}: {item.value.Indent(indentation + 1)},\n";
            }
            if (ret.Length > 2)
            {
                ret = ret.Substring(0, ret.Length - 2) + "\n";
            }
            for (uint i = 0; i < indentation + 1; i++) ret += '\t';
            return ret + "}";
        }

        public override Value ConsoleColorization(int indentation = 0)
        {
            Console.ResetColor();
            Console.Write("{\n");
            int count = 0;
            foreach (var item in this.Items)
            {
                for (uint i = 0; i <= indentation; i++) Console.Write("\t");
                Console.Write('"');
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(item.key.Value.ToString().Trim('"'));
                Console.ResetColor();
                Console.Write("\": ");
                item.value.ConsoleColorization(indentation + 1);
                if (++count == this.Items.Count)
                    Console.Write("\n");
                else
                    Console.Write(",\n");
            }
            // if (ret.Length > 2)
            // {
            //     ret = ret.Substring(0, ret.Length - 2) + "\n";
            // }
            for (uint i = 0; i < indentation + 1; i++) Console.Write('\t');
            Console.WriteLine("}");
            Console.ResetColor();

            return this;
        }
    }
}