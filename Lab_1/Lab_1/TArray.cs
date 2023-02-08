
namespace Lab_1
{
    class TArray
    {
        private int _length;
        private double[] _array;

        public TArray()
        {
            _length = 10;
            _array = new double[_length];

            Random random = new Random();

            for (int i = 0; i < _length; i++)
            {
                _array[i] = random.Next(-10, 10 + 1);
            }
        }
        public TArray(int length, bool randomValues)
        {
            _length = length;
            _array = new double[length];

            if (randomValues)
            {
                Random random = new Random();

                for (int i = 0; i < _length; i++)
                {
                    _array[i] = random.Next(-10, 10 + 1);
                }
            }
            else
            {
                for (int i = 0; i < _length; i++)
                {
                    Console.WriteLine("Введіть значення " + (i + 1) + " елемента в масиві (від -10 до 10)");
                    int num = InputNumber.ReadInt(-10, 10);
                    _array[i] = num;
                }

            }
        }
        public TArray(int length, double[] array)
        {
            _length = length;
            _array = new double[length];

            for (int i = 0; i < _length; i++)
            {
                _array[i] = array[i];
            }
        }
        public TArray(TArray tArray)
        {
            _length = tArray.GetLength();
            _array = tArray.GetArray();
        }

        public int GetLength() => _length;
        public double[] GetArray()
        {
            double[] array = new double[_length];

            for (int i = 0; i < _length; i++)
            {
                array[i] = _array[i];
            }

            return array;
        }

        public void SetNewArray(int length)
        {
            _length = length;
            _array = new double[_length];

            for (int i = 0; i < _length; i++)
            {
                Console.WriteLine("Введіть значення " + (i + 1) + " елемента в масиві (від -10 до 10)");
                int num = InputNumber.ReadInt(-10, 10);
                _array[i] = num;
            }
        }


        public void Display()
        {
            for (int i = 0; i < _length; i++)
            {
                Console.Write(_array[i] + "\t");
            }
        }

        public double FindMax()
        {
            double max = double.MinValue;

            for (int i = 0; i < _length; i++)
            {
                if (max <= _array[i])
                {
                    max = _array[i];
                }
            }

            return max;
        }
        public double FindMin()
        {
            double min = double.MaxValue;

            for (int i = 0; i < _length; i++)
            {
                if (min >= _array[i])
                {
                    min = _array[i];
                }
            }

            return min;
        }
        public double FindSum()
        {
            double sum = 0;

            for (int i = 0; i < _length; i++)
            {
                sum += _array[i];
            }

            return sum;

        }

        public void SortArray()
        {
            SortMethod(_array, 0, _length - 1);
        }
        private void SortMethod(double[] array, int leftIndex, int rightIndex)
        {
            int i = leftIndex;
            int j = rightIndex;
            double pivot = array[leftIndex];

            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    double temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j) SortMethod(array, leftIndex, j);
            if (i < rightIndex) SortMethod(array, i, rightIndex);
        }

        public static TArray operator +(TArray tArray, int num)
        {
            int length = tArray.GetLength();
            double[] newArray = new double[length];

            double[] array = tArray.GetArray();

            for (int i = 0; i < length; i++)
            {
                newArray[i] = array[i] + num;
            }

            return new TArray(length, newArray);
        }
        public static TArray operator -(TArray tArray, int num)
        {
            int length = tArray.GetLength();
            double[] newArray = new double[length];

            double[] array = tArray.GetArray();

            for (int i = 0; i < length; i++)
            {
                newArray[i] = array[i] - num;
            }

            return new TArray(length, newArray);
        }
        public static TArray operator *(TArray tArray, int num)
        {
            int length = tArray.GetLength();
            double[] newArray = new double[length];

            double[] array = tArray.GetArray();

            for (int i = 0; i < length; i++)
            {
                newArray[i] = array[i] * num;
            }

            return new TArray(length, newArray);
        }
    }
}
