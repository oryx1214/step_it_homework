using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29._02._2024.Services;

static class CountsService
{
    static public async Task<int> SentenceCount(string sentence)
    {
        int number = 0;
        for (int i = 0; i != sentence.Length; i++)
        {
            if (sentence[i] == '!' || sentence[i] == '.' || sentence[i] == '?') number++;
        }

        return number;
    }

    static public async Task<int> SymbolCount(string sentence)
    {

        int number = 0;
        for (int i = 0; i != sentence.Length; i++)
        {
            if (sentence[i] != ' ') number++;
        }
        return number;
    }

    static public async Task<int> WordCount(string sentence)
    {
        bool IsWord = false;

        int WordsCount = 0;
        int Number = 0;
        for (int i = 0; i != sentence.Length; i++)
        {
            if (sentence[i] >= 65 && sentence[i] <= 90 || sentence[i] >= 97 && sentence[i] <= 122) Number++;
            else Number = 0;

            if (Number >= 2) { WordsCount++; Number = 0; }

        }
        return WordsCount;
    }

    static public async Task<int> QuestionSentencesCount(string sentence)
    {

        int Number = 0;
        for (int i = 0; i != sentence.Length; i++)
        {
            if (sentence[i] == '?') Number++;
        }
        return Number;
    }


    static public async Task<int> ExclamatorySentencesCount(string sentence)
    {

        int Number = 0;
        for (int i = 0; i != sentence.Length; i++)
        {
            if (sentence[i] == '!') Number++;
        }
        return Number;
    }
}
