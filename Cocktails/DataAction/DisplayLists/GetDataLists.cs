using Cocktails.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails.DataAction.DisplayLists
{
    public class GetDataLists
    {
        public List<Unit> GetAllUnits()
        {
            using (Context con = new Context())
            {
                return con.Units.ToList();
            }
        }
        public List<IngredientType> GetAllIngredientTypes()
        {
            using (Context con = new Context())
            {
                return con.IngredientTypes.ToList();
            }
        }
        public List<Ingredient> GetAllIngredients()
        {
            using (Context con = new Context())
            {
                return con.Ingredients.ToList();
            }
        }
        public List<DrinkGlass> GetAllDrinkGlasses()
        {
            using (Context con = new Context())
            {
                return con.Glasses.ToList();
            }
        }
        public List<Drink> GetAllDrinks()
        {
            using (Context con = new Context())
            {
                return con.Drinks.ToList();
            }
        }
    }
}
