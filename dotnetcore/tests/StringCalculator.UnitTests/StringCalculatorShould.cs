using System;
using Xunit;
using FluentAssertions;
using KataStringCalculator.ConsoleUI;

namespace KataStringCalculator.UnitTests
{
    public class StringCalculatorShould
    {
        [Fact]
        public void ReturnZeroWhenStringValueIsNullOrWhiteSpace()
        {
            string value = null;
            int expected = 0;

            var sut = StringCalculator.Add(value);

            sut.Should().Equals(expected);
        }
    }
}