using System;
using Xunit;
using FluentAssertions;
using KataStringCalculator.ConsoleUI;
using Xunit.Abstractions;

namespace KataStringCalculator.UnitTests
{
    public class StringCalculatorShould
    {
        private readonly ITestOutputHelper _output;

        public StringCalculatorShould(ITestOutputHelper output)
        {
            _output = output;
        }

        [Theory(DisplayName = "Return Zero (0) When String Is Null Empty or Whitespace")]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void ReturnZeroWhenStringIsNullEmptyOrWhiteSpace(string value)
        {
            int expected = 0;

            var sut = new StringCalculator();
            var result = sut.Add(value);

            result.Should().Be(expected);
        }

        [Fact(DisplayName = "Return Integer Value When One Integer Value Is Provided")]
        public void ReturnIntegerValueWhenOneIntegerValueIsProvided()
        {
            string value = "1";
            int expected = 1;

            var sut = new StringCalculator();
            var result = sut.Add(value);

            result.Should().Be(expected);
            
            _output.WriteLine($"Value provided was {value}");
            _output.WriteLine($"Expected sum value should be {expected}");
            _output.WriteLine($"Sum outcome is {sut}");
        }

        [Theory(DisplayName = "Return Expected Total Sum When Multiple Comma Delimited Integers Are Provided")]
        [InlineData("1,2",3)]
        [InlineData("2,2,2",6)]
        [InlineData("1\n,2,3",6)]
        [InlineData("1\n",1)]
        public void ReturnExpectedTotalSumWhenMultipleCommaDelimitedIntegersAreProvided(string value, int expected)
        {
            var sut = new StringCalculator();
            var result = sut.Add(value);

            result.Should().Be(expected);
            
            _output.WriteLine($"Value provided was {value}");
            _output.WriteLine($"Expected sum value should be {expected}");
            _output.WriteLine($"Sum outcome is {sut}");
        }

        [Theory(DisplayName = "Return Expected Total Sum When Provided Custom Delimiter")]
        [InlineData("//;\n1,2",3)]
        public void ReturnExpectedTotalSumWhenProvidedCustomDelimiter(string value, int expected)
        {
            var sut = new StringCalculator();
            var result = sut.Add(value);

            result.Should().Be(expected);
            
            _output.WriteLine($"Value provided was {value}");
            _output.WriteLine($"Expected sum value should be {expected}");
            _output.WriteLine($"Sum outcome is {sut}");
        }
    }
}