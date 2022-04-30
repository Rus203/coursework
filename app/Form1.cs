using System.Diagnostics;
using Solution;

namespace app
{
    public partial class Form1 : Form
    {
        private double[,] matrixA;
        private double[] matrixB;
        private double[,] matrixL;
        private double[,] matrixU;
        private double[] matrixX;

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
        }

        private void btn_solve_Click(object sender, EventArgs e)
        {
            matrixA = new double[Size, Size];
            matrixB = new double[Size];
            matrixL = new double[Size, Size];
            matrixU = new double[Size, Size];
            matrixX = new double[Size];

                SetMatrixA();
                SetMatrixB();
                luMethod = new LuMethod(matrixA, matrixB, Size);
                matrixU = (luMethod.GetUMatrix());
                matrixL = (luMethod.GetLMatrix());
                matrixX = (luMethod.GetXMatrix());
                FillInDataGridViewLU();
                FillInDataGridViewX();            
        }

        private void SetMatrixA()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    try
                    {
                        double value = Convert.ToDouble(dataGridViewA[j, i].Value);
                        matrixA[i, j] = value;
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show($"In the matrix \"A\" was made the mistake at the position - {i},{j}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        i = Size; 
                        j = Size;
                    }
                }
            }
        }

        private void SetMatrixB()
        {
            for (int i = 0; i < Size; i++)
            {
                try
                {
                    double value = Convert.ToDouble(dataGridViewB[0, i].Value);
                    matrixB[i] = value;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show($"In the matrix \"B\" was made the mistake at the position - {i}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    i = Size;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
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
                    dataGridViewL[j, i].Value = matrixL[i, j];
                    dataGridViewU[j, i].Value = matrixU[i, j];
                }
            }
        }
        
        public void FillInDataGridViewX()
        {
            Boolean hasSolution = true;
            for (int i = 0; i < Size; i++)
            {
                double item = matrixX[i];
                if ( Double.IsNaN(item))
                {
                    hasSolution = false;
                }
                dataGridViewX[0, i].Value = item;
            }

            if(!hasSolution)
            {
                MessageBox.Show("The equation has no solutions", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private async void btnSave_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();

            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.Title = "Browse Text Files";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = "result.txt";
            saveFileDialog.CheckPathExists = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var myStream = saveFileDialog.OpenFile();

                    if (myStream != null)
                    {
                        using (StreamWriter sw = new StreamWriter(myStream))
                        {
                            await sw.WriteLineAsync("=== Answer ===");
                            for (int i = 0; i < Size; i++)
                            {
                                sw.WriteLine($"x{ i + 1 } = { dataGridViewX[0, i].Value }");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
           
        private async void btnLoad_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();

            openFileDialog.InitialDirectory = path;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Title = "Browse Text Files";
            openFileDialog.FileName = "input data";
            openFileDialog.DefaultExt = "txt";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        string? line;
                        int j = 0;
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (line.Contains("=") || line == String.Empty)
                            {
                                continue;
                            }

                            string[] test = line.Trim().Split(" ");
                            for (int i = 0; i < Size ; i++)
                            {
                                dataGridViewA[i, j].Value = test[i];
                            }
                            dataGridViewB[0, j].Value = test[^1];
                            j++;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}