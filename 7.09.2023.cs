// first


// static void decimal_to_binary()
// {
//     Console.WriteLine("Enter number for convert from decimal to binary: ");
//     if (!int.TryParse(Console.ReadLine(), out int decimal_num))
//     {
//         Console.WriteLine("Error,invalid number");
//         return;
//     }
//
//     string bin_num = Convert.ToString(decimal_num);
//     Console.WriteLine(bin_num);
//
// }
//
// void binary_to_decimal()
// {
//     Console.WriteLine("Enter number to convert from binary to decimal: ");
//     string bin_num = Console.ReadLine();
//
//
//     if (!binary(bin_num))
//     {
//         Console.WriteLine("Error,invalid number");
//         return;
//     }
//
//     int decimal_num = Convert.ToInt32(bin_num);
//     Console.WriteLine(decimal_num);
// }
//
// static bool binary(string str)
// {
//     for (int i = 0; i < str.Length; i++)
//     {
//         char chr = str[i];
//         if (chr != '0' && chr != '1')
//         {
//             return false;
//         }
//     }
//
//     return true;
// }
// Console.WriteLine("Select your operation:\n" +
//                   "1.Decimal to binary\n" +
//                   "2.Binary to decimal");
//
// if (int.TryParse(Console.ReadLine(), out int choice))
// {
//     if (choice == 1)
//     {
//         decimal_to_binary();
//     }
//     else if (choice == 2)
//     {
//         binary_to_decimal();
//     }
//     else
//     {
//         Console.WriteLine("Error,invalid choice");
//     }
// }
// else
// {
//     Console.WriteLine("Error,invalid number");
// }

// second

// string[] numbers = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
// Console.WriteLine("Choose one number from zero to nine: ");
// string choice = Console.ReadLine();
// bool error_founder = false;
// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] == choice)
//     {
//         Console.WriteLine(i);
//         error_founder = true; 
//         break;
//     }
// }
// if (!error_founder)
// {
//     Console.WriteLine("Error, invalid choice");
// }

// third


// class Passport
// {
//     private string Passport_number;
//     private string Surname;
//     private DateTime Give_date;
//
//     public Passport(string passport_number, string surname, DateTime giveDate)
//     {
//         if (string.IsNullOrEmpty(passport_number) || passport_number.Length != 9)
//         {
//             throw new ArgumentException("Invalid passport number");
//         }
//
//         if (string.IsNullOrEmpty(surname))
//         {
//             throw new ArgumentException("Invalid SNL");
//         }
//
//         if (giveDate > DateTime.Now)
//         {
//             throw new ArgumentException("Date cant be greater than now date");
//         }
//
//         this.Passport_number = passport_number;
//         this.Surname = surname;
//         this.Give_date = giveDate;
//     }
//     public string PassportNumber
//     {
//         get { return Passport_number; }
//     }
//
//     public string Full_name
//     {
//         get { return Surname; }
//     }
//
//     public DateTime GiveDate
//     {
//         get { return Give_date; }
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         try
//         {
//             Passport passport = new Passport("AA1234567", "Mammadov Anvar Ali Bala", new DateTime(2022, 1, 15));
//             
//             // Доступ к данным
//             Console.WriteLine("Passport number: " + passport.PassportNumber);
//             Console.WriteLine("SNL: " + passport.Full_name);
//             Console.WriteLine("Give date: " + passport.GiveDate.ToShortDateString());
//         }
//         catch (ArgumentException ex)
//         {
//             Console.WriteLine("Error in passport creation. " + ex.Message);
//         }
//     }
// }





