
namespace Lab_4
{
    public class MyTextReader
    {
        public static int CountUppercaseLetters(char[] symbols)
        {
            int count = 0;

            foreach (char symbol in symbols)
            {
                if (char.IsUpper(symbol))
                {
                    count++;
                }
            }

            return count;
        }

        public static int CountUppercaseLetters(List<char> symbols)
        {
            int count = 0;

            foreach (char symbol in symbols)
            {
                if (char.IsUpper(symbol))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
