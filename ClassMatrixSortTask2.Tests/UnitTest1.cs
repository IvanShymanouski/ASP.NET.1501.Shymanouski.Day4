using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using ClassMatrixSortTask2;

namespace ClassMatrixSortTask2.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            const int xSize=10;

            int[][] matrix = new int[xSize][];
            Random random = new Random();

            for (int i = 0; i < xSize; i++)
            {
                int ySize = random.Next(1,11);
                matrix[i] = new int[ySize];
                for (int j = 0; j < ySize; j++)
                {
                    matrix[i][j] = random.Next(0,1000);
                }
            }
            int[][] matrix1 = (Int32[][])matrix.Clone();
                    
            Func<int[],int> selector=i => i.Max();
            Func<int, int, bool> compare = (i, j) => i < j;

            MatrixSort.Sort(matrix, selector , compare);

        }
    }
}
