using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace _29._02._2024.Services;
static class TextCheckService
{
    static public bool IsNull(string Sentence)
    {
        if (string.IsNullOrEmpty(Sentence))
        {
            MessageBox.Show("Write Something !");
            return true;
        }
        return false;
    }

    static public async Task<string> ShowAll(string EnteredTxtBox)
    {
        Thread.Sleep(1000);
        return
      $"Sentences Count : {Convert.ToString(await CountsService.SentenceCount(EnteredTxtBox))}\n" +
      $"Symbol Count : {Convert.ToString(await CountsService.SymbolCount(EnteredTxtBox))}\n" +
      $"Words Count : {Convert.ToString(await CountsService.WordCount(EnteredTxtBox))} \n" +
      $"Questions Sentence Count : {Convert.ToString(await CountsService.QuestionSentencesCount(EnteredTxtBox))}\n" +
      $"Exclamatory Sentences Count : {Convert.ToString(await CountsService.ExclamatorySentencesCount(EnteredTxtBox))}";
    }
}
