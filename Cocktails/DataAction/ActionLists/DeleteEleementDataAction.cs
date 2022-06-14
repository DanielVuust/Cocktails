
using Cocktails.DataAction.DeleteElements;
using Cocktails.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails.DataAction.ActionLists
{
    public class DeleteEleementDataAction
    {
        public Dictionary<string, IDrinkDataAction> AllCreateElementActions = new Dictionary<string, IDrinkDataAction>
        {
            { "Drink", null },
            { "Drink glass", null },
            { "Ingredient", null },
            { "Ingredient type", null },
            { "Unit", new DeleteUnitDataAction() }
        };
    }
}
