
namespace Facade
{
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
}
