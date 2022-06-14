using Cocktails.DataAction.CreateElement;
using Cocktails.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails.DataAction
{
    public class CreateElementDataAction
    {
        public Dictionary<string, IDrinkDataAction> AllCreateElementActions= new Dictionary<string, IDrinkDataAction>
        {
            { "Drink", null },
            { "Drink glass", null },
            { "Ingredient", null },
            { "Ingredient type", new NewIngredientTypeDataAction() },
            { "Unit", new NewUnitDataAction() }
        };
    }
}
