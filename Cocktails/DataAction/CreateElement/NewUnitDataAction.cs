using Cocktails.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails.DataAction.CreateElement
{
    public class NewUnitDataAction : IDrinkDataAction
    {
        public void ExecuteAction()
        {
            Console.WriteLine("Write Unit type");
            string unitType = Console.ReadLine();
            AddNewUnitManager addNewUnit = new AddNewUnitManager(unitType);
            addNewUnit.AddNewElement();

        }
    }
}
