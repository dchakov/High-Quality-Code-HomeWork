namespace Prototype
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var stormCommander = new Commander();
            var infantry = new Infantry();


            var stormCommander2 = stormCommander.Clone() as Commander;
            var infantry2 = infantry.Clone() as Infantry;


            if (stormCommander2 != null)
                Console.WriteLine("Firepower: {0}, Armor: {1}", stormCommander2.FirePower, stormCommander2.Armor);

            if (infantry2 != null)
                Console.WriteLine("Firepower: {0}, Armor: {1}", infantry2.FirePower, infantry2.Armor);
        }
    }
}
