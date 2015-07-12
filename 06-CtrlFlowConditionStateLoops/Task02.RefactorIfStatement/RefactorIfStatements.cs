namespace Task02.RefactorIfStatement
{
    using System;
    using Task01.Chef;

    public class RefactorIfStatements
    {
        public const int MinX = 2;
        public const int MaxX = 5;
        public const int MinY = 1;
        public const int MaxY = 10;

        public static void Main()
        {
            /*
            Potato potato;
            if (potato != null)
                if (!potato.HasNotBeenPeeled && !potato.IsRotten)
                    Cook(potato);
            */
            Potato potato = new Potato();
            Chef chef = new Chef();

            potato.IsPeeled = true;
            potato.IsRotten = false;

            if (potato != null)
            {
                if (potato.IsPeeled && !potato.IsRotten)
                {
                    chef.Cook(potato);
                }
            }

            /*
            if (x >= MIN_X && (x =< MAX_X && ((MAX_Y >= y && MIN_Y <= y) && !shouldNotVisitCell)))
            {
               VisitCell();
            }
             */
            int x = 4;
            int y = 5;

            bool shouldVisitCell = true;

            if (InRange(x, y) && shouldVisitCell)
            {
                VisitCell();
            }
        }

        private static void VisitCell()
        {
            Console.WriteLine("Cell visited");
        }

        private static bool InRange(int x, int y)
        {
            bool inRange = MinX <= x && x <= MaxX &&
                           MinY <= y && y <= MaxY;

            return inRange;
        }
    }
}
