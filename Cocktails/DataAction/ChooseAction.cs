using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cocktails.DataAction.ActionLists;
using Cocktails.Interfaces;

namespace Cocktails.DataAction
{
    public class ChooseAction
    {
        public IDrinkDataAction GetAction(string input)
        {
            int intInput = Convert.ToInt32(input);
            return new DrinkDataAction().AllDrinkDataAction.ElementAt(intInput).Value;
        }
        public IDrinkDataAction GetCreateElementAction(string input)
        {
            int intInput = Convert.ToInt32(input);
            return new CreateElementDataAction().AllCreateElementActions.ElementAt(intInput).Value;
        }
        public IDrinkDataAction GetDeleteElementAction(string input)
        {
            int intInput = Convert.ToInt32(input);
            return new DeleteEleementDataAction().AllCreateElementActions.ElementAt(intInput).Value;
        }
    }
}
