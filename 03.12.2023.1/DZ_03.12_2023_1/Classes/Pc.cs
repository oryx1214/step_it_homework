using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw.PC.Classes
{
    public class Pc
    {
        public string? Processor;
        public string? Memory;
        public string? VideoCard;
        public string? HardDisk;
        public void DisplayInformation()
        {
            Console.WriteLine($"Processor: {Processor}\n" +
                $"VideoCard: {VideoCard}\n" +
                $"Memory: {Memory}\n" +
                $"HardDisk: {HardDisk}");
        }
    }
}
