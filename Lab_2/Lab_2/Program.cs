
using Lab_2;

class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Default;

        Console.WriteLine("Введіть довжину вектора (максимум 20)");
        int length = InputNumber.ReadInt(1, 20);
        Console.WriteLine("Ввести значення самостійно?");
        Console.WriteLine("так - [1]");
        Console.WriteLine("ні - [0]");
        bool randomValues = InputNumber.ReadInt(0, 1) == 0 ? true : false;

        Vector vectorTest1 = new Vector(length, randomValues);

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Вектор:");
        vectorTest1.Display();
        Console.WriteLine();
        Console.WriteLine("Замінюємо всі значення більше середнього на нуль:");
        vectorTest1.ChangeEverythingAboveAverageToZro();
        vectorTest1.Display();

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("---------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("Введіть довжину векторів A, B, C (максимум 20)");
        length = InputNumber.ReadInt(1, 20);
        Console.WriteLine("Ввести значення самостійно?");
        Console.WriteLine("так - [1]");
        Console.WriteLine("ні - [0]");
        randomValues = InputNumber.ReadInt(0, 1) == 0 ? true : false;

        Vector vectorA = new Vector(length, randomValues);
        Vector vectorB = new Vector(length, randomValues);
        Vector vectorC = new Vector(length, randomValues);

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Вектор A:");
        vectorA.Display();
        Console.WriteLine("Вектор B:");
        vectorB.Display();
        Console.WriteLine("Вектор C:");
        vectorC.Display();

        Vector newVectror = (vectorC * 2 * Vector.DotProduct(vectorA, vectorB)) - vectorB * 3;

        Console.WriteLine();
        Console.WriteLine("Вектор newVectror = 2<a,b>с-3*b:");
        newVectror.Display();

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("---------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("Введіть довжину вектора (максимум 20)");
        length = InputNumber.ReadInt(1, 20);
        Console.WriteLine("Ввести значення самостійно?");
        Console.WriteLine("так - [1]");
        Console.WriteLine("ні - [0]");
        randomValues = InputNumber.ReadInt(0, 1) == 0 ? true : false;

        Vector vectorTest3 = new Vector(length, randomValues);

        int a, b;

        Console.WriteLine("Введіть мінмальне значення інтервалу a (мінімум -10,максимум 10)");
        a = InputNumber.ReadInt(-10, 10);
        Console.WriteLine("Введіть мінмальне значення інтервалу b (мінімум " + a + ",максимум 10)");
        b = InputNumber.ReadInt(a, 10);

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Вектор:");
        vectorTest3.Display();
        Console.WriteLine();
        Console.WriteLine("Стискаємо масив, вилучаючи значення в інтервалі [a, b]:");
        vectorTest3.CompressVectorArray(a, b);
        vectorTest3.Display();

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("---------------------------------------------------------------");
        Console.WriteLine();

        Console.WriteLine("Введіть кількість рядків та стовпців (максимум 20)");
        int size = InputNumber.ReadInt(1, 20);
        Console.WriteLine("Ввести значення самостійно?");
        Console.WriteLine("так - [1]");
        Console.WriteLine("ні - [0]");
        randomValues = InputNumber.ReadInt(0, 1) == 0 ? true : false;
        Console.WriteLine("Введіть значення k (максимум " + size + ")");
        int k = InputNumber.ReadInt(1, size);

        Matrix matrixTest1 = new Matrix(size, size, randomValues);

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Матриця:");
        matrixTest1.Display();
        Console.WriteLine();
        Console.WriteLine("Зсуваємо кожен парний рядок на значення k:");
        matrixTest1.ShiftEvenRows(k);
        matrixTest1.Display();

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("---------------------------------------------------------------");
        Console.WriteLine();

        Console.WriteLine("Введіть кількість рядків (максимум 20)");
        int rows = InputNumber.ReadInt(1, 20);
        Console.WriteLine("Введіть кількість стовпців (максимум 20)");
        int cols = InputNumber.ReadInt(1, 20);
        Console.WriteLine("Ввести значення самостійно?");
        Console.WriteLine("так - [1]");
        Console.WriteLine("ні - [0]");
        randomValues = InputNumber.ReadInt(0, 1) == 0 ? true : false;

        Matrix matrixTest2 = new Matrix(rows, cols, randomValues);

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Матриця:");
        matrixTest2.Display();
        Console.WriteLine();
        Console.WriteLine("Зводимо матрицю до трикутного вигляду:");
        matrixTest2.TriangularizeMatrix();
        matrixTest2.Display();

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("---------------------------------------------------------------");
        Console.WriteLine();

        Console.WriteLine("Введіть кількість рядків (максимум 20)");
        rows = InputNumber.ReadInt(1, 20);
        Console.WriteLine("Введіть кількість стовпців (максимум 20)");
        cols = InputNumber.ReadInt(1, 20);
        Console.WriteLine("Ввести значення самостійно?");
        Console.WriteLine("так - [1]");
        Console.WriteLine("ні - [0]");
        randomValues = InputNumber.ReadInt(0, 1) == 0 ? true : false;

        Matrix matrixTest3 = new Matrix(rows, cols, randomValues);

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Введіть значення k (максимум 10)");
        k = InputNumber.ReadInt(1, 10);
        Console.WriteLine("Матриця:");
        matrixTest3.Display();
        Console.WriteLine();
        Console.WriteLine("Кількість рядків матриці, середнє арифметичне елементів яких менше за задану величину:");
        Console.WriteLine(matrixTest3.CountRowsWithAverageLessThanValue(k));
    }
}