
using Lab_3;

class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            Console.WriteLine("Enter first vector2D elements:");
            Console.Write("x: ");
            double x = InputNumber.ReadDouble(-10, 10);
            Console.Write("y: ");
            double y = InputNumber.ReadDouble(-10, 10);
            Vector2D firstVector2D = new Vector2D(x, y);


            Console.WriteLine();


            Console.WriteLine("Enter second vector2D elements:");
            Console.Write("x: ");
            x = InputNumber.ReadDouble(-10, 10);
            Console.Write("y: ");
            y = InputNumber.ReadDouble(-10, 10);
            Vector2D secondVector2D = new Vector2D(x, y);

            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("First vector2D length: " + firstVector2D.Length());
            Console.WriteLine("Sum of 2D vectors: " + firstVector2D.Sum(secondVector2D).ToString());

            Console.WriteLine("Enter number:");
            int number = InputNumber.ReadInt(-10, 10);

            Console.WriteLine("First vector2D multiplied by a number: " + firstVector2D.MultiplyByNumber(number).ToString());
            Console.WriteLine("Dot product of 2D vectors: " + firstVector2D.DotProduct(secondVector2D));



            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();



            Console.WriteLine("Enter first vector3D elements:");
            Console.Write("x: ");
            x = InputNumber.ReadDouble(-10, 10);
            Console.Write("y: ");
            y = InputNumber.ReadDouble(-10, 10);
            Console.Write("z: ");
            double z = InputNumber.ReadDouble(-10, 10);
            Vector3D firstVector3D = new Vector3D(x, y, z);


            Console.WriteLine();


            Console.WriteLine("Enter second vector3D elements:");
            Console.Write("x: ");
            x = InputNumber.ReadDouble(-10, 10);
            Console.Write("y: ");
            y = InputNumber.ReadDouble(-10, 10);
            Console.Write("z: ");
            z = InputNumber.ReadDouble(-10, 10);
            Vector3D secondVector3D = new Vector3D(x, y, z);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("First vector3D length: " + firstVector3D.Length());
            Console.WriteLine("Sum of 3D vectors: " + firstVector3D.Sum(secondVector3D).ToString());

            Console.WriteLine("Enter number:");
            number = InputNumber.ReadInt(-10, 10);

            Console.WriteLine("First vector3D multiplied by a number: " + firstVector3D.MultiplyByNumber(number).ToString());
            Console.WriteLine("Dot product of 3D vectors: " + firstVector3D.DotProduct(secondVector3D));
        } catch (Exception ex) {
            Console.WriteLine(ex.Message);
        }
    }
}