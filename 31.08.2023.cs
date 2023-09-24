// void square(char symbol, int length)
// {
//     for (int i = 0; i < length; i++)
//     {
//         for (int j = 0; j < length; j++)
//         {
//             Console.Write(symbol);
//         }
//
//         Console.WriteLine();
//     }
// }
// Console.WriteLine("select symbol: ");
// char symbol = char.Parse(Console.ReadLine());
// Console.WriteLine("choose length of square: ");
// int length = int.Parse(Console.ReadLine());
// square(symbol,length);



// second

// static bool PAlindrome(int number)
// {
//     string str = number.ToString();
//     int first = 0;
//     int second = str.Length - 1;
//     for (; first < second; first++, second--)
//     {
//         if (str[first] != str[second])
//             return false;
//     }
//     return true;
// }
// Console.Write("Enter number to check for a palindrome: ");
// int number = int.Parse(Console.ReadLine());
// Console.Write(PAlindrome(number));
//






// fourth


// public class Web_site
// {
//     private string Name { get ; set; }
//     private string Path { get ; set; }
//     private string Description { get ; set; }
//     private string IP { get ; set; }
//
//     public void Create()
//     {
//         Console.WriteLine("Enter site name: ");
//         Name = Console.ReadLine();
//         Console.WriteLine("Enter site path: ");
//         Path = Console.ReadLine();
//         Console.WriteLine("Enter site description:");
//         Description = Console.ReadLine();
//         Console.WriteLine("Enter site IP: ");
//         IP = Console.ReadLine();
//     }
//
//     public void Info()
//     {
//         Console.WriteLine("Site name: " + Name);
//         Console.WriteLine("Site path: " + Path);
//         Console.WriteLine("Site description: " + Description);
//         Console.WriteLine("Site IP: " + IP);
//     }
//     
//     
//     public string get_name()
//     {
//         return Name;
//     }
//     public void set_name()
//     {
//         Name = Name;
//     }
//
//     public string get_path()
//     {
//         return Path;
//     }
//     public void set_path()
//     {
//         Path = Path;
//     }
//
//     public string get_description()
//     {
//         return Description;
//     }
//     public void set_description()
//     {
//         Description = Description;
//     }
//
//     public string get_ip()
//     {
//         return IP;
//     }
//
//     public void set_ip()
//     {
//         IP = IP;
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         Web_site WEB_site = new Web_site();
//         WEB_site.Create();
//         
//         WEB_site.Info();
//         
//         
//     }
// }


 // fifth


 // чуток по другому написал
// class Journal
// {
//     private string title;
//     private int year;
//     private string description;
//     private string phone_number;
//     private string email;
//
//     public void SetTitle(string title)
//     {
//         this.title = title;
//     }
//
//     public string GetTitle()
//     {
//         return title;
//     }
//
//     public void set_year(int year)
//     {
//         this.year = year;
//     }
//
//     public int get_year()
//     {
//         return year;
//     }
//
//     public void Set_description(string desc)
//     {
//         description = desc;
//     }
//
//     public string get_description()
//     {
//         return description;
//     }
//
//     public void Set_phone(string phone)
//     {
//         phone_number = phone;
//     }
//
//     public string get_phone()
//     {
//         return phone_number;
//     }
//
//     public void Set_email(string email)
//     {
//         this.email = email;
//     }
//
//     public string get_email()
//     {
//         return email;
//     }
//
//     public void info()
//     {
//         Console.Write("Enter journal name: ");
//         title = Console.ReadLine();
//         
//         Console.Write("Enter the year of foundation: ");
//         year = int.Parse(Console.ReadLine());
//
//         Console.Write("Enter the journal description: ");
//         description = Console.ReadLine();
//
//         Console.Write("Enter the contact phone: ");
//         phone_number = Console.ReadLine();
//
//         Console.Write("Enter the contact e-mail: ");
//         email = Console.ReadLine();
//     }
//
//     public void out_info()
//     {
//         Console.WriteLine("Journal Title: " + title);
//         Console.WriteLine("Year of Foundation: " + year);
//         Console.WriteLine("Journal Description: " + description);
//         Console.WriteLine("Contact Phone: " + phone_number);
//         Console.WriteLine("Contact E-mail: " + email);
//     }
// }




using System;

// class Store
// {
//     private string name;
//     private string address;
//     private string description;
//     private string phone;
//     private string email;
//     public void InputData(string name, string address, string description, string phone, string email)
//     {
//         this.name = name;
//         this.address = address;
//         this.description = description;
//         this.phone = phone;
//         this.email = email;
//     }
//     public void DisplayData()
//     {
//         Console.WriteLine($"Store Name: {name}");
//         Console.WriteLine($"Address: {address}");
//         Console.WriteLine($"Description: {description}");
//         Console.WriteLine($"Phone: {phone}");
//         Console.WriteLine($"Email: {email}");
//     }
//     public string Get_name()
//     {
//         return name;
//     }
//     public string get_adress()
//     {
//         return address;
//     }
//     public string get_description()
//     {
//         return description;
//     }
//     public string get_phone()
//     {
//         return phone;
//     }
//     public string get_email()
//     {
//         return email;
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         Store store = new Store();
//         
//         Console.Write("Enter store name: ");
//         string name = Console.ReadLine();
//         Console.Write("Enter address: ");
//         string address = Console.ReadLine();
//         Console.Write("Enter store description: ");
//         string description = Console.ReadLine();
//         Console.Write("Enter contact phone: ");
//         string phone = Console.ReadLine();
//         Console.Write("Enter contact email: ");
//         string email = Console.ReadLine();
//         
//         store.InputData(name, address, description, phone, email);
//         
//         Console.WriteLine("\nStore Information:");
//         store.DisplayData();
//         
//         Console.WriteLine("\nStore Name: " + store.Get_name());
//         Console.WriteLine("Address: " + store.get_adress());
//         Console.WriteLine("Description: " + store.get_description());
//         Console.WriteLine("Phone: " + store.get_phone());
//         Console.WriteLine("Email: " + store.get_email());
//     }
// }