using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxy;

class ProxyTextFile : ITextFile
{
    private RealTextFile realTextFile;
    private string filename;

    public ProxyTextFile(string filename)
    {
        this.filename = filename;
    }

    public void PrintContent()
    {
        if (realTextFile == null)
        {
            realTextFile = new RealTextFile(filename);
        }
        realTextFile.PrintContent();
    }       
}