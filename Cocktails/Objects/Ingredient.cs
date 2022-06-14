using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails.Objects
{
    public class Ingredient
    {
        public int IngredientId { get; set; }
        public int IngredientAmount { get; set; }
        public IngredientType IngredientType { get; set; }
        public Unit Unit { get; set; }
    }
}
