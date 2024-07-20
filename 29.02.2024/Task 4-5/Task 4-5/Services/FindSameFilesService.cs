using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Task_4_5.Services;

static class FindSameFilesService
{

    public static async Task Find(string FromPath) 
    {
        String[] Paths = Directory.GetFiles(FromPath);
        int CopiedFile = 0;

        for (int i = 0; i < Paths.Length; i++)
        {
            string[] Path = Paths[i].Split('\\');
            string[] Splited = Path[Path.Length - 1].Split('.');
            string[] FileName = Splited[0].Split(' '); 
            string IsCopy = FileName[FileName.Length - 1];
          
            if(IsCopy == "копия")
            {

                FileInfo fileInfo = new(Paths[i]);
                fileInfo.MoveTo($"{fileInfo.Name}");
                using FileStream fileStream = new("History.txt", FileMode.OpenOrCreate);
                using StreamWriter streamWriter = new StreamWriter(fileStream);
                streamWriter.WriteLine($"Dublicate File {fileInfo.Name} was moved from {Paths[i]} to net8.0 - Windows ");
            }
            
        }

        return ;
    }

    
}
