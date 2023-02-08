
namespace Lab_1
{
    class TOderedArray : TArray
    {
        public TOderedArray() : base()
        {
            SortArray();
        }
        public TOderedArray(int length, bool randomValues) : base(length, randomValues)
        {
            SortArray();
        }
        public TOderedArray(int length, double[] array) : base(length, array)
        {
            SortArray();
        }
        public TOderedArray(TArray tArray) : base(tArray)
        {
            SortArray();
        }

        public static TOderedArray operator +(TOderedArray tArray, int num)
        {
            int length = tArray.GetLength();
            double[] newArray = new double[length + 1];

            double[] array = tArray.GetArray();

            for (int i = 0; i < length; i++)
            {
                newArray[i] = array[i];
            }

            newArray[length] = num;

            TOderedArray tOderedArray = new TOderedArray(length + 1, newArray);
            tOderedArray.SortArray();

            return tOderedArray;
        }
        public static TOderedArray operator -(TOderedArray tArray, int num)
        {
            int length = tArray.GetLength() - 1;
            double[] newArray = new double[length];

            double[] array = tArray.GetArray();

            bool returnOriginalArray = true;

            for (int i = 0; i < length + 1; i++)
            {
                if (array[i] == num)
                {
                    returnOriginalArray = false;
                    break;
                }
            }

            if (returnOriginalArray)
            {
                length = tArray.GetLength();
                newArray = new double[length];

                for (int i = 0; i < length; i++)
                {
                    newArray[i] = array[i];
                }

                return new TOderedArray(length, newArray);
            }

            bool isNumberRemoved = false;

            for (int i = 0; i < length; i++)
            {
                if (!isNumberRemoved && array[i] == num)
                {
                    isNumberRemoved = true;
                    continue;
                }

                newArray[i - (isNumberRemoved ? 1 : 0)] = array[i];
            }

            if (isNumberRemoved)
            {
                newArray[length - 1] = array[length];
            }
            else if (array[length] != num)
            {
                newArray[length - 1] = array[length];
            }

            return new TOderedArray(length, newArray);
        }
    }
}
