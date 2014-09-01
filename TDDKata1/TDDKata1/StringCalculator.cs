namespace TDDKata1
{
    public class StringCalculator
    {
        public int Add(string input)
        {
            if (input == string.Empty)
            {
                return 0;
            }

            int result = 0;
                
            foreach (var stringNumber in input.Split(','))
            {
                int parsedString;
                int.TryParse(stringNumber, out parsedString);

                result += parsedString;
            }

            return result;
        }

        public static void Main(string[] args)
        {
            
        }
    }
}