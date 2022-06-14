using Cocktails.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails.DataAction.MainActions
{
    public class DeleteElement : IDrinkDataAction
    {
        public void ExecuteAction()
        {
            DisplayActions displayActions = new DisplayActions();
            displayActions.DisplayDeletableElemnts();

            string action = Console.ReadLine();

            ChooseAction chooseAction = new ChooseAction();
            chooseAction.GetDeleteElementAction(action).ExecuteAction();

        }
    }
}
