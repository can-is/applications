using CSharpCodingChallenge;
using Xunit;

namespace CSharpCodingChallengeTest
{
    public class OldPhonePadTest
    {
        private const string INVALID_INPUT = "Invalid Input";

        [Theory]
        [InlineData("222 2 22#", "CAB")]
        [InlineData("33#", "E")]
        [InlineData("227*#", "B")]
        [InlineData("4433555 555666#", "HELLO")]
        [InlineData("8 88777444666*664#", "TURING")]
        [InlineData("#", INVALID_INPUT)]
        [InlineData(" ", INVALID_INPUT)]
        [InlineData("1", INVALID_INPUT)]
        [InlineData("2271#", INVALID_INPUT)]
        public void OldPhonePad_WhenPassedNumberCombination_ReturnsWord(string input, string expectedOutput)
        {
            //Arrange, Act
            string actualOutput = OldPhonePadApplication.OldPhonePad(input);

            //Assert
            Assert.Equal(expectedOutput, actualOutput);
        }
    }
}