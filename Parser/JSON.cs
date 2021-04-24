using System;
using System.Collections.Generic;

namespace JSONParser
{
    public class JSON
    {
        public Dictionary<string, JSONType> map;

        public JSON(List<Token> tokens)
        {
            map = new Dictionary<string, JSONType>();
            parse(tokens);
        }

        public void addKeyValue(string key, JSONType value)
        {
            // Console.WriteLine("added: " + key);
            map.Add(key, value);
        }

        public JSONType getValue(string key)
        {
            return map["\"" + key + "\""];
        }

        public void parse(List<Token> tkns)
        {
            JSONTokens tokens = new JSONTokens(tkns);
            Token key = null;
            Token value = null;

            while (tokens.hasMore())
            {
                key = tokens.step();
                // Console.WriteLine("Key: " + key.Value);
                if (key.Type == TokenType.String)
                {
                    value = tokens.step(3);
                    // Console.WriteLine("value: " + value.Value);

                    if (value.Type == TokenType.String)
                        addKeyValue(key.Value, new JSONString(value.Value));
                    else if (value.Type == TokenType.Number)
                        addKeyValue(key.Value, new JSONNumber(Double.Parse(value.Value)));
                    else if (value.Type == TokenType.Null)
                        addKeyValue(key.Value, new JSONNull());
                    else if (value.Type == TokenType.False)
                        addKeyValue(key.Value, new JSONFalse());
                    else if (value.Type == TokenType.True)
                        addKeyValue(key.Value, new JSONTrue());
                    else if (value.Type == TokenType.OpeningBracket)
                        addKeyValue(key.Value, parseArray(tokens));
                    else if (value.Type == TokenType.OpeningCurlyBracket)
                        addKeyValue(key.Value, parseObject(tokens));
                    else
                      if (tokens.hasMore()) tokens.step();
                }
            }
        }

        public JSONArray parseArray(JSONTokens tokens)
        {
            JSONArray list = new JSONArray();
            Token value;
            while (tokens.hasMore())
            {
                value = tokens.step();

                if (value.Type == TokenType.ClosingBracket)
                    break;

                if (value.Type == TokenType.String)
                    list.Add(new JSONString(value.Value));
                else if (value.Type == TokenType.Number)
                    list.Add(new JSONNumber(Double.Parse(value.Value)));
                else if (value.Type == TokenType.Null)
                    list.Add(new JSONNull());
                else if (value.Type == TokenType.True)
                    list.Add(new JSONTrue());
                else if (value.Type == TokenType.False)
                    list.Add(new JSONFalse());
                else if (value.Type == TokenType.OpeningBracket)
                    list.Add(parseArray(tokens));
                else if (value.Type == TokenType.OpeningCurlyBracket)
                    list.Add(parseObject(tokens));
            }
            return list;
        }

        public JSONObject parseObject(JSONTokens tokens)
        {
            JSONObject obj = new JSONObject();
            Token value;
            Token temp;
            while (tokens.hasMore())
            {
                value = tokens.step();

                if (value.Type == TokenType.ClosingCurlyBracket)
                    break;

                while (tokens.hasMore() && value.Type == TokenType.String)
                {
                    temp = tokens.step();

                    if (temp.Type == TokenType.String)
                    {
                        obj.value.Add(value.Value, new JSONString(temp.Value));
                        break;
                    }
                    else if (temp.Type == TokenType.Number)
                    {
                        obj.value.Add(value.Value, new JSONNumber(Double.Parse(temp.Value)));
                        break;
                    }
                    else if (temp.Type == TokenType.Null)
                    {
                        obj.value.Add(value.Value, new JSONNull());
                        break;
                    }
                    else if (temp.Type == TokenType.True)
                    {
                        obj.value.Add(value.Value, new JSONTrue());
                        break;
                    }
                    else if (temp.Type == TokenType.False)
                    {
                        obj.value.Add(value.Value, new JSONFalse());
                        break;
                    }
                    else if (temp.Type == TokenType.OpeningBracket)
                    {
                        obj.value.Add(value.Value, parseArray(tokens));
                        break;
                    }
                    else if (temp.Type == TokenType.OpeningCurlyBracket)
                    {
                        obj.value.Add(value.Value, parseObject(tokens));
                        break;
                    }
                }
            }
            return obj;
        }

        public override string ToString()
        {
            string json = "{\n";
            int i = 0;
            foreach (KeyValuePair<string, JSONType> kvp in map)
            {
                json += $"   {kvp.Key}: {kvp.Value}";

                if (i < map.Count - 1)
                    json += ",\n";
                else
                    json += "\n";
                i++;
            }
            json += "}\n";

            return json;
        }

        public void print()
        {
            Utilities.setConsoleForegroundColor(ConsoleColor.Yellow);
            Console.WriteLine("{");
            int i = 0;
            foreach (KeyValuePair<string, JSONType> kvp in map)
            {
                Utilities.setConsoleForegroundColor(ConsoleColor.DarkCyan);
                Console.Write($"   {kvp.Key}: ");
                Utilities.setConsoleForegroundColor(ConsoleColor.Green);
                Console.Write($"{kvp.Value}");
                Utilities.setConsoleForegroundColor(ConsoleColor.White);

                if (i < map.Count - 1)
                    Console.Write(",\n");
                else
                    Console.Write("\n");
                i++;
            }
            Utilities.setConsoleForegroundColor(ConsoleColor.Yellow);
            Console.WriteLine("}");

            Utilities.resetConsoleForegroundColor();
        }

        public void printKeys()
        {
            Console.Write("Keys: [");
            int i = 0;
            foreach (KeyValuePair<string, JSONType> kvp in map)
            {
                Utilities.setConsoleForegroundColor(ConsoleColor.DarkBlue);
                Console.Write(kvp.Key);
                Utilities.resetConsoleForegroundColor();

                if (i < map.Count - 1)
                    Console.Write(", ");
                else
                    Console.Write("]");
                i++;
            }
        }

    }
}