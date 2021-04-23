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
    public class Input
    {
        private readonly string input;
        private readonly int length;
        private int position;
        private int lineNumber;

        //Properties
        public int Length { get; }
        public int Position { get; }
        public int LineNumber { get; }
        public char Character
        {
            get
            {
                if (this.position > -1) return this.input[this.position];
                else return '\0';
            }
        }

        public Input(string input)
        {
            this.input = input;
            this.length = input.Length;
            this.position = -1;
            this.lineNumber = 1;
        }

        public bool hasMore(int numOfSteps = 1)
        {
            if (numOfSteps <= 0) throw new Exception("Invalid number of steps");
            int t = (this.position + numOfSteps);
            return 0 <= t && t < this.length;
        }

        public Input step(int numOfSteps = 1)
        {
            if (this.hasMore(numOfSteps)) this.position += numOfSteps;
            else throw new Exception("There is no more step");
            return this;
        }

        public char peek(int numOfSteps = 0)
        {
            return hasMore() ? this.input[this.Position + numOfSteps + 1] : '\0';
        }
    }
}
