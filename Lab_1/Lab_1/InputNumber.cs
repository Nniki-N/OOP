
namespace Lab_1
{
    class InputNumber
    {
        public static int ReadInt(int min, int max)
        {
            while (true)
            {
                int result;

                if (Int32.TryParse(Console.ReadLine(), out result))
                {
                    if (result > max || result < min)
                    {
                        Console.WriteLine("Введене значення не коректне, спробуйте ще раз:");
                        continue;
                    }
                    return result;
                }
                else
                {
                    Console.WriteLine("Введене значення не коректне, спробуйте ще раз:");
                    continue;
                }
            }
        }
    }
}
