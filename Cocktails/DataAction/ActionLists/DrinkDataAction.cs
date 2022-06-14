using Cocktails.DataAction.CreateElement;
using Cocktails.DataAction.MainActions;
using Cocktails.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails.DataAction
{
    public class DrinkDataAction
    {
        public Dictionary<string, IDrinkDataAction> AllDrinkDataAction = new Dictionary<string, IDrinkDataAction>
        {
            { "Create new element", new CreateNewElement() },
            { "Delete element", new DeleteElement() },
            { "Edit element", new EditElement() }
            
        };
    }
}
