using System;
using System.Collections.Generic;
using System.Linq;

namespace KataStringCalculator.ConsoleUI
{
    public static class StringCalculator
    {
        public static int Add(string value)
        {
            int total = 0;
            
            if (string.IsNullOrWhiteSpace(value))
            {
                return total;
            }

            if (value.Length == 1)
            {
                return Convert.ToInt32(value);
            }

            List<int> valuesToAdd = value.Split(',').Select(int.Parse).ToList();

            total = valuesToAdd.Aggregate((result,next) => result + next);

            return total;
        }
    }
}