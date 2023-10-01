// class Money
// {
//     private int dollars;
//     private int cents;
//     public Money(int dollars, int cents)
//     {
//         this.dollars = dollars;
//         this.cents = cents;
//     }
//     public void Amount()
//     {
//         Console.WriteLine($"Amount: {dollars} dollars and {cents} cents");
//     }
//     public void SetAmount(int dollars, int cents)
//     {
//         this.dollars = dollars;
//         this.cents = cents;
//     }
//     public int GetDollars()
//     {
//         return dollars;
//     }
//     public int GetCents()
//     {
//         return cents;
//     }
// }
// class Product
// {
//     private string name;
//     private Money price;
//
//     public Product(string name, Money price)
//     {
//         this.name = name;
//         this.price = price;
//     }
//
//     public void Info()
//     {
//         Console.WriteLine($"Product: {name}");
//         price.Amount();
//     }
//     public void Decrease(int dollars, int cents)
//     {
//         int newDollars = price.GetDollars() - dollars;
//         int newCents = price.GetCents() - cents;
//
//         if (newCents < 0)
//         {
//             newDollars -= 1;
//             newCents += 100;
//         }
//
//         price.SetAmount(newDollars, newCents);
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         Money money = new Money(50, 75);
//         money.Amount();
//         money.SetAmount(30, 50);
//         money.Amount();
//         Product product = new Product("Example", new Money(25, 99));
//         product.Info();
//         product.Decrease(10, 50);
//         product.Info();
//     }
// }

// task 2

// tsak 3

//  class MusicalInstrument          // предположим что работодатель сам введет данные ибо я понятия не имею как изобразить звуки инструментов
// {
//     protected string name;
//     protected string characteristics;
//     public MusicalInstrument(string name, string characteristics)
//     {
//         this.name = name;
//         this.characteristics = characteristics;
//     }
//     public virtual void Sound()
//     {
//         Console.WriteLine("Sound of the musical instrument");
//     }
//     public void Show()
//     {
//         Console.WriteLine($"Name of the musical instrument: {name}");
//     }
//     public virtual void Desc()
//     {
//         Console.WriteLine($"Characteristics of the musical instrument: {characteristics}");
//     }
//     public virtual void History()
//     {
//         Console.WriteLine("History of the musical instrument creation");
//     }
// }
// class Violin : MusicalInstrument
// {
//     public Violin(string name, string characteristics) : base(name, characteristics)
//     {
//     }
// }
// class Trombone : MusicalInstrument
// {
//     public Trombone(string name, string characteristics) : base(name, characteristics)
//     {
//     }
// }
// class Ukulele : MusicalInstrument
// {
//     public Ukulele(string name, string characteristics) : base(name, characteristics)
//     {
//     }
// }
// class Cello : MusicalInstrument
// {
//     public Cello(string name, string characteristics) : base(name, characteristics)
//     {
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         Violin violin = new Violin("Violin", "Wooden body, strings");
//         violin.Show();
//         violin.Sound();
//         violin.Desc();
//         violin.History();
//
//         Trombone trombone = new Trombone("Trombone", "Brass instrument, slide");
//         trombone.Show();
//         trombone.Sound();
//         trombone.Desc();
//         trombone.History();
//     }
// }

// task 4
// abstract class Worker
// {
//     public string Name;
//     public Worker(string name)
//     {
//         Name = name;
//     }
//     public abstract void Print();
//
//
// }
// class President : Worker
// {
//     public President(string name) : base(name) {}
//
//     public override void Print()
//     {
//         Console.WriteLine($"President's name: {Name}");
//     }
//     
// }
// class Security : Worker
// {
//     public Security(string name) : base(name) {}
//     
//     public override void Print()
//     {
//         Console.WriteLine($"Security's name: {Name}");
//     }
// }
// class Manager : Worker
// {
//     public Manager(string name) : base(name) {}
//     
//     public override void Print()
//     {
//         Console.WriteLine($"Manager's name: {Name}");
//     }
// }
// class Engineer : Worker
// {
//     public Engineer(string name) : base(name) {}
//     
//     public override void Print()
//     {
//         Console.WriteLine($"Engineer's name: {Name}");
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         Worker worker = new President("Igor");
//         Worker worker2 = new Engineer("Andrey");
//         Worker worker3 = new Manager("Ivan");
//         Worker worker4 = new Security("Vova");
//
//         worker.Print();
//         worker2.Print();
//         worker3.Print();
//         worker4.Print();
//
//     }
// }

