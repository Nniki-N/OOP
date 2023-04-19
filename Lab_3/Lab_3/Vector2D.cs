

namespace Lab_3
{
    public class Vector2D : IVector
    {
        private double x;
        private double y;

        public Vector2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double Length()
        {
            return Math.Sqrt(x * x + y * y);
        }

        public IVector Sum(IVector vector)
        {
            Vector2D v = vector as Vector2D;

            if (v == null)
            {
                throw new ArgumentException("Argument must be a Vector2D object.");
            }

            return new Vector2D(x + v.x, y + v.y);
        }

        public IVector MultiplyByNumber(double number)
        {
            return new Vector2D(x * number, y * number);
        }

        public double DotProduct(IVector vector)
        {
            Vector2D v = vector as Vector2D;
            if (v == null)
            {
                throw new ArgumentException("Argument must be a Vector2D object.");
            }

            return x * v.x + y * v.y;
        }

        override public String ToString()
        {
            return "(" + x + ", " + y + ")";
        }
    }
}
