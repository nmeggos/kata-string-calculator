using System;
using System.Linq;

namespace KataStringCalculator.ConsoleUI
{
    public class StringCalculator
    {
        public StringCalculator()
        {
        }
        
        public int Add(string value)
        {
            int total = 0;
            
            if (string.IsNullOrWhiteSpace(value))
            {
                return total;
            }

            var delimiters = GetDelimiters(value);

            var valuesToAdd = value
                .Split(delimiters, StringSplitOptions.RemoveEmptyEntries)
                .Select(number => Convert.ToInt32(number))
                .ToList();

            total = valuesToAdd.Sum();

            return total;
        }

        private string[] GetDelimiters(string value)
        {
            const string defaultDelimiter = ",";
            const string delimiterStartPattern = "//";
            const string delimiterEndPattern = "\n";

            int delimiterStartPatternIndex = value.IndexOf(delimiterStartPattern);

            if (delimiterStartPatternIndex == -1)
            {
                return new string[] {defaultDelimiter};
            }
            
            int delimiterValueIndex = value.IndexOf(delimiterEndPattern) - delimiterStartPattern.Length;

            var delimiterValue = value.Substring(delimiterStartPatternIndex, delimiterValueIndex);
            
            return new string[] {defaultDelimiter};

        }
    }
}