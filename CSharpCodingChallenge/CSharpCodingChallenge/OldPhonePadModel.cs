namespace CSharpCodingChallenge
{
    public class OldPhonePadModel
    {
        public static Dictionary<char, List<string>> OldPhonePadConfiguration => new Dictionary<char, List<string>>()
    {
      {
        '2',
        new List<string>() { "A", "B", "C" }
      },
      {
        '3',
        new List<string>() { "D", "E", "F" }
      },
      {
        '4',
        new List<string>() { "G", "H", "I" }
      },
      {
        '5',
        new List<string>() { "J", "K", "L" }
      },
      {
        '6',
        new List<string>() { "M", "N", "O" }
      },
      {
        '7',
        new List<string>() { "P", "Q", "R", "S" }
      },
      {
        '8',
        new List<string>() { "T", "U", "V" }
      },
      {
        '9',
        new List<string>() { "W", "X", "Y", "Z" }
      }
    };
    }
}
