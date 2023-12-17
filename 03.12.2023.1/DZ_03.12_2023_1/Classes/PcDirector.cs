using hw.PC.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw.PC.Classes
{
    public class PcDirector
    {
        public void ConstructPc(IPcBuilder builder)
        {
            builder.BuildProcessor();
            builder.BuildHardDisk();
            builder.BuildVideoCard();
            builder.BuildMemory();
        }
    }
}
