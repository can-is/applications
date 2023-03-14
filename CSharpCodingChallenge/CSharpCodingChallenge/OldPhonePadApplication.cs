namespace CSharpCodingChallenge
{
    /// <summary>
    /// For given number series, Application will generate word
    /// </summary>
    public class OldPhonePadApplication
    {
        private const string INVALID_INPUT = "Invalid Input";

        private OldPhonePadApplication()
        {
        }

        /// <summary>
        /// The method will return word based on input
        /// </summary>
        /// <param name="input">Number Series</param>
        /// <returns></returns>
        public static string OldPhonePad(string input)
        {
            string output;
            new OldPhonePadApplication().Process(input, out output);
            return output;
        }

        private void Process(string input, out string output)
        {
            char previousNumber = '~';
            int numberCount = 0;
            output = string.Empty;
            if (!this.ValidateInput(input))
            {
                output = INVALID_INPUT;
            }
            else
            {
                foreach (char currentnNumber in input)
                {
                    if (currentnNumber == '#')
                    {
                        this.ConvertToWord(numberCount, previousNumber, currentnNumber, ref output);
                        break;
                    }

                    if ((int)previousNumber == (int)currentnNumber)
                    {
                        ++numberCount; // Count the number of occurence of character
                    }
                    else if (previousNumber != ' ' && previousNumber != '~')
                    {
                        this.ConvertToWord(numberCount, previousNumber, currentnNumber, ref output);

                        //Move to next character 
                        numberCount = 0;
                    }

                    previousNumber = currentnNumber;
                }
            }
        }

        private void ConvertToWord(
          int numberCount,
          char previousNumber,
          char currentNumber,
          ref string output)
        {
            Dictionary<char, List<string>> keyPadConfiguration = OldPhonePadModel.OldPhonePadConfiguration;
            if (currentNumber == '*' || previousNumber == '*' || previousNumber == ' ')
            {
                return;
            }

            List<string> stringList = keyPadConfiguration[previousNumber];
            output += stringList[numberCount];
        }

        private bool ValidateInput(string input)
        {
            bool flag = true;
            if (input.StartsWith("#"))
            { flag = false; }
            else if (input.Contains("1"))
            { flag = false; }
            else if (input == " ")
            { flag = false; }
            return flag;
        }
    }
}
