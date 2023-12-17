using hw.PC.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw.PC.Interfaces
{
    public interface IPcBuilder
    {
        void BuildProcessor();
        void BuildMemory();
        void BuildVideoCard();
        void BuildHardDisk();
        Pc GetPc();

    }
}
