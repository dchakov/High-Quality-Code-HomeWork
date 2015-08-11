namespace WalkInMatrix
{
    public static class MatrixUtils
    {
        private const int DirectionsLength = 8;
        private static readonly int[] DirectionX = { 1, 1, 1, 0, -1, -1, -1, 0 };
        private static readonly int[] DirectionY = { 1, 0, -1, -1, -1, 0, 1, 1 };

        public static void GetNextDirection(ref int dirX, ref int dirY)
        {
            int currentDirection = 0;
            for (int count = 0; count < DirectionsLength; count++)
            {
                if (DirectionX[count] == dirX && DirectionY[count] == dirY)
                {
                    currentDirection = count;
                    break;
                }
            }

            if (currentDirection == DirectionsLength - 1)
            {
                dirX = DirectionX[0];
                dirY = DirectionY[0];
                return;
            }

            dirX = DirectionX[currentDirection + 1];
            dirY = DirectionY[currentDirection + 1];
        }

        public static bool AreNeighbourCellsEmpty(int[,] matrix, int row, int col)
        {
            int[] directionX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionY = { 1, 0, -1, -1, -1, 0, 1, 1 };
            for (int i = 0; i < DirectionsLength; i++)
            {
                if (!IsInRange(matrix, row + directionX[i]))
                {
                    directionX[i] = 0;
                }

                if (!IsInRange(matrix, col + directionY[i]))
                {
                    directionY[i] = 0;
                }
            }

            for (int i = 0; i < DirectionsLength; i++)
            {
                if (matrix[row + directionX[i], col + directionY[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public static void FindNextEmptyCell(int[,] matrix, out int emptyCellRow, out int emptyCellCol)
        {
            emptyCellRow = 0;
            emptyCellCol = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    if (matrix[row, col] == 0)
                    {
                        emptyCellRow = row;
                        emptyCellCol = col;
                        return;
                    }
                }
            }
        }

        public static bool IsInRange(int[,] matrix, int value)
        {
            if (0 <= value && value < matrix.GetLength(0))
            {
                return true;
            }

            return false;
        }
    }
}