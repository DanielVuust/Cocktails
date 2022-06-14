using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails.Objects
{
    public class Drink
    {
        public int DrinkId { get; set; }

        public string DrinkName { get; set; }
        public double DrinkPrice { get; set; }
        public ICollection<Ingredient> DrinkIngredients { get; set; }
        public ICollection<Ingredient> DrinkGarnish { get; set; }
        public DrinkGlass DrinkGlass { get; set; }
    }
}
