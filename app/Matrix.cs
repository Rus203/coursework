namespace Matrix
{
    class TwoDimensionalMatrix
    {
        private double[,] matrix;
        private int columns;
        private int rows;
        public int Rows
        {
            get { return rows; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Non positive rows of an array are forbidden");
                }
                else { rows = value; }
            }
        }

        public int Columns
        {
            get { return columns; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("No positive columns of an array are forbidden");
                }
                columns = value;
            }
        }

        public TwoDimensionalMatrix(int i, int j)
        {
            Rows = i;
            Columns = j;
            matrix = new double[Rows, Columns];
        }

        public TwoDimensionalMatrix(double[,] array)
        {
            Rows = array.GetLength(0);
            Columns = array.GetLength(1);
            matrix = array;
        }

        public double GetItem(int i, int j)
        {
            if (i >= Rows) 
            {
                throw new NullReferenceException(i.ToString());
            }
            else if (j >= Columns)
            {
                throw new NullReferenceException(j.ToString());
            }
            else { return matrix[i, j]; }
        }

        public void SetItem(double item, int i, int j)
        {
            if (i < Rows && j < Columns) { matrix[i, j] = item; }
        }

        public void ClearMatrix() { Array.Clear(matrix, 0, matrix.Length); }
        public double[,] GetMatrix() { return matrix; }
    }

    class OneDimensionalMatrix
    {
        private double[] matrix;
        private int order;
        public int Order 
        { 
            get { return order; } 
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("No positive order is forbidden");
                }
                order = value;
                    
            }
        }

        public OneDimensionalMatrix(int order)
        {
            Order = order;
            matrix = new double[Order];
        }

        public OneDimensionalMatrix(double[] array)
        {
            Order = array.Length;
            matrix = array;
        }

        public double GetItem(int index)
        {
            if (index >= matrix.Length) 
            {
                throw new NullReferenceException(index.ToString());
            }
            else 
            { 
                return matrix[index]; 
            }
        }

        public void SetItem(double item, int index)
        {
            if (index < matrix.Length) { matrix[index] = item; }
        }

        public void ClearMatrix() { Array.Clear(matrix, 0, matrix.Length); }
        public double[] GetMatrix() { return matrix; }
    }
}
