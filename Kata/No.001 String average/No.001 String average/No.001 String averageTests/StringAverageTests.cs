using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace No._001_String_average.Tests
{
    public class StringAverageTests
    {
        [TestCase("FIVE EIGHT NINE ONE")]
        public void AverageString_Upper5891_ReturnFive(string input)
        {
            var expected = "five";

            var actual = StringAverage.AverageString(input);
            actual.Should().Be(expected);
        }

        [TestCase("five eight nine one")]
        public void AverageString_Lower5891_ReturnFive(string input)
        {
            var expected = "five";

            var actual = StringAverage.AverageString(input);
            actual.Should().Be(expected);
        }

        [TestCase("elevent eight nine one")]
        public void AverageString_Over_Nine_ReturnNA(string input)
        {
            var expected = "n/a";

            var actual = StringAverage.AverageString(input);
            actual.Should().Be(expected);
        }

        [TestCase("A B C D")]
        [TestCase("! @ # $")]
        public void AverageString_Not_Number_ReturnNA(string input)
        {
            var expected = "n/a";

            var actual = StringAverage.AverageString(input);
            actual.Should().Be(expected);
        }

        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void AverageString_EmptyOrSpaceOrNull_ReturnNA(string input)
        {
            var expected = "n/a";

            var actual = StringAverage.AverageString(input);
            actual.Should().Be(expected);
        }

        [TestCase("five      eight     nine    one")]
        public void AverageString_MultiSpace_ReturnNA(string input)
        {
            var expected = "five";

            var actual = StringAverage.AverageString(input);
            actual.Should().Be(expected);
        }
    }
}