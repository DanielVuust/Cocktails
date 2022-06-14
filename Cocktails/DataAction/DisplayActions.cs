using Cocktails.DataAction.ActionLists;
using Cocktails.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails.DataAction
{
    public class DisplayActions
    {
        public void DisplayAllDrinkActions()
        {
            Dictionary<string, IDrinkDataAction> drinkDataActions = new DrinkDataAction().AllDrinkDataAction;
            DisplayAllInDictionary displayAllInDictionary = new DisplayAllInDictionary();
            displayAllInDictionary.Display(drinkDataActions);
        }
        public void DisplayCreateableElements()
        {
            Dictionary<string, IDrinkDataAction> createElementDataAction = new CreateElementDataAction().AllCreateElementActions;
            DisplayAllInDictionary displayAllInDictionary = new DisplayAllInDictionary();
            displayAllInDictionary.Display(createElementDataAction);
        }
        public void DisplayDeletableElemnts()
        {
            Dictionary<string, IDrinkDataAction> deletableElementDataAction = new DeleteEleementDataAction().AllCreateElementActions;
            DisplayAllInDictionary displayAllInDictionary = new DisplayAllInDictionary();
            displayAllInDictionary.Display(deletableElementDataAction);
        }
    }
}
