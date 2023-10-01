// public interface ICalc
// {
//     int Less(int value);
//     int Greater(int value);
// }
// public class Array : ICalc
// {
//     private int[] elements;
//     public Array(int[] initial)
//     {
//         elements = initial;
//     }
//     public int Less(int value)
//     {
//         int count = 0;
//         for (int i = 0; i < elements.Length; i++)
//         {
//             if (elements[i] < value)
//             {
//                 count++;
//             }
//         }
//         return count;
//     }
//     public int Greater(int value)
//     {
//         int count = 0;
//         for (int i = 0; i < elements.Length; i++)
//         {
//             if (elements[i] > value)
//             {
//                 count++;
//             }
//         }
//         return count;
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         int[] elements = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//         Array array = new Array(elements);
//         int lessCount = array.Less(5);
//         int greaterCount = array.Greater(5);
//         Console.WriteLine($"Count of elements less than 5: {lessCount}");
//         Console.WriteLine($"Count of elements greater than 5: {greaterCount}");
//     }
// }
// task2
// public interface IOutput2
// {
//     void ShowEven();
//     void ShowOdd();
// }
// public class Array : Icalc, IOutput2
// {
//     private int[] elements;
//     public Array(int[] initial)
//     {
//         elements = initial;
//     }
//     public int Less(int value)
//     {
//         int count = 0;
//         for (int i = 0; i < elements.Length; i++)
//         {
//             if (elements[i] < value)
//             {
//                 count++;
//             }
//         }
//         return count;
//     }
//     public int Greater(int value)
//     {
//         int count = 0;
//         for (int i = 0; i < elements.Length; i++)
//         {
//             if (elements[i] > value)
//             {
//                 count++;
//             }
//         }
//         return count;
//     }
//     public void ShowEven()
//     {
//         Console.WriteLine("Even numbers:");
//         for (int i = 0; i < elements.Length; i++)
//         {
//             if (elements[i] % 2 == 0)
//             {
//                 Console.Write($"{elements[i]} ");
//             }
//         }
//         Console.WriteLine();
//     }
//     public void ShowOdd()
//     {
//         Console.WriteLine("Odd numbers:");
//         for (int i = 0; i < elements.Length; i++)
//         {
//             if (elements[i] % 2 != 0)
//             {
//                 Console.Write($"{elements[i]} ");
//             }
//         }
//         Console.WriteLine();
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//         Array array = new Array(numbers);
//         Console.WriteLine("Original array:");
//         array.ShowEven();
//         array.ShowOdd();
//     }
// }
//

