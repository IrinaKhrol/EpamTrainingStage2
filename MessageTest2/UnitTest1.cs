using BasicOfNETFrameworkAndCSharpWithUnitTests;

namespace MessageTest
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase("aabbbccccdddddddeeee", 2, "expected return result should be 2")]
        [TestCase("12375858", 8, "check integer")]
        [TestCase("12375888", 6, "check integer")]
        public void CheckGetMaxConsecutiveDifferentCharacters(string input, int expected, string message)
        {
            int result = Message.GetMaxConsecutiveDifferentCharacters(input);

            Assert.That(expected.Equals(result), message);
        }

        [TestCase("", 0, "expected return result should be 0")]
        [TestCase("12375858", 0, "check integer")]
        [TestCase("a1b2c3d4e5", 1, "check single consecutive latin letter in a mixed string")]
        [TestCase("abc", 3, "check three consecutive latin letters")]
        public void CheckMaxConsecutiveLatinLetters(string input, int expected, string message)
        {
            int result = Message.GetMaxConsecutiveLatinLetters(input);

            Assert.That(expected.Equals(result), message);
        }

        [TestCase("", 0, "expected return result should be 0")]
        [TestCase("\\d+", 0, "check integer")]
        [TestCase("123", 3, "check three consecutive digits")]
        [TestCase("abc123xyz456", 3, "check three consecutive digits in a mixed string")]
        public void CheckMaxConsecutiveDigits(string input, int expected, string message)
        {
            int result = Message.GetMaxConsecutiveDigits(input);

            Assert.That(expected.Equals(result), message);
        }
    }
}