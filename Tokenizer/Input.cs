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
        public int Length
        {
            get
            {
                return this.length;
            }
        }

        public int Position
        {
            get
            {
                return this.position;
            }
        }

        public int NextPosition
        {
            get
            {
                return this.position + 1;
            }
        }

        public int LineNumber
        {
            get
            {
                return this.lineNumber;
            }
        }

        public char Character
        {
            get
            {
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
        }

        public bool hasMore(int numOfSteps = 1)
        {
            if (numOfSteps <= 0)
                throw new Exception("Invalid number of steps");
            int t = (this.position + numOfSteps);
            return 0 <= t && t < this.length;
        }

        public bool hasLess(int numOfSteps = 1)
        {
            if (numOfSteps <= 0)
                throw new Exception("Invalid number of steps");
            return (this.position - numOfSteps) > -1;
        }

        public Input step(int numOfSteps = 1)
        {
            if (this.hasMore(numOfSteps))
                this.position += numOfSteps;
            else
            {
                throw new Exception("There is no more step");
            }

            return this;
        }

        public Input back(int numOfSteps = 1)
        {
            if (this.hasLess(numOfSteps))
                this.position -= numOfSteps;
            else
            {
                throw new Exception("There is no more step");
            }

            return this;
        }

        public Input reset()
        {
            this.position = -1;
            this.lineNumber = 1;
            return this;
        }

        public char peek(int numOfSteps = 1)
        {
            if (this.hasMore())
                return this.input[this.NextPosition];
            return '\0';
        }

        public char lookAhead(int numOfSteps = 0)
        {
            int distance = this.NextPosition + numOfSteps;
            if (this.hasMore() && distance < this.Length)
                return this.input[distance];
            return '\0';
        }

        public int indexOf(char ch)
        {
            return this.input.IndexOf(ch);
        }

        public int lastIndexOf(char ch)
        {
            return this.input.LastIndexOf(ch);
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