using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fly;
class Cola : IDrink
{
    private string Brand;

    public Cola(string brand)
    {
        Brand = brand;
    }

    public void Pour(int amount)
    {
        Console.WriteLine($"Pouring {amount} ml of {Brand} Cola");
    }
}
