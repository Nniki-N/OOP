

namespace Lab_2
{
    class Matrix
    {
        private double[,] _matrix;
        private int _rows;
        private int _cols;

        public Matrix()
        {
            Random random = new Random();

            _rows = 3;
            _cols = 3;

            _matrix = new double[_rows, _cols];

            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _cols; j++)
                {
                    _matrix[i, j] = random.Next(-10, 10 + 1);
                }
            }
        }
        public Matrix(int rows, int cols, bool randomVelues)
        {
            _rows = rows;
            _cols = cols;
            _matrix = new double[_rows, _cols];

            if (randomVelues)
            {
                Console.WriteLine("Матриця згенерована рандомно");

                Random random = new Random();

                for (int i = 0; i < _rows; i++)
                {
                    for (int j = 0; j < _cols; j++)
                    {
                        _matrix[i, j] = random.Next(-10, 10 + 1);
                    }
                }
            }
            else
            {
                for (int i = 0; i < _rows; i++)
                {
                    for (int j = 0; j < _cols; j++)
                    {
                        Console.WriteLine("Введіть значення єлемента в рядку " + (i + 1) + " і стовпцю " + (j + 1) + ": (від -10 до 10)");
                        int num = InputNumber.ReadInt(-10, 10);
                        _matrix[i, j] = num;
                    }
                }
            }

        }
        public Matrix(int rows, int cols, int[,] matrix)
        {
            _rows = rows;
            _cols = cols;
            _matrix = new double[_rows, _cols];

            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _cols; j++)
                {
                    _matrix[i, j] = matrix[i, j];
                }
            }
        }

        public double[,] GetMatrix()
        {
            double[,] matrix = new double[_rows, _cols];

            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _cols; j++)
                {
                    matrix[i, j] = _matrix[i, j];
                }
            }
            return matrix;
        }
        public int GetRows() => _rows;
        public int GetCols() => _cols;

        public void Display()
        {
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _cols; j++)
                {
                    Console.Write(_matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public void ShiftEvenRows(int k)
        {

            for (int i = 1; i < _rows; i += 2)
            {
                double[] tempRow = new double[_cols];

                for (int j = 0; j < _cols; j++)
                {
                    int newIndex = (j + k) % _cols;
                    tempRow[newIndex] = _matrix[i, j];
                }

                for (int j = 0; j < _cols; j++)
                {
                    _matrix[i, j] = tempRow[j];
                }
            }
        }
        public void TriangularizeMatrix()
        {
            for (int i = 0; i < _rows; i++)
            {
                int maxRowIndex = i;
                for (int j = i + 1; j < _rows; j++)
                {
                    if (Math.Abs(_matrix[j, i]) > Math.Abs(_matrix[maxRowIndex, i]))
                    {
                        maxRowIndex = j;
                    }
                }

                if (maxRowIndex != i)
                {
                    for (int k = i; k < _cols; k++)
                    {
                        double temp = _matrix[i, k];
                        _matrix[i, k] = _matrix[maxRowIndex, k];
                        _matrix[maxRowIndex, k] = temp;
                    }
                }

                for (int j = i + 1; j < _rows; j++)
                {
                    for (int k = i + 1; k < _cols; k++)
                    {
                        _matrix[j, k] = _matrix[j, k] * _matrix[i, i] - _matrix[j, i] * _matrix[i, k];
                        _matrix[j, k] /= _matrix[i, i];
                    }
                    _matrix[j, i] = 0;
                }
            }

            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _rows; j++)
                {
                    _matrix[i, j] = Math.Round(_matrix[i, j], 3);
                }
            }
        }
        public int CountRowsWithAverageLessThanValue(double value)
        {
            int count = 0;

            for (int i = 0; i < _rows; i++)
            {
                double sum = 0.0;

                for (int j = 0; j < _cols; j++)
                {
                    sum += _matrix[i, j];
                }

                double average = sum / _cols;

                if (average < value)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
