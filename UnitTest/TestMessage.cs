using BasicOfNETFrameworkAndCSharpWithUnitTests;
namespace UnitTest
{
    [TestFixture]
    public class TestMessage
    {
        [TestCase("aabbbccccdddddddeeee", "message")]
        [TestCase("12375858","check integer")]
        public void GetMaxConsecutiveDifferentCharacters_ReturnsCorrectResult(string input,string message)
        {
            // Arrange
            //string input = "aabbbccccdddddddeeee";
            int expected = 6; // Максимальное количество неодинаковых последовательных символов

            // Act
            int result = Message.GetMaxConsecutiveDifferentCharacters(input);

            // Assert
            Assert.That(expected.Equals( result),message);
        }
    }
}