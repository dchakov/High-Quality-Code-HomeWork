## Structural Design Patterns

### **Decorator** ###

##### Мотивация
Динамично добавя допълнителни отговорности на обект, като запазва интерфейса му. Декораторите предоставят гъвкава алтернатива на наследяването за разширяване на функционалността.

##### Цел
 Този шаблон може да бъде използван за разширяването на функционалността на опеределен клас по времето на изпълнение на програмата, като запазва интерфейса му.

 
##### Приложение


##### Употреба
Може да се използва за разширяване на функционалноста на потребителския интерфейс, както и разширяване на функционалността на запечтани класове.


##### Имплементация

```c#    
public abstract class Sandwich
    {
        public abstract string GetDescription();

        public abstract double GetPrice();

        public string Description { get; set; }
    }

 public class VeggieSandwich : Sandwich
    {
        public VeggieSandwich()
        {
            this.Description = "Veggie Sandwitch";
        }

        public override string GetDescription()
        {
            return this.Description;
        }

        public override double GetPrice()
        {
            return 2.70;
        }
    }

public class TunaSandwich : Sandwich
    {
        public TunaSandwich()
        {
            this.Description = "Tuna Sandwitch";
        }
        public override string GetDescription()
        {
            return this.Description;
        }

        public override double GetPrice()
        {
            return 5.20;
        }
    }

internal abstract class SandwichDecorator : Sandwich
    {
        protected Sandwich Sandwich { get; private set; }

        protected SandwichDecorator(Sandwich sandwich)
        {
            this.Sandwich = sandwich;
        }

        public override string GetDescription()
        {
            return this.Sandwich.GetDescription();
        }

        public override double GetPrice()
        {
            return this.Sandwich.GetPrice();
        }
    }

internal class Cheese : SandwichDecorator
    {
        public Cheese(Sandwich sandwich)
            : base(sandwich)
        {
            this.Description = "Cheese";
        }

        public override string GetDescription()
        {
            return this.Sandwich.GetDescription() + ", " + this.Description;
        }

        public override double GetPrice()
        {
            return this.Sandwich.GetPrice() + 1.23;
        }
    }

internal class Corn : SandwichDecorator
    {
        public Corn(Sandwich sandwich)
            : base(sandwich)
        {
            this.Description = "Corn";
        }

        public override string GetDescription()
        {
            return this.Sandwich.GetDescription() + ", " + this.Description;
        }

        public override double GetPrice()
        {
            return this.Sandwich.GetPrice() + 0.23;
        }
    }

internal class Olives : SandwichDecorator
    {
        public Olives(Sandwich sandwich)
            : base(sandwich)
        {
            this.Description = "Olives";
        }

        public override string GetDescription()
        {
            return this.Sandwich.GetDescription() + ", " + this.Description;
        }

        public override double GetPrice()
        {
            return this.Sandwich.GetPrice() + 0.78;
        }
    }

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

```
##### Участници
ComponentBase

ConcreteComponent

DecoratorBase

ConcreteDecorator

##### Структура

![](https://github.com/dchakov/High-Quality-Code-HomeWork/blob/master/17-Design%20Patterns/StructuralPatterns/images/Decorator.jpg)

