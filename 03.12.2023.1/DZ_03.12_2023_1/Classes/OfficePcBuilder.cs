using hw.PC.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw.PC.Classes
{
    public class OfficePcBuilder : IPcBuilder
    {
        private Pc Pc = new Pc();


        public void BuildProcessor()
        {
            Pc.Processor = "Intel Core i5 10th Gen";
        }

        public void BuildMemory()
        {
            Pc.Memory = "16GB";
        }

        public void BuildVideoCard()
        {
            Pc.VideoCard = "Nvidia GeForce GT 730";
        }

        public void BuildHardDisk()
        {
            Pc.HardDisk = "512GB";
        }

        public Pc GetPc()
        {
            return Pc;
        }
    }
}
