using Cocktails.DataAction.DisplayLists;
using Cocktails.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails.DataAction
{
    public class DataList
    {
        public List<Unit> GetAllUnits()
        {
            return new GetDataLists().GetAllUnits();
        }
        public List<IngredientType> GetAllIngredientTypes()
        {
            return new GetDataLists().GetAllIngredientTypes();
        }
        public List<Ingredient> GetAllIngredients()
        {
            return new GetDataLists().GetAllIngredients();
        }
        public List<DrinkGlass> GetAllDrinkGlasses()
        {
            return new GetDataLists().GetAllDrinkGlasses();
        }
        public List<Drink> GetAllDrinks()
        {
            return new GetDataLists().GetAllDrinks();
        }
    }
}
