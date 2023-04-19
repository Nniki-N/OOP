

namespace Lab_3
{
    public class Vector3D : IVector
    {
        private double x;
        private double y;
        private double z;

        public Vector3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double Length()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }

        public IVector Sum(IVector vector)
        {
            Vector3D v = vector as Vector3D;
            if (v == null)
            {
                throw new ArgumentException("Argument must be a Vector3D object.");
            }

            return new Vector3D(x + v.x, y + v.y, z + v.z);
        }

        public IVector MultiplyByNumber(double number)
        {
            return new Vector3D(x * number, y * number, z * number);
        }

        public double DotProduct(IVector vector)
        {
            Vector3D v = vector as Vector3D;
            if (v == null)
            {
                throw new ArgumentException("Argument must be a Vector3D object.");
            }

            return x * v.x + y * v.y + z * v.z;
        }

        override public String ToString()
        {
            return "(" + x + ", " + y + ", " + z + ")";
        }
    }
}
