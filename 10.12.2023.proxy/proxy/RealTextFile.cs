using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxy;
class RealTextFile : ITextFile
{
    private string filename;
    private string content;

    public RealTextFile(string filename)
    {
        this.filename = filename;
        LoadContentFromFile();
    }

    private void LoadContentFromFile()
    {
        content = $"Content of file {filename}";
        Console.WriteLine($"Loading content from file: {filename}");
    }

    public void PrintContent()
    {
        Console.WriteLine($"Print content: {content}");
    }
}
