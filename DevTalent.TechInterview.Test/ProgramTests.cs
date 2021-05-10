using NUnit.Framework;
using Shouldly;

namespace DevTalent.TechInterview.Tests
{
    public class ProgramTests
    {
        [Test]
        public void Test1()
        {
            // Arrange
            var input = "hello world";
            var expectedResult = "HELLO WORLD";

            // Act
            var result = Program.Execute(input);

            // Assert
            result.ShouldBe(expectedResult);
        }
    }
}