// class Journal
// {
//     private string title;
//     private int year;
//     private string description;
//     private string phone;
//     private string email;
//     private int empl_number; 
//
//     public int EmplNumber
//     {
//         get { return empl_number; }
//         set { empl_number = value; }
//     }
//
//     public void InputData(string title, int year, string description, string phoneNumber, string email, int numberOfEmployees)
//     {
//         this.title = title;
//         this.year = year;
//         this.description = description;
//         this.phone = phoneNumber;
//         this.email = email;
//         this.empl_number = numberOfEmployees;
//     }
//
//     public void DisplayData()
//     {
//         Console.WriteLine($"Journal Title: {title}");
//         Console.WriteLine($"Year: {year}");
//         Console.WriteLine($"Description: {description}");
//         Console.WriteLine($"Phone: {phone}");
//         Console.WriteLine($"Email: {email}");
//         Console.WriteLine($"Number of Employees: {empl_number}");
//     }
//
//     public static Journal operator +(Journal journal, int addEmployees)
//     {
//         journal.empl_number += addEmployees;
//         return journal;
//     }
//
//     public static Journal operator -(Journal journal, int removeEmployees)
//     {
//         journal.empl_number -= removeEmployees;
//         if (journal.empl_number < 0)
//         {
//             journal.empl_number = 0;
//         }
//         return journal;
//     }
//
//     public static bool operator ==(Journal journal1, Journal journal2)
//     {
//         return journal1.empl_number == journal2.empl_number;
//     }
//
//     public static bool operator !=(Journal journal1, Journal journal2)
//     {
//         return journal1.empl_number != journal2.empl_number;
//     }
//
//     public static bool operator <(Journal journal1, Journal journal2)
//     {
//         return journal1.empl_number < journal2.empl_number;
//     }
//
//     public static bool operator >(Journal journal1, Journal journal2)
//     {
//         return journal1.empl_number > journal2.empl_number;
//     }
//
//     public override bool Equals(object obj)
//     {
//         if (obj == null || GetType() != obj.GetType())
//         {
//             return false;
//         }
//         Journal otherJournal = (Journal)obj;
//         return this.empl_number == otherJournal.empl_number;
//     }
//
//     public override int GetHashCode()
//     {
//         return empl_number.GetHashCode();
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         Journal journal1 = new Journal();
//         Journal journal2 = new Journal();
//
//         Console.WriteLine("Enter information for the first journal:");
//         Console.Write("Journal Title: ");
//         string title1 = Console.ReadLine();
//         Console.Write("Year of Foundation: ");
//         int year1 = int.Parse(Console.ReadLine());
//         Console.Write("Description: ");
//         string description1 = Console.ReadLine();
//         Console.Write("Phone Number: ");
//         string phone1 = Console.ReadLine();
//         Console.Write("Email: ");
//         string email1 = Console.ReadLine();
//         Console.Write("Number of Employees: ");
//         int employees1 = int.Parse(Console.ReadLine());
//
//         Console.WriteLine("Enter information for the second journal:");
//         Console.Write("Journal Title: ");
//         string title2 = Console.ReadLine();
//         Console.Write("Year of Foundation: ");
//         int year2 = int.Parse(Console.ReadLine());
//         Console.Write("Description: ");
//         string description2 = Console.ReadLine();
//         Console.Write("Phone Number: ");
//         string phone2 = Console.ReadLine();
//         Console.Write("Email: ");
//         string email2 = Console.ReadLine();
//         Console.Write("Number of Employees: ");
//         int employees2 = int.Parse(Console.ReadLine());
//
//         journal1.InputData(title1, year1, description1, phone1, email1, employees1);
//         journal2.InputData(title2, year2, description2, phone2, email2, employees2);
//  
//         Console.WriteLine("\nInformation for the first journal:");
//         journal1.DisplayData();
//         Console.WriteLine("\nInformation for the second journal:");
//         journal2.DisplayData();
//         
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
//     private double area; 
//
//     public double Area
//     {
//         get { return area; }
//         set { area = value; }
//     }
//
//     public void input(string name, string address, string description, string phone, string email, double area)
//     {
//         this.name = name;
//         this.address = address;
//         this.description = description;
//         this.phone = phone;
//         this.email = email;
//         this.area = area;
//     }
//
//     public void info()
//     {
//         Console.WriteLine($"Store Name: {name}");
//         Console.WriteLine($"Address: {address}");
//         Console.WriteLine($"Description: {description}");
//         Console.WriteLine($"Phone: {phone}");
//         Console.WriteLine($"Email: {email}");
//         Console.WriteLine($"Area: {area} sq. ft");
//     }
//
//     public static Store operator +(Store store, double increase)
//     {
//         store.Area += increase;
//         return store;
//     }
//
//     public static Store operator -(Store store, double decrease)
//     {
//         store.Area -= decrease;
//         return store;
//     }
//
//     public static bool operator ==(Store store1, Store store2)
//     {
//         return store1.Area == store2.Area;
//     }
//
//     public static bool operator !=(Store store1, Store store2)
//     {
//         return store1.Area != store2.Area;
//     }
//
//     public static bool operator <(Store store1, Store store2)
//     {
//         return store1.Area < store2.Area;
//     }
//
//     public static bool operator >(Store store1, Store store2)
//     {
//         return store1.Area > store2.Area;
//     }
//
//     public override bool Equals(object obj)
//     {
//         if (obj is Store otherStore)
//         {
//             return this.Area == otherStore.Area;
//         }
//         return false;
//     }
//
//     public override int GetHashCode()
//     {
//         return Area.GetHashCode();
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         Store store1 = new Store();
//         Store store2 = new Store();
//
//         Console.Write("Enter store 1 name: ");
//         string name1 = Console.ReadLine();
//         Console.Write("Enter address: ");
//         string address1 = Console.ReadLine();
//         Console.Write("Enter store 1 description: ");
//         string description1 = Console.ReadLine();
//         Console.Write("Enter contact phone: ");
//         string phone1 = Console.ReadLine();
//         Console.Write("Enter contact email: ");
//         string email1 = Console.ReadLine();
//         Console.Write("Enter store 1 area (sq. ft): ");
//         double area1 = double.Parse(Console.ReadLine());
//
//         Console.Write("Enter store 2 name: ");
//         string name2 = Console.ReadLine();
//         Console.Write("Enter address: ");
//         string address2 = Console.ReadLine();
//         Console.Write("Enter store 2 description: ");
//         string description2 = Console.ReadLine();
//         Console.Write("Enter contact phone: ");
//         string phone2 = Console.ReadLine();
//         Console.Write("Enter contact email: ");
//         string email2 = Console.ReadLine();
//         Console.Write("Enter store 2 area (sq. ft): ");
//         double area2 = double.Parse(Console.ReadLine());
//
//         store1.input(name1, address1, description1, phone1, email1, area1);
//         store2.input(name2, address2, description2, phone2, email2, area2);
//
//         Console.WriteLine("\nStore 1 information:");
//         store1.info();
//
//         Console.WriteLine("\nStore 2 information:");
//         store2.info();
//
//         store1 += 100; 
//         store2 -= 50;  
//
//         Console.WriteLine($"\nStore 1 Area after increase: {store1.Area} sq. ft");
//         Console.WriteLine($"Store 2 Area after decrease: {store2.Area} sq. ft");
//
//         if (store1 == store2)
//         {
//             Console.WriteLine("\nStore 1 and store 2 have the same area.");
//         }
//         else if (store1 < store2)
//         {
//             Console.WriteLine("\nStore 1 has a smaller area than store 2.");
//         }
//         else
//         {
//             Console.WriteLine("\nStore 1 has a larger area than store 2.");
//         }
//         
//         if (store1 != store2)
//         {
//             Console.WriteLine("\nStore 1 and store 2 have different areas.");
//         }
//
//         Console.ReadKey();
//     }
// }
