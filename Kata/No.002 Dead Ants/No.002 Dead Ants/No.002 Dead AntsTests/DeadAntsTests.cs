using NUnit.Framework;
using FluentAssertions;

namespace No._002_Dead_Ants.Tests
{
    public class DeadAntsTests
    {
        [TestCase("...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t")]
        public void GetDeadAntsCount_LowerDeadBody_ReturnThree(string input)
        {
            var expected = 3;

            var actual = DeadAnts.GetDeadAntsCount(input);
            actual.Should().Be(expected);
        }

        [TestCase("A.A.A.A.A.A.A.A.A.NT")]
        public void GetDeadAntsCount_UpperDeadBody_ReturnNine(string input)
        {
            var expected = 9;

            var actual = DeadAnts.GetDeadAntsCount(input);
            actual.Should().Be(expected);
        }

        [TestCase("...bb...cc..xxx....xx.er.we.er.y.er.")]
        public void GetDeadAntsCount_NoneContainAnt_ReturnZero(string input)
        {
            var expected = 0;

            var actual = DeadAnts.GetDeadAntsCount(input);
            actual.Should().Be(expected);
        }

        [TestCase("!@#$%^&")]
        [TestCase("12345678")]
        public void GetDeadAntsCount_Not_AntString_ReturnZero(string input)
        {
            var expected = 0;

            var actual = DeadAnts.GetDeadAntsCount(input);
            actual.Should().Be(expected);
        }

        [TestCase("")]
        [TestCase("  ")]
        [TestCase(null)]
        public void GetDeadAntsCount_EmptyOrNull_ReturnZero(string input)
        {
            var expected = 0;

            var actual = DeadAnts.GetDeadAntsCount(input);
            actual.Should().Be(expected);
        }
    }
}