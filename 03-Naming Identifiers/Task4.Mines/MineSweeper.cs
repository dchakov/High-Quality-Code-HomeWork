namespace MineSweeper
{
    using System;
    using System.Collections.Generic;

    public class MineSweeper
    {
        public static void Main()
        {
            const int MAX_MOVES = 35;

            string command = string.Empty;
            char[,] playBoard = CreatePlayBoard();
            char[,] mines = PutRandomMines();
            int counter = 0;
            bool stepOnMine = false;
            List<Points> championsList = new List<Points>(6);
            int row = 0;
            int column = 0;
            bool commandStart = true;
            bool isMaxMoves = false;

            do
            {
                if (commandStart)
                {
                    Console.WriteLine("Let's play Mines.Try to find all fields without mines." +
                    " Command 'top' shows score table, 'restart' starts a new game, 'exit' quits the game!");
                    PrintBoard(playBoard);
                    commandStart = false;
                }

                Console.Write("Please, enter row and column or command : ");
                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                        int.TryParse(command[2].ToString(), out column) &&
                            row <= playBoard.GetLength(0) && column <= playBoard.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        PrintFinalScore(championsList);
                        break;

                    case "restart":
                        playBoard = CreatePlayBoard();
                        mines = PutRandomMines();
                        PrintBoard(playBoard);
                        stepOnMine = false;
                        commandStart = false;
                        break;

                    case "exit":
                        Console.WriteLine("Bye, Bye!");
                        break;

                    case "turn":
                        if (mines[row, column] != '*')
                        {
                            if (mines[row, column] == '-')
                            {
                                PlayerMove(playBoard, mines, row, column);
                                counter++;
                            }

                            if (MAX_MOVES == counter)
                            {
                                isMaxMoves = true;
                            }
                            else
                            {
                                PrintBoard(playBoard);
                            }
                        }
                        else
                        {
                            stepOnMine = true;
                        }

                        break;

                    default:
                        Console.WriteLine("\nError! Invalid command\n");
                        break;
                }

                if (stepOnMine)
                {
                    PrintBoard(mines);
                    Console.Write("\nGame over!Your are death with {0} points. " + "Please, enter your nickname: ", counter);
                    string nickname = Console.ReadLine();
                    Points playerScore = new Points(nickname, counter);

                    if (championsList.Count < 5)
                    {
                        championsList.Add(playerScore);
                    }
                    else
                    {
                        for (int i = 0; i < championsList.Count; i++)
                        {
                            if (championsList[i].Score < playerScore.Score)
                            {
                                championsList.Insert(i, playerScore);
                                championsList.RemoveAt(championsList.Count - 1);
                                break;
                            }
                        }
                    }

                    championsList.Sort((Points player1, Points player2) => player2.Name.CompareTo(player1.Name));
                    championsList.Sort((Points player1, Points player2) => player2.Score.CompareTo(player1.Score));
                    PrintFinalScore(championsList);

                    playBoard = CreatePlayBoard();
                    mines = PutRandomMines();
                    counter = 0;
                    stepOnMine = false;
                    commandStart = true;
                }

                if (isMaxMoves)
                {
                    Console.WriteLine("\nExcellent.You open 35 cells.");
                    PrintBoard(mines);
                    Console.WriteLine("Please, enter your name: ");
                    string name = Console.ReadLine();
                    Points player = new Points(name, counter);
                    championsList.Add(player);
                    PrintFinalScore(championsList);
                    playBoard = CreatePlayBoard();
                    mines = PutRandomMines();
                    counter = 0;
                    isMaxMoves = false;
                    commandStart = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria");
            Console.Read();
        }

        private static void PrintFinalScore(List<Points> points)
        {
            Console.WriteLine("\nScore:");
            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} boxes", i + 1, points[i].Name, points[i].Score);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty Score list!\n");
            }
        }

        private static void PlayerMove(char[,] playBoardField, char[,] mines, int row, int column)
        {
            char counterMines = CountMines(mines, row, column);
            mines[row, column] = counterMines;
            playBoardField[row, column] = counterMines;
        }

        private static void PrintBoard(char[,] board)
        {
            int row = board.GetLength(0);
            int col = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < row; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < col; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreatePlayBoard()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] PutRandomMines()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];

            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '-';
                }
            }

            List<int> minesList = new List<int>();

            while (minesList.Count < 15)
            {
                Random random = new Random();
                int mineNumber = random.Next(50);
                if (!minesList.Contains(mineNumber))
                {
                    minesList.Add(mineNumber);
                }
            }

            foreach (int mineNumber in minesList)
            {
                int col = mineNumber / boardColumns;
                int row = mineNumber % boardColumns;
                if (row == 0 && mineNumber != 0)
                {
                    col--;
                    row = boardColumns;
                }
                else
                {
                    row++;
                }

                board[col, row - 1] = '*';
            }

            return board;
        }

        private static void CalculateNeighbourMines(char[,] board)
        {
            int col = board.GetLength(0);
            int row = board.GetLength(1);

            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (board[i, j] != '*')
                    {
                        char counter = CountMines(board, i, j);
                        board[i, j] = counter;
                    }
                }
            }
        }

        private static char CountMines(char[,] playField, int row, int column)
        {
            int counter = 0;
            int rows = playField.GetLength(0);
            int cols = playField.GetLength(1);

            if (row - 1 >= 0)
            {
                if (playField[row - 1, column] == '*')
                {
                    counter++;
                }
            }

            if (row + 1 < rows)
            {
                if (playField[row + 1, column] == '*')
                {
                    counter++;
                }
            }

            if (column - 1 >= 0)
            {
                if (playField[row, column - 1] == '*')
                {
                    counter++;
                }
            }

            if (column + 1 < cols)
            {
                if (playField[row, column + 1] == '*')
                {
                    counter++;
                }
            }

            if ((row - 1 >= 0) && (column - 1 >= 0))
            {
                if (playField[row - 1, column - 1] == '*')
                {
                    counter++;
                }
            }

            if ((row - 1 >= 0) && (column + 1 < cols))
            {
                if (playField[row - 1, column + 1] == '*')
                {
                    counter++;
                }
            }

            if ((row + 1 < rows) && (column - 1 >= 0))
            {
                if (playField[row + 1, column - 1] == '*')
                {
                    counter++;
                }
            }

            if ((row + 1 < rows) && (column + 1 < cols))
            {
                if (playField[row + 1, column + 1] == '*')
                {
                    counter++;
                }
            }

            return char.Parse(counter.ToString());
        }
    }
}
