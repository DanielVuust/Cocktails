using System;
using System.Collections.Generic;
using System.Linq;
using Cocktails.DataAction;
using Cocktails.Objects;

namespace Cocktails
{
    class Program
    {
        static void Main(string[] args)
        {
            //CreateDataObjects createDataObjects = new CreateDataObjects();

            while (true)
            {
                Console.Clear();
                DisplayActions displayDrinkActions = new DisplayActions();
                displayDrinkActions.DisplayAllDrinkActions();

                string action = Console.ReadLine();

                ChooseAction chooseAction = new ChooseAction();
                chooseAction.GetAction(action).ExecuteAction();


                Console.WriteLine("Hello World!");

            }


        }
    }
}
