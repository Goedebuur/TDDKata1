using System.Linq;

namespace TDDKata1
{
    public class StringCalculator
    {
        public static void Main(string[] args) {}

        public int Add(string input)
        {
            if (input == string.Empty)
            {
                return 0;
            }

            int result = 0;
            var lines = GetLines(input);

            foreach (string stringNumber in lines
                .Select(line => line.Split(','))
                .SelectMany(numbers => numbers))
            {
                int parsedString;
                int.TryParse(stringNumber, out parsedString);

                result += parsedString;
            }

            return result;
        }

        private string[] GetLines(string input)
        {
            return input.Split('\n');
        }
    }
}