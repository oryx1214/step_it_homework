using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fly;
class DrinkFactory
{
    private Dictionary<string, IDrink> drink = new Dictionary<string, IDrink>();

    public IDrink GetCola(string brand)
    {
        if (!drink.ContainsKey(brand))
        {
            drink[brand] = new Cola(brand);
        }
        return drink[brand];
    }
}