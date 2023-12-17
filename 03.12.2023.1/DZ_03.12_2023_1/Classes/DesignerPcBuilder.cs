using hw.PC.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw.PC.Classes
{
    public class DesignerPcBuilder : IPcBuilder
    {
        private Pc pc = new Pc();


        public void BuildProcessor()
        {
            pc.Processor = "Intel Core i3 10th gen";
        }

        public void BuildMemory()
        {
            pc.Memory = "8GB";
        }

        public void BuildVideoCard()
        {
            pc.VideoCard = "Nvidia GeForce GT 730";
        }

        public void BuildHardDisk()
        {
            pc.HardDisk = "256GB";
        }
        public Pc GetPc()
        {
            return pc;
        }
    }
}
