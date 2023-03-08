

namespace Lab_2
{
    class Vector
    {
        private int _length;
        private double[] _vector;

        public Vector()
        {
            _length = 10;
            _vector = new double[_length];

            Random random = new Random();

            for (int i = 0; i < _length; i++)
            {
                _vector[i] = Math.Round(random.NextDouble() * (10 - -10) + -10, 2);
            }
        }
        public Vector(int length, bool randomValues)
        {
            _length = length;
            _vector = new double[length];

            if (randomValues)
            {
                Random random = new Random();

                for (int i = 0; i < _length; i++)
                {
                    _vector[i] = Math.Round(random.NextDouble() * (10 - -10) + -10, 2);
                }
            }
            else
            {
                for (int i = 0; i < _length; i++)
                {
                    Console.WriteLine("Введіть значення " + (i + 1) + " елемента в масиві (від -10 до 10)");
                    double num = InputNumber.ReadDouble(-10, 10);
                    _vector[i] = num;
                }

            }
        }
        public Vector(int length, double[] vectorArray)
        {
            _length = length;
            _vector = new double[length];

            for (int i = 0; i < _length; i++)
            {
                _vector[i] = vectorArray[i];
            }
        }

        public int GetLength() => _length;
        public double[] GetVectorArray()
        {
            double[] vectorArray = new double[_length];

            for (int i = 0; i < _length; i++)
            {
                vectorArray[i] = _vector[i];
            }

            return vectorArray;
        }
       
        public void Display()
        {
            for (int i = 0; i < _length; i++)
            {
                Console.Write(_vector[i] + "\t");
            }
            Console.WriteLine();
        }

        public void ChangeEverythingAboveAverageToZro()
        {
            double sum = 0;
            double average = 0;

            for (int i = 0; i < _length; i++)
            {
                sum += _vector[i];
            }

            average = sum / _length;

            Console.WriteLine("Average:" + average);

            for (int i = 0; i < _length; i++)
            {
                if (_vector[i] > average)
                {
                    _vector[i] = 0;
                }
            }
        }

        public void CompressVectorArray(int a, int b)
        {
            int writeIndex = 0;
            for (int i = 0; i < _length; i++)
            {
                if (_vector[i] < a || _vector[i] > b)
                {
                    _vector[writeIndex++] = _vector[i];
                }
            }

            while (writeIndex < _length)
            {
                _vector[writeIndex++] = 0;
            }
        }

        public static double DotProduct(Vector vector1, Vector vector2)
        {
            if (vector1.GetLength() != vector2.GetLength())
            {
                throw new Exception("Vectors have different lenght");
            }

            int length = vector1.GetLength();
            double sum = 0;

            double[] vector1Array = vector1.GetVectorArray();
            double[] vector2Array = vector2.GetVectorArray();

            for (int i = 0; i < length; i++)
            {
                sum += vector1Array[i] * vector2Array[i];
            }

            return Math.Round(sum, 2);
        }
        public static Vector operator *(Vector vector, double num)
        {
            int length = vector.GetLength();
            double[] newArray = new double[length];

            double[] vectorArray = vector.GetVectorArray();

            for (int i = 0; i < length; i++)
            {
                newArray[i] = Math.Round(vectorArray[i] * num, 2);
            }

            return new Vector(length, newArray);
        }
        public static Vector operator /(Vector vector, double num)
        {
            int length = vector.GetLength();
            double[] newArray = new double[length];

            double[] vectorArray = vector.GetVectorArray();

            for (int i = 0; i < length; i++)
            {
                newArray[i] = Math.Round(vectorArray[i] / num, 2);
            }

            return new Vector(length, newArray);
        }
        public static Vector operator -(Vector vector1, Vector vector2)
        {
            if (vector1.GetLength() != vector2.GetLength())
            {
                throw new Exception("Vectors have different lenght");
            }
            int length = vector1.GetLength();
            double[] newArray = new double[length];

            double[] vector1Array = vector1.GetVectorArray();
            double[] vector2Array = vector2.GetVectorArray();

            for (int i = 0; i < length; i++)
            {
                newArray[i] = vector1Array[i] - vector2Array[i];
            }

            return new Vector(length, newArray);
        }
        public static Vector operator +(Vector vector1, Vector vector2)
        {
            if (vector1.GetLength() != vector2.GetLength())
            {
                throw new Exception("Vectors have different lenght");
            }
            int length = vector1.GetLength();
            double[] newArray = new double[length];

            double[] vector1Array = vector1.GetVectorArray();
            double[] vector2Array = vector2.GetVectorArray();

            for (int i = 0; i < length; i++)
            {
                newArray[i] = vector1Array[i] + vector2Array[i];
            }

            return new Vector(length, newArray);
        }
    }
}
