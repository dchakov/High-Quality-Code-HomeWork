namespace WalkInMatrix.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class WalkInMatrixTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMatrixLowerBoundaryValueShouldThrow_Zero()
        {
            Matrix matrix = new Matrix(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMatrixLowerBoundaryValueShouldThrow_NegativeNumber()
        {
            Matrix matrix = new Matrix(-3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMatrixUpperValueShouldThrow()
        {
            Matrix matrix = new Matrix(200);
        }

        [TestMethod]
        public void TestMatrixToString()
        {
            Matrix matrix = new Matrix(2);
            string expected = string.Format(
                "  1  4" + Environment.NewLine +
                "  3  2" + Environment.NewLine);
            Assert.AreEqual(expected, matrix.ToString());
        }

        [TestMethod]
        public void MatrixFindNextEmptyCell()
        {
            int[,] matrix = new int[,]
            {
                {1,2,3},
                {1,2,3},
                {0,2,3}
            };
            int emptyCellRow = 0;
            int emptyCellCol = 0;
            MatrixUtils.FindNextEmptyCell(matrix, out emptyCellRow, out emptyCellCol);
            Assert.AreEqual(2, emptyCellRow);
            Assert.AreEqual(0, emptyCellCol);
        }

        [TestMethod]
        public void MatrixGetNextDirection()
        {
            int[,] matrix = new int[,]
            {
                {1,2,3},
                {1,2,3},
                {0,2,3}
            };
            int dirX = 0;
            int dirY = 1;
            MatrixUtils.GetNextDirection(ref dirX,ref dirY);
            Assert.AreEqual(1, dirX);
            Assert.AreEqual(1, dirY);
        }
    }
}
