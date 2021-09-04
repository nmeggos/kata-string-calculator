using System;

namespace KataStringCalculator.ConsoleUI
{
    public static class StringCalculator
    {
        public static int Add(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return 0;
            }

            return Convert.ToInt32(value);
        }
    }
}