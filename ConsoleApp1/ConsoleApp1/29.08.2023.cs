//task 1

/*
Console.WriteLine("choose your number from 1 to 100");
if (int.TryParse(Console.ReadLine(), out int number))
{
    if (number >= 1 & number <= 100)
    {
        if (number % 3 == 0 && number % 5 == 0)
        {
            Console.Write("Fizz Buzz");
        }
        else if (number % 3 == 0)
        {
            Console.Write("Fizz");
        }
        else if (number % 5 == 0)
        {
            Console.Write("Buzz");
        }

        else if (number % 3 != 0 && number % 5 != 0)
        {
            Console.Write(number);
        }
    }
    else
    {
        Console.Write("Error,wrong number");
    }
}*/

//task 2

/*
Console.Write("Enter number: ");
double value = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter percent: ");
double percent = Convert.ToDouble(Console.ReadLine());

double result = (percent * value) / 100;

Console.WriteLine($"Result: {result}");
*/

//task 3

/*
Console.WriteLine("enter first number: ");
string first_num = Convert.ToString(Console.ReadLine());

Console.WriteLine("enter second number: ");
string second_num = Convert.ToString(Console.ReadLine());

Console.WriteLine("enter third number: ");
string third_num = Convert.ToString(Console.ReadLine());

Console.WriteLine("enter fourth number: ");
string fourth_num = Convert.ToString(Console.ReadLine());

string res =(first_num + second_num + third_num + fourth_num);
Console.WriteLine($"Result: {res}");
*/

//task4

/*
int new_array;
int result;
int[] arr = new int[6];
int[] change = new int[2];
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine($"Enter your number {i + 1} : ");
    arr[i] = int.Parse(Console.ReadLine());
}
for (int j = 0; j < change.Length; j++)
{
    Console.Write($"Choose which numbers you want to change {j + 1} : ");
    change[j] = int.Parse(Console.ReadLine());
}
new_array = arr[change[0] - 1];
arr[change[0] - 1] = arr[change[1] - 1];
arr[change[1] - 1] = new_array;
result = arr[0] * 100000 + arr[1] * 10000 + arr[2] * 1000 + arr[3] * 100 + arr[4] * 10 + arr[5];
Console.WriteLine($"Result: {result}");*/

//task 5


//task 6

/*int choose;
double degree;

Console.WriteLine("Enter degree: ");
degree = double.Parse(Console.ReadLine());

Console.WriteLine("Select operation: \n1. Celsius to Fahrenheit\n2. Fahrenheit to Celsius \n");
choose = int.Parse(Console.ReadLine());

if (choose == 1)
{
    degree = degree * 1.8d + 32;
    Console.WriteLine($"{(int)degree} Fahrenheit");
}
else if (choose == 2)
{
    degree = (degree - 32) / 1.8d;
    Console.WriteLine($"{(int)degree} Celsius");
}
else
{
    Console.WriteLine("Unknown choise;");
}*/

//task 7

/*int first_num;
int second_num;
int middle;

Console.Write("Enter fist number: ");
first_num = int.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
second_num = int.Parse(Console.ReadLine());
if (first_num > second_num)
{
    first_num = second_num;
    middle = first_num;
    second_num = middle;
}
for (int i = first_num; i < second_num; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}*/
