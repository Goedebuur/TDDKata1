using System;
using System.Linq;

namespace TDDKata1
{
    public class StringCalculator
    {
        private char[] _delims;
        private string _input;
        private string[] _lines;

        public static void Main(string[] args) {}

        public int Add(string input)
        {
            _input = input;
            _lines = GetLines();

            SetDelims();

            int result = 0;

            foreach (string stringNumber in _lines.Select(line => line.Split(_delims)).SelectMany(numbers => numbers))
            {
                int parsedString;
                int.TryParse(stringNumber, out parsedString);

                result += parsedString;
            }

            return result;
        }

        private string[] GetLines()
        {
            return _input.Split('\n');
        }

        private void SetDelims()
        {
            if (_input.StartsWith("//"))
            {
                _delims = _lines.First().Substring(2).ToCharArray();
                _lines = _lines.Skip(1).ToArray();
            }
            else
            {
                _delims = new[] { ',' };
            }
        }
    }
}