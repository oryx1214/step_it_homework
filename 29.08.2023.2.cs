// class Program
// {
//     static void Main()
//     {
//         double[] A = new double[10];
//         Console.WriteLine("enter 10 numbers to array A:");
//         for (int i = 0; i < A.Length; i++)
//         {
//             A[i] = Convert.ToDouble(Console.ReadLine());
//         }
//
//         double[,] B = new double[3, 4];
//         Random rand = new Random();
//         Console.WriteLine("array B random nums:");
//         for (int i = 0; i < 3; i++)
//         {
//             for (int j = 0; j < 4; j++)
//             {
//                 B[i, j] = rand.NextDouble() * 100; 
//                 Console.Write($"{B[i, j]:N}\t");
//             }
//             Console.WriteLine();
//         }
//         double maxA = A[0], minA = A[0], maxB = B[0, 0], minB = B[0, 0];
//
//         foreach (double num in A)
//         {
//             if (num > maxA)
//                 maxA = num;
//             if (num < minA)
//                 minA = num;
//         }
//         foreach (double num in B)
//         {
//             if (num > maxB)
//                 maxB = num;
//             if (num < minB)
//                 minB = num;
//         }
//         double summa = 0, prod = 1;
//
//         foreach (double num in A)
//         {
//             summa += num;
//             prod *= num;
//         }
//
//         foreach (double num in B)
//         {
//             summa += num;
//             prod *= num;
//         }
//         double sumA = 0;
//         foreach (double num in A)
//         {
//             if (num % 2 == 0)
//                 sumA += num;
//         }
//         double sumB = 0;
//         for (int j = 0; j < 4; j++)
//         {
//             if (j % 2 != 0)
//             {
//                 for (int i = 0; i < 3; i++)
//                 {
//                     sumB += B[i, j];
//                 }
//             }
//         }
//         Console.WriteLine($"Maximum element in array A: {maxA}");
//         Console.WriteLine($"Minimum element in array A: {minA}");
//         Console.WriteLine($"Maximum element in array B: {maxB}");
//         Console.WriteLine($"Minimum element in array B: {minB}");
//         Console.WriteLine($"Total sum of all elements: {summa}");
//         Console.WriteLine($"Total product of all elements: {prod}");
//         Console.WriteLine($"Sum of even elements in array A: {sumA}");
//         Console.WriteLine($"Sum of elements in odd columns of array B: {sumB}");
//     }
// }
//
//task2
// int[,] array = new int[5, 5];
// Random rand = new Random();
// Console.WriteLine("Array:");
// for (int i = 0; i < 5; i++)
// {
//     for (int j = 0; j < 5; j++)
//     {
//         array[i, j] = rand.Next(-100, 101);
//         Console.Write($"{array[i, j],4}\t");
//     }
//     Console.WriteLine();
// }
// int mine = array[0, 0];
// int maxe = array[0, 0];
// int minr = 0, minc = 0, maxr = 0, maxc = 0;
//
// for (int i = 0; i < 5; i++)
// {
//     for (int j = 0; j < 5; j++)
//     {
//         if (array[i, j] < mine)
//         {
//             mine = array[i, j];
//             minr = i;
//             minc = j;
//         }
//
//         if (array[i, j] > maxe)
//         {
//             maxe = array[i, j];
//             maxr = i;
//             maxc = j;
//         }
//     }
// }
// Console.WriteLine($"\nMin: {mine} {minr + 1},{minc + 1}");
// Console.WriteLine($"Max: {maxe} {maxr + 1},{maxc + 1}");
// int sum_min_max = 0;
// int star = Math.Min(minr, maxr) + 1;
// int end = Math.Max(minr, maxr);
// int start = Math.Min(minc, maxc) + 1;
// int endc = Math.Max(minc, maxc);
//
// for (int i = star; i < end; i++)
// {
//     for (int j = start; j < endc; j++)
//     {
//         sum_min_max += array[i, j];
//     }
// }
// Console.WriteLine($"sum between min and max: {sum_min_max}");
//

// task3

// task4
// int[,] array = new int[3, 3] { { 3, 6, 2 }, { 2, 7, 8 }, { 4, 1, 5 } };
//
// for (int i = 0; i < 3; i++)
// {
//     for (int j = 0; j < 3; j++)
//     {
//         Console.Write($"{array[i, j]} \t");
//     }
//
//     Console.WriteLine();
// }
//
// int choice = 0;
// do
// {
//     Console.WriteLine("Enter what to do: \n" +
//                       "1. Multiplication of a matrix by a number \n" +
//                       "2. Matrix addition \n" +
//                       "3. Product of matrices \n" +
//                       "4. End program \n");
//     choice = Int32.Parse(Console.ReadLine());
//
//     if (choice == 1)
//     {
//         Console.WriteLine("Enter number to multiply: ");
//         int multnums = Int32.Parse(Console.ReadLine());
//
//         Console.WriteLine("Matrix after multiplication: \n");
//         for (int i = 0; i < 3; i++)
//         {
//             for (int j = 0; j < 3; j++)
//             {
//                 array[i, j] *= multnums;
//                 Console.Write($"{array[i, j]} \t");
//             }
//             Console.WriteLine();
//         }
//     }
//     else if (choice == 2)
//     {
//         int[,] araaytosum = new int[3, 3] { { 2, 1, 4 }, { 3, 3, 3 }, { 5, 9, 1 } };
//         int[,] arrayres = new int[3, 3];
//
//         Console.WriteLine("Matrix after addition: \n");
//         for (int i = 0; i < 3; i++)
//         {
//             for (int j = 0; j < 3; j++)
//             {
//                 arrayres[i, j] = array[i, j] + araaytosum[i, j];
//                 Console.Write($"{arrayres[i, j]} \t");
//             }
//
//             Console.WriteLine();
//         }
//     }
//     else if (choice == 3)
//     {
//         int[,] arraytomult = new int[3, 3] { { 5, 4, 3 }, { 1, 2, 3 }, { 9, 8, 5 } };
//         int[,] arraytores = new int[3, 3];
//
//         Console.WriteLine("Matrix after multiplication: \n");
//         for (int i = 0; i < 3; i++)
//         {
//             for (int j = 0; j < 3; j++)
//             {
//                 arraytores[i, j] = array[i, j] * arraytomult[i, j];
//                 Console.Write($"{arraytores[i, j]} \t");
//             }
//
//             Console.WriteLine();
//         }
//     }
//     else if (choice == 4)
//     {
//         break;
//     }
//
// } while (choice != 4);


// task5
// class Program
// {
//     static int CalcExample(string example)
//     {
//         int result = 0;
//         char operation = '+';
//         int nums = 0;
//
//         for (int i = 0; i < example.Length; i++)
//         {
//             char ch = example[i];
//
//             switch (ch)
//             {
//                 case var _ when char.IsDigit(ch):
//                     nums = ch - '0';
//                     break;
//                 case '+':
//                 case '-':
//                     if (operation == '+')
//                     {
//                         result += nums;
//                     }
//                     else if (operation == '-')
//                     {
//                         result -= nums;
//                     }
//
//                     nums = 0;
//                     operation = ch;
//                     break;
//             }
//         }
//         if (operation == '+')
//         {
//             result += nums;
//         }
//         else if (operation == '-')
//         {
//             result -= nums;
//         }
//
//         return result;
//     }
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Add example: ");
//         string example = Console.ReadLine();
//         int result = CalcExample(example);
//         Console.WriteLine(result);
//     }
// }
// taks6
// class Program
// {
//     static string Capslock(string text)
//     {
//         string[] parts = text.Split(new[] { '.', '!', '?',':'}, StringSplitOptions.RemoveEmptyEntries);
//         for (int i = 0; i < parts.Length; i++)
//         {
//             parts[i] = char.ToUpper(parts[i][0]) + parts[i].Substring(1);
//         }
//         return string.Join(". ", parts);
//     }
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Enter your sentence: ");
//         string text = Console.ReadLine();
//         string result = Capslock(text);
//         
//         Console.WriteLine(result);
//     }
//     
// }
// task 7
// string text = "To be, or not to be, that is the question,\n" +
//               "Whether 'tis nobler in the mind to suffer\n" +
//               "The slings and arrows of outrageous fortune,\n" +
//               "Or to take arms against a sea of troubles,\n" +
//               "And by opposing end them? To die: to sleep;\n" +
//               "No more; and by a sleep to say we end\n" +
//               "The heart-ache and the thousand natural shocks\n" +
//               "That flesh is heir to, 'tis a consummation\n" +
//               "Devoutly to be wish'd. To die, to sleep";
// List<string> wordToReplace = new List<string> { "die" };
// int count = 0;
// string[] words = text.Split(new[] { ' ', '.', ',', '!', '?', ':', ';' },StringSplitOptions.RemoveEmptyEntries);
// for (int i = 0; i < words.Length; i++)
// {
//     if (wordToReplace.Contains(words[i].ToLower()))
//     {
//         words[i] = new string('*', words[i].Length);
//         count++;
//     }
// }
// string newtext = string.Join(" ", words);
// Console.WriteLine("Refreshed text: ");
// Console.WriteLine(newtext);
// Console.WriteLine("Replaced words: " + count);
