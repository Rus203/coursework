using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    class LuMethod
    {
        private int order;
        private int precision = 2;
        public int Order
        {
            get { return order; }
            private set
            {
                if (value < 2)
                { 
                    throw new ArgumentException("less order of an array are forbidden"); 
                }
                else
                {
                    order = value;
                }
            }
        }

        #region
        private double sum;
        private int i;
        private int k;
        private int j;
        private int p;

        private double[,] a = { { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 } };
        private double[,] l = { { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 } };
        private double[,] u = { { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 } };
        private double[] b = { 0, 0, 0, 0, 0, 0, 0 };
        private double[] z = { 0, 0, 0, 0, 0, 0, 0 };
        private double[] x = { 0, 0, 0, 0, 0, 0, 0 };
        #endregion

        public LuMethod(double[,] matrixA, double[] matrixB, int order)
        {
            Order = order;

            for (i = 1; i <= Order; i++)
            {
                for (j = 1; j <= Order; j++)
                {
                    a[i, j] = matrixA[i - 1, j - 1];
                }
                b[i] = matrixB[i - 1];
            }

            Decomposition();
        }

        private void Decomposition() // LU decomposition 
        {
            for (k = 1; k <= Order; k++)
            {
                u[k, k] = 1;
                for (i = k; i <= Order; i++)
                {
                    sum = 0;
                    for (p = 1; p <= k - 1; p++)
                    { 
                        sum += l[i, p] * u[p, k]; 
                    }
                    l[i, k] = a[i, k] - sum;
                }

                for (j = k + 1; j <= Order; j++)
                {
                    sum = 0;
                    for (p = 1; p <= k - 1; p++)
                    { 
                        sum += l[k, p] * u[p, j]; 
                    }
                    u[k, j] = (a[k, j] - sum) / l[k, k];
                }
            }
        }

        private void ShowMatrix()
        {
            Console.WriteLine("L - matrix");
            for (i = 1; i <= Order; i++)
            {
                for (j = 1; j <= Order; j++)
                { 
                    Console.Write(l[i, j] + " "); 
                }
                Console.WriteLine();
            }

            Console.WriteLine("U - matrix");
            for (i = 1; i <= Order; i++)
            {
                for (j = 1; j <= Order; j++)
                { 
                    Console.Write(u[i, j] + " "); 
                }
                Console.WriteLine();
            }
        }

        public double[,] GetLMatrix()
        {
            double[,] lMatrix = new double[Order, Order];
            for (i = 1; i <= Order; i++)
            {
                for (j = 1; j <= Order; j++)
                { 
                    lMatrix[i - 1, j - 1] = Math.Round(l[i, j], precision); 
                }
            }
            return lMatrix;
        }

        public double[,] GetUMatrix()
        {
            double[,] uMatrix = new double[Order, Order];
            for (i = 1; i <= Order; i++)
            {
                for (j = 1; j <= Order; j++)
                {
                    uMatrix[i - 1, j - 1] = Math.Round(u[i, j], precision); 
                }
            }
            return uMatrix;
        }

        private void FindZMatrix()   // FINDING Z; LZ=b
        {
            for (i = 1; i <= Order; i++)         //forward subtitution method
            {
                sum = 0;
                for (p = 1; p < i; p++)
                { 
                    sum += l[i, p] * z[p]; 
                }

                z[i] = (b[i] - sum) / l[i, i];
            }
        }

        private void FindXMatrix()    // FINDING X; UX=Z
        {
            FindZMatrix();
            for (i = Order; i > 0; i--)
            {
                sum = 0;
                for (p = Order; p > i; p--)
                { 
                    sum += u[i, p] * x[p]; 
                }

                x[i] = (z[i] - sum) / u[i, i];
            }
        }

        public double[] GetXMatrix()
        {
            FindXMatrix();
            double[] answer = new double[Order];
            for (int i = 1; i <= Order; i++)
            { 
                answer[i - 1] = Math.Round(x[i], precision); 
            }
            return answer;
        }
    }
}
