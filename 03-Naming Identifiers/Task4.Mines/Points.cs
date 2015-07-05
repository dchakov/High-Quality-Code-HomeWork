namespace MineSweeper
{
    public class Points
    {
        private string name;
        private int points;

        public Points()
        { 
        }

        public Points(string name, int points)
        {
            this.Name = name;
            this.Score = points;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Score
        {
            get { return this.points; }
            set { this.points = value; }
        }
    }
}
