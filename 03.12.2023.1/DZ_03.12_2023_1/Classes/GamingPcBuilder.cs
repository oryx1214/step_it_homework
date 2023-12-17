using hw.PC.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw.PC.Classes
{
    public class GamingPcBuilder : IPcBuilder
    {
        private Pc Pc = new Pc();


        public void BuildProcessor()
        {
            Pc.Processor = "Intel Core i7 9th Gen";
        }

        public void BuildMemory()
        {
            Pc.Memory = "16GB";
        }

        public void BuildVideoCard()
        {
            Pc.VideoCard = "Nvidia GeForce GTX 1660 ti";
        }

        public void BuildHardDisk()
        {
            Pc.HardDisk = "2TB ";
        }

        public Pc GetPc()
        {
            return Pc;
        }
    }
}
