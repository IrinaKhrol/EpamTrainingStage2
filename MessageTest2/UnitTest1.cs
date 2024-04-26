using BasicOfNETFrameworkAndCSharpWithUnitTests;

namespace MessageTest
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase("aabbbccccdddddddeeee", 2, "expected return result should be 2")]
        [TestCase("12375858", 8, "check integer")]
        public void CheckMaxConsecutiveDifferentCharacters_ReturnsCorrectResult(string input, int expected, string message)
        {
            // Act
            int result = Message.GetMaxConsecutiveDifferentCharacters(input);

            // Assert
            Assert.That(expected.Equals(result), message);
        }

        [TestCase("", 0, "message")]
        [TestCase("12375858", 0, "check integer")]
        public void CheckGetMaxConsecutiveLatinLetters(string input, int expected, string message)
        {
            // Act
            int result = Message.GetMaxConsecutiveLatinLetters(input);

            // Assert
            Assert.That(expected.Equals(result), message);
        }
    }
}