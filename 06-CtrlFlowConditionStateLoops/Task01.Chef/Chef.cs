namespace Task01.Chef
{
    using System;

    public class Chef
    {
        public void Cook()
        {
            Potato potato = this.GetPotato();
            this.Peel(potato);
            this.Cut(potato);

            Carrot carrot = this.GetCarrot();
            this.Peel(carrot);
            this.Cut(carrot);

            Bowl bowl = this.GetBowl();
            bowl.Add(potato);
            bowl.Add(carrot);

            Console.WriteLine(bowl.ToString());
        }
        private Bowl GetBowl()
        {
            return new Bowl();
        }

        private Potato GetPotato()
        {
            return new Potato();
        }

        private Carrot GetCarrot()
        {
            return new Carrot();
        }

        private void Peel(Vegetable vegetable)
        {
            Console.WriteLine("Peeling vegetable {0}", vegetable);
        }

        private void Cut(Vegetable vegetable)
        {
            Console.WriteLine("Cuting vegetable {0}", vegetable);
        }
    }
}
