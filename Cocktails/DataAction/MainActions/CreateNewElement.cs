using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cocktails.Interfaces;

namespace Cocktails.DataAction
{
    public class CreateNewElement : IDrinkDataAction
    {
        public void ExecuteAction()
        {
            DisplayActions displayActions = new DisplayActions();
            displayActions.DisplayCreateableElements();

            string action = Console.ReadLine();

            ChooseAction chooseAction = new ChooseAction();
            chooseAction.GetCreateElementAction(action).ExecuteAction();
        }
    }
}
