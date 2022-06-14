using Cocktails.Interfaces;
using Cocktails.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails.DataAction.DeleteElements
{
    class DeleteUnitDataAction : IDrinkDataAction
    {
        public void ExecuteAction()
        {
            DataList dataList = new DataList();
            List<Unit> units = dataList.GetAllUnits().ToList();
            for(int i = 0; i < units.Count;i++)
            {
                Console.WriteLine(i + ". " + units[i].UnitType);
            }
            Console.WriteLine("Choose a unit to delete");
            int action = Convert.ToInt32(Console.ReadLine());

            DeleteUnitManager deleteUnitManager = new DeleteUnitManager(units[action]);
            deleteUnitManager.DeleteUnit();
        }
    }
}
