using Cocktails.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails.DataAction.CreateElement
{
    class NewIngredientTypeDataAction : IDrinkDataAction
    {
        public void ExecuteAction()
        {
            Console.WriteLine("Write Ingredient type");
            string IngredientTypeName = Console.ReadLine();
            AddNewIngredientTypeManager addNewIngredientTypeManager = new AddNewIngredientTypeManager(IngredientTypeName);
            addNewIngredientTypeManager.AddNewElement();

        }
    }
}
