## Behavioral Design Patterns

### **Visitor** ###

##### Мотивация
Моделът Visitor ви позволява да се отдели един алгоритъм от сравнително сложен обект, върху който той оперира. Резултатът от това разделяне е модел на данните с ограничена функционалност и набор от посетителите, които извършват операции върху данните. Друго предимство е възможността да се добави нов посетител без да се променя съществуващата структура.
##### Цел
Спомага за разхлабването на връзките и дава възможност за допълнителни операции, които се добавят без да се променят класовете данни.
 
##### Приложение


##### Имплементация

```c#    
interface IElementBase
    {
        void Accept(IVisitorBase visitor);
    }
public class Body : IElementBase
    {
        public Body(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public void Accept(IVisitorBase visitor)
        {
            visitor.Visit(this);
        }
    }
public class Engine : IElementBase
    {
        public Engine(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public void Accept(IVisitorBase visitor)
        {
            visitor.Visit(this);
        }
    }
public class Wheel : IElementBase
    {
        public Wheel(string name)
        {
            this.Name = name;
        }

        public string Tire { get; set; }

        public string Name { get; set; }

        public void Accept(IVisitorBase visitor)
        {
            visitor.Visit(this);
        }
    }
public class Transmission : IElementBase
    {
        public Transmission(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public void Accept(IVisitorBase visitor)
        {
            visitor.Visit(this);
        }
    }
public interface IVisitorBase
    {
        void Visit(Wheel wheel);
        void Visit(Body body);
        void Visit(Engine engine);
        void Visit(Transmission transmission);
    }
public class CarElementPrintVisitor : IVisitorBase
    {
        public void Visit(Wheel wheel)
        {
            Console.WriteLine("Wheel ({0}): {1}", wheel.Name, wheel.Tire);
        }

        public void Visit(Body body)
        {
            Console.WriteLine("Body: {0}", body.Name);
        }

        public void Visit(Engine engine)
        {
            Console.WriteLine("Engine: {0}", engine.Name);
        }

        public void Visit(Transmission transmission)
        {
            Console.WriteLine("Transmission: {0}", transmission.Name);
        }
    }
 public class Car : IElementBase
    {
        private readonly List<IElementBase> parts;

        public Car()
        {
            this.parts = new List<IElementBase>
                   {
                       new Wheel("Front Left"){Tire = "Michelin Pilot Super Sport"},
                       new Wheel("Front Right"){Tire = "Michelin Pilot Super Sport"},
                       new Wheel("Back Left"){Tire = "Michelin Pilot Super Sport"},
                       new Wheel("Back Right"){Tire = "Michelin Pilot Super Sport"},
                       new Engine("3.3 TDI 225"),
                       new Body("4-door sedan"),
                       new Transmission("5-speed manual")
                   };
        }

        public void Accept(IVisitorBase visitor)
        {
            foreach (var part in this.parts)
            {
                part.Accept(visitor);
            }
        }
    }
public class Program
    {
        static void Main()
        {
            var visitor = new CarElementPrintVisitor();

            var car = new Car();
            car.Accept(visitor);
        }
    }

```
##### Участници
Client

ObjectStructure

ElementBase

ConcreteElement

VisitorBase

ConcreteVisitor

##### Структура

![](https://github.com/dchakov/High-Quality-Code-HomeWork/blob/master/17-Design%20Patterns/BehavioralPatterns/images/Visitor.jpg)

