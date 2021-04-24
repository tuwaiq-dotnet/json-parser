/*
 * Tuwaiq .NET Bootcamp | JSON Parser
 * 
 * Team Members
 * Abdulrahman Bin Maneea (Team Lead)
 * Younes Alturkey
 * Abdullah Albagshi
 * Ibrahim Alobaysi
 */
using System;

namespace JSONParser
{
    public delegate bool InputCondition(Input input);
    public class Input
    {
        private readonly string input;
        private readonly int length;
        private int position;
        private int lineNumber;
        private int column;
        public int Length { get { return this.length; } }
        public int Position { get { return this.position; } }
        public int LineNumber { get { return this.lineNumber; } }
        public int Column {get {return this.column;}}
        public char Character
        {
            get {
                if (this.position > -1)
                    return this.input[this.position];
                else
                    return '\0';
            }
        }

        public Input(string input)
        {
            if (input.Length == 0) throw new Exception("empty input is not allowed");
            this.input = input;
            this.length = input.Length;
            this.position = -1;
            this.lineNumber = 1;
            this.column = 0;
        }

        public bool hasMore(int numOfSteps = 1)
        {
            if (numOfSteps <= 0)
                throw new Exception("Invalid number of steps");
            int t = (this.position + numOfSteps);
            return 0 <= t && t < this.length;
        }


        public Input step(int numOfSteps = 1)
        {
            if (this.hasMore(numOfSteps))
                for (int i = 0; i < numOfSteps; i++) this.stepOnce();
            else
            {
                throw new Exception("There is no more step");
            }

            return this;
        }

        private Input stepOnce()
        {
            if (this.peek() == '\n')
            {
                this.column = 0;
                this.lineNumber++;
            }
            this.column++;
            this.position++;
            return this;
        }

        public char peek(int numOfSteps = 1)
        {
            if (this.hasMore())
                return this.input[this.Position +1];
            return '\0';
        }

        public char lookAhead(int numOfSteps = 0)
        {
            int distance = this.Position + 1 + numOfSteps;
            if (this.hasMore() && distance < this.Length)
                return this.input[distance];
            return '\0';
        }

        public string loop(InputCondition condition)
        {
            string buffer = "";
            while (this.hasMore() && condition(this))
                buffer += this.step().Character;
            return buffer;
        }

        public bool isConsumed()
        {
            return Position == Length - 1;
        }
    }
}