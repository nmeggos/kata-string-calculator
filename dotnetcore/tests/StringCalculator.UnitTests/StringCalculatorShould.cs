using System;
using Xunit;
using FluentAssertions;
using KataStringCalculator.ConsoleUI;

namespace KataStringCalculator.UnitTests
{
    public class StringCalculatorShould
    {
        [Fact(DisplayName = "Return Zero When String Value Is Null")]
        public void ReturnZeroWhenStringValueIsNull()
        {
            string value = null;
            int expected = 0;

            var sut = StringCalculator.Add(value);

            sut.Should().Equals(expected);
        }

        [Fact(DisplayName = "Return Zero When String Value Is Empty")]
        public void ReturnZeroWhenStringValueIsEmpty()
        {
            string value = String.Empty;
            int expected = 0;

            var sut = StringCalculator.Add(value);

            sut.Should().Equals(expected);

            value = "";
            sut = StringCalculator.Add(value);
            
            sut.Should().Equals(expected);
        }

        [Fact(DisplayName = "Return Zero When String Value Is White Space")]
        public void ReturnZeroWhenStringValueIsWhiteSpace()
        {
            string value = " ";
            int expected = 0;

            var sut = StringCalculator.Add(value);
            
            sut.Should().Equals(expected);
        }

        [Fact(DisplayName = "Return Integer Value When One Integer Value Is Provided")]
        public void ReturnIntegerValueWhenOneIntegerValueIsProvided()
        {
            string value = "1";
            int expected = 1;

            var sut = StringCalculator.Add(value);

            sut.Should().Equals(expected);
        }
    }
}