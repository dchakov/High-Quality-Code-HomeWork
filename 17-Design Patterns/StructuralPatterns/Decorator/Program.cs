using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public class Program
    {
        public static void Main()
        {
            Sandwich veggie = new VeggieSandwich();
            Console.WriteLine(veggie.GetPrice());
            Console.WriteLine(veggie.GetDescription());
            var veggieCheese = new Cheese(veggie);
            Console.WriteLine(veggieCheese.GetPrice());
            Console.WriteLine(veggieCheese.GetDescription());
            var veggieCheeseCorn = new Corn(veggieCheese);
            Console.WriteLine(veggieCheeseCorn.GetPrice());
            Console.WriteLine(veggieCheeseCorn.GetDescription());

            var tuna = new Corn(new Olives(new TunaSandwich()));
            Console.WriteLine(tuna.GetPrice());
            Console.WriteLine(tuna.GetDescription());

        }
    }
}
