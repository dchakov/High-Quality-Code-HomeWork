## Structural Design Patterns

### **Facade** ###

##### Мотивация
Моделът Facade е модел дизайн, който се използва, за да се опрости достъпа до функционалност в сложни или недобре разработени подсистеми. Класът на Facade осигурява прост, еднокласови интерфейс, който крие подробностите по изпълнението на основните код.
Можем да кажем, че моделът е някаква обвивка, която съдържа набор от членовете които са лесни за разбиране и ползване.

##### Цел
Предоставя уеднаквен интерфейс за редица интерфейси. Дефинира интерфейс от по-високо ниво, което прави по-лесна употребата на подсистемата.
Моделът прави софтуерната библиотека лесна за използване, разбиране и тестване. Прави библиотеката по-разбираема и може да намали зависимостите.
 
##### Приложение
Този модел е много полезен, когато се занимава с много независими класове или групи, които изискват използването на множество методи, особено когато те са трудни за използване или трудни за разбиране.


##### Употреба
Този модел се използва, когато подсистемата е лошо проектирана и може да няма възможност за рефактуриране на кода.

##### Имплементация

```c#    
public class CPU
    {
        public void Freeze()
        {
            Console.WriteLine("CPU is frozen");
        }

        public void Jump(long position)
        {
            Console.WriteLine("Jumping to position: {0}", position);
        }

        public void Execute()
        {
            Console.WriteLine("Executing...");
        }
    }

 public class HardDrive
    {
        public byte[] Read(int size)
        {
            var bytes = new byte[size];
            var random = new Random();
            random.NextBytes(bytes);
            return bytes;
        }
    }

public class Memory
    {
        public void Load(byte[] data)
        {
            Console.WriteLine("Loading data: ");
            foreach (var b in data)
            {
                Console.Write(b + " ");
                Thread.Sleep(700);
            }

            Console.WriteLine("\nLoading compleded");
        }
    }

 public class Computer
    {
        private readonly CPU cpu;
        private readonly HardDrive hardDrive;
        private readonly Memory memory;

        private const long BootAddress = 1;
        private const int SectorSize = 5;

        public Computer()
        {
            cpu = new CPU();
            hardDrive = new HardDrive();
            memory = new Memory();
        }

        public void Start()
        {
            cpu.Freeze();
            memory.Load(hardDrive.Read(SectorSize));
            cpu.Jump(BootAddress);
            cpu.Execute();
        }
    }

public class Program
    {
        static void Main()
        {
            var computer = new Computer();
            computer.Start();
        }
    }

```
##### Участници
Facade

PackageA/B

ClassA/B

##### Структура

![](https://github.com/dchakov/High-Quality-Code-HomeWork/blob/master/17-Design%20Patterns/StructuralPatterns/images/Facade.jpg)

