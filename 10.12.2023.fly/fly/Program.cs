// See https://aka.ms/new-console-template for more information
using fly;

class Program
{
    static void Main()
    {
        DrinkFactory drinkFactory = new DrinkFactory();

        IDrink Ccola = drinkFactory.GetCola("Coca");
        IDrink pepsi = drinkFactory.GetCola("Pepsi");
        IDrink drPepper = drinkFactory.GetCola("Dr. Pepper");
        Ccola.Pour(500);
        pepsi.Pour(450);
        drPepper.Pour(300);
        IDrink anotherCocaCola = drinkFactory.GetCola("Coca");
        anotherCocaCola.Pour(300);
    }
}