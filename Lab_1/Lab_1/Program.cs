
using Lab_1;

class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Default;

        TOderedArray tArray1 = new TOderedArray();

        Console.WriteLine("Введіть довжину масива (максимум 100)");
        int length = InputNumber.ReadInt(1, 100);
        Console.WriteLine("Ввести значення самостійно?");
        Console.WriteLine("так - [1]");
        Console.WriteLine("ні - [0]");
        bool randomValues = InputNumber.ReadInt(0, 1) == 0 ? true : false;

        tArray1 = new TOderedArray(length, randomValues);

        Console.Clear();
        Console.WriteLine("Масив:");
        tArray1.Display();

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Найменший елемент масиву:" + tArray1.FindMin());

        Console.WriteLine();
        Console.WriteLine("Найбільший елемент масиву:" + tArray1.FindMax());

        Console.WriteLine();
        Console.WriteLine("Сума елементів масиву:" + tArray1.FindSum());

        Console.WriteLine();
        Console.WriteLine("Введіть значення елемента який додаємо в масив (від -10 до 10)");
        int numToAdd = InputNumber.ReadInt(-10, 10);
        TOderedArray tArray2 = tArray1 + numToAdd;

        Console.WriteLine();
        Console.WriteLine("Масив:");
        tArray2.Display();

        Console.WriteLine();
        Console.WriteLine("Введіть значення елемента який видаляємо з масиву (від -10 до 10)");
        int numToRemove = InputNumber.ReadInt(-10, 10);
        tArray2 = tArray2 - numToRemove;

        Console.WriteLine();
        Console.WriteLine("Масив:");
        tArray2.Display();

    }
}