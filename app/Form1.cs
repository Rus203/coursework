using Matrix;
using Solution;

namespace app
{
    public partial class Form1 : Form
    {
        private TwoDimensionalMatrix matrixA;
        private OneDimensionalMatrix matrixB;
        private TwoDimensionalMatrix matrixL;
        private TwoDimensionalMatrix matrixU;
        private OneDimensionalMatrix matrixX;

       
        private LuMethod luMethod;
        public int Size { get; set; }

        public Form1()
        {
            InitializeComponent();
            matrixSize.SelectedIndex = 1;
            Size = Convert.ToInt32(matrixSize.Text);


            dataGridViewA.RowCount = Size;
            dataGridViewA.ColumnCount = Size;

            dataGridViewB.RowCount = Size;
            dataGridViewB.ColumnCount = 1;

            dataGridViewX.RowCount = Size;
            dataGridViewX.ColumnCount = 1;

            clearDataGridViews();
            FillInMatrixAByTestData();  // I'll clear up it later
        }


        private void btn_solve_Click(object sender, EventArgs e)
        {
            matrixA = new TwoDimensionalMatrix(Size, Size);
            matrixB = new OneDimensionalMatrix(Size);
            matrixL = new TwoDimensionalMatrix(Size, Size);
            matrixU = new TwoDimensionalMatrix(Size, Size);
            matrixX = new OneDimensionalMatrix(Size);

            try
            {
                SetMatrixA();
                SetMatrixB();
                luMethod = new LuMethod(matrixA.GetMatrix(), matrixB.GetMatrix(), Size);
                matrixU = new TwoDimensionalMatrix(luMethod.GetUMatrix());
                matrixL = new TwoDimensionalMatrix(luMethod.GetLMatrix());
                matrixX = new OneDimensionalMatrix(luMethod.GetXMatrix());
                FillInDataGridViewLU();
                FillInDataGridViewX();
            }
            catch (FormatException)
            {
                labelError.Text = "*Try to enter only number in the matrixes.";
            }
            
        }

        private void SetMatrixA()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    double value = Convert.ToDouble(dataGridViewA[j, i].Value);
                    matrixA.SetItem(value, i, j);
                }
            }
        }

        private void SetMatrixB()
        {
            for (int i = 0; i < Size; i++)
            {
                double value = Convert.ToDouble(dataGridViewB[0, i].Value);
                matrixB.SetItem(value, i);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            matrixA.ClearMatrix();
            matrixB.ClearMatrix();
            clearDataGridViews();
        }


        private void clearDataGridViews()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    dataGridViewA[j, i].Value = 0;
                    dataGridViewL[j, i].Value = String.Empty;
                    dataGridViewU[j, i].Value = String.Empty;
                }

                dataGridViewB[0, i].Value = 0;
                dataGridViewX[0, i].Value = String.Empty;
            }
        }
        

        private void FillInDataGridViewsExtraZeros()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    string? cell = Convert.ToString(dataGridViewA[j, i].Value);
                    if (cell == String.Empty || cell == null)
                    {
                        dataGridViewA[j, i].Value = 0;
                    }   
                }

                dataGridViewB[0, i].Value = 0;
            }
        }

        public void FillInDataGridViewLU()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    dataGridViewL[j, i].Value = matrixL.GetItem(i, j);
                    dataGridViewU[j, i].Value = matrixU.GetItem(i, j);
                }
            }
        }
        
        public void FillInDataGridViewX()
        {
            for (int i = 0; i < Size; i++)
            {
                double item = matrixX.GetItem(i);
                if ( Double.IsNaN(item))
                {
                    MessageBox.Show("The equation has no solutions");
                    break;
                }
                dataGridViewX[0, i].Value = item;
            }
        }

        private void matrixSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            Size = Convert.ToInt32(matrixSize.Text);
            dataGridViewA.ColumnCount = Convert.ToInt32(Size);
            dataGridViewA.RowCount = Convert.ToInt32(Size);

            dataGridViewB.RowCount = Convert.ToInt32(Size);

            dataGridViewL.ColumnCount = Convert.ToInt32(Size);
            dataGridViewL.RowCount = Convert.ToInt32(Size);

            dataGridViewU.ColumnCount = Convert.ToInt32(Size);
            dataGridViewU.RowCount = Convert.ToInt32(Size);

            dataGridViewX.RowCount = Convert.ToInt32(Size);

            FillInDataGridViewsExtraZeros();
        }

        private void FillInMatrixAByTestData()
        {
            Random rnd = new Random();
            for (int i = 0; i < Size; i++)
            {
                for(int j = 0; j < Size; j++)
                {
                    dataGridViewA[j, i].Value = rnd.Next(1, 100);
                }
                dataGridViewB[0, i].Value = rnd.Next(1, 100);
            }
        }
    }
}